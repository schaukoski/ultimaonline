using System.Collections.Generic;
using Server.Gumps;
using Server.Items;

namespace Server.Mobiles;

// ─────────────────────────────────────────────────────────────────────────────
// Zulu Hotel — WaterShrineLord extended to handle fishing shells.
//
// Ported from POL zhna 15-08-13 pkg/mobile/npcs/ais/water.src
//
// In POL the same Water Element Shrine Lord handled BOTH:
//   - Water pentagram pieces (9 pieces from monsters)
//   - Fishing shells (9 collectible shells from fishing)
//
// If a player drops a FishShell, this override intercepts it and checks the
// player's backpack for a complete 9-shell set. If complete, opens the shell
// reward gump. Otherwise lists what's missing.
//
// Pentagram piece drops are still handled by base.OnDragDrop (ElementalShrineLord).
// ─────────────────────────────────────────────────────────────────────────────

public partial class WaterShrineLord
{
    public override bool OnDragDrop(Mobile from, Item dropped)
    {
        if (dropped is FishShell shell)
        {
            return HandleShellDrop(from, shell);
        }

        return base.OnDragDrop(from, dropped);
    }

    private bool HandleShellDrop(Mobile from, FishShell shell)
    {
        var pack = from.Backpack;
        if (pack == null)
        {
            return false;
        }

        var found = FishShellInfo.FindShells(pack);

        // Count the dropped shell too (not yet in pack).
        if (!found.ContainsKey(shell.Kind))
        {
            found[shell.Kind] = shell;
        }

        if (found.Count >= FishShellInfo.ShellCount)
        {
            Say("You have gathered all nine shells! Choose your reward.");
            from.SendGump(new ShellShrineLordRewardGump(from, this));
        }
        else
        {
            var missing = new List<string>();
            for (var i = 1; i <= FishShellInfo.ShellCount; i++)
            {
                var kind = (FishShellKind)i;
                if (!found.ContainsKey(kind))
                {
                    missing.Add(FishShellInfo.GetName(kind));
                }
            }

            Say($"Good, a {FishShellInfo.GetName(shell.Kind)}! You still need: {string.Join(", ", missing)}.");
        }

        // Never consume on drop.
        return false;
    }

    public override void OnDoubleClick(Mobile from)
    {
        if (!from.InRange(Location, 4))
        {
            from.SendLocalizedMessage(500446); // That is too far away.
            return;
        }

        Say("Bring me all 9 Water Pentagram pieces, or all 9 fishing shells — and I shall reward you handsomely!");
    }
}
