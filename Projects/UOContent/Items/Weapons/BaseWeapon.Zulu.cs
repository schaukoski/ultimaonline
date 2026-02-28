using Server.Collections;
using Server.Engines.MLQuests.Definitions;
using Server.Engines.Virtues;
using Server.Mobiles;
using Server.SkillHandlers;
using Server.Spells;
using Server.Spells.Bushido;
using Server.Spells.Chivalry;
using Server.Spells.Necromancy;
using Server.Spells.Ninjitsu;
using Server.Spells.Spellweaving;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Server.Items
{
    public abstract partial class BaseWeapon
    {
        public virtual bool CheckHitZulu(Mobile attacker, Mobile defender)
        {
            var atkWeapon = attacker.Weapon as BaseWeapon;
            var defWeapon = defender.Weapon as BaseWeapon;

            var atkSkill = attacker.Skills[atkWeapon?.Skill ?? SkillName.Wrestling];

            var atkValue = atkWeapon?.GetAttackSkillValue(attacker, defender) ?? 0.0;
            var defValue = defWeapon?.GetDefendSkillValue(attacker, defender) ?? 0.0;

            double ourValue, theirValue;

            var bonus = attacker.GetZuluModifier(ZuluMod.Accurracy) / 100;

            // Regra basica Minimo 2% de chance e Maximo de 98%

            ourValue = Math.Max(0.1, atkValue + 50.0);
            theirValue = Math.Max(0.1, defValue + 50.0);

            var chance = ourValue / (theirValue * 2.0) * 1.0 + (double)bonus / 100;

            if (chance < 0.02)
            {
                chance = 0.02;
            }

            return attacker.CheckSkill(atkSkill.SkillName, chance);
        }


        public virtual int ComputeZuluDamage(Mobile attacker, Mobile defender)
        {
            //Dano da Arma ou Maos, ja calculado entre min e max da arma.
            double damage = GetZuluBaseDamage(attacker);

            // Passively check tactics for gain
            attacker.CheckSkill(SkillName.Tactics, 0.0, attacker.Skills.Tactics.Cap);

            var damageBonus = attacker.GetZuluModifier(ZuluMod.PhysicalDamageAmp) / 100.0;

            return (int)Math.Round(damage * (1+damageBonus/100));
        }

        public virtual double GetZuluBaseDamage(Mobile attacker)
        {
            GetBaseDamageRange(attacker, out var min, out var max);

            var damage = Utility.RandomMinMax(min, max);

            //Adicionar Modificador de Arma, Vanquisihing Power etc?
            damage += (int)attacker.GetZuluModifier(ZuluMod.FixedPhysicalDamageAmp);

            return damage;
        }

        public double CriticalStrike(Mobile attacker, Mobile defender, double damage)
        {
            var critChance = attacker.GetZuluModifier(ZuluMod.CriticalChance) / 100.0;

            if (critChance <= 0)
                return 1.0;

            var atkWeapon = attacker.Weapon as BaseWeapon;

            if (atkWeapon?.Skill != SkillName.Swords)
                return 1.0;
            
            if (Utility.RandomDouble() < critChance)
            {
                var critBonus = attacker.GetZuluModifier(ZuluMod.CriticalDamage) / 100.0;
                critBonus = 1+ critBonus;
                return critBonus;

            }

            return 1.0; // No critical strike
        }

        public static bool CheckParryZulu(Mobile defender)
        {
            if (defender == null)
                return false;

            var shield = defender.FindItemOnLayer<BaseShield>(Layer.TwoHanded);

            if (shield == null)
                return false;

            double chance = defender.GetZuluModifier(ZuluMod.ParryngChance) / 100.0;

            return defender.CheckSkill(SkillName.Parry, chance);

        }

        public virtual int ParryDamageZulu(Mobile attacker, Mobile defender, int damage)
        {
            var blocked = false;

            if (defender.Player || defender.Body.IsHuman)
            {
                blocked = CheckParryZulu(defender);

                if (blocked)
                {
                    defender.FixedEffect(0x37B9, 10, 16);
                    ZuluModManager.SendDamageTakenOverHeadMessage(ZuluMod.ParryngChance, 0, attacker, defender);
                    damage = 0;

                    var shield = defender.FindItemOnLayer<BaseShield>(Layer.TwoHanded);

                    shield?.OnHit(this, damage);
                }
            }

            if (!blocked)
            {
                var positionChance = Utility.RandomDouble();

                var armorItem = positionChance switch
                {
                    < 0.07 => defender.NeckArmor,
                    < 0.14 => defender.HandArmor,
                    < 0.28 => defender.ArmsArmor,
                    < 0.43 => defender.HeadArmor,
                    < 0.65 => defender.LegsArmor,
                    _ => defender.ChestArmor
                };

                if (armorItem is IWearableDurability armor)
                {
                    armor.OnHit(this, damage); // call OnHit to lose durability
                }
            }

            return damage;
        }

        public virtual void GetZuluDamageDistributed(int damage,
        Mobile wielder, out int phys, out int fire, out int water, out int pois,
        out int air, out int necro, out int holly, out int earth
    )
        {
            if (wielder is BaseCreature bc)
            {
                phys = bc.z_Physical_DD / 100 * damage;
                fire = bc.z_Fire_DD / 100 * damage;
                water = bc.z_Water_DD / 100 * damage;
                pois = bc.z_Poison_DD / 100 * damage;
                air = bc.z_Air_DD / 100 * damage;
                necro = bc.z_Necro_DD / 100 * damage;
                holly = bc.z_Holly_DD / 100 * damage;
                earth = bc.z_Earth_DD / 100 * damage;
            }
            else
            {
                fire = water = pois = air = necro = holly = earth = 0;
                phys = damage;
            }
            
        }


        public virtual int ApplyZuluResistance(int damage, double resistancePercent)
        {
            double multiplier = 1 - (resistancePercent / 100.0);
            int finalDamage = (int)Math.Round(damage * multiplier);

            return finalDamage;
        }

        public virtual int ApplyZuluDamage(Mobile attacker, Mobile defender, int phys, int fire, int water, int pois, int air, int necro, int holly, int earth)
        {
            var damageGiven = 0;
            var appliedDamage = 0;

            if (phys > 0)
            {
                appliedDamage = ApplyZuluResistance(phys, defender.GetZuluModifier(ZuluMod.PhysicalProtection));
                    

                //Calculate Extra Protection for Swords, Fencing and Wrestling only for Mobs
                if (defender is BaseCreature)
                {
                    var atkWeapon = attacker.Weapon as BaseWeapon;
                    var atkSkill = attacker.Skills[atkWeapon?.Skill ?? SkillName.Wrestling];

                    if (atkWeapon.Skill == SkillName.Swords)
                        appliedDamage = ApplyZuluResistance(appliedDamage, defender.GetZuluModifier(ZuluMod.SwordsProtection));
                    else if (atkWeapon.Skill == SkillName.Fencing)
                        appliedDamage = ApplyZuluResistance(appliedDamage, defender.GetZuluModifier(ZuluMod.FencingProtection));
                    else if (atkWeapon.Skill == SkillName.Macing)
                        appliedDamage = ApplyZuluResistance(appliedDamage, defender.GetZuluModifier(ZuluMod.MacingProtection));
                    else if (atkWeapon.Skill == SkillName.Archery)
                        appliedDamage = ApplyZuluResistance(appliedDamage, defender.GetZuluModifier(ZuluMod.RangedProtection));
                    else
                        appliedDamage = ApplyZuluResistance(appliedDamage, defender.GetZuluModifier(ZuluMod.WrestlingProtection));

                }
                damageGiven += appliedDamage;

                //Dano fisico nunca menor que 0;
                if (damageGiven < 0)
                    damageGiven = 0;

                ZuluModManager.SendDamageTakenOverHeadMessage(ZuluMod.PhysicalDamageAmp, damageGiven, attacker, defender);
            }

            if (fire > 0)
            {
                appliedDamage = ApplyZuluResistance(fire, defender.GetZuluModifier(ZuluMod.FireProtection));
                damageGiven += appliedDamage;

                ZuluModManager.SendDamageTakenOverHeadMessage(ZuluMod.FireProtection, appliedDamage, attacker, defender, appliedDamage == 0);
            }

            if (water > 0)
            {
                appliedDamage = ApplyZuluResistance(water, defender.GetZuluModifier(ZuluMod.WaterProtection));
                damageGiven += appliedDamage;
                ZuluModManager.SendDamageTakenOverHeadMessage(ZuluMod.WaterProtection, appliedDamage, attacker, defender, appliedDamage == 0);
            }

            if (pois > 0)
            {
                appliedDamage = ApplyZuluResistance(pois, defender.GetZuluModifier(ZuluMod.PoisonProtection));
                damageGiven += appliedDamage;
                ZuluModManager.SendDamageTakenOverHeadMessage(ZuluMod.PoisonProtection, appliedDamage, attacker, defender, appliedDamage == 0);
            }

            if (air > 0)
            {
                appliedDamage = ApplyZuluResistance(air, defender.GetZuluModifier(ZuluMod.AirProtection));
                damageGiven += appliedDamage;
                ZuluModManager.SendDamageTakenOverHeadMessage(ZuluMod.AirProtection, appliedDamage, attacker, defender, appliedDamage == 0);
            }

            if (necro > 0)
            {
                appliedDamage = ApplyZuluResistance(necro, defender.GetZuluModifier(ZuluMod.NecroProtection));
                damageGiven += appliedDamage;
                ZuluModManager.SendDamageTakenOverHeadMessage(ZuluMod.NecroProtection, appliedDamage, attacker, defender, appliedDamage == 0);
            }

            if (holly > 0)
            {
                appliedDamage = ApplyZuluResistance(holly, defender.GetZuluModifier(ZuluMod.HollyProtection));
                damageGiven += appliedDamage;
                ZuluModManager.SendDamageTakenOverHeadMessage(ZuluMod.HollyProtection, appliedDamage, attacker, defender, appliedDamage == 0);
            }

            if (earth > 0)
            {
                appliedDamage = ApplyZuluResistance(earth, defender.GetZuluModifier(ZuluMod.EarthProtection));
                damageGiven += appliedDamage;
                ZuluModManager.SendDamageTakenOverHeadMessage(ZuluMod.EarthProtection, appliedDamage, attacker, defender, appliedDamage == 0);
            }
            

            if (defender?.Deleted != false || !defender.Alive || damageGiven <= 0)
                defender.Damage(damageGiven, attacker);

            return damageGiven;

        }

        public virtual void OnHitZulu(Mobile attacker, Mobile defender, double damageBonus = 1.0)
        {
            PlaySwingAnimation(attacker);
            PlayHurtAnimation(defender);

            attacker.PlaySound(GetHitAttackSound(attacker, defender));
            defender.PlaySound(GetHitDefendSound(attacker, defender));

            var damage = ComputeZuluDamage(attacker, defender);

            //Special Critical Strike
            var damageMultiplier = CriticalStrike(attacker, defender, damage);
            damage = (int)(damage * damageMultiplier);

            var defLoc = new WorldLocation(defender);
            var bcAtt = attacker as BaseCreature;
            var bcDef = defender as BaseCreature;

            bcAtt?.AlterMeleeDamageTo(defender, ref damage);
            bcDef?.AlterMeleeDamageFrom(attacker, ref damage);

            //Parry Physical Damage
            damage = ParryDamageZulu(attacker, defender, damage);

            if (damage <= 0)
                return;

            GetZuluDamageDistributed(
                damage, attacker, out int phys, out int fire, out int water, out int pois, out int air, out int necro, out int holly, out int earth
            );

            int totaldamageGiven = ApplyZuluDamage(attacker, defender, phys, fire, water, pois, air, necro, holly, earth);

            if (damageMultiplier > 1)
                ZuluModManager.SendSpecialHabilityOverHeadMessage(ZuluMod.CriticalDamage, attacker, defender);


            //Special Stunn
            //Special Mana Drain //attacker.PlaySound(0x44D); // LEECH SOUND

            

            //Special Cleave
            DoZuluAreaAttack(attacker, defender, 0x10E, phys, fire, water, pois, air, necro, holly, earth);

            //Special Lifesteal
            ZuluLifesteal(attacker, defender, totaldamageGiven);

            //Special Bleeding //AddBlood(attacker, defender, damage);
            ZuluBleedAttack(attacker, defender);


            // Reduzir hitpoints da arma
            if (Utility.Random(15) == 0)
            {
                    
                if (_hitPoints > 0)
                {
                    --HitPoints;
                }
                else if (_maxHitPoints > 1)
                {
                    --MaxHitPoints;

                    if (Parent is Mobile mobile)
                    {
                        // Your equipment is severely damaged.
                        mobile.LocalOverheadMessage(MessageType.Regular, 0x3B2, 1061121);
                    }
                }
                else
                {
                    Delete();
                }
            }
            
        }

        public virtual void ZuluBleedAttack(Mobile attacker, Mobile defender)
        {
            if (attacker.GetZuluModifier(ZuluMod.BleedChance) <= 0)
                return;

            var chance = attacker.GetZuluModifier(ZuluMod.BleedChance) / 100.0;

            if (Utility.RandomDouble() < chance)
            {
                ZuluBleed.StartBleed(attacker, defender, new WorldLocation(defender));
            }

        }

        public virtual void ZuluLifesteal(Mobile attacker, Mobile defender, int damage)
        {
            if (attacker.GetZuluModifier(ZuluMod.Lifesteal) <= 0)
                return;

            if (damage <= 0)
                return;

            int healed = damage * (int)attacker.GetZuluModifier(ZuluMod.Lifesteal) / 100;
            attacker.Hits += healed;

            ZuluModManager.SendSpecialHabilityOverHeadMessage(ZuluMod.Lifesteal, attacker, defender, healed);
        }

        public virtual void DoZuluAreaAttack(
    Mobile from, Mobile defender, int sound, int phys, int fire, int water, int pois,  int air,  int necro,  int holly, int earth)
        {
            if (from.GetZuluModifier(ZuluMod.CleaveDamage) <= 0)
                return;

            if (from is PlayerMobile)
            {
                if (from.Weapon == null || from.Weapon is not BasePoleArm)
                    return;
            }

            var map = from.Map;

            if (map == null)
            {
                return;
            }

            using var queue = PooledRefQueue<Mobile>.Create();
            foreach (var m in from.GetMobilesInRange(ZuluModManager.GetMod(ZuluMod.CleaveDamage).EffectRange))
            {
                if (from != m && defender != m && SpellHelper.ValidIndirectTarget(from, m)
                    && from.CanBeHarmful(m, false) && (from.InLOS(m)))
                {
                    queue.Enqueue(m);
                }
            }
            
            if (queue.Count == 0)
            {
                return;
            }

            Effects.PlaySound(from.Location, map, sound);

            while (queue.Count > 0)
            {
                var m = queue.Dequeue();

                var scalar = (11 - from.GetDistanceToSqrt(m)) / 10;

                if (scalar <= 0)
                {
                    continue;
                }

                if (scalar < 1.0)
                {
                    phys *= (int)(11 - from.GetDistanceToSqrt(m)) / 10;
                    fire *= (int)(11 - from.GetDistanceToSqrt(m)) / 10;
                    water *= (int)(11 - from.GetDistanceToSqrt(m)) / 10;
                    pois *= (int)(11 - from.GetDistanceToSqrt(m)) / 10;
                    air *= (int)(11 - from.GetDistanceToSqrt(m)) / 10;
                    necro *= (int)(11 - from.GetDistanceToSqrt(m)) / 10;
                    holly *= (int)(11 - from.GetDistanceToSqrt(m)) / 10;
                    earth *= (int)(11 - from.GetDistanceToSqrt(m)) / 10;
                }

                from.DoHarmful(m, true);

                if (phys > 0)
                    m.FixedEffect(0x3779, 1, 15, ZuluModManager.GetMod(ZuluMod.PhysicalDamageAmp).Hue, 0);
                if (fire > 0)
                    m.FixedEffect(0x3779, 1, 15, ZuluModManager.GetMod(ZuluMod.FireProtection).Hue, 0);
                if (water > 0)
                    m.FixedEffect(0x3779, 1, 15, ZuluModManager.GetMod(ZuluMod.WaterProtection).Hue, 0);
                if (pois > 0)
                    m.FixedEffect(0x3779, 1, 15, ZuluModManager.GetMod(ZuluMod.PoisonProtection).Hue, 0);
                if (air > 0)
                    m.FixedEffect(0x3779, 1, 15, ZuluModManager.GetMod(ZuluMod.AirProtection).Hue, 0);
                if (necro > 0)
                    m.FixedEffect(0x3779, 1, 15, ZuluModManager.GetMod(ZuluMod.NecroProtection).Hue, 0);
                if (holly > 0)
                    m.FixedEffect(0x3779, 1, 15, ZuluModManager.GetMod(ZuluMod.HollyProtection).Hue, 0);
                if (earth > 0)
                    m.FixedEffect(0x3779, 1, 15, ZuluModManager.GetMod(ZuluMod.EarthProtection).Hue, 0);

                ApplyZuluDamage(from, m, phys, fire, water, pois, air, necro, holly, earth);
                ZuluModManager.SendSpecialHabilityOverHeadMessage(ZuluMod.CleaveDamage, from, m);

            }
        }
    }
}
