using ModernUO.Serialization;
using Server.Items;

namespace Server.Mobiles
{
    // Zulu Hotel — Daemons Evil NPCs
    // Auto-generated from npcdesc_zhbr.cfg (11 NPCs)
    // Source: POL 98 Zulu Hotel shard

    [SerializationGenerator(0, false)]
    public partial class ZuluBalrog : BaseCreature
    {
        [Constructible]
        public ZuluBalrog() : base(AIType.AI_Mage)
        {
            Body = 9;
            Hue = 0x488;
            BaseSoundID = 0x2BD;

            SetStr(250);
            SetDex(900);
            SetInt(3000);
            SetHits(6000);
            SetMana(50000);
            SetStam(20000);

            SetDamage(8, 25);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.FireProtection, 50, 50);
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
            SetSkill(SkillName.Parry, 115.0, 125.0);
            SetSkill(SkillName.MagicResist, 120.0, 130.0);
            SetSkill(SkillName.DetectHidden, 115.0, 125.0);
            SetSkill(SkillName.Magery, 120.0, 130.0);
            SetSkill(SkillName.EvalInt, 120.0, 130.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 67;
        }

        public override string DefaultName => "The Balrog";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBalron : BaseCreature
    {
        [Constructible]
        public ZuluBalron() : base(AIType.AI_Mage)
        {
            Body = 9;
            Hue = 0x4001;
            BaseSoundID = 0x2BD;

            SetStr(250);
            SetDex(900);
            SetInt(4000);
            SetHits(6000);
            SetMana(50000);
            SetStam(10000);

            SetDamage(8, 25);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.FireProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.WaterProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.NecroProtection, 100, 100);
            AddMobZuluModifier(ZuluMod.EarthProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 6, 6);

            SetSkill(SkillName.Tactics, 120.0, 130.0);
            SetSkill(SkillName.Anatomy, 120.0, 130.0);
            SetSkill(SkillName.Swords, 120.0, 130.0);
            SetSkill(SkillName.Macing, 120.0, 130.0);
            SetSkill(SkillName.Fencing, 120.0, 130.0);
            SetSkill(SkillName.Wrestling, 120.0, 130.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 120.0, 130.0);
            SetSkill(SkillName.DetectHidden, 110.0, 120.0);
            SetSkill(SkillName.Magery, 120.0, 130.0);
            SetSkill(SkillName.EvalInt, 120.0, 130.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 59;
        }

        public override string DefaultName => "a Balron";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.FilthyRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluDaemon : BaseCreature
    {
        [Constructible]
        public ZuluDaemon() : base(AIType.AI_Mage)
        {
            Body = 9;
            Hue = 0x83F8;
            BaseSoundID = 0x16A;

            SetStr(400);
            SetDex(800);
            SetInt(400);
            SetHits(1000);
            SetMana(800);
            SetStam(800);

            SetDamage(12, 35);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.FireProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 5, 5);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Anatomy, 90.0, 100.0);
            SetSkill(SkillName.Swords, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.Fencing, 90.0, 100.0);
            SetSkill(SkillName.Wrestling, 90.0, 100.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 90.0, 100.0);
            SetSkill(SkillName.DetectHidden, 80.0, 90.0);
            SetSkill(SkillName.Magery, 140.0, 150.0);
            SetSkill(SkillName.EvalInt, 140.0, 150.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 53;
        }

        public override string DefaultName => "a Daemon";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluDaemon1 : BaseCreature
    {
        [Constructible]
        public ZuluDaemon1() : base(AIType.AI_Melee)
        {
            Body = 9;
            Hue = 0x83F8;
            BaseSoundID = 0x16A;

            SetStr(200);
            SetDex(300);
            SetInt(300);
            SetHits(600);
            SetMana(305);
            SetStam(80);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Macing, 110.0, 120.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 90.0, 100.0);
            SetSkill(SkillName.Magery, 90.0, 100.0);
            SetSkill(SkillName.EvalInt, 90.0, 100.0);

            Fame = 2500;
            Karma = -2500;
            VirtualArmor = 53;
        }

        public override string DefaultName => "Daemon";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluDaemongatekeeper : BaseCreature
    {
        [Constructible]
        public ZuluDaemongatekeeper() : base(AIType.AI_Melee)
        {
            Body = 10;
            Hue = 0x7B6;
            BaseSoundID = 0x16A;

            SetStr(1100);
            SetDex(1000);
            SetInt(300);
            SetHits(6000);
            SetMana(0);
            SetStam(4000);

            SetDamage(25, 80);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.FireProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.WaterProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.EarthProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 8, 8);

            SetSkill(SkillName.Tactics, 115.0, 125.0);
            SetSkill(SkillName.Anatomy, 150.0, 160.0);
            SetSkill(SkillName.Swords, 150.0, 160.0);
            SetSkill(SkillName.Macing, 150.0, 160.0);
            SetSkill(SkillName.Fencing, 150.0, 160.0);
            SetSkill(SkillName.Wrestling, 150.0, 160.0);
            SetSkill(SkillName.Parry, 115.0, 125.0);
            SetSkill(SkillName.MagicResist, 140.0, 150.0);
            SetSkill(SkillName.DetectHidden, 105.0, 115.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 71;
        }

        public override string DefaultName => "Yakra, the Gatekeeper";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.FilthyRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluDaemonguard : BaseCreature
    {
        [Constructible]
        public ZuluDaemonguard() : base(AIType.AI_Melee)
        {
            Body = 10;
            Hue = 0x496;
            BaseSoundID = 0x16A;

            SetStr(1000);
            SetDex(1000);
            SetInt(150);
            SetHits(4000);
            SetMana(0);
            SetStam(2000);

            SetDamage(25, 80);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.WaterProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.AirProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.EarthProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 6, 6);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Anatomy, 140.0, 150.0);
            SetSkill(SkillName.Swords, 140.0, 150.0);
            SetSkill(SkillName.Macing, 140.0, 150.0);
            SetSkill(SkillName.Fencing, 140.0, 150.0);
            SetSkill(SkillName.Wrestling, 140.0, 150.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 115.0, 125.0);
            SetSkill(SkillName.DetectHidden, 100.0, 110.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 58;
        }

        public override string DefaultName => "a Daemon Prison Guard";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluDaemonknight : BaseCreature
    {
        [Constructible]
        public ZuluDaemonknight() : base(AIType.AI_Melee)
        {
            Body = 10;
            Hue = 0x83F8;
            BaseSoundID = 0x16A;

            SetStr(500);
            SetDex(1000);
            SetInt(150);
            SetHits(2500);
            SetMana(0);
            SetStam(2000);

            SetDamage(18, 50);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.FireProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.NecroProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 6, 6);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Anatomy, 140.0, 150.0);
            SetSkill(SkillName.Swords, 140.0, 150.0);
            SetSkill(SkillName.Macing, 140.0, 150.0);
            SetSkill(SkillName.Fencing, 140.0, 150.0);
            SetSkill(SkillName.Wrestling, 140.0, 150.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 115.0, 125.0);
            SetSkill(SkillName.DetectHidden, 90.0, 100.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 58;
        }

        public override string DefaultName => "a Daemon Knight";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluHellguardian : BaseCreature
    {
        [Constructible]
        public ZuluHellguardian() : base(AIType.AI_Mage)
        {
            Body = 86;
            Hue = 0x494;
            BaseSoundID = 0x1DC;

            SetStr(1500);
            SetDex(2000);
            SetInt(200);
            SetHits(3000);
            SetMana(0);
            SetStam(2000);

            SetDamage(25, 80);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 100, 100);
            AddMobZuluModifier(ZuluMod.WaterProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 5, 5);

            SetSkill(SkillName.Tactics, 120.0, 130.0);
            SetSkill(SkillName.Anatomy, 140.0, 150.0);
            SetSkill(SkillName.Swords, 140.0, 150.0);
            SetSkill(SkillName.Macing, 140.0, 150.0);
            SetSkill(SkillName.Fencing, 140.0, 150.0);
            SetSkill(SkillName.Wrestling, 140.0, 150.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 115.0, 125.0);
            SetSkill(SkillName.DetectHidden, 105.0, 115.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 58;
        }

        public override string DefaultName => "a Hell Guardian";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluImp : BaseCreature
    {
        [Constructible]
        public ZuluImp() : base(AIType.AI_Mage)
        {
            Body = 39;
            Hue = 0x7B5;
            BaseSoundID = 0x1AB;

            SetStr(75);
            SetDex(50);
            SetInt(50);
            SetHits(300);
            SetMana(50);
            SetStam(600);

            SetDamage(5, 15);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.FireProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.NecroProtection, 10, 10);

            SetSkill(SkillName.Tactics, 65.0, 75.0);
            SetSkill(SkillName.Anatomy, 65.0, 75.0);
            SetSkill(SkillName.Swords, 65.0, 75.0);
            SetSkill(SkillName.Macing, 65.0, 75.0);
            SetSkill(SkillName.Fencing, 65.0, 75.0);
            SetSkill(SkillName.Wrestling, 65.0, 75.0);
            SetSkill(SkillName.Parry, 40.0, 50.0);
            SetSkill(SkillName.MagicResist, 90.0, 100.0);
            SetSkill(SkillName.DetectHidden, 40.0, 50.0);
            SetSkill(SkillName.Magery, 40.0, 50.0);
            SetSkill(SkillName.EvalInt, 65.0, 75.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 36;
            MinTameSkill = 100;
        }

        public override string DefaultName => "an imp";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluMinordaemon : BaseCreature
    {
        [Constructible]
        public ZuluMinordaemon() : base(AIType.AI_Melee)
        {
            Body = 4;
            Hue = 0x494;
            BaseSoundID = 0x179;

            SetStr(150);
            SetDex(200);
            SetInt(100);
            SetHits(500);
            SetMana(0);
            SetStam(1200);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.FireProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.NecroProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 2, 2);

            SetSkill(SkillName.Tactics, 80.0, 90.0);
            SetSkill(SkillName.Anatomy, 80.0, 90.0);
            SetSkill(SkillName.Swords, 80.0, 90.0);
            SetSkill(SkillName.Macing, 80.0, 90.0);
            SetSkill(SkillName.Fencing, 80.0, 90.0);
            SetSkill(SkillName.Wrestling, 80.0, 90.0);
            SetSkill(SkillName.Parry, 65.0, 75.0);
            SetSkill(SkillName.MagicResist, 90.0, 100.0);
            SetSkill(SkillName.DetectHidden, 50.0, 60.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 45;
        }

        public override string DefaultName => "a minor daemon";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluSoultaker : BaseCreature
    {
        [Constructible]
        public ZuluSoultaker() : base(AIType.AI_Mage)
        {
            Body = 10;
            Hue = 0x7B2;
            BaseSoundID = 0x16A;

            SetStr(500);
            SetDex(650);
            SetInt(5000);
            SetHits(3000);
            SetMana(10000);
            SetStam(10000);

            SetDamage(18, 50);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 80, 80);
            AddMobZuluModifier(ZuluMod.FireProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.NecroProtection, 100, 100);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 7, 7);

            SetSkill(SkillName.Tactics, 125.0, 135.0);
            SetSkill(SkillName.Anatomy, 125.0, 135.0);
            SetSkill(SkillName.Swords, 125.0, 135.0);
            SetSkill(SkillName.Macing, 125.0, 135.0);
            SetSkill(SkillName.Fencing, 125.0, 135.0);
            SetSkill(SkillName.Wrestling, 125.0, 135.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 120.0, 130.0);
            SetSkill(SkillName.DetectHidden, 105.0, 115.0);
            SetSkill(SkillName.Magery, 140.0, 150.0);
            SetSkill(SkillName.EvalInt, 140.0, 150.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 59;
        }

        public override string DefaultName => "Duriel, the Soultaker";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }
}
