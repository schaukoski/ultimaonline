using System;
using System.Collections.Generic;
using Server.Gumps;
using Server.Network;

namespace Server.Zulu.Gumps;

public class PlayerStatusGump : ZuluGump
{
    private const int StartX = 60;
    private const int StartY = 60;
    private const int WidthUnits = 2;
    private const int HeightUnits = 4;
    private const int ContentWidth = 270 * WidthUnits - 4;

    private const string ColorTitle = "#4A2E0A";
    private const string ColorLabel = "#F5CD3B";
    private const string ColorWhite = "#FFFFFF";
    private const string ColorPositive = "#4CFF4C";
    private const string ColorNegative = "#FF5555";
    private const string ColorZero = "#888888";
    private const string ColorSection = "#F5CD3B";

    private const int BtnClose = 1;
    private const int BtnToggleHideZeros = 2;
    private const int BtnRefresh = 3;
    private const int BtnLangBase = 100;    // 100..105 = idiomas
    private const int BtnModDetailBase = 1000; // 1000 + (int)ZuluMod

    private readonly Mobile _mobile;
    private readonly PlayerStatusLanguage _lang;
    private readonly PlayerStatusPreferencesData _prefs;

    public PlayerStatusGump(Mobile m) : base(20, 30)
    {
        _mobile = m;

        if (m.isZuluDirty)
        {
            m.RecalculateZuluModifiers();
        }

        _prefs = PlayerStatusPreferences.Get(m);
        _lang = PlayerStatusLanguageResolver.Resolve(m);

        Build();
    }

    private void Build()
    {
        AddPage(0);
        AddBackgroundByUnits(StartX, StartY, WidthUnits, HeightUnits, ZuluGumpStyles.Black);

        int x = StartX;
        int y = StartY;

        // Banner título
        int bannerWidth = 240;
        int bannerX = x + (WidthUnits * 270) / 2 - bannerWidth / 2;
        AddBackground(bannerX, y - 10, bannerWidth, 26, 9300);
        AddLabelHtml(bannerX, y - 8, bannerWidth, 22, PlayerStatusLanguageResolver.Label(_lang, LabelKey.Title), ColorTitle, 5, true);

        // Close (X) no canto
        AddButton(x + 10, y - 18, 2093, 2093, BtnClose);

        int contentX = x + 12;
        int contentY = y + 24;
        int colTwoX = contentX + ContentWidth / 2 + 4;
        int colWidth = ContentWidth / 2 - 8;

        // Header: Nome
        AddLabelHtml(contentX, contentY, ContentWidth, 24, _mobile.Name ?? "", ColorWhite, 5, false);
        contentY += 28;

        // Classe + Nível
        if (_mobile.ActiveZuluClass != ZuluClass.NonClass && _mobile.ActiveZuluClassLevel > 0)
        {
            AddLabelHtml(contentX, contentY, 90, 24, PlayerStatusLanguageResolver.Label(_lang, LabelKey.Class) + ":", ColorLabel, 5, false);
            AddLabelHtml(contentX + 90, contentY, 200, 24, _mobile.ActiveZuluClass.ToString(), ColorWhite, 5, false);
            AddLabelHtml(contentX + 300, contentY, 80, 24, PlayerStatusLanguageResolver.Label(_lang, LabelKey.Level) + ":", ColorLabel, 5, false);
            AddLabelHtml(contentX + 380, contentY, 80, 24, _mobile.ActiveZuluClassLevel.ToString(), ColorWhite, 5, false);
            contentY += 26;

            // Próximo nível — só texto, sem barra
            var (current, next) = ZuluClassManager.GetClassProgress(_mobile);
            if (next > 0)
            {
                AddLabelHtml(contentX, contentY, ContentWidth, 22,
                    $"{PlayerStatusLanguageResolver.Label(_lang, LabelKey.NextLevel)}: {current}/{next}",
                    ColorWhite, 5, false);
                contentY += 24;
            }
        }
        else
        {
            contentY += 4;
        }

        // Separador
        AddImageTiled(contentX, contentY, ContentWidth, 2, 96);
        contentY += 8;

        // Stats — 3 colunas uniformes
        int colStat = ContentWidth / 3;
        AddLabelHtml(contentX, contentY, colStat, 24,
            $"{PlayerStatusLanguageResolver.Label(_lang, LabelKey.HP)}: {_mobile.Hits}/{_mobile.HitsMax}", ColorWhite, 5, false);
        AddLabelHtml(contentX + colStat, contentY, colStat, 24,
            $"{PlayerStatusLanguageResolver.Label(_lang, LabelKey.Mana)}: {_mobile.Mana}/{_mobile.ManaMax}", ColorWhite, 5, false);
        AddLabelHtml(contentX + colStat * 2, contentY, colStat, 24,
            $"{PlayerStatusLanguageResolver.Label(_lang, LabelKey.Stam)}: {_mobile.Stam}/{_mobile.StamMax}", ColorWhite, 5, false);
        contentY += 26;

        // Ordem STR / INT / DEX — alinha com HP / Mana / Stam (STR→HP, INT→Mana, DEX→Stam)
        AddLabelHtml(contentX, contentY, colStat, 24,
            $"{PlayerStatusLanguageResolver.Label(_lang, LabelKey.Str)}: {_mobile.Str}", ColorWhite, 5, false);
        AddLabelHtml(contentX + colStat, contentY, colStat, 24,
            $"{PlayerStatusLanguageResolver.Label(_lang, LabelKey.Int)}: {_mobile.Int}", ColorWhite, 5, false);
        AddLabelHtml(contentX + colStat * 2, contentY, colStat, 24,
            $"{PlayerStatusLanguageResolver.Label(_lang, LabelKey.Dex)}: {_mobile.Dex}", ColorWhite, 5, false);
        contentY += 28;

        // Separador
        AddImageTiled(contentX, contentY, ContentWidth, 2, 96);
        contentY += 8;

        // Seções de modificadores — coluna esquerda e direita
        int leftY = contentY;
        int rightY = contentY;

        leftY = RenderSection(contentX, leftY, colWidth,
            PlayerStatusLanguageResolver.Label(_lang, LabelKey.Protections),
            ZuluModManager.GetProtectionsMods());

        leftY = RenderSection(contentX, leftY, colWidth,
            PlayerStatusLanguageResolver.Label(_lang, LabelKey.MagicalAmps),
            ZuluModManager.GetMagicalMods());

        rightY = RenderSection(colTwoX, rightY, colWidth,
            PlayerStatusLanguageResolver.Label(_lang, LabelKey.Combat),
            ZuluModManager.GetCombatMods());

        rightY = RenderSection(colTwoX, rightY, colWidth,
            PlayerStatusLanguageResolver.Label(_lang, LabelKey.Special),
            ZuluModManager.GetSpecialMods());

        contentY = Math.Max(leftY, rightY);

        // Footer: checkbox hide zeros + idioma + refresh
        contentY += 8;
        AddImageTiled(contentX, contentY, ContentWidth, 2, 96);
        contentY += 8;

        // Checkbox hide zeros — botão (não AddCheck, que só escreve em Switches e não dispara OnResponse)
        int checkGraphic = _prefs.HideZeroMods ? 2153 : 2151;
        AddButton(contentX, contentY, checkGraphic, checkGraphic, BtnToggleHideZeros);
        AddLabelHtml(contentX + 26, contentY + 2, 260, 24,
            PlayerStatusLanguageResolver.Label(_lang, LabelKey.HideZeros), ColorWhite, 5, false);

        // Refresh (ao lado direito, mesma linha)
        int refreshX = contentX + ContentWidth - 160;
        AddButton(refreshX, contentY, 2152, 2152, BtnRefresh);
        AddLabelHtml(refreshX + 26, contentY + 2, 140, 24,
            PlayerStatusLanguageResolver.Label(_lang, LabelKey.Refresh), ColorWhite, 5, false);
        contentY += 28;

        // Idiomas
        AddLabelHtml(contentX, contentY, 100, 24,
            PlayerStatusLanguageResolver.Label(_lang, LabelKey.Language) + ":", ColorLabel, 5, false);

        string[] langCodes = { "PT", "EN", "ES", "SV", "RU", "IT" };
        int langStartX = contentX + 100;
        const int langSlotW = 60;
        for (int i = 0; i < langCodes.Length; i++)
        {
            int bx = langStartX + i * langSlotW;
            bool isCurrent = (int)_lang == i;
            AddButton(bx, contentY, isCurrent ? 2152 : 2151, 2152, BtnLangBase + i);
            AddLabelHtml(bx + 22, contentY + 2, 36, 24, langCodes[i], ColorWhite, 5, false);
        }
        contentY += 28;

        // Rodapé
        AddLabelHtml(bannerX, StartY + 20 + (HeightUnits * 206) - 20, bannerWidth, 24, "ZuluHotel New Age", ColorTitle, 3, true);
    }

    private int RenderSection(int x, int y, int width, string title, List<ZuluMod> mods)
    {
        // Título da seção
        AddLabelHtml(x, y, width, 24, title, ColorSection, 5, true);
        y += 26;

        int valueColWidth = 80;
        int nameX = x + 22;
        int valueX = x + width - valueColWidth;
        int nameWidth = valueX - nameX - 4;

        foreach (var mod in mods)
        {
            int modIdx = (int)mod;
            if (modIdx >= _mobile.ActiveZuluModifiers.Length) continue;

            double total = _mobile.ActiveZuluModifiers[modIdx];

            if (_prefs.HideZeroMods && total == 0) continue;

            var cfg = ZuluModManager.GetMod(mod);
            if (cfg == null) continue;

            string valueText = FormatValue(total, cfg.CalculateType);
            string color = total > 0 ? ColorPositive : total < 0 ? ColorNegative : ColorZero;

            // botão info (BlueBulletMini 2103)
            AddButton(x, y + 3, 2103, 2104, BtnModDetailBase + modIdx);
            AddLabelHtml(nameX, y, nameWidth, 22, cfg.Name ?? mod.ToString(), ColorWhite, 5, false);
            AddLabelHtml(valueX, y, valueColWidth, 22, valueText, color, 5, false);

            y += 22;
        }

        y += 8;
        return y;
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
        var m = sender?.Mobile;
        if (m == null) return;

        int id = info.ButtonID;

        if (id == BtnClose)
        {
            return;
        }

        if (id == BtnToggleHideZeros)
        {
            // O check vem em info.Switches — interpretar toggle: alternar valor atual
            var prefs = PlayerStatusPreferences.Get(m);
            prefs.HideZeroMods = !prefs.HideZeroMods;
            PlayerStatusPreferences.Save(m, prefs);
            m.SendGump(new PlayerStatusGump(m));
            return;
        }

        if (id == BtnRefresh)
        {
            m.isZuluDirty = true;
            m.SendGump(new PlayerStatusGump(m));
            return;
        }

        if (id >= BtnLangBase && id < BtnLangBase + 6)
        {
            var prefs = PlayerStatusPreferences.Get(m);
            prefs.LanguageOverride = (PlayerStatusLanguage)(id - BtnLangBase);
            PlayerStatusPreferences.Save(m, prefs);
            m.SendGump(new PlayerStatusGump(m));
            return;
        }

        if (id >= BtnModDetailBase)
        {
            int modIdx = id - BtnModDetailBase;
            if (modIdx >= 0 && modIdx < Enum.GetValues<ZuluMod>().Length)
            {
                var mod = (ZuluMod)modIdx;
                m.SendGump(new PlayerStatusGump(m)); // reabre principal
                m.SendGump(new PlayerModDetailGump(m, mod));
            }
            return;
        }
    }
}
