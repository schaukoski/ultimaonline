using Server.Commands;
using Server.Items;

namespace Server;

/// <summary>
/// Developer commands for the fishing shell collection system.
/// [ShellBag — creates a bag with all 9 shell kinds for testing.
/// </summary>
public static class ShellCommands
{
    public static void Initialize()
    {
        CommandSystem.Register("ShellBag", AccessLevel.Developer, ShellBag_OnCommand);
    }

    [Usage("ShellBag")]
    [Description("Creates a bag containing one of each of the 9 collectible fishing shells.")]
    private static void ShellBag_OnCommand(CommandEventArgs e)
    {
        var from = e.Mobile;
        if (from.Backpack == null)
        {
            from.SendMessage("You need a backpack.");
            return;
        }

        var bag = new Bag
        {
            Name = "Shell Collection",
            Hue = 0x0489 // deep-sea blue
        };

        foreach (FishShellKind kind in System.Enum.GetValues<FishShellKind>())
        {
            bag.DropItem(new FishShell(kind));
        }

        from.Backpack.DropItem(bag);
        from.SendMessage("A bag with all 9 fishing shells has been placed in your backpack.");
    }
}
