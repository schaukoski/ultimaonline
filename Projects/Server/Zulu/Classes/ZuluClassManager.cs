using Server.Targeting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Server;

public enum ZuluClass
{
    NonClass,
    Warrior,
    Mage,
    Necromancer,
    Ranger,
    Bard,
    Crafter,
    Thief
}

public static class ZuluClassManager
{
    private static ZuluClassInfo[] _classes;

    public static void Initialize()
    {
        EventSink.Connected += EventSink_Connected;

        CommandSystem.Register("showclasse", AccessLevel.Player, OnClassCommand);
        CommandSystem.Register("trigger", AccessLevel.Player, OnTriggerCommand);
        CommandSystem.Register("setclass", AccessLevel.Player, OnSetClassCommand);


        _classes = new ZuluClassInfo[Enum.GetValues<ZuluClass>().Length];
        _classes[(int)ZuluClass.NonClass] = new ZuluClassInfo(
            "NonClass", ZuluClass.NonClass, Array.Empty<SkillName>(), Array.Empty<ZuluModifierSet[]>()
            );


        _classes[(int)ZuluClass.Warrior] = new ZuluClassInfo(
            "Warrior",
            ZuluClass.Warrior,
            [
                SkillName.Wrestling,
                SkillName.Tactics,
                SkillName.Healing,
                SkillName.Anatomy,
                SkillName.Swords,
                SkillName.Macing,
                SkillName.Fencing,
                SkillName.Parry,
            ],
            [
                null, // LEVEL 0
                //  LEVEL 1
                [
                    //POR LEVEL
                    new ZuluModifierSet(ZuluMod.PhysicalDamageAmp, 15),
                    new ZuluModifierSet(ZuluMod.PhysicalProtection, 15),
                    new ZuluModifierSet(ZuluMod.HealingBonus, 15),
                    new ZuluModifierSet(ZuluMod.ParryngChance, 15),

                    //ESPECIFIC LVL 1
                    new ZuluModifierSet(ZuluMod.SpellAmplifier, -50),
                    new ZuluModifierSet(ZuluMod.SpellProtection, -50),

                ],
                // LEVEL 2
                [
                    //POR LEVEL
                    new ZuluModifierSet(ZuluMod.PhysicalDamageAmp, 15),
                    new ZuluModifierSet(ZuluMod.PhysicalProtection, 15),
                    new ZuluModifierSet(ZuluMod.HealingBonus, 15),
                    new ZuluModifierSet(ZuluMod.ParryngChance, 15),
                ],
                // LEVEL 3
                [
                    //POR LEVEL
                    new ZuluModifierSet(ZuluMod.PhysicalDamageAmp, 15),
                    new ZuluModifierSet(ZuluMod.PhysicalProtection, 15),
                    new ZuluModifierSet(ZuluMod.HealingBonus, 15),
                    new ZuluModifierSet(ZuluMod.ParryngChance, 15),
                ],
                // LEVEL 4
                [
                    //POR LEVEL
                    new ZuluModifierSet(ZuluMod.PhysicalDamageAmp, 15),
                    new ZuluModifierSet(ZuluMod.PhysicalProtection, 15),
                    new ZuluModifierSet(ZuluMod.HealingBonus, 15),
                    new ZuluModifierSet(ZuluMod.ParryngChance, 15),
                ],
                // LEVEL 5
                [
                    //POR LEVEL
                    new ZuluModifierSet(ZuluMod.PhysicalDamageAmp, 15),
                    new ZuluModifierSet(ZuluMod.PhysicalProtection, 15),
                    new ZuluModifierSet(ZuluMod.HealingBonus, 15),
                    new ZuluModifierSet(ZuluMod.ParryngChance, 15),
                ],

                // LEVEL 6
                [
                    //POR LEVEL
                    new ZuluModifierSet(ZuluMod.PhysicalDamageAmp, 15),
                    new ZuluModifierSet(ZuluMod.PhysicalProtection, 15),
                    new ZuluModifierSet(ZuluMod.HealingBonus, 15),
                    new ZuluModifierSet(ZuluMod.ParryngChance, 15),
                ],
            ]
            );

        _classes[(int)ZuluClass.Mage] = new ZuluClassInfo(
            "Mage",
            ZuluClass.Mage,
            [
                SkillName.Alchemy,
                SkillName.ItemID,
                SkillName.EvalInt,
                SkillName.Inscribe,
                SkillName.MagicResist,
                SkillName.Meditation,
                SkillName.Magery,
                SkillName.SpiritSpeak
            ],
            [
                null, // LEVEL 0
                //  LEVEL 1
                [
                    //POR LEVEL
                    new ZuluModifierSet(ZuluMod.PhysicalDamageAmp, -15),
                    new ZuluModifierSet(ZuluMod.PhysicalProtection, -15),
                    new ZuluModifierSet(ZuluMod.SpellAmplifier, 10),
                    new ZuluModifierSet(ZuluMod.SpellProtection, 10),
                    new ZuluModifierSet(ZuluMod.MeditationRegenAmplifier, 10),

                ],
                // LEVEL 2
                [
                    //POR LEVEL
                    new ZuluModifierSet(ZuluMod.PhysicalDamageAmp, -15),
                    new ZuluModifierSet(ZuluMod.PhysicalProtection, -15),
                    new ZuluModifierSet(ZuluMod.SpellAmplifier, 10),
                    new ZuluModifierSet(ZuluMod.SpellProtection, 10),
                    new ZuluModifierSet(ZuluMod.MeditationRegenAmplifier, 10),
                ],
                // LEVEL 3
                [
                    //POR LEVEL
                    new ZuluModifierSet(ZuluMod.PhysicalDamageAmp, -15),
                    new ZuluModifierSet(ZuluMod.PhysicalProtection, -15),
                    new ZuluModifierSet(ZuluMod.SpellAmplifier, 10),
                    new ZuluModifierSet(ZuluMod.SpellProtection, 10),
                    new ZuluModifierSet(ZuluMod.MeditationRegenAmplifier, 10),
                ],
                // LEVEL 4
                [
                    //POR LEVEL
                    new ZuluModifierSet(ZuluMod.PhysicalDamageAmp, -15),
                    new ZuluModifierSet(ZuluMod.PhysicalProtection, -15),
                    new ZuluModifierSet(ZuluMod.SpellAmplifier, 10),
                    new ZuluModifierSet(ZuluMod.SpellProtection, 10),
                    new ZuluModifierSet(ZuluMod.MeditationRegenAmplifier, 10),
                ],
                // LEVEL 5
                [
                    //POR LEVEL
                    new ZuluModifierSet(ZuluMod.PhysicalDamageAmp, -15),
                    new ZuluModifierSet(ZuluMod.PhysicalProtection, -15),
                    new ZuluModifierSet(ZuluMod.SpellAmplifier, 10),
                    new ZuluModifierSet(ZuluMod.SpellProtection, 10),
                    new ZuluModifierSet(ZuluMod.MeditationRegenAmplifier, 10),
                ],

                // LEVEL 6
                [
                    //POR LEVEL
                    new ZuluModifierSet(ZuluMod.PhysicalDamageAmp, -15),
                    new ZuluModifierSet(ZuluMod.PhysicalProtection, -15),
                    new ZuluModifierSet(ZuluMod.SpellAmplifier, 10),
                    new ZuluModifierSet(ZuluMod.SpellProtection, 10),
                    new ZuluModifierSet(ZuluMod.MeditationRegenAmplifier, 10),
                ],
            ]
            );

        _classes[(int)ZuluClass.Necromancer] = new ZuluClassInfo(
        "Necromancer",
    ZuluClass.Necromancer,
    [
                SkillName.Wrestling,
                SkillName.AnimalLore,
                SkillName.EvalInt,
                SkillName.Inscribe,
                SkillName.MagicResist,
                SkillName.Meditation,
                SkillName.Necromancy,
                SkillName.SpiritSpeak,
    ],
    [
        null, // LEVEL 0
                //  LEVEL 1
                [
                    //POR LEVEL
                    new ZuluModifierSet(ZuluMod.PhysicalDamageAmp, -15),
                    new ZuluModifierSet(ZuluMod.PhysicalProtection, -15),
                    new ZuluModifierSet(ZuluMod.SpellAmplifier, 10),
                    new ZuluModifierSet(ZuluMod.SpellProtection, 10),
                    new ZuluModifierSet(ZuluMod.MeditationRegenAmplifier, 10),

                ],
                // LEVEL 2
                [
                    //POR LEVEL
                    new ZuluModifierSet(ZuluMod.PhysicalDamageAmp, -15),
                    new ZuluModifierSet(ZuluMod.PhysicalProtection, -15),
                    new ZuluModifierSet(ZuluMod.SpellAmplifier, 10),
                    new ZuluModifierSet(ZuluMod.SpellProtection, 10),
                    new ZuluModifierSet(ZuluMod.MeditationRegenAmplifier, 10),
                ],
                // LEVEL 3
                [
                    //POR LEVEL
                    new ZuluModifierSet(ZuluMod.PhysicalDamageAmp, -15),
                    new ZuluModifierSet(ZuluMod.PhysicalProtection, -15),
                    new ZuluModifierSet(ZuluMod.SpellAmplifier, 10),
                    new ZuluModifierSet(ZuluMod.SpellProtection, 10),
                    new ZuluModifierSet(ZuluMod.MeditationRegenAmplifier, 10),
                ],
                // LEVEL 4
                [
                    //POR LEVEL
                    new ZuluModifierSet(ZuluMod.PhysicalDamageAmp, -15),
                    new ZuluModifierSet(ZuluMod.PhysicalProtection, -15),
                    new ZuluModifierSet(ZuluMod.SpellAmplifier, 10),
                    new ZuluModifierSet(ZuluMod.SpellProtection, 10),
                    new ZuluModifierSet(ZuluMod.MeditationRegenAmplifier, 10),
                ],
                // LEVEL 5
                [
                    //POR LEVEL
                    new ZuluModifierSet(ZuluMod.PhysicalDamageAmp, -15),
                    new ZuluModifierSet(ZuluMod.PhysicalProtection, -15),
                    new ZuluModifierSet(ZuluMod.SpellAmplifier, 10),
                    new ZuluModifierSet(ZuluMod.SpellProtection, 10),
                    new ZuluModifierSet(ZuluMod.MeditationRegenAmplifier, 10),
                ],

                // LEVEL 6
                [
                    //POR LEVEL
                    new ZuluModifierSet(ZuluMod.PhysicalDamageAmp, -15),
                    new ZuluModifierSet(ZuluMod.PhysicalProtection, -15),
                    new ZuluModifierSet(ZuluMod.SpellAmplifier, 10),
                    new ZuluModifierSet(ZuluMod.SpellProtection, 10),
                    new ZuluModifierSet(ZuluMod.MeditationRegenAmplifier, 10),
                ],
            ]
        );

        _classes[(int)ZuluClass.Ranger] = new ZuluClassInfo(
"Ranger",
ZuluClass.Ranger,
[
                SkillName.Tracking,
                SkillName.Archery,
                SkillName.AnimalLore,
                SkillName.Veterinary,
                SkillName.AnimalTaming,
                SkillName.Fishing,
                SkillName.Camping,
                SkillName.Cooking,
],
[
null, // LEVEL 0
                //  LEVEL 1
                [
                    //POR LEVEL
                    new ZuluModifierSet(ZuluMod.HealingBonus, 15),
                    new ZuluModifierSet(ZuluMod.ArcheryDamageAmp, 115),

                ],
                // LEVEL 2
                [
                    //POR LEVEL
                    new ZuluModifierSet(ZuluMod.HealingBonus, 15),
                    new ZuluModifierSet(ZuluMod.ArcheryDamageAmp, 115),
                ],
                // LEVEL 3
                [
                    //POR LEVEL
                    new ZuluModifierSet(ZuluMod.HealingBonus, 15),
                    new ZuluModifierSet(ZuluMod.ArcheryDamageAmp, 115),
                ],
                // LEVEL 4
                [
                    //POR LEVEL
                    new ZuluModifierSet(ZuluMod.HealingBonus, 15),
                    new ZuluModifierSet(ZuluMod.ArcheryDamageAmp, 115),
                ],
                // LEVEL 5
                [
                    //POR LEVEL
                    new ZuluModifierSet(ZuluMod.HealingBonus, 15),
                    new ZuluModifierSet(ZuluMod.ArcheryDamageAmp, 115),
                ],

                // LEVEL 6
                [
                    //POR LEVEL
                    new ZuluModifierSet(ZuluMod.HealingBonus, 15),
                    new ZuluModifierSet(ZuluMod.ArcheryDamageAmp, 115),
                ],
    ]
);

        _classes[(int)ZuluClass.Bard] = new ZuluClassInfo(
"Bard",
ZuluClass.Bard,
[
                SkillName.Provocation,
                SkillName.Musicianship,
                SkillName.Herding,
                SkillName.Discordance,
                SkillName.TasteID,
                SkillName.Peacemaking,
                SkillName.Cartography,
                SkillName.Begging,
],
[
null, // LEVEL 0
                //  LEVEL 1
                [
                    //POR LEVEL
                   

                ],
                // LEVEL 2
                [
                    //POR LEVEL
                  
                ],
                // LEVEL 3
                [
                    //POR LEVEL
                    
                ],
                // LEVEL 4
                [
                    //POR LEVEL
                    
                ],
                // LEVEL 5
                [
                    //POR LEVEL
                    
                ],

                // LEVEL 6
                [
                    //POR LEVEL
          
                ],
]
);

        _classes[(int)ZuluClass.Crafter] = new ZuluClassInfo(
"Crafter",
ZuluClass.Crafter,
[
                SkillName.Tinkering,
                SkillName.ArmsLore,
                SkillName.Fletching,
                SkillName.Tailoring,
                SkillName.Mining,
                SkillName.Lumberjacking,
                SkillName.Carpentry,
                SkillName.Blacksmith,
],
[
null, // LEVEL 0
                //  LEVEL 1
                [
                    //POR LEVEL


                ],
                // LEVEL 2
                [
                    //POR LEVEL

                ],
                // LEVEL 3
                [
                    //POR LEVEL

                ],
                // LEVEL 4
                [
                    //POR LEVEL

                ],
                // LEVEL 5
                [
                    //POR LEVEL

                ],

                // LEVEL 6
                [
                    //POR LEVEL

                ],
]
);
        _classes[(int)ZuluClass.Thief] = new ZuluClassInfo(
"Thief",
ZuluClass.Thief,
[
                SkillName.Hiding,
                SkillName.Stealth,
                SkillName.Stealing,
                SkillName.DetectHidden,
                SkillName.RemoveTrap,
                SkillName.Poisoning,
                SkillName.Lockpicking,
                SkillName.Snooping,
],
[
null, // LEVEL 0
                //  LEVEL 1
                [
                    //POR LEVEL
                    new ZuluModifierSet(ZuluMod.HealingBonus, 15),
                    new ZuluModifierSet(ZuluMod.ArcheryDamageAmp, 115),

                ],
                // LEVEL 2
                [
                    //POR LEVEL
                    new ZuluModifierSet(ZuluMod.HealingBonus, 15),
                    new ZuluModifierSet(ZuluMod.ArcheryDamageAmp, 115),
                ],
                // LEVEL 3
                [
                    //POR LEVEL
                    new ZuluModifierSet(ZuluMod.HealingBonus, 15),
                    new ZuluModifierSet(ZuluMod.ArcheryDamageAmp, 115),
                ],
                // LEVEL 4
                [
                    //POR LEVEL
                    new ZuluModifierSet(ZuluMod.HealingBonus, 15),
                    new ZuluModifierSet(ZuluMod.ArcheryDamageAmp, 115),
                ],
                // LEVEL 5
                [
                    //POR LEVEL
                    new ZuluModifierSet(ZuluMod.HealingBonus, 15),
                    new ZuluModifierSet(ZuluMod.ArcheryDamageAmp, 115),
                ],

                // LEVEL 6
                [
                    //POR LEVEL
                    new ZuluModifierSet(ZuluMod.HealingBonus, 15),
                    new ZuluModifierSet(ZuluMod.ArcheryDamageAmp, 115),
                ],
]
);


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
                    case "warrior": SetClass(m, ZuluClass.Warrior, _level); break;
                    case "mage": SetClass(m, ZuluClass.Mage, _level); break;
                    case "necromancer": SetClass(m, ZuluClass.Necromancer, _level); break;
                    case "ranger": SetClass(m, ZuluClass.Ranger, _level); break;
                    case "bard": SetClass(m, ZuluClass.Bard, _level); break;
                    case "crafter": SetClass(m, ZuluClass.Crafter, _level); break;
                    case "thief": SetClass(m, ZuluClass.Thief, _level); break;

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

    public static void SetClass(Mobile m, ZuluClass classe, int level)
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
            if (_classes[(int)classe].RequiredSkills.Contains(skill.SkillName))
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

        if (m.ActiveZuluClass == ZuluClass.NonClass || m.ActiveZuluClassLevel == 0)
        {
            m.SendMessage("You aren't in any specific classe");
            return;
        }

        m.SendMessage(
            $"You're a qualified level {m.ActiveZuluClassLevel} {_classes[(int)m.ActiveZuluClass].Name}");
    }



    private static void EventSink_Connected(Mobile obj)
    {
        CalculateAndSetClass(obj);
    }

    private static readonly (int Level, double MinPoints, double MinPercent)[] ClassLevels =
    {
        (1, 600, 0.60),
        (2, 720, 0.68),
        (3, 840, 0.76),
        (4, 960, 0.84),
        (5, 1080, 0.92),
        (6, 1200, 1.00)
    };

    public static ZuluClassInfo GetInfo(ZuluClass classe) => _classes[(int)classe];

    public static void CalculateAndSetClass(Mobile m)
    {
        if (m == null || !m.Player)
            return;

        if (m.SkillsTotal < 6000 || m.SkillsTotal > 13200)
        {
            m.ActiveZuluClass = ZuluClass.NonClass;
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

            double percentInClass = classSkillPoints / (m.SkillsTotal / 10);

            foreach (var rule in ClassLevels)
            {
                if (classSkillPoints >= rule.MinPoints && percentInClass >= rule.MinPercent)
                {
                    m.ActiveZuluClass = classe.Classe;
                    m.ActiveZuluClassLevel = rule.Level;

                }

            }
        }
    }
}
