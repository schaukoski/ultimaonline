using ModernUO.Serialization;
using System;

namespace Server;

public partial class Item
{
    [SerializableProperty(0)]
    public double[] ZuluModifiers { get; set; } = new double[Enum.GetValues<ZuluMod>().Length];

}
