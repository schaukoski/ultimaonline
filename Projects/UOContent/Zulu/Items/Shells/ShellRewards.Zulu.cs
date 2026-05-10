using ModernUO.Serialization;

namespace Server.Items;

// ─────────────────────────────────────────────────────────────────────────────
// Zulu Hotel — Fishing Shell reward items.
//
// Awarded by the Shell Shrine Lord when a player turns in all 9 collectible
// shells. POL source does not specify the reward set — these are sea-themed
// choices, mirroring the Pentagram reward pattern (weapon / headgear / pouch).
// ─────────────────────────────────────────────────────────────────────────────

/// <summary>
/// Sea-themed reinforced trident awarded for the full shell collection.
/// Re-hued, renamed variant of the standard Pitchfork graphic.
/// </summary>
[SerializationGenerator(0, false)]
public partial class NeptunesTrident : Pitchfork
{
    [Constructible]
    public NeptunesTrident()
    {
        Name = "Neptune's Trident";
        Hue = 0x0499; // deep-sea turquoise
    }
}

/// <summary>
/// Ceremonial crown made from compressed pearl and coral, awarded for the
/// full shell collection. Built on the Bascinet graphic — any light helmet
/// would work, but Bascinet has a crown-like silhouette.
/// </summary>
[SerializationGenerator(0, false)]
public partial class PoseidonsCrown : Bascinet
{
    [Constructible]
    public PoseidonsCrown()
    {
        Name = "Poseidon's Crown";
        Hue = 0x0501; // pale pearl-white
    }
}

/// <summary>
/// A small leather pouch containing 50 white pearls — the "cash" reward for
/// players who prefer material value over gear.
/// </summary>
[SerializationGenerator(0, false)]
public partial class PouchOfPearls : Pouch
{
    [Constructible]
    public PouchOfPearls()
    {
        Name = "Pouch of Pearls";
        Hue = 0x0489;

        for (var i = 0; i < 50; i++)
        {
            DropItem(new WhitePearl());
        }
    }
}
