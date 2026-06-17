using Server.Gumps;
using Server.Items;
using Server.Mobiles;
using Server.Network;

namespace Server;

/// <summary>
/// Reward selection gump for the pentagram collection system.
/// Shown after a player presents all 9 pieces to a Shrine Lord.
/// Black panel (WarshardGump style), compact, with item previews.
/// </summary>
public class ShrineLordRewardGump : ZuluGump
{
    private readonly Mobile _player;
    private readonly ElementalShrineLord _shrineLord;
    private readonly PentagramElement _element;

    public override bool Singleton => true;

    private const string ColLabel = "#F5CD3B";
    private const string ColValue = "#FFFFFF";
    private const string ColTitle = "#4A2E0A";
    private const string ColWarn  = "#FF8800";

    public ShrineLordRewardGump(Mobile player, ElementalShrineLord shrineLord, PentagramElement element)
        : base(80, 100)
    {
        _player = player;
        _shrineLord = shrineLord;
        _element = element;

        Build();
    }

    private void Build()
    {
        var elemName = PentagramElementInfo.GetName(_element);
        var elemHue  = PentagramElementInfo.GetPieceHue(_element);

        const int sx = 0;
        const int sy = 0;
        const int margin = 16;

        AddPage(0);

        // Black panel — 1×1 unit (306×224 px approx with cornerSize=18, ch=206)
        AddBackgroundByUnits(sx, sy, 1, 1, ZuluGumpStyles.Black);

        // Close button
        AddButton(sx + 10, sy - 18, 2093, 2093, 0);

        // Title ribbon
        AddBackground(sx + 60, sy - 10, 186, 26, 9300);
        AddLabelHtml(sx + 60, sy - 8, 186, 22, $"{elemName} Shrine", ColTitle, 5, true);

        var y = sy + margin;

        AddLabelHtml(sx + margin, y, 274, 20, "Choose your reward:", ColLabel, 4, true);
        y += 28;

        // ── Option 1: Weapon ─────────────────────────────────────────────────
        AddButton(sx + margin, y + 8, 2151, 2152, 1, GumpButtonType.Reply, 0);
        AddItem(sx + margin + 22, y - 2, GetWeaponItemID(), elemHue);
        AddLabelHtml(sx + margin + 64, y + 6, 200, 20, GetWeaponName(), ColValue, 4, false);
        y += 44;

        // Divider
        AddImageTiled(sx + margin, y, 274, 3, 96);
        y += 10;

        // ── Option 2: Plate Armor Set ────────────────────────────────────────
        AddButton(sx + margin, y + 8, 2151, 2152, 2, GumpButtonType.Reply, 0);
        AddItem(sx + margin + 22, y - 2, 0x1412, elemHue); // PlateHelm preview
        AddLabelHtml(sx + margin + 64, y + 6, 200, 20, "Plate Armor Set (6 pcs)", ColValue, 4, false);
        y += 44;

        // Divider
        AddImageTiled(sx + margin, y, 274, 3, 96);
        y += 10;

        // Warning text
        AddLabelHtml(sx + margin, y, 274, 36,
            "All 9 pentagram pieces will be consumed.", ColWarn, 3, true);
    }

    private int GetWeaponItemID() => _element switch
    {
        PentagramElement.Water  => 0x1405, // WarFork
        PentagramElement.Earth  => 0x1439, // WarHammer
        PentagramElement.Air    => 0x13B2, // Bow
        PentagramElement.Fire   => 0x13FF, // Katana
        PentagramElement.Shadow => 0x0E87, // Pitchfork
        PentagramElement.Poison => 0x1401, // Kryss
        _                       => 0x1405
    };

    private string GetWeaponName() => _element switch
    {
        PentagramElement.Water  => "War Fork",
        PentagramElement.Earth  => "War Hammer",
        PentagramElement.Air    => "Bow",
        PentagramElement.Fire   => "Katana",
        PentagramElement.Shadow => "Pitchfork",
        PentagramElement.Poison => "Kryss",
        _                       => "Weapon"
    };

    public override void OnResponse(NetState sender, in RelayInfo info)
    {
        if (info.ButtonID is not (1 or 2))
        {
            return;
        }

        var from = sender.Mobile;
        if (from?.Backpack == null || from.Deleted)
        {
            return;
        }

        // Find and consume all 9 pieces (searches sub-bags up to 3 levels)
        var pieces = PentagramElementInfo.FindPieces(from.Backpack, _element);
        if (pieces.Count < PentagramElementInfo.PieceCount)
        {
            from.SendMessage("You no longer have all 9 pentagram pieces.");
            return;
        }

        // Consume all 9 pieces
        foreach (var kvp in pieces)
        {
            kvp.Value.Delete();
        }

        // Give reward
        var pack = from.Backpack;
        switch (info.ButtonID)
        {
            case 1:
                GiveWeapon(pack);
                break;
            case 2:
                GiveArmorSet(pack);
                break;
        }

        from.SendMessage($"The {PentagramElementInfo.GetName(_element)} Shrine Lord has rewarded you!");
        _shrineLord?.Say("May the elements guide you, warrior.");
    }

    private void GiveWeapon(Container pack)
    {
        Item weapon = _element switch
        {
            PentagramElement.Water  => new WaterElementWarFork(),
            PentagramElement.Earth  => new EarthElementWarHammer(),
            PentagramElement.Air    => new AirElementBow(),
            PentagramElement.Fire   => new FireElementKatana(),
            PentagramElement.Shadow => new ShadowElementPitchfork(),
            PentagramElement.Poison => new PoisonElementKryss(),
            _                       => null
        };

        if (weapon != null)
        {
            pack.DropItem(weapon);
        }
    }

    private void GiveArmorSet(Container pack)
    {
        pack.DropItem(new ElementalPlateChest(_element));
        pack.DropItem(new ElementalPlateLegs(_element));
        pack.DropItem(new ElementalPlateHelm(_element));
        pack.DropItem(new ElementalPlateGorget(_element));
        pack.DropItem(new ElementalPlateArms(_element));
        pack.DropItem(new ElementalPlateGloves(_element));
    }
}
