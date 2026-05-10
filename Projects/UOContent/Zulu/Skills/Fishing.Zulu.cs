using Server.Items;

namespace Server.Engines.Harvest;

// ─────────────────────────────────────────────────────────────────────────────
// Zulu Hotel — Fishing Pole shell drop.
//
// Implements the partial hook declared in Fishing.cs (##zulu mod region).
// Called once per successful fishing pole catch via OnHarvestFinished.
//
// Ported from POL zhna 15-08-13 pkg/skills/fishing/fishing.src:RandomShell()
//
// Pole shells 1..5 — shells 4 & 5 require effective Fishing skill > 100.
// No class bonus is applied — POL source had none.
// ─────────────────────────────────────────────────────────────────────────────

public partial class Fishing
{
    // POL: case 5 of the outer fishing switch -> if (Random(50) < 6) ... ~12%
    private const double ShellDropChancePole = 0.12;

    partial void ZuluOnFishCaught(Mobile from, Item tool, object harvested)
    {
        if (from?.Backpack == null || from.Deleted)
        {
            return;
        }

        if (!Utility.RandomDouble().IsLessThan(ShellDropChancePole))
        {
            return;
        }

        var kind = ZuluShellHelper.RollPoleShell(from);
        if (kind is null)
        {
            return;
        }

        from.Backpack.DropItem(new FishShell(kind.Value));
        from.SendMessage("You find something valuable among your catch!");
    }
}

/// <summary>
/// Shared helper for rolling shell drops for both fishing pole and fishing
/// net. Ported from POL fishing.src and fishingnet.src.
/// </summary>
internal static class ZuluShellHelper
{
    // POL pole: case (Random(10)) 0..4, rest nothing
    public static FishShellKind? RollPoleShell(Mobile from)
    {
        var roll = Utility.Random(10);
        var highSkill = from.Skills.Fishing.Value > 100.0;

        return roll switch
        {
            0 => FishShellKind.Aquaria,
            1 => FishShellKind.Capricornia,
            2 => FishShellKind.SeaNymph,
            3 or 4 when highSkill && Utility.Random(6) == 2 => FishShellKind.NeptunesNautilus,
            3 or 4 when highSkill                            => FishShellKind.SandDollar,
            3 or 4                                           => FishShellKind.SeaNymph, // low-skill fallback
            _                                                => null
        };
    }

    // POL net: case (Random(5)) 0..4
    public static FishShellKind? RollNetShell(Mobile from)
    {
        var roll = Utility.Random(5);
        var highSkill = from.Skills.Fishing.Value > 100.0;

        return roll switch
        {
            0 => FishShellKind.SandDollar,
            1 => FishShellKind.Divinia,
            2 => FishShellKind.Mermaid,
            3 or 4 when highSkill && Utility.Random(3) == 2 => FishShellKind.OceanOdyssey,
            3 or 4 when highSkill                            => FishShellKind.Talimari,
            3 or 4                                           => FishShellKind.Mermaid, // low-skill fallback
            _                                                => null
        };
    }
}

internal static class ZuluDoubleExtensions
{
    public static bool IsLessThan(this double value, double threshold) => value < threshold;
}
