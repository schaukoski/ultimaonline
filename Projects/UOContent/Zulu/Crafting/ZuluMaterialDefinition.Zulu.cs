using System.Collections.Generic;

namespace Server.Zulu.Crafting;

public sealed class ZuluMaterialDefinition
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ZuluCraftCategory Category { get; set; }
    public int Hue { get; set; }
    public int OreItemId { get; set; }
    public int IngotItemId { get; set; }
    public double Difficulty { get; set; }
    public double QualityFactor { get; set; } = 1.0;
    public double DurabilityFactor { get; set; } = 1.0;
    public List<ZuluMaterialMod> Mods { get; set; } = new();
}
