using System.Collections.Generic;
using Server;

namespace Server.Zulu.Gumps;

public class PlayerStatusPreferencesData
{
    public bool HideZeroMods { get; set; } = true;
    public PlayerStatusLanguage? LanguageOverride { get; set; }
}

public class PlayerStatusPreferences : GenericPersistence
{
    private static PlayerStatusPreferences _instance;

    private static readonly Dictionary<Mobile, PlayerStatusPreferencesData> _prefs = new();

    public static void Configure()
    {
        _instance = new PlayerStatusPreferences();
    }

    public PlayerStatusPreferences() : base("ZuluPlayerStatusPreferences", 10)
    {
    }

    public static PlayerStatusPreferencesData Get(Mobile m)
    {
        if (!_prefs.TryGetValue(m, out var p))
        {
            p = new PlayerStatusPreferencesData();
            _prefs[m] = p;
        }
        return p;
    }

    public static void Save(Mobile m, PlayerStatusPreferencesData data)
    {
        _prefs[m] = data;
    }

    public override void Serialize(IGenericWriter writer)
    {
        writer.WriteEncodedInt(0); // version

        writer.WriteEncodedInt(_prefs.Count);
        foreach (var (m, data) in _prefs)
        {
            writer.Write(m);
            writer.Write(data.HideZeroMods);
            writer.Write(data.LanguageOverride.HasValue);
            if (data.LanguageOverride.HasValue)
                writer.WriteEncodedInt((int)data.LanguageOverride.Value);
        }
    }

    public override void Deserialize(IGenericReader reader)
    {
        var version = reader.ReadEncodedInt();

        var count = reader.ReadEncodedInt();
        for (var i = 0; i < count; i++)
        {
            var m = reader.ReadEntity<Mobile>();
            var hideZero = reader.ReadBool();
            var hasLang = reader.ReadBool();
            PlayerStatusLanguage? lang = hasLang ? (PlayerStatusLanguage)reader.ReadEncodedInt() : null;

            if (m != null)
            {
                _prefs[m] = new PlayerStatusPreferencesData
                {
                    HideZeroMods = hideZero,
                    LanguageOverride = lang,
                };
            }
        }
    }
}
