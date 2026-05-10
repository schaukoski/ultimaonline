using Server;

namespace Server.Zulu.Gumps;

public enum PlayerStatusLanguage
{
    PtBR,
    EnUS,
    EsES,
    SvSE,
    RuRU,
    ItIT,
}

public static class PlayerStatusLanguageResolver
{
    public static PlayerStatusLanguage Resolve(Mobile m)
    {
        var pref = PlayerStatusPreferences.Get(m);
        if (pref.LanguageOverride.HasValue)
            return pref.LanguageOverride.Value;

        return (m.Language ?? "ENU") switch
        {
            "PTB" => PlayerStatusLanguage.PtBR,
            "ESP" => PlayerStatusLanguage.EsES,
            "SVE" => PlayerStatusLanguage.SvSE,
            "RUS" => PlayerStatusLanguage.RuRU,
            "ITA" => PlayerStatusLanguage.ItIT,
            _ => PlayerStatusLanguage.EnUS,
        };
    }

    public static (string Main, string Second) GetDescription(ZuluMod mod, PlayerStatusLanguage lang)
    {
        var cfg = ZuluModManager.GetMod(mod);
        if (cfg == null)
            return ("", "");

        var (main, second) = lang switch
        {
            PlayerStatusLanguage.PtBR => (cfg.Description_PtBR, cfg.Description_PtBR_SecondLine),
            PlayerStatusLanguage.EnUS => (cfg.Description_EnUS, cfg.Description_EnUS_SecondLine),
            PlayerStatusLanguage.EsES => (cfg.Description_EsES, cfg.Description_EsES_SecondLine),
            PlayerStatusLanguage.SvSE => (cfg.Description_SvSE, cfg.Description_SvSE_SecondLine),
            PlayerStatusLanguage.RuRU => (cfg.Description_RuRU, cfg.Description_RuRU_SecondLine),
            PlayerStatusLanguage.ItIT => (cfg.Description_ItIT, cfg.Description_ItIT_SecondLine),
            _ => (cfg.Description_EnUS, cfg.Description_EnUS_SecondLine),
        };

        if (string.IsNullOrEmpty(main))
        {
            main = cfg.Description_EnUS;
            second = cfg.Description_EnUS_SecondLine;
        }

        return (main ?? "", second ?? "");
    }

    public static string Label(PlayerStatusLanguage lang, LabelKey key) =>
        lang switch
        {
            PlayerStatusLanguage.PtBR => PtBR(key),
            PlayerStatusLanguage.EsES => EsES(key),
            PlayerStatusLanguage.SvSE => SvSE(key),
            PlayerStatusLanguage.RuRU => RuRU(key),
            PlayerStatusLanguage.ItIT => ItIT(key),
            _ => EnUS(key),
        };

    private static string PtBR(LabelKey k) => k switch
    {
        LabelKey.Title => "Status do Personagem",
        LabelKey.Class => "Classe",
        LabelKey.Level => "Nível",
        LabelKey.HP => "HP",
        LabelKey.Mana => "Mana",
        LabelKey.Stam => "Stam",
        LabelKey.Str => "STR",
        LabelKey.Dex => "DEX",
        LabelKey.Int => "INT",
        LabelKey.Protections => "Proteções",
        LabelKey.MagicalAmps => "Amplificadores Mágicos",
        LabelKey.Combat => "Combate",
        LabelKey.Special => "Especiais",
        LabelKey.HideZeros => "Ocultar zerados",
        LabelKey.Language => "Idioma",
        LabelKey.Refresh => "Atualizar",
        LabelKey.NextLevel => "Próximo nível",
        LabelKey.Total => "TOTAL",
        LabelKey.Source => "Origem",
        LabelKey.Type => "Tipo",
        LabelKey.Value => "Valor",
        LabelKey.NoSources => "Nenhuma fonte ativa.",
        LabelKey.Close => "Fechar",
        LabelKey.OverheadStyle => "Mensagem",
        LabelKey.MinCap => "Mín",
        LabelKey.MaxCap => "Máx",
        _ => k.ToString(),
    };

    private static string EnUS(LabelKey k) => k switch
    {
        LabelKey.Title => "Character Status",
        LabelKey.Class => "Class",
        LabelKey.Level => "Level",
        LabelKey.HP => "HP",
        LabelKey.Mana => "Mana",
        LabelKey.Stam => "Stam",
        LabelKey.Str => "STR",
        LabelKey.Dex => "DEX",
        LabelKey.Int => "INT",
        LabelKey.Protections => "Protections",
        LabelKey.MagicalAmps => "Magical Amplifiers",
        LabelKey.Combat => "Combat",
        LabelKey.Special => "Special",
        LabelKey.HideZeros => "Hide zeroed",
        LabelKey.Language => "Language",
        LabelKey.Refresh => "Refresh",
        LabelKey.NextLevel => "Next level",
        LabelKey.Total => "TOTAL",
        LabelKey.Source => "Source",
        LabelKey.Type => "Type",
        LabelKey.Value => "Value",
        LabelKey.NoSources => "No active sources.",
        LabelKey.Close => "Close",
        LabelKey.OverheadStyle => "Message",
        LabelKey.MinCap => "Min",
        LabelKey.MaxCap => "Max",
        _ => k.ToString(),
    };

    private static string EsES(LabelKey k) => k switch
    {
        LabelKey.Title => "Estado del Personaje",
        LabelKey.Class => "Clase",
        LabelKey.Level => "Nivel",
        LabelKey.HP => "Vida",
        LabelKey.Mana => "Maná",
        LabelKey.Stam => "Res",
        LabelKey.Str => "FUE",
        LabelKey.Dex => "DES",
        LabelKey.Int => "INT",
        LabelKey.Protections => "Protecciones",
        LabelKey.MagicalAmps => "Amplificadores Mágicos",
        LabelKey.Combat => "Combate",
        LabelKey.Special => "Especiales",
        LabelKey.HideZeros => "Ocultar ceros",
        LabelKey.Language => "Idioma",
        LabelKey.Refresh => "Actualizar",
        LabelKey.NextLevel => "Siguiente nivel",
        LabelKey.Total => "TOTAL",
        LabelKey.Source => "Origen",
        LabelKey.Type => "Tipo",
        LabelKey.Value => "Valor",
        LabelKey.NoSources => "Sin fuentes activas.",
        LabelKey.Close => "Cerrar",
        LabelKey.OverheadStyle => "Mensaje",
        LabelKey.MinCap => "Mín",
        LabelKey.MaxCap => "Máx",
        _ => k.ToString(),
    };

    private static string SvSE(LabelKey k) => k switch
    {
        LabelKey.Title => "Karaktärsstatus",
        LabelKey.Class => "Klass",
        LabelKey.Level => "Nivå",
        LabelKey.HP => "HP",
        LabelKey.Mana => "Mana",
        LabelKey.Stam => "Stam",
        LabelKey.Str => "STY",
        LabelKey.Dex => "SMI",
        LabelKey.Int => "INT",
        LabelKey.Protections => "Skydd",
        LabelKey.MagicalAmps => "Magiska Förstärkare",
        LabelKey.Combat => "Strid",
        LabelKey.Special => "Speciella",
        LabelKey.HideZeros => "Dölj nollor",
        LabelKey.Language => "Språk",
        LabelKey.Refresh => "Uppdatera",
        LabelKey.NextLevel => "Nästa nivå",
        LabelKey.Total => "TOTALT",
        LabelKey.Source => "Källa",
        LabelKey.Type => "Typ",
        LabelKey.Value => "Värde",
        LabelKey.NoSources => "Inga aktiva källor.",
        LabelKey.Close => "Stäng",
        LabelKey.OverheadStyle => "Meddelande",
        LabelKey.MinCap => "Min",
        LabelKey.MaxCap => "Max",
        _ => k.ToString(),
    };

    private static string RuRU(LabelKey k) => k switch
    {
        LabelKey.Title => "Статус Персонажа",
        LabelKey.Class => "Класс",
        LabelKey.Level => "Уровень",
        LabelKey.HP => "ХП",
        LabelKey.Mana => "Мана",
        LabelKey.Stam => "Выносл.",
        LabelKey.Str => "СИЛ",
        LabelKey.Dex => "ЛОВ",
        LabelKey.Int => "ИНТ",
        LabelKey.Protections => "Защиты",
        LabelKey.MagicalAmps => "Магические Усилители",
        LabelKey.Combat => "Бой",
        LabelKey.Special => "Особые",
        LabelKey.HideZeros => "Скрыть нулевые",
        LabelKey.Language => "Язык",
        LabelKey.Refresh => "Обновить",
        LabelKey.NextLevel => "След. уровень",
        LabelKey.Total => "ИТОГО",
        LabelKey.Source => "Источник",
        LabelKey.Type => "Тип",
        LabelKey.Value => "Значение",
        LabelKey.NoSources => "Нет активных источников.",
        LabelKey.Close => "Закрыть",
        LabelKey.OverheadStyle => "Сообщение",
        LabelKey.MinCap => "Мин",
        LabelKey.MaxCap => "Макс",
        _ => k.ToString(),
    };

    private static string ItIT(LabelKey k) => k switch
    {
        LabelKey.Title => "Stato del Personaggio",
        LabelKey.Class => "Classe",
        LabelKey.Level => "Livello",
        LabelKey.HP => "Vita",
        LabelKey.Mana => "Mana",
        LabelKey.Stam => "Res",
        LabelKey.Str => "FOR",
        LabelKey.Dex => "DES",
        LabelKey.Int => "INT",
        LabelKey.Protections => "Protezioni",
        LabelKey.MagicalAmps => "Amplificatori Magici",
        LabelKey.Combat => "Combattimento",
        LabelKey.Special => "Speciali",
        LabelKey.HideZeros => "Nascondi zero",
        LabelKey.Language => "Lingua",
        LabelKey.Refresh => "Aggiorna",
        LabelKey.NextLevel => "Livello successivo",
        LabelKey.Total => "TOTALE",
        LabelKey.Source => "Origine",
        LabelKey.Type => "Tipo",
        LabelKey.Value => "Valore",
        LabelKey.NoSources => "Nessuna fonte attiva.",
        LabelKey.Close => "Chiudi",
        LabelKey.OverheadStyle => "Messaggio",
        LabelKey.MinCap => "Min",
        LabelKey.MaxCap => "Max",
        _ => k.ToString(),
    };
}

public enum LabelKey
{
    Title,
    Class,
    Level,
    HP,
    Mana,
    Stam,
    Str,
    Dex,
    Int,
    Protections,
    MagicalAmps,
    Combat,
    Special,
    HideZeros,
    Language,
    Refresh,
    NextLevel,
    Total,
    Source,
    Type,
    Value,
    NoSources,
    Close,
    OverheadStyle,
    MinCap,
    MaxCap,
}
