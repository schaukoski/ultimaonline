using Server.Gumps;

namespace Server.Zulu.Crafting;

/// <summary>
/// Shared renderer for the Zulu "Material Properties" info panel.
/// Used by <see cref="ZuluCraftGump"/> (resource picker page) and
/// <see cref="ZuluCraftGumpItem"/> (recipe detail page).
/// </summary>
public static class ZuluMaterialPanelRenderer
{
    private const int LabelHue = 0x480;

    /// <summary>
    /// Draws the material properties block (header + difficulty/quality/durability + mods)
    /// at the given top-left coordinates. Caller is responsible for reserving vertical space
    /// (block grows with the number of visible mods, ~16px per line).
    /// </summary>
    public static void Draw(ref DynamicGumpBuilder builder, int x, int y, ZuluMaterialDefinition def)
    {
        if (def == null)
        {
            builder.AddLabel(x, y, LabelHue, "Material data unavailable.");
            return;
        }

        var headerHue = def.Hue == 0 ? LabelHue : def.Hue;
        builder.AddLabel(x, y, headerHue, $"Material: {def.Name}");

        // Divider
        builder.AddImageTiled(x, y + 18, 290, 1, 2624);

        var cy = y + 22;

        builder.AddLabel(x, cy, LabelHue, $"Difficulty: {def.Difficulty:F1}");
        cy += 16;
        builder.AddLabel(x, cy, LabelHue, $"Quality: {def.QualityFactor:F2}x");
        cy += 16;
        builder.AddLabel(x, cy, LabelHue, $"Durability: {def.DurabilityFactor:F2}x");
        cy += 16;

        if (def.Mods != null && def.Mods.Count > 0)
        {
            var anyShown = false;
            foreach (var mm in def.Mods)
            {
                if (ZuluModInfo.IsHidden(mm.Mod))
                {
                    continue;
                }

                anyShown = true;
                var sign = mm.Factor >= 0 ? "+" : "";
                builder.AddLabel(x, cy, LabelHue, $"{mm.Mod} {sign}{mm.Factor:F2}/ingot");
                cy += 16;
            }

            if (!anyShown)
            {
                builder.AddLabel(x, cy, LabelHue, "(no visible mods)");
            }
        }
        else
        {
            builder.AddLabel(x, cy, LabelHue, "(no mods)");
        }
    }

    /// <summary>
    /// Convenience overload: resolves the material from the player's selected sub-resource
    /// and renders. If <paramref name="resIndex"/> is out of range and <paramref name="fallbackToFirst"/>
    /// is true, falls back to index 0; otherwise renders a "no material selected" notice.
    /// </summary>
    public static void DrawForContext(
        ref DynamicGumpBuilder builder,
        int x,
        int y,
        ZuluCraftSubResCol res,
        int resIndex,
        bool fallbackToFirst
    )
    {
        if (res == null || res.Count == 0)
        {
            builder.AddLabel(x, y, LabelHue, "No material data.");
            return;
        }

        if (resIndex < 0 || resIndex >= res.Count)
        {
            if (!fallbackToFirst)
            {
                builder.AddLabel(x, y, LabelHue, "No material selected.");
                return;
            }
            resIndex = 0;
        }

        Draw(ref builder, x, y, res.GetAt(resIndex).Definition);
    }
}
