using ModernUO.Serialization;
using Server.Engines.PartySystem;
using Server.Gumps;
using Server.Network;
using Server.Targeting;
using System.Collections.Generic;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

namespace Server;

[SerializationGenerator(0)]
public partial class SpecsItem : Item
{
    [Constructible]
    public SpecsItem() : base(0x0E3B)
    {
        Name = "Specs Book";
        Hue = 1153;
        Weight = 1.0;
    }

    public override void OnDoubleClick(Mobile from)
    {
        base.OnDoubleClick(from);
        if (!from.InRange(GetWorldLocation(), 2))
        {
            from.SendLocalizedMessage(500446); // That is too far away.
            return;
        }
        from.Target = new InternalTarget();
    }
    private class InternalTarget : Target
    {
        public InternalTarget() : base(16, false, TargetFlags.None)
        {

        }

        protected override void OnTarget(Mobile from, object targeted)
        {
            if (targeted is Mobile m)
            {
                from.SendGump(new SpecsGump(m));
            }
            else
            {
                from.SendMessage("Alvo inválido.");
            }
        }
    }
}

public class SpecsGump : ZuluGump
{
    private readonly Mobile m_Mobile;

    private const int startPageX = 80;
    private const int startPageY = 80;

    public override void OnResponse(NetState sender, in RelayInfo info)
    {
        base.OnResponse(sender, info);

        if (info.ButtonID == 2)
        {
            m_Mobile.Str = int.Parse(info.GetTextEntry(1001));
            m_Mobile.Dex = int.Parse(info.GetTextEntry(1002));
            m_Mobile.Int = int.Parse(info.GetTextEntry(1003));
            
            m_Mobile.Hits = int.Parse(info.GetTextEntry(1004));
            m_Mobile.Frozen = bool.Parse(info.GetTextEntry(1005));

            foreach (var item in ZuluModManager.GetCombatMods())
            {
                var text = info.GetTextEntry((int)item);
                if (int.TryParse(text, out int value))
                {
                    m_Mobile.ActiveZuluModifiers[(int)item] = value;
                }
            }
            foreach (var item in ZuluModManager.GetSpecialMods())
            {
                var text = info.GetTextEntry((int)item);
                if (int.TryParse(text, out int value))
                {
                    m_Mobile.ActiveZuluModifiers[(int)item] = value;
                }
            }
            foreach (var item in ZuluModManager.GetProtectionsMods())
            {
                var text = info.GetTextEntry((int)item);
                if (int.TryParse(text, out int value))
                {
                    m_Mobile.ActiveZuluModifiers[(int)item] = value;
                }
            }

            foreach (var item in ZuluModManager.GetMobsMods())
            {
                var text = info.GetTextEntry((int)item);
                if (int.TryParse(text, out int value))
                {
                    m_Mobile.ActiveZuluModifiers[(int)item] = value;
                }
            }

            foreach (var item in ZuluModManager.GetMagicalMods())
            {
                var text = info.GetTextEntry((int)item);
                if (int.TryParse(text, out int value))
                {
                    m_Mobile.ActiveZuluModifiers[(int)item] = value;
                }
            }
        }
    
    }

    public SpecsGump(Mobile m) : base(20, 30)
    {
        m_Mobile = m;

        AddPage(0);

        AddBackgroundByUnits(startPageX, startPageY, 3, 3, ZuluGumpStyles.Black);

        //Couro - Fechar gump
        AddButton(startPageX + 10, startPageY - 18, 2093, 2093, 10);

        //TITULO
        AddBackground(startPageX + 75, startPageY - 10, 150, 24, 9300);
        AddLabelHtml(startPageX + 75, startPageY - 8, 150, 24, "Specs Helper", "#363638", 5, true);

        //Footer
        AddLabelHtml(startPageX + 320, startPageY + 700, 150, 24, "ZuluHotel New Age", "#363638", 4, true);


        AddLabelHtml(startPageX + 12, startPageY + 40, 200, 40, "Class:", "#F5CD3B", 4, false);
        AddLabelHtml(startPageX + 92, startPageY + 40, 200, 40, m.ActiveZuluClass.ToString(), "#FFFFFF", 4, false);

        AddLabelHtml(startPageX + 180, startPageY + 40, 200, 40, "Level:", "#F5CD3B", 4, false);
        AddLabelHtml(startPageX + 230, startPageY + 40, 200, 40, m.ActiveZuluClassLevel.ToString(), "#FFFFFF", 4, false);


        AddImageTiled(startPageX + 3, startPageY + 65, 800, 3, 96);


        AddButton(startPageX + 705, startPageY + 30, 2151, 2152, 2, GumpButtonType.Reply, 1);
        AddLabelHtml(startPageX + 738, startPageY + 34, 200, 32, "Apply Changes", "#FFFFFF", 4, false);


        int alturaInicioColunas = 180;

        //Coluna Combat
        CreateLisGroup(ZuluModManager.GetCombatMods(), " --- Combat ---", startPageX + 5, startPageY + alturaInicioColunas);

        CreateLisGroup(ZuluModManager.GetProtectionsMods(), " --- Protections ---", startPageX + 205, startPageY + alturaInicioColunas);

        CreateLisGroup(ZuluModManager.GetMagicalMods(), " --- Magical ---", startPageX + 405, startPageY + alturaInicioColunas);

        CreateLisGroup(ZuluModManager.GetSpecialMods(), " --- Special ---", startPageX + 605, startPageY + alturaInicioColunas);



        CreateLisGroup(ZuluModManager.GetMobsMods(), " --- Only Mobs ---", startPageX + 605, startPageY);




        int col1x = startPageX + 24;
        int col1y = startPageY + 85;
        int espacing = 24;
        int inputsize = 60;

        int spacingLabel = 150;


        AddLabelHtml(col1x, col1y, 200, 40, "-- STATS -- ", "#F5CD3B", 4, true);
        col1y += espacing;

        // STR
        AddLabelHtml(col1x, col1y + 5, 200, 18, "STR", "#FFFFFF", 4, false);

        AddBackground(col1x + spacingLabel, col1y, inputsize, 20, 9300);
        AddTextEntry(col1x + 5 + spacingLabel, col1y + 2, inputsize, 20, 0, 1001, m_Mobile.Str.ToString());

        col1y += espacing;

        // DEX
        AddLabelHtml(col1x, col1y + 5, 200, 18, "Dex", "#FFFFFF", 4, false);

        AddBackground(col1x + spacingLabel, col1y, inputsize, 20, 9300);
        AddTextEntry(col1x + 5 + spacingLabel, col1y + 2, inputsize, 20, 0, 1002, m_Mobile.Dex.ToString());

        col1y += espacing;

        // INT
        AddLabelHtml(col1x, col1y + 5, 200, 18, "Int", "#FFFFFF", 4, false);

        AddBackground(col1x + spacingLabel, col1y, inputsize, 20, 9300);
        AddTextEntry(col1x + 5 + spacingLabel, col1y + 2, inputsize, 20, 0, 1003, m_Mobile.Int.ToString());

        col1y += espacing;

        // MaxHits
        AddLabelHtml(col1x, col1y + 5, 200, 18, "Hits", "#FFFFFF", 4, false);

        AddBackground(col1x + spacingLabel, col1y, inputsize, 20, 9300);
        AddTextEntry(col1x + 5 + spacingLabel, col1y + 2, inputsize, 20, 0, 1004, m_Mobile.Hits.ToString());

        col1y += espacing;

        // Frozen
        AddLabelHtml(col1x, col1y + 5, 200, 18, "Freeze", "#FFFFFF", 4, false);

        AddBackground(col1x + spacingLabel, col1y, inputsize, 20, 9300);
        AddTextEntry(col1x + 5 + spacingLabel, col1y + 2, inputsize, 20, 0, 1005, m_Mobile.Frozen.ToString());

        col1y += espacing;







    }

    private void CreateLisGroup(List<ZuluMod> mods, string titlegroup, int startX, int startY)
    {
        AddLabelHtml(startX, startY + 85, 200, 40, titlegroup, "#F5CD3B", 4, true);
        int col1x = startX + 24;
        int col1y = startY + 110;
        int espacing = 24;
        int inputsize = 40;

        int spacingLabel = 150;

        foreach (var item in mods)
        {
            int color = 0;

            if (m_Mobile.ActiveZuluModifiers[(int)item] != 0)
                color = m_Mobile.ActiveZuluModifiers[(int)item] > 0 ? 65 : 32;

            AddLabelHtml(col1x, col1y + 5, 200, 18, item.ToString(), "#FFFFFF", 4, false);

            AddBackground(col1x + spacingLabel, col1y +2, inputsize, 20, 9300);
            AddTextEntry(col1x + 5 + spacingLabel, col1y + 4, inputsize, 20, color, (int)item, m_Mobile.ActiveZuluModifiers[(int)item].ToString());

            col1y += espacing;
        }

    }



}
