using Server;
using Server.Commands;

namespace Server.Zulu.Commands;

public static class SpawnZuluCommand
{
    public static void Configure()
    {
        CommandSystem.Register("SpawnZulu", AccessLevel.Developer, SpawnZulu_OnCommand);
    }

    [Usage("SpawnZulu")]
    [Description("Generates all Zulu Hotel spawners from JSON files in Data/Spawns/zulu/")]
    private static void SpawnZulu_OnCommand(CommandEventArgs e)
    {
        var from = e.Mobile;
        from.SendMessage("SpawnZulu: Generating Zulu spawners...");

        CommandSystem.Handle(
            from,
            $"{CommandSystem.Prefix}ImportSpawners Data/Spawns/zulu/felucca/**.json"
        );

        from.SendMessage("SpawnZulu: Done. Check above messages for details.");
    }
}
