using ModernUO.Serialization;

namespace Server.Items;

// Zulu Hotel — Earth Magic spell scrolls (IDs 750-765).
// Use standard scroll graphic (0x1F2E) with earth hue (0x48A).
// Double-clicking casts the spell (from backpack); drag into EarthBook to learn.

[SerializationGenerator(0, false)]
public partial class AntidoteScroll : SpellScroll
{
    [Constructible]
    public AntidoteScroll(int amount = 1) : base(750, 0x1F2E, amount)
    {
        Hue = 0x48A;
        Name = "Antidote Scroll";
    }
}

[SerializationGenerator(0, false)]
public partial class OwlSightScroll : SpellScroll
{
    [Constructible]
    public OwlSightScroll(int amount = 1) : base(751, 0x1F2E, amount)
    {
        Hue = 0x48A;
        Name = "Owl Sight Scroll";
    }
}

[SerializationGenerator(0, false)]
public partial class ShiftingEarthScroll : SpellScroll
{
    [Constructible]
    public ShiftingEarthScroll(int amount = 1) : base(752, 0x1F2E, amount)
    {
        Hue = 0x48A;
        Name = "Shifting Earth Scroll";
    }
}

[SerializationGenerator(0, false)]
public partial class SummonMammalsScroll : SpellScroll
{
    [Constructible]
    public SummonMammalsScroll(int amount = 1) : base(753, 0x1F2E, amount)
    {
        Hue = 0x48A;
        Name = "Summon Mammals Scroll";
    }
}

[SerializationGenerator(0, false)]
public partial class CallLightningScroll : SpellScroll
{
    [Constructible]
    public CallLightningScroll(int amount = 1) : base(754, 0x1F2E, amount)
    {
        Hue = 0x48A;
        Name = "Call Lightning Scroll";
    }
}

[SerializationGenerator(0, false)]
public partial class EarthBlessingScroll : SpellScroll
{
    [Constructible]
    public EarthBlessingScroll(int amount = 1) : base(755, 0x1F2E, amount)
    {
        Hue = 0x48A;
        Name = "Earth Blessing Scroll";
    }
}

[SerializationGenerator(0, false)]
public partial class EarthPortalScroll : SpellScroll
{
    [Constructible]
    public EarthPortalScroll(int amount = 1) : base(756, 0x1F2E, amount)
    {
        Hue = 0x48A;
        Name = "Earth Portal Scroll";
    }
}

[SerializationGenerator(0, false)]
public partial class NaturesTouchScroll : SpellScroll
{
    [Constructible]
    public NaturesTouchScroll(int amount = 1) : base(757, 0x1F2E, amount)
    {
        Hue = 0x48A;
        Name = "Nature's Touch Scroll";
    }
}

[SerializationGenerator(0, false)]
public partial class GustOfAirScroll : SpellScroll
{
    [Constructible]
    public GustOfAirScroll(int amount = 1) : base(758, 0x1F2E, amount)
    {
        Hue = 0x48A;
        Name = "Gust of Air Scroll";
    }
}

[SerializationGenerator(0, false)]
public partial class RisingFireScroll : SpellScroll
{
    [Constructible]
    public RisingFireScroll(int amount = 1) : base(759, 0x1F2E, amount)
    {
        Hue = 0x48A;
        Name = "Rising Fire Scroll";
    }
}

[SerializationGenerator(0, false)]
public partial class ShapeshiftScroll : SpellScroll
{
    [Constructible]
    public ShapeshiftScroll(int amount = 1) : base(760, 0x1F2E, amount)
    {
        Hue = 0x48A;
        Name = "Shapeshift Scroll";
    }
}

[SerializationGenerator(0, false)]
public partial class IceStrikeScroll : SpellScroll
{
    [Constructible]
    public IceStrikeScroll(int amount = 1) : base(761, 0x1F2E, amount)
    {
        Hue = 0x48A;
        Name = "Ice Strike Scroll";
    }
}

[SerializationGenerator(0, false)]
public partial class EarthSpiritScroll : SpellScroll
{
    [Constructible]
    public EarthSpiritScroll(int amount = 1) : base(762, 0x1F2E, amount)
    {
        Hue = 0x48A;
        Name = "Earth Spirit Scroll";
    }
}

[SerializationGenerator(0, false)]
public partial class FlameSpiritScroll : SpellScroll
{
    [Constructible]
    public FlameSpiritScroll(int amount = 1) : base(763, 0x1F2E, amount)
    {
        Hue = 0x48A;
        Name = "Flame Spirit Scroll";
    }
}

[SerializationGenerator(0, false)]
public partial class StormSpiritScroll : SpellScroll
{
    [Constructible]
    public StormSpiritScroll(int amount = 1) : base(764, 0x1F2E, amount)
    {
        Hue = 0x48A;
        Name = "Storm Spirit Scroll";
    }
}

[SerializationGenerator(0, false)]
public partial class WaterSpiritScroll : SpellScroll
{
    [Constructible]
    public WaterSpiritScroll(int amount = 1) : base(765, 0x1F2E, amount)
    {
        Hue = 0x48A;
        Name = "Water Spirit Scroll";
    }
}
