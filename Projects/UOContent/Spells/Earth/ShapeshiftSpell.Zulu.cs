using System;
using Server.Items;

namespace Server.Spells.Earth;

// Spell 760 — Shapeshift (Athru Cruth)
// Circle 2 | Mana: 15 | Skill: 100
// Transforms the caster into a wolf for a duration (BodyMod).
public class ShapeshiftSpell : EarthSpell
{
    private static readonly SpellInfo _info = new(
        "Shapeshift",
        "Mude Minha Forma",
        -1,
        9002,
        typeof(WormsHeart),
        typeof(BlackMoor),
        typeof(BatWing)
    );

    public ShapeshiftSpell(Mobile caster, Item scroll = null) : base(caster, scroll, _info)
    {
    }

    public override TimeSpan CastDelayBase => TimeSpan.FromSeconds(3.0);
    public override double RequiredSkill => 100.0;
    public override int RequiredMana => 15;

    public override void OnCast()
    {
        if (!CheckSequence())
        {
            return;
        }

        // Toggle: if already shapeshifted, revert
        if (Caster.BodyMod == 23) // wolf body
        {
            Caster.BodyMod = 0;
            Caster.HueMod = -1;
            Caster.SendMessage(0x48A, "You return to your natural form.");
            return;
        }

        var duration = TimeSpan.FromSeconds(30 + Caster.Skills.Magery.Value * 0.6);

        Caster.BodyMod = 23; // wolf
        Caster.HueMod = 0;

        Timer.StartTimer(duration, () =>
        {
            if (!Caster.Deleted && Caster.BodyMod == 23)
            {
                Caster.BodyMod = 0;
                Caster.HueMod = -1;
                Caster.SendMessage(0x48A, "Your shapeshifted form fades away.");
            }
        });

        Caster.FixedParticles(0x1, 10, 10, 5036, EffectLayer.Head);
        Caster.FixedParticles(0x373A, 10, 15, 5036, EffectLayer.Head);
        Caster.PlaySound(0x20A);
        Caster.SendMessage(0x48A, "You transform into a wolf!");
    }
}
