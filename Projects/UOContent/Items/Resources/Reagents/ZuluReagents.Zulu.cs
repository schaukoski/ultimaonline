using ModernUO.Serialization;

namespace Server.Items;

// Zulu Hotel custom reagents used by Earth Magic spells.
// ItemIDs match the POL reference (D:\OneDrive\Eduardo\Ultima Online Shards\zhna 15-08-13\config\itemdesc.cfg).

[SerializationGenerator(0, false)]
public partial class EyeOfNewt : BaseReagent
{
    [Constructible]
    public EyeOfNewt(int amount = 1) : base(0xF87, amount)
    {
        Hue = 0x48A;
        Name = "Eye Of Newt";
    }
}

[SerializationGenerator(0, false)]
public partial class Brimstone : BaseReagent
{
    [Constructible]
    public Brimstone(int amount = 1) : base(0xF7F, amount)
    {
        Hue = 0x96C;
        Name = "Brimstone";
    }
}

[SerializationGenerator(0, false)]
public partial class Obsidian : BaseReagent
{
    [Constructible]
    public Obsidian(int amount = 1) : base(0xF89, amount)
    {
        Hue = 0x497;
        Name = "Obsidian";
    }
}

[SerializationGenerator(0, false)]
public partial class VolcanicAsh : BaseReagent
{
    [Constructible]
    public VolcanicAsh(int amount = 1) : base(0xF8F, amount)
    {
        Hue = 0x021;
        Name = "Volcanic Ash";
    }
}

[SerializationGenerator(0, false)]
public partial class ZuluDeadwood : BaseReagent
{
    [Constructible]
    public ZuluDeadwood(int amount = 1) : base(0xF90, amount)
    {
        Hue = 0x455;
        Name = "Deadwood";
    }
}

[SerializationGenerator(0, false)]
public partial class SerpentsScales : BaseReagent
{
    [Constructible]
    public SerpentsScales(int amount = 1) : base(0xF8E, amount)
    {
        Hue = 0x44E;
        Name = "Serpent's Scales";
    }
}

[SerializationGenerator(0, false)]
public partial class BlackMoor : BaseReagent
{
    [Constructible]
    public BlackMoor(int amount = 1) : base(0xF79, amount)
    {
        Hue = 0x001;
        Name = "Black Moor";
    }
}

[SerializationGenerator(0, false)]
public partial class WormsHeart : BaseReagent
{
    [Constructible]
    public WormsHeart(int amount = 1) : base(0xF91, amount)
    {
        Hue = 0x26C;
        Name = "Worm's Heart";
    }
}

[SerializationGenerator(0, false)]
public partial class Pumice : BaseReagent
{
    [Constructible]
    public Pumice(int amount = 1) : base(0xF8B, amount)
    {
        Hue = 0x3B2;
        Name = "Pumice";
    }
}

[SerializationGenerator(0, false)]
public partial class VialOfBlood : BaseReagent
{
    [Constructible]
    public VialOfBlood(int amount = 1) : base(0xF7D, amount)
    {
        Hue = 0x26;
        Name = "Vial Of Blood";
    }
}

[SerializationGenerator(0, false)]
public partial class ZuluExecutionersCap : BaseReagent
{
    [Constructible]
    public ZuluExecutionersCap(int amount = 1) : base(0xF83, amount)
    {
        Hue = 0x8FD;
        Name = "Executioner's Cap";
    }
}
