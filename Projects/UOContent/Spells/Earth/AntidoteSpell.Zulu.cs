using System;
using Server.Items;
using Server.Targeting;

namespace Server.Spells.Earth;

// Spell 750 — Antidote (Nimhe Saor In Aisce)
// Circle 1 | Mana: 5 | Skill: 60
// Cures poison from target.
public class AntidoteSpell : EarthSpell, ITargetingSpell<Mobile>
{
    private static readonly SpellInfo _info = new(
        "Antidote",
        "Puissante Terre Traite Ce Patient",
        -1,
        9002,
        typeof(ZuluDeadwood),
        typeof(FertileDirt),
        typeof(ZuluExecutionersCap)
    );

    public AntidoteSpell(Mobile caster, Item scroll = null) : base(caster, scroll, _info)
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

        if (m.Poisoned)
        {
            m.CurePoison(Caster);
            m.FixedParticles(0x373A, 10, 10, 5012, EffectLayer.Waist);
            m.PlaySound(0x1E1);
            m.SendMessage(0x48A, "The poison has been cleansed from your body.");
        }
        else
        {
            m.SendLocalizedMessage(1060177); // That creature is not poisoned.
        }
    }

    public override void OnCast()
    {
        Caster.Target = new SpellTarget<Mobile>(this, TargetFlags.Beneficial);
    }
}
