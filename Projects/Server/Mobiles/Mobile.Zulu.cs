using ModernUO.Serialization;
using System;
using System.Collections.Generic;

namespace Server
{
    public partial class Mobile
    {
        /// <summary>
        /// Active Class defined for the player after calculation. Classes are calculated every equip/unequip, login, and whe skill increase. Or open Class/Skills Menu.
        /// </summary>
        public ZuluClass ActiveZuluClass { get; set; }
        /// <summary>
        /// Active Class level defined for the player after calculation. Level are recalculated every equip/unequip, login and whe skill increased. Or open Class/Skills Menu.
        /// </summary>
        public int ActiveZuluClassLevel { get; set; }


        private static readonly int _zuluModCount = Enum.GetValues<ZuluMod>().Length;
        /// <summary>
        /// Active ZuluModifiers of the mobile. Calculated every equip/unequip, login, and when changes Level or Class. One item per ZuluMod in this list, acumulated if multiples sources of modifier.
        /// </summary>
        public double[] ActiveZuluModifiers { get; set; } = new double[_zuluModCount];
        /// <summary>
        /// Lists every ZuluModifier impacting ActiveZuluModifier of the players. Used just for understand why some value in ActiveZuluModifiers are this value. Breaks down every source totalizing this value.
        /// </summary>
        public List<ZuluModifierSource> ZuluModifierSources { get; set; } = new List<ZuluModifierSource>();

        /// <summary>
        ///  Indicates that whenever it needed to use Modifiers for anything like Combat/useskill/craft/defend etc, it must be recalculated. This is used to improve performance and not recalculate everytime increase skill or every combat. Only when needed.
        /// </summary>
        public bool isZuluDirty { get; set; } = true;

        public int z_Physical_DD { get; set; } = 0;
        public int z_Air_DD { get; set; } = 0;
        public int z_Necro_DD { get; set; } = 0;
        public int z_Fire_DD { get; set; } = 0;
        public int z_Water_DD { get; set; } = 0;
        public int z_Poison_DD { get; set; } = 0;
        public int z_Holly_DD { get; set; } = 0;
        public int z_Earth_DD { get; set; } = 0;


        public void RecalculateZuluModifiers()
        {
            // Somente calcula se for Dirty
            if (!isZuluDirty)
                return;

            // Not Player não recalcula
            if (!Player)
                return;

            //Clean ActiveModifiers and List
            ZuluModifierSources.Clear();
            Array.Clear(ActiveZuluModifiers);

            // Recalcula a Classe Ativa
            ZuluClassManager.CalculateAndSetClass(this);

            // Calcular Modificadores de Classe
            if (ActiveZuluClassLevel > 0)
            {
                var classInfo = ZuluClassManager.GetInfo(ActiveZuluClass);
                if (classInfo != null)
                {
                    var mods = classInfo.AccumulatedModifiers[ActiveZuluClassLevel];
                    foreach (var m in mods)
                    {
                        AddZuluModifier(m.zuluMod, m.value, ZuluModifierSourceType.Classe, ActiveZuluClass.ToString());
                    }
                }
            }

            // Calcular Modificadores de Status
            AddZuluModifier(
                ZuluMod.PhysicalDamageAmp,
                GetBonusFromThreshold(this.Str, 0.050, 130.0, 0),
                ZuluModifierSourceType.Stat, Stat.Str.ToString());

            AddZuluModifier(
                ZuluMod.SpellAmplifier,
                GetBonusFromThreshold(this.Int, 0.5, 100.0, 5),
                ZuluModifierSourceType.Stat, Stat.Int.ToString());

            //Modificadores de Skill
            AddZuluModifier(
                ZuluMod.PhysicalDamageAmp,
                GetBonusThreshold(this.Skills.Tactics.Value, 0.625, 100.0, 6.25),
                ZuluModifierSourceType.Skill, SkillName.Tactics.ToString());

            AddZuluModifier(
                ZuluMod.ParryngChance,
                this.Skills.Parry.Value / 150 * 35,
                ZuluModifierSourceType.Skill, SkillName.Parry.ToString());






            // Calcular Modificadores de Equipamento
            foreach (var item in this.Items)
            {
                if (!item.IsEquippableLayer)
                {
                    continue;
                }
                for (int i = 0; i < item.ZuluModifiers.Length; i++)
                {
                    AddZuluModifier((ZuluMod)i, item.ZuluModifiers[i], ZuluModifierSourceType.Equipment, item.GetType().Name);
                }
            }


            // Calcular Modificadores de Buffs (Talvez ja seja automatico?)



            //Finaliza
            isZuluDirty = false;

            return;

        }

        public double GetZuluModifier(ZuluMod mod)
        {
            RecalculateZuluModifiers();
            var cfg = ZuluModManager.GetMod(mod);
            var value = ActiveZuluModifiers[(int)mod];

            if (value > cfg.MaxCap)
            {
                return cfg.MaxCap;
            }

            if (value < cfg.MinCap)
            {
                return cfg.MinCap;
            }

            return value;
        }

        private void AddZuluModifier(ZuluMod modifier, double value, ZuluModifierSourceType source)
        {
            AddZuluModifier(modifier, value, source, null);
        }

        public void AddZuluModifier(ZuluMod modifier, double value, ZuluModifierSourceType source, string sourceName)
        {
            if (value != 0)
            {
                ActiveZuluModifiers[(int)modifier] += value;
                ZuluModifierSources.Add(new ZuluModifierSource()
                {
                    Source = source,
                    Mod = modifier,
                    Value = value,
                    SourceName = sourceName,
                });
            }
        }

        public void AddMobZuluModifier(ZuluMod modifier, double min, double max)
        {
            ActiveZuluModifiers[(int)modifier] += Utility.RandomMinMax(min, max);
        }

        /// <summary>
        /// Calcula bônus percentual baseado em um atributo.
        /// </summary>
        /// <param name="attributeValue">Valor do atributo (ex: STR)</param>
        /// <param name="pointsPerStep">Quantos pontos geram 1 step</param>
        /// <param name="bonusPerStep">Bônus (%) por step</param>
        /// <param name="cap">CAP máximo (%)</param>
        public static double CalculatePercentBonus(
            int attributeValue,
            int pointsPerStep,
            double bonusPerStep,
            double cap)
        {
            if (attributeValue <= 0 || pointsPerStep <= 0 || bonusPerStep <= 0)
                return 0;

            int steps = attributeValue / pointsPerStep;
            double bonus = steps * bonusPerStep;

            if (cap > 0 && bonus > cap)
                bonus = cap;

            return bonus;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">Valor base (ex: STR, Tactics, Skill)</param>
        /// <param name="scalar">Quanto cada ponto contribui</param>
        /// <param name="threshold">Valor mínimo para ganhar bônus extra</param>
        /// <param name="offset">Bônus fixo adicional após o threshold</param>
        /// <returns></returns>
        public virtual double GetBonusThreshold(double value, double scalar, double threshold, double offset)
        {
            var bonus = value * scalar;

            if (value >= threshold)
            {
                bonus += offset;
            }

            return bonus / 100;
        }

        public virtual double GetBonusFromThreshold(
    double value,
    double scalar,
    double threshold,
    double offset)
        {
            if (value < threshold)
                return 0;

            double bonus = (value - threshold) * scalar;

            if (offset > 0)
                bonus += offset;

            return bonus / 100;
        }
    }
}

