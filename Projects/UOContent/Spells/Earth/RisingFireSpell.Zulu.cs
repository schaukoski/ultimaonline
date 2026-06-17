using System;
using Server.Collections;
using Server.Items;
using Server.Targeting;

namespace Server.Spells.Earth;

// Spell 759 — Rising Fire (Eiri Amach Doiteain)
// Circle 2 | Mana: 15 | Skill: 100 | Element: Fire
// Area effect fire damage around the target.
public class RisingFireSpell : EarthSpell, ITargetingSpell<IPoint3D>
{
    private static readonly SpellInfo _info = new(
        "Rising Fire",
        "Batida Do Fogo",
        -1,
        9002,
        typeof(BatWing),
        typeof(Brimstone),
        typeof(VialOfBlood)
    );

    public RisingFireSpell(Mobile caster, Item scroll = null) : base(caster, scroll, _info)
    {
    }

    public override TimeSpan CastDelayBase => TimeSpan.FromSeconds(3.0);
    public override double RequiredSkill => 100.0;
    public override int RequiredMana => 15;

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

        Effects.PlaySound(loc, map, 0x209);
        Effects.SendLocationParticles(EffectItem.Create(loc, map, EffectItem.DefaultDuration), 0x3709, 10, 30, 0x48A, 0, 5052, 0);

        using var queue = PooledRefQueue<Mobile>.Create();
        foreach (var m in map.GetMobilesInRange(loc, 2))
        {
            if (m != Caster && SpellHelper.ValidIndirectTarget(Caster, m) && Caster.CanBeHarmful(m, false))
            {
                queue.Enqueue(m);
            }
        }

        while (queue.Count > 0)
        {
            var m = queue.Dequeue();
            var damage = GetEarthDamage(10, 20);

            m.FixedParticles(0x3709, 10, 30, 5052, EffectLayer.LeftFoot);

            Caster.DoHarmful(m);
            SpellHelper.ZuluDamage(this, m, damage, 0, 100, 0, 0, 0, 0, 0, 0); // fire
        }
    }

    public override void OnCast()
    {
        Caster.Target = new SpellTarget<IPoint3D>(this, TargetFlags.Harmful);
    }
}
