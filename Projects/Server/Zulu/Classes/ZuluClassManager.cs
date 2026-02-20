using Server.Targeting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Server;


public static class ZuluClassManager
{
    public static void Initialize()
    {
        EventSink.Connected += EventSink_Connected;

        CommandSystem.Register("showclasse", AccessLevel.Player, OnClassCommand);
        CommandSystem.Register("trigger", AccessLevel.Player, OnTriggerCommand);
        CommandSystem.Register("setclass", AccessLevel.Player, OnSetClassCommand);
    }

    private static void OnSetClassCommand(CommandEventArgs e)
    {
        e.Mobile.Target = new InternalTarget(e.GetString(0), e.GetInt32(1));
    }

    private class InternalTarget : Target
    {
        public string _classe { get; set; }
        public int _level { get; set; }
        public InternalTarget(string classe, int level) : base(16, false, TargetFlags.None)
        {
            _classe = classe;
            _level = level;
        }

        protected override void OnTarget(Mobile from, object targeted)
        {
            if (targeted is Mobile m)
            {
                switch (_classe)
                {
                    case "warrior": SetClass(m, new WarriorClass(), _level); break;
                    case "mage": SetClass(m, new MageClass(), _level); break;
                    case "necromancer": SetClass(m, new NecromancerClass(), _level); break;
                    case "ranger": SetClass(m, new RangerClass(), _level); break;
                    case "bard": SetClass(m, new BardClass(), _level); break;
                    case "crafter": SetClass(m, new CrafterClass(), _level); break;
                    case "thief": SetClass(m, new ThiefClass(), _level); break;

                    default:
                        break;
                }
            }
            else
            {
                from.SendMessage("Alvo inválido.");
            }
        }
    }

    public static void SetClass(Mobile m, ZuluClassBase classe, int level)
    {
        double baseValue = 0; 
        switch (level)
        {
            case 1: baseValue = 75.0; break;
            case 2: baseValue = 90.0; break;
            case 3: baseValue = 105.0; break;
            case 4: baseValue = 120.0; break;
            case 5: baseValue = 135.0; break;
            case 6: baseValue = 150.0; break;
            case 7: baseValue = 165.0; break;

            default:
                break;
        }
        foreach (Skill skill in m.Skills)
        {
            if (classe.RequiredSkills.Contains(skill.SkillName))
                skill.Base = baseValue;
            else
                skill.Base = 0;
        }

        CalculateAndSetClass(m);
    }

    private static void OnGumpsCommand(CommandEventArgs e)
    {
        


    }

    private static void OnTriggerCommand(CommandEventArgs e)
    {
        
        e.Mobile.SendMessage("teste");

    }


    private static void OnClassCommand(CommandEventArgs e)
    {
        ShowClassMessage(e.Mobile);
    }

    public static void ShowClassMessage(Mobile m)
    {
        if (m == null)
            return;

        if (m.ActiveZuluClass == null || m.ActiveZuluClassLevel == 0)
        {
            m.SendMessage("You aren't in any specific classe");
            return;
        }

        var zClass = m.ActiveZuluClass;

        m.SendMessage(
            $"You're a qualified level {m.ActiveZuluClassLevel} {zClass.Name}");
    }



    private static void EventSink_Connected(Mobile obj)
    {
        CalculateAndSetClass(obj);
    }

    private static readonly List<IZuluClass> _classes = new List<IZuluClass> { new WarriorClass(), new MageClass(), new NecromancerClass(), new RangerClass(), new CrafterClass(), new BardClass(), new ThiefClass() };

    private static readonly (int Level, double MinPoints, double MinPercent)[] ClassLevels =
    {
        (1, 600, 0.60),
        (2, 720, 0.68),
        (3, 840, 0.76),
        (4, 960, 0.84),
        (5, 1080, 0.92),
        (6, 1200, 1.00)
    };

    public static void CalculateAndSetClass(Mobile m)
    {
        if (m == null || !m.Player)
            return;

        if (m.SkillsTotal < 6000 || m.SkillsTotal > 13200)
        {
            m.ActiveZuluClass = new NonClass() {};
            m.ActiveZuluClassLevel = 0;
            return;
        }

        foreach (var classe in _classes)
        {
            int classSkillPoints = 0;

            foreach (var skill in classe.RequiredSkills)
            {
                classSkillPoints += (int)m.Skills[skill]?.Base;
            }

            if (classSkillPoints < 600)
                continue;

            double percentInClass = classSkillPoints / (m.SkillsTotal/10);

            foreach(var rule in ClassLevels)
            {
                if (classSkillPoints >= rule.MinPoints && percentInClass >= rule.MinPercent)
                {
                    m.ActiveZuluClass = classe;
                    m.ActiveZuluClassLevel = rule.Level;
                    
                }
           
            }
        }
    }
}
