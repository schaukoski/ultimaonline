using ModernUO.Serialization;
using Server.Items;

namespace Server.Mobiles
{
    // Zulu Hotel — Undead Evil NPCs
    // Auto-generated from npcdesc_zhbr.cfg (24 NPCs)
    // Source: POL 98 Zulu Hotel shard

    [SerializationGenerator(0, false)]
    public partial class ZuluBloodliche : BaseCreature
    {
        [Constructible]
        public ZuluBloodliche() : base(AIType.AI_Mage)
        {
            Body = 24;
            Hue = 0x494;

            SetStr(275);
            SetDex(210);
            SetInt(900);
            SetHits(275);
            SetMana(900);
            SetStam(210);

            SetDamage(8, 25);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.NecroProtection, 80, 80);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 7, 7);

            SetSkill(SkillName.Tactics, 40.0, 50.0);
            SetSkill(SkillName.Macing, 150.0, 160.0);
            SetSkill(SkillName.MagicResist, 140.0, 150.0);
            SetSkill(SkillName.Magery, 165.0, 175.0);

            Fame = 10000;
            Karma = -10000;
            VirtualArmor = 30;
        }

        public override string DefaultName => "a Bloodliche";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBoneknight : BaseCreature
    {
        [Constructible]
        public ZuluBoneknight() : base(AIType.AI_Melee)
        {
            Body = 57;
            Hue = 0x83F8;
            BaseSoundID = 0x492;

            SetStr(100);
            SetDex(150);
            SetInt(30);
            SetHits(300);
            SetMana(50);
            SetStam(600);

            SetDamage(5, 15);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.FireProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 40, 40);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Anatomy, 90.0, 100.0);
            SetSkill(SkillName.Swords, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.Fencing, 90.0, 100.0);
            SetSkill(SkillName.Wrestling, 90.0, 100.0);
            SetSkill(SkillName.Parry, 65.0, 75.0);
            SetSkill(SkillName.MagicResist, 65.0, 75.0);
            SetSkill(SkillName.DetectHidden, 65.0, 75.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 40;
        }

        public override string DefaultName => "a bone knight";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluFlamingskeleton : BaseCreature
    {
        [Constructible]
        public ZuluFlamingskeleton() : base(AIType.AI_Mage)
        {
            Body = 50;
            Hue = 0x486;
            BaseSoundID = 0x1C8;

            SetStr(300);
            SetDex(400);
            SetInt(50);
            SetHits(300);
            SetMana(50);
            SetStam(600);

            SetDamage(12, 35);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.FireProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.NecroProtection, 20, 20);

            SetSkill(SkillName.Tactics, 80.0, 90.0);
            SetSkill(SkillName.Anatomy, 80.0, 90.0);
            SetSkill(SkillName.Swords, 80.0, 90.0);
            SetSkill(SkillName.Macing, 80.0, 90.0);
            SetSkill(SkillName.Fencing, 80.0, 90.0);
            SetSkill(SkillName.Wrestling, 80.0, 90.0);
            SetSkill(SkillName.Parry, 65.0, 75.0);
            SetSkill(SkillName.MagicResist, 80.0, 90.0);
            SetSkill(SkillName.DetectHidden, 40.0, 50.0);
            SetSkill(SkillName.Magery, 50.0, 60.0);
            SetSkill(SkillName.EvalInt, 80.0, 90.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 43;
        }

        public override string DefaultName => "a flaming skeleton";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluGhost : BaseCreature
    {
        [Constructible]
        public ZuluGhost() : base(AIType.AI_Melee)
        {
            Body = 970;
            BaseSoundID = 0x183;

            SetStr(75);
            SetDex(40);
            SetInt(15);
            SetHits(100);
            SetMana(15);
            SetStam(40);

            SetDamage(5, 15);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 9990, 9990);
            AddMobZuluModifier(ZuluMod.NecroProtection, 40, 40);

            SetSkill(SkillName.Tactics, 70.0, 80.0);
            SetSkill(SkillName.Anatomy, 55.0, 65.0);
            SetSkill(SkillName.Swords, 55.0, 65.0);
            SetSkill(SkillName.Macing, 55.0, 65.0);
            SetSkill(SkillName.Fencing, 55.0, 65.0);
            SetSkill(SkillName.Wrestling, 55.0, 65.0);
            SetSkill(SkillName.Parry, 30.0, 40.0);
            SetSkill(SkillName.MagicResist, 30.0, 40.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 21;
        }

        public override string DefaultName => "a ghost";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluGhostlyhorse : BaseCreature
    {
        [Constructible]
        public ZuluGhostlyhorse() : base(AIType.AI_Mage)
        {
            Body = 115;
            BaseSoundID = 0xAD;

            SetStr(200);
            SetDex(180);
            SetInt(125);
            SetHits(200);
            SetMana(125);
            SetStam(150);

            SetDamage(8, 25);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 9990, 9990);
            AddMobZuluModifier(ZuluMod.FireProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.WaterProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.AirProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.NecroProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.EarthProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 3, 3);

            SetSkill(SkillName.Tactics, 100.0, 110.0);
            SetSkill(SkillName.Anatomy, 100.0, 110.0);
            SetSkill(SkillName.Swords, 100.0, 110.0);
            SetSkill(SkillName.Macing, 100.0, 110.0);
            SetSkill(SkillName.Fencing, 100.0, 110.0);
            SetSkill(SkillName.Wrestling, 100.0, 110.0);
            SetSkill(SkillName.Parry, 100.0, 110.0);
            SetSkill(SkillName.MagicResist, 100.0, 110.0);
            SetSkill(SkillName.DetectHidden, 100.0, 110.0);
            SetSkill(SkillName.Magery, 80.0, 90.0);
            SetSkill(SkillName.EvalInt, 70.0, 80.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 58;
            MinTameSkill = 135;
        }

        public override string DefaultName => "a ghostly horse";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluGhostlyostard : BaseCreature
    {
        [Constructible]
        public ZuluGhostlyostard() : base(AIType.AI_Mage)
        {
            Body = 171;
            BaseSoundID = 0xB7;

            SetStr(300);
            SetDex(250);
            SetInt(125);
            SetHits(300);
            SetMana(125);
            SetStam(600);

            SetDamage(12, 35);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 9990, 9990);
            AddMobZuluModifier(ZuluMod.FireProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.WaterProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.AirProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.NecroProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.EarthProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 3, 3);

            SetSkill(SkillName.Tactics, 100.0, 110.0);
            SetSkill(SkillName.Anatomy, 100.0, 110.0);
            SetSkill(SkillName.Swords, 100.0, 110.0);
            SetSkill(SkillName.Macing, 100.0, 110.0);
            SetSkill(SkillName.Fencing, 100.0, 110.0);
            SetSkill(SkillName.Wrestling, 100.0, 110.0);
            SetSkill(SkillName.Parry, 100.0, 110.0);
            SetSkill(SkillName.MagicResist, 100.0, 110.0);
            SetSkill(SkillName.DetectHidden, 100.0, 110.0);
            SetSkill(SkillName.Magery, 80.0, 90.0);
            SetSkill(SkillName.EvalInt, 70.0, 80.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 58;
            MinTameSkill = 145;
        }

        public override string DefaultName => "a ghostly ostard";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluLiche : BaseCreature
    {
        [Constructible]
        public ZuluLiche() : base(AIType.AI_Mage)
        {
            Body = 24;
            BaseSoundID = 0x1A1;

            SetStr(200);
            SetDex(600);
            SetInt(200);
            SetHits(300);
            SetMana(1000);
            SetStam(600);

            SetDamage(8, 25);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.NecroProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 3, 3);

            SetSkill(SkillName.Tactics, 65.0, 75.0);
            SetSkill(SkillName.Anatomy, 65.0, 75.0);
            SetSkill(SkillName.Swords, 65.0, 75.0);
            SetSkill(SkillName.Macing, 65.0, 75.0);
            SetSkill(SkillName.Fencing, 65.0, 75.0);
            SetSkill(SkillName.Wrestling, 65.0, 75.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 1090.0, 1100.0);
            SetSkill(SkillName.DetectHidden, 40.0, 50.0);
            SetSkill(SkillName.Magery, 100.0, 110.0);
            SetSkill(SkillName.EvalInt, 90.0, 100.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 80;
        }

        public override string DefaultName => "a liche";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluLichelord : BaseCreature
    {
        [Constructible]
        public ZuluLichelord() : base(AIType.AI_Mage)
        {
            Body = 24;
            Hue = 0x4631;

            SetStr(450);
            SetDex(85);
            SetInt(600);
            SetHits(450);
            SetMana(600);
            SetStam(85);

            SetDamage(12, 35);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.NecroProtection, 80, 80);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 6, 6);

            SetSkill(SkillName.Tactics, 60.0, 70.0);
            SetSkill(SkillName.Macing, 115.0, 125.0);
            SetSkill(SkillName.MagicResist, 90.0, 100.0);
            SetSkill(SkillName.Magery, 110.0, 120.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 20;
        }

        public override string DefaultName => "a Liche Lord";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluMagusboneknight : BaseCreature
    {
        [Constructible]
        public ZuluMagusboneknight() : base(AIType.AI_Melee)
        {
            Body = 57;
            Hue = 0x455;

            SetStr(600);
            SetDex(600);
            SetInt(100);
            SetHits(1200);
            SetMana(100);
            SetStam(1200);

            SetDamage(18, 50);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 10, 10);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Swords, 95.0, 105.0);
            SetSkill(SkillName.MagicResist, 110.0, 120.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 24;
        }

        public override string DefaultName => "a Magus Bone Knight";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluMaguszombie : BaseCreature
    {
        [Constructible]
        public ZuluMaguszombie() : base(AIType.AI_Melee)
        {
            Body = 400;
            Hue = 0x599;

            SetStr(450);
            SetDex(450);
            SetInt(450);
            SetHits(1500);
            SetMana(450);
            SetStam(450);

            SetDamage(12, 35);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 120.0, 130.0);
            SetSkill(SkillName.Macing, 120.0, 130.0);
            SetSkill(SkillName.MagicResist, 80.0, 90.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 18;
        }

        public override string DefaultName => "a reanimated villager";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluMummy : BaseCreature
    {
        [Constructible]
        public ZuluMummy() : base(AIType.AI_Melee)
        {
            Body = 3;
            Hue = 0x498;

            SetStr(250);
            SetDex(50);
            SetInt(25);
            SetHits(280);
            SetMana(25);
            SetStam(50);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.FireProtection, 20, 20);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Macing, 140.0, 150.0);
            SetSkill(SkillName.MagicResist, 70.0, 80.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 16;
        }

        public override string DefaultName => "a mummy";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluRottenundead : BaseCreature
    {
        [Constructible]
        public ZuluRottenundead() : base(AIType.AI_Melee)
        {
            Body = 31;
            Hue = 0x500;
            BaseSoundID = 0x3A1;

            SetStr(500);
            SetDex(400);
            SetInt(100);
            SetHits(3000);
            SetMana(100);
            SetStam(600);

            SetDamage(18, 50);
            z_Physical_DD = 50;
            z_Poison_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.NecroProtection, 80, 80);
            AddMobZuluModifier(ZuluMod.EarthProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 6, 6);

            SetSkill(SkillName.Tactics, 100.0, 110.0);
            SetSkill(SkillName.Anatomy, 100.0, 110.0);
            SetSkill(SkillName.Swords, 100.0, 110.0);
            SetSkill(SkillName.Macing, 100.0, 110.0);
            SetSkill(SkillName.Fencing, 100.0, 110.0);
            SetSkill(SkillName.Wrestling, 100.0, 110.0);
            SetSkill(SkillName.Parry, 100.0, 110.0);
            SetSkill(SkillName.MagicResist, 100.0, 110.0);
            SetSkill(SkillName.DetectHidden, 100.0, 110.0);
            SetSkill(SkillName.Poisoning, 130.0, 140.0);

            Fame = 35000;
            Karma = -35000;
            VirtualArmor = 58;
        }

        public override string DefaultName => "a rotten undead";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluSkeleton : BaseCreature
    {
        [Constructible]
        public ZuluSkeleton() : base(AIType.AI_Melee)
        {
            Body = 50;
            Hue = 0x83F8;
            BaseSoundID = 0x1C8;

            SetStr(90);
            SetDex(90);
            SetInt(30);
            SetHits(150);
            SetMana(15);
            SetStam(600);

            SetDamage(5, 15);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 10, 10);

            SetSkill(SkillName.Tactics, 70.0, 80.0);
            SetSkill(SkillName.Anatomy, 55.0, 65.0);
            SetSkill(SkillName.Swords, 55.0, 65.0);
            SetSkill(SkillName.Macing, 55.0, 65.0);
            SetSkill(SkillName.Fencing, 55.0, 65.0);
            SetSkill(SkillName.Wrestling, 55.0, 65.0);
            SetSkill(SkillName.Parry, 30.0, 40.0);
            SetSkill(SkillName.MagicResist, 30.0, 40.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 21;
        }

        public override string DefaultName => "a skeleton";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluSkeleton2 : BaseCreature
    {
        [Constructible]
        public ZuluSkeleton2() : base(AIType.AI_Melee)
        {
            Body = 56;
            Hue = 0x83F8;
            BaseSoundID = 0x1C8;

            SetStr(150);
            SetDex(100);
            SetInt(100);
            SetHits(200);
            SetMana(0);
            SetStam(1200);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 20, 20);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Anatomy, 90.0, 100.0);
            SetSkill(SkillName.Swords, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.Fencing, 90.0, 100.0);
            SetSkill(SkillName.Wrestling, 90.0, 100.0);
            SetSkill(SkillName.Parry, 110.0, 120.0);
            SetSkill(SkillName.MagicResist, 110.0, 120.0);
            SetSkill(SkillName.DetectHidden, 60.0, 70.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 64;
        }

        public override string DefaultName => "a skeleton assassin";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluSkeleton3 : BaseCreature
    {
        [Constructible]
        public ZuluSkeleton3() : base(AIType.AI_Melee)
        {
            Body = 50;
            Hue = 0x83F8;
            BaseSoundID = 0x1C8;

            SetStr(75);
            SetDex(75);
            SetInt(15);
            SetHits(100);
            SetMana(15);
            SetStam(600);

            SetDamage(5, 15);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 10, 10);

            SetSkill(SkillName.Tactics, 70.0, 80.0);
            SetSkill(SkillName.Anatomy, 55.0, 65.0);
            SetSkill(SkillName.Swords, 55.0, 65.0);
            SetSkill(SkillName.Macing, 55.0, 65.0);
            SetSkill(SkillName.Fencing, 55.0, 65.0);
            SetSkill(SkillName.Wrestling, 55.0, 65.0);
            SetSkill(SkillName.Parry, 30.0, 40.0);
            SetSkill(SkillName.MagicResist, 30.0, 40.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 21;
        }

        public override string DefaultName => "a skeleton";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluUndeadcovetous1 : BaseCreature
    {
        [Constructible]
        public ZuluUndeadcovetous1() : base(AIType.AI_Melee)
        {
            Body = 400;
            Hue = 0x516;

            SetStr(400);
            SetDex(250);
            SetInt(200);
            SetHits(400);
            SetMana(100);
            SetStam(50);

            SetDamage(12, 35);
            z_Physical_DD = 100;

            SetSkill(SkillName.Tactics, 110.0, 120.0);
            SetSkill(SkillName.Swords, 130.0, 140.0);
            SetSkill(SkillName.MagicResist, 90.0, 100.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 20;
        }

        public override string DefaultName => "Undead Covetous Guard";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluUndeadcovetous2 : BaseCreature
    {
        [Constructible]
        public ZuluUndeadcovetous2() : base(AIType.AI_Melee)
        {
            Body = 400;
            Hue = 0x516;

            SetStr(400);
            SetDex(250);
            SetInt(200);
            SetHits(400);
            SetMana(100);
            SetStam(50);

            SetDamage(12, 35);
            z_Physical_DD = 100;

            SetSkill(SkillName.Tactics, 110.0, 120.0);
            SetSkill(SkillName.Swords, 130.0, 140.0);
            SetSkill(SkillName.Parry, 120.0, 130.0);
            SetSkill(SkillName.MagicResist, 90.0, 100.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 63;
        }

        public override string DefaultName => "Undead Covetous Elite Guard";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluUndeadcovetous3 : BaseCreature
    {
        [Constructible]
        public ZuluUndeadcovetous3() : base(AIType.AI_Archer)
        {
            Body = 400;
            Hue = 0x485;

            SetStr(300);
            SetDex(350);
            SetInt(60);
            SetHits(300);
            SetMana(0);
            SetStam(50);

            SetDamage(12, 35);
            z_Physical_DD = 100;

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 80.0, 90.0);
            SetSkill(SkillName.DetectHidden, 90.0, 100.0);
            SetSkill(SkillName.Archery, 120.0, 130.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 18;
        }

        public override string DefaultName => "Undead Covetous Guard";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluUndeadcovetous4 : BaseCreature
    {
        [Constructible]
        public ZuluUndeadcovetous4() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x1;

            SetStr(200);
            SetDex(150);
            SetInt(1000);
            SetHits(200);
            SetMana(1000);
            SetStam(50);

            SetDamage(8, 25);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 110.0, 120.0);
            SetSkill(SkillName.Magery, 130.0, 140.0);
            SetSkill(SkillName.EvalInt, 110.0, 120.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 24;
        }

        public override string DefaultName => "Undead Covetous Priest";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluUndeadflayer : BaseCreature
    {
        [Constructible]
        public ZuluUndeadflayer() : base(AIType.AI_Mage)
        {
            Body = 24;
            Hue = 0x488;
            BaseSoundID = 0x3EE;

            SetStr(150);
            SetDex(1000);
            SetInt(10000);
            SetHits(5000);
            SetMana(10000);
            SetStam(10000);

            SetDamage(8, 25);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.FireProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.WaterProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.AirProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 100, 100);
            AddMobZuluModifier(ZuluMod.EarthProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 8, 8);

            SetSkill(SkillName.Tactics, 120.0, 130.0);
            SetSkill(SkillName.Anatomy, 120.0, 130.0);
            SetSkill(SkillName.Swords, 120.0, 130.0);
            SetSkill(SkillName.Macing, 120.0, 130.0);
            SetSkill(SkillName.Fencing, 120.0, 130.0);
            SetSkill(SkillName.Wrestling, 120.0, 130.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 120.0, 130.0);
            SetSkill(SkillName.DetectHidden, 90.0, 100.0);
            SetSkill(SkillName.Magery, 190.0, 200.0);
            SetSkill(SkillName.EvalInt, 190.0, 200.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 59;
        }

        public override string DefaultName => "an Undead Flayer";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluUndeadmagusguardian : BaseCreature
    {
        [Constructible]
        public ZuluUndeadmagusguardian() : base(AIType.AI_Melee)
        {
            Body = 554;
            Hue = 0x516;

            SetStr(400);
            SetDex(250);
            SetInt(200);
            SetHits(400);
            SetMana(100);
            SetStam(50);

            SetDamage(12, 35);
            z_Physical_DD = 100;

            SetSkill(SkillName.Tactics, 110.0, 120.0);
            SetSkill(SkillName.Swords, 130.0, 140.0);
            SetSkill(SkillName.MagicResist, 90.0, 100.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 20;
        }

        public override string DefaultName => "Undead Magus Jail Guardian";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluUndeadpirate : BaseCreature
    {
        [Constructible]
        public ZuluUndeadpirate() : base(AIType.AI_Melee)
        {
            Body = 400;

            SetStr(110);
            SetDex(110);
            SetInt(20);
            SetHits(110);
            SetMana(100);
            SetStam(100);

            SetDamage(5, 15);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Swords, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 20.0, 30.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 6;

            EquipItem(new Skirt(0x25));
            EquipItem(new FancyDress(0x59B));
            EquipItem(new ShortPants(0x25));
            EquipItem(new Doublet(0x25));
        }

        public override string DefaultName => "Undead pirate";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluWraith : BaseCreature
    {
        [Constructible]
        public ZuluWraith() : base(AIType.AI_Mage)
        {
            Body = 26;
            Hue = 0x4001;
            BaseSoundID = 0x183;

            SetStr(750);
            SetDex(750);
            SetInt(500);
            SetHits(3000);
            SetMana(2500);
            SetStam(1500);

            SetDamage(18, 50);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 9990, 9990);
            AddMobZuluModifier(ZuluMod.FireProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.WaterProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.AirProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.EarthProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 2, 2);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Anatomy, 90.0, 100.0);
            SetSkill(SkillName.Swords, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.Fencing, 90.0, 100.0);
            SetSkill(SkillName.Wrestling, 90.0, 100.0);
            SetSkill(SkillName.Parry, 60.0, 70.0);
            SetSkill(SkillName.MagicResist, 80.0, 90.0);
            SetSkill(SkillName.DetectHidden, 70.0, 80.0);
            SetSkill(SkillName.Magery, 140.0, 150.0);
            SetSkill(SkillName.EvalInt, 110.0, 120.0);
            SetSkill(SkillName.Hiding, 90.0, 100.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 41;
        }

        public override string DefaultName => "a wraith";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluZombie : BaseCreature
    {
        [Constructible]
        public ZuluZombie() : base(AIType.AI_Melee)
        {
            Body = 3;
            BaseSoundID = 0x1DC;

            SetStr(80);
            SetDex(80);
            SetInt(15);
            SetHits(100);
            SetMana(15);
            SetStam(40);

            SetDamage(5, 15);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 10, 10);

            SetSkill(SkillName.Tactics, 70.0, 80.0);
            SetSkill(SkillName.Anatomy, 55.0, 65.0);
            SetSkill(SkillName.Swords, 55.0, 65.0);
            SetSkill(SkillName.Macing, 55.0, 65.0);
            SetSkill(SkillName.Fencing, 55.0, 65.0);
            SetSkill(SkillName.Wrestling, 55.0, 65.0);
            SetSkill(SkillName.Parry, 30.0, 40.0);
            SetSkill(SkillName.MagicResist, 30.0, 40.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 21;
        }

        public override string DefaultName => "a zombie";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }
}
