using ModernUO.Serialization;
using Server.Gumps;
using Server.Network;

namespace Server.Items;

// Zulu Hotel — Book of the Earth
// ItemID: 0xFF2, Hue: 0x48A (green-earth)
// BookOffset: 750, spells 750-765 (16 spells)
// Uses a custom server-drawn gump (EarthbookGump) matching the POL layout.
[SerializationGenerator(0, false)]
public partial class EarthBook : Spellbook
{
    [Constructible]
    public EarthBook(ulong content = 0xFFFF) : base(content, 0xFF2)
    {
        Hue = 0x48A;
        Layer = Layer.OneHanded;
        Name = "Book of the Earth";
    }

    public override SpellbookType SpellbookType => SpellbookType.EarthMagic;
    public override int BookOffset => 750;
    public override int BookCount => 16;

    public override void DisplayTo(Mobile to)
    {
        // The client must know about the item before we send the gump
        var ns = to.NetState;

        if (ns.CannotSendPackets())
        {
            return;
        }

        if (Parent == null)
        {
            SendWorldPacketTo(ns);
        }
        else if (Parent is Item)
        {
            ns.SendContainerContentUpdate(this);
        }
        else if (Parent is Mobile)
        {
            ns.SendEquipUpdate(this);
        }

        // Show the custom Earth Magic gump instead of the standard spellbook packet
        to.SendGump(new EarthbookGump(to, this));
    }

    public override void OnDoubleClick(Mobile from)
    {
        if (!from.InRange(GetWorldLocation(), 2))
        {
            from.SendLocalizedMessage(500446); // That is too far away.
            return;
        }

        DisplayTo(from);
    }
}
