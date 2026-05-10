using ModernUO.Serialization;
using Server.Items;

namespace Server.Mobiles
{
    // Zulu Hotel — Elementals Evil NPCs
    // Auto-generated from npcdesc_zhbr.cfg (14 NPCs)
    // Source: POL 98 Zulu Hotel shard

    [SerializationGenerator(0, false)]
    public partial class ZuluAcidelemental : BaseCreature
    {
        [Constructible]
        public ZuluAcidelemental() : base(AIType.AI_Melee)
        {
            Body = 16;
            Hue = 0x48A;
            BaseSoundID = 0x11B;

            SetStr(150);
            SetDex(250);
            SetInt(300);
            SetHits(500);
            SetMana(600);
            SetStam(600);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.EarthProtection, 40, 40);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Swords, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.Fencing, 90.0, 100.0);
            SetSkill(SkillName.Wrestling, 90.0, 100.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 80.0, 90.0);
            SetSkill(SkillName.Magery, 90.0, 100.0);
            SetSkill(SkillName.EvalInt, 40.0, 50.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 51;
        }

        public override string DefaultName => "a acid elemental";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluAirelemental : BaseCreature
    {
        [Constructible]
        public ZuluAirelemental() : base(AIType.AI_Mage)
        {
            Body = 13;
            Hue = 0x83F8;
            BaseSoundID = 0x10C;

            SetStr(150);
            SetDex(100);
            SetInt(300);
            SetHits(600);
            SetMana(600);
            SetStam(600);

            SetDamage(8, 25);
            z_Air_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.AirProtection, 40, 40);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Swords, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.Fencing, 90.0, 100.0);
            SetSkill(SkillName.Wrestling, 90.0, 100.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 90.0, 100.0);
            SetSkill(SkillName.Magery, 90.0, 100.0);
            SetSkill(SkillName.EvalInt, 90.0, 100.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 53;
        }

        public override string DefaultName => "an air elemental";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluAirelementallord : BaseCreature
    {
        [Constructible]
        public ZuluAirelementallord() : base(AIType.AI_Mage)
        {
            Body = 13;
            Hue = 0x41A;

            SetStr(200);
            SetDex(200);
            SetInt(300);
            SetHits(800);
            SetMana(1000);
            SetStam(1000);

            SetDamage(8, 25);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.AirProtection, 80, 80);

            SetSkill(SkillName.Tactics, 120.0, 130.0);
            SetSkill(SkillName.Swords, 120.0, 130.0);
            SetSkill(SkillName.Macing, 120.0, 130.0);
            SetSkill(SkillName.Parry, 120.0, 130.0);
            SetSkill(SkillName.MagicResist, 90.0, 100.0);
            SetSkill(SkillName.Magery, 120.0, 130.0);
            SetSkill(SkillName.EvalInt, 120.0, 130.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 63;
        }

        public override string DefaultName => "an air elemental lord";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBloodelemental : BaseCreature
    {
        [Constructible]
        public ZuluBloodelemental() : base(AIType.AI_Mage)
        {
            Body = 16;
            Hue = 0x4B9;

            SetStr(450);
            SetDex(185);
            SetInt(400);
            SetHits(500);
            SetMana(200);
            SetStam(50);

            SetDamage(12, 35);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 3, 3);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Macing, 190.0, 200.0);
            SetSkill(SkillName.MagicResist, 70.0, 80.0);

            Fame = 10000;
            Karma = -10000;
            VirtualArmor = 16;
        }

        public override string DefaultName => "a blood elemental";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluEarthelemental : BaseCreature
    {
        [Constructible]
        public ZuluEarthelemental() : base(AIType.AI_Melee)
        {
            Body = 14;
            Hue = 0x83F8;
            BaseSoundID = 0x111;

            SetStr(150);
            SetDex(100);
            SetInt(50);
            SetHits(600);
            SetMana(0);
            SetStam(600);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.EarthProtection, 40, 40);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Anatomy, 90.0, 100.0);
            SetSkill(SkillName.Swords, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.Fencing, 90.0, 100.0);
            SetSkill(SkillName.Wrestling, 90.0, 100.0);
            SetSkill(SkillName.Parry, 100.0, 110.0);
            SetSkill(SkillName.MagicResist, 65.0, 75.0);
            SetSkill(SkillName.DetectHidden, 190.0, 200.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 51;
        }

        public override string DefaultName => "an earth elemental";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluEarthelementallord : BaseCreature
    {
        [Constructible]
        public ZuluEarthelementallord() : base(AIType.AI_Melee)
        {
            Body = 14;
            Hue = 0x602;

            SetStr(400);
            SetDex(400);
            SetInt(100);
            SetHits(900);
            SetMana(1000);
            SetStam(1000);

            SetDamage(12, 35);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.EarthProtection, 80, 80);

            SetSkill(SkillName.Tactics, 120.0, 130.0);
            SetSkill(SkillName.Swords, 120.0, 130.0);
            SetSkill(SkillName.Macing, 120.0, 130.0);
            SetSkill(SkillName.Parry, 120.0, 130.0);
            SetSkill(SkillName.MagicResist, 90.0, 100.0);
            SetSkill(SkillName.Magery, 120.0, 130.0);
            SetSkill(SkillName.EvalInt, 120.0, 130.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 63;
        }

        public override string DefaultName => "an earth elemental lord";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluFireelemental : BaseCreature
    {
        [Constructible]
        public ZuluFireelemental() : base(AIType.AI_Mage)
        {
            Body = 15;
            Hue = 0x83F8;
            BaseSoundID = 0x116;

            SetStr(150);
            SetDex(100);
            SetInt(150);
            SetHits(600);
            SetMana(600);
            SetStam(600);

            SetDamage(8, 25);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.FireProtection, 40, 40);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Swords, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.Fencing, 90.0, 100.0);
            SetSkill(SkillName.Wrestling, 90.0, 100.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 90.0, 100.0);
            SetSkill(SkillName.Magery, 90.0, 100.0);
            SetSkill(SkillName.EvalInt, 90.0, 100.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 53;
        }

        public override string DefaultName => "a fire elemental";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluFireelementallord : BaseCreature
    {
        [Constructible]
        public ZuluFireelementallord() : base(AIType.AI_Mage)
        {
            Body = 15;
            Hue = 0x486;

            SetStr(300);
            SetDex(350);
            SetInt(500);
            SetHits(800);
            SetMana(1000);
            SetStam(1000);

            SetDamage(12, 35);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.FireProtection, 80, 80);

            SetSkill(SkillName.Tactics, 120.0, 130.0);
            SetSkill(SkillName.Swords, 120.0, 130.0);
            SetSkill(SkillName.Macing, 120.0, 130.0);
            SetSkill(SkillName.Parry, 120.0, 130.0);
            SetSkill(SkillName.MagicResist, 90.0, 100.0);
            SetSkill(SkillName.Magery, 120.0, 130.0);
            SetSkill(SkillName.EvalInt, 120.0, 130.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 63;
        }

        public override string DefaultName => "a fire elemental lord";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluIronelemental : BaseCreature
    {
        [Constructible]
        public ZuluIronelemental() : base(AIType.AI_Melee)
        {
            Body = 14;
            Hue = 0x502;
            BaseSoundID = 0x476;

            SetStr(500);
            SetDex(1000);
            SetInt(50);
            SetHits(500);
            SetMana(0);
            SetStam(600);

            SetDamage(18, 50);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Anatomy, 90.0, 100.0);
            SetSkill(SkillName.Swords, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.Fencing, 90.0, 100.0);
            SetSkill(SkillName.Wrestling, 90.0, 100.0);
            SetSkill(SkillName.Parry, 100.0, 110.0);
            SetSkill(SkillName.MagicResist, 80.0, 90.0);
            SetSkill(SkillName.DetectHidden, 190.0, 200.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 54;
        }

        public override string DefaultName => "an iron elemental";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluSandelemental : BaseCreature
    {
        [Constructible]
        public ZuluSandelemental() : base(AIType.AI_Mage)
        {
            Body = 16;
            Hue = 0x15F;
            BaseSoundID = 0x11B;

            SetStr(150);
            SetDex(250);
            SetInt(300);
            SetHits(350);
            SetMana(600);
            SetStam(600);

            SetDamage(8, 25);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.FireProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.EarthProtection, 40, 40);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Swords, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.Fencing, 90.0, 100.0);
            SetSkill(SkillName.Wrestling, 90.0, 100.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 80.0, 90.0);
            SetSkill(SkillName.Magery, 90.0, 100.0);
            SetSkill(SkillName.EvalInt, 40.0, 50.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 51;
        }

        public override string DefaultName => "a sand elemental";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluSnowelemental : BaseCreature
    {
        [Constructible]
        public ZuluSnowelemental() : base(AIType.AI_Mage)
        {
            Body = 199;

            SetStr(140);
            SetDex(70);
            SetInt(110);
            SetHits(225);
            SetMana(125);
            SetStam(65);

            SetDamage(5, 15);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.WaterProtection, 30, 30);

            SetSkill(SkillName.Tactics, 300.0, 310.0);
            SetSkill(SkillName.Macing, 175.0, 185.0);
            SetSkill(SkillName.MagicResist, 160.0, 170.0);
            SetSkill(SkillName.Magery, 80.0, 90.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 34;
        }

        public override string DefaultName => "a snow elemental";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluVortex : BaseCreature
    {
        [Constructible]
        public ZuluVortex() : base(AIType.AI_Mage)
        {
            Body = 573;

            SetStr(350);
            SetDex(250);
            SetInt(110);
            SetHits(500);
            SetMana(125);
            SetStam(500);

            SetDamage(12, 35);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 115.0, 125.0);
            SetSkill(SkillName.Macing, 115.0, 125.0);
            SetSkill(SkillName.MagicResist, 140.0, 150.0);
            SetSkill(SkillName.Poisoning, 90.0, 100.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 30;
        }

        public override string DefaultName => "an energy vortex";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluWaterelemental : BaseCreature
    {
        [Constructible]
        public ZuluWaterelemental() : base(AIType.AI_Mage)
        {
            Body = 16;
            Hue = 0x83F8;
            BaseSoundID = 0x11B;

            SetStr(100);
            SetDex(100);
            SetInt(250);
            SetHits(600);
            SetMana(600);
            SetStam(600);

            SetDamage(5, 15);
            z_Air_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.WaterProtection, 40, 40);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Swords, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.Fencing, 90.0, 100.0);
            SetSkill(SkillName.Wrestling, 90.0, 100.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 90.0, 100.0);
            SetSkill(SkillName.Magery, 90.0, 100.0);
            SetSkill(SkillName.EvalInt, 40.0, 50.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 53;
        }

        public override string DefaultName => "a water elemental";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluWaterelementallord : BaseCreature
    {
        [Constructible]
        public ZuluWaterelementallord() : base(AIType.AI_Mage)
        {
            Body = 16;
            Hue = 0x66;

            SetStr(300);
            SetDex(250);
            SetInt(600);
            SetHits(800);
            SetMana(1000);
            SetStam(1000);

            SetDamage(12, 35);
            z_Air_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.WaterProtection, 80, 80);

            SetSkill(SkillName.Tactics, 120.0, 130.0);
            SetSkill(SkillName.Swords, 120.0, 130.0);
            SetSkill(SkillName.Macing, 120.0, 130.0);
            SetSkill(SkillName.Parry, 120.0, 130.0);
            SetSkill(SkillName.MagicResist, 90.0, 100.0);
            SetSkill(SkillName.Magery, 120.0, 130.0);
            SetSkill(SkillName.EvalInt, 120.0, 130.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 63;
        }

        public override string DefaultName => "a water elemental lord";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }
}
