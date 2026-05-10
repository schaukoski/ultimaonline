using Server.Gumps;
using Server.Zulu.Crafting;
using Server.Zulu.Crafting.Systems;

namespace Server.Items;

public partial class SmithHammer
{
    public override void OnDoubleClick(Mobile from)
    {
        if (!IsChildOf(from.Backpack) && Parent != from)
        {
            from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it.
            return;
        }

        var system = ZuluBlacksmithy.CraftSystem;
        var num = system.CanCraft(from, this, null);

        if (num > 0)
        {
            from.SendLocalizedMessage(num);
            return;
        }

        from.SendGump(new ZuluCraftGump(from, system, this, null));
    }
}
