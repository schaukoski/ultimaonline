using System;
using Server.Items;
using Server.Targeting;

namespace Server.Spells.Earth;

// Spell 757 — Nature's Touch (Teagmhail Saol)
// Circle 1 | Mana: 10 | Skill: 80
// Heals target for a significant amount.
public class NaturesTouchSpell : EarthSpell, ITargetingSpell<Mobile>
{
    private static readonly SpellInfo _info = new(
        "Nature's Touch",
        "Guerissez Par Terre",
        -1,
        9002,
        typeof(Pumice),
        typeof(VialOfBlood),
        typeof(Obsidian)
    );

    public NaturesTouchSpell(Mobile caster, Item scroll = null) : base(caster, scroll, _info)
    {
    }

    public override TimeSpan CastDelayBase => TimeSpan.FromSeconds(2.0);
    public override double RequiredSkill => 80.0;
    public override int RequiredMana => 10;

    public void Target(Mobile m)
    {
        if (!CheckBSequence(m))
        {
            return;
        }

        SpellHelper.Turn(Caster, m);

        var skill = Caster.Skills.Magery.Value;
        var toHeal = (int)(20 + Utility.Random(20) + skill / 5.0);

        SpellHelper.Heal(toHeal, m, Caster);

        m.FixedParticles(0x375A, 7, 16, 5005, EffectLayer.Waist);
        m.PlaySound(0x203);
        m.SendMessage(0x48A, $"Nature's touch heals you for {toHeal} points.");
    }

    public override void OnCast()
    {
        Caster.Target = new SpellTarget<Mobile>(this, TargetFlags.Beneficial);
    }
}
