using System;
using Server.Spells.Necromancy;

namespace Server.Mobiles
{
    // Zulu Hotel - Soul Link do Mordrath, the Soulbound.
    //
    // Singleton MonsterAbility. Toda a maquina de fases/invuln/correntes
    // mora aqui, mas o estado da luta (lacaios vivos, fase atual) fica
    // dentro do proprio MordrathTheSoulbound (mais simples do que tabela
    // por boss e mais limpo na hora de inspecionar via [props).
    //
    // Mecanica:
    //   - O gatilho da 1a leva mora em MordrathTheSoulbound.OnDamage (cobre
    //     TODOS os caminhos de dano: melee, ranged, spell, poison tick, etc).
    //     A ability NAO trata mais TakeMelee/TakeSpellDamage no Trigger -
    //     mantemos esses flags so para os hooks AlterDamage continuarem firing.
    //   - Trigger Think (cooldown 500ms):
    //       * Verifica thresholds de HP (50%, 25%) e invoca leva 2/3.
    //       * Emite o pulso de correntes etereas se houver lacaios vivos.
    //       * Detecta abandono: se Phase>0 e boss ficou >60s sem tomar dano,
    //         chama ResetEncounter (mata lacaios, restaura HP, volta Phase=0).
    //   - AlterMeleeDamageFrom / AlterSpellDamageFrom:
    //       * Se IsLinked: dano = 0 + mensagem '*absorbs the blow*' + FX.
    //       * Spell que e NecromancerSpell: dano = 0 SEMPRE (mesmo sem link).
    public class MordrathSoulLinkAbility : MonsterAbility
    {
        public static readonly MordrathSoulLinkAbility Instance = new();

        // Cooldown serve so para o trigger Think (pulso e checagem de fases).
        // TakeDamage triggers sao bypassados em CanTrigger abaixo.
        public override TimeSpan MinTriggerCooldown => TimeSpan.FromMilliseconds(500);
        public override TimeSpan MaxTriggerCooldown => TimeSpan.FromMilliseconds(500);

        public override MonsterAbilityType AbilityType => MonsterAbilityType.MagicalBarrier;

        public override MonsterAbilityTrigger AbilityTrigger =>
            MonsterAbilityTrigger.TakeMeleeDamage |
            MonsterAbilityTrigger.TakeSpellDamage |
            MonsterAbilityTrigger.Think;

        // So aplica cooldown ao Think; demais triggers passam direto.
        // (Padrao copiado de MagicalBarrier.)
        public override bool CanTrigger(BaseCreature source, MonsterAbilityTrigger trigger) =>
            trigger != MonsterAbilityTrigger.Think || base.CanTrigger(source, trigger);

        // Abandonment timeout: 60s sem tomar dano com Phase>0 dispara reset.
        private static readonly TimeSpan AbandonmentTimeout = TimeSpan.FromSeconds(60);

        public override void Trigger(MonsterAbilityTrigger trigger, BaseCreature source, Mobile target)
        {
            if (source is not MordrathTheSoulbound boss || !boss.Alive || boss.Deleted)
            {
                return;
            }

            // Apenas Think faz trabalho aqui. TakeMelee/TakeSpellDamage caem
            // nesse override pra que os flags em AbilityTrigger sigam validos
            // (necessarios para os hooks AlterDamage), mas a logica de "primeiro
            // dano -> SummonWave(1)" mora em boss.OnDamage para cobrir tambem
            // dano ranged, AOE, poison ticks, traps e qualquer outro caminho
            // que nao passe por OnGotMeleeAttack / OnDamageSpell.
            if (trigger == MonsterAbilityTrigger.Think)
            {
                HandleThink(boss);
            }

            base.Trigger(trigger, source, target);
        }

        private static void HandleThink(MordrathTheSoulbound boss)
        {
            // Pulso visual das correntes (so se houver link).
            if (boss.IsLinked)
            {
                boss.PulseSoulChains();
            }

            var hits = boss.Hits;
            var hitsMax = boss.HitsMax;

            if (hitsMax <= 0)
            {
                return;
            }

            // Detecta abandono: se ja iniciou a luta (Phase>0) e ficou muito
            // tempo sem tomar dano, considera que o player desistiu/morreu/
            // deslogou. Reseta o boss pro estado inicial e recoloca em standby.
            if (boss.Phase > 0 && Core.Now - boss.LastDamageTime > AbandonmentTimeout)
            {
                boss.ResetEncounter();
                return;
            }

            // Thresholds: 50% para fase 2, 25% para fase 3.
            // So invoca a proxima leva se a anterior ja morreu (link inativo),
            // evitando o caso "duas levas vivas ao mesmo tempo".
            if (boss.Phase == 1 && !boss.IsLinked && hits * 2 <= hitsMax)
            {
                boss.SummonWave(2);
            }
            else if (boss.Phase == 2 && !boss.IsLinked && hits * 4 <= hitsMax)
            {
                boss.SummonWave(3);
            }
        }

        public override void AlterMeleeDamageFrom(BaseCreature source, Mobile target, ref int damage)
        {
            if (source is not MordrathTheSoulbound boss)
            {
                return;
            }

            if (boss.IsLinked)
            {
                damage = 0;
                ShowAbsorb(boss, target);
            }
        }

        public override void AlterSpellDamageFrom(BaseCreature source, Mobile target, ref int damage)
        {
            if (source is not MordrathTheSoulbound boss)
            {
                return;
            }

            // Imunidade permanente a magias do necrobook (com ou sem link).
            if (target?.Spell is NecromancerSpell)
            {
                damage = 0;
                ShowNecroNullify(boss, target);
                return;
            }

            if (boss.IsLinked)
            {
                damage = 0;
                ShowAbsorb(boss, target);
            }
        }

        private static void ShowAbsorb(MordrathTheSoulbound boss, Mobile attacker)
        {
            // FX leve no boss e mensagem em overhead. Hue 0x47E (roxo eldritch)
            // combina com a estetica das correntes.
            boss.FixedParticles(0x376A, 1, 14, 0x251F, 0x47E, 0, EffectLayer.Waist);
            boss.PublicOverheadMessage(MessageType.Emote, 0x47E, false, "*absorbs the blow*");
            attacker?.SendMessage(0x47E, "The soulbound chains drain your attack.");
        }

        private static void ShowNecroNullify(MordrathTheSoulbound boss, Mobile attacker)
        {
            boss.FixedParticles(0x3779, 1, 15, 0x2522, 0x47E, 0, EffectLayer.Head);
            boss.PublicOverheadMessage(MessageType.Emote, 0x47E, false, "*the dark magic withers*");
            attacker?.SendMessage(0x47E, "Mordrath drinks your necromancy as if it were water.");
        }
    }
}
