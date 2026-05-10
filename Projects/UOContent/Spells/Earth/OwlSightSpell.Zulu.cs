using System;
using Server.Engines.BuffIcons;
using Server.Items;
using Server.Mobiles;
using Server.Targeting;

namespace Server.Spells.Earth;

// Spell 751 — Owl Sight (Radharc Owl)
// Circle 1 | Mana: 5 | Skill: 60
// Grants night sight to target, cures blindness.
public class OwlSightSpell : EarthSpell, ITargetingSpell<Mobile>
{
    private static readonly SpellInfo _info = new(
        "Owl Sight",
        "Vista da Noite",
        -1,
        9002,
        typeof(EyeOfNewt)
    );

    public OwlSightSpell(Mobile caster, Item scroll = null) : base(caster, scroll, _info)
    {
    }

    public override TimeSpan CastDelayBase => TimeSpan.FromSeconds(1.0);
    public override double RequiredSkill => 60.0;
    public override int RequiredMana => 5;

    public void Target(Mobile m)
    {
        if (!CheckBSequence(m))
        {
            return;
        }

        SpellHelper.Turn(Caster, m);

        m.FixedParticles(0x373A, 10, 10, 5016, EffectLayer.Waist);
        m.PlaySound(0x1E4);
        m.SendMessage(0x48A, "Your vision sharpens with the clarity of an owl.");

        (m as PlayerMobile)?.AddBuff(new BuffInfo(BuffIcon.NightSight, 1075643, TimeSpan.FromMinutes(10.0)));
    }

    public override void OnCast()
    {
        Caster.Target = new SpellTarget<Mobile>(this, TargetFlags.Beneficial);
    }
}
