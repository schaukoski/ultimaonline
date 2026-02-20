using Server.Engines.ConPVP;
using Server.Gumps;
using Server.Mobiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Server;

public static class ZuluHelper
{
    public static void Initialize()
    {
        CommandSystem.Register("teste", AccessLevel.Player, OnTesteCommand);
        CommandSystem.Register("warshard", AccessLevel.Player, OnWarShardCommand);
    }

    private static void OnWarShardCommand(CommandEventArgs e)
    {
       
        e.Mobile.SendGump(new WarshardGump(e.Mobile, 0));

    }

    private static void OnTesteCommand(CommandEventArgs e)
    {

      
    }
}
