using ModernUO.Serialization;
using System;
using System.Collections.Generic;

namespace Server
{
    public partial class Mobile
    {
        public ZuluClass ActiveZuluClass { get; set; }
        public int ActiveZuluClassLevel { get; set; }

        public double[] ActiveZuluModifiers { get; set; } = new double[Enum.GetValues<ZuluMod>().Length];
        public List<ZuluModifierSource> ZuluModifierSources { get; set; } = new List<ZuluModifierSource>();

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
            ZuluModifierSources = new List<ZuluModifierSource>();
            ActiveZuluModifiers = new double[Enum.GetValues<ZuluMod>().Length];

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
                        AddZuluModifier(m.zuluMod, m.value, ZuluModifierSourceType.Classe);
                    }
                }
            }

            // Calcular Modificadores de Status
            AddZuluModifier(
                ZuluMod.PhysicalDamageAmp,
                GetBonusFromThreshold(this.Str, 0.050, 130.0, 0),
                ZuluModifierSourceType.Stat, Stat.Str.ToString());

            AddZuluModifier(
                ZuluMod.ParryngChance,
                GetBonusFromThreshold(this.Dex, 0.5, 100.0, 5),
                ZuluModifierSourceType.Stat, Stat.Dex.ToString());

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
                if (item.Parent == this)
                {
                    for (int i = 0; i < item.ZuluModifiers.Length; i++)
                    {
                        AddZuluModifier((ZuluMod)i, item.ZuluModifiers[i], ZuluModifierSourceType.Equipment);
                    }
                }

            }


            // Calcular Modificadores de Buffs (Talvez ja seja automatico?)



            //Finaliza
            isZuluDirty = false;

            return;

        }

        public double GetZuluModifier(ZuluMod mod)
        {
            double value = ActiveZuluModifiers[(int)mod];

            if (value > ZuluModManager.GetMod(mod).MaxCap)
                value = ZuluModManager.GetMod(mod).MaxCap;
            else if (value < ZuluModManager.GetMod(mod).MinCap)
                value = ZuluModManager.GetMod(mod).MinCap;

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

