using System;
using Server.Gumps;
using Server.Items;
using Server.Network;

namespace Server.Zulu.Crafting;

public class ZuluCraftGumpItem : DynamicGump
{
    private const int LabelHue = 0x480; // 0x384
    private const int RedLabelHue = 0x20;

    private const int LabelColor = 0x7FFF;
    private const int RedLabelColor = 0x6400;

    private const int GreyLabelColor = 0x3DEF;

    private readonly Mobile _from;
    private readonly ZuluCraftItem _craftItem;
    private readonly ZuluCraftSystem _craftSystem;
    private readonly BaseTool _tool;

    public override bool Singleton => true;

    public ZuluCraftGumpItem(Mobile from, ZuluCraftSystem craftSystem, ZuluCraftItem craftItem, BaseTool tool)
        : base(40, 40)
    {
        _from = from;
        _craftSystem = craftSystem;
        _craftItem = craftItem;
        _tool = tool;
    }

    protected override void BuildLayout(ref DynamicGumpBuilder builder)
    {
        // Zulu: extended height (417 -> 597) to fit the Material Properties panel below the standard layout.
        builder.AddPage();
        builder.AddBackground(0, 0, 530, 597, 5054);
        builder.AddImageTiled(10, 10, 510, 22, 2624);
        builder.AddImageTiled(10, 37, 150, 148, 2624);
        builder.AddImageTiled(165, 37, 355, 90, 2624);
        builder.AddImageTiled(10, 190, 155, 22, 2624);
        builder.AddImageTiled(10, 217, 150, 53, 2624);
        builder.AddImageTiled(165, 132, 355, 80, 2624);
        builder.AddImageTiled(10, 275, 155, 22, 2624);
        builder.AddImageTiled(10, 302, 150, 53, 2624);
        builder.AddImageTiled(165, 217, 355, 80, 2624);
        builder.AddImageTiled(10, 360, 155, 22, 2624);
        builder.AddImageTiled(165, 302, 355, 80, 2624);
        // Zulu: Material Properties panel area
        builder.AddImageTiled(10, 387, 510, 22, 2624);   // header strip "MATERIAL PROPERTIES"
        builder.AddImageTiled(10, 414, 510, 155, 2624);  // body
        builder.AddImageTiled(10, 567, 510, 22, 2624);   // bottom strip (BACK / MAKE NOW row)
        builder.AddAlphaRegion(10, 10, 510, 579);

        builder.AddHtmlLocalized(170, 40, 150, 20, 1044053, LabelColor); // ITEM
        builder.AddHtmlLocalized(10, 192, 150, 22, 1044054, LabelColor); // <CENTER>SKILLS</CENTER>
        builder.AddHtmlLocalized(10, 277, 150, 22, 1044055, LabelColor); // <CENTER>MATERIALS</CENTER>
        builder.AddHtmlLocalized(10, 362, 150, 22, 1044056, LabelColor); // <CENTER>OTHER</CENTER>
        // Zulu: header for the material properties panel
        builder.AddHtml(10, 390, 510, 22, "<CENTER>MATERIAL PROPERTIES</CENTER>");

        builder.AddHtml(10, 12, 510, 20, _craftSystem.GumpTitle ?? "Crafting Menu");

        // Zulu: moved BACK/MAKE NOW buttons from y=387 to y=567 to make room for the material panel.
        builder.AddButton(15, 567, 4014, 4016, 0);
        builder.AddHtmlLocalized(50, 570, 150, 18, 1044150, LabelColor); // BACK

        builder.AddButton(270, 567, 4005, 4007, 1);
        builder.AddHtmlLocalized(305, 570, 150, 18, 1044151, LabelColor); // MAKE NOW

        builder.AddLabel(330, 40, LabelHue, _craftItem.Name ?? "?");

        if (_craftItem.UseAllRes)
        {
            builder.AddHtmlLocalized(
                170,
                302,
                310,
                18,
                1048176, // Makes as many as possible at once
                LabelColor
            );
        }

        var otherCount = 1;

        DrawItem(ref builder, ref otherCount, out var showExceptionalChance);
        DrawSkill(ref builder, showExceptionalChance);
        DrawResource(ref builder);
        DrawSelectedMaterial(ref builder);

        // Regra 13 (CLAUDE.md): garantir conteúdo visual sempre.
        if (otherCount == 1 && _craftItem.Resources.Count == 0)
        {
            builder.AddLabel(170, 322, LabelHue, "(no extra info)");
        }
    }

    /// <summary>
    /// Draws the Material Properties panel for the player's currently selected sub-resource.
    /// Reuses <see cref="ZuluMaterialPanelRenderer"/>. If no material is selected, shows a notice.
    /// </summary>
    public void DrawSelectedMaterial(ref DynamicGumpBuilder builder)
    {
        // Material Properties panel — full-width area at y=414, height 155.
        const int X = 20;
        const int Y = 418;

        var res = _craftItem.UseSubRes2 ? _craftSystem.CraftSubRes2 : _craftSystem.CraftSubRes;
        var context = _craftSystem.GetContext(_from);
        var resIndex = -1;

        if (context != null)
        {
            resIndex = _craftItem.UseSubRes2 ? context.LastResourceIndex2 : context.LastResourceIndex;
        }

        // Strict semantics here (no fallback): per spec, if idx == -1 show "No material selected".
        ZuluMaterialPanelRenderer.DrawForContext(ref builder, X, Y, res, resIndex, fallbackToFirst: false);
    }

    public void DrawItem(ref DynamicGumpBuilder builder, ref int otherCount, out bool showExceptionalChance)
    {
        var type = _craftItem.ItemType;

        builder.AddItem(20, 50, _craftItem.ItemId, _craftItem.ItemHue);

        if (_craftItem.IsMarkable(type))
        {
            builder.AddHtmlLocalized(
                170,
                302 + otherCount++ * 20,
                310,
                18,
                1044059, // This item may hold its maker's mark
                LabelColor
            );

            showExceptionalChance = true;
        }
        else
        {
            showExceptionalChance = false;
        }
    }

    public void DrawSkill(ref DynamicGumpBuilder builder, bool showExceptionalChance)
    {
        for (var i = 0; i < _craftItem.Skills.Count; i++)
        {
            var skill = _craftItem.Skills[i];
            var minSkill = Math.Max(skill.MinSkill, 0);

            builder.AddHtmlLocalized(170, 132 + i * 20, 200, 18, AosSkillBonuses.GetLabel(skill.SkillToMake), LabelColor);
            builder.AddLabel(430, 132 + i * 20, LabelHue, $"{minSkill:F1}");
        }

        var context = _craftSystem.GetContext(_from);
        var resCol = _craftItem.UseSubRes2 ? _craftSystem.CraftSubRes2 : _craftSystem.CraftSubRes;

        var resIndex = -1;
        if (context != null)
        {
            resIndex = _craftItem.UseSubRes2 ? context.LastResourceIndex2 : context.LastResourceIndex;
        }

        var materialId = -1;
        if (resIndex > -1 && resIndex < resCol.Count)
        {
            materialId = resCol.GetAt(resIndex).MaterialId;
        }

        var chance = _craftItem.GetSuccessChance(_from, materialId, _craftSystem, false, out _);

        builder.AddHtmlLocalized(170, 80, 250, 18, 1044057, LabelColor); // Success Chance:
        builder.AddLabel(430, 80, LabelHue, $"{Math.Clamp(chance, 0, 1) * 100:F1}%");

        if (showExceptionalChance)
        {
            var exceptChance = Math.Clamp(_craftItem.GetExceptionalChance(_craftSystem, chance, _from), 0, 1.0);

            builder.AddHtmlLocalized(170, 100, 250, 18, 1044058, 32767); // Exceptional Chance:
            builder.AddLabel(430, 100, LabelHue, $"{exceptChance * 100:F1}%");
        }
    }

    public void DrawResource(ref DynamicGumpBuilder builder)
    {
        for (var i = 0; i < _craftItem.Resources.Count && i < 4; i++)
        {
            var craftResource = _craftItem.Resources[i];

            builder.AddLabel(170, 219 + i * 20, LabelHue, craftResource.Name ?? "?");
            builder.AddLabel(430, 219 + i * 20, LabelHue, craftResource.Amount.ToString());
        }
    }

    public override void OnResponse(NetState sender, in RelayInfo info)
    {
        var from = sender.Mobile;

        // Back Button
        if (info.ButtonID == 0)
        {
            var craftGump = new ZuluCraftGump(from, _craftSystem, _tool, null);
            from.SendGump(craftGump);
        }
        else // Make Button
        {
            var num = _craftSystem.CanCraft(from, _tool, _craftItem.ItemType);

            if (num > 0)
            {
                from.SendGump(new ZuluCraftGump(from, _craftSystem, _tool, $"#{num}"));
            }
            else
            {
                var ctx = _craftSystem.GetContext(from);

                var materialId = -1;
                if (ctx != null)
                {
                    var res = _craftItem.UseSubRes2 ? _craftSystem.CraftSubRes2 : _craftSystem.CraftSubRes;
                    var resIndex = _craftItem.UseSubRes2 ? ctx.LastResourceIndex2 : ctx.LastResourceIndex;

                    if (resIndex > -1 && resIndex < res.Count)
                    {
                        materialId = res.GetAt(resIndex).MaterialId;
                    }
                }

                _craftSystem.CreateItem(from, _craftItem.ItemType, materialId, _tool, _craftItem);
            }
        }
    }
}
