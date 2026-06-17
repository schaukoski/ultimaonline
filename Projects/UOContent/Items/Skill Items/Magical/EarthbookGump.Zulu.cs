using Server.Gumps;
using Server.Network;
using Server.Spells;

namespace Server.Items;

// Zulu Hotel — Server-drawn gump for the Book of the Earth.
// Replicates the POL earthbook gump (gumppic 2203) with two circles of 8 spells each.
// Spell buttons cast the spell when clicked (book must be in backpack or equipped).
// To learn spells: drag an Earth scroll directly onto the book item.
public class EarthbookGump : Gump
{
    // Button ID range 750-765 maps directly to spell IDs
    private const int ButtonClose = 0;

    private static readonly (int SpellId, string Name)[] _circle1 =
    [
        (750, "Antidote"),
        (751, "Owl Sight"),
        (752, "Shifting Earth"),
        (753, "Summon Mammals"),
        (754, "Call Lightning"),
        (755, "Earth Blessing"),
        (756, "Earth Portal"),
        (757, "Nature's Touch"),
    ];

    private static readonly (int SpellId, string Name)[] _circle2 =
    [
        (758, "Gust of Air"),
        (759, "Rising Fire"),
        (760, "Shapeshift"),
        (761, "Ice Strike"),
        (762, "Earth Spirit"),
        (763, "Flame Spirit"),
        (764, "Storm Spirit"),
        (765, "Water Spirit"),
    ];

    private readonly EarthBook _book;

    public EarthbookGump(Mobile user, EarthBook book) : base(50, 50)
    {
        _book = book;

        AddPage(0);

        // Book background image (gumppic 2203 — same as POL earthbook.src)
        AddImage(0, 0, 2203);

        // Circle headers
        AddHtml(58, 22, 110, 18, "<basefont color=#00AA00><b>Ciclo I</b></basefont>", false, false);
        AddHtml(218, 22, 110, 18, "<basefont color=#00AA00><b>Ciclo II</b></basefont>", false, false);

        // Circle 1 spells — left column
        for (var i = 0; i < _circle1.Length; i++)
        {
            var (spellId, name) = _circle1[i];

            if (!book.HasSpell(spellId))
            {
                continue;
            }

            var y = 50 + i * 20;
            AddButton(40, y + 2, 2103, 2104, spellId, GumpButtonType.Reply, 0);
            AddHtml(58, y, 130, 20, $"<basefont color=#FFFFFF>{name}</basefont>", false, false);
        }

        // Circle 2 spells — right column
        for (var i = 0; i < _circle2.Length; i++)
        {
            var (spellId, name) = _circle2[i];

            if (!book.HasSpell(spellId))
            {
                continue;
            }

            var y = 50 + i * 20;
            AddButton(200, y + 2, 2103, 2104, spellId, GumpButtonType.Reply, 0);
            AddHtml(218, y, 130, 20, $"<basefont color=#FFFFFF>{name}</basefont>", false, false);
        }

        // Hint at bottom: drag scroll onto the book to learn spells
        AddHtml(30, 278, 290, 18,
            "<basefont color=#888888>Arraste scrolls sobre o livro para aprender magias</basefont>",
            false, false);
    }

    public override void OnResponse(NetState sender, in RelayInfo info)
    {
        var buttonId = info.ButtonID;

        if (buttonId is < 750 or > 765)
        {
            return;
        }

        var from = sender.Mobile;
        var spellId = buttonId;

        if (!_book.HasSpell(spellId))
        {
            return;
        }

        // Book must be accessible (equipped or in backpack)
        if (Spellbook.Find(from, spellId) == null)
        {
            from.SendMessage("O livro precisa estar equipado ou na sua mochila.");
            return;
        }

        var spell = SpellRegistry.NewSpell(spellId, from, null);
        spell?.Cast();
    }
}
