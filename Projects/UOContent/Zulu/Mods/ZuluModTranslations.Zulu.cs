using Server;

namespace Server.Zulu.Mods;

public static class ZuluModTranslations
{
    [CallPriority(100)]
    public static void Initialize()
    {
        ApplyEsES();
        ApplySvSE();
        ApplyRuRU();
        ApplyItIT();
    }

    private static void Set(ZuluMod mod, string es = null, string es2 = null,
                            string sv = null, string sv2 = null,
                            string ru = null, string ru2 = null,
                            string it = null, string it2 = null)
    {
        var cfg = ZuluModManager.GetMod(mod);
        if (cfg == null) return;
        if (es != null) cfg.Description_EsES = es;
        if (es2 != null) cfg.Description_EsES_SecondLine = es2;
        if (sv != null) cfg.Description_SvSE = sv;
        if (sv2 != null) cfg.Description_SvSE_SecondLine = sv2;
        if (ru != null) cfg.Description_RuRU = ru;
        if (ru2 != null) cfg.Description_RuRU_SecondLine = ru2;
        if (it != null) cfg.Description_ItIT = it;
        if (it2 != null) cfg.Description_ItIT_SecondLine = it2;
    }

    private static void ApplyEsES()
    {
        Set(ZuluMod.AirProtection, es: "Reduce el daño recibido por ataques de elemento Aire.");
        Set(ZuluMod.NecroProtection, es: "Reduce el daño recibido por ataques de elemento Necro.");
        Set(ZuluMod.FireProtection, es: "Reduce el daño recibido por ataques de elemento Fuego.");
        Set(ZuluMod.WaterProtection, es: "Reduce el daño recibido por ataques de elemento Agua.");
        Set(ZuluMod.PoisonProtection, es: "Reduce el daño recibido por ataques de elemento Veneno.");
        Set(ZuluMod.HollyProtection, es: "Reduce el daño recibido por ataques de elemento Sagrado.");
        Set(ZuluMod.EarthProtection, es: "Reduce el daño recibido por ataques de elemento Tierra.");
        Set(ZuluMod.PhysicalProtection, es: "Reduce el daño recibido por ataques físicos.");
        Set(ZuluMod.SpellAmplifier, es: "Aumenta el daño causado por hechizos.");
        Set(ZuluMod.SpellProtection, es: "Reduce el daño recibido por hechizos.");
        Set(ZuluMod.AirAmplifier, es: "Aumenta el daño causado por hechizos de elemento Aire.");
        Set(ZuluMod.NecroAmplifier, es: "Aumenta el daño causado por hechizos de elemento Necro.");
        Set(ZuluMod.FireAmplifier, es: "Aumenta el daño causado por hechizos de elemento Fuego.");
        Set(ZuluMod.WaterAmplifier, es: "Aumenta el daño causado por hechizos de elemento Agua.");
        Set(ZuluMod.PoisonAmplifier, es: "Aumenta el daño causado por hechizos de elemento Veneno.");
        Set(ZuluMod.HollyAmplifier, es: "Aumenta el daño causado por hechizos de elemento Sagrado.");
        Set(ZuluMod.EarthAmplifier, es: "Aumenta el daño causado por hechizos de elemento Tierra.");
        Set(ZuluMod.PhysicalDamageAmp, es: "Aumenta el daño físico causado por los ataques.");
        Set(ZuluMod.FixedPhysicalDamageAmp, es: "Añade un valor fijo al daño físico causado por los ataques.");
        Set(ZuluMod.CleaveDamage,
            es: "Aumenta el daño causado por ataques en área.",
            es2: "Solo se aplica al usar Bardiche o Halberd.");
        Set(ZuluMod.Lifesteal, es: "Restaura la vida del atacante según el daño causado.");
        Set(ZuluMod.Manaleech, es: "Restaura el maná del atacante según el daño causado.");
        Set(ZuluMod.FreeAction, es: "Protección contra Freeze.");
        Set(ZuluMod.Evasion, es: "Aumenta la probabilidad de esquivar ataques.");
        Set(ZuluMod.ManaDrain, es: "Drena el maná del objetivo según el daño causado.");
        Set(ZuluMod.AttackSpeed, es: "Aumenta la velocidad de ataque.");
        Set(ZuluMod.CastSpeed, es: "Aumenta la velocidad de lanzamiento de hechizos.");
        Set(ZuluMod.Accurracy, es: "Aumenta la precisión de los ataques.");
        Set(ZuluMod.SpellCriticalChance, es: "Aumenta la probabilidad de crítico de los hechizos.");
        Set(ZuluMod.SpellCriticalDamage, es: "Aumenta el daño crítico de los hechizos.");
        Set(ZuluMod.CriticalChance,
            es: "Aumenta la probabilidad de crítico de los ataques físicos.",
            es2: "Solo se aplica a ataques cuerpo a cuerpo con Espadas.");
        Set(ZuluMod.CriticalDamage, es: "Aumenta el daño crítico de los ataques físicos.");
        Set(ZuluMod.BleedChance, es: "Aumenta la probabilidad de causar sangrado en el objetivo.");
        Set(ZuluMod.DisturbChance, es: "Aumenta la probabilidad de interrumpir las acciones del objetivo.");
        Set(ZuluMod.StunChance, es: "Aumenta la probabilidad de aturdir al objetivo.");
        Set(ZuluMod.SillenceChance, es: "Aumenta la probabilidad de silenciar al objetivo.");
        Set(ZuluMod.PhysicalDamageReflection,
            es: "Refleja un porcentaje del daño físico recibido al atacante.",
            es2: "Solo al usar escudos.");
        Set(ZuluMod.SpellDamageReflection,
            es: "Refleja un porcentaje del daño mágico recibido al atacante.",
            es2: "No funciona para la clase Warrior.");
        Set(ZuluMod.HealingBonus, es: "Aumenta la cantidad de curación recibida.");
        Set(ZuluMod.ParryngChance, es: "Aumenta la probabilidad de parar ataques cuerpo a cuerpo con Escudo.");
        Set(ZuluMod.ArcheryDamageAmp, es: "Aumenta el daño causado por ataques a distancia con Arcos.");
        Set(ZuluMod.MeditationRegenAmplifier, es: "Aumenta la regeneración de maná durante la meditación.");
    }

    private static void ApplySvSE()
    {
        Set(ZuluMod.AirProtection, sv: "Minskar skadan från Luft-attacker.");
        Set(ZuluMod.NecroProtection, sv: "Minskar skadan från Nekro-attacker.");
        Set(ZuluMod.FireProtection, sv: "Minskar skadan från Eld-attacker.");
        Set(ZuluMod.WaterProtection, sv: "Minskar skadan från Vatten-attacker.");
        Set(ZuluMod.PoisonProtection, sv: "Minskar skadan från Gift-attacker.");
        Set(ZuluMod.HollyProtection, sv: "Minskar skadan från Heliga attacker.");
        Set(ZuluMod.EarthProtection, sv: "Minskar skadan från Jord-attacker.");
        Set(ZuluMod.PhysicalProtection, sv: "Minskar skadan från fysiska attacker.");
        Set(ZuluMod.SpellAmplifier, sv: "Ökar skadan som orsakas av besvärjelser.");
        Set(ZuluMod.SpellProtection, sv: "Minskar skadan från besvärjelser.");
        Set(ZuluMod.AirAmplifier, sv: "Ökar skadan av Luft-besvärjelser.");
        Set(ZuluMod.NecroAmplifier, sv: "Ökar skadan av Nekro-besvärjelser.");
        Set(ZuluMod.FireAmplifier, sv: "Ökar skadan av Eld-besvärjelser.");
        Set(ZuluMod.WaterAmplifier, sv: "Ökar skadan av Vatten-besvärjelser.");
        Set(ZuluMod.PoisonAmplifier, sv: "Ökar skadan av Gift-besvärjelser.");
        Set(ZuluMod.HollyAmplifier, sv: "Ökar skadan av Heliga besvärjelser.");
        Set(ZuluMod.EarthAmplifier, sv: "Ökar skadan av Jord-besvärjelser.");
        Set(ZuluMod.PhysicalDamageAmp, sv: "Ökar den fysiska skadan av attacker.");
        Set(ZuluMod.FixedPhysicalDamageAmp, sv: "Lägger till ett fast värde till fysisk skada.");
        Set(ZuluMod.CleaveDamage,
            sv: "Ökar skadan av områdesattacker.",
            sv2: "Gäller endast med Bardiche eller Halberd.");
        Set(ZuluMod.Lifesteal, sv: "Återställer angriparens liv baserat på orsakad skada.");
        Set(ZuluMod.Manaleech, sv: "Återställer angriparens mana baserat på orsakad skada.");
        Set(ZuluMod.FreeAction, sv: "Skydd mot Freeze.");
        Set(ZuluMod.Evasion, sv: "Ökar chansen att undvika attacker.");
        Set(ZuluMod.ManaDrain, sv: "Dränerar målets mana baserat på orsakad skada.");
        Set(ZuluMod.AttackSpeed, sv: "Ökar attackhastigheten.");
        Set(ZuluMod.CastSpeed, sv: "Ökar besvärjelsens kastningshastighet.");
        Set(ZuluMod.Accurracy, sv: "Ökar attackprecisionen.");
        Set(ZuluMod.SpellCriticalChance, sv: "Ökar chansen till kritisk träff för besvärjelser.");
        Set(ZuluMod.SpellCriticalDamage, sv: "Ökar kritisk skada för besvärjelser.");
        Set(ZuluMod.CriticalChance,
            sv: "Ökar chansen till kritisk träff för fysiska attacker.",
            sv2: "Endast närstridsattacker med Svärd.");
        Set(ZuluMod.CriticalDamage, sv: "Ökar kritisk skada för fysiska attacker.");
        Set(ZuluMod.BleedChance, sv: "Ökar chansen att orsaka blödning.");
        Set(ZuluMod.DisturbChance, sv: "Ökar chansen att avbryta målets handlingar.");
        Set(ZuluMod.StunChance, sv: "Ökar chansen att bedöva målet.");
        Set(ZuluMod.SillenceChance, sv: "Ökar chansen att tysta målet.");
        Set(ZuluMod.PhysicalDamageReflection,
            sv: "Reflekterar en procent av mottagen fysisk skada tillbaka.",
            sv2: "Endast med sköldar.");
        Set(ZuluMod.SpellDamageReflection,
            sv: "Reflekterar en procent av mottagen besvärjelseskada tillbaka.",
            sv2: "Fungerar inte för Warrior-klassen.");
        Set(ZuluMod.HealingBonus, sv: "Ökar mängden läkning som mottas.");
        Set(ZuluMod.ParryngChance, sv: "Ökar chansen att parera närstridsattacker med Sköld.");
        Set(ZuluMod.ArcheryDamageAmp, sv: "Ökar skadan av distansattacker med Pilbågar.");
        Set(ZuluMod.MeditationRegenAmplifier, sv: "Ökar mana-regenereringen under meditation.");
    }

    private static void ApplyRuRU()
    {
        Set(ZuluMod.AirProtection, ru: "Уменьшает получаемый урон от атак элемента Воздуха.");
        Set(ZuluMod.NecroProtection, ru: "Уменьшает получаемый урон от атак элемента Некро.");
        Set(ZuluMod.FireProtection, ru: "Уменьшает получаемый урон от атак элемента Огня.");
        Set(ZuluMod.WaterProtection, ru: "Уменьшает получаемый урон от атак элемента Воды.");
        Set(ZuluMod.PoisonProtection, ru: "Уменьшает получаемый урон от атак элемента Яда.");
        Set(ZuluMod.HollyProtection, ru: "Уменьшает получаемый урон от Святых атак.");
        Set(ZuluMod.EarthProtection, ru: "Уменьшает получаемый урон от атак элемента Земли.");
        Set(ZuluMod.PhysicalProtection, ru: "Уменьшает получаемый физический урон.");
        Set(ZuluMod.SpellAmplifier, ru: "Увеличивает урон от заклинаний.");
        Set(ZuluMod.SpellProtection, ru: "Уменьшает получаемый урон от заклинаний.");
        Set(ZuluMod.AirAmplifier, ru: "Увеличивает урон заклинаний Воздуха.");
        Set(ZuluMod.NecroAmplifier, ru: "Увеличивает урон заклинаний Некро.");
        Set(ZuluMod.FireAmplifier, ru: "Увеличивает урон заклинаний Огня.");
        Set(ZuluMod.WaterAmplifier, ru: "Увеличивает урон заклинаний Воды.");
        Set(ZuluMod.PoisonAmplifier, ru: "Увеличивает урон заклинаний Яда.");
        Set(ZuluMod.HollyAmplifier, ru: "Увеличивает урон Святых заклинаний.");
        Set(ZuluMod.EarthAmplifier, ru: "Увеличивает урон заклинаний Земли.");
        Set(ZuluMod.PhysicalDamageAmp, ru: "Увеличивает физический урон от атак.");
        Set(ZuluMod.FixedPhysicalDamageAmp, ru: "Добавляет фиксированное значение к физическому урону.");
        Set(ZuluMod.CleaveDamage,
            ru: "Увеличивает урон от атак по области.",
            ru2: "Только при использовании Бардиша или Алебарды.");
        Set(ZuluMod.Lifesteal, ru: "Восстанавливает здоровье атакующего на основе урона.");
        Set(ZuluMod.Manaleech, ru: "Восстанавливает ману атакующего на основе урона.");
        Set(ZuluMod.FreeAction, ru: "Защита от заморозки.");
        Set(ZuluMod.Evasion, ru: "Увеличивает шанс уклониться от атак.");
        Set(ZuluMod.ManaDrain, ru: "Истощает ману цели на основе урона.");
        Set(ZuluMod.AttackSpeed, ru: "Увеличивает скорость атаки.");
        Set(ZuluMod.CastSpeed, ru: "Увеличивает скорость сотворения заклинаний.");
        Set(ZuluMod.Accurracy, ru: "Увеличивает точность атак.");
        Set(ZuluMod.SpellCriticalChance, ru: "Увеличивает шанс критического удара заклинаний.");
        Set(ZuluMod.SpellCriticalDamage, ru: "Увеличивает критический урон заклинаний.");
        Set(ZuluMod.CriticalChance,
            ru: "Увеличивает шанс критического удара физических атак.",
            ru2: "Только для ближнего боя Мечами.");
        Set(ZuluMod.CriticalDamage, ru: "Увеличивает критический урон физических атак.");
        Set(ZuluMod.BleedChance, ru: "Увеличивает шанс вызвать кровотечение у цели.");
        Set(ZuluMod.DisturbChance, ru: "Увеличивает шанс прервать действия цели.");
        Set(ZuluMod.StunChance, ru: "Увеличивает шанс оглушить цель.");
        Set(ZuluMod.SillenceChance, ru: "Увеличивает шанс наложить молчание.");
        Set(ZuluMod.PhysicalDamageReflection,
            ru: "Отражает процент получаемого физического урона.",
            ru2: "Только при использовании щита.");
        Set(ZuluMod.SpellDamageReflection,
            ru: "Отражает процент получаемого магического урона.",
            ru2: "Не работает для класса Warrior.");
        Set(ZuluMod.HealingBonus, ru: "Увеличивает количество получаемого лечения.");
        Set(ZuluMod.ParryngChance, ru: "Увеличивает шанс парировать атаки ближнего боя со щитом.");
        Set(ZuluMod.ArcheryDamageAmp, ru: "Увеличивает урон стрельбы из Лука.");
        Set(ZuluMod.MeditationRegenAmplifier, ru: "Увеличивает регенерацию маны во время медитации.");
    }

    private static void ApplyItIT()
    {
        Set(ZuluMod.AirProtection, it: "Riduce il danno subito da attacchi di Aria.");
        Set(ZuluMod.NecroProtection, it: "Riduce il danno subito da attacchi Necro.");
        Set(ZuluMod.FireProtection, it: "Riduce il danno subito da attacchi di Fuoco.");
        Set(ZuluMod.WaterProtection, it: "Riduce il danno subito da attacchi di Acqua.");
        Set(ZuluMod.PoisonProtection, it: "Riduce il danno subito da attacchi di Veleno.");
        Set(ZuluMod.HollyProtection, it: "Riduce il danno subito da attacchi Sacri.");
        Set(ZuluMod.EarthProtection, it: "Riduce il danno subito da attacchi di Terra.");
        Set(ZuluMod.PhysicalProtection, it: "Riduce il danno subito da attacchi fisici.");
        Set(ZuluMod.SpellAmplifier, it: "Aumenta il danno causato dagli incantesimi.");
        Set(ZuluMod.SpellProtection, it: "Riduce il danno subito dagli incantesimi.");
        Set(ZuluMod.AirAmplifier, it: "Aumenta il danno degli incantesimi di Aria.");
        Set(ZuluMod.NecroAmplifier, it: "Aumenta il danno degli incantesimi Necro.");
        Set(ZuluMod.FireAmplifier, it: "Aumenta il danno degli incantesimi di Fuoco.");
        Set(ZuluMod.WaterAmplifier, it: "Aumenta il danno degli incantesimi di Acqua.");
        Set(ZuluMod.PoisonAmplifier, it: "Aumenta il danno degli incantesimi di Veleno.");
        Set(ZuluMod.HollyAmplifier, it: "Aumenta il danno degli incantesimi Sacri.");
        Set(ZuluMod.EarthAmplifier, it: "Aumenta il danno degli incantesimi di Terra.");
        Set(ZuluMod.PhysicalDamageAmp, it: "Aumenta il danno fisico causato dagli attacchi.");
        Set(ZuluMod.FixedPhysicalDamageAmp, it: "Aggiunge un valore fisso al danno fisico.");
        Set(ZuluMod.CleaveDamage,
            it: "Aumenta il danno degli attacchi ad area.",
            it2: "Si applica solo usando Bardiche o Halberd.");
        Set(ZuluMod.Lifesteal, it: "Ripristina la vita dell'attaccante in base al danno inflitto.");
        Set(ZuluMod.Manaleech, it: "Ripristina il mana dell'attaccante in base al danno inflitto.");
        Set(ZuluMod.FreeAction, it: "Protezione contro Freeze.");
        Set(ZuluMod.Evasion, it: "Aumenta la probabilità di schivare gli attacchi.");
        Set(ZuluMod.ManaDrain, it: "Drena il mana del bersaglio in base al danno inflitto.");
        Set(ZuluMod.AttackSpeed, it: "Aumenta la velocità di attacco.");
        Set(ZuluMod.CastSpeed, it: "Aumenta la velocità di lancio degli incantesimi.");
        Set(ZuluMod.Accurracy, it: "Aumenta la precisione degli attacchi.");
        Set(ZuluMod.SpellCriticalChance, it: "Aumenta la probabilità di colpo critico degli incantesimi.");
        Set(ZuluMod.SpellCriticalDamage, it: "Aumenta il danno critico degli incantesimi.");
        Set(ZuluMod.CriticalChance,
            it: "Aumenta la probabilità di colpo critico degli attacchi fisici.",
            it2: "Si applica solo ad attacchi in mischia con Spade.");
        Set(ZuluMod.CriticalDamage, it: "Aumenta il danno critico degli attacchi fisici.");
        Set(ZuluMod.BleedChance, it: "Aumenta la probabilità di causare sanguinamento sul bersaglio.");
        Set(ZuluMod.DisturbChance, it: "Aumenta la probabilità di interrompere le azioni del bersaglio.");
        Set(ZuluMod.StunChance, it: "Aumenta la probabilità di stordire il bersaglio.");
        Set(ZuluMod.SillenceChance, it: "Aumenta la probabilità di silenziare il bersaglio.");
        Set(ZuluMod.PhysicalDamageReflection,
            it: "Riflette una percentuale del danno fisico subito all'attaccante.",
            it2: "Solo con l'uso di scudi.");
        Set(ZuluMod.SpellDamageReflection,
            it: "Riflette una percentuale del danno magico subito all'attaccante.",
            it2: "Non funziona per la classe Warrior.");
        Set(ZuluMod.HealingBonus, it: "Aumenta la quantità di cura ricevuta.");
        Set(ZuluMod.ParryngChance, it: "Aumenta la probabilità di parare attacchi in mischia con Scudo.");
        Set(ZuluMod.ArcheryDamageAmp, it: "Aumenta il danno degli attacchi a distanza con Archi.");
        Set(ZuluMod.MeditationRegenAmplifier, it: "Aumenta la rigenerazione del mana durante la meditazione.");
    }
}
