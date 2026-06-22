using Server.Commands;
using Server.Items;
using Server.Zulu.Crafting;

namespace Server;

/// <summary>
/// GM command for testing the Zulu Hotel crafting systems.
/// [ZuluIngotBag — creates a bag with 1000 ingots of every metal material plus the
/// relevant crafting/mining tools (Zulu smith hammer, tinker tools, pickaxe, shovel).
/// </summary>
public static class IngotBagCommand
{
    private const int DefaultAmount = 1000;

    public static void Initialize()
    {
        CommandSystem.Register("ZuluIngotBag", AccessLevel.GameMaster, ZuluIngotBag_OnCommand);
    }

    [Usage("ZuluIngotBag")]
    [Description("Creates a bag with 1000 of every Zulu metal ingot plus crafting and mining tools.")]
    private static void ZuluIngotBag_OnCommand(CommandEventArgs e)
    {
        var from = e.Mobile;
        if (from.Backpack == null)
        {
            from.SendMessage("You need a backpack.");
            return;
        }

        var bag = new Bag
        {
            Name = "Zulu Ingot Collection",
            Hue = 1153
        };

        var count = 0;
        foreach (var material in ZuluMaterialRegistry.ByCategory(ZuluCraftCategory.Metal))
        {
            bag.DropItem(new ZuluIngot(material.Id, DefaultAmount));
            count++;
        }

        // Crafting tools
        bag.DropItem(new SmithHammer());   // opens the Zulu blacksmithy gump
        bag.DropItem(new TinkerTools());   // vanilla tinkering for now (no Zulu tinkering system yet)

        // Mining tools
        bag.DropItem(new Pickaxe());
        bag.DropItem(new Shovel());

        from.Backpack.DropItem(bag);
        from.SendMessage($"A bag with {count} Zulu metal ingots and crafting/mining tools has been placed in your backpack.");
    }
}
