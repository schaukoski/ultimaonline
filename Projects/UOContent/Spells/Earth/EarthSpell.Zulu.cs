using System;
using Server.Items;

namespace Server.Spells.Earth;

// Base class for all Earth Magic spells (Zulu Hotel).
// Uses Magery skill for casting and damage scaling.
public abstract class EarthSpell : Spell
{
    protected EarthSpell(Mobile caster, Item scroll, SpellInfo info) : base(caster, scroll, info)
    {
    }

    public abstract double RequiredSkill { get; }
    public abstract int RequiredMana { get; }

    public override SkillName CastSkill => SkillName.Magery;
    public override SkillName DamageSkill => SkillName.Magery;
    public override bool ClearHandsOnCast => false;

    public override void GetCastSkills(out double min, out double max)
    {
        min = RequiredSkill;
        max = Scroll != null ? min : RequiredSkill + 40.0;
    }

    public override int GetMana() => RequiredMana;

    // Scales damage based on caster's Magery skill
    protected double GetEarthDamage(double baseMin, double baseMax)
    {
        var skill = Caster.Skills.Magery.Value;
        var scalar = 0.5 + skill / 200.0; // 50% at 0 skill, 100% at 100 skill
        var roll = baseMin + Utility.RandomDouble() * (baseMax - baseMin);
        return roll * scalar;
    }
}
