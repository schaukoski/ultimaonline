using Server.Items;
using System;
using System.Collections.Generic;

namespace Server;

public static class ZuluClassRestrictions
{
    public static void Configure()
    {
        ZuluClassManager.OnClassesInitialized = InitializeClassRestrictions;
        ZuluClassManager.OnClassChanged = EnforceEquippedItems;
    }

    private static readonly Type[] PlateArmorTypes =
    {
        typeof(PlateChest),
        typeof(PlateLegs),
        typeof(PlateArms),
        typeof(PlateGloves),
        typeof(PlateGorget),
        typeof(PlateHelm),
    };

    private static readonly Type[] ChainArmorTypes =
    {
        typeof(ChainChest),
        typeof(ChainLegs),
        typeof(ChainCoif),
    };

    private static readonly Type[] RingmailArmorTypes =
    {
        typeof(RingmailChest),
        typeof(RingmailLegs),
        typeof(RingmailArms),
        typeof(RingmailGloves),
    };

    public static void InitializeClassRestrictions(ZuluClassInfo[] classes)
    {
        ConfigureMage(classes[(int)ZuluClass.Mage]);
        ConfigureBlacklistPlate(classes[(int)ZuluClass.Necromancer]);
        ConfigureBlacklistPlate(classes[(int)ZuluClass.Ranger]);
        ConfigureBlacklistPlate(classes[(int)ZuluClass.Bard]);
        ConfigureBlacklistPlate(classes[(int)ZuluClass.Crafter]);
        ConfigureBlacklistPlate(classes[(int)ZuluClass.Thief]);
    }

    private static void ConfigureMage(ZuluClassInfo info)
    {
        int len = info.LevelModifiers.Length;

        var forbiddenList = new List<Type>();
        forbiddenList.AddRange(PlateArmorTypes);
        forbiddenList.AddRange(ChainArmorTypes);
        forbiddenList.AddRange(RingmailArmorTypes);

        var forbidden = new Type[len][];
        forbidden[1] = forbiddenList.ToArray();

        var allowedHandTypes = new[]
        {
            typeof(GnarledStaff),
            typeof(QuarterStaff),
            typeof(Spellbook),
            typeof(NecromancerSpellbook),
        };
        var whitelist = new Dictionary<Layer, Type[]>[len];
        whitelist[1] = new Dictionary<Layer, Type[]>
        {
            [Layer.OneHanded] = allowedHandTypes,
            [Layer.TwoHanded] = allowedHandTypes,
        };

        info.SetRestrictions(
            levelForbiddenTypes: forbidden,
            levelLayerWhitelist: whitelist);
    }

    private static void ConfigureBlacklistPlate(ZuluClassInfo info)
    {
        int len = info.LevelModifiers.Length;
        var forbidden = new Type[len][];
        forbidden[1] = PlateArmorTypes;
        info.SetRestrictions(levelForbiddenTypes: forbidden);
    }

    public static bool IsEquipAllowed(Mobile m, Item item)
    {
        if (m == null || item == null)
        {
            return true;
        }

        if (!m.Player || m.AccessLevel >= AccessLevel.GameMaster)
        {
            return true;
        }

        var classInfo = ZuluClassManager.GetInfo(m.ActiveZuluClass);
        int level = m.ActiveZuluClassLevel;

        if (classInfo == null || level <= 0)
        {
            return true;
        }

        var forbiddenTypes = level < classInfo.AccumulatedForbiddenTypes.Length
            ? classInfo.AccumulatedForbiddenTypes[level]
            : null;
        if (forbiddenTypes != null)
        {
            var itemType = item.GetType();
            foreach (var t in forbiddenTypes)
            {
                if (t.IsAssignableFrom(itemType))
                {
                    return false;
                }
            }
        }

        var whitelistMap = level < classInfo.AccumulatedLayerWhitelist.Length
            ? classInfo.AccumulatedLayerWhitelist[level]
            : null;
        if (whitelistMap != null && whitelistMap.TryGetValue(item.Layer, out var allowed))
        {
            var itemType = item.GetType();
            foreach (var t in allowed)
            {
                if (t.IsAssignableFrom(itemType))
                {
                    return true;
                }
            }
            return false;
        }

        return true;
    }

    public static void EnforceEquippedItems(Mobile m)
    {
        if (m == null || !m.Player || m.AccessLevel >= AccessLevel.GameMaster)
        {
            return;
        }

        var equipped = m.Items;
        if (equipped == null || equipped.Count == 0)
        {
            return;
        }

        for (int i = equipped.Count - 1; i >= 0; i--)
        {
            var item = equipped[i];
            if (item == null)
            {
                continue;
            }

            if (!IsEquipAllowed(m, item))
            {
                item.Movable = true;

                if (m.PlaceInBackpack(item))
                {
                    m.SendMessage($"Your class no longer allows wearing {item.GetType().Name}; it was moved to your backpack.");
                }
                else
                {
                    item.MoveToWorld(m.Location, m.Map);
                    m.SendMessage($"Your class no longer allows wearing {item.GetType().Name}; it fell to the ground.");
                }
            }
        }
    }
}
