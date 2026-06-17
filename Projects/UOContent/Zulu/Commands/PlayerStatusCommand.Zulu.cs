using Server.Commands;
using Server.Gumps;
using Server.Zulu.Gumps;

namespace Server;

public static class PlayerStatusCommand
{
    public static void Initialize()
    {
        CommandSystem.Register("status", AccessLevel.Player, OnCommand);
    }

    private static void OnCommand(CommandEventArgs e)
    {
        if (e.Mobile == null)
            return;

        e.Mobile.SendGump(new PlayerStatusGump(e.Mobile));
    }
}
