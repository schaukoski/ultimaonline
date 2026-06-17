using System;
using System.Collections.Generic;
using System.Linq;

namespace Server;

public sealed class ZuluClassInfo
{
    public string Name { get; set; }

    public ZuluClass Classe { get; set; }

    public IReadOnlyList<SkillName> RequiredSkills { get; set; }

    public ZuluModifierSet[][] LevelModifiers { get; }
    public ZuluModifierSet[][] AccumulatedModifiers { get; }

    public Type[][] LevelForbiddenTypes { get; private set; }
    public Type[][] AccumulatedForbiddenTypes { get; private set; }

    public Dictionary<Layer, Type[]>[] LevelLayerWhitelist { get; private set; }
    public Dictionary<Layer, Type[]>[] AccumulatedLayerWhitelist { get; private set; }

    public ZuluClassInfo(
        string name,
        ZuluClass classe,
        IReadOnlyList<SkillName> requiredSkills,
        ZuluModifierSet[][] levelModifiers)
    {
        Name = name;
        Classe = classe;
        RequiredSkills = requiredSkills;
        LevelModifiers = levelModifiers;

        AccumulatedModifiers = BuildAccumulated(levelModifiers);

        int len = levelModifiers.Length;
        LevelForbiddenTypes = new Type[len][];
        AccumulatedForbiddenTypes = new Type[len][];
        LevelLayerWhitelist = new Dictionary<Layer, Type[]>[len];
        AccumulatedLayerWhitelist = new Dictionary<Layer, Type[]>[len];
    }

    public void SetRestrictions(
        Type[][] levelForbiddenTypes = null,
        Dictionary<Layer, Type[]>[] levelLayerWhitelist = null)
    {
        int len = LevelModifiers.Length;

        LevelForbiddenTypes = levelForbiddenTypes ?? new Type[len][];
        LevelLayerWhitelist = levelLayerWhitelist ?? new Dictionary<Layer, Type[]>[len];

        AccumulatedForbiddenTypes = BuildAccumulatedTypes(LevelForbiddenTypes);
        AccumulatedLayerWhitelist = BuildAccumulatedWhitelist(LevelLayerWhitelist);
    }

    private static ZuluModifierSet[][] BuildAccumulated(
    ZuluModifierSet[][] levelMods)
    {
        int maxLevel = levelMods.Length - 1;

        var result = new ZuluModifierSet[maxLevel + 1][];

        var totals = new Dictionary<ZuluMod, double>();

        for (int lvl = 1; lvl <= maxLevel; lvl++)
        {
            if (levelMods[lvl] != null)
            {
                foreach (var m in levelMods[lvl])
                {
                    totals[m.zuluMod] = totals.TryGetValue(m.zuluMod, out var v)
                        ? v + m.value
                        : m.value;
                }
            }

            result[lvl] = totals
                .Select(kv => new ZuluModifierSet(kv.Key, kv.Value))
                .ToArray();
        }

        return result;
    }

    private static Type[][] BuildAccumulatedTypes(Type[][] perLevel)
    {
        int maxLevel = perLevel.Length - 1;
        var result = new Type[maxLevel + 1][];
        var acc = new HashSet<Type>();

        for (int lvl = 1; lvl <= maxLevel; lvl++)
        {
            if (perLevel[lvl] != null)
            {
                foreach (var t in perLevel[lvl])
                {
                    acc.Add(t);
                }
            }

            result[lvl] = acc.Count > 0 ? acc.ToArray() : null;
        }

        return result;
    }

    private static Dictionary<Layer, Type[]>[] BuildAccumulatedWhitelist(Dictionary<Layer, Type[]>[] perLevel)
    {
        int maxLevel = perLevel.Length - 1;
        var result = new Dictionary<Layer, Type[]>[maxLevel + 1];
        var acc = new Dictionary<Layer, HashSet<Type>>();

        for (int lvl = 1; lvl <= maxLevel; lvl++)
        {
            if (perLevel[lvl] != null)
            {
                foreach (var kv in perLevel[lvl])
                {
                    if (!acc.TryGetValue(kv.Key, out var set))
                    {
                        set = new HashSet<Type>();
                        acc[kv.Key] = set;
                    }

                    foreach (var t in kv.Value)
                    {
                        set.Add(t);
                    }
                }
            }

            if (acc.Count == 0)
            {
                result[lvl] = null;
                continue;
            }

            var snapshot = new Dictionary<Layer, Type[]>(acc.Count);
            foreach (var kv in acc)
            {
                snapshot[kv.Key] = kv.Value.ToArray();
            }
            result[lvl] = snapshot;
        }

        return result;
    }
}

public readonly struct ZuluModifierSet
{
    public readonly ZuluMod zuluMod;
    public readonly double value;

    public ZuluModifierSet(ZuluMod zuluMod, double value)
    {
        this.zuluMod = zuluMod;
        this.value = value;
    }
}
