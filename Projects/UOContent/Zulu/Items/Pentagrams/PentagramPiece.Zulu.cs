using System;
using System.Collections.Generic;
using ModernUO.Serialization;

namespace Server.Items;

/// <summary>
/// Elements available in the pentagram collection system.
/// Each element has 9 collectible pentagram pieces and a corresponding Shrine Lord.
/// </summary>
public enum PentagramElement
{
    Water,
    Earth,
    Air,
    Fire,
    Shadow,
    Poison
}

/// <summary>
/// Lookup table for element hue, display name, and shrine lord body/hue.
/// Piece hues sourced from POL pkg/items/pentagrams/config/itemdesc.cfg.
/// Shrine Lord hues sourced from POL config/npcdesc.cfg (differ for Water).
/// </summary>
public static class PentagramElementInfo
{
    public const int PieceCount = 9;
    public const int FirstGraphic = 0xFE6; // gump graphic 4070; pieces use 4070-4078

    /// <summary>Hue for the pentagram pieces.</summary>
    public static int GetPieceHue(PentagramElement element) => element switch
    {
        PentagramElement.Water  => 1167,
        PentagramElement.Earth  => 1538,
        PentagramElement.Air    => 1161,
        PentagramElement.Fire   => 139,
        PentagramElement.Shadow => 1157,
        PentagramElement.Poison => 1162,
        _                       => 0
    };

    /// <summary>Hue for the Shrine Lord NPC (Water differs from piece hue).</summary>
    public static int GetShrineLordHue(PentagramElement element) => element switch
    {
        PentagramElement.Water  => 1181,  // POL npcdesc.cfg — different from piece hue 1167
        PentagramElement.Earth  => 1538,
        PentagramElement.Air    => 1161,
        PentagramElement.Fire   => 139,
        PentagramElement.Shadow => 1157,
        PentagramElement.Poison => 1162,
        _                       => 0
    };

    public static string GetName(PentagramElement element) => element switch
    {
        PentagramElement.Water  => "Water",
        PentagramElement.Earth  => "Earth",
        PentagramElement.Air    => "Air",
        PentagramElement.Fire   => "Fire",
        PentagramElement.Shadow => "Shadow",
        PentagramElement.Poison => "Poison",
        _                       => "Unknown"
    };

    /// <summary>Body ID for the Shrine Lord NPC (POL ObjType field).</summary>
    public static int GetShrineLordBody(PentagramElement element) => element switch
    {
        PentagramElement.Water  => 16,  // 0x10 — water elemental
        PentagramElement.Earth  => 14,  // 0x0E — earth elemental
        PentagramElement.Air    => 13,  // 0x0D — air elemental
        PentagramElement.Fire   => 15,  // 0x0F — fire elemental
        PentagramElement.Shadow => 15,  // 0x0F — fire body, shadow hue
        PentagramElement.Poison => 13,  // 0x0D — air body, poison hue
        _                       => 14
    };

    /// <summary>
    /// Finds pentagram pieces for the given element in a container, searching sub-bags
    /// up to maxDepth levels deep. Returns a dictionary of pieceNumber -> item.
    /// Only the first found instance of each piece number is returned.
    /// </summary>
    public static Dictionary<int, PentagramPiece> FindPieces(
        Container container, PentagramElement element, int maxDepth = 3)
    {
        var result = new Dictionary<int, PentagramPiece>(PieceCount);
        SearchContainer(container, element, result, 0, maxDepth);
        return result;
    }

    private static void SearchContainer(
        Container container, PentagramElement element,
        Dictionary<int, PentagramPiece> found, int currentDepth, int maxDepth)
    {
        foreach (var item in container.Items)
        {
            if (item is PentagramPiece p && p.Element == element
                && p.PieceNumber >= 1 && p.PieceNumber <= PieceCount
                && !found.ContainsKey(p.PieceNumber))
            {
                found[p.PieceNumber] = p;
            }
            else if (item is Container sub && currentDepth < maxDepth)
            {
                SearchContainer(sub, element, found, currentDepth + 1, maxDepth);
            }

            // Early exit if we found all 9
            if (found.Count >= PieceCount)
            {
                return;
            }
        }
    }
}

/// <summary>
/// A single pentagram piece (1 of 9) for a specific element.
/// Players collect all 9 pieces and trade them to the matching Shrine Lord for rewards.
/// Graphics 0xFE6-0xFEE (4070-4078), coloured by element hue.
/// </summary>
[SerializationGenerator(0, false)]
public partial class PentagramPiece : Item
{
    [SerializableField(0)]
    private PentagramElement _element;

    [SerializableField(1)]
    private int _pieceNumber;

    [Constructible]
    public PentagramPiece() : this(PentagramElement.Water, 1)
    {
    }

    public PentagramPiece(PentagramElement element, int pieceNumber)
        : base(PentagramElementInfo.FirstGraphic + Math.Clamp(pieceNumber - 1, 0, 8))
    {
        _element = element;
        _pieceNumber = Math.Clamp(pieceNumber, 1, 9);
        Hue = PentagramElementInfo.GetPieceHue(element);
        Name = $"{PentagramElementInfo.GetName(element)} Pentagram Piece {_pieceNumber}";
        Weight = 1.0;
    }
}
