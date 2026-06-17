using System.Collections.Generic;

namespace Server.Zulu.Crafting;

public class ZuluCraftGroup
{
    private readonly List<ZuluCraftItem> _craftItems = new();

    public ZuluCraftGroup(string name)
    {
        Name = name;
    }

    public string Name { get; }
    public IReadOnlyList<ZuluCraftItem> CraftItems => _craftItems;

    public void AddCraftItem(ZuluCraftItem craftItem) => _craftItems.Add(craftItem);
}
