using System;

namespace Server.Zulu.Crafting;

[AttributeUsage(AttributeTargets.Class)]
public class ZuluCraftItemIDAttribute : Attribute
{
    public ZuluCraftItemIDAttribute(int itemId)
    {
        ItemId = itemId;
    }

    public int ItemId { get; }
}
