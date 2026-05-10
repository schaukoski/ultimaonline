using System;
using Server.Commands;
using Server.Items;

namespace Server;

/// <summary>
/// GM commands for the pentagram collection system.
/// [PentagramBag — creates a bag with all 9 pieces for each of the 6 elements (54 items total).
/// </summary>
public static class PentagramCommands
{
    public static void Initialize()
    {
        CommandSystem.Register("PentagramBag", AccessLevel.GameMaster, PentagramBag_OnCommand);
    }

    [Usage("PentagramBag")]
    [Description("Creates a bag containing all 54 pentagram pieces (9 per element × 6 elements).")]
    private static void PentagramBag_OnCommand(CommandEventArgs e)
    {
        var from = e.Mobile;
        if (from.Backpack == null)
        {
            from.SendMessage("You need a backpack.");
            return;
        }

        var mainBag = new Bag
        {
            Name = "Pentagram Collection",
            Hue = 1153
        };

        foreach (PentagramElement element in Enum.GetValues<PentagramElement>())
        {
            var elementBag = new Bag
            {
                Name = $"{PentagramElementInfo.GetName(element)} Pentagrams",
                Hue = PentagramElementInfo.GetPieceHue(element)
            };

            for (var piece = 1; piece <= PentagramElementInfo.PieceCount; piece++)
            {
                elementBag.DropItem(new PentagramPiece(element, piece));
            }

            mainBag.DropItem(elementBag);
        }

        from.Backpack.DropItem(mainBag);
        from.SendMessage("A bag with all 54 pentagram pieces has been placed in your backpack.");
    }
}
