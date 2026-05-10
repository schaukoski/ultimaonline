using Server.Gumps;
using Server.Items;
using Server.Mobiles;
using Server.Network;
#nullable enable

namespace Server;

// ─────────────────────────────────────────────────────────────────────────────
// Zulu Hotel — Fishing Shell reward selection gump.
//
// Shown when the player presents all 9 FishShells to the Shell Shrine Lord.
// Mirrors ShrineLordRewardGump (pentagram). Shells are only consumed when the
// player actually picks a reward — if they die, close the gump, or lose shells
// between open and response, nothing is taken.
// ─────────────────────────────────────────────────────────────────────────────

public class ShellShrineLordRewardGump : ZuluGump
{
    private readonly Mobile _player;
    private readonly BaseCreature? _shrineLord;

    public override bool Singleton => true;

    private const string ColLabel = "#F5CD3B";
    private const string ColValue = "#FFFFFF";
    private const string ColTitle = "#4A2E0A";
    private const string ColWarn  = "#FF8800";

    public ShellShrineLordRewardGump(Mobile player, BaseCreature? shrineLord)
        : base(80, 100)
    {
        _player = player;
        _shrineLord = shrineLord;

        Build();
    }

    private void Build()
    {
        const int sx = 0;
        const int sy = 0;
        const int margin = 18;

        AddPage(0);
        AddBackgroundByUnits(sx, sy, 1, 2, ZuluGumpStyles.Black);

        // Close button
        AddButton(sx + 10, sy - 18, 2093, 2093, 0);

        // Title bar
        AddBackground(sx + 60, sy - 10, 180, 26, 9300);
        AddLabelHtml(sx + 60, sy - 8, 180, 22, "Shell Shrine", ColTitle, 5, true);

        AddLabelHtml(sx + margin, sy + 20, 274, 24,
            "Choose your reward:", ColLabel, 4, true);

        AddImageTiled(sx + margin, sy + 50, 274, 3, 96);

        // Row 1 — Neptune's Trident (weapon)
        var y = sy + 60;
        AddButton(sx + margin, y + 6, ZuluGumpButtons.GreenArrowRight, GumpButtonType.Reply, 1);
        AddItem(sx + margin + 36, y, 0x0E87); // Pitchfork graphic
        AddLabelHtml(sx + margin + 88, y + 6, 200, 20, "Neptune's Trident", ColValue, 4, false);
        y += 50;

        // Row 2 — Poseidon's Crown (headgear)
        AddButton(sx + margin, y + 6, ZuluGumpButtons.GreenArrowRight, GumpButtonType.Reply, 2);
        AddItem(sx + margin + 36, y, 0x140C); // Bascinet graphic
        AddLabelHtml(sx + margin + 88, y + 6, 200, 20, "Poseidon's Crown", ColValue, 4, false);
        y += 50;

        // Row 3 — Pouch of Pearls (50 pearls)
        AddButton(sx + margin, y + 6, ZuluGumpButtons.GreenArrowRight, GumpButtonType.Reply, 3);
        AddItem(sx + margin + 36, y, 0x0E79); // Pouch graphic
        AddLabelHtml(sx + margin + 88, y + 6, 200, 20, "Pouch of 50 Pearls", ColValue, 4, false);
        y += 50;

        // Divider + warning
        AddImageTiled(sx + margin, y, 274, 3, 96);
        y += 8;
        AddLabelHtml(sx + margin, y, 274, 36,
            "All 9 shells will be consumed.", ColWarn, 3, true);
    }

    public override void OnResponse(NetState sender, in RelayInfo info)
    {
        if (info.ButtonID is not (1 or 2 or 3))
        {
            return;
        }

        var from = sender.Mobile;
        if (from?.Backpack == null || from.Deleted)
        {
            return;
        }

        // Re-validate that all 9 shells are still present (searches sub-bags
        // up to 3 levels). This protects against shells being moved, eaten,
        // or lost between gump open and response.
        var shells = FishShellInfo.FindShells(from.Backpack);
        if (shells.Count < FishShellInfo.ShellCount)
        {
            from.SendMessage("You no longer have all nine shells.");
            return;
        }

        // Consume exactly one per kind — duplicates are preserved.
        foreach (var kvp in shells)
        {
            kvp.Value.Delete();
        }

        // Award chosen reward.
        var pack = from.Backpack;
        switch (info.ButtonID)
        {
            case 1:
                pack.DropItem(new NeptunesTrident());
                break;
            case 2:
                pack.DropItem(new PoseidonsCrown());
                break;
            case 3:
                pack.DropItem(new PouchOfPearls());
                break;
        }

        from.SendMessage("The Shell Shrine Lord has rewarded you!");
        _shrineLord?.Say("May the tides favour you, friend.");
    }
}
