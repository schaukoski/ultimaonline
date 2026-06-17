using System;
using Server.Items;
using Server.Targeting;

namespace Server.Spells.Earth;

// Spell 756 — Earth Portal (Tairseach Nadur)
// Circle 1 | Mana: 10 | Skill: 80
// Creates a gate to a target location (30 second duration).
public class EarthPortalSpell : EarthSpell, ITargetingSpell<IPoint3D>
{
    private static readonly SpellInfo _info = new(
        "Earth Portal",
        "Destraves Limites Da Natureza",
        -1,
        9002,
        typeof(Brimstone),
        typeof(ZuluExecutionersCap),
        typeof(EyeOfNewt)
    );

    public EarthPortalSpell(Mobile caster, Item scroll = null) : base(caster, scroll, _info)
    {
    }

    public override TimeSpan CastDelayBase => TimeSpan.FromSeconds(2.0);
    public override double RequiredSkill => 80.0;
    public override int RequiredMana => 10;

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

        var from = new Point3D(Caster);
        var to = new Point3D(p);

        if (!SpellHelper.CheckTravel(Caster, TravelCheckType.GateFrom, out var msg1))
        {
            msg1.SendMessageTo(Caster);
            return;
        }

        if (!SpellHelper.CheckTravel(Caster, map, to, TravelCheckType.GateTo, out var msg2))
        {
            msg2.SendMessageTo(Caster);
            return;
        }

        Effects.PlaySound(from, map, 0x20F);

        var fromGate = new Moongate(to, map);
        fromGate.Hue = 0x48A;
        fromGate.MoveToWorld(from, map);
        Timer.StartTimer(TimeSpan.FromSeconds(30), fromGate.Delete);

        var toGate = new Moongate(from, map);
        toGate.Hue = 0x48A;
        toGate.MoveToWorld(to, map);
        Timer.StartTimer(TimeSpan.FromSeconds(30), toGate.Delete);
    }

    public override void OnCast()
    {
        Caster.Target = new SpellTarget<IPoint3D>(this, TargetFlags.None);
    }
}
