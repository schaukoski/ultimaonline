using System;
using Server.Items;
using Server.Targeting;

namespace Server.Spells.Earth;

// Spell 752 — Shifting Earth (Aistriu Talun)
// Circle 1 | Mana: 5 | Skill: 60 | Element: Earth
// Single target earth damage.
public class ShiftingEarthSpell : EarthSpell, ITargetingSpell<Mobile>
{
    private static readonly SpellInfo _info = new(
        "Shifting Earth",
        "Esmagamento Con Pedra",
        -1,
        9002,
        typeof(FertileDirt),
        typeof(Obsidian),
        typeof(ZuluDeadwood)
    );

    public ShiftingEarthSpell(Mobile caster, Item scroll = null) : base(caster, scroll, _info)
    {
    }

    public override TimeSpan CastDelayBase => TimeSpan.FromSeconds(1.0);
    public override double RequiredSkill => 60.0;
    public override int RequiredMana => 5;

    public void Target(Mobile m)
    {
        if (!CheckHSequence(m))
        {
            return;
        }

        SpellHelper.Turn(Caster, m);
        SpellHelper.CheckReflect((int)SpellCircle.First, Caster, ref m);

        var damage = GetEarthDamage(6, 14);

        m.FixedParticles(0x3789, 10, 10, 5052, EffectLayer.LeftFoot);
        m.PlaySound(0x20E);

        SpellHelper.ZuluDamage(this, m, damage, 0, 0, 0, 0, 0, 0, 0, 100); // earth
    }

    public override void OnCast()
    {
        Caster.Target = new SpellTarget<Mobile>(this, TargetFlags.Harmful);
    }
}
