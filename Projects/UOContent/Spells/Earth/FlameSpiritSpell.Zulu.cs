using System;
using Server.Items;
using Server.Mobiles;
using Server.Targeting;

namespace Server.Spells.Earth;

// Spell 763 — Flame Spirit (Glao Doiteain Eiliminteach)
// Circle 2 | Mana: 20 | Skill: 120
// Summons a Fire Elemental at the target location.
public class FlameSpiritSpell : EarthSpell, ITargetingSpell<IPoint3D>
{
    private static readonly SpellInfo _info = new(
        "Flame Spirit",
        "Chame O Fogo Elemental",
        -1,
        9002,
        typeof(EyeOfNewt),
        typeof(BlackMoor),
        typeof(Obsidian)
    );

    public FlameSpiritSpell(Mobile caster, Item scroll = null) : base(caster, scroll, _info)
    {
    }

    public override TimeSpan CastDelayBase => TimeSpan.FromSeconds(4.0);
    public override double RequiredSkill => 120.0;
    public override int RequiredMana => 20;

    public void Target(IPoint3D p)
    {
        if (!CheckSequence())
        {
            return;
        }

        SpellHelper.Turn(Caster, p);

        var map = Caster.Map;

        if (map == null)
        {
            return;
        }

        var loc = new Point3D(p);

        var elemental = new FireElemental();
        elemental.MoveToWorld(loc, map);
        elemental.Controlled = true;
        elemental.ControlMaster = Caster;
        elemental.ControlOrder = OrderType.Follow;
        elemental.IsBonded = false;

    }

    public override void OnCast()
    {
        Caster.Target = new SpellTarget<IPoint3D>(this, TargetFlags.None);
    }
}
