using System;
using Server.Gumps;
using Server.Network;

namespace Server.Zulu.Gumps;

public class PlayerModDetailGump : ZuluGump
{
    private const int StartX = 60;
    private const int StartY = 60;
    private const int WidthUnits = 1;
    private const int HeightUnits = 2;

    private const string ColorTitle = "#4A2E0A";
    private const string ColorLabel = "#F5CD3B";
    private const string ColorWhite = "#FFFFFF";
    private const string ColorPositive = "#4CFF4C";
    private const string ColorNegative = "#FF5555";
    private const string ColorZero = "#888888";

    private const int BtnClose = 1;

    public PlayerModDetailGump(Mobile m, ZuluMod mod) : base(480, 60)
    {
        m.RecalculateZuluModifiers();
        var lang = PlayerStatusLanguageResolver.Resolve(m);
        var cfg = ZuluModManager.GetMod(mod);

        AddPage(0);
        AddBackgroundByUnits(StartX, StartY, WidthUnits, HeightUnits, ZuluGumpStyles.Black);

        int x = StartX;
        int y = StartY;

        // Banner título
        AddBackground(x + 65, y - 10, 180, 26, 9300);
        AddLabelHtml(x + 65, y - 8, 180, 22, cfg?.Name ?? mod.ToString(), ColorTitle, 5, true);

        // Close
        AddButton(x + 10, y - 18, 2093, 2093, BtnClose);

        int contentX = x + 12;
        int contentY = y + 20;

        // TOTAL
        double total = 0;
        int modIdx = (int)mod;
        if (modIdx < m.ActiveZuluModifiers.Length)
        {
            total = m.ActiveZuluModifiers[modIdx];
        }

        var calcType = cfg?.CalculateType ?? ZuluModCalcType.None;
        string totalText = FormatValue(total, calcType);
        string totalColor = total > 0 ? ColorPositive : total < 0 ? ColorNegative : ColorZero;

        AddLabelHtml(contentX, contentY, 80, 24,
            PlayerStatusLanguageResolver.Label(lang, LabelKey.Total) + ":", ColorLabel, 4, false);
        AddLabelHtml(contentX + 80, contentY, 180, 24, totalText, totalColor, 5, true);
        contentY += 30;

        // Descrição — reserva ≥3 linhas, fonte 3 (maior que 2)
        const int descLineH = 18;
        const int descMinLines = 3;
        var (desc, second) = PlayerStatusLanguageResolver.GetDescription(mod, lang);

        int descLines1 = EstimateLines(desc, 260, 8);
        int descLines2 = EstimateLines(second, 260, 8);
        int totalLines = Math.Max(descMinLines, descLines1 + descLines2);

        int descBlockY = contentY;
        int line1H = Math.Max(descLineH, descLines1 * descLineH);
        if (!string.IsNullOrEmpty(desc))
        {
            AddLabelHtml(contentX, contentY, 266, line1H + descLineH, desc, ColorWhite, 3, false);
            contentY += line1H;
        }
        if (!string.IsNullOrEmpty(second))
        {
            int line2H = Math.Max(descLineH, descLines2 * descLineH);
            AddLabelHtml(contentX, contentY, 266, line2H + descLineH, second, ColorWhite, 3, false);
            contentY += line2H;
        }

        // Garantir altura mínima do bloco de descrição
        int minBlockH = descMinLines * descLineH;
        int actualH = contentY - descBlockY;
        if (actualH < minBlockH)
        {
            contentY += (minBlockH - actualH);
        }

        contentY += 4;

        // OverheadStyle + MinCap/MaxCap (apenas se houver cfg)
        if (cfg != null)
        {
            if (!string.IsNullOrEmpty(cfg.OverheadStyle))
            {
                AddLabelHtml(contentX, contentY, 90, 22,
                    PlayerStatusLanguageResolver.Label(lang, LabelKey.OverheadStyle) + ":",
                    ColorLabel, 3, false);
                // Hue nativo do UO via AddLabel (AddLabelHtml não converte hue→html facilmente)
                AddLabel(contentX + 90, contentY, cfg.Hue, cfg.OverheadStyle);
                contentY += 22;
            }

            string minText = cfg.MinCap <= -1000 ? "—" : $"{cfg.MinCap:0.#}";
            string maxText = cfg.MaxCap >= 9999 ? "—" : $"{cfg.MaxCap:0.#}";

            AddLabelHtml(contentX, contentY, 90, 22,
                PlayerStatusLanguageResolver.Label(lang, LabelKey.MinCap) + ":",
                ColorLabel, 3, false);
            AddLabelHtml(contentX + 60, contentY, 60, 22, minText, ColorWhite, 3, false);

            AddLabelHtml(contentX + 130, contentY, 60, 22,
                PlayerStatusLanguageResolver.Label(lang, LabelKey.MaxCap) + ":",
                ColorLabel, 3, false);
            AddLabelHtml(contentX + 190, contentY, 60, 22, maxText, ColorWhite, 3, false);
            contentY += 24;
        }

        // Separador
        AddImageTiled(contentX, contentY, 266, 2, 96);
        contentY += 8;

        // Cabeçalho da tabela de sources
        AddLabelHtml(contentX, contentY, 90, 22,
            PlayerStatusLanguageResolver.Label(lang, LabelKey.Type), ColorLabel, 5, false);
        AddLabelHtml(contentX + 90, contentY, 110, 22,
            PlayerStatusLanguageResolver.Label(lang, LabelKey.Source), ColorLabel, 5, false);
        AddLabelHtml(contentX + 200, contentY, 66, 22,
            PlayerStatusLanguageResolver.Label(lang, LabelKey.Value), ColorLabel, 5, false);
        contentY += 22;

        // Sources desse mod
        int matched = 0;
        foreach (var src in m.ZuluModifierSources)
        {
            if (src.Mod != mod) continue;

            // Tipo = categoria (Classe / Equipment / Skill / Stat...)
            string typeText = src.Source.ToString();

            // Origem = nome específico (ex: "Mage", "Magery", "Str", item). Fallback p/ skill, depois para o enum.
            string sourceName = src.SourceName;
            if (string.IsNullOrEmpty(sourceName) && src.Skill.HasValue)
            {
                sourceName = src.Skill.Value.ToString();
            }
            if (string.IsNullOrEmpty(sourceName))
            {
                sourceName = "—";
            }

            string val = FormatValue(src.Value, calcType);
            string valColor = src.Value > 0 ? ColorPositive : src.Value < 0 ? ColorNegative : ColorZero;

            AddLabelHtml(contentX, contentY, 90, 22, typeText, ColorWhite, 5, false);
            AddLabelHtml(contentX + 90, contentY, 110, 22, sourceName, ColorWhite, 5, false);
            AddLabelHtml(contentX + 200, contentY, 66, 22, val, valColor, 5, false);
            contentY += 22;
            matched++;
        }

        if (matched == 0)
        {
            AddLabelHtml(contentX, contentY, 266, 22,
                PlayerStatusLanguageResolver.Label(lang, LabelKey.NoSources), ColorZero, 5, false);
        }
    }

    private static int EstimateLines(string text, int widthPx, int avgCharPx)
    {
        if (string.IsNullOrEmpty(text)) return 0;
        int charsPerLine = Math.Max(1, widthPx / avgCharPx);
        return Math.Max(1, (text.Length + charsPerLine - 1) / charsPerLine);
    }

    private static string FormatValue(double v, ZuluModCalcType type)
    {
        // Trunca para 1 casa decimal (não arredonda).
        double truncated = Math.Truncate(v * 10) / 10.0;
        string sign = truncated > 0 ? "+" : "";
        return type switch
        {
            ZuluModCalcType.Percent => $"{sign}{truncated:0.0}%",
            ZuluModCalcType.Fixed => $"{sign}{truncated:0.0}",
            _ => truncated == 0 ? "—" : $"{sign}{truncated:0.0}",
        };
    }

    public override void OnResponse(NetState sender, in RelayInfo info)
    {
        // Fechar é automático quando recebe qualquer resposta — sub-gump não tem estado persistente
    }
}
