using Server.Gumps;
using Server.Items;
using Server.Network;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server;

public class WarshardGump : ZuluGump
{
    private readonly Mobile m_Mobile;

    public override void OnResponse(NetState sender, in RelayInfo info)
    {
        base.OnResponse(sender, info);

        switch (info.ButtonID)
        {
            case 1: ZuluClassManager.SetClass(sender.Mobile, new MageClass(), info.Switches[0]); break;
            case 2: ZuluClassManager.SetClass(sender.Mobile, new WarriorClass(), info.Switches[0]); break;
            case 3: ZuluClassManager.SetClass(sender.Mobile, new RangerClass(), info.Switches[0]); break;
            case 4: ZuluClassManager.SetClass(sender.Mobile, new BardClass(), info.Switches[0]); break;
            case 5: ZuluClassManager.SetClass(sender.Mobile, new CrafterClass(), info.Switches[0]); break;
            case 6: ZuluClassManager.SetClass(sender.Mobile, new ThiefClass(), info.Switches[0]); break;
            case 7: ZuluClassManager.SetClass(sender.Mobile, new NecromancerClass(), info.Switches[0]); break;

            default:
                break;
        }

        ZuluClassManager.ShowClassMessage(sender.Mobile);
    }

    public WarshardGump(Mobile m, int type) : base(20, 30)
    {
        m_Mobile = m;

        AddPage(0);

        int startPageX = 80;
        int startPageY = 80;

        AddBackgroundByUnits(startPageX, startPageY, 1, 2, ZuluGumpStyles.Black);

        //AddLabelHtml(220, startPageY + 420, 200, 40, "ZuluHotel New Age", "#FFFFFF", 3, true);
        AddButton(startPageX + 10, startPageY - 18, 2093, 2093, 10);

        //AddBackground(startPageX + 75, startPageY - 10, 150, 24, 9300);
        AddBackground(startPageX + 75, startPageY - 10, 150, 24, 9300);

        ///9300
        ///9308
        AddLabelHtml(startPageX+75, startPageY-8, 150, 24, "Warshard", "#363638", 5, true);

        AddLabelHtml(startPageX + 75, startPageY +420, 150, 24, "ZuluHotel New Age", "#363638", 4, true);


        AddLabelHtml(startPageX + 12, startPageY + 40, 200, 40, "Your Class:", "#F5CD3B", 4, false);
        AddLabelHtml(startPageX + 92, startPageY + 40, 200, 40, m.ActiveZuluClass.Name, "#FFFFFF", 4, false);

        AddLabelHtml(startPageX + 180, startPageY + 40, 200, 40, "Level:", "#F5CD3B", 4, false);
        AddLabelHtml(startPageX + 230, startPageY + 40, 200, 40, m.ActiveZuluClassLevel.ToString(), "#FFFFFF", 4, false);


        AddImageTiled(startPageX + 3, startPageY + 65, 295, 3, 96);
        //AddImageTiled(startPageX + 3, startPageY + 75, 290, 3, 30002);


        AddLabelHtml(startPageX, startPageY + 85, 110, 40, "Class", "#F5CD3B", 4, true);
        AddLabelHtml(startPageX + 180, startPageY + 85, 130, 40, "Level", "#F5CD3B", 4, true);

        //Coluna Classes
        int col1x = startPageX + 24;
        int col1y = startPageY + 110;
        int espacing = 42;
        int espacingItem = 25;

        int spacingLabel = 64;

        AddButton(col1x, col1y, 2151, 2152, 1, GumpButtonType.Reply, 11);
        AddItem(col1x+25, col1y+5, 0x1718);
        AddLabelHtml(col1x + spacingLabel, col1y+5, 200, 18, "Mage", "#FFFFFF", 4, false);

        
        col1y += espacing;

        AddButton(col1x, col1y, 2151, 2152, 2, GumpButtonType.Reply, 12);
        AddItem(col1x + espacingItem, col1y, 0x1412);
        AddLabelHtml(col1x + spacingLabel, col1y + 5, 200, 32, "Warrior", "#FFFFFF", 4, false);


        col1y += espacing;

        AddButton(col1x, col1y, 2152, 2152,3, GumpButtonType.Reply, 13);
        AddItem(col1x + espacingItem, col1y, 0x0F4F);
        AddLabelHtml(col1x + spacingLabel, col1y + 5, 200, 32, "Ranger", "#FFFFFF", 4, false);

        col1y += espacing;

        AddButton(col1x, col1y, 2152, 2152, 4, GumpButtonType.Reply, 14);
        AddItem(col1x + espacingItem, col1y, 0x0E85);
        AddLabelHtml(col1x + spacingLabel, col1y + 5, 200, 32, "Crafter", "#FFFFFF", 4, false);



        col1y += espacing;

        AddButton(col1x, col1y, 2152, 2152, 5, GumpButtonType.Reply, 15);
        AddItem(col1x + espacingItem, col1y, 0x0EB3);
        AddLabelHtml(col1x + spacingLabel, col1y + 5, 200, 32, "Bard", "#FFFFFF", 4, false);


        col1y += espacing;

        AddButton(col1x, col1y, 2152, 2152, 6, GumpButtonType.Reply, 16);
        AddItem(col1x + espacingItem, col1y, 0x1401);
        AddLabelHtml(col1x + spacingLabel, col1y + 5, 200, 32, "Thief", "#FFFFFF", 4, false);


        col1y += espacing;

        AddButton(col1x, col1y, 2152, 2152, 7, GumpButtonType.Reply, 17);
        AddItem(col1x + espacingItem, col1y +5, 0x0EFA);
        AddLabelHtml(col1x + spacingLabel, col1y + 5, 200, 32, "Necromancer", "#FFFFFF", 4, false);


        // Coluna 1 Levels
        col1x = startPageX+160;
        col1y = startPageY+110;
        int labelsize = 80;
        espacing = 42;

        col1x += espacing;

        for (int i = 1; i < 7; i++)
        {
            AddRadio(col1x, col1y, ZuluGumpChecks.SilverRock, i==5?true:false, i);
            AddLabelHtml(col1x + 24, col1y, labelsize, 32, "Level "+i, "#FFFFFF", 4, false);

            col1y += espacing;
        };

        //TITULO OUTLANDS  ID 2446 ou 2501

        //BANNERS LATERIAS OUTLANDS 10550,10551,10552

        ///Layout scrolls para animalr lore 9390
        ///

        //CHAR STATUS GUMP 10860


        ///Possiveis titulos:
        ///// 40135, 40136, 40029, 1143, 1591, 1590, 1764
        ///

        //Testar gump manual:
        // 4 partes:
        // 1596,1597,1598,1599
    }



}
