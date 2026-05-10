using ModernUO.Serialization;
using Server.Items;

namespace Server.Mobiles
{
    // Zulu Hotel — Gazers Evil NPCs
    // Auto-generated from npcdesc_zhbr.cfg (6 NPCs)
    // Source: POL 98 Zulu Hotel shard

    [SerializationGenerator(0, false)]
    public partial class ZuluDesertgazer : BaseCreature
    {
        [Constructible]
        public ZuluDesertgazer() : base(AIType.AI_Mage)
        {
            Body = 22;
            Hue = 0x497;
            BaseSoundID = 0x370;

            SetStr(250);
            SetDex(100);
            SetInt(200);
            SetHits(300);
            SetMana(1000);
            SetStam(200);

            SetDamage(8, 25);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.FireProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.AirProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.EarthProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 1, 1);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Anatomy, 90.0, 100.0);
            SetSkill(SkillName.Swords, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.Fencing, 90.0, 100.0);
            SetSkill(SkillName.Wrestling, 90.0, 100.0);
            SetSkill(SkillName.Parry, 110.0, 120.0);
            SetSkill(SkillName.MagicResist, 110.0, 120.0);
            SetSkill(SkillName.DetectHidden, 60.0, 70.0);
            SetSkill(SkillName.Magery, 100.0, 110.0);
            SetSkill(SkillName.EvalInt, 90.0, 100.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 64;
        }

        public override string DefaultName => "a desert beholder";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluEnchantedspellbook : BaseCreature
    {
        [Constructible]
        public ZuluEnchantedspellbook() : base(AIType.AI_Mage)
        {
            Body = 985;
            Hue = 0x486;
            BaseSoundID = 0x476;

            SetStr(750);
            SetDex(750);
            SetInt(500);
            SetHits(2000);
            SetMana(2500);
            SetStam(1500);

            SetDamage(18, 50);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.FireProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.WaterProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.AirProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.NecroProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.HollyProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.EarthProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 2, 2);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Anatomy, 90.0, 100.0);
            SetSkill(SkillName.Swords, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.Fencing, 90.0, 100.0);
            SetSkill(SkillName.Wrestling, 90.0, 100.0);
            SetSkill(SkillName.Parry, 60.0, 70.0);
            SetSkill(SkillName.MagicResist, 130.0, 140.0);
            SetSkill(SkillName.DetectHidden, 80.0, 90.0);
            SetSkill(SkillName.Magery, 140.0, 150.0);
            SetSkill(SkillName.EvalInt, 110.0, 120.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 51;
        }

        public override string DefaultName => "an enchanted spellbook";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluFlaminggazer : BaseCreature
    {
        [Constructible]
        public ZuluFlaminggazer() : base(AIType.AI_Mage)
        {
            Body = 22;
            Hue = 0x494;
            BaseSoundID = 0x370;

            SetStr(250);
            SetDex(100);
            SetInt(200);
            SetHits(500);
            SetMana(1000);
            SetStam(200);

            SetDamage(8, 25);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.FireProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.EarthProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 1, 1);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Anatomy, 90.0, 100.0);
            SetSkill(SkillName.Swords, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.Fencing, 90.0, 100.0);
            SetSkill(SkillName.Wrestling, 90.0, 100.0);
            SetSkill(SkillName.Parry, 110.0, 120.0);
            SetSkill(SkillName.MagicResist, 110.0, 120.0);
            SetSkill(SkillName.DetectHidden, 60.0, 70.0);
            SetSkill(SkillName.Magery, 100.0, 110.0);
            SetSkill(SkillName.EvalInt, 90.0, 100.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 64;
        }

        public override string DefaultName => "a flaming beholder";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluForestgazer : BaseCreature
    {
        [Constructible]
        public ZuluForestgazer() : base(AIType.AI_Mage)
        {
            Body = 22;
            Hue = 0x499;
            BaseSoundID = 0x17E;

            SetStr(150);
            SetDex(100);
            SetInt(100);
            SetHits(300);
            SetMana(500);
            SetStam(200);

            SetDamage(8, 25);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 40.0, 50.0);
            SetSkill(SkillName.Anatomy, 65.0, 75.0);
            SetSkill(SkillName.Swords, 65.0, 75.0);
            SetSkill(SkillName.Macing, 65.0, 75.0);
            SetSkill(SkillName.Fencing, 65.0, 75.0);
            SetSkill(SkillName.Wrestling, 65.0, 75.0);
            SetSkill(SkillName.Parry, 55.0, 65.0);
            SetSkill(SkillName.MagicResist, 75.0, 85.0);
            SetSkill(SkillName.DetectHidden, 40.0, 50.0);
            SetSkill(SkillName.Magery, 80.0, 90.0);
            SetSkill(SkillName.EvalInt, 70.0, 80.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 38;
        }

        public override string DefaultName => "a forest gazer";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluFrostgazer : BaseCreature
    {
        [Constructible]
        public ZuluFrostgazer() : base(AIType.AI_Mage)
        {
            Body = 22;
            Hue = 0x482;
            BaseSoundID = 0x370;

            SetStr(250);
            SetDex(100);
            SetInt(200);
            SetHits(500);
            SetMana(1000);
            SetStam(200);

            SetDamage(8, 25);
            z_Air_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.WaterProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.AirProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.EarthProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 1, 1);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Anatomy, 90.0, 100.0);
            SetSkill(SkillName.Swords, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.Fencing, 90.0, 100.0);
            SetSkill(SkillName.Wrestling, 90.0, 100.0);
            SetSkill(SkillName.Parry, 110.0, 120.0);
            SetSkill(SkillName.MagicResist, 110.0, 120.0);
            SetSkill(SkillName.DetectHidden, 60.0, 70.0);
            SetSkill(SkillName.Magery, 100.0, 110.0);
            SetSkill(SkillName.EvalInt, 90.0, 100.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 64;
        }

        public override string DefaultName => "a frigid eye";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluGazer : BaseCreature
    {
        [Constructible]
        public ZuluGazer() : base(AIType.AI_Mage)
        {
            Body = 22;
            BaseSoundID = 0x17E;

            SetStr(150);
            SetDex(100);
            SetInt(100);
            SetHits(300);
            SetMana(500);
            SetStam(200);

            SetDamage(8, 25);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 40.0, 50.0);
            SetSkill(SkillName.Anatomy, 65.0, 75.0);
            SetSkill(SkillName.Swords, 65.0, 75.0);
            SetSkill(SkillName.Macing, 65.0, 75.0);
            SetSkill(SkillName.Fencing, 65.0, 75.0);
            SetSkill(SkillName.Wrestling, 65.0, 75.0);
            SetSkill(SkillName.Parry, 55.0, 65.0);
            SetSkill(SkillName.MagicResist, 75.0, 85.0);
            SetSkill(SkillName.DetectHidden, 40.0, 50.0);
            SetSkill(SkillName.Magery, 80.0, 90.0);
            SetSkill(SkillName.EvalInt, 70.0, 80.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 38;
        }

        public override string DefaultName => "a gazer";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }
}
