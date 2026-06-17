using System;
using Server.Items;

namespace Server.Spells.Earth;

// Spell 755 — Earth Blessing (Gra Cre)
// Circle 1 | Mana: 10 | Skill: 80
// Buffs Str, Dex, Int of the caster for a duration.
public class EarthBlessingSpell : EarthSpell
{
    private static readonly SpellInfo _info = new(
        "Earth Blessing",
        "Furia da Terra",
        -1,
        9002,
        typeof(PigIron),
        typeof(Obsidian),
        typeof(VolcanicAsh)
    );

    public EarthBlessingSpell(Mobile caster, Item scroll = null) : base(caster, scroll, _info)
    {
    }

    public override TimeSpan CastDelayBase => TimeSpan.FromSeconds(2.0);
    public override double RequiredSkill => 80.0;
    public override int RequiredMana => 10;

    public override void OnCast()
    {
        if (!CheckSequence())
        {
            return;
        }

        SpellHelper.Turn(Caster, Caster);

        var duration = TimeSpan.FromSeconds(30 + Caster.Skills.Magery.Value * 0.5);
        var bonus = (int)(10 + Caster.Skills.Magery.Value / 10.0);

        Caster.AddStatMod(new StatMod(StatType.Str, "EarthBlessing-Str", bonus, duration));
        Caster.AddStatMod(new StatMod(StatType.Dex, "EarthBlessing-Dex", bonus, duration));
        Caster.AddStatMod(new StatMod(StatType.Int, "EarthBlessing-Int", bonus, duration));

        Caster.FixedParticles(0x373A, 10, 10, 5010, EffectLayer.Waist);
        Caster.PlaySound(0x1EB);
        Caster.SendMessage(0x48A, "The earth's blessing flows through you.");
    }
}
