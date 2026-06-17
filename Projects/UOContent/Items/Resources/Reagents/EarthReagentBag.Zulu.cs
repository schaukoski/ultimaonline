using ModernUO.Serialization;

namespace Server.Items;

// Zulu Hotel — pre-filled bag of Earth Magic reagents.
// Same pattern as BagOfAllReagents. Created by [EarthBag command.
[SerializationGenerator(0, false)]
public partial class EarthReagentBag : Bag
{
    [Constructible]
    public EarthReagentBag(int amount = 60)
    {
        Name = "Earth Magic Reagents";
        Hue = 0x48A;

        DropItem(new FertileDirt(amount));
        DropItem(new PigIron(amount));
        DropItem(new BatWing(amount));
        DropItem(new Bone(amount));
        DropItem(new DragonsBlood(amount));
        DropItem(new EyeOfNewt(amount));
        DropItem(new Brimstone(amount));
        DropItem(new Obsidian(amount));
        DropItem(new VolcanicAsh(amount));
        DropItem(new ZuluDeadwood(amount));
        DropItem(new SerpentsScales(amount));
        DropItem(new BlackMoor(amount));
        DropItem(new WormsHeart(amount));
        DropItem(new Pumice(amount));
        DropItem(new VialOfBlood(amount));
        DropItem(new ZuluExecutionersCap(amount));
    }
}
