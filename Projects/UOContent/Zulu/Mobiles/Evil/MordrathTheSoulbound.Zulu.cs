using System.Collections.Generic;
using ModernUO.Serialization;

namespace Server.Mobiles
{
    // Zulu Hotel - Mordrath, the Soulbound.
    //
    // Lich custom (body 78). Spawn vulneravel e sem lacaios. No primeiro
    // dano invoca a 1a leva (3 lacaios) e fica invulneravel enquanto pelo
    // menos 1 lacaio estiver vivo. Re-invoca em 50% e 25% de HP. Apos a 3a
    // leva morrer nao ha mais invocacoes ate o boss morrer.
    //
    // - Imune permanente a magias do necrobook.
    // - Continua castando e se movendo enquanto invuln.
    // - Damage type Zulu: 70% Necro / 30% Poison.
    //
    // Estado de combate (Phase, lista de lacaios, timer das correntes) NAO
    // eh persistido: a luta eh efemera. Se o servidor reiniciar no meio,
    // o boss volta a Phase 0 e quaisquer lacaios remanescentes viram
    // skeletal mages comuns sem master.

    [SerializationGenerator(0, false)]
    public partial class MordrathTheSoulbound : BaseCreature
    {
        // Numero alvo de lacaios por leva.
        private const int MinionsPerWave = 3;

        // Distancia maxima de spawn dos lacaios em torno do boss.
        private const int MinionSpawnRange = 3;

        // Pulso visual das correntes - 0.5s para sensacao "agitada".
        private static readonly System.TimeSpan ChainPulseInterval =
            System.TimeSpan.FromMilliseconds(500);

        // Hue eldritch usado nos FX de absorb/aura/break (mensagens e particulas no boss).
        private const int SoulLinkHue = 0x47E;

        // ItemID e hue da "corrente" entre boss e lacaios.
        // 0x36F4 (14068) = firesnake. Hue 1 = preto solido na paleta UO,
        // dando o aspecto "serpente de energia negra" entre boss e lacaios.
        private const int ChainEffectItemId = 0x36F4;
        private const int ChainEffectHue = 1;

        // ItemID usado no efeito de "corrente quebrando" quando lacaio morre.
        private const int ChainBreakItemId = 0x36BD;

        // Estado de combate - nao serializado de proposito.
        private readonly List<MordrathSoulboundMinion> _aliveMinions = new();
        private TimerExecutionToken _chainPulseToken;

        // Phase: 0 = nenhuma leva invocada ainda
        //        1 = 1a leva ja invocada (primeiro dano)
        //        2 = 2a leva ja invocada (50% HP)
        //        3 = 3a leva ja invocada (25% HP)
        public int Phase { get; private set; }

        // Timestamp do ultimo dano recebido. Usado pela ability pra detectar
        // abandono (player que desistiu / morreu / deslogou). Inicializado em
        // MaxValue para que a checagem so passe a valer apos a 1a leva (Phase>0).
        public System.DateTime LastDamageTime { get; private set; } = System.DateTime.MaxValue;

        // True enquanto houver pelo menos 1 lacaio vivo.
        // Lista eh purgada lazy: lacaios deletados sao removidos em OnMinionDied,
        // mas conferimos Alive aqui como cinto-suspensorios.
        public bool IsLinked
        {
            get
            {
                for (var i = _aliveMinions.Count - 1; i >= 0; i--)
                {
                    var m = _aliveMinions[i];
                    if (m == null || m.Deleted || !m.Alive)
                    {
                        _aliveMinions.RemoveAt(i);
                    }
                }

                return _aliveMinions.Count > 0;
            }
        }

        [Constructible]
        public MordrathTheSoulbound() : base(AIType.AI_Mage)
        {
            Name = "Mordrath";
            Title = "the Soulbound";
            Body = 78;            // Ancient Lich body
            BaseSoundID = 412;
            Hue = 0x47E;          // tom roxo-fantasma proprio da identidade

            SetStr(360, 400);
            SetDex(120, 140);
            SetInt(1100, 1200);

            // HP fixo conforme decisao do design.
            SetHits(12000);
            SetMana(3000);

            SetDamage(20, 32);

            // Damage type Zulu (autoritativo no projeto). Nao chamar
            // SetDamageType() aqui: no ZH, SetDamageType() redireciona pra
            // SetZuluDamageType(), entao Cold viraria z_Water_DD = 70 e
            // sujaria a distribuicao final.
            z_Necro_DD = 70;
            z_Poison_DD = 30;

            SetResistance(ResistanceType.Physical, 65, 75);
            SetResistance(ResistanceType.Fire, 30, 40);
            SetResistance(ResistanceType.Cold, 75, 85);
            SetResistance(ResistanceType.Poison, 80, 90);
            SetResistance(ResistanceType.Energy, 30, 40);

            SetSkill(SkillName.EvalInt, 130.0, 140.0);
            SetSkill(SkillName.Magery, 130.0, 140.0);
            SetSkill(SkillName.Meditation, 110.0, 120.0);
            SetSkill(SkillName.Poisoning, 120.0, 130.0);
            SetSkill(SkillName.MagicResist, 180.0, 200.0);
            SetSkill(SkillName.Tactics, 100.0, 110.0);
            SetSkill(SkillName.Wrestling, 100.0, 110.0);
            SetSkill(SkillName.Necromancy, 130.0, 140.0);
            SetSkill(SkillName.SpiritSpeak, 130.0, 140.0);

            Fame = 25000;
            Karma = -25000;
            VirtualArmor = 70;

            // Modificadores Zulu - protecao total contra elemento Necro.
            // Soma com o flag de imunidade a NecromancerSpell que mora na ability.
            AddMobZuluModifier(ZuluMod.NecroProtection, 100, 100);
            AddMobZuluModifier(ZuluMod.PoisonProtection, 50, 50);
        }

        public override string CorpseName => "Mordrath's withered corpse";
        public override OppositionGroup OppositionGroup => OppositionGroup.FeyAndUndead;
        public override bool Unprovokable => true;
        public override bool BleedImmune => true;
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override int GetIdleSound() => 0x19D;
        public override int GetAngerSound() => 0x175;
        public override int GetDeathSound() => 0x108;
        public override int GetAttackSound() => 0xE2;
        public override int GetHurtSound() => 0x28B;

        // Sem loot por enquanto: o user vai revisar a tabela de loot global depois.
        public override void GenerateLoot()
        {
        }

        private static MonsterAbility[] _abilities =
        {
            MordrathSoulLinkAbility.Instance
        };

        public override MonsterAbility[] GetMonsterAbilities() => _abilities;

        // ---- Mecanica de fases / soul link ----

        // Hook universal de dano: cobre TODOS os caminhos (melee, ranged,
        // spell, AOE, poison tick, [damage GM, traps, etc).
        // Por isso o gatilho da 1a leva fica AQUI, nao no Trigger() da
        // ability - assim qualquer dano que efetivamente conecte invoca
        // os lacaios, independente da arma/spell usada.
        public override void OnDamage(int amount, Mobile from, bool willKill)
        {
            if (amount > 0)
            {
                LastDamageTime = Core.Now;

                if (Phase == 0 && Alive && !Deleted)
                {
                    SummonWave(1);
                }
            }

            base.OnDamage(amount, from, willKill);
        }

        // Reset por abandono. Disparado pela ability quando boss fica >60s sem
        // tomar dano apos invocar a 1a leva. Mata os lacaios, restaura HP,
        // zera Phase. Tambem chamada se boss for retirado da luta de outras formas.
        public void ResetEncounter()
        {
            // Mata lacaios remanescentes silenciosamente: setamos Master=null
            // antes de Delete() pra que OnMinionDied nao dispare FX/sound a toa
            // (player ja nao esta perto, por isso o reset).
            for (var i = _aliveMinions.Count - 1; i >= 0; i--)
            {
                var m = _aliveMinions[i];
                if (m != null && !m.Deleted)
                {
                    m.Master = null;
                    m.Delete();
                }
            }

            _aliveMinions.Clear();
            _chainPulseToken.Cancel();

            Phase = 0;
            LastDamageTime = System.DateTime.MaxValue;

            // Restaura HP completo - abandonar nao deve "bankar" dano pra
            // proxima tentativa.
            Hits = HitsMax;
            Mana = ManaMax;
            Stam = StamMax;

            if (Map != null && Map != Map.Internal && !Deleted && Alive)
            {
                FixedParticles(0x3779, 10, 30, 0x2521, SoulLinkHue, 0, EffectLayer.Head);
                PlaySound(0x1F8);
                PublicOverheadMessage(
                    MessageType.Emote,
                    SoulLinkHue,
                    false,
                    "*Mordrath sinks back into ancient slumber*"
                );
            }

            // Limpa lista de combate pra ele realmente "desengajar".
            Combatant = null;
            Aggressors.Clear();
            Aggressed.Clear();
        }

        // Chamado pela ability quando um threshold de HP/dano dispara uma nova leva.
        public void SummonWave(int waveNum)
        {
            if (Map == null || Map == Map.Internal || !Alive || Deleted)
            {
                return;
            }

            Phase = waveNum;

            // Limpa qualquer leftover (defensive).
            _aliveMinions.Clear();

            // Anuncio mistico em estilo cast.
            AnnounceSummon(waveNum);

            // FX no boss antes dos lacaios materializarem.
            FixedParticles(0x3779, 10, 30, 0x2521, SoulLinkHue, 0, EffectLayer.Head);
            PlaySound(0x216);

            for (var i = 0; i < MinionsPerWave; i++)
            {
                var loc = Utility.GetValidLocationInLOS(Map, this, MinionSpawnRange);

                var minion = new MordrathSoulboundMinion
                {
                    Master = this,
                    Team = Team
                };

                minion.MoveToWorld(loc, Map);

                if (Combatant is Mobile combatant)
                {
                    minion.Combatant = combatant;
                }

                Effects.SendLocationEffect(loc, Map, 0x3728, 10);
                minion.PlaySound(0x48F);

                _aliveMinions.Add(minion);
            }

            StartChainPulse();
        }

        private void AnnounceSummon(int waveNum)
        {
            // Mensagem estilo "incantation" - o boss "casta" para invocar os lacaios.
            var chant = waveNum switch
            {
                1 => "Vas Corp Por Xen Mort!",
                2 => "Sanctus Anima Mort - Surge Iterum!",
                _ => "Aetera Anima Mort - Defendite Me!"
            };

            PublicOverheadMessage(MessageType.Spell, SoulLinkHue, false, chant);
            PublicOverheadMessage(
                MessageType.Emote,
                SoulLinkHue,
                false,
                "*Mordrath binds his soul to risen servants*"
            );
        }

        // Chamado pelo lacaio em OnAfterDelete.
        public void OnMinionDied(MordrathSoulboundMinion minion)
        {
            if (minion == null)
            {
                return;
            }

            _aliveMinions.Remove(minion);

            // FX de "corrente quebrando" do boss para o local do lacaio.
            if (Map != null && Map != Map.Internal && !Deleted && Alive)
            {
                Effects.SendMovingEffect(
                    this,
                    minion,
                    ChainBreakItemId,
                    7,
                    0,
                    false,
                    true,
                    SoulLinkHue,
                    0
                );
                Effects.PlaySound(minion.Location, minion.Map, 0x1FB);
                PublicOverheadMessage(
                    MessageType.Emote,
                    SoulLinkHue,
                    false,
                    "*a soulbound chain shatters*"
                );
            }

            // Quando ultimo lacaio morre, para o pulso. Boss fica vulneravel.
            if (_aliveMinions.Count == 0)
            {
                _chainPulseToken.Cancel();
            }
        }

        private void StartChainPulse()
        {
            // Cancela qualquer pulso anterior antes de reiniciar (re-invocacao).
            _chainPulseToken.Cancel();

            Timer.StartTimer(
                ChainPulseInterval,
                ChainPulseInterval,
                PulseSoulChains,
                out _chainPulseToken
            );
        }

        // Tambem chamado externamente pela ability no Think (redundante mas
        // garante pulso mesmo se o timer falhar). Idempotente.
        public void PulseSoulChains()
        {
            if (Map == null || Map == Map.Internal || Deleted || !Alive)
            {
                _chainPulseToken.Cancel();
                return;
            }

            // Re-confere link (purga lacaios mortos da lista).
            if (!IsLinked)
            {
                _chainPulseToken.Cancel();
                return;
            }

            for (var i = 0; i < _aliveMinions.Count; i++)
            {
                var minion = _aliveMinions[i];
                if (minion == null || minion.Deleted || !minion.Alive || minion.Map != Map)
                {
                    continue;
                }

                // Corrente boss -> lacaio (large fireball preto, fixedDirection=true para
                // a sprite manter orientacao durante o voo - parece mais "feixe").
                Effects.SendMovingEffect(
                    this,
                    minion,
                    ChainEffectItemId,
                    5,
                    0,
                    true,
                    false,
                    ChainEffectHue,
                    0
                );

                // Corrente lacaio -> boss (efeito ida-e-volta de "almas trocadas")
                Effects.SendMovingEffect(
                    minion,
                    this,
                    ChainEffectItemId,
                    5,
                    0,
                    true,
                    false,
                    ChainEffectHue,
                    0
                );
            }
        }

        public override void OnAfterDelete()
        {
            _chainPulseToken.Cancel();

            // Limpa lacaios remanescentes (boss morto = sem motivo dos lacaios viverem).
            for (var i = 0; i < _aliveMinions.Count; i++)
            {
                var m = _aliveMinions[i];
                if (m != null && !m.Deleted)
                {
                    m.Master = null;
                    m.Delete();
                }
            }

            _aliveMinions.Clear();

            base.OnAfterDelete();
        }
    }
}
