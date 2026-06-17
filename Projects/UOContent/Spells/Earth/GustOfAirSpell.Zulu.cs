using System;
using Server.Items;
using Server.Targeting;

namespace Server.Spells.Earth;

// Spell 758 — Gust of Air (Cumhacht An Aer)
// Circle 2 | Mana: 15 | Skill: 100 | Element: Air
// Single target air damage.
public class GustOfAirSpell : EarthSpell, ITargetingSpell<Mobile>
{
    private static readonly SpellInfo _info = new(
        "Gust of Air",
        "Gust do Ar",
        -1,
        9002,
        typeof(FertileDirt),
        typeof(Brimstone),
        typeof(EyeOfNewt)
    );

    public GustOfAirSpell(Mobile caster, Item scroll = null) : base(caster, scroll, _info)
    {
    }

    public override TimeSpan CastDelayBase => TimeSpan.FromSeconds(3.0);
    public override double RequiredSkill => 100.0;
    public override int RequiredMana => 15;

    public void Target(Mobile m)
    {
        if (!CheckHSequence(m))
        {
            return;
        }

        SpellHelper.Turn(Caster, m);
        SpellHelper.CheckReflect((int)SpellCircle.Third, Caster, ref m);

        var damage = GetEarthDamage(18, 32);

        Effects.SendLocationEffect(m.Location, m.Map, 0x37CC, 30, 30);
        m.PlaySound(0x108);
        m.PlaySound(0x109);

        SpellHelper.ZuluDamage(this, m, damage, 0, 0, 0, 0, 100, 0, 0, 0); // air
    }

    public override void OnCast()
    {
        Caster.Target = new SpellTarget<Mobile>(this, TargetFlags.Harmful);
    }
}
