using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace Server;

public enum ZuluMod
{
    None,
    AirProtection,
    NecroProtection,
    FireProtection,
    WaterProtection,
    PoisonProtection,
    HollyProtection,
    EarthProtection,
    PhysicalProtection,
    SpellAmplifier,
    SpellProtection,
    AirAmplifier,
    NecroAmplifier,
    FireAmplifier,
    WaterAmplifier,
    PoisonAmplifier,
    HollyAmplifier,
    EarthAmplifier,
    PhysicalDamageAmp,
    CleaveDamage,
    Lifesteal,
    Manaleech,
    FreeAction,
    Evasion,
    ManaDrain,
    AttackSpeed,
    CastSpeed,
    Accurracy,
    SpellCriticalChance,
    SpellCriticalDamage,
    CriticalChance,
    CriticalDamage,
    BleedChance,
    DisturbChance,
    StunChance,
    SillenceChance,
    PhysicalDamageReflection,
    SpellDamageReflection,
    HealingBonus,
    ParryngChance,
    ArcheryDamageAmp,
    MeditationRegenAmplifier,
    FixedPhysicalDamageAmp,
    MacingProtection,
    SwordsProtection,
    FencingProtection,
    WrestlingProtection,
    RangedProtection,


}

public enum ZuluElement
{
    Air,
    Necro,
    Fire,
    Water,
    Poison,
    Holly,
    Earth,
 }

public enum ZuluModCalcType
{
    None,
    Percent,
    Fixed,
}

public enum ZuluItemRarity
{
    Common,
    Uncomon,
    Rare,
    VeryRare,
    Epic,
    Mytic,
    Legendary
}

public static class ZuluModManager
{
    private static int SpecialModHue = 42; // Example hue for special mods, adjust as needed (Orange)
    private static int CriticalModHue = 1495; // Yellow.

    private static ZuluModConfigs[] _modConfigs;
    private static ZuluElementConfigs[] _elementConfigs;

    public static void Initialize()
    {
        _elementConfigs = new ZuluElementConfigs[Enum.GetValues<ZuluElement>().Length];
        _elementConfigs[(int)ZuluElement.Air] = new ZuluElementConfigs { Name = "Air", Hue = 1050 };
        _elementConfigs[(int)ZuluElement.Necro] = new ZuluElementConfigs { Name = "Necro", Hue = 1645 };
        _elementConfigs[(int)ZuluElement.Fire] = new ZuluElementConfigs { Name = "Fire", Hue = 1158 };
        _elementConfigs[(int)ZuluElement.Water] = new ZuluElementConfigs { Name = "Water", Hue = 102 };
        _elementConfigs[(int)ZuluElement.Poison] = new ZuluElementConfigs { Name = "Poison", Hue = 1162 };
        _elementConfigs[(int)ZuluElement.Holly] = new ZuluElementConfigs { Name = "Holly", Hue = 1156 };
        _elementConfigs[(int)ZuluElement.Earth] = new ZuluElementConfigs { Name = "Earth", Hue = 1538 };

        _modConfigs = new ZuluModConfigs[Enum.GetValues<ZuluMod>().Length];

        #region Elemenal Protections
        _modConfigs[(int)ZuluMod.AirProtection] = new ZuluModConfigs
        {
            Name = "Air Protection",
            MinCap = -1000,
            MaxCap = 100,
            Description_PtBR = "Reduz o dano recebido de ataques do elemento Ar.",
            Description_EnUS = "Reduces damage taken from Air element attacks.",
            OverheadStyle = "Air",
            CalculateType = ZuluModCalcType.Percent,
            Hue = _elementConfigs[(int)ZuluElement.Air].Hue,
        };

        _modConfigs[(int)ZuluMod.NecroProtection] = new ZuluModConfigs
        {
            Name = "Necro Protection",
            MinCap = -1000,
            MaxCap = 100,
            Description_PtBR = "Reduz o dano recebido de ataques do elemento Necro.",
            Description_EnUS = "Reduces damage taken from Necro element attacks.",
            OverheadStyle = "Necro",
            CalculateType = ZuluModCalcType.Percent,
            Hue = _elementConfigs[(int)ZuluElement.Necro].Hue
        };

        _modConfigs[(int)ZuluMod.FireProtection] = new ZuluModConfigs
        {
            Name = "Fire Protection",
            MinCap = -1000,
            MaxCap = 100,
            Description_PtBR = "Reduz o dano recebido de ataques do elemento Fogo.",
            Description_EnUS = "Reduces damage taken from Fire element attacks.",
            OverheadStyle = "Fire",
            CalculateType = ZuluModCalcType.Percent,
            Hue = _elementConfigs[(int)ZuluElement.Fire].Hue
        };

        _modConfigs[(int)ZuluMod.WaterProtection] = new ZuluModConfigs
        {
            Name = "Water Protection",
            MinCap = -1000,
            MaxCap = 100,
            Description_PtBR = "Reduz o dano recebido de ataques do elemento Água.",
            Description_EnUS = "Reduces damage taken from Water element attacks.",
            OverheadStyle = "Water",
            CalculateType = ZuluModCalcType.Percent,
            Hue = _elementConfigs[(int)ZuluElement.Water].Hue
        };

        _modConfigs[(int)ZuluMod.PoisonProtection] = new ZuluModConfigs
        {
            Name = "Poison Protection",
            MinCap = -1000,
            MaxCap = 100,
            Description_PtBR = "Reduz o dano recebido de ataques do elemento Veneno.",
            Description_EnUS = "Reduces damage taken from Poison element attacks.",
            OverheadStyle = "Poison",
            CalculateType = ZuluModCalcType.Percent,
            Hue = _elementConfigs[(int)ZuluElement.Poison].Hue
        };

        _modConfigs[(int)ZuluMod.HollyProtection] = new ZuluModConfigs
        {
            Name = "Holly Protection",
            MinCap = -1000,
            MaxCap = 100,
            Description_PtBR = "Reduz o dano recebido de ataques do elemento Sagrado.",
            Description_EnUS = "Reduces damage taken from Holly element attacks.",
            OverheadStyle = "Holly",
            CalculateType = ZuluModCalcType.Percent,
            Hue = _elementConfigs[(int)ZuluElement.Holly].Hue
        };

        _modConfigs[(int)ZuluMod.EarthProtection] = new ZuluModConfigs
        {
            Name = "Earth Protection",
            MinCap = -1000,
            MaxCap = 100,
            Description_PtBR = "Reduz o dano recebido de ataques do elemento Terra.",
            Description_EnUS = "Reduces damage taken from Earth element attacks.",
            OverheadStyle = "Earth",
            CalculateType = ZuluModCalcType.Percent,
            Hue = _elementConfigs[(int)ZuluElement.Earth].Hue
        };

        #endregion

        #region Elemental Amplifiers
        _modConfigs[(int)ZuluMod.AirAmplifier] = new ZuluModConfigs
        {
            Name = "Air Amplifier",
            MinCap = -1000,
            MaxCap = 100,
            Description_PtBR = "Aumenta o dano causado por feitiços do elemento Ar.",
            Description_EnUS = "Increases damage dealt by Air element spells.",
            OverheadStyle = "AirAmp",
            CalculateType = ZuluModCalcType.Percent,
            Hue = _elementConfigs[(int)ZuluElement.Air].Hue
        };

        _modConfigs[(int)ZuluMod.NecroAmplifier] = new ZuluModConfigs
        {
            Name = "Necro Amplifier",
            MinCap = -1000,
            MaxCap = 100,
            Description_PtBR = "Aumenta o dano causado por feitiços do elemento Necro.",
            Description_EnUS = "Increases damage dealt by Necro element spells.",
            OverheadStyle = "NecroAmp",
            CalculateType = ZuluModCalcType.Percent,
            Hue = _elementConfigs[(int)ZuluElement.Necro].Hue
        };

        _modConfigs[(int)ZuluMod.FireAmplifier] = new ZuluModConfigs
        {
            Name = "Fire Amplifier",
            MinCap = -1000,
            MaxCap = 100,
            Description_PtBR = "Aumenta o dano causado por feitiços do elemento Fogo.",
            Description_EnUS = "Increases damage dealt by Fire element spells.",
            OverheadStyle = "FireAmp",
            CalculateType = ZuluModCalcType.Percent,
            Hue = _elementConfigs[(int)ZuluElement.Fire].Hue
        };

        _modConfigs[(int)ZuluMod.WaterAmplifier] = new ZuluModConfigs
        {
            Name = "Water Amplifier",
            MinCap = -1000,
            MaxCap = 100,
            Description_PtBR = "Aumenta o dano causado por feitiços do elemento Água.",
            Description_EnUS = "Increases damage dealt by Water element spells.",
            OverheadStyle = "WaterAmp",
            CalculateType = ZuluModCalcType.Percent,
            Hue = _elementConfigs[(int)ZuluElement.Water].Hue
        };

        _modConfigs[(int)ZuluMod.PoisonAmplifier] = new ZuluModConfigs
        {
            Name = "Poison Amplifier",
            MinCap = -1000,
            MaxCap = 100,
            Description_PtBR = "Aumenta o dano causado por feitiços do elemento Veneno.",
            Description_EnUS = "Increases damage dealt by Poison element spells.",
            OverheadStyle = "PoisonAmp",
            CalculateType = ZuluModCalcType.Percent,
            Hue = _elementConfigs[(int)ZuluElement.Poison].Hue
        };

        _modConfigs[(int)ZuluMod.HollyAmplifier] = new ZuluModConfigs
        {
            Name = "Holly Amplifier",
            MinCap = -1000,
            MaxCap = 100,
            Description_PtBR = "Aumenta o dano causado por feitiços do elemento Sagrado.",
            Description_EnUS = "Increases damage dealt by Holly element spells.",
            OverheadStyle = "HollyAmp",
            CalculateType = ZuluModCalcType.Percent,
            Hue = _elementConfigs[(int)ZuluElement.Holly].Hue
        };

        _modConfigs[(int)ZuluMod.EarthAmplifier] = new ZuluModConfigs
        {
            Name = "Earth Amplifier",
            MinCap = -1000,
            MaxCap = 100,
            Description_PtBR = "Aumenta o dano causado por feitiços do elemento Terra.",
            Description_EnUS = "Increases damage dealt by Earth element spells.",
            OverheadStyle = "EarthAmp",
            CalculateType = ZuluModCalcType.Percent,
            Hue = _elementConfigs[(int)ZuluElement.Earth].Hue
        };
        #endregion

        #region Combat Modifiers

        _modConfigs[(int)ZuluMod.PhysicalProtection] = new ZuluModConfigs
        {
            Name = "Physical Protection",
            MinCap = -1000,
            MaxCap = 75,
            Description_PtBR = "Reduz o dano recebido de ataques físicos.",
            Description_EnUS = "Reduces damage taken from physical attacks.",
            OverheadStyle = "Physical Protection",
            CalculateType = ZuluModCalcType.Percent,
            Hue = 0 // Define a hue for physical protection if needed
        };

        _modConfigs[(int)ZuluMod.SpellAmplifier] = new ZuluModConfigs
        {
            Name = "Spell Amplifier",
            MinCap = -1000,
            MaxCap = 100,
            Description_PtBR = "Aumenta o dano causado por feitiços.",
            Description_EnUS = "Increases damage dealt by spells.",
            OverheadStyle = "SpellAmp",
            CalculateType = ZuluModCalcType.Percent,
            Hue = 12 // Purple
        };

        _modConfigs[(int)ZuluMod.SpellProtection] = new ZuluModConfigs
        {
            Name = "Spell Protection",
            MinCap = -1000,
            MaxCap = 75,
            Description_PtBR = "Reduz o dano recebido de feitiços.",
            Description_EnUS = "Reduces damage taken from spells.",
            OverheadStyle = "SpellProt",
            CalculateType = ZuluModCalcType.Percent,
            Hue = 12 // Define a hue for spell protection if needed
        };

        _modConfigs[(int)ZuluMod.PhysicalDamageAmp] = new ZuluModConfigs
        {
            Name = "Physical Damage Amplifier",
            MinCap = -1000,
            MaxCap = 9999,
            Description_PtBR = "Aumenta o dano físico causado por ataques.",
            Description_EnUS = "Increases physical damage dealt by attacks.",
            OverheadStyle = "{0}",
            CalculateType = ZuluModCalcType.Fixed,
            Hue = 32 // Red
        };

        _modConfigs[(int)ZuluMod.FixedPhysicalDamageAmp] = new ZuluModConfigs
        {
            Name = "Physical Damage Amplifier",
            MinCap = -1000,
            MaxCap = 100,
            Description_PtBR = "Adiciona valor fixo ao dano físico causado por ataques.",
            Description_EnUS = "Adds a fixed value to the physical damage dealt by attacks.",
            OverheadStyle = "PhysicalDamageAmp",
            CalculateType = ZuluModCalcType.Fixed,
            Hue = 934 // Silver
        };

        _modConfigs[(int)ZuluMod.CleaveDamage] = new ZuluModConfigs
        {
            Name = "Cleave Damage",
            MinCap = -1000,
            MaxCap = 100,
            Description_PtBR = "Aumenta o dano causado por ataques em área.",
            Description_PtBR_SecondLine = "Aplica-se apenas usando Bardiche ou Halberd",
            Description_EnUS = "Increases damage dealt by area attacks. /n Only using Bardiche or Halberd",
            Description_EnUS_SecondLine = "Only applies when using Bardiche or Halberd.",
            OverheadStyle = "CleaveDamage",
            CalculateType = ZuluModCalcType.Percent,
            Hue = SpecialModHue,
            EffectRange = 3
        };

        _modConfigs [(int)ZuluMod.Lifesteal] = new ZuluModConfigs
        {
            Name = "Lifesteal",
            MinCap = -1000,
            MaxCap = 100,
            Description_PtBR = "Restaura a vida do atacante com base no dano causado.",
            Description_EnUS = "Restores the attacker's health based on damage dealt.",
            OverheadStyle = "[Lifesteal +{0}]",
            CalculateType = ZuluModCalcType.Percent,
            Hue = SpecialModHue // Define a hue for lifesteal if needed
        };

        _modConfigs[(int)ZuluMod.Manaleech] = new ZuluModConfigs
        {
            Name = "Mana Leech",
            MinCap = -1000,
            MaxCap = 100,
            Description_PtBR = "Restaura a mana do atacante com base no dano causado.",
            Description_EnUS = "Restores the attacker's mana based on damage dealt.",
            OverheadStyle = "ManaLeech",
            CalculateType = ZuluModCalcType.Percent,
            Hue = SpecialModHue // Define a hue for mana leech if needed
        };

        _modConfigs[(int)ZuluMod.FreeAction] = new ZuluModConfigs
        {
            Name = "Free Action",
            MinCap = 0,
            MaxCap = 0,
            Description_PtBR = "Proteção contra Freeze.",
            Description_EnUS = "Protection from Freeze.",
            OverheadStyle = "FreeAction",
            CalculateType = ZuluModCalcType.None,
            Hue = SpecialModHue // Define a hue for free action if needed
        };

        _modConfigs[(int)ZuluMod.Evasion] = new ZuluModConfigs
        {
            Name = "Evasion",
            MinCap = 0,
            MaxCap = 35,
            Description_PtBR = "Aumenta a chance de esquivar de ataques.",
            Description_EnUS = "Increases the chance to evade attacks.",
            OverheadStyle = "[Evaded]",
            CalculateType = ZuluModCalcType.Percent,
            Hue = 1482 // Define a hue for evasion if needed
        };

        _modConfigs[(int)ZuluMod.ManaDrain] = new ZuluModConfigs
        {
            Name = "Mana Drain",
            MinCap = 0,
            MaxCap = 35,
            Description_PtBR = "Drena a mana do alvo com base no dano causado.",
            Description_EnUS = "Drains the target's mana based on damage dealt.",
            OverheadStyle = "ManaDrain",
            CalculateType = ZuluModCalcType.Percent,
            Hue = 1479 // Define a hue for mana drain if needed
        };

        _modConfigs[(int)ZuluMod.AttackSpeed] = new ZuluModConfigs
        {
            Name = "Attack Speed",
            MinCap = -1000,
            MaxCap = 100,
            Description_PtBR = "Aumenta a velocidade de ataque.",
            Description_EnUS = "Increases attack speed.",
            OverheadStyle = "AttackSpeed",
            CalculateType = ZuluModCalcType.Percent,
            Hue = 0 // Define a hue for attack speed if needed
        };

        _modConfigs[(int)ZuluMod.CastSpeed] = new ZuluModConfigs
        {
            Name = "Cast Speed",
            MinCap = -1000,
            MaxCap = 100,
            Description_PtBR = "Aumenta a velocidade de lançamento de feitiços.",
            Description_EnUS = "Increases spell casting speed.",
            OverheadStyle = "CastSpeed",
            CalculateType = ZuluModCalcType.Percent,
            Hue = 0 // Define a hue for cast speed if needed
        };

        _modConfigs [(int)ZuluMod.Accurracy] = new ZuluModConfigs
        {
            Name = "Accuracy",
            MinCap = -100,
            MaxCap = 100,
            Description_PtBR = "Aumenta a precisão dos ataques.",
            Description_EnUS = "Increases attack accuracy.",
            OverheadStyle = "Accuracy",
            CalculateType = ZuluModCalcType.Percent,
            Hue = SpecialModHue // Define a hue for accuracy if needed
        };

        _modConfigs [(int)ZuluMod.SpellCriticalChance] = new ZuluModConfigs
        {
            Name = "Spell Critical Chance",
            MinCap = 0,
            MaxCap = 35,
            Description_PtBR = "Aumenta a chance de acerto crítico de feitiços.",
            Description_EnUS = "Increases the critical hit chance of spells.",
            OverheadStyle = "SpellCritChance",
            CalculateType = ZuluModCalcType.Percent,
            Hue = CriticalModHue // Define a hue for spell critical chance if needed
        };
         _modConfigs[(int)ZuluMod.SpellCriticalDamage] = new ZuluModConfigs
        {
            Name = "Spell Critical Damage",
            MinCap = 0,
            MaxCap = 300,
            Description_PtBR = "Aumenta o dano causado por acertos críticos de feitiços.",
            Description_EnUS = "Increases damage dealt by critical hits of spells.",
            OverheadStyle = "SpellCritDamage",
            CalculateType = ZuluModCalcType.Percent,
            Hue = CriticalModHue // Define a hue for spell critical damage if needed
         };
         _modConfigs[(int)ZuluMod.CriticalChance] = new ZuluModConfigs
        {
            Name = "Physical Critical Chance",
            MinCap = 0,
            MaxCap = 35,
            Description_PtBR = "Aumenta a chance de acerto crítico de ataques físicos.",
            Description_PtBR_SecondLine = "Aplica-se apenas a ataques corpo a corpo, usando Espadas.",
            Description_EnUS_SecondLine = "Only applies to melee attacks, using Swords.",
            Description_EnUS = "Increases the critical hit chance of physical attacks.",
            OverheadStyle = "CritChance",
            CalculateType = ZuluModCalcType.Percent,
            Hue = CriticalModHue // Define a hue for critical chance if needed
         };
         _modConfigs[(int)ZuluMod.CriticalDamage] = new ZuluModConfigs
        {
            Name = "Critical Damage",
            MinCap = 0,
            MaxCap = 300,
            Description_PtBR = "Aumenta o dano causado por acertos críticos de ataques físicos.",
            Description_EnUS = "Increases damage dealt by critical hits of physical attacks.",
            OverheadStyle = "CritDamage",
            CalculateType = ZuluModCalcType.Percent,
            Hue = CriticalModHue // Define a hue for critical damage if needed
         };

        _modConfigs[(int)ZuluMod.BleedChance] = new ZuluModConfigs
        {
            Name = "Bleed Chance",
            MinCap = 0,
            MaxCap = 35,
            Description_PtBR = "Aumenta a chance de causar sangramento no alvo.",
            Description_EnUS = "Increases the chance to cause bleeding on the target.",
            OverheadStyle = "Bleeding",
            CalculateType = ZuluModCalcType.Percent,
            Hue = SpecialModHue, // Define a hue for bleed chance if neede
            SecondsPeriod = 3
        };
         _modConfigs[(int)ZuluMod.DisturbChance] = new ZuluModConfigs
        {
            Name = "Disturb Chance",
            MinCap = 0,
            MaxCap = 35,
            Description_PtBR = "Aumenta a chance de causar perturbação no alvo, interrompendo suas ações.",
            Description_EnUS = "Increases the chance to cause disturbance on the target, interrupting their actions.",
            OverheadStyle = "DisturbChance",
            CalculateType = ZuluModCalcType.Percent,
            Hue = SpecialModHue // Define a hue for disturb chance if needed
        };
         _modConfigs[(int)ZuluMod.StunChance] = new ZuluModConfigs
        {
            Name = "Stun Chance",
            MinCap = 0,
            MaxCap = 100,
            Description_PtBR = "Aumenta a chance de atordoar o alvo, impedindo-o de agir por um curto período.",
            Description_EnUS = "Increases the chance to stun the target, preventing them from acting for a short period.",
            OverheadStyle = "StunChance",
            CalculateType = ZuluModCalcType.Percent,
            Hue = SpecialModHue, // Define a hue for stun chance if needed
            SecondsPeriod = 1,
            
        };

        _modConfigs[(int)ZuluMod.SillenceChance] = new ZuluModConfigs
        {
            Name = "Silence Chance",
            MinCap = 0,
            MaxCap = 35,
            Description_PtBR = "Aumenta a chance de silenciar o alvo, impedindo-o de lançar feitiços por um curto período.",
            Description_EnUS = "Increases the chance to silence the target, preventing them from casting spells for a short period.",
            OverheadStyle = "Silence",
            CalculateType = ZuluModCalcType.Percent,
            Hue = SpecialModHue,
            SecondsPeriod = 3
        };

        _modConfigs[(int)ZuluMod.PhysicalDamageReflection] = new ZuluModConfigs
        {
            Name = "Physical Damage Reflection",
            MinCap = 0,
            MaxCap = 35,
            Description_PtBR = "Reflete uma porcentagem do dano físico recebido de volta para o atacante.",
            Description_PtBR_SecondLine = "Somente usando escudos.",
            Description_EnUS = "Reflects a percentage of physical damage taken back to the attacker.",
            Description_EnUS_SecondLine = "Only when using shields.",
            OverheadStyle = "Damage Reflected",
            CalculateType = ZuluModCalcType.Percent,
            Hue = SpecialModHue
        };

        _modConfigs[(int)ZuluMod.SpellDamageReflection] = new ZuluModConfigs
        {
            Name = "Spell Damage Reflection",
            MinCap = 0,
            MaxCap = 35,
            Description_PtBR = "Reflete uma porcentagem do dano magico recebido de volta para o atacante.",
            Description_PtBR_SecondLine = "Não funciona para Classe Warrior",
            Description_EnUS = "Reflects a percentage of spell damage taken back to the attacker.",
            Description_EnUS_SecondLine = "Does not work for Warrior Class.",
            OverheadStyle = "Damage Reflected",
            CalculateType = ZuluModCalcType.Percent,
            Hue = SpecialModHue
        };

         _modConfigs[(int)ZuluMod.ParryngChance] = new ZuluModConfigs
        {
            Name = "Parrying Chance",
            MinCap = 0,
            MaxCap = 75,
            Description_PtBR = "Aumenta a chance de aparar ataques corpo a corpo, usando Escudo.",
            Description_EnUS = "Increases the chance to parry melee attacks, using Shield.",
            OverheadStyle = "Parrying Chance",
            CalculateType = ZuluModCalcType.Percent,
            Hue = SpecialModHue
        };

         _modConfigs[(int)ZuluMod.ArcheryDamageAmp] = new ZuluModConfigs
        {
            Name = "Archery Damage Amplifier",
            MinCap = 0,
            MaxCap = 75,
            Description_PtBR = "Aumenta o dano causado por ataques à distância usando Arcos.",
            Description_EnUS = "Increases damage dealt by ranged attacks using Bows.",
            OverheadStyle = "Archery Damage Amp",
            CalculateType = ZuluModCalcType.Percent,
            Hue = SpecialModHue
        };


        _modConfigs[(int)ZuluMod.SpellDamageReflection] = new ZuluModConfigs
        {
            Name = "Spell Damage Reflection",
            MinCap = 0,
            MaxCap = 35,
            Description_PtBR = "Reflete uma porcentagem do dano magico recebido de volta para o atacante.",
            Description_PtBR_SecondLine = "Não funciona para Classe Warrior",
            Description_EnUS = "Reflects a percentage of spell damage taken back to the attacker.",
            Description_EnUS_SecondLine = "Does not work for Warrior Class.",
            OverheadStyle = "Damage Reflected",
            CalculateType = ZuluModCalcType.Percent,
            Hue = SpecialModHue
        };

        #endregion

        #region Skills Modifiers


        _modConfigs[(int)ZuluMod.HealingBonus] = new ZuluModConfigs
        {
            Name = "Healing Bonus",
            MinCap = 0,
            MaxCap = 75,
            Description_PtBR = "Aumenta a quantidade de cura recebida.",
            Description_EnUS = "Increases the amount of healing received.",
            OverheadStyle = "Healing Bonus",
            CalculateType = ZuluModCalcType.Percent,
            Hue = SpecialModHue
        };

        _modConfigs[(int)ZuluMod.MeditationRegenAmplifier] = new ZuluModConfigs
        {
            Name = "Meditation Regen Amplifier",
            MinCap = 0,
            MaxCap = 75,
            Description_PtBR = "Aumenta a regeneração de mana durante a meditação.",
            Description_EnUS = "Increases mana regeneration during meditation.",
            OverheadStyle = "Meditation Regen Amp",
            CalculateType = ZuluModCalcType.Percent,
            Hue = SpecialModHue
        };

        #endregion

        #region Mobs Modifiers
        _modConfigs[(int)ZuluMod.FencingProtection] = new ZuluModConfigs
        {
            Name = "Fencing Protection",
            MinCap = -1000,
            MaxCap = 100,
            Description_PtBR = "Proteção contra dano do tipo Fencing.",
            Description_EnUS = "Only for mobs.",
            OverheadStyle = "Fencing Prot",
            CalculateType = ZuluModCalcType.Percent,
            Hue = SpecialModHue,
        };

        _modConfigs[(int)ZuluMod.MacingProtection] = new ZuluModConfigs
        {
            Name = "Macing Protection",
            MinCap = -1000,
            MaxCap = 100,
            Description_PtBR = "Proteção contra dano do tipo Macing.",
            Description_EnUS = "Only for mobs.",
            OverheadStyle = "Macing Prot",
            CalculateType = ZuluModCalcType.Percent,
            Hue = SpecialModHue,
        };

        _modConfigs[(int)ZuluMod.SwordsProtection] = new ZuluModConfigs
        {
            Name = "Swords Protection",
            MinCap = -1000,
            MaxCap = 100,
            Description_PtBR = "Proteção contra dano do tipo Swords.",
            Description_EnUS = "Only for mobs.",
            OverheadStyle = "Swords Prot",
            CalculateType = ZuluModCalcType.Percent,
            Hue = SpecialModHue,
        };

        _modConfigs[(int)ZuluMod.WrestlingProtection] = new ZuluModConfigs
        {
            Name = "Wrestling Protection",
            MinCap = -1000,
            MaxCap = 100,
            Description_PtBR = "Proteção contra dano do tipo Wrestling.",
            Description_EnUS = "Only for mobs.",
            OverheadStyle = "Wrestling Prot",
            CalculateType = ZuluModCalcType.Percent,
            Hue = SpecialModHue,
        };

        _modConfigs[(int)ZuluMod.RangedProtection] = new ZuluModConfigs
        {
            Name = "Ranged Protection",
            MinCap = -1000,
            MaxCap = 100,
            Description_PtBR = "Proteção contra dano do tipo Ranged.",
            Description_EnUS = "Only for mobs.",
            OverheadStyle = "Ranged Prot",
            CalculateType = ZuluModCalcType.Percent,
            Hue = SpecialModHue,
        };

        #endregion

        //PENTS

        //Air 1161
        //Water 1167
        //Fire 139
        //Shadow 1157




    }
    public static ZuluModConfigs GetMod(ZuluMod type)
        => _modConfigs[(int)type];

    public static List<ZuluMod> GetCombatMods()
    {
        List<ZuluMod> result = [
            ZuluMod.PhysicalProtection,
            ZuluMod.Accurracy,
            ZuluMod.ParryngChance,
            ZuluMod.AttackSpeed,
            ZuluMod.ArcheryDamageAmp,
            ZuluMod.Evasion,
            ZuluMod.FixedPhysicalDamageAmp,
            ZuluMod.PhysicalDamageAmp,
            ZuluMod.PhysicalDamageReflection,
        ];

        return result;
    }

    public static List<ZuluMod> GetProtectionsMods()
    {
        List<ZuluMod> result = [
            ZuluMod.SpellProtection,
            ZuluMod.AirProtection,
            ZuluMod.EarthProtection,
            ZuluMod.WaterProtection,
            ZuluMod.FireProtection,
            ZuluMod.NecroProtection,
            ZuluMod.HollyProtection,
            ZuluMod.PoisonProtection,
        ];

        return result;
    }

    public static List<ZuluMod> GetMagicalMods()
    {
        List<ZuluMod> result = [
            
            ZuluMod.AirAmplifier,
            ZuluMod.EarthAmplifier,
            ZuluMod.WaterAmplifier,
            ZuluMod.FireAmplifier,
            ZuluMod.NecroAmplifier,
            ZuluMod.HollyAmplifier,
            ZuluMod.PoisonAmplifier,
            ZuluMod.SpellAmplifier,
            ZuluMod.CastSpeed,
            ZuluMod.SpellCriticalChance,
            ZuluMod.SpellCriticalDamage,
            ZuluMod.MeditationRegenAmplifier,
            ZuluMod.SpellDamageReflection,

        ];

        return result;
    }

    public static List<ZuluMod> GetSpecialMods()
    {
        List<ZuluMod> result = [

            ZuluMod.CleaveDamage,
            ZuluMod.Lifesteal,
            ZuluMod.Manaleech,
            ZuluMod.BleedChance,
            ZuluMod.DisturbChance,
            ZuluMod.StunChance,
            ZuluMod.SillenceChance,
            ZuluMod.HealingBonus,
            ZuluMod.FreeAction,
        ];

        return result;
    }

    public static List<ZuluMod> GetMobsMods()
    {
        List<ZuluMod> result = [

            ZuluMod.WrestlingProtection,
            ZuluMod.FencingProtection,
            ZuluMod.SwordsProtection,
            ZuluMod.MacingProtection,
            ZuluMod.RangedProtection,

        ];

        return result;
    }

    public static ZuluElementConfigs GetElement(ZuluElement type)
    => _elementConfigs[(int)type];

    public static void SendDamageTakenOverHeadMessage(ZuluMod type, int damage, Mobile attacker, Mobile defender, bool imune = false)
    {

        string valorEmTxt = "";

        if (damage > 0)
            valorEmTxt = $"-{damage}";
        else if (damage < 0)
            valorEmTxt = $"+{damage}";

        if (imune)
        {
            defender.PrivateOverheadMessage(
                MessageType.Regular,
                GetMod(type).Hue,
                true,
                $"[{GetMod(type).OverheadStyle} Immune]",
                attacker.NetState
            );
        }
        else
        {
            defender.PrivateOverheadMessage(
                MessageType.Regular,
                GetMod(type).Hue,
                true,
                string.Format(GetMod(type).OverheadStyle, valorEmTxt),
                attacker.NetState
            );
        }
    }

    public static void SendSpecialHabilityOverHeadMessage(ZuluMod type, Mobile attacker, Mobile defender, int value = 0)
    {
        string valorEmTxt;

        if(value > 0)
            valorEmTxt = value.ToString();
        else if (value <0)
            valorEmTxt = $"-{value}";


        attacker.PrivateOverheadMessage(
            MessageType.Regular,
            GetMod(type).Hue,
            true,
            string.Format(GetMod(type).OverheadStyle, value),
            attacker.NetState
        );
    }
}

public enum ZuluModifierSourceType
{
    None,
    Equipment,
    Skill,
    Potion,
    Food,
    Camping,
    Spell,
    Classe,
    Stat,
    Ambience,
}

public enum ZuluModGroups
{
    Protections,
    Combat,
    Magical,
    Special,
    OnlyMobs,

}

public class ZuluModifierSource
{
    public ZuluModifierSourceType Source { get; set; }
    public ZuluMod Mod { get; set; }
    public SkillName? Skill { get; set; }
    public string SourceName { get; set; }
    public double Value { get; set; } 
}

public sealed class ZuluModConfigs
{
    public string Name { get; set; }

    public double MinCap { get; set; }
    public double MaxCap { get; set; }

    public string Description_PtBR { get; set; }
    public string Description_PtBR_SecondLine { get; set; }

    public string Description_EnUS { get; set; }
    public string Description_EnUS_SecondLine { get; set; }
    public string OverheadStyle { get; set; }
    public ZuluModCalcType CalculateType { get; set; }
    public int Hue { get; set; }
    public ZuluModGroups Group { get; set; }

    public int SecondsPeriod { get; set; }
    public int EffectRange { get; set; }

    public Type[] AllowedTypes { get; set; }

}

public sealed class ZuluElementConfigs
{
    public string Name { get; set; }
    public int Hue { get; set; } 
}
