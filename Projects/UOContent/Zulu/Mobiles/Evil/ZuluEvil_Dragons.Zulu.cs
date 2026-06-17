using ModernUO.Serialization;
using Server.Items;

namespace Server.Mobiles
{
    // Zulu Hotel — Dragons Evil NPCs
    // Auto-generated from npcdesc_zhbr.cfg (41 NPCs)
    // Source: POL 98 Zulu Hotel shard

    [SerializationGenerator(0, false)]
    public partial class ZuluAirdrake : BaseCreature
    {
        [Constructible]
        public ZuluAirdrake() : base(AIType.AI_Mage)
        {
            Body = 61;
            Hue = 0x492;
            BaseSoundID = 0x467;

            SetStr(200);
            SetDex(150);
            SetInt(100);
            SetHits(400);
            SetMana(0);
            SetStam(600);

            SetDamage(8, 25);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.FireProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.AirProtection, 80, 80);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 3, 3);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Anatomy, 100.0, 110.0);
            SetSkill(SkillName.Swords, 100.0, 110.0);
            SetSkill(SkillName.Macing, 100.0, 110.0);
            SetSkill(SkillName.Fencing, 100.0, 110.0);
            SetSkill(SkillName.Wrestling, 100.0, 110.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 110.0, 120.0);
            SetSkill(SkillName.DetectHidden, 105.0, 115.0);
            SetSkill(SkillName.Magery, 80.0, 90.0);
            SetSkill(SkillName.EvalInt, 70.0, 80.0);

            Fame = 35000;
            Karma = -35000;
            VirtualArmor = 57;
            MinTameSkill = 120;
        }

        public override string DefaultName => "an air drake";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.FilthyRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluAmoebadragon : BaseCreature
    {
        [Constructible]
        public ZuluAmoebadragon() : base(AIType.AI_Melee)
        {
            Body = 206;
            Hue = 0x455;
            BaseSoundID = 0x28E;

            SetStr(300);
            SetDex(200);
            SetInt(50);
            SetHits(300);
            SetMana(50);
            SetStam(600);

            SetDamage(12, 35);
            z_Physical_DD = 50;
            z_Poison_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.NecroProtection, 30, 30);

            SetSkill(SkillName.Tactics, 110.0, 120.0);
            SetSkill(SkillName.Anatomy, 110.0, 120.0);
            SetSkill(SkillName.Swords, 110.0, 120.0);
            SetSkill(SkillName.Macing, 110.0, 120.0);
            SetSkill(SkillName.Fencing, 110.0, 120.0);
            SetSkill(SkillName.Wrestling, 110.0, 120.0);
            SetSkill(SkillName.Parry, 70.0, 80.0);
            SetSkill(SkillName.MagicResist, 50.0, 60.0);
            SetSkill(SkillName.DetectHidden, 70.0, 80.0);
            SetSkill(SkillName.Poisoning, 80.0, 90.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 38;
            MinTameSkill = 110;
        }

        public override string DefaultName => "an amoeba dragon";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluAncientundeaddragon : BaseCreature
    {
        [Constructible]
        public ZuluAncientundeaddragon() : base(AIType.AI_Mage)
        {
            Body = 59;
            Hue = 0x7B2;
            BaseSoundID = 0x2C2;

            SetStr(250);
            SetDex(1000);
            SetInt(5000);
            SetHits(15000);
            SetMana(20000);
            SetStam(20000);

            SetDamage(8, 25);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.WaterProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.AirProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.NecroProtection, 100, 100);
            AddMobZuluModifier(ZuluMod.EarthProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 8, 8);

            SetSkill(SkillName.Tactics, 120.0, 130.0);
            SetSkill(SkillName.Anatomy, 120.0, 130.0);
            SetSkill(SkillName.Swords, 120.0, 130.0);
            SetSkill(SkillName.Macing, 120.0, 130.0);
            SetSkill(SkillName.Fencing, 120.0, 130.0);
            SetSkill(SkillName.Wrestling, 120.0, 130.0);
            SetSkill(SkillName.Parry, 115.0, 125.0);
            SetSkill(SkillName.MagicResist, 140.0, 150.0);
            SetSkill(SkillName.DetectHidden, 125.0, 135.0);
            SetSkill(SkillName.Magery, 190.0, 200.0);
            SetSkill(SkillName.EvalInt, 190.0, 200.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 71;
            MinTameSkill = 155;
        }

        public override string DefaultName => "The Ancient Undead Dragon";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBabyfrostdragon : BaseCreature
    {
        [Constructible]
        public ZuluBabyfrostdragon() : base(AIType.AI_Mage)
        {
            Body = 6;
            Hue = 0x498;
            BaseSoundID = 0x1AB;

            SetStr(100);
            SetDex(600);
            SetInt(50);
            SetHits(200);
            SetMana(50);
            SetStam(600);

            SetDamage(5, 15);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.FireProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.WaterProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.EarthProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 3, 3);

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
            MinTameSkill = 105;
        }

        public override string DefaultName => "a baby frost dragon";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBrotherhooddragon : BaseCreature
    {
        [Constructible]
        public ZuluBrotherhooddragon() : base(AIType.AI_Mage)
        {
            Body = 59;
            Hue = 0x498;
            BaseSoundID = 0x2C2;

            SetStr(500);
            SetDex(600);
            SetInt(100);
            SetHits(2000);
            SetMana(100);
            SetStam(600);

            SetDamage(18, 50);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.WaterProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.AirProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.HollyProtection, 40, 40);
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

            Fame = 35000;
            Karma = -35000;
            VirtualArmor = 58;
        }

        public override string DefaultName => "The Brotherhood Dragon";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.FilthyRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluDesertdragon : BaseCreature
    {
        [Constructible]
        public ZuluDesertdragon() : base(AIType.AI_Mage)
        {
            Body = 206;
            Hue = 0x497;
            BaseSoundID = 0x1A6;

            SetStr(190);
            SetDex(150);
            SetInt(30);
            SetHits(350);
            SetMana(20);
            SetStam(80);

            SetDamage(8, 25);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Macing, 120.0, 130.0);
            SetSkill(SkillName.MagicResist, 90.0, 100.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 20;
            MinTameSkill = 120;
        }

        public override string DefaultName => "a desert dragon";

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluDesertdrake : BaseCreature
    {
        [Constructible]
        public ZuluDesertdrake() : base(AIType.AI_Mage)
        {
            Body = 60;
            Hue = 0x497;
            BaseSoundID = 0x467;

            SetStr(125);
            SetDex(150);
            SetInt(75);
            SetHits(300);
            SetMana(0);
            SetStam(600);

            SetDamage(5, 15);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.NecroProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.EarthProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 3, 3);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Anatomy, 90.0, 100.0);
            SetSkill(SkillName.Swords, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.Fencing, 90.0, 100.0);
            SetSkill(SkillName.Wrestling, 90.0, 100.0);
            SetSkill(SkillName.Parry, 80.0, 90.0);
            SetSkill(SkillName.MagicResist, 70.0, 80.0);
            SetSkill(SkillName.DetectHidden, 105.0, 115.0);
            SetSkill(SkillName.Magery, 80.0, 90.0);
            SetSkill(SkillName.EvalInt, 70.0, 80.0);

            Fame = 35000;
            Karma = -35000;
            VirtualArmor = 46;
            MinTameSkill = 120;
        }

        public override string DefaultName => "a desert drake";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluDragon1 : BaseCreature
    {
        [Constructible]
        public ZuluDragon1() : base(AIType.AI_Mage)
        {
            Body = 12;
            BaseSoundID = 0x2C2;

            SetStr(350);
            SetDex(600);
            SetInt(100);
            SetHits(600);
            SetMana(100);
            SetStam(600);

            SetDamage(12, 35);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.EarthProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 4, 4);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Anatomy, 90.0, 100.0);
            SetSkill(SkillName.Swords, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.Fencing, 90.0, 100.0);
            SetSkill(SkillName.Wrestling, 90.0, 100.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 90.0, 100.0);
            SetSkill(SkillName.DetectHidden, 90.0, 100.0);

            Fame = 35000;
            Karma = -35000;
            VirtualArmor = 53;
            MinTameSkill = 120;
        }

        public override string DefaultName => "a dragon";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.FilthyRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluDragon2 : BaseCreature
    {
        [Constructible]
        public ZuluDragon2() : base(AIType.AI_Mage)
        {
            Body = 59;
            BaseSoundID = 0x2C2;

            SetStr(350);
            SetDex(600);
            SetInt(100);
            SetHits(600);
            SetMana(100);
            SetStam(600);

            SetDamage(12, 35);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.EarthProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 4, 4);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Anatomy, 90.0, 100.0);
            SetSkill(SkillName.Swords, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.Fencing, 90.0, 100.0);
            SetSkill(SkillName.Wrestling, 90.0, 100.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 90.0, 100.0);
            SetSkill(SkillName.DetectHidden, 90.0, 100.0);

            Fame = 35000;
            Karma = -35000;
            VirtualArmor = 53;
            MinTameSkill = 120;
        }

        public override string DefaultName => "a dragon";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.FilthyRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluDragonostard : BaseCreature
    {
        [Constructible]
        public ZuluDragonostard() : base(AIType.AI_Mage)
        {
            Body = 218;
            Hue = 0x486;
            BaseSoundID = 0xB7;

            SetStr(225);
            SetDex(200);
            SetInt(75);
            SetHits(225);
            SetMana(0);
            SetStam(600);

            SetDamage(8, 25);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.FireProtection, 30, 30);

            SetSkill(SkillName.Tactics, 70.0, 80.0);
            SetSkill(SkillName.Anatomy, 80.0, 90.0);
            SetSkill(SkillName.Swords, 70.0, 80.0);
            SetSkill(SkillName.Macing, 70.0, 80.0);
            SetSkill(SkillName.Fencing, 70.0, 80.0);
            SetSkill(SkillName.Wrestling, 70.0, 80.0);
            SetSkill(SkillName.Parry, 70.0, 80.0);
            SetSkill(SkillName.MagicResist, 80.0, 90.0);
            SetSkill(SkillName.DetectHidden, 70.0, 80.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 44;
            MinTameSkill = 80;
        }

        public override string DefaultName => "a dragon ostard";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluDrake1 : BaseCreature
    {
        [Constructible]
        public ZuluDrake1() : base(AIType.AI_Mage)
        {
            Body = 60;
            BaseSoundID = 0x467;

            SetStr(100);
            SetDex(150);
            SetInt(50);
            SetHits(200);
            SetMana(0);
            SetStam(600);

            SetDamage(5, 15);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.FireProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.EarthProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 3, 3);

            SetSkill(SkillName.Tactics, 60.0, 70.0);
            SetSkill(SkillName.Anatomy, 60.0, 70.0);
            SetSkill(SkillName.Swords, 60.0, 70.0);
            SetSkill(SkillName.Macing, 60.0, 70.0);
            SetSkill(SkillName.Fencing, 60.0, 70.0);
            SetSkill(SkillName.Wrestling, 60.0, 70.0);
            SetSkill(SkillName.Parry, 60.0, 70.0);
            SetSkill(SkillName.MagicResist, 60.0, 70.0);
            SetSkill(SkillName.DetectHidden, 60.0, 70.0);

            Fame = 35000;
            Karma = -35000;
            VirtualArmor = 37;
            MinTameSkill = 100;
        }

        public override string DefaultName => "a drake";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.FilthyRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluDrake2 : BaseCreature
    {
        [Constructible]
        public ZuluDrake2() : base(AIType.AI_Mage)
        {
            Body = 61;
            BaseSoundID = 0x467;

            SetStr(100);
            SetDex(150);
            SetInt(50);
            SetHits(200);
            SetMana(0);
            SetStam(600);

            SetDamage(5, 15);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.FireProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.EarthProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 3, 3);

            SetSkill(SkillName.Tactics, 60.0, 70.0);
            SetSkill(SkillName.Anatomy, 60.0, 70.0);
            SetSkill(SkillName.Swords, 60.0, 70.0);
            SetSkill(SkillName.Macing, 60.0, 70.0);
            SetSkill(SkillName.Fencing, 60.0, 70.0);
            SetSkill(SkillName.Wrestling, 60.0, 70.0);
            SetSkill(SkillName.Parry, 60.0, 70.0);
            SetSkill(SkillName.MagicResist, 60.0, 70.0);
            SetSkill(SkillName.DetectHidden, 60.0, 70.0);

            Fame = 35000;
            Karma = -35000;
            VirtualArmor = 37;
            MinTameSkill = 100;
        }

        public override string DefaultName => "a drake";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluEarthdrake : BaseCreature
    {
        [Constructible]
        public ZuluEarthdrake() : base(AIType.AI_Mage)
        {
            Body = 60;
            Hue = 0x46E;
            BaseSoundID = 0x467;

            SetStr(400);
            SetDex(170);
            SetInt(100);
            SetHits(400);
            SetMana(0);
            SetStam(600);

            SetDamage(12, 35);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.EarthProtection, 80, 80);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 3, 3);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Anatomy, 100.0, 110.0);
            SetSkill(SkillName.Swords, 100.0, 110.0);
            SetSkill(SkillName.Macing, 100.0, 110.0);
            SetSkill(SkillName.Fencing, 100.0, 110.0);
            SetSkill(SkillName.Wrestling, 100.0, 110.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 110.0, 120.0);
            SetSkill(SkillName.DetectHidden, 105.0, 115.0);
            SetSkill(SkillName.Magery, 80.0, 90.0);
            SetSkill(SkillName.EvalInt, 70.0, 80.0);

            Fame = 35000;
            Karma = -35000;
            VirtualArmor = 57;
            MinTameSkill = 120;
        }

        public override string DefaultName => "an earth drake";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluFirebat : BaseCreature
    {
        [Constructible]
        public ZuluFirebat() : base(AIType.AI_Mage)
        {
            Body = 6;
            Hue = 0xAD4;
            BaseSoundID = 0x2A1;

            SetStr(45);
            SetDex(30);
            SetInt(45);
            SetHits(45);
            SetMana(0);
            SetStam(600);

            SetDamage(5, 15);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.FireProtection, 20, 20);

            SetSkill(SkillName.Tactics, 35.0, 45.0);
            SetSkill(SkillName.Anatomy, 35.0, 45.0);
            SetSkill(SkillName.Swords, 35.0, 45.0);
            SetSkill(SkillName.Macing, 35.0, 45.0);
            SetSkill(SkillName.Fencing, 35.0, 45.0);
            SetSkill(SkillName.Wrestling, 35.0, 45.0);
            SetSkill(SkillName.Parry, 30.0, 40.0);
            SetSkill(SkillName.MagicResist, 35.0, 45.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 22;
            MinTameSkill = 50;
        }

        public override string DefaultName => "a fire bat";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluFirecrow : BaseCreature
    {
        [Constructible]
        public ZuluFirecrow() : base(AIType.AI_Mage)
        {
            Body = 6;
            Hue = 0x486;
            BaseSoundID = 0x82;

            SetStr(45);
            SetDex(50);
            SetInt(45);
            SetHits(45);
            SetMana(0);
            SetStam(600);

            SetDamage(5, 15);
            z_Fire_DD = 100;

            SetSkill(SkillName.Tactics, 35.0, 45.0);
            SetSkill(SkillName.Anatomy, 35.0, 45.0);
            SetSkill(SkillName.Swords, 35.0, 45.0);
            SetSkill(SkillName.Macing, 35.0, 45.0);
            SetSkill(SkillName.Fencing, 35.0, 45.0);
            SetSkill(SkillName.Wrestling, 35.0, 45.0);
            SetSkill(SkillName.Parry, 30.0, 40.0);
            SetSkill(SkillName.MagicResist, 35.0, 45.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 22;
            MinTameSkill = 45;
        }

        public override string DefaultName => "a firecrow";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluFiredrake : BaseCreature
    {
        [Constructible]
        public ZuluFiredrake() : base(AIType.AI_Mage)
        {
            Body = 61;
            Hue = 0x486;
            BaseSoundID = 0x467;

            SetStr(200);
            SetDex(130);
            SetInt(100);
            SetHits(400);
            SetMana(0);
            SetStam(600);

            SetDamage(8, 25);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.FireProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.EarthProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 3, 3);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Anatomy, 100.0, 110.0);
            SetSkill(SkillName.Swords, 100.0, 110.0);
            SetSkill(SkillName.Macing, 100.0, 110.0);
            SetSkill(SkillName.Fencing, 100.0, 110.0);
            SetSkill(SkillName.Wrestling, 100.0, 110.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 110.0, 120.0);
            SetSkill(SkillName.DetectHidden, 105.0, 115.0);
            SetSkill(SkillName.Magery, 80.0, 90.0);
            SetSkill(SkillName.EvalInt, 70.0, 80.0);

            Fame = 35000;
            Karma = -35000;
            VirtualArmor = 57;
            MinTameSkill = 120;
        }

        public override string DefaultName => "a fire drake";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.FilthyRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluFlamingwyrm : BaseCreature
    {
        [Constructible]
        public ZuluFlamingwyrm() : base(AIType.AI_Mage)
        {
            Body = 59;
            Hue = 0x494;
            BaseSoundID = 0x2C2;

            SetStr(400);
            SetDex(800);
            SetInt(100);
            SetHits(7500);
            SetMana(100);
            SetStam(600);

            SetDamage(12, 35);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.FireProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.WaterProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.AirProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.NecroProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.HollyProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.EarthProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 4, 4);

            SetSkill(SkillName.Tactics, 100.0, 110.0);
            SetSkill(SkillName.Anatomy, 100.0, 110.0);
            SetSkill(SkillName.Swords, 100.0, 110.0);
            SetSkill(SkillName.Macing, 100.0, 110.0);
            SetSkill(SkillName.Fencing, 100.0, 110.0);
            SetSkill(SkillName.Wrestling, 100.0, 110.0);
            SetSkill(SkillName.Parry, 110.0, 120.0);
            SetSkill(SkillName.MagicResist, 110.0, 120.0);
            SetSkill(SkillName.DetectHidden, 125.0, 135.0);

            Fame = 35000;
            Karma = -35000;
            VirtualArmor = 64;
            MinTameSkill = 150;
        }

        public override string DefaultName => "a Flaming Wyrm";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluForestdrake : BaseCreature
    {
        [Constructible]
        public ZuluForestdrake() : base(AIType.AI_Mage)
        {
            Body = 60;
            Hue = 0x48A;
            BaseSoundID = 0x467;

            SetStr(125);
            SetDex(200);
            SetInt(50);
            SetHits(300);
            SetMana(0);
            SetStam(600);

            SetDamage(5, 15);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.FireProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.EarthProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 3, 3);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Anatomy, 90.0, 100.0);
            SetSkill(SkillName.Swords, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.Fencing, 90.0, 100.0);
            SetSkill(SkillName.Wrestling, 90.0, 100.0);
            SetSkill(SkillName.Parry, 70.0, 80.0);
            SetSkill(SkillName.MagicResist, 70.0, 80.0);
            SetSkill(SkillName.DetectHidden, 60.0, 70.0);
            SetSkill(SkillName.Poisoning, 30.0, 40.0);

            Fame = 35000;
            Karma = -35000;
            VirtualArmor = 42;
            MinTameSkill = 110;
        }

        public override string DefaultName => "a forest drake";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.FilthyRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluFrostdragon : BaseCreature
    {
        [Constructible]
        public ZuluFrostdragon() : base(AIType.AI_Mage)
        {
            Body = 12;
            Hue = 0x498;
            BaseSoundID = 0x2C2;

            SetStr(500);
            SetDex(600);
            SetInt(100);
            SetHits(750);
            SetMana(100);
            SetStam(600);

            SetDamage(18, 50);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.WaterProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.AirProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.HollyProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.EarthProtection, 10, 10);
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

            Fame = 35000;
            Karma = -35000;
            VirtualArmor = 58;
            MinTameSkill = 125;
        }

        public override string DefaultName => "a Frost Dragon";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.FilthyRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluFrostdrake : BaseCreature
    {
        [Constructible]
        public ZuluFrostdrake() : base(AIType.AI_Mage)
        {
            Body = 60;
            Hue = 0x498;
            BaseSoundID = 0x467;

            SetStr(125);
            SetDex(150);
            SetInt(75);
            SetHits(300);
            SetMana(0);
            SetStam(600);

            SetDamage(5, 15);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.FireProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.WaterProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.EarthProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 3, 3);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Anatomy, 90.0, 100.0);
            SetSkill(SkillName.Swords, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.Fencing, 90.0, 100.0);
            SetSkill(SkillName.Wrestling, 90.0, 100.0);
            SetSkill(SkillName.Parry, 80.0, 90.0);
            SetSkill(SkillName.MagicResist, 70.0, 80.0);
            SetSkill(SkillName.DetectHidden, 70.0, 80.0);

            Fame = 35000;
            Karma = -35000;
            VirtualArmor = 46;
            MinTameSkill = 115;
        }

        public override string DefaultName => "a frost drake";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluGoldendragon : BaseCreature
    {
        [Constructible]
        public ZuluGoldendragon() : base(AIType.AI_Mage)
        {
            Body = 12;
            Hue = 0x7AD;
            BaseSoundID = 0x2C2;

            SetStr(700);
            SetDex(1000);
            SetInt(300);
            SetHits(10000);
            SetMana(100);
            SetStam(30000);

            SetDamage(18, 50);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.FireProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.WaterProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.AirProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.NecroProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.HollyProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.EarthProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 6, 6);

            SetSkill(SkillName.Tactics, 110.0, 120.0);
            SetSkill(SkillName.Anatomy, 110.0, 120.0);
            SetSkill(SkillName.Swords, 110.0, 120.0);
            SetSkill(SkillName.Macing, 110.0, 120.0);
            SetSkill(SkillName.Fencing, 110.0, 120.0);
            SetSkill(SkillName.Wrestling, 110.0, 120.0);
            SetSkill(SkillName.Parry, 120.0, 130.0);
            SetSkill(SkillName.MagicResist, 140.0, 150.0);
            SetSkill(SkillName.DetectHidden, 130.0, 140.0);

            Fame = 35000;
            Karma = -35000;
            VirtualArmor = 73;
            MinTameSkill = 160;
        }

        public override string DefaultName => "The Golden Dragon";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluGreatwyrm : BaseCreature
    {
        [Constructible]
        public ZuluGreatwyrm() : base(AIType.AI_Mage)
        {
            Body = 59;
            Hue = 0x487;
            BaseSoundID = 0x2C2;

            SetStr(350);
            SetDex(1200);
            SetInt(100);
            SetHits(7500);
            SetMana(100);
            SetStam(600);

            SetDamage(12, 35);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.FireProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.WaterProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.AirProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.NecroProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.HollyProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.EarthProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 4, 4);

            SetSkill(SkillName.Tactics, 100.0, 110.0);
            SetSkill(SkillName.Anatomy, 100.0, 110.0);
            SetSkill(SkillName.Swords, 100.0, 110.0);
            SetSkill(SkillName.Macing, 100.0, 110.0);
            SetSkill(SkillName.Fencing, 100.0, 110.0);
            SetSkill(SkillName.Wrestling, 100.0, 110.0);
            SetSkill(SkillName.Parry, 100.0, 110.0);
            SetSkill(SkillName.MagicResist, 100.0, 110.0);
            SetSkill(SkillName.DetectHidden, 120.0, 130.0);

            Fame = 35000;
            Karma = -35000;
            VirtualArmor = 58;
            MinTameSkill = 145;
        }

        public override string DefaultName => "a Great Wyrm";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluHeavenlydrakecaretaker : BaseCreature
    {
        [Constructible]
        public ZuluHeavenlydrakecaretaker() : base(AIType.AI_Melee)
        {
            Body = 400;
            Hue = 0x3EA;

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

        public override string DefaultName => "heavenlydrakecaretaker, the Heavenly Drake Caretaker";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluInfernodragon : BaseCreature
    {
        [Constructible]
        public ZuluInfernodragon() : base(AIType.AI_Mage)
        {
            Body = 59;
            Hue = 0x486;
            BaseSoundID = 0x2C2;

            SetStr(800);
            SetDex(600);
            SetInt(1500);
            SetHits(3000);
            SetMana(500);
            SetStam(600);

            SetDamage(18, 50);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.AirProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.EarthProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 5, 5);

            SetSkill(SkillName.Tactics, 140.0, 150.0);
            SetSkill(SkillName.Anatomy, 140.0, 150.0);
            SetSkill(SkillName.Swords, 140.0, 150.0);
            SetSkill(SkillName.Macing, 140.0, 150.0);
            SetSkill(SkillName.Fencing, 140.0, 150.0);
            SetSkill(SkillName.Wrestling, 140.0, 150.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 100.0, 110.0);
            SetSkill(SkillName.DetectHidden, 115.0, 125.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 55;
            MinTameSkill = 140;
        }

        public override string DefaultName => "an Inferno Dragon";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluLavosdragon : BaseCreature
    {
        [Constructible]
        public ZuluLavosdragon() : base(AIType.AI_Mage)
        {
            Body = 59;
            Hue = 0x7CA;
            BaseSoundID = 0x2C2;

            SetStr(350);
            SetDex(600);
            SetInt(100);
            SetHits(1500);
            SetMana(100);
            SetStam(600);

            SetDamage(12, 35);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.WaterProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.NecroProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 4, 4);

            SetSkill(SkillName.Tactics, 100.0, 110.0);
            SetSkill(SkillName.Anatomy, 100.0, 110.0);
            SetSkill(SkillName.Swords, 100.0, 110.0);
            SetSkill(SkillName.Macing, 100.0, 110.0);
            SetSkill(SkillName.Fencing, 100.0, 110.0);
            SetSkill(SkillName.Wrestling, 100.0, 110.0);
            SetSkill(SkillName.Parry, 100.0, 110.0);
            SetSkill(SkillName.MagicResist, 90.0, 100.0);
            SetSkill(SkillName.DetectHidden, 115.0, 125.0);

            Fame = 35000;
            Karma = -35000;
            VirtualArmor = 56;
        }

        public override string DefaultName => "The Lavos Dragon";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluMechanicaldragon : BaseCreature
    {
        [Constructible]
        public ZuluMechanicaldragon() : base(AIType.AI_Mage)
        {
            Body = 59;
            Hue = 0x7CF;
            BaseSoundID = 0x306;

            SetStr(350);
            SetDex(600);
            SetInt(100);
            SetHits(3000);
            SetMana(100);
            SetStam(600);

            SetDamage(12, 35);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.NecroProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.HollyProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.EarthProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 4, 4);

            SetSkill(SkillName.Tactics, 70.0, 80.0);
            SetSkill(SkillName.Anatomy, 70.0, 80.0);
            SetSkill(SkillName.Swords, 70.0, 80.0);
            SetSkill(SkillName.Macing, 70.0, 80.0);
            SetSkill(SkillName.Fencing, 70.0, 80.0);
            SetSkill(SkillName.Wrestling, 70.0, 80.0);
            SetSkill(SkillName.Parry, 140.0, 150.0);
            SetSkill(SkillName.MagicResist, 70.0, 80.0);
            SetSkill(SkillName.DetectHidden, 140.0, 150.0);

            Fame = 35000;
            Karma = -35000;
            VirtualArmor = 66;
        }

        public override string DefaultName => "a Mechanical Dragon";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.FilthyRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluPhasingdrake : BaseCreature
    {
        [Constructible]
        public ZuluPhasingdrake() : base(AIType.AI_Mage)
        {
            Body = 60;
            Hue = 0x4631;
            BaseSoundID = 0x467;

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
            AddMobZuluModifier(ZuluMod.FireProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.AirProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.EarthProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 5, 5);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Anatomy, 90.0, 100.0);
            SetSkill(SkillName.Swords, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.Fencing, 90.0, 100.0);
            SetSkill(SkillName.Wrestling, 90.0, 100.0);
            SetSkill(SkillName.Parry, 110.0, 120.0);
            SetSkill(SkillName.MagicResist, 70.0, 80.0);
            SetSkill(SkillName.DetectHidden, 90.0, 100.0);
            SetSkill(SkillName.Magery, 100.0, 110.0);
            SetSkill(SkillName.EvalInt, 90.0, 100.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 56;
            MinTameSkill = 120;
        }

        public override string DefaultName => "a phase drake";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluPhoenix : BaseCreature
    {
        [Constructible]
        public ZuluPhoenix() : base(AIType.AI_Mage)
        {
            Body = 5;
            Hue = 0x486;
            BaseSoundID = 0x2F1;

            SetStr(350);
            SetDex(450);
            SetInt(200);
            SetHits(800);
            SetMana(400);
            SetStam(800);

            SetDamage(12, 35);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 100, 100);
            AddMobZuluModifier(ZuluMod.AirProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.EarthProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 2, 2);

            SetSkill(SkillName.Tactics, 110.0, 120.0);
            SetSkill(SkillName.Anatomy, 110.0, 120.0);
            SetSkill(SkillName.Swords, 110.0, 120.0);
            SetSkill(SkillName.Macing, 110.0, 120.0);
            SetSkill(SkillName.Fencing, 110.0, 120.0);
            SetSkill(SkillName.Wrestling, 110.0, 120.0);
            SetSkill(SkillName.Parry, 110.0, 120.0);
            SetSkill(SkillName.MagicResist, 105.0, 115.0);
            SetSkill(SkillName.DetectHidden, 100.0, 110.0);
            SetSkill(SkillName.Magery, 110.0, 120.0);
            SetSkill(SkillName.EvalInt, 100.0, 110.0);
            SetSkill(SkillName.Hiding, 90.0, 100.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 63;
            MinTameSkill = 160;
        }

        public override string DefaultName => "a Phoenix";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluPhoenix1 : BaseCreature
    {
        [Constructible]
        public ZuluPhoenix1() : base(AIType.AI_Mage)
        {
            Body = 5;
            Hue = 0x486;
            BaseSoundID = 0x2F1;

            SetStr(400);
            SetDex(400);
            SetInt(175);
            SetHits(800);
            SetMana(350);
            SetStam(800);

            SetDamage(12, 35);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 90, 90);
            AddMobZuluModifier(ZuluMod.AirProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.EarthProtection, 10, 10);

            SetSkill(SkillName.Tactics, 110.0, 120.0);
            SetSkill(SkillName.Anatomy, 110.0, 120.0);
            SetSkill(SkillName.Swords, 110.0, 120.0);
            SetSkill(SkillName.Macing, 110.0, 120.0);
            SetSkill(SkillName.Fencing, 110.0, 120.0);
            SetSkill(SkillName.Wrestling, 110.0, 120.0);
            SetSkill(SkillName.Parry, 110.0, 120.0);
            SetSkill(SkillName.MagicResist, 110.0, 120.0);
            SetSkill(SkillName.DetectHidden, 90.0, 100.0);
            SetSkill(SkillName.Magery, 110.0, 120.0);
            SetSkill(SkillName.EvalInt, 100.0, 110.0);
            SetSkill(SkillName.Hiding, 90.0, 100.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 64;
            MinTameSkill = 150;
        }

        public override string DefaultName => "a Phoenix";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluPhoenix2 : BaseCreature
    {
        [Constructible]
        public ZuluPhoenix2() : base(AIType.AI_Mage)
        {
            Body = 5;
            Hue = 0x66D;
            BaseSoundID = 0x2F1;

            SetStr(350);
            SetDex(400);
            SetInt(150);
            SetHits(700);
            SetMana(300);
            SetStam(800);

            SetDamage(12, 35);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.FireProtection, 80, 80);
            AddMobZuluModifier(ZuluMod.AirProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.EarthProtection, 10, 10);

            SetSkill(SkillName.Tactics, 100.0, 110.0);
            SetSkill(SkillName.Anatomy, 100.0, 110.0);
            SetSkill(SkillName.Swords, 100.0, 110.0);
            SetSkill(SkillName.Macing, 100.0, 110.0);
            SetSkill(SkillName.Fencing, 100.0, 110.0);
            SetSkill(SkillName.Wrestling, 100.0, 110.0);
            SetSkill(SkillName.Parry, 100.0, 110.0);
            SetSkill(SkillName.MagicResist, 100.0, 110.0);
            SetSkill(SkillName.DetectHidden, 80.0, 90.0);
            SetSkill(SkillName.Magery, 100.0, 110.0);
            SetSkill(SkillName.EvalInt, 90.0, 100.0);
            SetSkill(SkillName.Hiding, 80.0, 90.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 58;
            MinTameSkill = 140;
        }

        public override string DefaultName => "a Phoenix";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluPhoenix3 : BaseCreature
    {
        [Constructible]
        public ZuluPhoenix3() : base(AIType.AI_Mage)
        {
            Body = 5;
            Hue = 0x663;
            BaseSoundID = 0x2F1;

            SetStr(300);
            SetDex(400);
            SetInt(125);
            SetHits(600);
            SetMana(250);
            SetStam(800);

            SetDamage(12, 35);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.FireProtection, 70, 70);
            AddMobZuluModifier(ZuluMod.AirProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.EarthProtection, 10, 10);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Anatomy, 90.0, 100.0);
            SetSkill(SkillName.Swords, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.Fencing, 90.0, 100.0);
            SetSkill(SkillName.Wrestling, 90.0, 100.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 90.0, 100.0);
            SetSkill(SkillName.DetectHidden, 70.0, 80.0);
            SetSkill(SkillName.Magery, 90.0, 100.0);
            SetSkill(SkillName.EvalInt, 80.0, 90.0);
            SetSkill(SkillName.Hiding, 70.0, 80.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 53;
            MinTameSkill = 130;
        }

        public override string DefaultName => "a Phoenix";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluPoisondragon : BaseCreature
    {
        [Constructible]
        public ZuluPoisondragon() : base(AIType.AI_Mage)
        {
            Body = 12;
            Hue = 0x499;
            BaseSoundID = 0x2C2;

            SetStr(500);
            SetDex(600);
            SetInt(100);
            SetHits(700);
            SetMana(100);
            SetStam(600);

            SetDamage(18, 50);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 40, 40);
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
            MinTameSkill = 125;
        }

        public override string DefaultName => "a Poison Dragon";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluPossesseddragon : BaseCreature
    {
        [Constructible]
        public ZuluPossesseddragon() : base(AIType.AI_Mage)
        {
            Body = 59;
            Hue = 0x7B5;
            BaseSoundID = 0x2C2;

            SetStr(500);
            SetDex(600);
            SetInt(100);
            SetHits(2000);
            SetMana(100);
            SetStam(600);

            SetDamage(18, 50);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.NecroProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 6, 6);

            SetSkill(SkillName.Tactics, 105.0, 115.0);
            SetSkill(SkillName.Anatomy, 105.0, 115.0);
            SetSkill(SkillName.Swords, 105.0, 115.0);
            SetSkill(SkillName.Macing, 105.0, 115.0);
            SetSkill(SkillName.Fencing, 105.0, 115.0);
            SetSkill(SkillName.Wrestling, 105.0, 115.0);
            SetSkill(SkillName.Parry, 105.0, 115.0);
            SetSkill(SkillName.MagicResist, 105.0, 115.0);
            SetSkill(SkillName.DetectHidden, 105.0, 115.0);

            Fame = 35000;
            Karma = -35000;
            VirtualArmor = 61;
        }

        public override string DefaultName => "a Possessed Dragon";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluRockdragon : BaseCreature
    {
        [Constructible]
        public ZuluRockdragon() : base(AIType.AI_Mage)
        {
            Body = 12;
            Hue = 0x488;
            BaseSoundID = 0x2C2;

            SetStr(800);
            SetDex(600);
            SetInt(400);
            SetHits(1000);
            SetMana(400);
            SetStam(600);

            SetDamage(18, 50);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.AirProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.EarthProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 5, 5);

            SetSkill(SkillName.Tactics, 120.0, 130.0);
            SetSkill(SkillName.Anatomy, 120.0, 130.0);
            SetSkill(SkillName.Swords, 120.0, 130.0);
            SetSkill(SkillName.Macing, 120.0, 130.0);
            SetSkill(SkillName.Fencing, 120.0, 130.0);
            SetSkill(SkillName.Wrestling, 120.0, 130.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 80.0, 90.0);
            SetSkill(SkillName.DetectHidden, 115.0, 125.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 51;
            MinTameSkill = 135;
        }

        public override string DefaultName => "a Rock Dragon";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluRottendragon : BaseCreature
    {
        [Constructible]
        public ZuluRottendragon() : base(AIType.AI_Mage)
        {
            Body = 60;
            Hue = 0x500;
            BaseSoundID = 0x2C2;

            SetStr(100);
            SetDex(1000);
            SetInt(10000);
            SetHits(5000);
            SetMana(10000);
            SetStam(10000);

            SetDamage(5, 15);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.FireProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.WaterProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.AirProtection, 20, 20);
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
            SetSkill(SkillName.DetectHidden, 110.0, 120.0);
            SetSkill(SkillName.Magery, 190.0, 200.0);
            SetSkill(SkillName.EvalInt, 190.0, 200.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 59;
            MinTameSkill = 150;
        }

        public override string DefaultName => "a Rotten Dragon";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluShadowdragon : BaseCreature
    {
        [Constructible]
        public ZuluShadowdragon() : base(AIType.AI_Mage)
        {
            Body = 12;
            Hue = 0x4631;
            BaseSoundID = 0x2C2;

            SetStr(500);
            SetDex(600);
            SetInt(400);
            SetHits(1200);
            SetMana(400);
            SetStam(600);

            SetDamage(18, 50);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.WaterProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.AirProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.EarthProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 5, 5);

            SetSkill(SkillName.Tactics, 120.0, 130.0);
            SetSkill(SkillName.Anatomy, 120.0, 130.0);
            SetSkill(SkillName.Swords, 120.0, 130.0);
            SetSkill(SkillName.Macing, 120.0, 130.0);
            SetSkill(SkillName.Fencing, 120.0, 130.0);
            SetSkill(SkillName.Wrestling, 120.0, 130.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 80.0, 90.0);
            SetSkill(SkillName.DetectHidden, 115.0, 125.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 51;
            MinTameSkill = 140;
        }

        public override string DefaultName => "a Shadow Dragon";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.FilthyRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluStormdragon : BaseCreature
    {
        [Constructible]
        public ZuluStormdragon() : base(AIType.AI_Mage)
        {
            Body = 12;
            Hue = 0x492;
            BaseSoundID = 0x2C2;

            SetStr(500);
            SetDex(600);
            SetInt(400);
            SetHits(1200);
            SetMana(400);
            SetStam(600);

            SetDamage(18, 50);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.WaterProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.AirProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.EarthProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 5, 5);

            SetSkill(SkillName.Tactics, 120.0, 130.0);
            SetSkill(SkillName.Anatomy, 120.0, 130.0);
            SetSkill(SkillName.Swords, 120.0, 130.0);
            SetSkill(SkillName.Macing, 120.0, 130.0);
            SetSkill(SkillName.Fencing, 120.0, 130.0);
            SetSkill(SkillName.Wrestling, 120.0, 130.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 80.0, 90.0);
            SetSkill(SkillName.DetectHidden, 115.0, 125.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 51;
            MinTameSkill = 140;
        }

        public override string DefaultName => "a Storm Dragon";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluSwampdrake : BaseCreature
    {
        [Constructible]
        public ZuluSwampdrake() : base(AIType.AI_Melee)
        {
            Body = 61;
            Hue = 0x499;
            BaseSoundID = 0x467;

            SetStr(150);
            SetDex(170);
            SetInt(100);
            SetHits(300);
            SetMana(0);
            SetStam(600);

            SetDamage(8, 25);
            z_Physical_DD = 50;
            z_Poison_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.FireProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.EarthProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 3, 3);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Anatomy, 90.0, 100.0);
            SetSkill(SkillName.Swords, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.Fencing, 90.0, 100.0);
            SetSkill(SkillName.Wrestling, 90.0, 100.0);
            SetSkill(SkillName.Parry, 80.0, 90.0);
            SetSkill(SkillName.MagicResist, 70.0, 80.0);
            SetSkill(SkillName.DetectHidden, 80.0, 90.0);
            SetSkill(SkillName.Poisoning, 65.0, 75.0);

            Fame = 35000;
            Karma = -35000;
            VirtualArmor = 46;
            MinTameSkill = 115;
        }

        public override string DefaultName => "a swamp drake";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.FilthyRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluTidaldragon : BaseCreature
    {
        [Constructible]
        public ZuluTidaldragon() : base(AIType.AI_Mage)
        {
            Body = 12;
            Hue = 0x484;
            BaseSoundID = 0x2C2;

            SetStr(500);
            SetDex(1200);
            SetInt(400);
            SetHits(1350);
            SetMana(400);
            SetStam(600);

            SetDamage(18, 50);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.WaterProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.AirProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.EarthProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 5, 5);

            SetSkill(SkillName.Tactics, 120.0, 130.0);
            SetSkill(SkillName.Anatomy, 120.0, 130.0);
            SetSkill(SkillName.Swords, 120.0, 130.0);
            SetSkill(SkillName.Macing, 120.0, 130.0);
            SetSkill(SkillName.Fencing, 120.0, 130.0);
            SetSkill(SkillName.Wrestling, 120.0, 130.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 80.0, 90.0);
            SetSkill(SkillName.DetectHidden, 115.0, 125.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 51;
            MinTameSkill = 140;
        }

        public override string DefaultName => "a Tidal Dragon";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.FilthyRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluWaterdrake : BaseCreature
    {
        [Constructible]
        public ZuluWaterdrake() : base(AIType.AI_Melee)
        {
            Body = 61;
            Hue = 0x48D;
            BaseSoundID = 0x467;

            SetStr(200);
            SetDex(150);
            SetInt(100);
            SetHits(400);
            SetMana(0);
            SetStam(600);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.FireProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.WaterProtection, 80, 80);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 3, 3);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Anatomy, 100.0, 110.0);
            SetSkill(SkillName.Swords, 100.0, 110.0);
            SetSkill(SkillName.Macing, 100.0, 110.0);
            SetSkill(SkillName.Fencing, 100.0, 110.0);
            SetSkill(SkillName.Wrestling, 100.0, 110.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 110.0, 120.0);
            SetSkill(SkillName.DetectHidden, 105.0, 115.0);
            SetSkill(SkillName.Magery, 80.0, 90.0);
            SetSkill(SkillName.EvalInt, 70.0, 80.0);

            Fame = 35000;
            Karma = -35000;
            VirtualArmor = 57;
            MinTameSkill = 120;
        }

        public override string DefaultName => "a water drake";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.FilthyRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluWonderdragon : BaseCreature
    {
        [Constructible]
        public ZuluWonderdragon() : base(AIType.AI_Mage)
        {
            Body = 59;
            Hue = 0x512;
            BaseSoundID = 0x2C2;

            SetStr(350);
            SetDex(600);
            SetInt(100);
            SetHits(5000);
            SetMana(100);
            SetStam(600);

            SetDamage(12, 35);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.FireProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.WaterProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.AirProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.NecroProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.HollyProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.EarthProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 4, 4);

            SetSkill(SkillName.Tactics, 100.0, 110.0);
            SetSkill(SkillName.Anatomy, 90.0, 100.0);
            SetSkill(SkillName.Swords, 100.0, 110.0);
            SetSkill(SkillName.Macing, 100.0, 110.0);
            SetSkill(SkillName.Fencing, 100.0, 110.0);
            SetSkill(SkillName.Wrestling, 100.0, 110.0);
            SetSkill(SkillName.Parry, 100.0, 110.0);
            SetSkill(SkillName.MagicResist, 100.0, 110.0);
            SetSkill(SkillName.DetectHidden, 115.0, 125.0);

            Fame = 35000;
            Karma = -35000;
            VirtualArmor = 58;
            MinTameSkill = 140;
        }

        public override string DefaultName => "a Wonder Dragon";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.FilthyRich);
        }
    }
}
