using ModernUO.Serialization;
using Server.Items;

namespace Server.Mobiles
{
    // Zulu Hotel — Animals Evil NPCs
    // Auto-generated from npcdesc_zhbr.cfg (74 NPCs)
    // Source: POL 98 Zulu Hotel shard

    [SerializationGenerator(0, false)]
    public partial class ZuluAlligator : BaseCreature
    {
        [Constructible]
        public ZuluAlligator() : base(AIType.AI_Melee)
        {
            Body = 202;
            Hue = 0x83F8;
            BaseSoundID = 0x5F;

            SetStr(250);
            SetDex(100);
            SetInt(50);
            SetHits(250);
            SetMana(50);
            SetStam(100);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);

            SetSkill(SkillName.Tactics, 100.0, 110.0);
            SetSkill(SkillName.Anatomy, 100.0, 110.0);
            SetSkill(SkillName.Swords, 100.0, 110.0);
            SetSkill(SkillName.Macing, 100.0, 110.0);
            SetSkill(SkillName.Fencing, 100.0, 110.0);
            SetSkill(SkillName.Wrestling, 100.0, 110.0);
            SetSkill(SkillName.Parry, 70.0, 80.0);
            SetSkill(SkillName.MagicResist, 50.0, 60.0);
            SetSkill(SkillName.DetectHidden, 70.0, 80.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 38;
            MinTameSkill = 80;
        }

        public override string DefaultName => "an alligator";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluAntlion : BaseCreature
    {
        [Constructible]
        public ZuluAntlion() : base(AIType.AI_Melee)
        {
            Body = 242;
            Hue = 0x488;
            BaseSoundID = 0x4F1;

            SetStr(150);
            SetDex(100);
            SetInt(75);
            SetHits(200);
            SetMana(0);
            SetStam(1200);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.EarthProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 3, 3);

            SetSkill(SkillName.Tactics, 80.0, 90.0);
            SetSkill(SkillName.Anatomy, 80.0, 90.0);
            SetSkill(SkillName.Swords, 80.0, 90.0);
            SetSkill(SkillName.Macing, 80.0, 90.0);
            SetSkill(SkillName.Fencing, 80.0, 90.0);
            SetSkill(SkillName.Wrestling, 80.0, 90.0);
            SetSkill(SkillName.Parry, 65.0, 75.0);
            SetSkill(SkillName.MagicResist, 65.0, 75.0);
            SetSkill(SkillName.DetectHidden, 65.0, 75.0);
            SetSkill(SkillName.Hiding, 65.0, 75.0);
            SetSkill(SkillName.Poisoning, 65.0, 75.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 40;
            MinTameSkill = 95;
        }

        public override string DefaultName => "an antlion";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBat : BaseCreature
    {
        [Constructible]
        public ZuluBat() : base(AIType.AI_Melee)
        {
            Body = 6;
            Hue = 0x455;
            BaseSoundID = 0x2A1;

            SetStr(30);
            SetDex(30);
            SetInt(30);
            SetHits(20);
            SetMana(0);
            SetStam(300);

            SetDamage(5, 15);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 20, 20);

            SetSkill(SkillName.Tactics, 20.0, 30.0);
            SetSkill(SkillName.Anatomy, 20.0, 30.0);
            SetSkill(SkillName.Swords, 20.0, 30.0);
            SetSkill(SkillName.Macing, 20.0, 30.0);
            SetSkill(SkillName.Fencing, 20.0, 30.0);
            SetSkill(SkillName.Wrestling, 20.0, 30.0);
            SetSkill(SkillName.Parry, 20.0, 30.0);
            SetSkill(SkillName.MagicResist, 40.0, 50.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 20;
            MinTameSkill = 30;
        }

        public override string DefaultName => "a bat";
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBattleleaderbrother : BaseCreature
    {
        [Constructible]
        public ZuluBattleleaderbrother() : base(AIType.AI_Melee)
        {
            Body = 400;
            Hue = 0x3EA;
            BaseSoundID = 0x15B;

            SetStr(250);
            SetDex(600);
            SetInt(100);
            SetHits(750);
            SetMana(0);
            SetStam(1200);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.WaterProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.AirProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 3, 3);

            SetSkill(SkillName.Tactics, 85.0, 95.0);
            SetSkill(SkillName.Anatomy, 85.0, 95.0);
            SetSkill(SkillName.Swords, 85.0, 95.0);
            SetSkill(SkillName.Macing, 85.0, 95.0);
            SetSkill(SkillName.Fencing, 85.0, 95.0);
            SetSkill(SkillName.Wrestling, 85.0, 95.0);
            SetSkill(SkillName.Parry, 75.0, 85.0);
            SetSkill(SkillName.MagicResist, 90.0, 100.0);
            SetSkill(SkillName.DetectHidden, 80.0, 90.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 48;
        }

        public override string DefaultName => "Captain Parsons, the leader-in-battle brother";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.FilthyRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBlackbear : BaseCreature
    {
        [Constructible]
        public ZuluBlackbear() : base(AIType.AI_Melee)
        {
            Body = 211;
            Hue = 0x488;
            BaseSoundID = 0x2C;

            SetStr(150);
            SetDex(50);
            SetInt(50);
            SetHits(150);
            SetMana(50);
            SetStam(600);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 80.0, 90.0);
            SetSkill(SkillName.Anatomy, 80.0, 90.0);
            SetSkill(SkillName.Swords, 80.0, 90.0);
            SetSkill(SkillName.Macing, 80.0, 90.0);
            SetSkill(SkillName.Fencing, 80.0, 90.0);
            SetSkill(SkillName.Wrestling, 80.0, 90.0);
            SetSkill(SkillName.Parry, 50.0, 60.0);
            SetSkill(SkillName.MagicResist, 50.0, 60.0);
            SetSkill(SkillName.DetectHidden, 75.0, 85.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 32;
            MinTameSkill = 85;
        }

        public override string DefaultName => "a black bear";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBlackcat : BaseCreature
    {
        [Constructible]
        public ZuluBlackcat() : base(AIType.AI_Animal)
        {
            Body = 201;
            Hue = 0x485;
            BaseSoundID = 0x6E;

            SetStr(15);
            SetDex(20);
            SetInt(50);
            SetHits(15);
            SetMana(0);
            SetStam(600);

            SetDamage(5, 15);
            z_Physical_DD = 100;

            SetSkill(SkillName.Tactics, 30.0, 40.0);
            SetSkill(SkillName.Anatomy, 30.0, 40.0);
            SetSkill(SkillName.Swords, 5.0, 15.0);
            SetSkill(SkillName.Macing, 5.0, 15.0);
            SetSkill(SkillName.Fencing, 5.0, 15.0);
            SetSkill(SkillName.Wrestling, 5.0, 15.0);
            SetSkill(SkillName.Parry, 10.0, 20.0);
            SetSkill(SkillName.MagicResist, 30.0, 40.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 14;
            MinTameSkill = 35;
        }

        public override string DefaultName => "a black cat";

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBlackscorpion : BaseCreature
    {
        [Constructible]
        public ZuluBlackscorpion() : base(AIType.AI_Melee)
        {
            Body = 48;
            Hue = 0x455;

            SetStr(450);
            SetDex(300);
            SetInt(35);
            SetHits(900);
            SetMana(25);
            SetStam(50);

            SetDamage(12, 35);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 110.0, 120.0);
            SetSkill(SkillName.Swords, 125.0, 135.0);
            SetSkill(SkillName.Parry, 75.0, 85.0);
            SetSkill(SkillName.MagicResist, 70.0, 80.0);
            SetSkill(SkillName.Poisoning, 60.0, 70.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 44;
        }

        public override string DefaultName => "a giant black scorpion";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluChimera : BaseCreature
    {
        [Constructible]
        public ZuluChimera() : base(AIType.AI_Mage)
        {
            Body = 276;
            BaseSoundID = 0x2CA;

            SetStr(350);
            SetDex(600);
            SetInt(100);
            SetHits(350);
            SetMana(100);
            SetStam(600);

            SetDamage(12, 35);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.FireProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.WaterProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.AirProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.NecroProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.HollyProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.EarthProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 4, 4);

            SetSkill(SkillName.Tactics, 110.0, 120.0);
            SetSkill(SkillName.Anatomy, 110.0, 120.0);
            SetSkill(SkillName.Swords, 110.0, 120.0);
            SetSkill(SkillName.Macing, 110.0, 120.0);
            SetSkill(SkillName.Fencing, 110.0, 120.0);
            SetSkill(SkillName.Wrestling, 110.0, 120.0);
            SetSkill(SkillName.Parry, 110.0, 120.0);
            SetSkill(SkillName.MagicResist, 110.0, 120.0);
            SetSkill(SkillName.DetectHidden, 125.0, 135.0);

            Fame = 35000;
            Karma = -35000;
            VirtualArmor = 64;
            MinTameSkill = 145;
        }

        public override string DefaultName => "a chimera";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluCrystalostard : BaseCreature
    {
        [Constructible]
        public ZuluCrystalostard() : base(AIType.AI_Melee)
        {
            Body = 218;
            Hue = 0x492;
            BaseSoundID = 0xB7;

            SetStr(300);
            SetDex(200);
            SetInt(75);
            SetHits(300);
            SetMana(0);
            SetStam(600);

            SetDamage(12, 35);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.WaterProtection, 40, 40);

            SetSkill(SkillName.Tactics, 95.0, 105.0);
            SetSkill(SkillName.Anatomy, 95.0, 105.0);
            SetSkill(SkillName.Swords, 95.0, 105.0);
            SetSkill(SkillName.Macing, 95.0, 105.0);
            SetSkill(SkillName.Fencing, 95.0, 105.0);
            SetSkill(SkillName.Wrestling, 95.0, 105.0);
            SetSkill(SkillName.Parry, 95.0, 105.0);
            SetSkill(SkillName.MagicResist, 95.0, 105.0);
            SetSkill(SkillName.DetectHidden, 95.0, 105.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 56;
            MinTameSkill = 120;
        }

        public override string DefaultName => "a crystal ostard";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluCusidhe : BaseCreature
    {
        [Constructible]
        public ZuluCusidhe() : base(AIType.AI_Melee)
        {
            Body = 277;
            BaseSoundID = 0x576;

            SetStr(500);
            SetDex(1000);
            SetInt(150);
            SetHits(500);
            SetMana(0);
            SetStam(2000);

            SetDamage(18, 50);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.FireProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.WaterProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.AirProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.EarthProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 2, 2);

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
            MinTameSkill = 135;
        }

        public override string DefaultName => "a cusidhe";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluDemonostard : BaseCreature
    {
        [Constructible]
        public ZuluDemonostard() : base(AIType.AI_Mage)
        {
            Body = 210;
            Hue = 0xAD4;
            BaseSoundID = 0xB7;

            SetStr(250);
            SetDex(200);
            SetInt(75);
            SetHits(250);
            SetMana(0);
            SetStam(600);

            SetDamage(8, 25);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.FireProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.NecroProtection, 40, 40);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Anatomy, 90.0, 100.0);
            SetSkill(SkillName.Swords, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.Fencing, 90.0, 100.0);
            SetSkill(SkillName.Wrestling, 90.0, 100.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 90.0, 100.0);
            SetSkill(SkillName.DetectHidden, 90.0, 100.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 53;
            MinTameSkill = 110;
        }

        public override string DefaultName => "a demon ostard";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluDesertape : BaseCreature
    {
        [Constructible]
        public ZuluDesertape() : base(AIType.AI_Melee)
        {
            Body = 29;
            Hue = 0x497;
            BaseSoundID = 0xA3;

            SetStr(200);
            SetDex(130);
            SetInt(30);
            SetHits(100);
            SetMana(0);
            SetStam(600);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.FireProtection, 20, 20);

            SetSkill(SkillName.Tactics, 65.0, 75.0);
            SetSkill(SkillName.Anatomy, 65.0, 75.0);
            SetSkill(SkillName.Swords, 65.0, 75.0);
            SetSkill(SkillName.Macing, 65.0, 75.0);
            SetSkill(SkillName.Fencing, 65.0, 75.0);
            SetSkill(SkillName.Wrestling, 65.0, 75.0);
            SetSkill(SkillName.Parry, 65.0, 75.0);
            SetSkill(SkillName.MagicResist, 65.0, 75.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 40;
            MinTameSkill = 90;
        }

        public override string DefaultName => "a desert ape";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluDesertraven : BaseCreature
    {
        [Constructible]
        public ZuluDesertraven() : base(AIType.AI_Animal)
        {
            Body = 5;
            Hue = 0x485;
            BaseSoundID = 0x94;

            SetStr(75);
            SetDex(30);
            SetInt(20);
            SetHits(75);
            SetMana(0);
            SetStam(600);

            SetDamage(5, 15);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.FireProtection, 20, 20);

            SetSkill(SkillName.Tactics, 65.0, 75.0);
            SetSkill(SkillName.Anatomy, 65.0, 75.0);
            SetSkill(SkillName.Swords, 65.0, 75.0);
            SetSkill(SkillName.Macing, 65.0, 75.0);
            SetSkill(SkillName.Fencing, 65.0, 75.0);
            SetSkill(SkillName.Wrestling, 65.0, 75.0);
            SetSkill(SkillName.Parry, 65.0, 75.0);
            SetSkill(SkillName.MagicResist, 40.0, 50.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 35;
            MinTameSkill = 55;
        }

        public override string DefaultName => "a desert raven";

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluDesertserpent : BaseCreature
    {
        [Constructible]
        public ZuluDesertserpent() : base(AIType.AI_Melee)
        {
            Body = 21;
            Hue = 0x497;

            SetStr(215);
            SetDex(80);
            SetInt(85);
            SetHits(215);
            SetMana(85);
            SetStam(80);

            SetDamage(8, 25);
            z_Physical_DD = 50;
            z_Poison_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 60.0, 70.0);
            SetSkill(SkillName.Swords, 70.0, 80.0);
            SetSkill(SkillName.Parry, 40.0, 50.0);
            SetSkill(SkillName.MagicResist, 30.0, 40.0);
            SetSkill(SkillName.Poisoning, 80.0, 90.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 24;
            MinTameSkill = 80;
        }

        public override string DefaultName => "a desert serpent";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluDesertserpentnestling : BaseCreature
    {
        [Constructible]
        public ZuluDesertserpentnestling() : base(AIType.AI_Melee)
        {
            Body = 52;
            Hue = 0x497;
            BaseSoundID = 0xDC;

            SetStr(35);
            SetDex(85);
            SetInt(66);
            SetHits(35);
            SetMana(56);
            SetStam(50);

            SetDamage(5, 15);
            z_Physical_DD = 50;
            z_Poison_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 20, 20);

            SetSkill(SkillName.Tactics, 40.0, 50.0);
            SetSkill(SkillName.Anatomy, 40.0, 50.0);
            SetSkill(SkillName.Swords, 40.0, 50.0);
            SetSkill(SkillName.Parry, 10.0, 20.0);
            SetSkill(SkillName.MagicResist, 10.0, 20.0);
            SetSkill(SkillName.Poisoning, 35.0, 45.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 10;
            MinTameSkill = 70;
        }

        public override string DefaultName => "a snake";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluEmeraldostard : BaseCreature
    {
        [Constructible]
        public ZuluEmeraldostard() : base(AIType.AI_Melee)
        {
            Body = 218;
            Hue = 0x48A;
            BaseSoundID = 0xB7;

            SetStr(275);
            SetDex(200);
            SetInt(75);
            SetHits(275);
            SetMana(0);
            SetStam(600);

            SetDamage(8, 25);
            z_Physical_DD = 50;
            z_Poison_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.EarthProtection, 40, 40);

            SetSkill(SkillName.Tactics, 95.0, 105.0);
            SetSkill(SkillName.Anatomy, 95.0, 105.0);
            SetSkill(SkillName.Swords, 95.0, 105.0);
            SetSkill(SkillName.Macing, 95.0, 105.0);
            SetSkill(SkillName.Fencing, 95.0, 105.0);
            SetSkill(SkillName.Wrestling, 95.0, 105.0);
            SetSkill(SkillName.Parry, 95.0, 105.0);
            SetSkill(SkillName.MagicResist, 95.0, 105.0);
            SetSkill(SkillName.DetectHidden, 95.0, 105.0);
            SetSkill(SkillName.Poisoning, 95.0, 105.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 56;
            MinTameSkill = 120;
        }

        public override string DefaultName => "an emerald ostard";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluEvilbird : BaseCreature
    {
        [Constructible]
        public ZuluEvilbird() : base(AIType.AI_Melee)
        {
            Body = 6;
            Hue = 0x455;
            BaseSoundID = 0xD6;

            SetStr(15);
            SetDex(20);
            SetInt(15);
            SetHits(5);
            SetMana(0);
            SetStam(300);

            SetDamage(5, 15);
            z_Physical_DD = 100;

            SetSkill(SkillName.Tactics, 5.0, 15.0);
            SetSkill(SkillName.Anatomy, 5.0, 15.0);
            SetSkill(SkillName.Swords, 5.0, 15.0);
            SetSkill(SkillName.Macing, 5.0, 15.0);
            SetSkill(SkillName.Fencing, 5.0, 15.0);
            SetSkill(SkillName.Wrestling, 5.0, 15.0);
            SetSkill(SkillName.Parry, 0.1, 10.0);
            SetSkill(SkillName.MagicResist, 5.0, 15.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 6;
            MinTameSkill = 10;
        }

        public override string DefaultName => "a raven";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluEvisceratedcarcass : BaseCreature
    {
        [Constructible]
        public ZuluEvisceratedcarcass() : base(AIType.AI_Melee)
        {
            Body = 3;
            Hue = 0x50A;
            BaseSoundID = 0x1D9;

            SetStr(75);
            SetDex(150);
            SetInt(50);
            SetHits(1000);
            SetMana(50);
            SetStam(600);

            SetDamage(5, 15);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.FireProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 40, 40);

            SetSkill(SkillName.Tactics, 75.0, 85.0);
            SetSkill(SkillName.Anatomy, 75.0, 85.0);
            SetSkill(SkillName.Swords, 75.0, 85.0);
            SetSkill(SkillName.Macing, 75.0, 85.0);
            SetSkill(SkillName.Fencing, 75.0, 85.0);
            SetSkill(SkillName.Wrestling, 75.0, 85.0);
            SetSkill(SkillName.Parry, 40.0, 50.0);
            SetSkill(SkillName.MagicResist, 65.0, 75.0);
            SetSkill(SkillName.DetectHidden, 65.0, 75.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 31;
        }

        public override string DefaultName => "an Eviscerated Carcass";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluFireferret : BaseCreature
    {
        [Constructible]
        public ZuluFireferret() : base(AIType.AI_Mage)
        {
            Body = 279;
            Hue = 0x494;
            BaseSoundID = 0x98;

            SetStr(10);
            SetDex(30);
            SetInt(30);
            SetHits(30);
            SetMana(0);
            SetStam(300);

            SetDamage(5, 15);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.FireProtection, 20, 20);

            SetSkill(SkillName.Tactics, 10.0, 20.0);
            SetSkill(SkillName.Anatomy, 10.0, 20.0);
            SetSkill(SkillName.Swords, 10.0, 20.0);
            SetSkill(SkillName.Macing, 10.0, 20.0);
            SetSkill(SkillName.Fencing, 10.0, 20.0);
            SetSkill(SkillName.Wrestling, 10.0, 20.0);
            SetSkill(SkillName.Parry, 10.0, 20.0);
            SetSkill(SkillName.MagicResist, 10.0, 20.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 10;
            MinTameSkill = 35;
        }

        public override string DefaultName => "a fire ferret";

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluFireserpent : BaseCreature
    {
        [Constructible]
        public ZuluFireserpent() : base(AIType.AI_Mage)
        {
            Body = 21;
            Hue = 0x494;

            SetStr(215);
            SetDex(80);
            SetInt(85);
            SetHits(215);
            SetMana(85);
            SetStam(80);

            SetDamage(8, 25);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 60.0, 70.0);
            SetSkill(SkillName.Swords, 70.0, 80.0);
            SetSkill(SkillName.Parry, 40.0, 50.0);
            SetSkill(SkillName.MagicResist, 30.0, 40.0);
            SetSkill(SkillName.Poisoning, 80.0, 90.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 24;
            MinTameSkill = 80;
        }

        public override string DefaultName => "a fire serpent";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluFlamingbison : BaseCreature
    {
        [Constructible]
        public ZuluFlamingbison() : base(AIType.AI_Mage)
        {
            Body = 232;
            Hue = 0x486;
            BaseSoundID = 0x67;

            SetStr(120);
            SetDex(40);
            SetInt(50);
            SetHits(100);
            SetMana(0);
            SetStam(600);

            SetDamage(5, 15);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.FireProtection, 30, 30);

            SetSkill(SkillName.Tactics, 30.0, 40.0);
            SetSkill(SkillName.Anatomy, 60.0, 70.0);
            SetSkill(SkillName.Swords, 40.0, 50.0);
            SetSkill(SkillName.Macing, 40.0, 50.0);
            SetSkill(SkillName.Fencing, 40.0, 50.0);
            SetSkill(SkillName.Wrestling, 40.0, 50.0);
            SetSkill(SkillName.Parry, 40.0, 50.0);
            SetSkill(SkillName.MagicResist, 50.0, 60.0);
            SetSkill(SkillName.DetectHidden, 60.0, 70.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 28;
            MinTameSkill = 90;
        }

        public override string DefaultName => "a flaming bison";

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluForestscorp : BaseCreature
    {
        [Constructible]
        public ZuluForestscorp() : base(AIType.AI_Melee)
        {
            Body = 48;
            Hue = 0x499;
            BaseSoundID = 0x192;

            SetStr(75);
            SetDex(70);
            SetInt(35);
            SetHits(75);
            SetMana(25);
            SetStam(90);

            SetDamage(5, 15);
            z_Physical_DD = 50;
            z_Poison_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 65.0, 75.0);
            SetSkill(SkillName.Anatomy, 65.0, 75.0);
            SetSkill(SkillName.Swords, 65.0, 75.0);
            SetSkill(SkillName.Macing, 65.0, 75.0);
            SetSkill(SkillName.Fencing, 65.0, 75.0);
            SetSkill(SkillName.Wrestling, 65.0, 75.0);
            SetSkill(SkillName.Parry, 60.0, 70.0);
            SetSkill(SkillName.MagicResist, 30.0, 40.0);
            SetSkill(SkillName.DetectHidden, 25.0, 35.0);
            SetSkill(SkillName.Poisoning, 80.0, 90.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 31;
            MinTameSkill = 75;
        }

        public override string DefaultName => "a forest scorpion";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluFrostwolf : BaseCreature
    {
        [Constructible]
        public ZuluFrostwolf() : base(AIType.AI_Melee)
        {
            Body = 225;
            Hue = 0x482;
            BaseSoundID = 0xEA;

            SetStr(120);
            SetDex(60);
            SetInt(50);
            SetHits(120);
            SetMana(50);
            SetStam(600);

            SetDamage(5, 15);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.WaterProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.AirProtection, 10, 10);

            SetSkill(SkillName.Tactics, 80.0, 90.0);
            SetSkill(SkillName.Anatomy, 80.0, 90.0);
            SetSkill(SkillName.Swords, 80.0, 90.0);
            SetSkill(SkillName.Macing, 80.0, 90.0);
            SetSkill(SkillName.Fencing, 80.0, 90.0);
            SetSkill(SkillName.Wrestling, 80.0, 90.0);
            SetSkill(SkillName.Parry, 50.0, 60.0);
            SetSkill(SkillName.MagicResist, 50.0, 60.0);
            SetSkill(SkillName.DetectHidden, 90.0, 100.0);
            SetSkill(SkillName.Hiding, 90.0, 100.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 32;
            MinTameSkill = 90;
        }

        public override string DefaultName => "a frost wolf";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluGiantblackbear : BaseCreature
    {
        [Constructible]
        public ZuluGiantblackbear() : base(AIType.AI_Melee)
        {
            Body = 213;
            Hue = 0x485;
            BaseSoundID = 0x64;

            SetStr(250);
            SetDex(100);
            SetInt(50);
            SetHits(150);
            SetMana(50);
            SetStam(600);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);

            SetSkill(SkillName.Tactics, 110.0, 120.0);
            SetSkill(SkillName.Anatomy, 110.0, 120.0);
            SetSkill(SkillName.Swords, 110.0, 120.0);
            SetSkill(SkillName.Macing, 110.0, 120.0);
            SetSkill(SkillName.Fencing, 110.0, 120.0);
            SetSkill(SkillName.Wrestling, 110.0, 120.0);
            SetSkill(SkillName.Parry, 70.0, 80.0);
            SetSkill(SkillName.MagicResist, 70.0, 80.0);
            SetSkill(SkillName.DetectHidden, 100.0, 110.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 42;
            MinTameSkill = 110;
        }

        public override string DefaultName => "a giant black bear";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluGiantserpent : BaseCreature
    {
        [Constructible]
        public ZuluGiantserpent() : base(AIType.AI_Melee)
        {
            Body = 21;

            SetStr(215);
            SetDex(80);
            SetInt(85);
            SetHits(215);
            SetMana(85);
            SetStam(80);

            SetDamage(8, 25);
            z_Physical_DD = 50;
            z_Poison_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 60.0, 70.0);
            SetSkill(SkillName.Swords, 70.0, 80.0);
            SetSkill(SkillName.Parry, 40.0, 50.0);
            SetSkill(SkillName.MagicResist, 30.0, 40.0);
            SetSkill(SkillName.Poisoning, 80.0, 90.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 24;
            MinTameSkill = 80;
        }

        public override string DefaultName => "a giant serpent";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluGoldenostard : BaseCreature
    {
        [Constructible]
        public ZuluGoldenostard() : base(AIType.AI_Mage)
        {
            Body = 218;
            Hue = 0x7AD;
            BaseSoundID = 0xB7;

            SetStr(375);
            SetDex(200);
            SetInt(75);
            SetHits(375);
            SetMana(0);
            SetStam(600);

            SetDamage(12, 35);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.FireProtection, 100, 100);
            AddMobZuluModifier(ZuluMod.EarthProtection, 40, 40);

            SetSkill(SkillName.Tactics, 105.0, 115.0);
            SetSkill(SkillName.Anatomy, 105.0, 115.0);
            SetSkill(SkillName.Swords, 105.0, 115.0);
            SetSkill(SkillName.Macing, 105.0, 115.0);
            SetSkill(SkillName.Fencing, 105.0, 115.0);
            SetSkill(SkillName.Wrestling, 105.0, 115.0);
            SetSkill(SkillName.Parry, 105.0, 115.0);
            SetSkill(SkillName.MagicResist, 105.0, 115.0);
            SetSkill(SkillName.DetectHidden, 105.0, 115.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 61;
            MinTameSkill = 130;
        }

        public override string DefaultName => "a golden ostard";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluGorilla : BaseCreature
    {
        [Constructible]
        public ZuluGorilla() : base(AIType.AI_Melee)
        {
            Body = 29;
            Hue = 0x83F8;
            BaseSoundID = 0xA3;

            SetStr(125);
            SetDex(80);
            SetInt(30);
            SetHits(75);
            SetMana(0);
            SetStam(600);

            SetDamage(5, 15);
            z_Physical_DD = 100;

            SetSkill(SkillName.Tactics, 30.0, 40.0);
            SetSkill(SkillName.Anatomy, 60.0, 70.0);
            SetSkill(SkillName.Swords, 40.0, 50.0);
            SetSkill(SkillName.Macing, 40.0, 50.0);
            SetSkill(SkillName.Fencing, 40.0, 50.0);
            SetSkill(SkillName.Wrestling, 40.0, 50.0);
            SetSkill(SkillName.Parry, 40.0, 50.0);
            SetSkill(SkillName.MagicResist, 40.0, 50.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 26;
            MinTameSkill = 75;
        }

        public override string DefaultName => "a gorilla";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluGrat : BaseCreature
    {
        [Constructible]
        public ZuluGrat() : base(AIType.AI_Melee)
        {
            Body = 215;
            Hue = 0x83F8;
            BaseSoundID = 0x18D;

            SetStr(40);
            SetDex(20);
            SetInt(40);
            SetHits(40);
            SetMana(0);
            SetStam(600);

            SetDamage(5, 15);
            z_Physical_DD = 100;

            SetSkill(SkillName.Tactics, 10.0, 20.0);
            SetSkill(SkillName.Anatomy, 10.0, 20.0);
            SetSkill(SkillName.Swords, 10.0, 20.0);
            SetSkill(SkillName.Macing, 10.0, 20.0);
            SetSkill(SkillName.Fencing, 10.0, 20.0);
            SetSkill(SkillName.Wrestling, 10.0, 20.0);
            SetSkill(SkillName.Parry, 25.0, 35.0);
            SetSkill(SkillName.MagicResist, 10.0, 20.0);
            SetSkill(SkillName.DetectHidden, 20.0, 30.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 15;
            MinTameSkill = 40;
        }

        public override string DefaultName => "a giant rat";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluGrizzly : BaseCreature
    {
        [Constructible]
        public ZuluGrizzly() : base(AIType.AI_Melee)
        {
            Body = 212;
            Hue = 0x83F8;
            BaseSoundID = 0x64;

            SetStr(175);
            SetDex(50);
            SetInt(50);
            SetHits(175);
            SetMana(50);
            SetStam(600);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Anatomy, 90.0, 100.0);
            SetSkill(SkillName.Swords, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.Fencing, 90.0, 100.0);
            SetSkill(SkillName.Wrestling, 90.0, 100.0);
            SetSkill(SkillName.Parry, 60.0, 70.0);
            SetSkill(SkillName.MagicResist, 60.0, 70.0);
            SetSkill(SkillName.DetectHidden, 90.0, 100.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 37;
            MinTameSkill = 90;
        }

        public override string DefaultName => "a grizzly bear";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluHarpy : BaseCreature
    {
        [Constructible]
        public ZuluHarpy() : base(AIType.AI_Melee)
        {
            Body = 30;
            BaseSoundID = 0x197;

            SetStr(80);
            SetDex(60);
            SetInt(50);
            SetHits(160);
            SetMana(0);
            SetStam(600);

            SetDamage(5, 15);
            z_Physical_DD = 100;

            SetSkill(SkillName.Tactics, 40.0, 50.0);
            SetSkill(SkillName.Anatomy, 50.0, 60.0);
            SetSkill(SkillName.Swords, 50.0, 60.0);
            SetSkill(SkillName.Macing, 50.0, 60.0);
            SetSkill(SkillName.Fencing, 50.0, 60.0);
            SetSkill(SkillName.Wrestling, 50.0, 60.0);
            SetSkill(SkillName.Parry, 55.0, 65.0);
            SetSkill(SkillName.MagicResist, 75.0, 85.0);
            SetSkill(SkillName.DetectHidden, 40.0, 50.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 38;
        }

        public override string DefaultName => "a harpy";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluHighlandostard : BaseCreature
    {
        [Constructible]
        public ZuluHighlandostard() : base(AIType.AI_Animal)
        {
            Body = 218;
            Hue = 0x489;
            BaseSoundID = 0xB7;

            SetStr(275);
            SetDex(200);
            SetInt(75);
            SetHits(275);
            SetMana(0);
            SetStam(600);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.AirProtection, 30, 30);

            SetSkill(SkillName.Tactics, 65.0, 75.0);
            SetSkill(SkillName.Anatomy, 80.0, 90.0);
            SetSkill(SkillName.Swords, 65.0, 75.0);
            SetSkill(SkillName.Macing, 65.0, 75.0);
            SetSkill(SkillName.Fencing, 65.0, 75.0);
            SetSkill(SkillName.Wrestling, 65.0, 75.0);
            SetSkill(SkillName.Parry, 65.0, 75.0);
            SetSkill(SkillName.MagicResist, 80.0, 90.0);
            SetSkill(SkillName.DetectHidden, 65.0, 75.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 43;
            MinTameSkill = 75;
        }

        public override string DefaultName => "a highland ostard";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluHiryu : BaseCreature
    {
        [Constructible]
        public ZuluHiryu() : base(AIType.AI_Melee)
        {
            Body = 243;
            BaseSoundID = 0x396;

            SetStr(500);
            SetDex(600);
            SetInt(400);
            SetHits(350);
            SetMana(400);
            SetStam(600);

            SetDamage(18, 50);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.WaterProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.AirProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.EarthProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 5, 5);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Anatomy, 90.0, 100.0);
            SetSkill(SkillName.Swords, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.Fencing, 90.0, 100.0);
            SetSkill(SkillName.Wrestling, 90.0, 100.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 90.0, 100.0);
            SetSkill(SkillName.DetectHidden, 90.0, 100.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 53;
            MinTameSkill = 140;
        }

        public override string DefaultName => "a hiryu";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluIceostard : BaseCreature
    {
        [Constructible]
        public ZuluIceostard() : base(AIType.AI_Melee)
        {
            Body = 210;
            Hue = 0x480;
            BaseSoundID = 0xB7;

            SetStr(300);
            SetDex(200);
            SetInt(75);
            SetHits(200);
            SetMana(0);
            SetStam(600);

            SetDamage(12, 35);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.WaterProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.AirProtection, 10, 10);

            SetSkill(SkillName.Tactics, 85.0, 95.0);
            SetSkill(SkillName.Anatomy, 85.0, 95.0);
            SetSkill(SkillName.Swords, 85.0, 95.0);
            SetSkill(SkillName.Macing, 85.0, 95.0);
            SetSkill(SkillName.Fencing, 85.0, 95.0);
            SetSkill(SkillName.Wrestling, 85.0, 95.0);
            SetSkill(SkillName.Parry, 85.0, 95.0);
            SetSkill(SkillName.MagicResist, 85.0, 95.0);
            SetSkill(SkillName.DetectHidden, 85.0, 95.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 50;
            MinTameSkill = 105;
        }

        public override string DefaultName => "an ice ostard";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluLegendarysnake : BaseCreature
    {
        [Constructible]
        public ZuluLegendarysnake() : base(AIType.AI_Melee)
        {
            Body = 21;
            Hue = 0x488;
            BaseSoundID = 0x2C2;

            SetStr(500);
            SetDex(600);
            SetInt(100);
            SetHits(2000);
            SetMana(100);
            SetStam(600);

            SetDamage(18, 50);
            z_Physical_DD = 50;
            z_Poison_DD = 50;

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

        public override string DefaultName => "The Legendary Snake";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluLurker : BaseCreature
    {
        [Constructible]
        public ZuluLurker() : base(AIType.AI_Melee)
        {
            Body = 244;
            Hue = 0x7B2;
            BaseSoundID = 0x27F;

            SetStr(500);
            SetDex(100);
            SetInt(150);
            SetHits(3000);
            SetMana(150);
            SetStam(100);

            SetDamage(18, 50);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.WaterProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.AirProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.HollyProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.EarthProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 4, 4);

            SetSkill(SkillName.Tactics, 110.0, 120.0);
            SetSkill(SkillName.Anatomy, 110.0, 120.0);
            SetSkill(SkillName.Swords, 110.0, 120.0);
            SetSkill(SkillName.Macing, 110.0, 120.0);
            SetSkill(SkillName.Fencing, 110.0, 120.0);
            SetSkill(SkillName.Wrestling, 110.0, 120.0);
            SetSkill(SkillName.Parry, 100.0, 110.0);
            SetSkill(SkillName.MagicResist, 100.0, 110.0);
            SetSkill(SkillName.DetectHidden, 120.0, 130.0);
            SetSkill(SkillName.Hiding, 120.0, 130.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 58;
        }

        public override string DefaultName => "a lurker";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluMetallicostard : BaseCreature
    {
        [Constructible]
        public ZuluMetallicostard() : base(AIType.AI_Melee)
        {
            Body = 218;
            Hue = 0x7B2;
            BaseSoundID = 0xB7;

            SetStr(350);
            SetDex(200);
            SetInt(75);
            SetHits(350);
            SetMana(0);
            SetStam(600);

            SetDamage(12, 35);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 80, 80);

            SetSkill(SkillName.Tactics, 100.0, 110.0);
            SetSkill(SkillName.Anatomy, 100.0, 110.0);
            SetSkill(SkillName.Swords, 100.0, 110.0);
            SetSkill(SkillName.Macing, 100.0, 110.0);
            SetSkill(SkillName.Fencing, 100.0, 110.0);
            SetSkill(SkillName.Wrestling, 100.0, 110.0);
            SetSkill(SkillName.Parry, 100.0, 110.0);
            SetSkill(SkillName.MagicResist, 100.0, 110.0);
            SetSkill(SkillName.DetectHidden, 100.0, 110.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 58;
            MinTameSkill = 125;
        }

        public override string DefaultName => "a metallic ostard";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluMongbat : BaseCreature
    {
        [Constructible]
        public ZuluMongbat() : base(AIType.AI_Melee)
        {
            Body = 39;
            BaseSoundID = 0x1AB;

            SetStr(20);
            SetDex(60);
            SetInt(35);
            SetHits(35);
            SetMana(0);
            SetStam(50);

            SetDamage(5, 15);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 40.0, 50.0);
            SetSkill(SkillName.Swords, 30.0, 40.0);
            SetSkill(SkillName.Parry, 45.0, 55.0);
            SetSkill(SkillName.MagicResist, 0.1, 10.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 20;
            MinTameSkill = 25;
        }

        public override string DefaultName => "a mongbat";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluMountaingoat : BaseCreature
    {
        [Constructible]
        public ZuluMountaingoat() : base(AIType.AI_Melee)
        {
            Body = 209;
            Hue = 0x498;
            BaseSoundID = 0x9E;

            SetStr(70);
            SetDex(20);
            SetInt(20);
            SetHits(60);
            SetMana(0);
            SetStam(600);

            SetDamage(5, 15);
            z_Physical_DD = 100;

            SetSkill(SkillName.Tactics, 5.0, 15.0);
            SetSkill(SkillName.Anatomy, 40.0, 50.0);
            SetSkill(SkillName.Swords, 10.0, 20.0);
            SetSkill(SkillName.Macing, 10.0, 20.0);
            SetSkill(SkillName.Fencing, 10.0, 20.0);
            SetSkill(SkillName.Wrestling, 10.0, 20.0);
            SetSkill(SkillName.Parry, 30.0, 40.0);
            SetSkill(SkillName.MagicResist, 30.0, 40.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 21;
            MinTameSkill = 60;
        }

        public override string DefaultName => "a mountain goat";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluMountainlion : BaseCreature
    {
        [Constructible]
        public ZuluMountainlion() : base(AIType.AI_Melee)
        {
            Body = 214;
            Hue = 0x488;
            BaseSoundID = 0x3F3;

            SetStr(250);
            SetDex(120);
            SetInt(50);
            SetHits(150);
            SetMana(50);
            SetStam(600);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.AirProtection, 20, 20);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Anatomy, 90.0, 100.0);
            SetSkill(SkillName.Swords, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.Fencing, 90.0, 100.0);
            SetSkill(SkillName.Wrestling, 90.0, 100.0);
            SetSkill(SkillName.Parry, 60.0, 70.0);
            SetSkill(SkillName.MagicResist, 70.0, 80.0);
            SetSkill(SkillName.DetectHidden, 100.0, 110.0);
            SetSkill(SkillName.Hiding, 90.0, 100.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 39;
            MinTameSkill = 95;
        }

        public override string DefaultName => "a mountain lion";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluMountainostard : BaseCreature
    {
        [Constructible]
        public ZuluMountainostard() : base(AIType.AI_Animal)
        {
            Body = 218;
            Hue = 0x488;
            BaseSoundID = 0xB7;

            SetStr(150);
            SetDex(200);
            SetInt(35);
            SetHits(150);
            SetMana(0);
            SetStam(600);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.AirProtection, 10, 10);

            SetSkill(SkillName.Tactics, 40.0, 50.0);
            SetSkill(SkillName.Anatomy, 65.0, 75.0);
            SetSkill(SkillName.Swords, 40.0, 50.0);
            SetSkill(SkillName.Macing, 40.0, 50.0);
            SetSkill(SkillName.Fencing, 40.0, 50.0);
            SetSkill(SkillName.Wrestling, 40.0, 50.0);
            SetSkill(SkillName.Parry, 40.0, 50.0);
            SetSkill(SkillName.MagicResist, 50.0, 60.0);
            SetSkill(SkillName.DetectHidden, 30.0, 40.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 28;
            MinTameSkill = 65;
        }

        public override string DefaultName => "a mountain ostard";

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluNightwolf : BaseCreature
    {
        [Constructible]
        public ZuluNightwolf() : base(AIType.AI_Melee)
        {
            Body = 400;
            Hue = 0x3EA;
            BaseSoundID = 0x2C2;

            SetStr(500);
            SetDex(300);
            SetInt(100);
            SetHits(700);
            SetMana(100);
            SetStam(600);

            SetDamage(18, 50);
            z_Physical_DD = 100;

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
        }

        public override string DefaultName => "Nightwolf, the Zulu Chief";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluPanther : BaseCreature
    {
        [Constructible]
        public ZuluPanther() : base(AIType.AI_Melee)
        {
            Body = 214;
            Hue = 0x901;
            BaseSoundID = 0xBC;

            SetStr(200);
            SetDex(100);
            SetInt(50);
            SetHits(100);
            SetMana(50);
            SetStam(600);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Anatomy, 90.0, 100.0);
            SetSkill(SkillName.Swords, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.Fencing, 90.0, 100.0);
            SetSkill(SkillName.Wrestling, 90.0, 100.0);
            SetSkill(SkillName.Parry, 60.0, 70.0);
            SetSkill(SkillName.MagicResist, 60.0, 70.0);
            SetSkill(SkillName.DetectHidden, 100.0, 110.0);
            SetSkill(SkillName.Hiding, 90.0, 100.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 37;
            MinTameSkill = 85;
        }

        public override string DefaultName => "a panther";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluPoisonostard : BaseCreature
    {
        [Constructible]
        public ZuluPoisonostard() : base(AIType.AI_Melee)
        {
            Body = 218;
            Hue = 0xB59;
            BaseSoundID = 0xB7;

            SetStr(175);
            SetDex(200);
            SetInt(75);
            SetHits(175);
            SetMana(0);
            SetStam(600);

            SetDamage(8, 25);
            z_Physical_DD = 50;
            z_Poison_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 75.0, 85.0);
            SetSkill(SkillName.Anatomy, 85.0, 95.0);
            SetSkill(SkillName.Swords, 75.0, 85.0);
            SetSkill(SkillName.Macing, 75.0, 85.0);
            SetSkill(SkillName.Fencing, 75.0, 85.0);
            SetSkill(SkillName.Wrestling, 75.0, 85.0);
            SetSkill(SkillName.Parry, 75.0, 85.0);
            SetSkill(SkillName.MagicResist, 85.0, 95.0);
            SetSkill(SkillName.DetectHidden, 75.0, 85.0);
            SetSkill(SkillName.Poisoning, 65.0, 75.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 47;
            MinTameSkill = 85;
        }

        public override string DefaultName => "a poison ostard";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluPolar : BaseCreature
    {
        [Constructible]
        public ZuluPolar() : base(AIType.AI_Melee)
        {
            Body = 213;
            Hue = 0x83F8;
            BaseSoundID = 0x64;

            SetStr(200);
            SetDex(100);
            SetInt(50);
            SetHits(200);
            SetMana(50);
            SetStam(600);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.WaterProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.AirProtection, 20, 20);

            SetSkill(SkillName.Tactics, 110.0, 120.0);
            SetSkill(SkillName.Anatomy, 110.0, 120.0);
            SetSkill(SkillName.Swords, 110.0, 120.0);
            SetSkill(SkillName.Macing, 110.0, 120.0);
            SetSkill(SkillName.Fencing, 110.0, 120.0);
            SetSkill(SkillName.Wrestling, 110.0, 120.0);
            SetSkill(SkillName.Parry, 70.0, 80.0);
            SetSkill(SkillName.MagicResist, 70.0, 80.0);
            SetSkill(SkillName.DetectHidden, 100.0, 110.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 42;
            MinTameSkill = 105;
        }

        public override string DefaultName => "a polar bear";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluPrismaticostard : BaseCreature
    {
        [Constructible]
        public ZuluPrismaticostard() : base(AIType.AI_Mage)
        {
            Body = 219;
            Hue = 0x512;
            BaseSoundID = 0xB7;

            SetStr(350);
            SetDex(200);
            SetInt(100);
            SetHits(600);
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
            SetSkill(SkillName.Poisoning, 100.0, 110.0);

            Fame = 35000;
            Karma = -35000;
            VirtualArmor = 58;
            MinTameSkill = 140;
        }

        public override string DefaultName => "a prismatic ostard";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluRagingbull : BaseCreature
    {
        [Constructible]
        public ZuluRagingbull() : base(AIType.AI_Melee)
        {
            Body = 232;
            Hue = 0x7B2;

            SetStr(2250);
            SetDex(1200);
            SetInt(1000);
            SetHits(10000);
            SetMana(3000);
            SetStam(3000);

            SetDamage(40, 100);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.WaterProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.AirProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.NecroProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.HollyProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.EarthProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 4, 4);

            SetSkill(SkillName.Tactics, 140.0, 150.0);
            SetSkill(SkillName.Macing, 190.0, 200.0);
            SetSkill(SkillName.MagicResist, 100.0, 110.0);
            SetSkill(SkillName.DetectHidden, 115.0, 125.0);
            SetSkill(SkillName.Magery, 140.0, 150.0);

            Fame = 35000;
            Karma = -35000;
            VirtualArmor = 22;
        }

        public override string DefaultName => "The Raging Bull";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluReaper : BaseCreature
    {
        [Constructible]
        public ZuluReaper() : base(AIType.AI_Melee)
        {
            Body = 47;

            SetStr(210);
            SetDex(110);
            SetInt(35);
            SetHits(210);
            SetMana(25);
            SetStam(100);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.EarthProtection, 40, 40);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Macing, 140.0, 150.0);
            SetSkill(SkillName.Parry, 50.0, 60.0);
            SetSkill(SkillName.MagicResist, 65.0, 75.0);
            SetSkill(SkillName.Magery, 90.0, 100.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 35;
        }

        public override string DefaultName => "a reaper";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluRiverserpent : BaseCreature
    {
        [Constructible]
        public ZuluRiverserpent() : base(AIType.AI_Melee)
        {
            Body = 21;
            Hue = 0x489;

            SetStr(215);
            SetDex(80);
            SetInt(85);
            SetHits(215);
            SetMana(85);
            SetStam(80);

            SetDamage(8, 25);
            z_Physical_DD = 50;
            z_Poison_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 60.0, 70.0);
            SetSkill(SkillName.Swords, 70.0, 80.0);
            SetSkill(SkillName.Parry, 40.0, 50.0);
            SetSkill(SkillName.MagicResist, 30.0, 40.0);
            SetSkill(SkillName.Poisoning, 80.0, 90.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 24;
            MinTameSkill = 80;
        }

        public override string DefaultName => "a river serpent";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluRockscorpion : BaseCreature
    {
        [Constructible]
        public ZuluRockscorpion() : base(AIType.AI_Melee)
        {
            Body = 48;
            Hue = 0x484;
            BaseSoundID = 0x192;

            SetStr(230);
            SetDex(80);
            SetInt(40);
            SetHits(500);
            SetMana(40);
            SetStam(80);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 30, 30);

            SetSkill(SkillName.Tactics, 60.0, 70.0);
            SetSkill(SkillName.Macing, 120.0, 130.0);
            SetSkill(SkillName.MagicResist, 40.0, 50.0);
            SetSkill(SkillName.Poisoning, 90.0, 100.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 10;
            MinTameSkill = 85;
        }

        public override string DefaultName => "a giant rock scorpion";
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluRubyostard : BaseCreature
    {
        [Constructible]
        public ZuluRubyostard() : base(AIType.AI_Mage)
        {
            Body = 210;
            Hue = 0x494;
            BaseSoundID = 0xB7;

            SetStr(275);
            SetDex(200);
            SetInt(75);
            SetHits(275);
            SetMana(0);
            SetStam(600);

            SetDamage(8, 25);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.FireProtection, 40, 40);

            SetSkill(SkillName.Tactics, 95.0, 105.0);
            SetSkill(SkillName.Anatomy, 95.0, 105.0);
            SetSkill(SkillName.Swords, 95.0, 105.0);
            SetSkill(SkillName.Macing, 95.0, 105.0);
            SetSkill(SkillName.Fencing, 95.0, 105.0);
            SetSkill(SkillName.Wrestling, 95.0, 105.0);
            SetSkill(SkillName.Parry, 95.0, 105.0);
            SetSkill(SkillName.MagicResist, 95.0, 105.0);
            SetSkill(SkillName.DetectHidden, 95.0, 105.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 56;
            MinTameSkill = 120;
        }

        public override string DefaultName => "a ruby ostard";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluSamlethefairy : BaseCreature
    {
        [Constructible]
        public ZuluSamlethefairy() : base(AIType.AI_Mage)
        {
            Body = 264;
            Hue = 0x488;
            BaseSoundID = 0x375;

            SetStr(750);
            SetDex(750);
            SetInt(700);
            SetHits(3000);
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

        public override string DefaultName => "a samlethe fairy";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluSamletheostard : BaseCreature
    {
        [Constructible]
        public ZuluSamletheostard() : base(AIType.AI_Melee)
        {
            Body = 218;
            Hue = 0x496;
            BaseSoundID = 0xB7;

            SetStr(350);
            SetDex(200);
            SetInt(75);
            SetHits(350);
            SetMana(0);
            SetStam(600);

            SetDamage(12, 35);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.NecroProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 8, 8);

            SetSkill(SkillName.Tactics, 100.0, 110.0);
            SetSkill(SkillName.Anatomy, 100.0, 110.0);
            SetSkill(SkillName.Swords, 100.0, 110.0);
            SetSkill(SkillName.Macing, 100.0, 110.0);
            SetSkill(SkillName.Fencing, 100.0, 110.0);
            SetSkill(SkillName.Wrestling, 100.0, 110.0);
            SetSkill(SkillName.Parry, 100.0, 110.0);
            SetSkill(SkillName.MagicResist, 100.0, 110.0);
            SetSkill(SkillName.DetectHidden, 100.0, 110.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 58;
            MinTameSkill = 125;
        }

        public override string DefaultName => "a samlethe ostard";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluSandostard : BaseCreature
    {
        [Constructible]
        public ZuluSandostard() : base(AIType.AI_Melee)
        {
            Body = 218;
            Hue = 0x497;
            BaseSoundID = 0xB7;

            SetStr(250);
            SetDex(200);
            SetInt(75);
            SetHits(250);
            SetMana(0);
            SetStam(600);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.FireProtection, 40, 40);

            SetSkill(SkillName.Tactics, 80.0, 90.0);
            SetSkill(SkillName.Anatomy, 80.0, 90.0);
            SetSkill(SkillName.Swords, 80.0, 90.0);
            SetSkill(SkillName.Macing, 80.0, 90.0);
            SetSkill(SkillName.Fencing, 80.0, 90.0);
            SetSkill(SkillName.Wrestling, 80.0, 90.0);
            SetSkill(SkillName.Parry, 80.0, 90.0);
            SetSkill(SkillName.MagicResist, 80.0, 90.0);
            SetSkill(SkillName.DetectHidden, 80.0, 90.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 48;
            MinTameSkill = 100;
        }

        public override string DefaultName => "a sand ostard";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluScorp : BaseCreature
    {
        [Constructible]
        public ZuluScorp() : base(AIType.AI_Melee)
        {
            Body = 48;
            BaseSoundID = 0x192;

            SetStr(100);
            SetDex(120);
            SetInt(35);
            SetHits(100);
            SetMana(25);
            SetStam(90);

            SetDamage(5, 15);
            z_Physical_DD = 50;
            z_Poison_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 65.0, 75.0);
            SetSkill(SkillName.Anatomy, 65.0, 75.0);
            SetSkill(SkillName.Swords, 65.0, 75.0);
            SetSkill(SkillName.Macing, 65.0, 75.0);
            SetSkill(SkillName.Fencing, 65.0, 75.0);
            SetSkill(SkillName.Wrestling, 65.0, 75.0);
            SetSkill(SkillName.Parry, 60.0, 70.0);
            SetSkill(SkillName.MagicResist, 30.0, 40.0);
            SetSkill(SkillName.DetectHidden, 25.0, 35.0);
            SetSkill(SkillName.Poisoning, 80.0, 90.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 31;
            MinTameSkill = 70;
        }

        public override string DefaultName => "a giant scorpion";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluSeweralligator : BaseCreature
    {
        [Constructible]
        public ZuluSeweralligator() : base(AIType.AI_Melee)
        {
            Body = 202;
            Hue = 0x499;
            BaseSoundID = 0x5F;

            SetStr(250);
            SetDex(100);
            SetInt(50);
            SetHits(250);
            SetMana(50);
            SetStam(100);

            SetDamage(8, 25);
            z_Physical_DD = 50;
            z_Poison_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);

            SetSkill(SkillName.Tactics, 100.0, 110.0);
            SetSkill(SkillName.Anatomy, 100.0, 110.0);
            SetSkill(SkillName.Swords, 100.0, 110.0);
            SetSkill(SkillName.Macing, 100.0, 110.0);
            SetSkill(SkillName.Fencing, 100.0, 110.0);
            SetSkill(SkillName.Wrestling, 100.0, 110.0);
            SetSkill(SkillName.Parry, 70.0, 80.0);
            SetSkill(SkillName.MagicResist, 50.0, 60.0);
            SetSkill(SkillName.DetectHidden, 70.0, 80.0);
            SetSkill(SkillName.Poisoning, 65.0, 75.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 38;
            MinTameSkill = 85;
        }

        public override string DefaultName => "a sewer alligator";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluSilverbullet : BaseCreature
    {
        [Constructible]
        public ZuluSilverbullet() : base(AIType.AI_Melee)
        {
            Body = 284;
            Hue = 0x484;

            SetStr(2250);
            SetDex(1200);
            SetInt(1000);
            SetHits(10000);
            SetMana(3000);
            SetStam(3000);

            SetDamage(40, 100);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.FireProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.WaterProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.AirProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.EarthProtection, 100, 100);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 2, 2);

            SetSkill(SkillName.Tactics, 140.0, 150.0);
            SetSkill(SkillName.Macing, 165.0, 175.0);
            SetSkill(SkillName.MagicResist, 50.0, 60.0);
            SetSkill(SkillName.DetectHidden, 190.0, 200.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 12;
            MinTameSkill = 135;
        }

        public override string DefaultName => "a Silver Bullet Stallion";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluSparkmandrill : BaseCreature
    {
        [Constructible]
        public ZuluSparkmandrill() : base(AIType.AI_Melee)
        {
            Body = 29;
            Hue = 0x49D;
            BaseSoundID = 0xA3;

            SetStr(200);
            SetDex(160);
            SetInt(30);
            SetHits(100);
            SetMana(0);
            SetStam(600);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.AirProtection, 30, 30);

            SetSkill(SkillName.Tactics, 80.0, 90.0);
            SetSkill(SkillName.Anatomy, 80.0, 90.0);
            SetSkill(SkillName.Swords, 80.0, 90.0);
            SetSkill(SkillName.Macing, 80.0, 90.0);
            SetSkill(SkillName.Fencing, 80.0, 90.0);
            SetSkill(SkillName.Wrestling, 80.0, 90.0);
            SetSkill(SkillName.Parry, 80.0, 90.0);
            SetSkill(SkillName.MagicResist, 80.0, 90.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 48;
            MinTameSkill = 110;
        }

        public override string DefaultName => "a spark mandrill";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluSteelpanther : BaseCreature
    {
        [Constructible]
        public ZuluSteelpanther() : base(AIType.AI_Melee)
        {
            Body = 214;
            Hue = 0x502;
            BaseSoundID = 0x3F3;

            SetStr(2000);
            SetDex(600);
            SetInt(50);
            SetHits(300);
            SetMana(50);
            SetStam(600);

            SetDamage(40, 100);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.WaterProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.AirProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.EarthProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 2, 2);

            SetSkill(SkillName.Tactics, 100.0, 110.0);
            SetSkill(SkillName.Anatomy, 100.0, 110.0);
            SetSkill(SkillName.Swords, 100.0, 110.0);
            SetSkill(SkillName.Macing, 100.0, 110.0);
            SetSkill(SkillName.Fencing, 100.0, 110.0);
            SetSkill(SkillName.Wrestling, 100.0, 110.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 80.0, 90.0);
            SetSkill(SkillName.DetectHidden, 115.0, 125.0);
            SetSkill(SkillName.Hiding, 90.0, 100.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 51;
            MinTameSkill = 120;
        }

        public override string DefaultName => "a steel panther";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluStoneostard : BaseCreature
    {
        [Constructible]
        public ZuluStoneostard() : base(AIType.AI_Melee)
        {
            Body = 210;
            Hue = 0x484;
            BaseSoundID = 0xB7;

            SetStr(300);
            SetDex(200);
            SetInt(75);
            SetHits(125);
            SetMana(0);
            SetStam(600);

            SetDamage(12, 35);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);

            SetSkill(SkillName.Tactics, 80.0, 90.0);
            SetSkill(SkillName.Anatomy, 85.0, 95.0);
            SetSkill(SkillName.Swords, 80.0, 90.0);
            SetSkill(SkillName.Macing, 80.0, 90.0);
            SetSkill(SkillName.Fencing, 80.0, 90.0);
            SetSkill(SkillName.Wrestling, 80.0, 90.0);
            SetSkill(SkillName.Parry, 80.0, 90.0);
            SetSkill(SkillName.MagicResist, 85.0, 95.0);
            SetSkill(SkillName.DetectHidden, 80.0, 90.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 49;
            MinTameSkill = 90;
        }

        public override string DefaultName => "a stone ostard";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluSunkencolony : BaseCreature
    {
        [Constructible]
        public ZuluSunkencolony() : base(AIType.AI_Melee)
        {
            Body = 8;
            Hue = 0x488;
            BaseSoundID = 0x162;

            SetStr(500);
            SetDex(1000);
            SetInt(150);
            SetHits(2000);
            SetMana(0);
            SetStam(2000);

            SetDamage(18, 50);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.WaterProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.AirProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.HollyProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.EarthProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 4, 4);

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

        public override string DefaultName => "a sunken colony";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluSwampboar : BaseCreature
    {
        [Constructible]
        public ZuluSwampboar() : base(AIType.AI_Melee)
        {
            Body = 290;
            Hue = 0x7D6;
            BaseSoundID = 0xC9;

            SetStr(115);
            SetDex(65);
            SetInt(30);
            SetHits(85);
            SetMana(0);
            SetStam(600);

            SetDamage(5, 15);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 20, 20);

            SetSkill(SkillName.Tactics, 40.0, 50.0);
            SetSkill(SkillName.Anatomy, 60.0, 70.0);
            SetSkill(SkillName.Swords, 40.0, 50.0);
            SetSkill(SkillName.Macing, 40.0, 50.0);
            SetSkill(SkillName.Fencing, 40.0, 50.0);
            SetSkill(SkillName.Wrestling, 40.0, 50.0);
            SetSkill(SkillName.Parry, 40.0, 50.0);
            SetSkill(SkillName.MagicResist, 30.0, 40.0);
            SetSkill(SkillName.DetectHidden, 30.0, 40.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 24;
            MinTameSkill = 70;
        }

        public override string DefaultName => "a swamp boar";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluTerathandrone : BaseCreature
    {
        [Constructible]
        public ZuluTerathandrone() : base(AIType.AI_Melee)
        {
            Body = 71;

            SetStr(100);
            SetDex(305);
            SetInt(55);
            SetHits(500);
            SetMana(0);
            SetStam(125);

            SetDamage(5, 15);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 100.0, 110.0);
            SetSkill(SkillName.Swords, 100.0, 110.0);
            SetSkill(SkillName.Parry, 145.0, 155.0);
            SetSkill(SkillName.MagicResist, 50.0, 60.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 63;
        }

        public override string DefaultName => "a Terathan Drone";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluTerathanmatriarch : BaseCreature
    {
        [Constructible]
        public ZuluTerathanmatriarch() : base(AIType.AI_Mage)
        {
            Body = 72;
            BaseSoundID = 0x34C;

            SetStr(300);
            SetDex(800);
            SetInt(3000);
            SetHits(5000);
            SetMana(50000);
            SetStam(20000);

            SetDamage(12, 35);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.FireProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.WaterProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.AirProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.HollyProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.EarthProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 6, 6);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Anatomy, 120.0, 130.0);
            SetSkill(SkillName.Swords, 120.0, 130.0);
            SetSkill(SkillName.Macing, 120.0, 130.0);
            SetSkill(SkillName.Fencing, 120.0, 130.0);
            SetSkill(SkillName.Wrestling, 65.0, 75.0);
            SetSkill(SkillName.Parry, 120.0, 130.0);
            SetSkill(SkillName.MagicResist, 120.0, 130.0);
            SetSkill(SkillName.DetectHidden, 130.0, 140.0);
            SetSkill(SkillName.Magery, 120.0, 130.0);
            SetSkill(SkillName.EvalInt, 120.0, 130.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 69;
        }

        public override string DefaultName => "a Terathan Matriarch";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluTerathansoldier : BaseCreature
    {
        [Constructible]
        public ZuluTerathansoldier() : base(AIType.AI_Melee)
        {
            Body = 70;

            SetStr(600);
            SetDex(300);
            SetInt(250);
            SetHits(1000);
            SetMana(100);
            SetStam(600);

            SetDamage(18, 50);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 120.0, 130.0);
            SetSkill(SkillName.Swords, 130.0, 140.0);
            SetSkill(SkillName.Parry, 140.0, 150.0);
            SetSkill(SkillName.MagicResist, 140.0, 150.0);

            Fame = 5000;
            Karma = -5000;
            VirtualArmor = 80;
        }

        public override string DefaultName => "a Terathan Soldier";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluTerathanwarrior : BaseCreature
    {
        [Constructible]
        public ZuluTerathanwarrior() : base(AIType.AI_Melee)
        {
            Body = 70;

            SetStr(250);
            SetDex(105);
            SetInt(35);
            SetHits(750);
            SetMana(0);
            SetStam(70);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 2, 2);

            SetSkill(SkillName.Tactics, 100.0, 110.0);
            SetSkill(SkillName.Swords, 100.0, 110.0);
            SetSkill(SkillName.Parry, 145.0, 155.0);
            SetSkill(SkillName.MagicResist, 50.0, 60.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 63;
        }

        public override string DefaultName => "a Terathan Warrior";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluThunderbird : BaseCreature
    {
        [Constructible]
        public ZuluThunderbird() : base(AIType.AI_Melee)
        {
            Body = 6;
            Hue = 0x49D;
            BaseSoundID = 0x276;

            SetStr(50);
            SetDex(50);
            SetInt(50);
            SetHits(30);
            SetMana(0);
            SetStam(600);

            SetDamage(5, 15);
            z_Physical_DD = 100;

            SetSkill(SkillName.Tactics, 40.0, 50.0);
            SetSkill(SkillName.Anatomy, 40.0, 50.0);
            SetSkill(SkillName.Swords, 40.0, 50.0);
            SetSkill(SkillName.Macing, 40.0, 50.0);
            SetSkill(SkillName.Fencing, 40.0, 50.0);
            SetSkill(SkillName.Wrestling, 40.0, 50.0);
            SetSkill(SkillName.Parry, 40.0, 50.0);
            SetSkill(SkillName.MagicResist, 40.0, 50.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 26;
            MinTameSkill = 60;
        }

        public override string DefaultName => "a thunderbird";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluToad : BaseCreature
    {
        [Constructible]
        public ZuluToad() : base(AIType.AI_Melee)
        {
            Body = 80;
            Hue = 0x83F8;
            BaseSoundID = 0x26B;

            SetStr(110);
            SetDex(35);
            SetInt(30);
            SetHits(100);
            SetMana(0);
            SetStam(5);

            SetDamage(5, 15);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 50.0, 60.0);
            SetSkill(SkillName.Swords, 50.0, 60.0);
            SetSkill(SkillName.Parry, 62.0, 72.0);
            SetSkill(SkillName.MagicResist, 30.0, 40.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 32;
            MinTameSkill = 80;
        }

        public override string DefaultName => "a giant toad";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluTropicalostard : BaseCreature
    {
        [Constructible]
        public ZuluTropicalostard() : base(AIType.AI_Melee)
        {
            Body = 218;
            Hue = 0x495;
            BaseSoundID = 0x364;

            SetStr(200);
            SetDex(200);
            SetInt(75);
            SetHits(200);
            SetMana(0);
            SetStam(600);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.EarthProtection, 10, 10);

            SetSkill(SkillName.Tactics, 80.0, 90.0);
            SetSkill(SkillName.Anatomy, 85.0, 95.0);
            SetSkill(SkillName.Swords, 80.0, 90.0);
            SetSkill(SkillName.Macing, 80.0, 90.0);
            SetSkill(SkillName.Fencing, 80.0, 90.0);
            SetSkill(SkillName.Wrestling, 80.0, 90.0);
            SetSkill(SkillName.Parry, 80.0, 90.0);
            SetSkill(SkillName.MagicResist, 85.0, 95.0);
            SetSkill(SkillName.DetectHidden, 80.0, 90.0);
            SetSkill(SkillName.Poisoning, 65.0, 75.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 49;
            MinTameSkill = 95;
        }

        public override string DefaultName => "a tropical ostard";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluValkerie : BaseCreature
    {
        [Constructible]
        public ZuluValkerie() : base(AIType.AI_Melee)
        {
            Body = 30;
            Hue = 0x7AD;
            BaseSoundID = 0x39A;

            SetStr(500);
            SetDex(250);
            SetInt(100);
            SetHits(1000);
            SetMana(0);
            SetStam(1200);

            SetDamage(18, 50);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.WaterProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.AirProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.EarthProtection, 50, 50);
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

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 64;
        }

        public override string DefaultName => "a Valkerie";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluWildboar : BaseCreature
    {
        [Constructible]
        public ZuluWildboar() : base(AIType.AI_Melee)
        {
            Body = 290;
            Hue = 0x488;
            BaseSoundID = 0xC9;

            SetStr(100);
            SetDex(40);
            SetInt(30);
            SetHits(75);
            SetMana(0);
            SetStam(600);

            SetDamage(5, 15);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 20, 20);

            SetSkill(SkillName.Tactics, 30.0, 40.0);
            SetSkill(SkillName.Anatomy, 50.0, 60.0);
            SetSkill(SkillName.Swords, 30.0, 40.0);
            SetSkill(SkillName.Macing, 30.0, 40.0);
            SetSkill(SkillName.Fencing, 30.0, 40.0);
            SetSkill(SkillName.Wrestling, 30.0, 40.0);
            SetSkill(SkillName.Parry, 30.0, 40.0);
            SetSkill(SkillName.MagicResist, 30.0, 40.0);
            SetSkill(SkillName.DetectHidden, 20.0, 30.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 21;
            MinTameSkill = 65;
        }

        public override string DefaultName => "a wild boar";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluWindostard : BaseCreature
    {
        [Constructible]
        public ZuluWindostard() : base(AIType.AI_Mage)
        {
            Body = 210;
            Hue = 0x49C;
            BaseSoundID = 0xB7;

            SetStr(250);
            SetDex(200);
            SetInt(125);
            SetHits(250);
            SetMana(125);
            SetStam(600);

            SetDamage(8, 25);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.WaterProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.AirProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.EarthProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 3, 3);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Anatomy, 90.0, 100.0);
            SetSkill(SkillName.Swords, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.Fencing, 90.0, 100.0);
            SetSkill(SkillName.Wrestling, 90.0, 100.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 90.0, 100.0);
            SetSkill(SkillName.DetectHidden, 90.0, 100.0);
            SetSkill(SkillName.Magery, 80.0, 90.0);
            SetSkill(SkillName.EvalInt, 70.0, 80.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 53;
            MinTameSkill = 115;
        }

        public override string DefaultName => "a wind ostard";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluWolf : BaseCreature
    {
        [Constructible]
        public ZuluWolf() : base(AIType.AI_Melee)
        {
            Body = 225;
            Hue = 0x83F8;
            BaseSoundID = 0xEA;

            SetStr(90);
            SetDex(40);
            SetInt(50);
            SetHits(90);
            SetMana(50);
            SetStam(600);

            SetDamage(5, 15);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 65.0, 75.0);
            SetSkill(SkillName.Anatomy, 65.0, 75.0);
            SetSkill(SkillName.Swords, 65.0, 75.0);
            SetSkill(SkillName.Macing, 65.0, 75.0);
            SetSkill(SkillName.Fencing, 65.0, 75.0);
            SetSkill(SkillName.Wrestling, 65.0, 75.0);
            SetSkill(SkillName.Parry, 40.0, 50.0);
            SetSkill(SkillName.MagicResist, 40.0, 50.0);
            SetSkill(SkillName.DetectHidden, 90.0, 100.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 26;
            MinTameSkill = 75;
        }

        public override string DefaultName => "a wolf";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluYewtreesimian : BaseCreature
    {
        [Constructible]
        public ZuluYewtreesimian() : base(AIType.AI_Melee)
        {
            Body = 29;
            Hue = 0x499;
            BaseSoundID = 0xA3;

            SetStr(150);
            SetDex(100);
            SetInt(35);
            SetHits(80);
            SetMana(0);
            SetStam(600);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            SetSkill(SkillName.Tactics, 35.0, 45.0);
            SetSkill(SkillName.Anatomy, 65.0, 75.0);
            SetSkill(SkillName.Swords, 45.0, 55.0);
            SetSkill(SkillName.Macing, 45.0, 55.0);
            SetSkill(SkillName.Fencing, 45.0, 55.0);
            SetSkill(SkillName.Wrestling, 45.0, 55.0);
            SetSkill(SkillName.Parry, 45.0, 55.0);
            SetSkill(SkillName.MagicResist, 45.0, 55.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 29;
            MinTameSkill = 80;
        }

        public override string DefaultName => "an yew tree simian";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluZergling : BaseCreature
    {
        [Constructible]
        public ZuluZergling() : base(AIType.AI_Melee)
        {
            Body = 251;
            Hue = 0x488;
            BaseSoundID = 0x4EA;

            SetStr(800);
            SetDex(900);
            SetInt(100);
            SetHits(500);
            SetMana(100);
            SetStam(600);

            SetDamage(18, 50);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.WaterProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.AirProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.HollyProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.EarthProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 2, 2);

            SetSkill(SkillName.Tactics, 100.0, 110.0);
            SetSkill(SkillName.Anatomy, 100.0, 110.0);
            SetSkill(SkillName.Swords, 100.0, 110.0);
            SetSkill(SkillName.Macing, 100.0, 110.0);
            SetSkill(SkillName.Fencing, 100.0, 110.0);
            SetSkill(SkillName.Wrestling, 100.0, 110.0);
            SetSkill(SkillName.Parry, 100.0, 110.0);
            SetSkill(SkillName.MagicResist, 100.0, 110.0);
            SetSkill(SkillName.DetectHidden, 110.0, 120.0);
            SetSkill(SkillName.Hiding, 90.0, 100.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 58;
            MinTameSkill = 120;
        }

        public override string DefaultName => "a zergling";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }
}
