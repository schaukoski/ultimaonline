using System;
using Server.Items;
using Server.Mobiles;

namespace Server.Spells.Earth;

// Spell 753 — Summon Mammals (Mamaigh Thoghairm)
// Circle 1 | Mana: 5 | Skill: 60
// Summons 1-2 random animals near the caster.
public class SummonMammalsSpell : EarthSpell
{
    private static readonly SpellInfo _info = new(
        "Summon Mammals",
        "Chame O Mamifero Agora",
        -1,
        9002,
        typeof(SerpentsScales),
        typeof(PigIron),
        typeof(EyeOfNewt)
    );

    private static readonly Type[] _mammals =
    [
        typeof(TimberWolf),
        typeof(Horse),
        typeof(Panther),
        typeof(BlackBear),
        typeof(GrizzlyBear),
        typeof(ForestOstard)
    ];

    public SummonMammalsSpell(Mobile caster, Item scroll = null) : base(caster, scroll, _info)
    {
    }

    public override TimeSpan CastDelayBase => TimeSpan.FromSeconds(1.0);
    public override double RequiredSkill => 60.0;
    public override int RequiredMana => 5;

    public override void OnCast()
    {
        if (!CheckSequence())
        {
            return;
        }

        var map = Caster.Map;

        if (map == null)
        {
            return;
        }

        var count = Utility.RandomMinMax(1, 2);

        for (var i = 0; i < count; i++)
        {
            var type = _mammals[Utility.Random(_mammals.Length)];
            var creature = (BaseCreature)Activator.CreateInstance(type);

            var spawnLoc = Caster.Location;

            for (var attempt = 0; attempt < 10; attempt++)
            {
                var x = Caster.X + Utility.RandomMinMax(-2, 2);
                var y = Caster.Y + Utility.RandomMinMax(-2, 2);
                var z = map.GetAverageZ(x, y);

                if (map.CanFit(x, y, z, 16, false, false))
                {
                    spawnLoc = new Point3D(x, y, z);
                    break;
                }
            }

            creature.MoveToWorld(spawnLoc, map);
            creature.Controlled = true;
            creature.ControlMaster = Caster;
            creature.ControlOrder = OrderType.Follow;
            creature.IsBonded = false;
        }

    }
}
