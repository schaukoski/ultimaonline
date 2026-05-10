using ModernUO.Serialization;

namespace Server.Items;

public abstract partial class BaseArmor
{
    public bool CanEquipZulu(Mobile from) => ZuluClassRestrictions.IsEquipAllowed(from, this);

    [SerializableProperty(25)]
    public int ZuluMaterialId { get; set; }

    [SerializableProperty(26)]
    public string ZuluMaterialName { get; set; }
}
