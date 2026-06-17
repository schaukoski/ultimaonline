using System;
using Server.Mobiles;
using Server.Spells.Mysticism;

namespace Server.Spells
{
    public static partial class SpellHelper
    {
        // Called from SpellHelper.cs in place of AOS.Damage.
        // Maps UO standard elements (phys, fire, cold, pois, nrgy, chaos)
        // to Zulu element resistance system: cold→Water, nrgy→Air, chaos→Necro.
        private static int ZuluApplySpellDamage(
            Mobile from, Mobile target, int damage,
            int phys, int fire, int cold, int pois, int nrgy, int chaos
        )
        {
            return ZuluApplyElements(from, target, damage, phys, fire, cold, pois, nrgy, chaos, 0, 0);
        }

        // Public entry point for Earth spells (and any Zulu spell) using native Zulu elements.
        // phys, fire, water, pois, air, necro, holly, earth — percentages summing to 100.
        public static void ZuluDamage(
            Spell spell, Mobile target, double damage,
            int phys, int fire, int water, int pois, int air, int necro, int holly, int earth
        )
        {
            var ts = GetDamageDelayForSpell(spell);
            var dmg = (int)damage;

            if (ts == TimeSpan.Zero)
            {
                var bcFrom = spell.Caster as BaseCreature;
                var bcTarget = target as BaseCreature;

                bcFrom?.AlterSpellDamageTo(target, ref dmg);
                bcTarget?.AlterSpellDamageFrom(spell.Caster, ref dmg);

                var total = ZuluApplyElements(spell.Caster, target, dmg, phys, fire, water, pois, air, necro, holly, earth);

                SpellPlagueSpell.OnMobileDamaged(target);

                bcFrom?.OnDamageSpell(target, total);

                if (spell.Caster != null && bcTarget != null)
                {
                    bcTarget.OnHarmfulSpell(spell.Caster);
                    bcTarget.OnDamagedBySpell(spell.Caster, total);
                }
            }
            else
            {
                new ZuluSpellDamageTimer(spell, ts, target, spell.Caster, dmg, phys, fire, water, pois, air, necro, holly, earth).Start();
            }
        }

        // Core damage application — shared by both entry points.
        // Parameters: phys, fire, water, pois, air, necro, holly, earth (all as percentages or raw values).
        private static int ZuluApplyElements(
            Mobile from, Mobile target, int damage,
            int phys, int fire, int water, int pois, int air, int necro, int holly, int earth
        )
        {
            if (target?.Deleted != false || !target.Alive || damage <= 0)
            {
                return 0;
            }

            // PermMagicImmunity: block spells of circle ≤ MagicImmunityCircle stored on target.
            if (from?.Spell is MagerySpell ms)
            {
                var immunityCircle = (int)target.GetZuluModifier(ZuluMod.MagicImmunityCircle);
                if (immunityCircle > 0 && (int)ms.Circle + 1 <= immunityCircle)
                {
                    return 0;
                }
            }

            var physDmg  = phys  > 0 ? (int)(damage * phys  / 100.0) : 0;
            var fireDmg  = fire  > 0 ? (int)(damage * fire  / 100.0) : 0;
            var waterDmg = water > 0 ? (int)(damage * water / 100.0) : 0;
            var poisDmg  = pois  > 0 ? (int)(damage * pois  / 100.0) : 0;
            var airDmg   = air   > 0 ? (int)(damage * air   / 100.0) : 0;
            var necroDmg = necro > 0 ? (int)(damage * necro / 100.0) : 0;
            var hollyDmg = holly > 0 ? (int)(damage * holly / 100.0) : 0;
            var earthDmg = earth > 0 ? (int)(damage * earth / 100.0) : 0;

            var totalDamage = 0;
            int applied;

            if (physDmg > 0)
            {
                applied = ApplyZuluSpellResistance(physDmg, target.GetZuluModifier(ZuluMod.PhysicalProtection));
                totalDamage += applied;
                ZuluModManager.SendDamageTakenOverHeadMessage(ZuluMod.PhysicalDamageAmp, applied, from, target);
            }

            if (fireDmg > 0)
            {
                applied = ApplyZuluSpellResistance(fireDmg, target.GetZuluModifier(ZuluMod.FireProtection));
                totalDamage += applied;
                ZuluModManager.SendDamageTakenOverHeadMessage(ZuluMod.FireProtection, applied, from, target, applied == 0);
            }

            if (waterDmg > 0)
            {
                applied = ApplyZuluSpellResistance(waterDmg, target.GetZuluModifier(ZuluMod.WaterProtection));
                totalDamage += applied;
                ZuluModManager.SendDamageTakenOverHeadMessage(ZuluMod.WaterProtection, applied, from, target, applied == 0);
            }

            if (poisDmg > 0)
            {
                applied = ApplyZuluSpellResistance(poisDmg, target.GetZuluModifier(ZuluMod.PoisonProtection));
                totalDamage += applied;
                ZuluModManager.SendDamageTakenOverHeadMessage(ZuluMod.PoisonProtection, applied, from, target, applied == 0);
            }

            if (airDmg > 0)
            {
                applied = ApplyZuluSpellResistance(airDmg, target.GetZuluModifier(ZuluMod.AirProtection));
                totalDamage += applied;
                ZuluModManager.SendDamageTakenOverHeadMessage(ZuluMod.AirProtection, applied, from, target, applied == 0);
            }

            if (necroDmg > 0)
            {
                applied = ApplyZuluSpellResistance(necroDmg, target.GetZuluModifier(ZuluMod.NecroProtection));
                totalDamage += applied;
                ZuluModManager.SendDamageTakenOverHeadMessage(ZuluMod.NecroProtection, applied, from, target, applied == 0);
            }

            if (hollyDmg > 0)
            {
                applied = ApplyZuluSpellResistance(hollyDmg, target.GetZuluModifier(ZuluMod.HollyProtection));
                totalDamage += applied;
                ZuluModManager.SendDamageTakenOverHeadMessage(ZuluMod.HollyProtection, applied, from, target, applied == 0);
            }

            if (earthDmg > 0)
            {
                applied = ApplyZuluSpellResistance(earthDmg, target.GetZuluModifier(ZuluMod.EarthProtection));
                totalDamage += applied;
                ZuluModManager.SendDamageTakenOverHeadMessage(ZuluMod.EarthProtection, applied, from, target, applied == 0);
            }

            if (totalDamage <= 0)
            {
                return 0;
            }

            target.Damage(totalDamage, from);
            return totalDamage;
        }

        private static int ApplyZuluSpellResistance(int damage, double resistancePercent)
        {
            var multiplier = 1.0 - (resistancePercent / 100.0);
            return (int)Math.Round(damage * multiplier);
        }

        private class ZuluSpellDamageTimer : Timer
        {
            private readonly int _phys, _fire, _water, _pois, _air, _necro, _holly, _earth;
            private readonly Mobile _from;
            private readonly Spell _spell;
            private readonly Mobile _target;
            private int _damage;

            public ZuluSpellDamageTimer(
                Spell s, TimeSpan delay, Mobile target, Mobile from, int damage,
                int phys, int fire, int water, int pois, int air, int necro, int holly, int earth
            ) : base(delay)
            {
                _target = target;
                _from   = from;
                _damage = damage;
                _phys   = phys;
                _fire   = fire;
                _water  = water;
                _pois   = pois;
                _air    = air;
                _necro  = necro;
                _holly  = holly;
                _earth  = earth;
                _spell  = s;

                if (_spell?.DelayedDamage == true)
                {
                    _spell.StartDelayedDamageContext(target, this);
                }
            }

            protected override void OnTick()
            {
                if (_target.Deleted || !_target.Alive)
                {
                    return;
                }

                ZuluDamage(_spell, _target, _damage, _phys, _fire, _water, _pois, _air, _necro, _holly, _earth);
                _spell?.RemoveDelayedDamageContext(_target);
            }
        }
    }
}
