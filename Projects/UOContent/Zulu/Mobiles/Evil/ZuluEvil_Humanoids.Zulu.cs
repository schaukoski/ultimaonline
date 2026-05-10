using ModernUO.Serialization;
using Server.Items;

namespace Server.Mobiles
{
    // Zulu Hotel — Humanoids Evil NPCs
    // Auto-generated from npcdesc_zhbr.cfg (160 NPCs)
    // Source: POL 98 Zulu Hotel shard

    [SerializationGenerator(0, false)]
    public partial class ZuluAbominablesnowman : BaseCreature
    {
        [Constructible]
        public ZuluAbominablesnowman() : base(AIType.AI_Melee)
        {
            Body = 267;
            Hue = 0x484;

            SetStr(450);
            SetDex(450);
            SetInt(450);
            SetHits(2000);
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

        public override string DefaultName => "The Abominable Snowman";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluAbyssalone : BaseCreature
    {
        [Constructible]
        public ZuluAbyssalone() : base(AIType.AI_Melee)
        {
            Body = 241;
            Hue = 0x494;

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

        public override string DefaultName => "an abyssal one";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluAirmaster : BaseCreature
    {
        [Constructible]
        public ZuluAirmaster() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x3EA;

            SetStr(160);
            SetDex(600);
            SetInt(3000);
            SetHits(2000);
            SetMana(10000);
            SetStam(10000);

            SetDamage(8, 25);
            z_Air_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.AirProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 4, 4);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 110.0, 120.0);
            SetSkill(SkillName.Magery, 140.0, 150.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 24;
        }

        public override string DefaultName => "airmaster, the air master";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluAndariel : BaseCreature
    {
        [Constructible]
        public ZuluAndariel() : base(AIType.AI_Mage)
        {
            Body = 401;
            Hue = 0x3EA;
            BaseSoundID = 0x153;

            SetStr(100);
            SetDex(1000);
            SetInt(3000);
            SetHits(3000);
            SetMana(20000);
            SetStam(20000);

            SetDamage(5, 15);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.WaterProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.AirProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.NecroProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.EarthProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 8, 8);

            SetSkill(SkillName.Tactics, 110.0, 120.0);
            SetSkill(SkillName.Anatomy, 110.0, 120.0);
            SetSkill(SkillName.Swords, 110.0, 120.0);
            SetSkill(SkillName.Macing, 110.0, 120.0);
            SetSkill(SkillName.Fencing, 110.0, 120.0);
            SetSkill(SkillName.Wrestling, 110.0, 120.0);
            SetSkill(SkillName.Parry, 115.0, 125.0);
            SetSkill(SkillName.MagicResist, 140.0, 150.0);
            SetSkill(SkillName.DetectHidden, 115.0, 125.0);
            SetSkill(SkillName.Magery, 190.0, 200.0);
            SetSkill(SkillName.EvalInt, 190.0, 200.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 71;
        }

        public override string DefaultName => "Andariel, the Necromancer Sister";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluApprenticewizard1 : BaseCreature
    {
        [Constructible]
        public ZuluApprenticewizard1() : base(AIType.AI_Mage)
        {
            Body = 401;
            Hue = 0x3EA;

            SetStr(200);
            SetDex(90);
            SetInt(295);
            SetHits(80);
            SetMana(295);
            SetStam(50);

            SetDamage(8, 25);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 75.0, 85.0);
            SetSkill(SkillName.Macing, 75.0, 85.0);
            SetSkill(SkillName.MagicResist, 80.0, 90.0);
            SetSkill(SkillName.Magery, 90.0, 100.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 18;
        }

        public override string DefaultName => "apprenticewizard1, the apprentice";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluApprenticewizard2 : BaseCreature
    {
        [Constructible]
        public ZuluApprenticewizard2() : base(AIType.AI_Mage)
        {
            Body = 401;
            Hue = 0x3EA;

            SetStr(200);
            SetDex(90);
            SetInt(295);
            SetHits(80);
            SetMana(295);
            SetStam(50);

            SetDamage(8, 25);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 75.0, 85.0);
            SetSkill(SkillName.Macing, 75.0, 85.0);
            SetSkill(SkillName.MagicResist, 80.0, 90.0);
            SetSkill(SkillName.Magery, 90.0, 100.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 18;
        }

        public override string DefaultName => "apprenticewizard2, the apprentice";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluApprenticewizard3 : BaseCreature
    {
        [Constructible]
        public ZuluApprenticewizard3() : base(AIType.AI_Mage)
        {
            Body = 401;
            Hue = 0x3EA;

            SetStr(200);
            SetDex(90);
            SetInt(295);
            SetHits(80);
            SetMana(295);
            SetStam(50);

            SetDamage(8, 25);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 75.0, 85.0);
            SetSkill(SkillName.Macing, 75.0, 85.0);
            SetSkill(SkillName.MagicResist, 80.0, 90.0);
            SetSkill(SkillName.Magery, 90.0, 100.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 18;
        }

        public override string DefaultName => "apprenticewizard3, the apprentice";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBaal : BaseCreature
    {
        [Constructible]
        public ZuluBaal() : base(AIType.AI_Mage)
        {
            Body = 256;
            Hue = 0x494;
            BaseSoundID = 0x2AC;

            SetStr(900);
            SetDex(1200);
            SetInt(5000);
            SetHits(8000);
            SetMana(20000);
            SetStam(20000);

            SetDamage(18, 50);
            z_Air_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.FireProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.AirProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.NecroProtection, 100, 100);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 7, 7);

            SetSkill(SkillName.Tactics, 110.0, 120.0);
            SetSkill(SkillName.Anatomy, 110.0, 120.0);
            SetSkill(SkillName.Swords, 110.0, 120.0);
            SetSkill(SkillName.Macing, 110.0, 120.0);
            SetSkill(SkillName.Fencing, 110.0, 120.0);
            SetSkill(SkillName.Wrestling, 110.0, 120.0);
            SetSkill(SkillName.Parry, 115.0, 125.0);
            SetSkill(SkillName.MagicResist, 140.0, 150.0);
            SetSkill(SkillName.DetectHidden, 115.0, 125.0);
            SetSkill(SkillName.Magery, 190.0, 200.0);
            SetSkill(SkillName.EvalInt, 190.0, 200.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 71;
        }

        public override string DefaultName => "Baal";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBehemoth : BaseCreature
    {
        [Constructible]
        public ZuluBehemoth() : base(AIType.AI_Melee)
        {
            Body = 14;
            Hue = 0x488;

            SetStr(500);
            SetDex(1000);
            SetInt(1000);
            SetHits(15000);
            SetMana(3000);
            SetStam(3000);

            SetDamage(18, 50);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.WaterProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.AirProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.EarthProtection, 100, 100);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 6, 6);

            SetSkill(SkillName.Tactics, 140.0, 150.0);
            SetSkill(SkillName.Macing, 165.0, 175.0);
            SetSkill(SkillName.MagicResist, 50.0, 60.0);
            SetSkill(SkillName.DetectHidden, 190.0, 200.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 12;
        }

        public override string DefaultName => "a Behemoth";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.FilthyRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBewitchedarmor : BaseCreature
    {
        [Constructible]
        public ZuluBewitchedarmor() : base(AIType.AI_Melee)
        {
            Body = 527;
            BaseSoundID = 0x2B;

            SetStr(250);
            SetDex(400);
            SetInt(75);
            SetHits(500);
            SetMana(0);
            SetStam(800);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.FireProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.WaterProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.AirProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.EarthProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 2, 2);

            SetSkill(SkillName.Tactics, 120.0, 130.0);
            SetSkill(SkillName.Anatomy, 120.0, 130.0);
            SetSkill(SkillName.Swords, 120.0, 130.0);
            SetSkill(SkillName.Macing, 120.0, 130.0);
            SetSkill(SkillName.Fencing, 120.0, 130.0);
            SetSkill(SkillName.Wrestling, 120.0, 130.0);
            SetSkill(SkillName.Parry, 60.0, 70.0);
            SetSkill(SkillName.MagicResist, 70.0, 80.0);
            SetSkill(SkillName.DetectHidden, 60.0, 70.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 39;
        }

        public override string DefaultName => "a haunted armor";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBewitchedbardiche : BaseCreature
    {
        [Constructible]
        public ZuluBewitchedbardiche() : base(AIType.AI_Melee)
        {
            Body = 614;
            BaseSoundID = 0x2B;

            SetStr(250);
            SetDex(400);
            SetInt(75);
            SetHits(500);
            SetMana(0);
            SetStam(800);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.FireProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.WaterProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.AirProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.EarthProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 2, 2);

            SetSkill(SkillName.Tactics, 120.0, 130.0);
            SetSkill(SkillName.Anatomy, 120.0, 130.0);
            SetSkill(SkillName.Swords, 120.0, 130.0);
            SetSkill(SkillName.Macing, 120.0, 130.0);
            SetSkill(SkillName.Fencing, 120.0, 130.0);
            SetSkill(SkillName.Wrestling, 120.0, 130.0);
            SetSkill(SkillName.Parry, 60.0, 70.0);
            SetSkill(SkillName.MagicResist, 70.0, 80.0);
            SetSkill(SkillName.DetectHidden, 60.0, 70.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 39;
        }

        public override string DefaultName => "a haunted bardiche";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBewitchedgauntlets : BaseCreature
    {
        [Constructible]
        public ZuluBewitchedgauntlets() : base(AIType.AI_Melee)
        {
            Body = 530;
            BaseSoundID = 0x2B;

            SetStr(250);
            SetDex(400);
            SetInt(75);
            SetHits(750);
            SetMana(0);
            SetStam(800);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.FireProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.WaterProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.AirProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.EarthProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 2, 2);

            SetSkill(SkillName.Tactics, 120.0, 130.0);
            SetSkill(SkillName.Anatomy, 120.0, 130.0);
            SetSkill(SkillName.Swords, 120.0, 130.0);
            SetSkill(SkillName.Macing, 120.0, 130.0);
            SetSkill(SkillName.Fencing, 120.0, 130.0);
            SetSkill(SkillName.Wrestling, 120.0, 130.0);
            SetSkill(SkillName.Parry, 60.0, 70.0);
            SetSkill(SkillName.MagicResist, 70.0, 80.0);
            SetSkill(SkillName.DetectHidden, 60.0, 70.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 39;
        }

        public override string DefaultName => "a haunted gauntlets";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBewitchedpeasant : BaseCreature
    {
        [Constructible]
        public ZuluBewitchedpeasant() : base(AIType.AI_Melee)
        {
            Body = 400;
            Hue = 0x599;
            BaseSoundID = 0x15E;

            SetStr(500);
            SetDex(300);
            SetInt(150);
            SetHits(2500);
            SetMana(0);
            SetStam(2000);

            SetDamage(18, 50);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.NecroProtection, 40, 40);
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

        public override string DefaultName => "a bewitched peasant";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBewitchedspear : BaseCreature
    {
        [Constructible]
        public ZuluBewitchedspear() : base(AIType.AI_Melee)
        {
            Body = 626;
            BaseSoundID = 0x2B;

            SetStr(250);
            SetDex(200);
            SetInt(75);
            SetHits(500);
            SetMana(0);
            SetStam(800);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.FireProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.WaterProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.AirProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.EarthProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 2, 2);

            SetSkill(SkillName.Tactics, 120.0, 130.0);
            SetSkill(SkillName.Anatomy, 120.0, 130.0);
            SetSkill(SkillName.Swords, 120.0, 130.0);
            SetSkill(SkillName.Macing, 120.0, 130.0);
            SetSkill(SkillName.Fencing, 120.0, 130.0);
            SetSkill(SkillName.Wrestling, 120.0, 130.0);
            SetSkill(SkillName.Parry, 60.0, 70.0);
            SetSkill(SkillName.MagicResist, 70.0, 80.0);
            SetSkill(SkillName.DetectHidden, 60.0, 70.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 39;
        }

        public override string DefaultName => "a haunted spear";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.FilthyRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBewitchedsword : BaseCreature
    {
        [Constructible]
        public ZuluBewitchedsword() : base(AIType.AI_Melee)
        {
            Body = 643;
            BaseSoundID = 0x2B;

            SetStr(250);
            SetDex(150);
            SetInt(75);
            SetHits(500);
            SetMana(0);
            SetStam(800);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.FireProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.WaterProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.AirProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.EarthProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 2, 2);

            SetSkill(SkillName.Tactics, 120.0, 130.0);
            SetSkill(SkillName.Anatomy, 120.0, 130.0);
            SetSkill(SkillName.Swords, 120.0, 130.0);
            SetSkill(SkillName.Macing, 120.0, 130.0);
            SetSkill(SkillName.Fencing, 120.0, 130.0);
            SetSkill(SkillName.Wrestling, 120.0, 130.0);
            SetSkill(SkillName.Parry, 60.0, 70.0);
            SetSkill(SkillName.MagicResist, 70.0, 80.0);
            SetSkill(SkillName.DetectHidden, 60.0, 70.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 39;
        }

        public override string DefaultName => "a haunted sword";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBewitchedwarhammer : BaseCreature
    {
        [Constructible]
        public ZuluBewitchedwarhammer() : base(AIType.AI_Melee)
        {
            Body = 646;
            BaseSoundID = 0x2B;

            SetStr(300);
            SetDex(400);
            SetInt(75);
            SetHits(500);
            SetMana(0);
            SetStam(800);

            SetDamage(12, 35);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.FireProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.WaterProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.AirProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.EarthProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 2, 2);

            SetSkill(SkillName.Tactics, 120.0, 130.0);
            SetSkill(SkillName.Anatomy, 120.0, 130.0);
            SetSkill(SkillName.Swords, 120.0, 130.0);
            SetSkill(SkillName.Macing, 120.0, 130.0);
            SetSkill(SkillName.Fencing, 120.0, 130.0);
            SetSkill(SkillName.Wrestling, 120.0, 130.0);
            SetSkill(SkillName.Parry, 60.0, 70.0);
            SetSkill(SkillName.MagicResist, 70.0, 80.0);
            SetSkill(SkillName.DetectHidden, 60.0, 70.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 39;
        }

        public override string DefaultName => "a haunted warhammer";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBigfoot : BaseCreature
    {
        [Constructible]
        public ZuluBigfoot() : base(AIType.AI_Melee)
        {
            Body = 267;

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

        public override string DefaultName => "The Big Foot";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBizarreexperiment : BaseCreature
    {
        [Constructible]
        public ZuluBizarreexperiment() : base(AIType.AI_Mage)
        {
            Body = 259;
            BaseSoundID = 0x1DC;

            SetStr(1000);
            SetDex(1000);
            SetInt(200);
            SetHits(5000);
            SetMana(0);
            SetStam(2000);

            SetDamage(25, 80);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.FireProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.WaterProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.AirProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.NecroProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.EarthProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 5, 5);

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

        public override string DefaultName => "a bizarre experiment";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBlackknight : BaseCreature
    {
        [Constructible]
        public ZuluBlackknight() : base(AIType.AI_Melee)
        {
            Body = 400;
            Hue = 0x488;
            BaseSoundID = 0x15E;

            SetStr(500);
            SetDex(1000);
            SetInt(150);
            SetHits(20000);
            SetMana(150);
            SetStam(600);

            SetDamage(18, 50);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.WaterProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.AirProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.NecroProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.HollyProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.EarthProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 7, 7);

            SetSkill(SkillName.Tactics, 120.0, 130.0);
            SetSkill(SkillName.Anatomy, 120.0, 130.0);
            SetSkill(SkillName.Swords, 115.0, 125.0);
            SetSkill(SkillName.Macing, 115.0, 125.0);
            SetSkill(SkillName.Fencing, 115.0, 125.0);
            SetSkill(SkillName.Wrestling, 115.0, 125.0);
            SetSkill(SkillName.Parry, 100.0, 110.0);
            SetSkill(SkillName.MagicResist, 110.0, 120.0);
            SetSkill(SkillName.DetectHidden, 120.0, 130.0);

            Fame = 35000;
            Karma = -35000;
            VirtualArmor = 60;
        }

        public override string DefaultName => "blackknight, the possessed Hero";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBlackwisp : BaseCreature
    {
        [Constructible]
        public ZuluBlackwisp() : base(AIType.AI_Mage)
        {
            Body = 58;
            Hue = 0x455;

            SetStr(700);
            SetDex(575);
            SetInt(1100);
            SetHits(900);
            SetMana(1100);
            SetStam(575);

            SetDamage(18, 50);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.NecroProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.EarthProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 6, 6);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 190.0, 200.0);
            SetSkill(SkillName.Magery, 190.0, 200.0);
            SetSkill(SkillName.EvalInt, 190.0, 200.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 40;
        }

        public override string DefaultName => "a black wisp";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBladespirit : BaseCreature
    {
        [Constructible]
        public ZuluBladespirit() : base(AIType.AI_Melee)
        {
            Body = 574;
            Hue = 0x83F8;

            SetStr(300);
            SetDex(200);
            SetInt(25);
            SetHits(150);
            SetMana(0);
            SetStam(50);

            SetDamage(12, 35);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 140.0, 150.0);
            SetSkill(SkillName.Macing, 115.0, 125.0);
            SetSkill(SkillName.MagicResist, 100.0, 110.0);
            SetSkill(SkillName.Poisoning, 90.0, 100.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 22;
        }

        public override string DefaultName => "a blade spirit";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBluemare : BaseCreature
    {
        [Constructible]
        public ZuluBluemare() : base(AIType.AI_Mage)
        {
            Body = 200;
            Hue = 0x7B7;

            SetStr(450);
            SetDex(600);
            SetInt(450);
            SetHits(450);
            SetMana(450);
            SetStam(450);

            SetDamage(45, 80);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 5, 5);

            SetSkill(SkillName.Tactics, 120.0, 130.0);
            SetSkill(SkillName.Macing, 165.0, 175.0);
            SetSkill(SkillName.MagicResist, 90.0, 100.0);
            SetSkill(SkillName.Magery, 140.0, 150.0);
            SetSkill(SkillName.EvalInt, 90.0, 100.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 20;
            MinTameSkill = 140;
        }

        public override string DefaultName => "a bluemare";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBridgeguardian : BaseCreature
    {
        [Constructible]
        public ZuluBridgeguardian() : base(AIType.AI_Melee)
        {
            Body = 4;
            Hue = 0x498;
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
            SetSkill(SkillName.DetectHidden, 95.0, 105.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 58;
        }

        public override string DefaultName => "The Bridge Guardian";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBrigandarcher : BaseCreature
    {
        [Constructible]
        public ZuluBrigandarcher() : base(AIType.AI_Archer)
        {
            Body = 400;

            SetStr(95);
            SetDex(105);
            SetInt(45);
            SetHits(99);
            SetMana(0);
            SetStam(50);

            SetDamage(5, 15);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 50.0, 60.0);
            SetSkill(SkillName.Macing, 65.0, 75.0);
            SetSkill(SkillName.MagicResist, 140.0, 150.0);
            SetSkill(SkillName.Archery, 65.0, 75.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 30;

            EquipItem(new Shoes(0x5E4));
            EquipItem(new LongPants(0x59B));
            EquipItem(new Skirt(0x215));
            EquipItem(new StuddedChest());
            EquipItem(new FancyShirt(0x5E4));
        }

        public override string DefaultName => "a brigand archer";

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluCaptainmccoy : BaseCreature
    {
        [Constructible]
        public ZuluCaptainmccoy() : base(AIType.AI_Melee)
        {
            Body = 400;

            SetStr(1500);
            SetDex(1200);
            SetInt(1000);
            SetHits(3000);
            SetMana(3000);
            SetStam(3000);

            SetDamage(25, 80);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.WaterProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.AirProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.EarthProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 7, 7);

            SetSkill(SkillName.Tactics, 120.0, 130.0);
            SetSkill(SkillName.Swords, 130.0, 140.0);
            SetSkill(SkillName.Parry, 140.0, 150.0);
            SetSkill(SkillName.MagicResist, 140.0, 150.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 80;
        }

        public override string DefaultName => "Captain McCoy, the Dragon Hunter";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluCarnivoresnowworm : BaseCreature
    {
        [Constructible]
        public ZuluCarnivoresnowworm() : base(AIType.AI_Melee)
        {
            Body = 8;
            Hue = 0x498;

            SetStr(150);
            SetDex(105);
            SetInt(45);
            SetHits(150);
            SetMana(45);
            SetStam(105);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.EarthProtection, 50, 50);

            SetSkill(SkillName.Tactics, 80.0, 90.0);
            SetSkill(SkillName.Macing, 95.0, 105.0);
            SetSkill(SkillName.Parry, 10.0, 20.0);
            SetSkill(SkillName.MagicResist, 10.0, 20.0);
            SetSkill(SkillName.Hiding, 65.0, 75.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 10;
        }

        public override string DefaultName => "a carnivore snow worm";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluChildkeeper : BaseCreature
    {
        [Constructible]
        public ZuluChildkeeper() : base(AIType.AI_Mage)
        {
            Body = 4;
            Hue = 0x7B2;
            BaseSoundID = 0x4BF;

            SetStr(100);
            SetDex(1000);
            SetInt(10000);
            SetHits(7500);
            SetMana(10000);
            SetStam(10000);

            SetDamage(5, 15);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.FireProtection, 100, 100);
            AddMobZuluModifier(ZuluMod.NecroProtection, 100, 100);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 8, 8);

            SetSkill(SkillName.Tactics, 110.0, 120.0);
            SetSkill(SkillName.Anatomy, 110.0, 120.0);
            SetSkill(SkillName.Swords, 110.0, 120.0);
            SetSkill(SkillName.Macing, 110.0, 120.0);
            SetSkill(SkillName.Fencing, 110.0, 120.0);
            SetSkill(SkillName.Wrestling, 110.0, 120.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 120.0, 130.0);
            SetSkill(SkillName.DetectHidden, 110.0, 120.0);
            SetSkill(SkillName.Magery, 190.0, 200.0);
            SetSkill(SkillName.EvalInt, 190.0, 200.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 59;
        }

        public override string DefaultName => "The Child Keeper";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.FilthyRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluCondemnedchild1 : BaseCreature
    {
        [Constructible]
        public ZuluCondemnedchild1() : base(AIType.AI_Mage)
        {
            Body = 39;
            Hue = 0x7BD;
            BaseSoundID = 0x153;

            SetStr(750);
            SetDex(750);
            SetInt(500);
            SetHits(2000);
            SetMana(2500);
            SetStam(1500);

            SetDamage(18, 50);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 70, 70);
            AddMobZuluModifier(ZuluMod.FireProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.NecroProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 2, 2);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Anatomy, 90.0, 100.0);
            SetSkill(SkillName.Swords, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.Fencing, 90.0, 100.0);
            SetSkill(SkillName.Wrestling, 90.0, 100.0);
            SetSkill(SkillName.Parry, 60.0, 70.0);
            SetSkill(SkillName.MagicResist, 130.0, 140.0);
            SetSkill(SkillName.DetectHidden, 90.0, 100.0);
            SetSkill(SkillName.Magery, 140.0, 150.0);
            SetSkill(SkillName.EvalInt, 110.0, 120.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 51;
        }

        public override string DefaultName => "a condemned child";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluCondemnedchild2 : BaseCreature
    {
        [Constructible]
        public ZuluCondemnedchild2() : base(AIType.AI_Mage)
        {
            Body = 39;
            Hue = 0x498;
            BaseSoundID = 0x153;

            SetStr(750);
            SetDex(750);
            SetInt(500);
            SetHits(2000);
            SetMana(2500);
            SetStam(1500);

            SetDamage(18, 50);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 70, 70);
            AddMobZuluModifier(ZuluMod.FireProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.NecroProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 2, 2);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Anatomy, 90.0, 100.0);
            SetSkill(SkillName.Swords, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.Fencing, 90.0, 100.0);
            SetSkill(SkillName.Wrestling, 90.0, 100.0);
            SetSkill(SkillName.Parry, 60.0, 70.0);
            SetSkill(SkillName.MagicResist, 130.0, 140.0);
            SetSkill(SkillName.DetectHidden, 90.0, 100.0);
            SetSkill(SkillName.Magery, 140.0, 150.0);
            SetSkill(SkillName.EvalInt, 110.0, 120.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 51;
        }

        public override string DefaultName => "a condemned child";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluCondemnedchild3 : BaseCreature
    {
        [Constructible]
        public ZuluCondemnedchild3() : base(AIType.AI_Mage)
        {
            Body = 39;
            Hue = 0x496;
            BaseSoundID = 0x153;

            SetStr(750);
            SetDex(750);
            SetInt(500);
            SetHits(2000);
            SetMana(2500);
            SetStam(1500);

            SetDamage(18, 50);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 70, 70);
            AddMobZuluModifier(ZuluMod.FireProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.NecroProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 2, 2);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Anatomy, 90.0, 100.0);
            SetSkill(SkillName.Swords, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.Fencing, 90.0, 100.0);
            SetSkill(SkillName.Wrestling, 90.0, 100.0);
            SetSkill(SkillName.Parry, 60.0, 70.0);
            SetSkill(SkillName.MagicResist, 130.0, 140.0);
            SetSkill(SkillName.DetectHidden, 90.0, 100.0);
            SetSkill(SkillName.Magery, 140.0, 150.0);
            SetSkill(SkillName.EvalInt, 110.0, 120.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 51;
        }

        public override string DefaultName => "a condemned child";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluCondemnedchild4 : BaseCreature
    {
        [Constructible]
        public ZuluCondemnedchild4() : base(AIType.AI_Mage)
        {
            Body = 39;
            Hue = 0x48C;
            BaseSoundID = 0x153;

            SetStr(750);
            SetDex(750);
            SetInt(500);
            SetHits(2000);
            SetMana(2500);
            SetStam(1500);

            SetDamage(18, 50);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 70, 70);
            AddMobZuluModifier(ZuluMod.FireProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.NecroProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 2, 2);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Anatomy, 90.0, 100.0);
            SetSkill(SkillName.Swords, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.Fencing, 90.0, 100.0);
            SetSkill(SkillName.Wrestling, 90.0, 100.0);
            SetSkill(SkillName.Parry, 60.0, 70.0);
            SetSkill(SkillName.MagicResist, 130.0, 140.0);
            SetSkill(SkillName.DetectHidden, 90.0, 100.0);
            SetSkill(SkillName.Magery, 140.0, 150.0);
            SetSkill(SkillName.EvalInt, 110.0, 120.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 51;
        }

        public override string DefaultName => "a condemned child";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluCondemnedchild5 : BaseCreature
    {
        [Constructible]
        public ZuluCondemnedchild5() : base(AIType.AI_Mage)
        {
            Body = 39;
            Hue = 0x495;
            BaseSoundID = 0x153;

            SetStr(750);
            SetDex(750);
            SetInt(500);
            SetHits(2000);
            SetMana(2500);
            SetStam(1500);

            SetDamage(18, 50);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 70, 70);
            AddMobZuluModifier(ZuluMod.FireProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.NecroProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 2, 2);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Anatomy, 90.0, 100.0);
            SetSkill(SkillName.Swords, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.Fencing, 90.0, 100.0);
            SetSkill(SkillName.Wrestling, 90.0, 100.0);
            SetSkill(SkillName.Parry, 60.0, 70.0);
            SetSkill(SkillName.MagicResist, 130.0, 140.0);
            SetSkill(SkillName.DetectHidden, 90.0, 100.0);
            SetSkill(SkillName.Magery, 140.0, 150.0);
            SetSkill(SkillName.EvalInt, 110.0, 120.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 51;
        }

        public override string DefaultName => "a condemned child";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluCorpser : BaseCreature
    {
        [Constructible]
        public ZuluCorpser() : base(AIType.AI_Melee)
        {
            Body = 8;

            SetStr(150);
            SetDex(105);
            SetInt(45);
            SetHits(150);
            SetMana(45);
            SetStam(105);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.EarthProtection, 50, 50);

            SetSkill(SkillName.Tactics, 80.0, 90.0);
            SetSkill(SkillName.Macing, 95.0, 105.0);
            SetSkill(SkillName.Parry, 10.0, 20.0);
            SetSkill(SkillName.MagicResist, 10.0, 20.0);
            SetSkill(SkillName.Hiding, 65.0, 75.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 10;
        }

        public override string DefaultName => "a corpser";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluCraziedlittlegirl : BaseCreature
    {
        [Constructible]
        public ZuluCraziedlittlegirl() : base(AIType.AI_Mage)
        {
            Body = 401;
            BaseSoundID = 0x153;

            SetStr(1000);
            SetDex(1000);
            SetInt(200);
            SetHits(5000);
            SetMana(0);
            SetStam(2000);

            SetDamage(25, 80);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.WaterProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.AirProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.NecroProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.HollyProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.EarthProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 5, 5);

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

        public override string DefaultName => "Sarah, the crazied little girl";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluCraziedmage : BaseCreature
    {
        [Constructible]
        public ZuluCraziedmage() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x83F8;

            SetStr(500);
            SetDex(500);
            SetInt(1000);
            SetHits(5000);
            SetMana(2000);
            SetStam(1000);

            SetDamage(18, 50);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 110.0, 120.0);
            SetSkill(SkillName.Fencing, 110.0, 120.0);
            SetSkill(SkillName.Parry, 70.0, 80.0);
            SetSkill(SkillName.MagicResist, 95.0, 105.0);
            SetSkill(SkillName.Magery, 140.0, 150.0);
            SetSkill(SkillName.EvalInt, 90.0, 100.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 47;
        }

        public override string DefaultName => "The Crazied Mage";

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluCyclops : BaseCreature
    {
        [Constructible]
        public ZuluCyclops() : base(AIType.AI_Melee)
        {
            Body = 75;
            Hue = 0x83F8;

            SetStr(350);
            SetDex(130);
            SetInt(65);
            SetHits(350);
            SetMana(65);
            SetStam(130);

            SetDamage(12, 35);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 100.0, 110.0);
            SetSkill(SkillName.Macing, 100.0, 110.0);
            SetSkill(SkillName.Parry, 70.0, 80.0);
            SetSkill(SkillName.MagicResist, 75.0, 85.0);

            Fame = 2500;
            Karma = -2500;
            VirtualArmor = 43;
        }

        public override string DefaultName => "a cyclops";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluDarkarcher : BaseCreature
    {
        [Constructible]
        public ZuluDarkarcher() : base(AIType.AI_Archer)
        {
            Body = 401;
            Hue = 0x455;

            SetStr(165);
            SetDex(130);
            SetInt(95);
            SetHits(165);
            SetMana(95);
            SetStam(130);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 6, 6);

            SetSkill(SkillName.Tactics, 140.0, 150.0);
            SetSkill(SkillName.Macing, 85.0, 95.0);
            SetSkill(SkillName.Wrestling, 140.0, 150.0);
            SetSkill(SkillName.MagicResist, 100.0, 110.0);
            SetSkill(SkillName.Archery, 140.0, 150.0);
            SetSkill(SkillName.Hiding, 90.0, 100.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 22;
        }

        public override string DefaultName => "a dark archer";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluDarkmage : BaseCreature
    {
        [Constructible]
        public ZuluDarkmage() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x455;

            SetStr(160);
            SetDex(195);
            SetInt(300);
            SetHits(160);
            SetMana(300);
            SetStam(195);

            SetDamage(8, 25);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 6, 6);

            SetSkill(SkillName.Tactics, 65.0, 75.0);
            SetSkill(SkillName.Swords, 100.0, 110.0);
            SetSkill(SkillName.Macing, 100.0, 110.0);
            SetSkill(SkillName.MagicResist, 110.0, 120.0);
            SetSkill(SkillName.Magery, 100.0, 110.0);
            SetSkill(SkillName.Hiding, 90.0, 100.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 24;
        }

        public override string DefaultName => "a dark mage";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluDesertskunk : BaseCreature
    {
        [Constructible]
        public ZuluDesertskunk() : base(AIType.AI_Melee)
        {
            Body = 215;
            Hue = 0x497;
            BaseSoundID = 0x18D;

            SetStr(60);
            SetDex(60);
            SetInt(40);
            SetHits(40);
            SetMana(0);
            SetStam(600);

            SetDamage(5, 15);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.FireProtection, 20, 20);

            SetSkill(SkillName.Tactics, 30.0, 40.0);
            SetSkill(SkillName.Anatomy, 30.0, 40.0);
            SetSkill(SkillName.Swords, 30.0, 40.0);
            SetSkill(SkillName.Macing, 30.0, 40.0);
            SetSkill(SkillName.Fencing, 30.0, 40.0);
            SetSkill(SkillName.Wrestling, 30.0, 40.0);
            SetSkill(SkillName.Parry, 30.0, 40.0);
            SetSkill(SkillName.MagicResist, 70.0, 80.0);
            SetSkill(SkillName.DetectHidden, 30.0, 40.0);
            SetSkill(SkillName.Hiding, 40.0, 50.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 29;
            MinTameSkill = 50;
        }

        public override string DefaultName => "a desert skunk";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluDiablo : BaseCreature
    {
        [Constructible]
        public ZuluDiablo() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x482;
            BaseSoundID = 0x111;

            SetStr(100);
            SetDex(1000);
            SetInt(5000);
            SetHits(2500);
            SetMana(10000);
            SetStam(10000);

            SetDamage(5, 15);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.WaterProtection, 10, 10);
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
            SetSkill(SkillName.DetectHidden, 120.0, 130.0);
            SetSkill(SkillName.Magery, 190.0, 200.0);
            SetSkill(SkillName.EvalInt, 190.0, 200.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 59;
        }

        public override string DefaultName => "The Dark Wanderer";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluDiablo2 : BaseCreature
    {
        [Constructible]
        public ZuluDiablo2() : base(AIType.AI_Mage)
        {
            Body = 249;
            BaseSoundID = 0x34C;

            SetStr(2000);
            SetDex(1200);
            SetInt(6000);
            SetHits(8000);
            SetMana(20000);
            SetStam(20000);

            SetDamage(40, 100);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.FireProtection, 80, 80);
            AddMobZuluModifier(ZuluMod.WaterProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.AirProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.NecroProtection, 100, 100);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.EarthProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 8, 8);

            SetSkill(SkillName.Tactics, 190.0, 200.0);
            SetSkill(SkillName.Anatomy, 120.0, 130.0);
            SetSkill(SkillName.Swords, 190.0, 200.0);
            SetSkill(SkillName.Macing, 190.0, 200.0);
            SetSkill(SkillName.Fencing, 190.0, 200.0);
            SetSkill(SkillName.Wrestling, 190.0, 200.0);
            SetSkill(SkillName.Parry, 190.0, 200.0);
            SetSkill(SkillName.MagicResist, 140.0, 150.0);
            SetSkill(SkillName.DetectHidden, 130.0, 140.0);
            SetSkill(SkillName.Magery, 190.0, 200.0);
            SetSkill(SkillName.EvalInt, 190.0, 200.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 80;
        }

        public override string DefaultName => "Diablo";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluDracula : BaseCreature
    {
        [Constructible]
        public ZuluDracula() : base(AIType.AI_Melee)
        {
            Body = 400;

            SetStr(600);
            SetDex(300);
            SetInt(400);
            SetHits(600);
            SetMana(400);
            SetStam(300);

            SetDamage(18, 50);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 4, 4);

            SetSkill(SkillName.Tactics, 120.0, 130.0);
            SetSkill(SkillName.Macing, 120.0, 130.0);
            SetSkill(SkillName.MagicResist, 120.0, 130.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 26;

            EquipItem(new Cloak(0x1));
            EquipItem(new FancyShirt(0x1));
            EquipItem(new LongPants());
            EquipItem(new Shoes(0x1));
            EquipItem(new Doublet(0x20));
        }

        public override string DefaultName => "a vampire";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluEarthmaster : BaseCreature
    {
        [Constructible]
        public ZuluEarthmaster() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x3EA;

            SetStr(500);
            SetDex(700);
            SetInt(3000);
            SetHits(2700);
            SetMana(10000);
            SetStam(5000);

            SetDamage(18, 50);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.EarthProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 4, 4);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 110.0, 120.0);
            SetSkill(SkillName.Magery, 140.0, 150.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 24;
        }

        public override string DefaultName => "earthmaster, the earth summoner";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluEfreeti : BaseCreature
    {
        [Constructible]
        public ZuluEfreeti() : base(AIType.AI_Mage)
        {
            Body = 13;
            Hue = 0x5D;

            SetStr(350);
            SetDex(100);
            SetInt(355);
            SetHits(350);
            SetMana(355);
            SetStam(100);

            SetDamage(12, 35);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.AirProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 4, 4);

            SetSkill(SkillName.Tactics, 75.0, 85.0);
            SetSkill(SkillName.Macing, 150.0, 160.0);
            SetSkill(SkillName.MagicResist, 120.0, 130.0);
            SetSkill(SkillName.Magery, 90.0, 100.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 26;
        }

        public override string DefaultName => "an efreeti";

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluEttin : BaseCreature
    {
        [Constructible]
        public ZuluEttin() : base(AIType.AI_Melee)
        {
            Body = 2;
            Hue = 0x83F8;
            BaseSoundID = 0x174;

            SetStr(240);
            SetDex(130);
            SetInt(25);
            SetHits(250);
            SetMana(25);
            SetStam(130);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Macing, 140.0, 150.0);
            SetSkill(SkillName.MagicResist, 30.0, 40.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 8;
        }

        public override string DefaultName => "an ettin";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluEttin2 : BaseCreature
    {
        [Constructible]
        public ZuluEttin2() : base(AIType.AI_Melee)
        {
            Body = 18;
            Hue = 0x83F8;
            BaseSoundID = 0x174;

            SetStr(240);
            SetDex(130);
            SetInt(10);
            SetHits(250);
            SetMana(10);
            SetStam(130);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 60.0, 70.0);
            SetSkill(SkillName.Macing, 70.0, 80.0);
            SetSkill(SkillName.Parry, 50.0, 60.0);
            SetSkill(SkillName.MagicResist, 30.0, 40.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 28;
        }

        public override string DefaultName => "an ettin";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluEvilmage1 : BaseCreature
    {
        [Constructible]
        public ZuluEvilmage1() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x3EA;
            BaseSoundID = 0x17E;

            SetStr(250);
            SetDex(100);
            SetInt(200);
            SetHits(500);
            SetMana(1000);
            SetStam(200);

            SetDamage(8, 25);
            z_Air_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.WaterProtection, 50, 50);
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

        public override string DefaultName => "evilmage1, the mage";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluEvilmage2 : BaseCreature
    {
        [Constructible]
        public ZuluEvilmage2() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x3EA;
            BaseSoundID = 0x17E;

            SetStr(250);
            SetDex(100);
            SetInt(200);
            SetHits(500);
            SetMana(1000);
            SetStam(200);

            SetDamage(8, 25);
            z_Air_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.WaterProtection, 50, 50);
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

        public override string DefaultName => "evilmage2, the mage";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluEvilmage3 : BaseCreature
    {
        [Constructible]
        public ZuluEvilmage3() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x3EA;
            BaseSoundID = 0x17E;

            SetStr(250);
            SetDex(100);
            SetInt(200);
            SetHits(500);
            SetMana(1000);
            SetStam(200);

            SetDamage(8, 25);
            z_Air_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.WaterProtection, 50, 50);
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

        public override string DefaultName => "evilmage3, the mage";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluEvilpossession : BaseCreature
    {
        [Constructible]
        public ZuluEvilpossession() : base(AIType.AI_Mage)
        {
            Body = 26;
            Hue = 0x494;

            SetStr(500);
            SetDex(180);
            SetInt(1000);
            SetHits(3500);
            SetMana(2000);
            SetStam(180);

            SetDamage(18, 50);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 110.0, 120.0);
            SetSkill(SkillName.Fencing, 110.0, 120.0);
            SetSkill(SkillName.Parry, 70.0, 80.0);
            SetSkill(SkillName.MagicResist, 95.0, 105.0);
            SetSkill(SkillName.Magery, 140.0, 150.0);
            SetSkill(SkillName.EvalInt, 90.0, 100.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 47;
        }

        public override string DefaultName => "an evil possession";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluExecutorbrother : BaseCreature
    {
        [Constructible]
        public ZuluExecutorbrother() : base(AIType.AI_Melee)
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

        public override string DefaultName => "executorbrother, the executor brother";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.FilthyRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluFallenangel : BaseCreature
    {
        [Constructible]
        public ZuluFallenangel() : base(AIType.AI_Melee)
        {
            Body = 4;
            Hue = 0x496;
            BaseSoundID = 0x4E7;

            SetStr(600);
            SetDex(600);
            SetInt(485);
            SetHits(1000);
            SetMana(285);
            SetStam(1000);

            SetDamage(18, 50);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.WaterProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.AirProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.NecroProtection, 100, 100);
            AddMobZuluModifier(ZuluMod.EarthProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 6, 6);

            SetSkill(SkillName.Tactics, 120.0, 130.0);
            SetSkill(SkillName.Swords, 125.0, 135.0);
            SetSkill(SkillName.Macing, 125.0, 135.0);
            SetSkill(SkillName.Fencing, 125.0, 135.0);
            SetSkill(SkillName.Wrestling, 125.0, 135.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 140.0, 150.0);
            SetSkill(SkillName.DetectHidden, 110.0, 120.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 63;
        }

        public override string DefaultName => "a fallen angel";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.FilthyRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluFetidmonster : BaseCreature
    {
        [Constructible]
        public ZuluFetidmonster() : base(AIType.AI_Melee)
        {
            Body = 256;
            Hue = 0x488;
            BaseSoundID = 0x1DC;

            SetStr(1000);
            SetDex(1000);
            SetInt(200);
            SetHits(3000);
            SetMana(0);
            SetStam(2000);

            SetDamage(25, 80);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 100, 100);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 5, 5);

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

        public override string DefaultName => "a fetid monster";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluFirearchmage : BaseCreature
    {
        [Constructible]
        public ZuluFirearchmage() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x3EA;
            BaseSoundID = 0x17E;

            SetStr(250);
            SetDex(100);
            SetInt(200);
            SetHits(5000);
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

        public override string DefaultName => "firearchmage, the Fire Archmage";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluFirebrigand1 : BaseCreature
    {
        [Constructible]
        public ZuluFirebrigand1() : base(AIType.AI_Melee)
        {
            Body = 400;
            Hue = 0x3EA;

            SetStr(130);
            SetDex(180);
            SetInt(105);
            SetHits(130);
            SetMana(95);
            SetStam(180);

            SetDamage(5, 15);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 75.0, 85.0);
            SetSkill(SkillName.Swords, 70.0, 80.0);
            SetSkill(SkillName.Fencing, 75.0, 85.0);
            SetSkill(SkillName.Parry, 70.0, 80.0);
            SetSkill(SkillName.MagicResist, 40.0, 50.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 36;
        }

        public override string DefaultName => "firebrigand1, the bandit";

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluFiredungeonarcher : BaseCreature
    {
        [Constructible]
        public ZuluFiredungeonarcher() : base(AIType.AI_Archer)
        {
            Body = 400;

            SetStr(95);
            SetDex(105);
            SetInt(45);
            SetHits(99);
            SetMana(0);
            SetStam(50);

            SetDamage(5, 15);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 50.0, 60.0);
            SetSkill(SkillName.Macing, 65.0, 75.0);
            SetSkill(SkillName.MagicResist, 140.0, 150.0);
            SetSkill(SkillName.Archery, 65.0, 75.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 30;

            EquipItem(new Shoes(0x5E4));
            EquipItem(new LongPants(0x59B));
            EquipItem(new Skirt(0x215));
            EquipItem(new StuddedChest());
            EquipItem(new FancyShirt(0x5E4));
        }

        public override string DefaultName => "firedungeonarcher, the archer";

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluFiredungeonconjurer : BaseCreature
    {
        [Constructible]
        public ZuluFiredungeonconjurer() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x3EA;
            BaseSoundID = 0x17E;

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

        public override string DefaultName => "firedungeonconjurer, the Fire Conjurer";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluFiredungeonleader : BaseCreature
    {
        [Constructible]
        public ZuluFiredungeonleader() : base(AIType.AI_Melee)
        {
            Body = 400;
            Hue = 0x488;

            SetStr(1500);
            SetDex(1200);
            SetInt(1000);
            SetHits(3000);
            SetMana(3000);
            SetStam(3000);

            SetDamage(25, 80);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.WaterProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.AirProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.EarthProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 7, 7);

            SetSkill(SkillName.Tactics, 120.0, 130.0);
            SetSkill(SkillName.Swords, 130.0, 140.0);
            SetSkill(SkillName.Parry, 140.0, 150.0);
            SetSkill(SkillName.MagicResist, 140.0, 150.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 80;
        }

        public override string DefaultName => "firedungeonleader, the Fire Leader";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluFirefighter : BaseCreature
    {
        [Constructible]
        public ZuluFirefighter() : base(AIType.AI_Mage)
        {
            Body = 400;

            SetStr(600);
            SetDex(600);
            SetInt(600);
            SetHits(1200);
            SetMana(1200);
            SetStam(1200);

            SetDamage(18, 50);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 120.0, 130.0);
            SetSkill(SkillName.Swords, 140.0, 150.0);
            SetSkill(SkillName.Fencing, 120.0, 130.0);
            SetSkill(SkillName.Parry, 140.0, 150.0);
            SetSkill(SkillName.MagicResist, 55.0, 65.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 63;
        }

        public override string DefaultName => "firefighter, the fire fighter";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluFiremaster : BaseCreature
    {
        [Constructible]
        public ZuluFiremaster() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x3EA;

            SetStr(500);
            SetDex(500);
            SetInt(3000);
            SetHits(2500);
            SetMana(10000);
            SetStam(5000);

            SetDamage(18, 50);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.FireProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 4, 4);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 110.0, 120.0);
            SetSkill(SkillName.Magery, 140.0, 150.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 24;
        }

        public override string DefaultName => "firemaster, the fire mage";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluFiretemplepriest : BaseCreature
    {
        [Constructible]
        public ZuluFiretemplepriest() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x3EA;

            SetStr(1500);
            SetDex(1500);
            SetInt(1500);
            SetHits(6000);
            SetMana(1500);
            SetStam(1500);

            SetDamage(25, 80);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.FireProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.WaterProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.AirProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.NecroProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.EarthProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 8, 8);

            SetSkill(SkillName.Tactics, 80.0, 90.0);
            SetSkill(SkillName.Macing, 100.0, 110.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 140.0, 150.0);
            SetSkill(SkillName.DetectHidden, 190.0, 200.0);
            SetSkill(SkillName.Magery, 165.0, 175.0);

            Fame = 35000;
            Karma = -35000;
            VirtualArmor = 63;
        }

        public override string DefaultName => "firetemplepriest, the Fire Temple Priest";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluFiretempleseer : BaseCreature
    {
        [Constructible]
        public ZuluFiretempleseer() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x3EA;
            BaseSoundID = 0x166;

            SetStr(100);
            SetDex(1000);
            SetInt(10000);
            SetHits(5000);
            SetMana(10000);
            SetStam(10000);

            SetDamage(5, 15);
            z_Air_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.FireProtection, 100, 100);
            AddMobZuluModifier(ZuluMod.AirProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 8, 8);

            SetSkill(SkillName.Tactics, 140.0, 150.0);
            SetSkill(SkillName.Anatomy, 140.0, 150.0);
            SetSkill(SkillName.Swords, 140.0, 150.0);
            SetSkill(SkillName.Macing, 140.0, 150.0);
            SetSkill(SkillName.Fencing, 140.0, 150.0);
            SetSkill(SkillName.Wrestling, 140.0, 150.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 120.0, 130.0);
            SetSkill(SkillName.DetectHidden, 110.0, 120.0);
            SetSkill(SkillName.Magery, 190.0, 200.0);
            SetSkill(SkillName.EvalInt, 190.0, 200.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 59;
        }

        public override string DefaultName => "firetempleseer, the Fire Temple Seer";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.FilthyRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluFlamegargoyle : BaseCreature
    {
        [Constructible]
        public ZuluFlamegargoyle() : base(AIType.AI_Mage)
        {
            Body = 4;
            Hue = 0x486;
            BaseSoundID = 0x179;

            SetStr(250);
            SetDex(100);
            SetInt(200);
            SetHits(1000);
            SetMana(1000);
            SetStam(200);

            SetDamage(8, 25);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.FireProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.NecroProtection, 100, 100);
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

        public override string DefaultName => "a flaming gargoyle";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluFlamingapparition : BaseCreature
    {
        [Constructible]
        public ZuluFlamingapparition() : base(AIType.AI_Mage)
        {
            Body = 573;
            Hue = 0xAD4;

            SetStr(300);
            SetDex(200);
            SetInt(500);
            SetHits(300);
            SetMana(500);
            SetStam(80);

            SetDamage(12, 35);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.NecroProtection, 80, 80);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 4, 4);

            SetSkill(SkillName.Tactics, 115.0, 125.0);
            SetSkill(SkillName.Fencing, 120.0, 130.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 95.0, 105.0);
            SetSkill(SkillName.DetectHidden, 120.0, 130.0);
            SetSkill(SkillName.EvalInt, 90.0, 100.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 54;
        }

        public override string DefaultName => "a flaming apparition";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluFlamingwisp : BaseCreature
    {
        [Constructible]
        public ZuluFlamingwisp() : base(AIType.AI_Mage)
        {
            Body = 58;
            Hue = 0x494;

            SetStr(700);
            SetDex(175);
            SetInt(1100);
            SetHits(700);
            SetMana(1100);
            SetStam(175);

            SetDamage(18, 50);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.FireProtection, 80, 80);
            AddMobZuluModifier(ZuluMod.NecroProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.EarthProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 6, 6);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 190.0, 200.0);
            SetSkill(SkillName.Magery, 190.0, 200.0);
            SetSkill(SkillName.EvalInt, 190.0, 200.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 40;
        }

        public override string DefaultName => "a flaming wisp";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluForesttroll : BaseCreature
    {
        [Constructible]
        public ZuluForesttroll() : base(AIType.AI_Melee)
        {
            Body = 54;
            Hue = 0x48A;

            SetStr(185);
            SetDex(70);
            SetInt(35);
            SetHits(185);
            SetMana(0);
            SetStam(50);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 80.0, 90.0);
            SetSkill(SkillName.Swords, 80.0, 90.0);
            SetSkill(SkillName.Parry, 40.0, 50.0);
            SetSkill(SkillName.MagicResist, 50.0, 60.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 28;
        }

        public override string DefaultName => "a forest troll";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluFrostgargoyle : BaseCreature
    {
        [Constructible]
        public ZuluFrostgargoyle() : base(AIType.AI_Mage)
        {
            Body = 4;
            Hue = 0x492;
            BaseSoundID = 0x179;

            SetStr(250);
            SetDex(100);
            SetInt(200);
            SetHits(1200);
            SetMana(1000);
            SetStam(200);

            SetDamage(8, 25);
            z_Air_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.WaterProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.AirProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.NecroProtection, 100, 100);
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

        public override string DefaultName => "a frost gargoyle";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluGargoyle : BaseCreature
    {
        [Constructible]
        public ZuluGargoyle() : base(AIType.AI_Mage)
        {
            Body = 4;
            BaseSoundID = 0x179;

            SetStr(150);
            SetDex(100);
            SetInt(100);
            SetHits(400);
            SetMana(500);
            SetStam(200);

            SetDamage(8, 25);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.FireProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 100, 100);

            SetSkill(SkillName.Tactics, 40.0, 50.0);
            SetSkill(SkillName.Anatomy, 65.0, 75.0);
            SetSkill(SkillName.Swords, 65.0, 75.0);
            SetSkill(SkillName.Macing, 65.0, 75.0);
            SetSkill(SkillName.Fencing, 65.0, 75.0);
            SetSkill(SkillName.Wrestling, 65.0, 75.0);
            SetSkill(SkillName.Parry, 55.0, 65.0);
            SetSkill(SkillName.MagicResist, 90.0, 100.0);
            SetSkill(SkillName.DetectHidden, 40.0, 50.0);
            SetSkill(SkillName.Magery, 80.0, 90.0);
            SetSkill(SkillName.EvalInt, 80.0, 90.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 41;
        }

        public override string DefaultName => "a gargoyle";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluGoblin1 : BaseCreature
    {
        [Constructible]
        public ZuluGoblin1() : base(AIType.AI_Melee)
        {
            Body = 400;
            Hue = 0x499;
            BaseSoundID = 0x253;

            SetStr(150);
            SetDex(600);
            SetInt(75);
            SetHits(300);
            SetMana(0);
            SetStam(600);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.WaterProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.EarthProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 2, 2);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Anatomy, 90.0, 100.0);
            SetSkill(SkillName.Swords, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.Fencing, 90.0, 100.0);
            SetSkill(SkillName.Wrestling, 90.0, 100.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 65.0, 75.0);
            SetSkill(SkillName.DetectHidden, 60.0, 70.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 48;

            EquipItem(new ShortPants(0x14));
            EquipItem(new LongPants(0x5F));
            EquipItem(new WizardsHat(0x455));
        }

        public override string DefaultName => "goblin1, the goblin";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluGoblin2 : BaseCreature
    {
        [Constructible]
        public ZuluGoblin2() : base(AIType.AI_Melee)
        {
            Body = 400;
            Hue = 0x499;
            BaseSoundID = 0x255;

            SetStr(150);
            SetDex(600);
            SetInt(75);
            SetHits(300);
            SetMana(0);
            SetStam(600);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.WaterProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.EarthProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 2, 2);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Anatomy, 90.0, 100.0);
            SetSkill(SkillName.Swords, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.Fencing, 90.0, 100.0);
            SetSkill(SkillName.Wrestling, 90.0, 100.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 65.0, 75.0);
            SetSkill(SkillName.DetectHidden, 60.0, 70.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 48;

            EquipItem(new ShortPants(0x28));
            EquipItem(new LongPants(0x4B));
            EquipItem(new WizardsHat(0x514));
        }

        public override string DefaultName => "goblin2, the goblin";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluGoblin3 : BaseCreature
    {
        [Constructible]
        public ZuluGoblin3() : base(AIType.AI_Melee)
        {
            Body = 400;
            Hue = 0x499;
            BaseSoundID = 0x256;

            SetStr(200);
            SetDex(600);
            SetInt(75);
            SetHits(450);
            SetMana(0);
            SetStam(600);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.WaterProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.EarthProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 2, 2);

            SetSkill(SkillName.Tactics, 100.0, 110.0);
            SetSkill(SkillName.Anatomy, 100.0, 110.0);
            SetSkill(SkillName.Swords, 100.0, 110.0);
            SetSkill(SkillName.Macing, 100.0, 110.0);
            SetSkill(SkillName.Fencing, 100.0, 110.0);
            SetSkill(SkillName.Wrestling, 100.0, 110.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 75.0, 85.0);
            SetSkill(SkillName.DetectHidden, 80.0, 90.0);
            SetSkill(SkillName.Hiding, 90.0, 100.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 50;

            EquipItem(new ShortPants(0x3C));
            EquipItem(new LongPants(0x37));
            EquipItem(new WizardsHat(0x23));
        }

        public override string DefaultName => "goblin3, the goblin warrior";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluGoblin4 : BaseCreature
    {
        [Constructible]
        public ZuluGoblin4() : base(AIType.AI_Melee)
        {
            Body = 400;
            Hue = 0x499;
            BaseSoundID = 0x257;

            SetStr(200);
            SetDex(600);
            SetInt(75);
            SetHits(450);
            SetMana(0);
            SetStam(600);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.WaterProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.EarthProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 2, 2);

            SetSkill(SkillName.Tactics, 100.0, 110.0);
            SetSkill(SkillName.Anatomy, 100.0, 110.0);
            SetSkill(SkillName.Swords, 100.0, 110.0);
            SetSkill(SkillName.Macing, 100.0, 110.0);
            SetSkill(SkillName.Fencing, 100.0, 110.0);
            SetSkill(SkillName.Wrestling, 100.0, 110.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 75.0, 85.0);
            SetSkill(SkillName.DetectHidden, 80.0, 90.0);
            SetSkill(SkillName.Hiding, 90.0, 100.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 50;
        }

        public override string DefaultName => "goblin4, the goblin warrior";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluGoblinarcher : BaseCreature
    {
        [Constructible]
        public ZuluGoblinarcher() : base(AIType.AI_Archer)
        {
            Body = 400;
            Hue = 0x499;
            BaseSoundID = 0x255;

            SetStr(200);
            SetDex(600);
            SetInt(75);
            SetHits(450);
            SetMana(0);
            SetStam(600);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.WaterProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.EarthProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 2, 2);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Anatomy, 90.0, 100.0);
            SetSkill(SkillName.Swords, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.Fencing, 90.0, 100.0);
            SetSkill(SkillName.Wrestling, 90.0, 100.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 75.0, 85.0);
            SetSkill(SkillName.DetectHidden, 90.0, 100.0);
            SetSkill(SkillName.Hiding, 90.0, 100.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 50;

            EquipItem(new ShortPants(0x64));
            EquipItem(new LongPants(0xF));
            EquipItem(new WizardsHat(0x455));
        }

        public override string DefaultName => "goblinarcher, the goblin archer";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluGolem : BaseCreature
    {
        [Constructible]
        public ZuluGolem() : base(AIType.AI_Melee)
        {
            Body = 76;
            Hue = 0x497;

            SetStr(1000);
            SetDex(1000);
            SetInt(1000);
            SetHits(1000);
            SetMana(1000);
            SetStam(90);

            SetDamage(25, 80);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.FireProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 3, 3);

            SetSkill(SkillName.Tactics, 115.0, 125.0);
            SetSkill(SkillName.Macing, 165.0, 175.0);
            SetSkill(SkillName.MagicResist, 120.0, 130.0);
            SetSkill(SkillName.Magery, 90.0, 100.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 26;
        }

        public override string DefaultName => "a clay golem";

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluGoliath : BaseCreature
    {
        [Constructible]
        public ZuluGoliath() : base(AIType.AI_Melee)
        {
            Body = 281;
            Hue = 0x484;
            BaseSoundID = 0x4F9;

            SetStr(400);
            SetDex(1000);
            SetInt(100);
            SetHits(15000);
            SetMana(100);
            SetStam(600);

            SetDamage(12, 35);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.FireProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.WaterProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.AirProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.NecroProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.EarthProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 2, 2);

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
        }

        public override string DefaultName => "The Goliath";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.FilthyRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluGreatershadow : BaseCreature
    {
        [Constructible]
        public ZuluGreatershadow() : base(AIType.AI_Melee)
        {
            Body = 573;
            Hue = 0x484;

            SetStr(350);
            SetDex(200);
            SetInt(200);
            SetHits(500);
            SetMana(200);
            SetStam(200);

            SetDamage(12, 35);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.NecroProtection, 80, 80);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 5, 5);

            SetSkill(SkillName.Tactics, 115.0, 125.0);
            SetSkill(SkillName.Fencing, 140.0, 150.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 115.0, 125.0);
            SetSkill(SkillName.DetectHidden, 120.0, 130.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 58;
        }

        public override string DefaultName => "a Greater Shadow";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluHeadless : BaseCreature
    {
        [Constructible]
        public ZuluHeadless() : base(AIType.AI_Melee)
        {
            Body = 31;
            BaseSoundID = 0x19C;

            SetStr(100);
            SetDex(100);
            SetInt(15);
            SetHits(200);
            SetMana(15);
            SetStam(600);

            SetDamage(5, 15);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.NecroProtection, 20, 20);

            SetSkill(SkillName.Tactics, 80.0, 90.0);
            SetSkill(SkillName.Anatomy, 65.0, 75.0);
            SetSkill(SkillName.Swords, 65.0, 75.0);
            SetSkill(SkillName.Macing, 65.0, 75.0);
            SetSkill(SkillName.Fencing, 65.0, 75.0);
            SetSkill(SkillName.Wrestling, 65.0, 75.0);
            SetSkill(SkillName.Parry, 40.0, 50.0);
            SetSkill(SkillName.MagicResist, 40.0, 50.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 26;
        }

        public override string DefaultName => "a headless one";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluHealerpk : BaseCreature
    {
        [Constructible]
        public ZuluHealerpk() : base(AIType.AI_Mage)
        {
            Body = 401;
            Hue = 0x83F8;

            SetStr(300);
            SetDex(200);
            SetInt(300);
            SetHits(100);
            SetMana(200);
            SetStam(100);

            SetDamage(12, 35);
            z_Physical_DD = 100;

            SetSkill(SkillName.Macing, 190.0, 200.0);
            SetSkill(SkillName.Magery, 190.0, 200.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 0;
        }

        public override string DefaultName => "healerpk Healer";

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluIcefiend : BaseCreature
    {
        [Constructible]
        public ZuluIcefiend() : base(AIType.AI_Mage)
        {
            Body = 9;
            Hue = 0x492;
            BaseSoundID = 0x16A;

            SetStr(400);
            SetDex(800);
            SetInt(400);
            SetHits(1500);
            SetMana(800);
            SetStam(800);

            SetDamage(12, 35);
            z_Air_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.WaterProtection, 100, 100);
            AddMobZuluModifier(ZuluMod.AirProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.NecroProtection, 100, 100);
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

        public override string DefaultName => "an Ice Fiend";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluIcemagebrother : BaseCreature
    {
        [Constructible]
        public ZuluIcemagebrother() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x3EA;
            BaseSoundID = 0x15C;

            SetStr(750);
            SetDex(750);
            SetInt(500);
            SetHits(1500);
            SetMana(2500);
            SetStam(1500);

            SetDamage(18, 50);
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
            SetSkill(SkillName.Parry, 60.0, 70.0);
            SetSkill(SkillName.MagicResist, 130.0, 140.0);
            SetSkill(SkillName.DetectHidden, 80.0, 90.0);
            SetSkill(SkillName.Magery, 140.0, 150.0);
            SetSkill(SkillName.EvalInt, 110.0, 120.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 51;
        }

        public override string DefaultName => "icemagebrother, the Icemage brother";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.FilthyRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluIcespawn : BaseCreature
    {
        [Constructible]
        public ZuluIcespawn() : base(AIType.AI_Melee)
        {
            Body = 39;
            Hue = 0x492;
            BaseSoundID = 0x1AB;

            SetStr(75);
            SetDex(200);
            SetInt(50);
            SetHits(300);
            SetMana(50);
            SetStam(600);

            SetDamage(5, 15);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.FireProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.WaterProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.NecroProtection, 40, 40);

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
        }

        public override string DefaultName => "an ice spawn";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluImmolatedvirgin : BaseCreature
    {
        [Constructible]
        public ZuluImmolatedvirgin() : base(AIType.AI_Mage)
        {
            Body = 401;
            Hue = 0x482;
            BaseSoundID = 0x186;

            SetStr(750);
            SetDex(750);
            SetInt(500);
            SetHits(4000);
            SetMana(2500);
            SetStam(1500);

            SetDamage(18, 50);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.FireProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.WaterProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.AirProtection, 20, 20);
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

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 51;
        }

        public override string DefaultName => "The Immolated Virgin";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.FilthyRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluImmolator : BaseCreature
    {
        [Constructible]
        public ZuluImmolator() : base(AIType.AI_Melee)
        {
            Body = 400;
            Hue = 0x496;

            SetStr(600);
            SetDex(600);
            SetInt(500);
            SetHits(1200);
            SetMana(0);
            SetStam(150);

            SetDamage(18, 50);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 8, 8);

            SetSkill(SkillName.Tactics, 120.0, 130.0);
            SetSkill(SkillName.Swords, 120.0, 130.0);
            SetSkill(SkillName.Macing, 140.0, 150.0);
            SetSkill(SkillName.Fencing, 120.0, 130.0);
            SetSkill(SkillName.MagicResist, 150.0, 160.0);
            SetSkill(SkillName.DetectHidden, 120.0, 130.0);
            SetSkill(SkillName.Poisoning, 90.0, 100.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 32;
        }

        public override string DefaultName => "immolator, the Immolator";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluInsanehermit : BaseCreature
    {
        [Constructible]
        public ZuluInsanehermit() : base(AIType.AI_Mage)
        {
            Body = 24;
            Hue = 0x484;
            BaseSoundID = 0x3EE;

            SetStr(150);
            SetDex(1000);
            SetInt(10000);
            SetHits(10000);
            SetMana(20000);
            SetStam(20000);

            SetDamage(8, 25);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.WaterProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.AirProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.NecroProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.EarthProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 8, 8);

            SetSkill(SkillName.Tactics, 120.0, 130.0);
            SetSkill(SkillName.Anatomy, 120.0, 130.0);
            SetSkill(SkillName.Swords, 120.0, 130.0);
            SetSkill(SkillName.Macing, 120.0, 130.0);
            SetSkill(SkillName.Fencing, 120.0, 130.0);
            SetSkill(SkillName.Wrestling, 120.0, 130.0);
            SetSkill(SkillName.Parry, 115.0, 125.0);
            SetSkill(SkillName.MagicResist, 140.0, 150.0);
            SetSkill(SkillName.DetectHidden, 115.0, 125.0);
            SetSkill(SkillName.Magery, 190.0, 200.0);
            SetSkill(SkillName.EvalInt, 190.0, 200.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 71;
        }

        public override string DefaultName => "Griswold, the insane hermit";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluJuiz : BaseCreature
    {
        [Constructible]
        public ZuluJuiz() : base(AIType.AI_Melee)
        {
            Body = 400;
            Hue = 0x83F8;

            SetStr(6000);
            SetDex(6000);
            SetInt(6000);
            SetHits(6000);
            SetMana(200);
            SetStam(200);

            SetDamage(5, 500);
            z_Physical_DD = 100;

            SetSkill(SkillName.Tactics, 40.0, 50.0);
            SetSkill(SkillName.Wrestling, 90.0, 100.0);
            SetSkill(SkillName.Magery, 60.0, 70.0);
            SetSkill(SkillName.Inscribe, 80.0, 90.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 0;
        }

        public override string DefaultName => "juiz";

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluLadydeath : BaseCreature
    {
        [Constructible]
        public ZuluLadydeath() : base(AIType.AI_Melee)
        {
            Body = 400;
            Hue = 0x484;

            SetStr(600);
            SetDex(600);
            SetInt(500);
            SetHits(1200);
            SetMana(0);
            SetStam(150);

            SetDamage(18, 50);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 8, 8);

            SetSkill(SkillName.Tactics, 120.0, 130.0);
            SetSkill(SkillName.Swords, 120.0, 130.0);
            SetSkill(SkillName.Macing, 140.0, 150.0);
            SetSkill(SkillName.Fencing, 120.0, 130.0);
            SetSkill(SkillName.MagicResist, 150.0, 160.0);
            SetSkill(SkillName.DetectHidden, 120.0, 130.0);
            SetSkill(SkillName.Poisoning, 90.0, 100.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 32;
        }

        public override string DefaultName => "The Death";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluLavos1 : BaseCreature
    {
        [Constructible]
        public ZuluLavos1() : base(AIType.AI_Mage)
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

        public override string DefaultName => "Lavos";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluLavos10 : BaseCreature
    {
        [Constructible]
        public ZuluLavos10() : base(AIType.AI_Mage)
        {
            Body = 72;
            BaseSoundID = 0x34C;

            SetStr(5000);
            SetDex(1200);
            SetInt(10000);
            SetHits(20000);
            SetMana(20000);
            SetStam(20000);

            SetDamage(40, 100);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 70, 70);
            AddMobZuluModifier(ZuluMod.FireProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.WaterProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.AirProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.NecroProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.HollyProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.EarthProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 8, 8);

            SetSkill(SkillName.Tactics, 190.0, 200.0);
            SetSkill(SkillName.Anatomy, 120.0, 130.0);
            SetSkill(SkillName.Swords, 190.0, 200.0);
            SetSkill(SkillName.Macing, 190.0, 200.0);
            SetSkill(SkillName.Fencing, 190.0, 200.0);
            SetSkill(SkillName.Wrestling, 65.0, 75.0);
            SetSkill(SkillName.Parry, 190.0, 200.0);
            SetSkill(SkillName.MagicResist, 140.0, 150.0);
            SetSkill(SkillName.DetectHidden, 130.0, 140.0);
            SetSkill(SkillName.Magery, 190.0, 200.0);
            SetSkill(SkillName.EvalInt, 190.0, 200.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 80;
        }

        public override string DefaultName => "Lavos";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluLavos11 : BaseCreature
    {
        [Constructible]
        public ZuluLavos11() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x482;
            BaseSoundID = 0x34C;

            SetStr(5000);
            SetDex(1200);
            SetInt(10000);
            SetHits(20000);
            SetMana(20000);
            SetStam(20000);

            SetDamage(40, 100);
            z_Air_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.WaterProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.AirProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.NecroProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.EarthProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 8, 8);

            SetSkill(SkillName.Tactics, 190.0, 200.0);
            SetSkill(SkillName.Anatomy, 120.0, 130.0);
            SetSkill(SkillName.Swords, 190.0, 200.0);
            SetSkill(SkillName.Macing, 190.0, 200.0);
            SetSkill(SkillName.Fencing, 190.0, 200.0);
            SetSkill(SkillName.Wrestling, 65.0, 75.0);
            SetSkill(SkillName.Parry, 190.0, 200.0);
            SetSkill(SkillName.MagicResist, 140.0, 150.0);
            SetSkill(SkillName.DetectHidden, 130.0, 140.0);
            SetSkill(SkillName.Magery, 190.0, 200.0);
            SetSkill(SkillName.EvalInt, 190.0, 200.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 80;
        }

        public override string DefaultName => "Lavos";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluLavos2 : BaseCreature
    {
        [Constructible]
        public ZuluLavos2() : base(AIType.AI_Mage)
        {
            Body = 22;
            Hue = 0x482;
            BaseSoundID = 0x17E;

            SetStr(250);
            SetDex(100);
            SetInt(200);
            SetHits(500);
            SetMana(1000);
            SetStam(200);

            SetDamage(8, 25);
            z_Air_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.WaterProtection, 50, 50);
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

        public override string DefaultName => "Lavos";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluLavos3 : BaseCreature
    {
        [Constructible]
        public ZuluLavos3() : base(AIType.AI_Mage)
        {
            Body = 22;
            Hue = 0x494;
            BaseSoundID = 0x17E;

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

        public override string DefaultName => "Lavos";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluLavos4 : BaseCreature
    {
        [Constructible]
        public ZuluLavos4() : base(AIType.AI_Mage)
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

        public override string DefaultName => "Lavos";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluLavos5 : BaseCreature
    {
        [Constructible]
        public ZuluLavos5() : base(AIType.AI_Mage)
        {
            Body = 985;
            Hue = 0x486;
            BaseSoundID = 0x476;

            SetStr(750);
            SetDex(750);
            SetInt(500);
            SetHits(1500);
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

        public override string DefaultName => "Lavos";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluLavos6 : BaseCreature
    {
        [Constructible]
        public ZuluLavos6() : base(AIType.AI_Mage)
        {
            Body = 9;
            Hue = 0x4001;
            BaseSoundID = 0x166;

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
            AddMobZuluModifier(ZuluMod.WaterProtection, 10, 10);
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
        }

        public override string DefaultName => "Lavos";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluLavos7 : BaseCreature
    {
        [Constructible]
        public ZuluLavos7() : base(AIType.AI_Mage)
        {
            Body = 9;
            Hue = 0x488;
            BaseSoundID = 0x167;

            SetStr(150);
            SetDex(1000);
            SetInt(10000);
            SetHits(5000);
            SetMana(20000);
            SetStam(20000);

            SetDamage(8, 25);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.WaterProtection, 10, 10);
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
            SetSkill(SkillName.MagicResist, 140.0, 150.0);
            SetSkill(SkillName.DetectHidden, 115.0, 125.0);
            SetSkill(SkillName.Magery, 190.0, 200.0);
            SetSkill(SkillName.EvalInt, 190.0, 200.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 71;
        }

        public override string DefaultName => "Lavos";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluLavos8 : BaseCreature
    {
        [Constructible]
        public ZuluLavos8() : base(AIType.AI_Mage)
        {
            Body = 256;
            Hue = 0x494;
            BaseSoundID = 0x2AC;

            SetStr(100);
            SetDex(1000);
            SetInt(10000);
            SetHits(5000);
            SetMana(20000);
            SetStam(20000);

            SetDamage(5, 15);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.AirProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.NecroProtection, 100, 100);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 8, 8);

            SetSkill(SkillName.Tactics, 110.0, 120.0);
            SetSkill(SkillName.Anatomy, 110.0, 120.0);
            SetSkill(SkillName.Swords, 110.0, 120.0);
            SetSkill(SkillName.Macing, 110.0, 120.0);
            SetSkill(SkillName.Fencing, 110.0, 120.0);
            SetSkill(SkillName.Wrestling, 110.0, 120.0);
            SetSkill(SkillName.Parry, 115.0, 125.0);
            SetSkill(SkillName.MagicResist, 140.0, 150.0);
            SetSkill(SkillName.DetectHidden, 115.0, 125.0);
            SetSkill(SkillName.Magery, 190.0, 200.0);
            SetSkill(SkillName.EvalInt, 190.0, 200.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 71;
        }

        public override string DefaultName => "Lavos";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluLavos9 : BaseCreature
    {
        [Constructible]
        public ZuluLavos9() : base(AIType.AI_Mage)
        {
            Body = 250;
            BaseSoundID = 0x266;

            SetStr(100);
            SetDex(1000);
            SetInt(10000);
            SetHits(10000);
            SetMana(20000);
            SetStam(20000);

            SetDamage(5, 15);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.WaterProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.NecroProtection, 100, 100);
            AddMobZuluModifier(ZuluMod.EarthProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 8, 8);

            SetSkill(SkillName.Tactics, 110.0, 120.0);
            SetSkill(SkillName.Anatomy, 110.0, 120.0);
            SetSkill(SkillName.Swords, 110.0, 120.0);
            SetSkill(SkillName.Macing, 110.0, 120.0);
            SetSkill(SkillName.Fencing, 110.0, 120.0);
            SetSkill(SkillName.Wrestling, 110.0, 120.0);
            SetSkill(SkillName.Parry, 115.0, 125.0);
            SetSkill(SkillName.MagicResist, 140.0, 150.0);
            SetSkill(SkillName.DetectHidden, 115.0, 125.0);
            SetSkill(SkillName.Magery, 190.0, 200.0);
            SetSkill(SkillName.EvalInt, 190.0, 200.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 71;
        }

        public override string DefaultName => "Lavos";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluLavosassistant : BaseCreature
    {
        [Constructible]
        public ZuluLavosassistant() : base(AIType.AI_Melee)
        {
            Body = 400;
            Hue = 0x492;

            SetStr(450);
            SetDex(800);
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

        public override string DefaultName => "lavosassistant, the Lavos assistant";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluLavossummon : BaseCreature
    {
        [Constructible]
        public ZuluLavossummon() : base(AIType.AI_Melee)
        {
            Body = 573;
            Hue = 0x492;

            SetStr(550);
            SetDex(300);
            SetInt(200);
            SetHits(550);
            SetMana(200);
            SetStam(300);

            SetDamage(18, 50);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.NecroProtection, 80, 80);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 6, 6);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Fencing, 165.0, 175.0);
            SetSkill(SkillName.Parry, 120.0, 130.0);
            SetSkill(SkillName.MagicResist, 140.0, 150.0);
            SetSkill(SkillName.DetectHidden, 120.0, 130.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 73;
        }

        public override string DefaultName => "a Lavos Summon";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluLessershadow : BaseCreature
    {
        [Constructible]
        public ZuluLessershadow() : base(AIType.AI_Mage)
        {
            Body = 573;
            Hue = 0x4631;

            SetStr(300);
            SetDex(200);
            SetInt(500);
            SetHits(500);
            SetMana(500);
            SetStam(80);

            SetDamage(12, 35);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.NecroProtection, 80, 80);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 4, 4);

            SetSkill(SkillName.Tactics, 115.0, 125.0);
            SetSkill(SkillName.Fencing, 120.0, 130.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 95.0, 105.0);
            SetSkill(SkillName.DetectHidden, 120.0, 130.0);
            SetSkill(SkillName.EvalInt, 90.0, 100.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 54;
        }

        public override string DefaultName => "a Lesser Shadow";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluMagehunter : BaseCreature
    {
        [Constructible]
        public ZuluMagehunter() : base(AIType.AI_Melee)
        {
            Body = 574;
            Hue = 0x492;

            SetStr(200);
            SetDex(600);
            SetInt(25);
            SetHits(200);
            SetMana(0);
            SetStam(150);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 8, 8);

            SetSkill(SkillName.Tactics, 120.0, 130.0);
            SetSkill(SkillName.Macing, 140.0, 150.0);
            SetSkill(SkillName.MagicResist, 150.0, 160.0);
            SetSkill(SkillName.DetectHidden, 120.0, 130.0);
            SetSkill(SkillName.Poisoning, 90.0, 100.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 32;
        }

        public override string DefaultName => "a Mage Hunter";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluMagus : BaseCreature
    {
        [Constructible]
        public ZuluMagus() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x488;

            SetStr(2000);
            SetDex(2200);
            SetInt(4000);
            SetHits(5000);
            SetMana(50000);
            SetStam(20000);

            SetDamage(40, 100);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 70, 70);
            AddMobZuluModifier(ZuluMod.FireProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.WaterProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.AirProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 100, 100);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.EarthProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 6, 6);

            SetSkill(SkillName.Tactics, 190.0, 200.0);
            SetSkill(SkillName.Macing, 190.0, 200.0);
            SetSkill(SkillName.Fencing, 190.0, 200.0);
            SetSkill(SkillName.Parry, 190.0, 200.0);
            SetSkill(SkillName.MagicResist, 140.0, 150.0);
            SetSkill(SkillName.DetectHidden, 190.0, 200.0);
            SetSkill(SkillName.Magery, 190.0, 200.0);
            SetSkill(SkillName.EvalInt, 190.0, 200.0);

            Fame = 2500;
            Karma = -2500;
            VirtualArmor = 80;
        }

        public override string DefaultName => "Magus";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluMagusairmaster : BaseCreature
    {
        [Constructible]
        public ZuluMagusairmaster() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x3EA;

            SetStr(1500);
            SetDex(1500);
            SetInt(5000);
            SetHits(7000);
            SetMana(8500);
            SetStam(8500);

            SetDamage(25, 80);
            z_Air_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.FireProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.WaterProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.AirProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.NecroProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.EarthProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 8, 8);

            SetSkill(SkillName.Tactics, 80.0, 90.0);
            SetSkill(SkillName.Macing, 100.0, 110.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 140.0, 150.0);
            SetSkill(SkillName.DetectHidden, 190.0, 200.0);
            SetSkill(SkillName.Magery, 165.0, 175.0);

            Fame = 35000;
            Karma = -35000;
            VirtualArmor = 63;
        }

        public override string DefaultName => "magusairmaster, the Jail Warden";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluMagusbodyguard : BaseCreature
    {
        [Constructible]
        public ZuluMagusbodyguard() : base(AIType.AI_Melee)
        {
            Body = 400;

            SetStr(600);
            SetDex(600);
            SetInt(600);
            SetHits(1200);
            SetMana(1200);
            SetStam(1200);

            SetDamage(18, 50);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 120.0, 130.0);
            SetSkill(SkillName.Swords, 140.0, 150.0);
            SetSkill(SkillName.Fencing, 120.0, 130.0);
            SetSkill(SkillName.Parry, 140.0, 150.0);
            SetSkill(SkillName.MagicResist, 55.0, 65.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 63;
        }

        public override string DefaultName => "Magus Body Guard";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluMagusearthmaster : BaseCreature
    {
        [Constructible]
        public ZuluMagusearthmaster() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x3EA;

            SetStr(1500);
            SetDex(1500);
            SetInt(500);
            SetHits(7000);
            SetMana(8500);
            SetStam(8500);

            SetDamage(25, 80);
            z_Necro_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.FireProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.WaterProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.AirProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.NecroProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.EarthProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 8, 8);

            SetSkill(SkillName.Tactics, 80.0, 90.0);
            SetSkill(SkillName.Macing, 100.0, 110.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 140.0, 150.0);
            SetSkill(SkillName.DetectHidden, 190.0, 200.0);
            SetSkill(SkillName.Magery, 165.0, 175.0);

            Fame = 35000;
            Karma = -35000;
            VirtualArmor = 63;
        }

        public override string DefaultName => "magusearthmaster, the Magus Earth Master";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluMagusfiremaster : BaseCreature
    {
        [Constructible]
        public ZuluMagusfiremaster() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x3EA;

            SetStr(1500);
            SetDex(1500);
            SetInt(4000);
            SetHits(7000);
            SetMana(8000);
            SetStam(8000);

            SetDamage(25, 80);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.FireProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.WaterProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.AirProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.NecroProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.EarthProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 8, 8);

            SetSkill(SkillName.Tactics, 80.0, 90.0);
            SetSkill(SkillName.Macing, 100.0, 110.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 140.0, 150.0);
            SetSkill(SkillName.DetectHidden, 190.0, 200.0);
            SetSkill(SkillName.Magery, 165.0, 175.0);

            Fame = 35000;
            Karma = -35000;
            VirtualArmor = 63;
        }

        public override string DefaultName => "magusfiremaster, the Magus Fire Master";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluMagusmountedsoldier : BaseCreature
    {
        [Constructible]
        public ZuluMagusmountedsoldier() : base(AIType.AI_Melee)
        {
            Body = 400;

            SetStr(350);
            SetDex(600);
            SetInt(80);
            SetHits(600);
            SetMana(80);
            SetStam(1200);

            SetDamage(12, 35);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 120.0, 130.0);
            SetSkill(SkillName.Swords, 140.0, 150.0);
            SetSkill(SkillName.Fencing, 120.0, 130.0);
            SetSkill(SkillName.Parry, 140.0, 150.0);
            SetSkill(SkillName.MagicResist, 55.0, 65.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 63;
        }

        public override string DefaultName => "Magus Mounted Soldier";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluMagusscholar1 : BaseCreature
    {
        [Constructible]
        public ZuluMagusscholar1() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x83F8;
            BaseSoundID = 0x186;

            SetStr(750);
            SetDex(750);
            SetInt(1000);
            SetHits(1500);
            SetMana(2000);
            SetStam(1500);

            SetDamage(18, 50);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.FireProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.WaterProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.AirProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.EarthProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 2, 2);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Swords, 90.0, 100.0);
            SetSkill(SkillName.Macing, 165.0, 175.0);
            SetSkill(SkillName.Parry, 60.0, 70.0);
            SetSkill(SkillName.MagicResist, 130.0, 140.0);
            SetSkill(SkillName.DetectHidden, 80.0, 90.0);
            SetSkill(SkillName.Magery, 140.0, 150.0);
            SetSkill(SkillName.EvalInt, 110.0, 120.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 51;
        }

        public override string DefaultName => "a Magus scholar";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluMagusscholar2 : BaseCreature
    {
        [Constructible]
        public ZuluMagusscholar2() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x83F8;
            BaseSoundID = 0x186;

            SetStr(750);
            SetDex(750);
            SetInt(1000);
            SetHits(1500);
            SetMana(2000);
            SetStam(1500);

            SetDamage(18, 50);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.FireProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.WaterProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.AirProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.EarthProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 2, 2);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Swords, 90.0, 100.0);
            SetSkill(SkillName.Macing, 165.0, 175.0);
            SetSkill(SkillName.Parry, 60.0, 70.0);
            SetSkill(SkillName.MagicResist, 130.0, 140.0);
            SetSkill(SkillName.DetectHidden, 80.0, 90.0);
            SetSkill(SkillName.Magery, 140.0, 150.0);
            SetSkill(SkillName.EvalInt, 110.0, 120.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 51;
        }

        public override string DefaultName => "a Magus scholar";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluMagusscholar3 : BaseCreature
    {
        [Constructible]
        public ZuluMagusscholar3() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x83F8;
            BaseSoundID = 0x186;

            SetStr(750);
            SetDex(750);
            SetInt(1000);
            SetHits(1500);
            SetMana(2000);
            SetStam(1500);

            SetDamage(18, 50);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.FireProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.WaterProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.AirProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.EarthProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 2, 2);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Swords, 90.0, 100.0);
            SetSkill(SkillName.Macing, 165.0, 175.0);
            SetSkill(SkillName.Parry, 60.0, 70.0);
            SetSkill(SkillName.MagicResist, 130.0, 140.0);
            SetSkill(SkillName.DetectHidden, 80.0, 90.0);
            SetSkill(SkillName.Magery, 140.0, 150.0);
            SetSkill(SkillName.EvalInt, 110.0, 120.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 51;
        }

        public override string DefaultName => "a Magus scholar";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluMagussoldier : BaseCreature
    {
        [Constructible]
        public ZuluMagussoldier() : base(AIType.AI_Melee)
        {
            Body = 400;

            SetStr(350);
            SetDex(600);
            SetInt(80);
            SetHits(600);
            SetMana(80);
            SetStam(1200);

            SetDamage(12, 35);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 120.0, 130.0);
            SetSkill(SkillName.Swords, 140.0, 150.0);
            SetSkill(SkillName.Fencing, 120.0, 130.0);
            SetSkill(SkillName.Parry, 140.0, 150.0);
            SetSkill(SkillName.MagicResist, 55.0, 65.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 63;
        }

        public override string DefaultName => "Magus Soldier";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluMaguswatermaster : BaseCreature
    {
        [Constructible]
        public ZuluMaguswatermaster() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x3EA;

            SetStr(1500);
            SetDex(1500);
            SetInt(4000);
            SetHits(7000);
            SetMana(8000);
            SetStam(8000);

            SetDamage(25, 80);
            z_Necro_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.FireProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.WaterProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.AirProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.NecroProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.EarthProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 8, 8);

            SetSkill(SkillName.Tactics, 80.0, 90.0);
            SetSkill(SkillName.Macing, 100.0, 110.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 140.0, 150.0);
            SetSkill(SkillName.DetectHidden, 190.0, 200.0);
            SetSkill(SkillName.Magery, 165.0, 175.0);

            Fame = 35000;
            Karma = -35000;
            VirtualArmor = 63;
        }

        public override string DefaultName => "maguswatermaster, the Magus Water Master";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluMedusa : BaseCreature
    {
        [Constructible]
        public ZuluMedusa() : base(AIType.AI_Mage)
        {
            Body = 265;
            Hue = 0x494;
            BaseSoundID = 0x56E;

            SetStr(200);
            SetDex(500);
            SetInt(2000);
            SetHits(5000);
            SetMana(20000);
            SetStam(20000);

            SetDamage(8, 25);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.FireProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.WaterProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.AirProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.EarthProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 6, 6);

            SetSkill(SkillName.Tactics, 110.0, 120.0);
            SetSkill(SkillName.Anatomy, 110.0, 120.0);
            SetSkill(SkillName.Swords, 110.0, 120.0);
            SetSkill(SkillName.Macing, 110.0, 120.0);
            SetSkill(SkillName.Fencing, 110.0, 120.0);
            SetSkill(SkillName.Wrestling, 110.0, 120.0);
            SetSkill(SkillName.Parry, 115.0, 125.0);
            SetSkill(SkillName.MagicResist, 140.0, 150.0);
            SetSkill(SkillName.DetectHidden, 115.0, 125.0);
            SetSkill(SkillName.Magery, 190.0, 200.0);
            SetSkill(SkillName.EvalInt, 190.0, 200.0);
            SetSkill(SkillName.Poisoning, 90.0, 100.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 71;
        }

        public override string DefaultName => "Hidra";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluMephisto : BaseCreature
    {
        [Constructible]
        public ZuluMephisto() : base(AIType.AI_Mage)
        {
            Body = 250;
            BaseSoundID = 0x266;

            SetStr(700);
            SetDex(1000);
            SetInt(5000);
            SetHits(7000);
            SetMana(20000);
            SetStam(20000);

            SetDamage(18, 50);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.FireProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.WaterProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.NecroProtection, 100, 100);
            AddMobZuluModifier(ZuluMod.EarthProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 8, 8);

            SetSkill(SkillName.Tactics, 110.0, 120.0);
            SetSkill(SkillName.Anatomy, 110.0, 120.0);
            SetSkill(SkillName.Swords, 110.0, 120.0);
            SetSkill(SkillName.Macing, 110.0, 120.0);
            SetSkill(SkillName.Fencing, 110.0, 120.0);
            SetSkill(SkillName.Wrestling, 110.0, 120.0);
            SetSkill(SkillName.Parry, 115.0, 125.0);
            SetSkill(SkillName.MagicResist, 140.0, 150.0);
            SetSkill(SkillName.DetectHidden, 115.0, 125.0);
            SetSkill(SkillName.Magery, 190.0, 200.0);
            SetSkill(SkillName.EvalInt, 190.0, 200.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 71;
        }

        public override string DefaultName => "Mephisto";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluMountedbrigandarcher : BaseCreature
    {
        [Constructible]
        public ZuluMountedbrigandarcher() : base(AIType.AI_Archer)
        {
            Body = 400;

            SetStr(150);
            SetDex(300);
            SetInt(60);
            SetHits(150);
            SetMana(350);
            SetStam(350);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 50.0, 60.0);
            SetSkill(SkillName.Macing, 65.0, 75.0);
            SetSkill(SkillName.MagicResist, 55.0, 65.0);
            SetSkill(SkillName.Archery, 130.0, 140.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 13;

            EquipItem(new Shoes(0x5E4));
            EquipItem(new LongPants(0x59B));
            EquipItem(new Skirt(0x215));
            EquipItem(new StuddedChest());
            EquipItem(new FancyShirt(0x5E4));
        }

        public override string DefaultName => "a brigand archer";

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluNightmare : BaseCreature
    {
        [Constructible]
        public ZuluNightmare() : base(AIType.AI_Mage)
        {
            Body = 200;
            Hue = 0x455;

            SetStr(600);
            SetDex(600);
            SetInt(450);
            SetHits(800);
            SetMana(450);
            SetStam(600);

            SetDamage(18, 50);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 5, 5);

            SetSkill(SkillName.Tactics, 120.0, 130.0);
            SetSkill(SkillName.Macing, 165.0, 175.0);
            SetSkill(SkillName.MagicResist, 90.0, 100.0);
            SetSkill(SkillName.Magery, 140.0, 150.0);
            SetSkill(SkillName.EvalInt, 90.0, 100.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 20;
            MinTameSkill = 140;
        }

        public override string DefaultName => "a nightmare";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluOgre : BaseCreature
    {
        [Constructible]
        public ZuluOgre() : base(AIType.AI_Melee)
        {
            Body = 1;
            Hue = 0x83F8;
            BaseSoundID = 0x1B0;

            SetStr(150);
            SetDex(200);
            SetInt(25);
            SetHits(400);
            SetMana(25);
            SetStam(600);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.EarthProtection, 20, 20);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Anatomy, 90.0, 100.0);
            SetSkill(SkillName.Swords, 165.0, 175.0);
            SetSkill(SkillName.Macing, 165.0, 175.0);
            SetSkill(SkillName.Fencing, 165.0, 175.0);
            SetSkill(SkillName.Wrestling, 165.0, 175.0);
            SetSkill(SkillName.Parry, 70.0, 80.0);
            SetSkill(SkillName.MagicResist, 70.0, 80.0);
            SetSkill(SkillName.DetectHidden, 25.0, 35.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 42;
        }

        public override string DefaultName => "an ogre";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluOgrelord : BaseCreature
    {
        [Constructible]
        public ZuluOgrelord() : base(AIType.AI_Melee)
        {
            Body = 1;
            Hue = 0x488;

            SetStr(500);
            SetDex(230);
            SetInt(75);
            SetHits(500);
            SetMana(75);
            SetStam(230);

            SetDamage(18, 50);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 60, 60);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Macing, 140.0, 150.0);
            SetSkill(SkillName.MagicResist, 70.0, 80.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 16;
        }

        public override string DefaultName => "Ogre Lord";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluOgrerockthrower : BaseCreature
    {
        [Constructible]
        public ZuluOgrerockthrower() : base(AIType.AI_Melee)
        {
            Body = 1;
            Hue = 0x38;

            SetStr(250);
            SetDex(160);
            SetInt(35);
            SetHits(250);
            SetMana(35);
            SetStam(50);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Macing, 110.0, 120.0);
            SetSkill(SkillName.MagicResist, 30.0, 40.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 8;
        }

        public override string DefaultName => "ogre rockthrower";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluOphidianqueen : BaseCreature
    {
        [Constructible]
        public ZuluOphidianqueen() : base(AIType.AI_Mage)
        {
            Body = 87;

            SetStr(350);
            SetDex(70);
            SetInt(700);
            SetHits(350);
            SetMana(700);
            SetStam(50);

            SetDamage(12, 35);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 5, 5);

            SetSkill(SkillName.Tactics, 40.0, 50.0);
            SetSkill(SkillName.Swords, 60.0, 70.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.Parry, 50.0, 60.0);
            SetSkill(SkillName.MagicResist, 85.0, 95.0);
            SetSkill(SkillName.Magery, 110.0, 120.0);

            Fame = 2500;
            Karma = -2500;
            VirtualArmor = 39;
        }

        public override string DefaultName => "an Ophidian Queen";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluOphidianshaman : BaseCreature
    {
        [Constructible]
        public ZuluOphidianshaman() : base(AIType.AI_Mage)
        {
            Body = 85;

            SetStr(160);
            SetDex(70);
            SetInt(350);
            SetHits(300);
            SetMana(350);
            SetStam(50);

            SetDamage(8, 25);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 3, 3);

            SetSkill(SkillName.Tactics, 40.0, 50.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.Parry, 77.0, 87.0);
            SetSkill(SkillName.MagicResist, 80.0, 90.0);
            SetSkill(SkillName.Magery, 100.0, 110.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 47;
        }

        public override string DefaultName => "an Ophidian Shaman";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluOphidianwarrior : BaseCreature
    {
        [Constructible]
        public ZuluOphidianwarrior() : base(AIType.AI_Melee)
        {
            Body = 86;

            SetStr(200);
            SetDex(160);
            SetInt(160);
            SetHits(500);
            SetMana(160);
            SetStam(70);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 75.0, 85.0);
            SetSkill(SkillName.Macing, 80.0, 90.0);
            SetSkill(SkillName.Parry, 60.0, 70.0);
            SetSkill(SkillName.MagicResist, 50.0, 60.0);
            SetSkill(SkillName.Magery, 70.0, 80.0);

            Fame = 5000;
            Karma = -5000;
            VirtualArmor = 35;
        }

        public override string DefaultName => "an Ophidian Warrior";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluPriestbrother : BaseCreature
    {
        [Constructible]
        public ZuluPriestbrother() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x3EA;
            BaseSoundID = 0x15C;

            SetStr(500);
            SetDex(750);
            SetInt(500);
            SetHits(2500);
            SetMana(2500);
            SetStam(1500);

            SetDamage(18, 50);
            z_Air_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.WaterProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.AirProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.HollyProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 1, 1);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Anatomy, 90.0, 100.0);
            SetSkill(SkillName.Swords, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.Fencing, 90.0, 100.0);
            SetSkill(SkillName.Wrestling, 90.0, 100.0);
            SetSkill(SkillName.Parry, 80.0, 90.0);
            SetSkill(SkillName.MagicResist, 140.0, 150.0);
            SetSkill(SkillName.DetectHidden, 80.0, 90.0);
            SetSkill(SkillName.Magery, 140.0, 150.0);
            SetSkill(SkillName.EvalInt, 80.0, 90.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 60;
        }

        public override string DefaultName => "priestbrother, the priest brother";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.FilthyRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluQueenkerrigan : BaseCreature
    {
        [Constructible]
        public ZuluQueenkerrigan() : base(AIType.AI_Mage)
        {
            Body = 258;
            BaseSoundID = 0x3EE;

            SetStr(400);
            SetDex(1000);
            SetInt(5000);
            SetHits(4000);
            SetMana(50000);
            SetStam(30000);

            SetDamage(12, 35);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.FireProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.WaterProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.AirProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.NecroProtection, 100, 100);
            AddMobZuluModifier(ZuluMod.EarthProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 6, 6);

            SetSkill(SkillName.Tactics, 120.0, 130.0);
            SetSkill(SkillName.Anatomy, 120.0, 130.0);
            SetSkill(SkillName.Swords, 120.0, 130.0);
            SetSkill(SkillName.Macing, 120.0, 130.0);
            SetSkill(SkillName.Fencing, 120.0, 130.0);
            SetSkill(SkillName.Wrestling, 120.0, 130.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 110.0, 120.0);
            SetSkill(SkillName.DetectHidden, 90.0, 100.0);
            SetSkill(SkillName.Magery, 140.0, 150.0);
            SetSkill(SkillName.EvalInt, 140.0, 150.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 57;
        }

        public override string DefaultName => "The Queen Kerrigan";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluRedmare : BaseCreature
    {
        [Constructible]
        public ZuluRedmare() : base(AIType.AI_Mage)
        {
            Body = 200;
            Hue = 0x7B5;

            SetStr(450);
            SetDex(600);
            SetInt(450);
            SetHits(450);
            SetMana(450);
            SetStam(450);

            SetDamage(45, 80);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 5, 5);

            SetSkill(SkillName.Tactics, 120.0, 130.0);
            SetSkill(SkillName.Macing, 165.0, 175.0);
            SetSkill(SkillName.MagicResist, 90.0, 100.0);
            SetSkill(SkillName.Magery, 140.0, 150.0);
            SetSkill(SkillName.EvalInt, 90.0, 100.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 20;
            MinTameSkill = 140;
        }

        public override string DefaultName => "a redmare";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluRitualist : BaseCreature
    {
        [Constructible]
        public ZuluRitualist() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x83F8;
            BaseSoundID = 0x424;

            SetStr(700);
            SetDex(600);
            SetInt(400);
            SetHits(3000);
            SetMana(1500);
            SetStam(600);

            SetDamage(18, 50);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 70, 70);
            AddMobZuluModifier(ZuluMod.FireProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.WaterProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.AirProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.NecroProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.HollyProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.EarthProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 6, 6);

            SetSkill(SkillName.Tactics, 120.0, 130.0);
            SetSkill(SkillName.Anatomy, 120.0, 130.0);
            SetSkill(SkillName.Swords, 120.0, 130.0);
            SetSkill(SkillName.Macing, 120.0, 130.0);
            SetSkill(SkillName.Fencing, 120.0, 130.0);
            SetSkill(SkillName.Wrestling, 120.0, 130.0);
            SetSkill(SkillName.Parry, 120.0, 130.0);
            SetSkill(SkillName.MagicResist, 120.0, 130.0);
            SetSkill(SkillName.DetectHidden, 95.0, 105.0);
            SetSkill(SkillName.Magery, 120.0, 130.0);
            SetSkill(SkillName.EvalInt, 120.0, 130.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 69;
        }

        public override string DefaultName => "a ritualist";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluRogueknight : BaseCreature
    {
        [Constructible]
        public ZuluRogueknight() : base(AIType.AI_Melee)
        {
            Body = 400;
            Hue = 0x83F8;

            SetStr(350);
            SetDex(140);
            SetInt(80);
            SetHits(350);
            SetMana(80);
            SetStam(140);

            SetDamage(12, 35);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 120.0, 130.0);
            SetSkill(SkillName.Swords, 140.0, 150.0);
            SetSkill(SkillName.Fencing, 120.0, 130.0);
            SetSkill(SkillName.Parry, 140.0, 150.0);
            SetSkill(SkillName.MagicResist, 55.0, 65.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 63;
        }

        public override string DefaultName => "a rogue knight";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluSewerwanderer : BaseCreature
    {
        [Constructible]
        public ZuluSewerwanderer() : base(AIType.AI_Melee)
        {
            Body = 267;
            Hue = 0x499;

            SetStr(1500);
            SetDex(1200);
            SetInt(1000);
            SetHits(5000);
            SetMana(3000);
            SetStam(3000);

            SetDamage(25, 80);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.WaterProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.AirProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.EarthProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 7, 7);

            SetSkill(SkillName.Tactics, 120.0, 130.0);
            SetSkill(SkillName.Swords, 130.0, 140.0);
            SetSkill(SkillName.Parry, 140.0, 150.0);
            SetSkill(SkillName.MagicResist, 140.0, 150.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 80;
        }

        public override string DefaultName => "sewerwanderer, the sewer wanderer";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluShade : BaseCreature
    {
        [Constructible]
        public ZuluShade() : base(AIType.AI_Melee)
        {
            Body = 400;
            Hue = 0x4631;
            BaseSoundID = 0x183;

            SetStr(150);
            SetDex(200);
            SetInt(100);
            SetHits(150);
            SetMana(0);
            SetStam(600);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 9990, 9990);
            AddMobZuluModifier(ZuluMod.NecroProtection, 40, 40);

            SetSkill(SkillName.Tactics, 70.0, 80.0);
            SetSkill(SkillName.Anatomy, 70.0, 80.0);
            SetSkill(SkillName.Swords, 70.0, 80.0);
            SetSkill(SkillName.Macing, 70.0, 80.0);
            SetSkill(SkillName.Fencing, 70.0, 80.0);
            SetSkill(SkillName.Wrestling, 70.0, 80.0);
            SetSkill(SkillName.Parry, 65.0, 75.0);
            SetSkill(SkillName.MagicResist, 65.0, 75.0);
            SetSkill(SkillName.Hiding, 65.0, 75.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 40;
        }

        public override string DefaultName => "a shade";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluShadowlord : BaseCreature
    {
        [Constructible]
        public ZuluShadowlord() : base(AIType.AI_Melee)
        {
            Body = 573;
            Hue = 0x498;

            SetStr(550);
            SetDex(400);
            SetInt(200);
            SetHits(800);
            SetMana(200);
            SetStam(300);

            SetDamage(18, 50);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.NecroProtection, 80, 80);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 6, 6);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Fencing, 165.0, 175.0);
            SetSkill(SkillName.Parry, 120.0, 130.0);
            SetSkill(SkillName.MagicResist, 140.0, 150.0);
            SetSkill(SkillName.DetectHidden, 120.0, 130.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 73;
        }

        public override string DefaultName => "a Shadow Lord";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluSkullcollector : BaseCreature
    {
        [Constructible]
        public ZuluSkullcollector() : base(AIType.AI_Mage)
        {
            Body = 249;
            Hue = 0x494;

            SetStr(450);
            SetDex(450);
            SetInt(450);
            SetHits(1500);
            SetMana(450);
            SetStam(450);

            SetDamage(12, 35);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 120.0, 130.0);
            SetSkill(SkillName.Macing, 120.0, 130.0);
            SetSkill(SkillName.MagicResist, 80.0, 90.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 18;
        }

        public override string DefaultName => "The Skull Collector";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluSnowabomination : BaseCreature
    {
        [Constructible]
        public ZuluSnowabomination() : base(AIType.AI_Melee)
        {
            Body = 256;
            Hue = 0x484;
            BaseSoundID = 0x1DC;

            SetStr(900);
            SetDex(1100);
            SetInt(200);
            SetHits(7000);
            SetMana(0);
            SetStam(5000);

            SetDamage(18, 50);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.WaterProtection, 100, 100);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 5, 5);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Anatomy, 140.0, 150.0);
            SetSkill(SkillName.Swords, 140.0, 150.0);
            SetSkill(SkillName.Macing, 140.0, 150.0);
            SetSkill(SkillName.Fencing, 140.0, 150.0);
            SetSkill(SkillName.Wrestling, 140.0, 150.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 110.0, 120.0);
            SetSkill(SkillName.DetectHidden, 90.0, 100.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 57;
        }

        public override string DefaultName => "a snow abomination";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.FilthyRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluSpawntest : BaseCreature
    {
        [Constructible]
        public ZuluSpawntest() : base(AIType.AI_Melee)
        {
            Body = 400;
            Hue = 0x7CF;
            BaseSoundID = 0x18D;

            SetStr(1);
            SetDex(600);
            SetInt(1);
            SetHits(1);
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
        }

        public override string DefaultName => "a spawn test (please kill me)";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluStrider : BaseCreature
    {
        [Constructible]
        public ZuluStrider() : base(AIType.AI_Melee)
        {
            Body = 285;
            BaseSoundID = 0x1BF;

            SetStr(600);
            SetDex(100);
            SetInt(25);
            SetHits(300);
            SetMana(25);
            SetStam(200);

            SetDamage(18, 50);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.WaterProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.HollyProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.EarthProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 2, 2);

            SetSkill(SkillName.Tactics, 105.0, 115.0);
            SetSkill(SkillName.Anatomy, 105.0, 115.0);
            SetSkill(SkillName.Swords, 105.0, 115.0);
            SetSkill(SkillName.Macing, 105.0, 115.0);
            SetSkill(SkillName.Fencing, 105.0, 115.0);
            SetSkill(SkillName.Wrestling, 105.0, 115.0);
            SetSkill(SkillName.Parry, 80.0, 90.0);
            SetSkill(SkillName.MagicResist, 40.0, 50.0);
            SetSkill(SkillName.DetectHidden, 40.0, 50.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 40;
        }

        public override string DefaultName => "a strider";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluSubzero : BaseCreature
    {
        [Constructible]
        public ZuluSubzero() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x83F8;
            BaseSoundID = 0x2BD;

            SetStr(100);
            SetDex(1000);
            SetInt(6000);
            SetHits(5000);
            SetMana(10000);
            SetStam(10000);

            SetDamage(5, 15);
            z_Air_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.FireProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.WaterProtection, 100, 100);
            AddMobZuluModifier(ZuluMod.AirProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.NecroProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.EarthProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 8, 8);

            SetSkill(SkillName.Tactics, 120.0, 130.0);
            SetSkill(SkillName.Anatomy, 120.0, 130.0);
            SetSkill(SkillName.Swords, 120.0, 130.0);
            SetSkill(SkillName.Macing, 120.0, 130.0);
            SetSkill(SkillName.Fencing, 120.0, 130.0);
            SetSkill(SkillName.Wrestling, 120.0, 130.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 100.0, 110.0);
            SetSkill(SkillName.DetectHidden, 110.0, 120.0);
            SetSkill(SkillName.Magery, 190.0, 200.0);
            SetSkill(SkillName.EvalInt, 190.0, 200.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 55;
        }

        public override string DefaultName => "Sub-Zero, the Cerimonial Master";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluSummoner : BaseCreature
    {
        [Constructible]
        public ZuluSummoner() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x83F8;
            BaseSoundID = 0x186;

            SetStr(750);
            SetDex(750);
            SetInt(1000);
            SetHits(1500);
            SetMana(2000);
            SetStam(1500);

            SetDamage(18, 50);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.FireProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.WaterProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.AirProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.EarthProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 2, 2);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Swords, 90.0, 100.0);
            SetSkill(SkillName.Macing, 165.0, 175.0);
            SetSkill(SkillName.Parry, 60.0, 70.0);
            SetSkill(SkillName.MagicResist, 130.0, 140.0);
            SetSkill(SkillName.DetectHidden, 80.0, 90.0);
            SetSkill(SkillName.Magery, 140.0, 150.0);
            SetSkill(SkillName.EvalInt, 110.0, 120.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 51;
        }

        public override string DefaultName => "summoner, the Summoner";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluSummoner2 : BaseCreature
    {
        [Constructible]
        public ZuluSummoner2() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x83F8;
            BaseSoundID = 0x186;

            SetStr(750);
            SetDex(750);
            SetInt(1000);
            SetHits(1500);
            SetMana(2000);
            SetStam(1500);

            SetDamage(18, 50);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.FireProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.WaterProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.AirProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.EarthProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 2, 2);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Swords, 90.0, 100.0);
            SetSkill(SkillName.Macing, 165.0, 175.0);
            SetSkill(SkillName.Parry, 60.0, 70.0);
            SetSkill(SkillName.MagicResist, 130.0, 140.0);
            SetSkill(SkillName.DetectHidden, 80.0, 90.0);
            SetSkill(SkillName.Magery, 140.0, 150.0);
            SetSkill(SkillName.EvalInt, 110.0, 120.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 51;
        }

        public override string DefaultName => "summoner2, the Fire Summoner";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluTempleguardian : BaseCreature
    {
        [Constructible]
        public ZuluTempleguardian() : base(AIType.AI_Mage)
        {
            Body = 24;
            Hue = 0xB60;

            SetStr(1200);
            SetDex(310);
            SetInt(2750);
            SetHits(1200);
            SetMana(2750);
            SetStam(310);

            SetDamage(25, 80);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.NecroProtection, 80, 80);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 8, 8);

            SetSkill(SkillName.Tactics, 140.0, 150.0);
            SetSkill(SkillName.Macing, 150.0, 160.0);
            SetSkill(SkillName.MagicResist, 140.0, 150.0);
            SetSkill(SkillName.DetectHidden, 190.0, 200.0);
            SetSkill(SkillName.Magery, 165.0, 175.0);

            Fame = 10000;
            Karma = -10000;
            VirtualArmor = 30;
        }

        public override string DefaultName => "a Fire Temple Guardian";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluTheritualmaster : BaseCreature
    {
        [Constructible]
        public ZuluTheritualmaster() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x83F8;
            BaseSoundID = 0x425;

            SetStr(100);
            SetDex(1000);
            SetInt(10000);
            SetHits(5000);
            SetMana(20000);
            SetStam(20000);

            SetDamage(5, 15);
            z_Air_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.FireProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.WaterProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.AirProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.NecroProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.HollyProtection, 30, 30);
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
            SetSkill(SkillName.DetectHidden, 115.0, 125.0);
            SetSkill(SkillName.Magery, 190.0, 200.0);
            SetSkill(SkillName.EvalInt, 190.0, 200.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 71;
        }

        public override string DefaultName => "theritualmaster, the ritual master";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.FilthyRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluThreeheadedbeast : BaseCreature
    {
        [Constructible]
        public ZuluThreeheadedbeast() : base(AIType.AI_Mage)
        {
            Body = 250;
            Hue = 0x48A;
            BaseSoundID = 0x52B;

            SetStr(500);
            SetDex(1000);
            SetInt(150);
            SetHits(7500);
            SetMana(0);
            SetStam(2000);

            SetDamage(18, 50);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.FireProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.WaterProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.AirProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.EarthProtection, 40, 40);
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

        public override string DefaultName => "The Three Headed Beast";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluTitan : BaseCreature
    {
        [Constructible]
        public ZuluTitan() : base(AIType.AI_Mage)
        {
            Body = 76;

            SetStr(400);
            SetDex(90);
            SetInt(210);
            SetHits(400);
            SetMana(200);
            SetStam(90);

            SetDamage(12, 35);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 3, 3);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Macing, 100.0, 110.0);
            SetSkill(SkillName.Parry, 40.0, 50.0);
            SetSkill(SkillName.MagicResist, 80.0, 90.0);
            SetSkill(SkillName.Magery, 110.0, 120.0);

            Fame = 2500;
            Karma = -2500;
            VirtualArmor = 34;
        }

        public override string DefaultName => "a Titan";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluTormentedarchangel : BaseCreature
    {
        [Constructible]
        public ZuluTormentedarchangel() : base(AIType.AI_Melee)
        {
            Body = 4;
            Hue = 0x7B0;
            BaseSoundID = 0x46A;

            SetStr(1000);
            SetDex(800);
            SetInt(485);
            SetHits(5000);
            SetMana(285);
            SetStam(1000);

            SetDamage(25, 80);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.WaterProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.AirProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.NecroProtection, 100, 100);
            AddMobZuluModifier(ZuluMod.EarthProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 6, 6);

            SetSkill(SkillName.Tactics, 140.0, 150.0);
            SetSkill(SkillName.Swords, 165.0, 175.0);
            SetSkill(SkillName.Macing, 165.0, 175.0);
            SetSkill(SkillName.Fencing, 165.0, 175.0);
            SetSkill(SkillName.Wrestling, 165.0, 175.0);
            SetSkill(SkillName.Parry, 40.0, 50.0);
            SetSkill(SkillName.MagicResist, 140.0, 150.0);
            SetSkill(SkillName.DetectHidden, 115.0, 125.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 46;
        }

        public override string DefaultName => "The Tormented Archangel";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.FilthyRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluTorturedone : BaseCreature
    {
        [Constructible]
        public ZuluTorturedone() : base(AIType.AI_Melee)
        {
            Body = 400;
            Hue = 0x494;

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

        public override string DefaultName => "the tortured one";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluTroll1 : BaseCreature
    {
        [Constructible]
        public ZuluTroll1() : base(AIType.AI_Melee)
        {
            Body = 54;
            Hue = 0x83F8;

            SetStr(185);
            SetDex(70);
            SetInt(35);
            SetHits(185);
            SetMana(0);
            SetStam(50);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 80.0, 90.0);
            SetSkill(SkillName.Swords, 80.0, 90.0);
            SetSkill(SkillName.Parry, 40.0, 50.0);
            SetSkill(SkillName.MagicResist, 50.0, 60.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 28;
        }

        public override string DefaultName => "a troll";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluTroll2 : BaseCreature
    {
        [Constructible]
        public ZuluTroll2() : base(AIType.AI_Melee)
        {
            Body = 53;
            Hue = 0x83F8;

            SetStr(185);
            SetDex(70);
            SetInt(35);
            SetHits(185);
            SetMana(0);
            SetStam(50);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 80.0, 90.0);
            SetSkill(SkillName.Macing, 80.0, 90.0);
            SetSkill(SkillName.Parry, 40.0, 50.0);
            SetSkill(SkillName.MagicResist, 50.0, 60.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 28;
        }

        public override string DefaultName => "a troll warrior";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluTroll3 : BaseCreature
    {
        [Constructible]
        public ZuluTroll3() : base(AIType.AI_Melee)
        {
            Body = 55;
            Hue = 0x83F8;

            SetStr(185);
            SetDex(70);
            SetInt(35);
            SetHits(185);
            SetMana(0);
            SetStam(50);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 80.0, 90.0);
            SetSkill(SkillName.Swords, 50.0, 60.0);
            SetSkill(SkillName.Macing, 80.0, 90.0);
            SetSkill(SkillName.Parry, 50.0, 60.0);
            SetSkill(SkillName.MagicResist, 50.0, 60.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 32;
        }

        public override string DefaultName => "a troll smasher";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluTrollchief : BaseCreature
    {
        [Constructible]
        public ZuluTrollchief() : base(AIType.AI_Melee)
        {
            Body = 53;
            Hue = 0x465;

            SetStr(350);
            SetDex(220);
            SetInt(90);
            SetHits(500);
            SetMana(90);
            SetStam(220);

            SetDamage(12, 35);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 130.0, 140.0);
            SetSkill(SkillName.Swords, 150.0, 160.0);
            SetSkill(SkillName.MagicResist, 70.0, 80.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 16;
        }

        public override string DefaultName => "a troll chief";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluTrollking : BaseCreature
    {
        [Constructible]
        public ZuluTrollking() : base(AIType.AI_Melee)
        {
            Body = 53;
            Hue = 0x49F;

            SetStr(350);
            SetDex(220);
            SetInt(90);
            SetHits(350);
            SetMana(90);
            SetStam(220);

            SetDamage(12, 35);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 130.0, 140.0);
            SetSkill(SkillName.Swords, 150.0, 160.0);
            SetSkill(SkillName.MagicResist, 70.0, 80.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 16;
        }

        public override string DefaultName => "The King of the Trolls";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluTrollshaman : BaseCreature
    {
        [Constructible]
        public ZuluTrollshaman() : base(AIType.AI_Mage)
        {
            Body = 53;
            Hue = 0x220;

            SetStr(225);
            SetDex(170);
            SetInt(285);
            SetHits(225);
            SetMana(285);
            SetStam(225);

            SetDamage(8, 25);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 50.0, 60.0);
            SetSkill(SkillName.Macing, 80.0, 90.0);
            SetSkill(SkillName.MagicResist, 50.0, 60.0);
            SetSkill(SkillName.Magery, 80.0, 90.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 12;
        }

        public override string DefaultName => "a Troll Shaman";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluTwistedanimation : BaseCreature
    {
        [Constructible]
        public ZuluTwistedanimation() : base(AIType.AI_Melee)
        {
            Body = 581;
            Hue = 0xC100;
            BaseSoundID = 0x2B;

            SetStr(150);
            SetDex(200);
            SetInt(100);
            SetHits(1000);
            SetMana(0);
            SetStam(1200);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.NecroProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 3, 3);

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

        public override string DefaultName => "a twisted animation";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluUmbralflicker : BaseCreature
    {
        [Constructible]
        public ZuluUmbralflicker() : base(AIType.AI_Mage)
        {
            Body = 58;
            Hue = 0x6225;

            SetStr(450);
            SetDex(250);
            SetInt(2200);
            SetHits(700);
            SetMana(2200);
            SetStam(50);

            SetDamage(12, 35);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.FireProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.NecroProtection, 80, 80);
            AddMobZuluModifier(ZuluMod.EarthProtection, 40, 40);

            SetSkill(SkillName.Tactics, 110.0, 120.0);
            SetSkill(SkillName.Swords, 130.0, 140.0);
            SetSkill(SkillName.MagicResist, 120.0, 130.0);
            SetSkill(SkillName.Magery, 140.0, 150.0);
            SetSkill(SkillName.EvalInt, 140.0, 150.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 26;
        }

        public override string DefaultName => "an Umbral Flicker";
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluWatermaster : BaseCreature
    {
        [Constructible]
        public ZuluWatermaster() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x3EA;

            SetStr(300);
            SetDex(600);
            SetInt(3000);
            SetHits(2500);
            SetMana(10000);
            SetStam(10000);

            SetDamage(12, 35);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.WaterProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 4, 4);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 110.0, 120.0);
            SetSkill(SkillName.Magery, 140.0, 150.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 24;
        }

        public override string DefaultName => "watermaster, the water lord";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.FilthyRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluWitch1 : BaseCreature
    {
        [Constructible]
        public ZuluWitch1() : base(AIType.AI_Mage)
        {
            Body = 401;
            Hue = 0x3EA;

            SetStr(200);
            SetDex(90);
            SetInt(295);
            SetHits(80);
            SetMana(295);
            SetStam(50);

            SetDamage(8, 25);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 75.0, 85.0);
            SetSkill(SkillName.Macing, 75.0, 85.0);
            SetSkill(SkillName.MagicResist, 80.0, 90.0);
            SetSkill(SkillName.Magery, 90.0, 100.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 18;
        }

        public override string DefaultName => "witch1, the witch";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluWitch3 : BaseCreature
    {
        [Constructible]
        public ZuluWitch3() : base(AIType.AI_Mage)
        {
            Body = 401;
            Hue = 0x3EA;

            SetStr(200);
            SetDex(90);
            SetInt(295);
            SetHits(80);
            SetMana(295);
            SetStam(50);

            SetDamage(8, 25);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 75.0, 85.0);
            SetSkill(SkillName.Macing, 75.0, 85.0);
            SetSkill(SkillName.MagicResist, 80.0, 90.0);
            SetSkill(SkillName.Magery, 90.0, 100.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 18;
        }

        public override string DefaultName => "witch3, the witch";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluWitch4 : BaseCreature
    {
        [Constructible]
        public ZuluWitch4() : base(AIType.AI_Mage)
        {
            Body = 401;
            Hue = 0x3EA;

            SetStr(200);
            SetDex(90);
            SetInt(295);
            SetHits(80);
            SetMana(295);
            SetStam(50);

            SetDamage(8, 25);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 75.0, 85.0);
            SetSkill(SkillName.Macing, 75.0, 85.0);
            SetSkill(SkillName.MagicResist, 80.0, 90.0);
            SetSkill(SkillName.Magery, 90.0, 100.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 18;
        }

        public override string DefaultName => "witch4, the witch";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluWorshipmember : BaseCreature
    {
        [Constructible]
        public ZuluWorshipmember() : base(AIType.AI_Melee)
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

        public override string DefaultName => "worshipmember, member of the Worship";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluYomotsuelder : BaseCreature
    {
        [Constructible]
        public ZuluYomotsuelder() : base(AIType.AI_Mage)
        {
            Body = 255;
            BaseSoundID = 0x186;

            SetStr(750);
            SetDex(750);
            SetInt(500);
            SetHits(1500);
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

        public override string DefaultName => "The Yomotsu Elder";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluYomotsupriest : BaseCreature
    {
        [Constructible]
        public ZuluYomotsupriest() : base(AIType.AI_Mage)
        {
            Body = 253;
            BaseSoundID = 0x17E;

            SetStr(250);
            SetDex(100);
            SetInt(200);
            SetHits(800);
            SetMana(1000);
            SetStam(200);

            SetDamage(8, 25);
            z_Air_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.WaterProtection, 50, 50);
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

        public override string DefaultName => "a Yomotsu Priest";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluYomotsuwarrior : BaseCreature
    {
        [Constructible]
        public ZuluYomotsuwarrior() : base(AIType.AI_Melee)
        {
            Body = 245;

            SetStr(450);
            SetDex(650);
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

        public override string DefaultName => "a Yomotsu Warrior";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluZuluhunter : BaseCreature
    {
        [Constructible]
        public ZuluZuluhunter() : base(AIType.AI_Archer)
        {
            Body = 400;
            Hue = 0x44E;

            SetStr(130);
            SetDex(120);
            SetInt(35);
            SetHits(200);
            SetMana(25);
            SetStam(120);

            SetDamage(5, 15);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 100.0, 110.0);
            SetSkill(SkillName.Fencing, 100.0, 110.0);
            SetSkill(SkillName.MagicResist, 50.0, 60.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 12;

            EquipItem(new Shoes(0x5E4));
            EquipItem(new LongPants(0x59B));
            EquipItem(new Skirt(0x215));
            EquipItem(new StuddedChest());
            EquipItem(new FancyShirt(0x5E4));
        }

        public override string DefaultName => "a Zulu Hunter";

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }
}
