using System;
using Server.Commands;
using Server.Items;

namespace Server.Spells.Earth;

// Zulu Hotel — Earth Magic developer commands.
//
// Commands:
//   [ebook01 .. [ebook16   — Cast Earth spell by number (AccessLevel.Developer)
//   [EarthBag              — Creates a bag with 60 of each Earth Magic reagent (AccessLevel.Developer)
//   [EarthKit              — Creates a bag with an empty EarthBook + all 16 scrolls (AccessLevel.Developer)
public static class EarthCommands
{
    private static readonly (string Name, int SpellId)[] _spells =
    [
        ("ebook01", 750), // Antidote
        ("ebook02", 751), // Owl Sight
        ("ebook03", 752), // Shifting Earth
        ("ebook04", 753), // Summon Mammals
        ("ebook05", 754), // Call Lightning
        ("ebook06", 755), // Earth Blessing
        ("ebook07", 756), // Earth Portal
        ("ebook08", 757), // Nature's Touch
        ("ebook09", 758), // Gust of Air
        ("ebook10", 759), // Rising Fire
        ("ebook11", 760), // Shapeshift
        ("ebook12", 761), // Ice Strike
        ("ebook13", 762), // Earth Spirit
        ("ebook14", 763), // Flame Spirit
        ("ebook15", 764), // Storm Spirit
        ("ebook16", 765), // Water Spirit
    ];

    private static readonly Type[] _earthScrollTypes =
    [
        typeof(AntidoteScroll),      // 750
        typeof(OwlSightScroll),      // 751
        typeof(ShiftingEarthScroll), // 752
        typeof(SummonMammalsScroll), // 753
        typeof(CallLightningScroll), // 754
        typeof(EarthBlessingScroll), // 755
        typeof(EarthPortalScroll),   // 756
        typeof(NaturesTouchScroll),  // 757
        typeof(GustOfAirScroll),     // 758
        typeof(RisingFireScroll),    // 759
        typeof(ShapeshiftScroll),    // 760
        typeof(IceStrikeScroll),     // 761
        typeof(EarthSpiritScroll),   // 762
        typeof(FlameSpiritScroll),   // 763
        typeof(StormSpiritScroll),   // 764
        typeof(WaterSpiritScroll),   // 765
    ];

    public static void Configure()
    {
        foreach (var (name, spellId) in _spells)
        {
            var id = spellId; // capture for closure
            CommandSystem.Register(name, AccessLevel.Developer, e => CastEarthSpell(e, id));
        }

        CommandSystem.Register("EarthBag", AccessLevel.Developer, EarthBag_OnCommand);
        CommandSystem.Register("EarthKit", AccessLevel.Developer, EarthKit_OnCommand);
    }

    private static void CastEarthSpell(CommandEventArgs e, int spellId)
    {
        var spell = SpellRegistry.NewSpell(spellId, e.Mobile, null);

        if (spell == null)
        {
            e.Mobile.SendMessage($"Earth spell not found (id={spellId}).");
            return;
        }

        spell.Cast();
    }

    private static void EarthBag_OnCommand(CommandEventArgs e)
    {
        var pack = e.Mobile.Backpack;

        if (pack == null)
        {
            return;
        }

        pack.AddItem(new EarthReagentBag(60));

        e.Mobile.SendMessage(0x48A, "A bag with 60 of each Earth Magic reagent has been placed in your backpack.");
    }

    private static void EarthKit_OnCommand(CommandEventArgs e)
    {
        var pack = e.Mobile.Backpack;

        if (pack == null)
        {
            return;
        }

        var bag = new Bag
        {
            Name = "Earth Magic Kit",
            Hue = 0x48A
        };

        // Empty book — drag scrolls in to learn the spells
        bag.AddItem(new EarthBook(0));

        foreach (var type in _earthScrollTypes)
        {
            var scroll = (Item)Activator.CreateInstance(type, 1);
            bag.AddItem(scroll);
        }

        pack.AddItem(bag);

        e.Mobile.SendMessage(0x48A, "An Earth Magic Kit (empty book + all 16 scrolls) has been placed in your backpack.");
    }
}
