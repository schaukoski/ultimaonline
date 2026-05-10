using System;
using ModernUO.Serialization;

namespace Server.Items;

// ─────────────────────────────────────────────────────────────────────────────
// Each element's plate armor set: 6 pieces (Chest, Legs, Helm, Gorget, Arms, Gloves).
// All share the same structure — element hue, name, and elemental protection mod.
// AR values and protection levels come from POL itemdesc.cfg.
//
// Protection CProps from POL (level × 10 = %):
//   Water  i3 → 30%   Fire  i3 → 30%   Air i3 → 30%
//   Earth  i3 → 30%   Shadow(Necro) i3 → 30%   Poison i3 → 30%
//   (Gorget/Gloves typically i2 → 20%)
// ─────────────────────────────────────────────────────────────────────────────

/// <summary>
/// Configuration per element for the armor reward set.
/// </summary>
internal static class ElementalArmorConfig
{
    public record struct Config(string Name, int Hue, ZuluMod Protection, int MajorProt, int MinorProt);

    public static Config Get(PentagramElement element) => element switch
    {
        PentagramElement.Water  => new("Water",  1167, ZuluMod.WaterProtection,   30, 20),
        PentagramElement.Earth  => new("Earth",  1538, ZuluMod.EarthProtection,   30, 20),
        PentagramElement.Air    => new("Air",    1161, ZuluMod.AirProtection,     30, 20),
        PentagramElement.Fire   => new("Fire",   139,  ZuluMod.FireProtection,    30, 20),
        PentagramElement.Shadow => new("Shadow", 1157, ZuluMod.NecroProtection,   30, 20),
        PentagramElement.Poison => new("Poison", 1162, ZuluMod.PoisonProtection,  30, 20),
        _                       => new("Unknown", 0,   ZuluMod.None,              0,  0)
    };
}

// ── Chest ────────────────────────────────────────────────────────────────────
[SerializationGenerator(0, false)]
public partial class ElementalPlateChest : PlateChest
{
    [SerializableField(0)]
    private PentagramElement _element;

    [Constructible]
    public ElementalPlateChest() : this(PentagramElement.Water)
    {
    }

    public ElementalPlateChest(PentagramElement element)
    {
        _element = element;
        var cfg = ElementalArmorConfig.Get(element);
        Name = $"Breastplate of the {cfg.Name} Element";
        Hue = cfg.Hue;
    }
}

// ── Legs ─────────────────────────────────────────────────────────────────────
[SerializationGenerator(0, false)]
public partial class ElementalPlateLegs : PlateLegs
{
    [SerializableField(0)]
    private PentagramElement _element;

    [Constructible]
    public ElementalPlateLegs() : this(PentagramElement.Water)
    {
    }

    public ElementalPlateLegs(PentagramElement element)
    {
        _element = element;
        var cfg = ElementalArmorConfig.Get(element);
        Name = $"Platelegs of the {cfg.Name} Element";
        Hue = cfg.Hue;
    }
}

// ── Helm ─────────────────────────────────────────────────────────────────────
[SerializationGenerator(0, false)]
public partial class ElementalPlateHelm : PlateHelm
{
    [SerializableField(0)]
    private PentagramElement _element;

    [Constructible]
    public ElementalPlateHelm() : this(PentagramElement.Water)
    {
    }

    public ElementalPlateHelm(PentagramElement element)
    {
        _element = element;
        var cfg = ElementalArmorConfig.Get(element);
        Name = $"Platehelm of the {cfg.Name} Element";
        Hue = cfg.Hue;
    }
}

// ── Gorget ───────────────────────────────────────────────────────────────────
[SerializationGenerator(0, false)]
public partial class ElementalPlateGorget : PlateGorget
{
    [SerializableField(0)]
    private PentagramElement _element;

    [Constructible]
    public ElementalPlateGorget() : this(PentagramElement.Water)
    {
    }

    public ElementalPlateGorget(PentagramElement element)
    {
        _element = element;
        var cfg = ElementalArmorConfig.Get(element);
        Name = $"Plategorget of the {cfg.Name} Element";
        Hue = cfg.Hue;
    }
}

// ── Arms ─────────────────────────────────────────────────────────────────────
[SerializationGenerator(0, false)]
public partial class ElementalPlateArms : PlateArms
{
    [SerializableField(0)]
    private PentagramElement _element;

    [Constructible]
    public ElementalPlateArms() : this(PentagramElement.Water)
    {
    }

    public ElementalPlateArms(PentagramElement element)
    {
        _element = element;
        var cfg = ElementalArmorConfig.Get(element);
        Name = $"Platearms of the {cfg.Name} Element";
        Hue = cfg.Hue;
    }
}

// ── Gloves ───────────────────────────────────────────────────────────────────
[SerializationGenerator(0, false)]
public partial class ElementalPlateGloves : PlateGloves
{
    [SerializableField(0)]
    private PentagramElement _element;

    [Constructible]
    public ElementalPlateGloves() : this(PentagramElement.Water)
    {
    }

    public ElementalPlateGloves(PentagramElement element)
    {
        _element = element;
        var cfg = ElementalArmorConfig.Get(element);
        Name = $"Plategloves of the {cfg.Name} Element";
        Hue = cfg.Hue;
    }
}
