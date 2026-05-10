using Server.Commands;
using Server.Gumps;
using Server.Network;
using static Server.ZuluGump;

namespace Server.Zulu.Gumps;

public class ZuluAdminGump : ZuluGump
{
    // Each entry: (ButtonID, CommandName, Label, AccessLevel)
    private static readonly (int Id, string Command, string Label, AccessLevel Access)[] _commands =
    [
        (1,  "warshard",     "Warshard",          AccessLevel.Player),
        (2,  "teste",        "Teste",             AccessLevel.Player),
        (3,  "PentagramBag", "Pentagram Bag",     AccessLevel.GameMaster),
        (4,  "ShellBag",     "Shell Bag",         AccessLevel.Developer),
        (5,  "SpawnZulu",    "Spawn Zulu",        AccessLevel.Developer),
        (6,  "EarthBag",     "Earth Reagent Bag", AccessLevel.Developer),
        (7,  "EarthKit",     "Earth Magic Kit",   AccessLevel.Developer),
        (8,  "ebook01",      "Earth: Antidote",        AccessLevel.Developer),
        (9,  "ebook02",      "Earth: Owl Sight",       AccessLevel.Developer),
        (10, "ebook03",      "Earth: Shifting Earth",  AccessLevel.Developer),
        (11, "ebook04",      "Earth: Summon Mammals",  AccessLevel.Developer),
        (12, "ebook05",      "Earth: Call Lightning",  AccessLevel.Developer),
        (13, "ebook06",      "Earth: Earth Blessing",  AccessLevel.Developer),
        (14, "ebook07",      "Earth: Earth Portal",    AccessLevel.Developer),
        (15, "ebook08",      "Earth: Nature's Touch",  AccessLevel.Developer),
        (16, "ebook09",      "Earth: Gust of Air",     AccessLevel.Developer),
        (17, "ebook10",      "Earth: Rising Fire",     AccessLevel.Developer),
        (18, "ebook11",      "Earth: Shapeshift",      AccessLevel.Developer),
        (19, "ebook12",      "Earth: Ice Strike",      AccessLevel.Developer),
        (20, "ebook13",      "Earth: Earth Spirit",    AccessLevel.Developer),
        (21, "ebook14",      "Earth: Flame Spirit",    AccessLevel.Developer),
        (22, "ebook15",      "Earth: Storm Spirit",    AccessLevel.Developer),
        (23, "ebook16",      "Earth: Water Spirit",    AccessLevel.Developer),
    ];

    public static void Configure()
    {
        CommandSystem.Register("ZuluAdmin", AccessLevel.Owner, ZuluAdmin_OnCommand);
    }

    [Usage("ZuluAdmin")]
    [Description("Opens the Zulu Admin command panel.")]
    private static void ZuluAdmin_OnCommand(CommandEventArgs e)
    {
        e.Mobile.SendGump(new ZuluAdminGump(e.Mobile));
    }

    public ZuluAdminGump(Mobile from) : base(20, 30)
    {
        AddPage(0);

        int startX = 80;
        int startY = 80;

        // Black background: 1 wide x 4 tall gives room for all commands
        AddBackgroundByUnits(startX, startY, 1, 4, ZuluGumpStyles.Black);

        // Close button
        AddButton(startX + 10, startY - 18, 2093, 2093, 0);

        // Title bar
        AddBackground(startX + 60, startY - 10, 180, 26, 9300);
        AddLabelHtml(startX + 60, startY - 8, 180, 22, "Zulu Admin", "#4A2E0A", 5, true);

        // Section: General Commands
        int rowY = startY + 25;
        AddLabelHtml(startX + 12, rowY, 260, 20, "General Commands", "#F5CD3B", 4, true);
        rowY += 22;
        AddImageTiled(startX + 3, rowY, 295, 3, 96);
        rowY += 10;

        // General commands (first 7)
        for (int i = 0; i < 7; i++)
        {
            var cmd = _commands[i];
            AddButton(startX + 14, rowY + 2, ZuluGumpButtons.GreenArrowRight, GumpButtonType.Reply, cmd.Id);
            AddLabelHtml(startX + 38, rowY, 200, 20, cmd.Label, "#FFFFFF", 4, false);
            AddLabelHtml(startX + 210, rowY, 80, 20, $"{"[" + cmd.Access + "]"}", "#808080", 2, false);
            rowY += 24;
        }

        // Section: Earth Magic Spells
        rowY += 5;
        AddLabelHtml(startX + 12, rowY, 260, 20, "Earth Magic Spells", "#F5CD3B", 4, true);
        rowY += 22;
        AddImageTiled(startX + 3, rowY, 295, 3, 96);
        rowY += 10;

        // Earth spell commands (index 7..23)
        for (int i = 7; i < _commands.Length; i++)
        {
            var cmd = _commands[i];
            AddButton(startX + 14, rowY + 2, ZuluGumpButtons.BulletLeather, GumpButtonType.Reply, cmd.Id);
            AddLabelHtml(startX + 38, rowY, 230, 20, cmd.Label, "#FFFFFF", 4, false);
            rowY += 22;
        }

        // Footer
        rowY += 8;
        AddLabelHtml(startX + 75, rowY, 150, 24, "ZuluHotel New Age", "#363638", 4, true);
    }

    public override void OnResponse(NetState sender, in RelayInfo info)
    {
        base.OnResponse(sender, info);

        var from = sender.Mobile;

        if (from == null || info.ButtonID <= 0)
        {
            return;
        }

        // Find the command by button ID
        foreach (var cmd in _commands)
        {
            if (cmd.Id == info.ButtonID)
            {
                // Access check
                if (from.AccessLevel < cmd.Access)
                {
                    from.SendMessage("You do not have access to that command.");
                    return;
                }

                CommandSystem.Handle(from, $"{CommandSystem.Prefix}{cmd.Command}");

                // Re-open the gump for convenience (except SpawnZulu which is heavy)
                if (cmd.Command != "SpawnZulu")
                {
                    from.SendGump(new ZuluAdminGump(from));
                }

                return;
            }
        }
    }
}
