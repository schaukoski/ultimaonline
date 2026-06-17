using ModernUO.Serialization;
using Server.Items;

namespace Server.Mobiles
{
    // Zulu Hotel — Spiders Evil NPCs
    // Auto-generated from npcdesc_zhbr.cfg (6 NPCs)
    // Source: POL 98 Zulu Hotel shard

    [SerializationGenerator(0, false)]
    public partial class ZuluDireweaver : BaseCreature
    {
        [Constructible]
        public ZuluDireweaver() : base(AIType.AI_Melee)
        {
            Body = 28;
            Hue = 0x7B2;
            BaseSoundID = 0x189;

            SetStr(300);
            SetDex(200);
            SetInt(100);
            SetHits(700);
            SetMana(100);
            SetStam(600);

            SetDamage(12, 35);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.EarthProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 6, 6);

            SetSkill(SkillName.Tactics, 100.0, 110.0);
            SetSkill(SkillName.Anatomy, 100.0, 110.0);
            SetSkill(SkillName.Swords, 100.0, 110.0);
            SetSkill(SkillName.Macing, 100.0, 110.0);
            SetSkill(SkillName.Fencing, 100.0, 110.0);
            SetSkill(SkillName.Wrestling, 100.0, 110.0);
            SetSkill(SkillName.Parry, 100.0, 110.0);
            SetSkill(SkillName.MagicResist, 90.0, 100.0);
            SetSkill(SkillName.DetectHidden, 120.0, 130.0);
            SetSkill(SkillName.Hiding, 90.0, 100.0);
            SetSkill(SkillName.Poisoning, 120.0, 130.0);

            Fame = 35000;
            Karma = -35000;
            VirtualArmor = 56;
            MinTameSkill = 126;
        }

        public override string DefaultName => "a Dire Weaver";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluFlamingspider : BaseCreature
    {
        [Constructible]
        public ZuluFlamingspider() : base(AIType.AI_Melee)
        {
            Body = 28;
            Hue = 0x494;

            SetStr(90);
            SetDex(125);
            SetInt(60);
            SetHits(165);
            SetMana(0);
            SetStam(70);

            SetDamage(5, 15);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 60.0, 70.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 80.0, 90.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 18;
            MinTameSkill = 80;
        }

        public override string DefaultName => "a giant flaming spider";
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluFrostspider : BaseCreature
    {
        [Constructible]
        public ZuluFrostspider() : base(AIType.AI_Melee)
        {
            Body = 28;
            Hue = 0x482;

            SetStr(90);
            SetDex(125);
            SetInt(60);
            SetHits(165);
            SetMana(0);
            SetStam(70);

            SetDamage(5, 15);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 60.0, 70.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 80.0, 90.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 18;
            MinTameSkill = 80;
        }

        public override string DefaultName => "a giant frost spider";
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluPhasespider : BaseCreature
    {
        [Constructible]
        public ZuluPhasespider() : base(AIType.AI_Mage)
        {
            Body = 28;
            Hue = 0x4631;
            BaseSoundID = 0x189;

            SetStr(150);
            SetDex(100);
            SetInt(100);
            SetHits(100);
            SetMana(500);
            SetStam(200);

            SetDamage(8, 25);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 10, 10);

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
            SetSkill(SkillName.Hiding, 65.0, 75.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 38;
            MinTameSkill = 85;
        }

        public override string DefaultName => "a phase spider";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluRockspider : BaseCreature
    {
        [Constructible]
        public ZuluRockspider() : base(AIType.AI_Melee)
        {
            Body = 28;
            Hue = 0x45E;

            SetStr(185);
            SetDex(110);
            SetInt(50);
            SetHits(185);
            SetMana(50);
            SetStam(110);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Macing, 100.0, 110.0);
            SetSkill(SkillName.MagicResist, 30.0, 40.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 8;
            MinTameSkill = 80;
        }

        public override string DefaultName => "a giant rock spider";
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluSpider : BaseCreature
    {
        [Constructible]
        public ZuluSpider() : base(AIType.AI_Melee)
        {
            Body = 28;
            BaseSoundID = 0x189;

            SetStr(100);
            SetDex(60);
            SetInt(35);
            SetHits(100);
            SetMana(35);
            SetStam(60);

            SetDamage(5, 15);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 10, 10);

            SetSkill(SkillName.Tactics, 70.0, 80.0);
            SetSkill(SkillName.Anatomy, 65.0, 75.0);
            SetSkill(SkillName.Swords, 65.0, 75.0);
            SetSkill(SkillName.Macing, 65.0, 75.0);
            SetSkill(SkillName.Fencing, 65.0, 75.0);
            SetSkill(SkillName.Wrestling, 65.0, 75.0);
            SetSkill(SkillName.Parry, 35.0, 45.0);
            SetSkill(SkillName.MagicResist, 20.0, 30.0);
            SetSkill(SkillName.DetectHidden, 20.0, 30.0);
            SetSkill(SkillName.Hiding, 65.0, 75.0);
            SetSkill(SkillName.Poisoning, 60.0, 70.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 21;
            MinTameSkill = 75;
        }

        public override string DefaultName => "a giant spider";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }
}
