using ModernUO.Serialization;
using Server.Zulu.Crafting;

namespace Server.Items;

[SerializationGenerator(0)]
public partial class ZuluIngot : Item
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
    public ZuluIngot(int materialId = 0, int amount = 1) : base(0x1BF2)
    {
        Stackable = true;
        Amount = amount;
        _materialId = materialId;
        ApplyMaterial();
    }

    public override double DefaultWeight => 0.1;

    private void ApplyMaterial()
    {
        var def = ZuluMaterialRegistry.Get(_materialId);
        if (def == null)
        {
            Hue = 0;
            ItemID = 0x1BF2;
            return;
        }

        Hue = def.Hue;
        ItemID = def.IngotItemId == 0 ? 0x1BF2 : def.IngotItemId;
    }

    public override bool CanStackWith(Item dropped) =>
        dropped is ZuluIngot other && other._materialId == _materialId && base.CanStackWith(dropped);

    public override void AddNameProperty(IPropertyList list)
    {
        var def = ZuluMaterialRegistry.Get(_materialId);
        var name = def?.Name ?? "Unknown";

        if (Amount > 1)
        {
            list.Add($"{Amount} {name} ingots");
        }
        else
        {
            list.Add($"{name} ingot");
        }
    }
}
