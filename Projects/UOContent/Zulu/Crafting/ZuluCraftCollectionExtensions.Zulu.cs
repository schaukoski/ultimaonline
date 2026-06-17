using System;
using System.Collections.Generic;

namespace Server.Zulu.Crafting;

public static class ZuluCraftCollectionExtensions
{
    public static int SearchFor(this List<ZuluCraftGroup> list, string groupName)
    {
        for (var i = 0; i < list.Count; i++)
        {
            if (list[i].Name == groupName)
            {
                return i;
            }
        }
        return -1;
    }

    public static ZuluCraftItem SearchForSubclass(this List<ZuluCraftItem> list, Type type)
    {
        for (var i = 0; i < list.Count; i++)
        {
            var ci = list[i];
            if (ci.ItemType == type || type.IsSubclassOf(ci.ItemType))
            {
                return ci;
            }
        }
        return null;
    }

    public static ZuluCraftItem SearchFor(this List<ZuluCraftItem> list, Type type)
    {
        for (var i = 0; i < list.Count; i++)
        {
            if (list[i].ItemType == type)
            {
                return list[i];
            }
        }
        return null;
    }
}
