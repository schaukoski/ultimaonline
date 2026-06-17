using System;
using System.Collections.Generic;
using ModernUO.Serialization;

namespace Server.Items;

// ─────────────────────────────────────────────────────────────────────────────
// Zulu Hotel — Fishing Shell collection system.
//
// Ported from POL zhna 15-08-13 pkg/skills/fishing/config/itemdesc.cfg
//
// 9 collectible shells caught via fishing pole (1-5) or fishing net (5-9).
// Players bring all 9 to the Shell Shrine Lord for a reward.
//
// Pattern mirrors the existing Pentagram collection system.
// ─────────────────────────────────────────────────────────────────────────────

/// <summary>
/// 1 of 9 collectible shells ported from POL Zulu Hotel.
/// </summary>
public enum FishShellKind
{
    Aquaria           = 1, // 0x80ae (graphic 0xfc4, hue 0x504)
    Capricornia       = 2, // 0x80be (graphic 0xfc5, hue 0x519)
    SeaNymph          = 3, // 0x80ce (graphic 0xfc6, hue 0x606)
    NeptunesNautilus  = 4, // 0x80de (graphic 0xfc7, hue 0x505)
    SandDollar        = 5, // 0x80ee (graphic 0xfc8, hue 0x501)
    Divinia           = 6, // 0x81ae (graphic 0xfc9, hue 0x499)
    Mermaid           = 7, // 0x81be (graphic 0xfca, hue 0x48D)
    OceanOdyssey      = 8, // 0x81ce (graphic 0xfcb, hue 0x489)
    Talimari          = 9, // 0x81de (graphic 0xfcc, hue 0x496)
}

/// <summary>
/// Static info/lookups for the shell collection system.
/// </summary>
public static class FishShellInfo
{
    public const int ShellCount = 9;

    private static readonly (int Graphic, int Hue, string Name)[] _data =
    {
        (0x0FC4, 0x0504, "Aquaria Shell"),
        (0x0FC5, 0x0519, "Capricornia Shell"),
        (0x0FC6, 0x0606, "Sea Nymph Shell"),
        (0x0FC7, 0x0505, "Neptune's Nautilus"),
        (0x0FC8, 0x0501, "Sea Shore Sand Dollar"),
        (0x0FC9, 0x0499, "Divinia Shell"),
        (0x0FCA, 0x048D, "Mermaid Shell"),
        (0x0FCB, 0x0489, "Ocean Odyssey"),
        (0x0FCC, 0x0496, "Talimari Shell"),
    };

    public static int GetGraphic(FishShellKind k) => _data[(int)k - 1].Graphic;
    public static int GetHue(FishShellKind k)     => _data[(int)k - 1].Hue;
    public static string GetName(FishShellKind k) => _data[(int)k - 1].Name;

    /// <summary>
    /// Finds one FishShell for each kind in the container, searching sub-bags
    /// up to <paramref name="maxDepth"/> levels deep. Duplicates are ignored —
    /// only the first instance of each kind is returned.
    /// </summary>
    public static Dictionary<FishShellKind, FishShell> FindShells(
        Container container, int maxDepth = 3)
    {
        var result = new Dictionary<FishShellKind, FishShell>(ShellCount);
        if (container == null)
        {
            return result;
        }

        SearchContainer(container, result, 0, maxDepth);
        return result;
    }

    private static void SearchContainer(
        Container container,
        Dictionary<FishShellKind, FishShell> found,
        int currentDepth,
        int maxDepth)
    {
        foreach (var item in container.Items)
        {
            if (item is FishShell s && !found.ContainsKey(s.Kind))
            {
                found[s.Kind] = s;
            }
            else if (item is Container sub && currentDepth < maxDepth)
            {
                SearchContainer(sub, found, currentDepth + 1, maxDepth);
            }

            if (found.Count >= ShellCount)
            {
                return;
            }
        }
    }
}

/// <summary>
/// A single collectible fishing shell. Graphic, hue and name are driven by
/// <see cref="FishShellKind"/>.
/// </summary>
[SerializationGenerator(0, false)]
public partial class FishShell : Item
{
    [SerializableField(0)]
    private FishShellKind _kind;

    [Constructible]
    public FishShell() : this(FishShellKind.Aquaria)
    {
    }

    public FishShell(FishShellKind kind)
        : base(FishShellInfo.GetGraphic(kind))
    {
        _kind = kind;
        Hue = FishShellInfo.GetHue(kind);
        Name = FishShellInfo.GetName(kind);
        Weight = 1.0;
    }
}

// ── Convenience subclasses (one per shell, needed for [Add and loot tables) ──

[SerializationGenerator(0, false)]
public partial class AquariaShell : FishShell
{
    [Constructible] public AquariaShell() : base(FishShellKind.Aquaria) { }
}

[SerializationGenerator(0, false)]
public partial class CapricorniaShell : FishShell
{
    [Constructible] public CapricorniaShell() : base(FishShellKind.Capricornia) { }
}

[SerializationGenerator(0, false)]
public partial class SeaNymphShell : FishShell
{
    [Constructible] public SeaNymphShell() : base(FishShellKind.SeaNymph) { }
}

[SerializationGenerator(0, false)]
public partial class NeptunesNautilusShell : FishShell
{
    [Constructible] public NeptunesNautilusShell() : base(FishShellKind.NeptunesNautilus) { }
}

[SerializationGenerator(0, false)]
public partial class SandDollarShell : FishShell
{
    [Constructible] public SandDollarShell() : base(FishShellKind.SandDollar) { }
}

[SerializationGenerator(0, false)]
public partial class DiviniaShell : FishShell
{
    [Constructible] public DiviniaShell() : base(FishShellKind.Divinia) { }
}

[SerializationGenerator(0, false)]
public partial class MermaidShell : FishShell
{
    [Constructible] public MermaidShell() : base(FishShellKind.Mermaid) { }
}

[SerializationGenerator(0, false)]
public partial class OceanOdysseyShell : FishShell
{
    [Constructible] public OceanOdysseyShell() : base(FishShellKind.OceanOdyssey) { }
}

[SerializationGenerator(0, false)]
public partial class TalimariShell : FishShell
{
    [Constructible] public TalimariShell() : base(FishShellKind.Talimari) { }
}
