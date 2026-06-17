using ModernUO.Serialization;
using Server.Zulu.Crafting;

namespace Server.Items;

[SerializationGenerator(0)]
public partial class ZuluOre : Item
{
    [SerializableProperty(0)]
    [CommandProperty(AccessLevel.GameMaster)]
    public int MaterialId
    {
        get => _materialId;
        set
        {
            _materialId = value;
            ApplyMaterial();
            this.MarkDirty();
        }
    }

    [Constructible]
    public ZuluOre(int materialId = 0, int amount = 1) : base(0x19B9)
    {
        Stackable = true;
        Amount = amount;
        _materialId = materialId;
        ApplyMaterial();
    }

    public override double DefaultWeight => 2.0;

    private void ApplyMaterial()
    {
        var def = ZuluMaterialRegistry.Get(_materialId);
        if (def == null)
        {
            Hue = 0;
            ItemID = 0x19B9;
            return;
        }

        Hue = def.Hue;
        ItemID = def.OreItemId == 0 ? 0x19B9 : def.OreItemId;
    }

    public override bool CanStackWith(Item dropped) =>
        dropped is ZuluOre other && other._materialId == _materialId && base.CanStackWith(dropped);

    public override void AddNameProperty(IPropertyList list)
    {
        var def = ZuluMaterialRegistry.Get(_materialId);
        var name = def?.Name ?? "Unknown";

        if (Amount > 1)
        {
            list.Add($"{Amount} {name} ore");
        }
        else
        {
            list.Add($"{name} ore");
        }
    }
}
