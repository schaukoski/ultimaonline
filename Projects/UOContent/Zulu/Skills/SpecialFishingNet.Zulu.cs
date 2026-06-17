using Server.Engines.Harvest;

namespace Server.Items;

// ─────────────────────────────────────────────────────────────────────────────
// Zulu Hotel — Special Fishing Net shell drop.
//
// Implements the partial hook declared in SpecialFishingNet.cs (##zulu mod).
// Called once when the net finishes spawning sea creatures.
//
// Ported from POL zhna 15-08-13 pkg/skills/fishing/fishingnet.src:RandomShell()
//
// Net shells 1..5 — shells 4 & 5 require effective Fishing skill > 100.
// Drop chance: ~16.7% (POL: if (Random(6) == 2))
// ─────────────────────────────────────────────────────────────────────────────

public partial class SpecialFishingNet
{
    // POL: if (Random(6) == 2) → 1/6 ≈ 16.7%
    private const double ShellDropChanceNet = 1.0 / 6.0;

    partial void ZuluOnNetFinished(Mobile from)
    {
        if (from?.Backpack == null || from.Deleted)
        {
            return;
        }

        if (Utility.RandomDouble() >= ShellDropChanceNet)
        {
            return;
        }

        var kind = ZuluShellHelper.RollNetShell(from);
        if (kind is null)
        {
            return;
        }

        from.Backpack.DropItem(new FishShell(kind.Value));
        from.SendMessage("You find something valuable in the net!");
    }
}
