using ModernUO.Serialization;
using System;

namespace Server;

public partial class Item
{
    [SerializableProperty(0)]
    public double[] ZuluModifiers { get; set; } = new double[Enum.GetValues<ZuluMod>().Length];

    public bool IsEquippableLayer =>
        Layer >= Layer.FirstValid
        && Layer <= Layer.LastUserValid
        && Layer != Layer.Hair
        && Layer != Layer.FacialHair
        && Layer != Layer.Backpack
        && Layer != Layer.Unused_xF;
}
