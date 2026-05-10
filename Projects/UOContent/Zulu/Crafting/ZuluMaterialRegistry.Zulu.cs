using System.Collections.Generic;
using System.IO;
using System.Linq;
using Server.Json;
using Server.Logging;

namespace Server.Zulu.Crafting;

public static class ZuluMaterialRegistry
{
    private static readonly ILogger logger = LogFactory.GetLogger(typeof(ZuluMaterialRegistry));
    private const string RelPath = "Configuration/zulu-materials.json";

    private static Dictionary<int, ZuluMaterialDefinition> _byId = new();
    private static Dictionary<string, ZuluMaterialDefinition> _byName = new();
    private static List<ZuluMaterialDefinition> _all = new();

    public static IReadOnlyList<ZuluMaterialDefinition> All => _all;

    public static void Configure()
    {
        var path = Path.Join(Core.BaseDirectory, RelPath);

        if (!File.Exists(path))
        {
            logger.Warning("Zulu material configuration not found at {Path}; registry will be empty.", RelPath);
            return;
        }

        var list = JsonConfig.Deserialize<List<ZuluMaterialDefinition>>(path);
        if (list == null)
        {
            logger.Error("Failed reading Zulu material configuration from {Path}", RelPath);
            return;
        }

        _all = list;
        _byId = list.ToDictionary(m => m.Id);
        _byName = list.ToDictionary(m => m.Name, System.StringComparer.OrdinalIgnoreCase);

        logger.Information("Loaded {Count} Zulu materials from {Path}", list.Count, RelPath);
    }

    public static ZuluMaterialDefinition Get(int id) =>
        _byId.TryGetValue(id, out var def) ? def : null;

    public static ZuluMaterialDefinition GetByName(string name) =>
        name != null && _byName.TryGetValue(name, out var def) ? def : null;

    public static IEnumerable<ZuluMaterialDefinition> ByCategory(ZuluCraftCategory category)
    {
        foreach (var def in _all)
        {
            if (def.Category == category)
            {
                yield return def;
            }
        }
    }
}
