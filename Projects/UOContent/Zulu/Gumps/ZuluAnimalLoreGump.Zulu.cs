using System;
using System.Collections.Generic;
using Server.Gumps;
using Server.Mobiles;
using Server.Network;

namespace Server;

/// <summary>
/// Zulu Hotel Animal Lore gump.
/// Black panel with Warshard-style chrome (ZuluGumpStyles.Black).
/// Two-column resistance layout matching the in-game Protection Information screen.
/// Opened via AnimalLore.Zulu.cs callback override.
/// </summary>
public class ZuluAnimalLoreGump : ZuluGump
{
    private readonly BaseCreature _creature;

    public override bool Singleton => true;

    // ── Element colors (light variants — readable on black background) ────────
    private const string ColAir    = "#6699FF";   // light blue
    private const string ColNecro  = "#BB88FF";   // light purple
    private const string ColFire   = "#FF6633";   // orange-red
    private const string ColWater  = "#4488FF";   // blue
    private const string ColPoison = "#66CC66";   // light green
    private const string ColHolly  = "#FFCC33";   // gold
    private const string ColEarth  = "#AABB66";   // olive-lime
    private const string ColPhys   = "#CCCCCC";   // light grey

    // ── Chrome colors (Warshard palette) ──────────────────────────────────────
    private const string ColHeader  = "#F5CD3B";  // gold       — section titles
    private const string ColLabel   = "#F5CD3B";  // gold       — row labels
    private const string ColValue   = "#FFFFFF";  // white      — normal values
    private const string ColTitle   = "#4A2E0A";  // dark brown — gump title (on 9300 ribbon)
    private const string ColResPos  = "#4CFF4C";  // bright green — positive resistance
    private const string ColResNeg  = "#FF5555";  // red        — weakness
    private const string ColGrey    = "#888888";  // grey       — zero / none
    private const string ColImmune  = "#FFAA33";  // amber      — immune

    // ── Panel geometry: White 1×2 (cornerSize=26, cw=240, ch=240) ────────────
    // Total: 292 × 532 px.  Inner margin: 20px.  Inner width: 252px.
    private const int Margin = 20;
    private const int InnerW = 252;  // 292 - 20*2
    private const int ColW   = 126;  // InnerW / 2

    // ── Entry point ──────────────────────────────────────────────────────────
    public static void DisplayTo(Mobile from, BaseCreature creature)
    {
        if (creature?.Deleted != false || !creature.Alive)
        {
            return;
        }

        from.SendGump(new ZuluAnimalLoreGump(creature));
    }

    public ZuluAnimalLoreGump(BaseCreature creature) : base(20, 30)
    {
        _creature = creature;

        if (creature?.Deleted != false)
        {
            AddBackgroundByUnits(80, 60, 1, 1, ZuluGumpStyles.Black);
            AddLabelHtml(100, 100, 240, 20, "Target no longer available.", ColResNeg, 4, true);
            return;
        }

        Build();
    }

    // ── Layout ───────────────────────────────────────────────────────────────
    private void Build()
    {
        var c = _creature;

        const int sx = 80;   // panel left
        const int sy = 60;   // panel top

        AddPage(0);

        // Black panel — matches Warshard chrome
        AddBackgroundByUnits(sx, sy, 1, 2, ZuluGumpStyles.Black);

        // Close button — leather X, above top-left
        AddButton(sx + 8, sy - 18, 2093, 2093, 0);

        // Title band — centred at top of panel
        AddBackground(sx + 56, sy - 10, 180, 26, 9300);
        AddLabelHtml(sx + 56, sy - 8, 180, 22, "Animal Lore", ColTitle, 5, true);

        var y = sy + Margin;

        // ── Mob Name ─────────────────────────────────────────────────────────
        AddLabelHtml(sx + Margin, y, InnerW, 22, c.Name ?? "Unknown", ColHeader, 5, true);
        y += 26;

        // ── HP Bar (grey frame + HTML bgcolor fill) ──────────────────────────
        // Frame: gump 3000 (plain grey box, stretchable).
        // Fill:  AddHtml with a coloured bgcolor — exact colour, no border.
        var hpPct = c.HitsMax > 0 ? c.Hits / (double)c.HitsMax * 100.0 : 0.0;
        var fillW = Math.Max(0, (int)(InnerW * hpPct / 100.0));

        AddBackground(sx + Margin, y, InnerW, 14, 3000);
        if (fillW > 0)
        {
            var fillHex = hpPct > 66.0 ? "#2BA84A"    // green
                        : hpPct > 33.0 ? "#E6A015"    // amber/yellow
                        :                "#C23B22";   // red
            // Small 1-pad inset so the grey frame edge stays visible.
            AddHtml(
                sx + Margin + 2,
                y + 2,
                Math.Max(0, fillW - 4),
                10,
                $"<BODY BGCOLOR={fillHex}> </BODY>",
                false,
                false
            );
        }
        y += 18;

        var hpColor = hpPct > 66.0 ? ColResPos : hpPct > 33.0 ? ColImmune : ColResNeg;
        AddLabelHtml(sx + Margin, y, InnerW, 18,
            $"{c.Hits} / {c.HitsMax}  ({hpPct:F0}%)", hpColor, 4, true);
        y += 22;

        Divider(sx, y); y += 10;

        // ── Damage Dealt ─────────────────────────────────────────────────────
        AddLabelHtml(sx + Margin, y, InnerW, 18, "Damage Dealt", ColHeader, 4, true);
        y += 22;

        // Per-element damage listing
        var (ddLine1, ddLine2) = BuildDamageLines(c);
        AddHtml(sx + Margin, y, InnerW, 18, ddLine1);
        y += 20;
        if (ddLine2.Length > 0)
        {
            AddHtml(sx + Margin, y, InnerW, 18, ddLine2);
            y += 20;
        }

        AddLabelHtml(sx + Margin,      y, 50,  18, "Base:",                     ColLabel, 4, false);
        AddLabelHtml(sx + Margin + 52, y, 100, 18, $"{c.DamageMin} - {c.DamageMax}", ColValue, 4, false);
        y += 24;

        Divider(sx, y); y += 10;

        // ── Resistances ──────────────────────────────────────────────────────
        AddLabelHtml(sx + Margin, y, InnerW, 18, "Resistances", ColHeader, 4, true);
        y += 22;

        var c1 = sx + Margin;
        var c2 = sx + Margin + ColW;

        ResistRow(c1, c2, y, c,
            "Physical", ZuluMod.PhysicalProtection, ColPhys,
            "Fire",     ZuluMod.FireProtection,     ColFire);   y += 20;
        ResistRow(c1, c2, y, c,
            "Water",    ZuluMod.WaterProtection,    ColWater,
            "Poison",   ZuluMod.PoisonProtection,   ColPoison); y += 20;
        ResistRow(c1, c2, y, c,
            "Air",      ZuluMod.AirProtection,      ColAir,
            "Necro",    ZuluMod.NecroProtection,    ColNecro);  y += 20;
        ResistRow(c1, c2, y, c,
            "Holly",    ZuluMod.HollyProtection,    ColHolly,
            "Earth",    ZuluMod.EarthProtection,    ColEarth);  y += 24;

        Divider(sx, y); y += 10;

        // ── Info ─────────────────────────────────────────────────────────────
        AddLabelHtml(sx + Margin, y, InnerW, 18, "Info", ColHeader, 4, true);
        y += 22;

        // Armor
        var armor = (int)Math.Round(c.ArmorRating);
        if (armor > 0)
        {
            InfoRow(sx, y, "Armor:", armor.ToString(), ColValue); y += 20;
        }

        // Karma
        var (karmaLabel, karmaColor) = c.Karma switch
        {
            > 5000  => ("Good",    ColAir),
            < -5000 => ("Evil",    ColResNeg),
            _       => ("Neutral", ColGrey)
        };
        InfoRow(sx, y, "Karma:", $"{c.Karma}  ({karmaLabel})", karmaColor); y += 20;

        // Taming
        if (c.Tamable && c.MinTameSkill > 0)
        {
            InfoRow(sx, y, "Taming:", $"{c.MinTameSkill:F1} skill req.", ColAir); y += 20;
        }

        // Magic immunity
        var magicImm = (int)c.GetZuluModifier(ZuluMod.MagicImmunityCircle);
        if (magicImm > 0)
        {
            InfoRow(sx, y, "Magic Immune:", $"Circle {magicImm}+", ColImmune); y += 20;
        }

        // Poison immunity
        if (c.PoisonImmune != null)
        {
            InfoRow(sx, y, "Poison Immune:", c.PoisonImmune.Name, ColPoison);
        }
    }

    // ── Helpers ──────────────────────────────────────────────────────────────

    // Divider — parchment style (tile 9304 = thin light horizontal line)
    private void Divider(int sx, int y)
    {
        AddImageTiled(sx + Margin, y, InnerW, 2, 9304);
    }

    // Info row: [Label]  [value in valueColor]
    private void InfoRow(int sx, int y, string label, string value, string valueColor)
    {
        AddLabelHtml(sx + Margin,      y, 100, 18, label, ColLabel, 4, false);
        AddLabelHtml(sx + Margin + 102, y, 148, 18, value, valueColor, 4, false);
    }

    // Two resist cells per row
    private void ResistRow(
        int col1, int col2, int y, BaseCreature c,
        string name1, ZuluMod mod1, string elemColor1,
        string name2, ZuluMod mod2, string elemColor2)
    {
        ResistCell(col1, y, name1, (int)c.GetZuluModifier(mod1), elemColor1);
        ResistCell(col2, y, name2, (int)c.GetZuluModifier(mod2), elemColor2);
    }

    // [Name]  [value]
    //   > 0  → dark green "+N%"  (resistant)
    //   < 0  → red        "N%"   (weakness — takes more damage)
    //   = 0  → grey       "0%"
    private void ResistCell(int x, int y, string name, int pct, string elemColor)
    {
        // Label width 72 fits "Physical" (longest name)
        AddLabelHtml(x, y, 72, 18, name, elemColor, 4, false);

        var (valueText, valueColor) = pct switch
        {
            > 0 => ($"+{pct}%", ColResPos),
            < 0 => ($"{pct}%",  ColResNeg),
            _   => ("0%",       ColGrey)
        };

        AddLabelHtml(x + 74, y, 50, 18, valueText, valueColor, 4, false);
    }

    // Splits the damage types into up to two lines of HTML (max 4 per line)
    private static (string line1, string line2) BuildDamageLines(BaseCreature c)
    {
        var parts = new List<string>(8);

        void Add(string name, int val, string color)
        {
            if (val > 0)
            {
                parts.Add($"<BASEFONT COLOR={color}>{name}: {val}%</BASEFONT>");
            }
        }

        Add("Physical", c.z_Physical_DD, ColPhys);
        Add("Fire",     c.z_Fire_DD,     ColFire);
        Add("Water",    c.z_Water_DD,    ColWater);
        Add("Poison",   c.z_Poison_DD,   ColPoison);
        Add("Air",      c.z_Air_DD,      ColAir);
        Add("Necro",    c.z_Necro_DD,    ColNecro);
        Add("Holly",    c.z_Holly_DD,    ColHolly);
        Add("Earth",    c.z_Earth_DD,    ColEarth);

        if (parts.Count == 0)
        {
            return ($"<BASEFONT COLOR={ColGrey}>---</BASEFONT>", "");
        }

        var split    = Math.Min(4, parts.Count);
        var line1    = string.Join("  ", parts[..split]);
        var line2    = parts.Count > split ? string.Join("  ", parts[split..]) : "";
        return (line1, line2);
    }

    public override void OnResponse(NetState sender, in RelayInfo info)
    {
        // Button 0 = leather close; no action needed.
    }
}
