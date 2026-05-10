using System.Collections.Generic;

namespace Server.Zulu.Crafting;

public enum ZuluCraftMarkOption
{
    MarkItem,
    DoNotMark,
    PromptForMark,
}

public class ZuluCraftContext
{
    public ZuluCraftContext()
    {
        Items = new List<ZuluCraftItem>();
        LastResourceIndex = -1;
        LastResourceIndex2 = -1;
        LastGroupIndex = -1;
    }

    public List<ZuluCraftItem> Items { get; }
    public int LastResourceIndex { get; set; }
    public int LastResourceIndex2 { get; set; }
    public int LastGroupIndex { get; set; }
    public bool DoNotColor { get; set; }
    public ZuluCraftMarkOption MarkOption { get; set; }

    public ZuluCraftItem LastMade => Items.Count > 0 ? Items[0] : null;

    public void OnMade(ZuluCraftItem item)
    {
        Items.Remove(item);

        if (Items.Count == 10)
        {
            Items.RemoveAt(9);
        }

        Items.Insert(0, item);
    }
}
