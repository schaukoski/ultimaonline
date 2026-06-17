using System;
using Server.Engines.Craft;

namespace Server.Zulu.Crafting;

public class ZuluCraftRes
{
    private string _name;

    public ZuluCraftRes(Type type, string name, int amount, string message = null)
    {
        ItemType = type;
        Amount = amount;
        _name = name;
        Message = message;
    }

    public Type ItemType { get; }
    public string Message { get; }
    public string Name => _name ??= GetTypeLabel(ItemType);
    public int Amount { get; }

    private static string GetTypeLabel(Type type) => type?.Name ?? "?";

    public void SendMessage(Mobile from)
    {
        if (!string.IsNullOrEmpty(Message))
        {
            from.SendMessage(Message);
        }
        else
        {
            from.SendLocalizedMessage(502925); // You don't have the resources required to make that item.
        }
    }
}
