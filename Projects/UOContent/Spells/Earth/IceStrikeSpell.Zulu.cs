using System;
using Server.Items;
using Server.Targeting;

namespace Server.Spells.Earth;

// Spell 761 — Ice Strike (Oighear Stailc)
// Circle 2 | Mana: 20 | Skill: 120 | Element: Water
// Single target water/cold damage.
public class IceStrikeSpell : EarthSpell, ITargetingSpell<Mobile>
{
    private static readonly SpellInfo _info = new(
        "Ice Strike",
        "Geada Com Inverno",
        -1,
        9002,
        typeof(Bone),
        typeof(BatWing),
        typeof(Brimstone)
    );

    public IceStrikeSpell(Mobile caster, Item scroll = null) : base(caster, scroll, _info)
    {
    }

    public override TimeSpan CastDelayBase => TimeSpan.FromSeconds(4.0);
    public override double RequiredSkill => 120.0;
    public override int RequiredMana => 20;

    public void Target(Mobile m)
    {
        if (!CheckHSequence(m))
        {
            return;
        }

        SpellHelper.Turn(Caster, m);
        SpellHelper.CheckReflect((int)SpellCircle.Fourth, Caster, ref m);

        var damage = GetEarthDamage(24, 42);

        Effects.SendLocationEffect(m.Location, m.Map, 0x3789, 30, 30);
        m.PlaySound(0x117);
        m.PlaySound(0x118);

        SpellHelper.ZuluDamage(this, m, damage, 0, 0, 100, 0, 0, 0, 0, 0); // water/cold
    }

    public override void OnCast()
    {
        Caster.Target = new SpellTarget<Mobile>(this, TargetFlags.Harmful);
    }
}
