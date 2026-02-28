using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Server;

public sealed class ZuluClassInfo
{
    public string Name { get; set; }

    public ZuluClass Classe { get; set; }

    public IReadOnlyList<SkillName> RequiredSkills { get; set; }

    public ZuluModifierSet[][] LevelModifiers { get; }
    public ZuluModifierSet[][] AccumulatedModifiers { get; }

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
    }

    private static ZuluModifierSet[][] BuildAccumulated(
    ZuluModifierSet[][] levelMods)
    {
        int maxLevel = levelMods.Length - 1;

        var result = new ZuluModifierSet[maxLevel + 1][];

        // buffer reutilizável
        var totals = new Dictionary<ZuluMod, double>();

        for (int lvl = 1; lvl <= maxLevel; lvl++)
        {
            // soma os mods do level
            if (levelMods[lvl] != null)
            {
                foreach (var m in levelMods[lvl])
                    totals[m.zuluMod] = totals.TryGetValue(m.zuluMod, out var v)
                        ? v + m.value
                        : m.value;
            }

            // snapshot imutável do estado atual
            result[lvl] = totals
                .Select(kv => new ZuluModifierSet(kv.Key, kv.Value))
                .ToArray();
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
