using System;
using Server.Items;
using Server.Mobiles;
using Server.Targeting;

namespace Server.Spells.Earth;

// Spell 762 — Earth Spirit (Glao Cre Eiliminteach)
// Circle 2 | Mana: 20 | Skill: 120
// Summons an Earth Elemental at the target location.
public class EarthSpiritSpell : EarthSpell, ITargetingSpell<IPoint3D>
{
    private static readonly SpellInfo _info = new(
        "Earth Spirit",
        "Chame A Terra Elemental",
        -1,
        9002,
        typeof(DragonsBlood),
        typeof(FertileDirt),
        typeof(VolcanicAsh)
    );

    public EarthSpiritSpell(Mobile caster, Item scroll = null) : base(caster, scroll, _info)
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

        var elemental = new EarthElemental();
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
