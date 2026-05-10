using ModernUO.Serialization;
using Server.Items;

namespace Server.Mobiles
{
    // Zulu Hotel — Brotherhood Evil NPCs
    // Auto-generated from npcdesc_zhbr.cfg (43 NPCs)
    // Source: POL 98 Zulu Hotel shard

    [SerializationGenerator(0, false)]
    public partial class ZuluBrotherhoodarachnid : BaseCreature
    {
        [Constructible]
        public ZuluBrotherhoodarachnid() : base(AIType.AI_Melee)
        {
            Body = 28;
            Hue = 0x498;
            BaseSoundID = 0x2C2;

            SetStr(500);
            SetDex(600);
            SetInt(100);
            SetHits(1000);
            SetMana(100);
            SetStam(600);

            SetDamage(18, 50);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.WaterProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.NecroProtection, 20, 20);
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
            SetSkill(SkillName.Poisoning, 100.0, 110.0);

            Fame = 35000;
            Karma = -35000;
            VirtualArmor = 56;
            MinTameSkill = 135;
        }

        public override string DefaultName => "a brotherhood arachnid";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBrotherhoodassassin1 : BaseCreature
    {
        [Constructible]
        public ZuluBrotherhoodassassin1() : base(AIType.AI_Melee)
        {
            Body = 400;
            Hue = 0x83F8;
            BaseSoundID = 0x15B;

            SetStr(400);
            SetDex(600);
            SetInt(100);
            SetHits(1500);
            SetMana(0);
            SetStam(1200);

            SetDamage(12, 35);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.WaterProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.AirProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 7, 7);

            SetSkill(SkillName.Tactics, 105.0, 115.0);
            SetSkill(SkillName.Anatomy, 105.0, 115.0);
            SetSkill(SkillName.Swords, 105.0, 115.0);
            SetSkill(SkillName.Macing, 105.0, 115.0);
            SetSkill(SkillName.Fencing, 105.0, 115.0);
            SetSkill(SkillName.Wrestling, 105.0, 115.0);
            SetSkill(SkillName.Parry, 100.0, 110.0);
            SetSkill(SkillName.MagicResist, 90.0, 100.0);
            SetSkill(SkillName.DetectHidden, 100.0, 110.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 56;
        }

        public override string DefaultName => "brotherhoodassassin1, the assassin brother";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBrotherhoodassassin2 : BaseCreature
    {
        [Constructible]
        public ZuluBrotherhoodassassin2() : base(AIType.AI_Melee)
        {
            Body = 400;
            Hue = 0x83F8;
            BaseSoundID = 0x15B;

            SetStr(400);
            SetDex(600);
            SetInt(100);
            SetHits(1500);
            SetMana(0);
            SetStam(1200);

            SetDamage(12, 35);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.WaterProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.AirProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 7, 7);

            SetSkill(SkillName.Tactics, 105.0, 115.0);
            SetSkill(SkillName.Anatomy, 105.0, 115.0);
            SetSkill(SkillName.Swords, 105.0, 115.0);
            SetSkill(SkillName.Macing, 105.0, 115.0);
            SetSkill(SkillName.Fencing, 105.0, 115.0);
            SetSkill(SkillName.Wrestling, 105.0, 115.0);
            SetSkill(SkillName.Parry, 100.0, 110.0);
            SetSkill(SkillName.MagicResist, 90.0, 100.0);
            SetSkill(SkillName.DetectHidden, 100.0, 110.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 56;
        }

        public override string DefaultName => "brotherhoodassassin2, the assassin brother";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBrotherhoodassassin3 : BaseCreature
    {
        [Constructible]
        public ZuluBrotherhoodassassin3() : base(AIType.AI_Melee)
        {
            Body = 400;
            Hue = 0x83F8;
            BaseSoundID = 0x15B;

            SetStr(400);
            SetDex(600);
            SetInt(100);
            SetHits(1500);
            SetMana(0);
            SetStam(1200);

            SetDamage(12, 35);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.WaterProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.AirProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 7, 7);

            SetSkill(SkillName.Tactics, 105.0, 115.0);
            SetSkill(SkillName.Anatomy, 105.0, 115.0);
            SetSkill(SkillName.Swords, 105.0, 115.0);
            SetSkill(SkillName.Macing, 105.0, 115.0);
            SetSkill(SkillName.Fencing, 105.0, 115.0);
            SetSkill(SkillName.Wrestling, 105.0, 115.0);
            SetSkill(SkillName.Parry, 100.0, 110.0);
            SetSkill(SkillName.MagicResist, 90.0, 100.0);
            SetSkill(SkillName.DetectHidden, 100.0, 110.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 56;
        }

        public override string DefaultName => "brotherhoodassassin3, the assassin brother";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBrotherhoodbrood : BaseCreature
    {
        [Constructible]
        public ZuluBrotherhoodbrood() : base(AIType.AI_Melee)
        {
            Body = 80;
            Hue = 0x498;
            BaseSoundID = 0x2C2;

            SetStr(500);
            SetDex(600);
            SetInt(100);
            SetHits(1000);
            SetMana(100);
            SetStam(600);

            SetDamage(18, 50);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.WaterProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.AirProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.EarthProtection, 20, 20);
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
            MinTameSkill = 130;
        }

        public override string DefaultName => "a brotherhood brood";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBrotherhoodcaretaker : BaseCreature
    {
        [Constructible]
        public ZuluBrotherhoodcaretaker() : base(AIType.AI_Melee)
        {
            Body = 400;
            Hue = 0x83F8;
            BaseSoundID = 0x15B;

            SetStr(250);
            SetDex(600);
            SetInt(75);
            SetHits(1500);
            SetMana(0);
            SetStam(1200);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.WaterProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.AirProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 5, 5);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Anatomy, 90.0, 100.0);
            SetSkill(SkillName.Swords, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.Fencing, 90.0, 100.0);
            SetSkill(SkillName.Wrestling, 90.0, 100.0);
            SetSkill(SkillName.Parry, 80.0, 90.0);
            SetSkill(SkillName.MagicResist, 90.0, 100.0);
            SetSkill(SkillName.DetectHidden, 90.0, 100.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 50;
        }

        public override string DefaultName => "brotherhoodcaretaker, the Dragon caretaker";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBrotherhoodelite1 : BaseCreature
    {
        [Constructible]
        public ZuluBrotherhoodelite1() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x83F8;
            BaseSoundID = 0x424;

            SetStr(700);
            SetDex(600);
            SetInt(400);
            SetHits(2000);
            SetMana(1500);
            SetStam(600);

            SetDamage(18, 50);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.WaterProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.AirProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.NecroProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 4, 4);

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

        public override string DefaultName => "brotherhoodelite1, the elite brother";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBrotherhoodelite2 : BaseCreature
    {
        [Constructible]
        public ZuluBrotherhoodelite2() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x83F8;
            BaseSoundID = 0x424;

            SetStr(700);
            SetDex(600);
            SetInt(400);
            SetHits(2000);
            SetMana(1500);
            SetStam(600);

            SetDamage(18, 50);
            z_Air_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.WaterProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.AirProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.NecroProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 4, 4);

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

        public override string DefaultName => "brotherhoodelite2, the elite brother";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBrotherhoodelite3 : BaseCreature
    {
        [Constructible]
        public ZuluBrotherhoodelite3() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x83F8;
            BaseSoundID = 0x424;

            SetStr(700);
            SetDex(600);
            SetInt(400);
            SetHits(2000);
            SetMana(1500);
            SetStam(600);

            SetDamage(18, 50);
            z_Air_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.WaterProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.AirProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.NecroProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 4, 4);

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

        public override string DefaultName => "brotherhoodelite3, the elite brother";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBrotherhoodelite4 : BaseCreature
    {
        [Constructible]
        public ZuluBrotherhoodelite4() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x83F8;
            BaseSoundID = 0x424;

            SetStr(700);
            SetDex(600);
            SetInt(400);
            SetHits(2000);
            SetMana(1500);
            SetStam(600);

            SetDamage(18, 50);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.WaterProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.AirProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.NecroProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 4, 4);

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

        public override string DefaultName => "brotherhoodelite4, the elite brother";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBrotherhoodelite5 : BaseCreature
    {
        [Constructible]
        public ZuluBrotherhoodelite5() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x83F8;
            BaseSoundID = 0x424;

            SetStr(700);
            SetDex(600);
            SetInt(400);
            SetHits(2000);
            SetMana(1500);
            SetStam(600);

            SetDamage(18, 50);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.WaterProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.AirProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.NecroProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 4, 4);

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

        public override string DefaultName => "brotherhoodelite5, the elite brother";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBrotherhoodexperiment : BaseCreature
    {
        [Constructible]
        public ZuluBrotherhoodexperiment() : base(AIType.AI_Mage)
        {
            Body = 259;
            Hue = 0x484;
            BaseSoundID = 0x1DC;

            SetStr(1000);
            SetDex(1000);
            SetInt(200);
            SetHits(3000);
            SetMana(0);
            SetStam(2000);

            SetDamage(25, 80);
            z_Fire_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.WaterProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.AirProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.NecroProtection, 40, 40);
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

        public override string DefaultName => "a brotherhood experiment";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBrotherhoodmaster1 : BaseCreature
    {
        [Constructible]
        public ZuluBrotherhoodmaster1() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x3EA;
            BaseSoundID = 0x2BD;

            SetStr(100);
            SetDex(1000);
            SetInt(6000);
            SetHits(3000);
            SetMana(20000);
            SetStam(20000);

            SetDamage(5, 15);
            z_Air_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.WaterProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.AirProtection, 40, 40);
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

        public override string DefaultName => "brotherhoodmaster1, the master brother";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBrotherhoodmaster2 : BaseCreature
    {
        [Constructible]
        public ZuluBrotherhoodmaster2() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x3EA;
            BaseSoundID = 0x2BD;

            SetStr(100);
            SetDex(1000);
            SetInt(6000);
            SetHits(3500);
            SetMana(20000);
            SetStam(20000);

            SetDamage(5, 15);
            z_Air_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.WaterProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.AirProtection, 40, 40);
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

        public override string DefaultName => "brotherhoodmaster2, the master brother";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBrotherhoodmaster3 : BaseCreature
    {
        [Constructible]
        public ZuluBrotherhoodmaster3() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x3EA;
            BaseSoundID = 0x2BD;

            SetStr(100);
            SetDex(1000);
            SetInt(6000);
            SetHits(3500);
            SetMana(20000);
            SetStam(20000);

            SetDamage(5, 15);
            z_Air_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.WaterProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.AirProtection, 40, 40);
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

        public override string DefaultName => "brotherhoodmaster3, the master brother";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBrotherhoodmaster4 : BaseCreature
    {
        [Constructible]
        public ZuluBrotherhoodmaster4() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x3EA;
            BaseSoundID = 0x2BD;

            SetStr(100);
            SetDex(1000);
            SetInt(6000);
            SetHits(3000);
            SetMana(20000);
            SetStam(20000);

            SetDamage(5, 15);
            z_Air_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.WaterProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.AirProtection, 40, 40);
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

        public override string DefaultName => "brotherhoodmaster4, the master brother";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBrotherhoodmaster5 : BaseCreature
    {
        [Constructible]
        public ZuluBrotherhoodmaster5() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x3EA;
            BaseSoundID = 0x2BD;

            SetStr(100);
            SetDex(1000);
            SetInt(6000);
            SetHits(3000);
            SetMana(20000);
            SetStam(20000);

            SetDamage(5, 15);
            z_Air_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 50, 50);
            AddMobZuluModifier(ZuluMod.FireProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.WaterProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.AirProtection, 40, 40);
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

        public override string DefaultName => "brotherhoodmaster5, the master brother";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBrotherhoodmember1 : BaseCreature
    {
        [Constructible]
        public ZuluBrotherhoodmember1() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x83F8;
            BaseSoundID = 0x424;

            SetStr(200);
            SetDex(100);
            SetInt(200);
            SetHits(400);
            SetMana(1000);
            SetStam(200);

            SetDamage(8, 25);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.WaterProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.AirProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
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
            SetSkill(SkillName.Magery, 100.0, 110.0);
            SetSkill(SkillName.EvalInt, 90.0, 100.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 64;
        }

        public override string DefaultName => "brotherhoodmember1, the novice brother";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.FilthyRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBrotherhoodmember2 : BaseCreature
    {
        [Constructible]
        public ZuluBrotherhoodmember2() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x83F8;
            BaseSoundID = 0x425;

            SetStr(200);
            SetDex(100);
            SetInt(200);
            SetHits(400);
            SetMana(1000);
            SetStam(200);

            SetDamage(8, 25);
            z_Air_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.WaterProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.AirProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
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
            SetSkill(SkillName.Magery, 100.0, 110.0);
            SetSkill(SkillName.EvalInt, 90.0, 100.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 64;
        }

        public override string DefaultName => "brotherhoodmember2, the novice brother";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.FilthyRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBrotherhoodmember3 : BaseCreature
    {
        [Constructible]
        public ZuluBrotherhoodmember3() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x83F8;
            BaseSoundID = 0x426;

            SetStr(200);
            SetDex(100);
            SetInt(200);
            SetHits(400);
            SetMana(1000);
            SetStam(200);

            SetDamage(8, 25);
            z_Air_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.WaterProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.AirProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
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
            SetSkill(SkillName.Magery, 100.0, 110.0);
            SetSkill(SkillName.EvalInt, 90.0, 100.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 64;
        }

        public override string DefaultName => "brotherhoodmember3, the novice brother";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.FilthyRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBrotherhoodmember4 : BaseCreature
    {
        [Constructible]
        public ZuluBrotherhoodmember4() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x83F8;
            BaseSoundID = 0x427;

            SetStr(200);
            SetDex(100);
            SetInt(200);
            SetHits(400);
            SetMana(1000);
            SetStam(200);

            SetDamage(8, 25);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.WaterProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.AirProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
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
            SetSkill(SkillName.Magery, 100.0, 110.0);
            SetSkill(SkillName.EvalInt, 90.0, 100.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 64;
        }

        public override string DefaultName => "brotherhoodmember4, the novice brother";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.FilthyRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBrotherhoodmember5 : BaseCreature
    {
        [Constructible]
        public ZuluBrotherhoodmember5() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x83F8;
            BaseSoundID = 0x428;

            SetStr(200);
            SetDex(100);
            SetInt(200);
            SetHits(400);
            SetMana(1000);
            SetStam(200);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.WaterProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.AirProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
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
            SetSkill(SkillName.Magery, 100.0, 110.0);
            SetSkill(SkillName.EvalInt, 90.0, 100.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 64;
        }

        public override string DefaultName => "brotherhoodmember5, the novice brother";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.FilthyRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBrotherhoodnecromancer : BaseCreature
    {
        [Constructible]
        public ZuluBrotherhoodnecromancer() : base(AIType.AI_Mage)
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

        public override string DefaultName => "brotherhoodnecromancer, the Brotherhood Necromancer";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBrotherhoodpet : BaseCreature
    {
        [Constructible]
        public ZuluBrotherhoodpet() : base(AIType.AI_Mage)
        {
            Body = 39;
            Hue = 0x48D;
            BaseSoundID = 0x1AB;

            SetStr(75);
            SetDex(600);
            SetInt(150);
            SetHits(75);
            SetMana(150);
            SetStam(600);

            SetDamage(5, 15);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.WaterProtection, 30, 30);

            SetSkill(SkillName.Tactics, 65.0, 75.0);
            SetSkill(SkillName.Anatomy, 65.0, 75.0);
            SetSkill(SkillName.Swords, 65.0, 75.0);
            SetSkill(SkillName.Macing, 65.0, 75.0);
            SetSkill(SkillName.Fencing, 65.0, 75.0);
            SetSkill(SkillName.Wrestling, 65.0, 75.0);
            SetSkill(SkillName.Parry, 40.0, 50.0);
            SetSkill(SkillName.MagicResist, 90.0, 100.0);
            SetSkill(SkillName.DetectHidden, 40.0, 50.0);
            SetSkill(SkillName.Magery, 60.0, 70.0);
            SetSkill(SkillName.EvalInt, 70.0, 80.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 36;
            MinTameSkill = 85;
        }

        public override string DefaultName => "a brotherhood pet";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBrotherhoodritualist : BaseCreature
    {
        [Constructible]
        public ZuluBrotherhoodritualist() : base(AIType.AI_Mage)
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

        public override string DefaultName => "brotherhoodritualist, the brotherhood ritualist";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBrotherhoodscientist1 : BaseCreature
    {
        [Constructible]
        public ZuluBrotherhoodscientist1() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x3EA;
            BaseSoundID = 0x2BD;

            SetStr(1000);
            SetDex(1000);
            SetInt(10000);
            SetHits(7500);
            SetMana(10000);
            SetStam(10000);

            SetDamage(25, 80);
            z_Air_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.WaterProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.AirProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.NecroProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 8, 8);

            SetSkill(SkillName.Tactics, 115.0, 125.0);
            SetSkill(SkillName.Anatomy, 115.0, 125.0);
            SetSkill(SkillName.Swords, 115.0, 125.0);
            SetSkill(SkillName.Macing, 115.0, 125.0);
            SetSkill(SkillName.Fencing, 115.0, 125.0);
            SetSkill(SkillName.Wrestling, 115.0, 125.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 120.0, 130.0);
            SetSkill(SkillName.DetectHidden, 110.0, 120.0);
            SetSkill(SkillName.Magery, 190.0, 200.0);
            SetSkill(SkillName.EvalInt, 190.0, 200.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 59;
        }

        public override string DefaultName => "brotherhoodscientist1, the scientist brother";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBrotherhoodscientist2 : BaseCreature
    {
        [Constructible]
        public ZuluBrotherhoodscientist2() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x3EA;
            BaseSoundID = 0x2BD;

            SetStr(1000);
            SetDex(1000);
            SetInt(10000);
            SetHits(7500);
            SetMana(10000);
            SetStam(10000);

            SetDamage(25, 80);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.WaterProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.AirProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.NecroProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 8, 8);

            SetSkill(SkillName.Tactics, 115.0, 125.0);
            SetSkill(SkillName.Anatomy, 115.0, 125.0);
            SetSkill(SkillName.Swords, 115.0, 125.0);
            SetSkill(SkillName.Macing, 115.0, 125.0);
            SetSkill(SkillName.Fencing, 115.0, 125.0);
            SetSkill(SkillName.Wrestling, 115.0, 125.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 120.0, 130.0);
            SetSkill(SkillName.DetectHidden, 110.0, 120.0);
            SetSkill(SkillName.Magery, 190.0, 200.0);
            SetSkill(SkillName.EvalInt, 190.0, 200.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 59;
        }

        public override string DefaultName => "brotherhoodscientist2, the scientist brother";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBrotherhoodscientist3 : BaseCreature
    {
        [Constructible]
        public ZuluBrotherhoodscientist3() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x3EA;
            BaseSoundID = 0x2BD;

            SetStr(1000);
            SetDex(1000);
            SetInt(10000);
            SetHits(7500);
            SetMana(10000);
            SetStam(10000);

            SetDamage(25, 80);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.WaterProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.AirProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.NecroProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 8, 8);

            SetSkill(SkillName.Tactics, 115.0, 125.0);
            SetSkill(SkillName.Anatomy, 115.0, 125.0);
            SetSkill(SkillName.Swords, 115.0, 125.0);
            SetSkill(SkillName.Macing, 115.0, 125.0);
            SetSkill(SkillName.Fencing, 115.0, 125.0);
            SetSkill(SkillName.Wrestling, 115.0, 125.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 120.0, 130.0);
            SetSkill(SkillName.DetectHidden, 110.0, 120.0);
            SetSkill(SkillName.Magery, 190.0, 200.0);
            SetSkill(SkillName.EvalInt, 190.0, 200.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 59;
        }

        public override string DefaultName => "brotherhoodscientist3, the scientist brother";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBrotherhoodscientist4 : BaseCreature
    {
        [Constructible]
        public ZuluBrotherhoodscientist4() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x3EA;
            BaseSoundID = 0x2BD;

            SetStr(1000);
            SetDex(1000);
            SetInt(10000);
            SetHits(7500);
            SetMana(10000);
            SetStam(10000);

            SetDamage(25, 80);
            z_Air_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.WaterProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.AirProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.NecroProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 8, 8);

            SetSkill(SkillName.Tactics, 115.0, 125.0);
            SetSkill(SkillName.Anatomy, 115.0, 125.0);
            SetSkill(SkillName.Swords, 115.0, 125.0);
            SetSkill(SkillName.Macing, 115.0, 125.0);
            SetSkill(SkillName.Fencing, 115.0, 125.0);
            SetSkill(SkillName.Wrestling, 115.0, 125.0);
            SetSkill(SkillName.Parry, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 120.0, 130.0);
            SetSkill(SkillName.DetectHidden, 110.0, 120.0);
            SetSkill(SkillName.Magery, 190.0, 200.0);
            SetSkill(SkillName.EvalInt, 190.0, 200.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 59;
        }

        public override string DefaultName => "brotherhoodscientist4, the scientist brother";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBrotherhoodscout : BaseCreature
    {
        [Constructible]
        public ZuluBrotherhoodscout() : base(AIType.AI_Archer)
        {
            Body = 400;
            Hue = 0x3EA;
            BaseSoundID = 0x424;

            SetStr(300);
            SetDex(600);
            SetInt(60);
            SetHits(300);
            SetMana(0);
            SetStam(600);

            SetDamage(12, 35);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.WaterProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.AirProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 3, 3);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Anatomy, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 90.0, 100.0);
            SetSkill(SkillName.DetectHidden, 90.0, 100.0);
            SetSkill(SkillName.Archery, 90.0, 100.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 20;
        }

        public override string DefaultName => "brotherhoodscout, the scout brother";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.FilthyRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBrotherhoodshaman : BaseCreature
    {
        [Constructible]
        public ZuluBrotherhoodshaman() : base(AIType.AI_Mage)
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

        public override string DefaultName => "brotherhoodshaman, the Brotherhood Shaman";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBrotherhoodsoldier1 : BaseCreature
    {
        [Constructible]
        public ZuluBrotherhoodsoldier1() : base(AIType.AI_Melee)
        {
            Body = 400;
            Hue = 0x83F8;
            BaseSoundID = 0x15B;

            SetStr(250);
            SetDex(600);
            SetInt(75);
            SetHits(800);
            SetMana(0);
            SetStam(1200);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.WaterProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.AirProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 5, 5);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Anatomy, 90.0, 100.0);
            SetSkill(SkillName.Swords, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.Fencing, 90.0, 100.0);
            SetSkill(SkillName.Wrestling, 90.0, 100.0);
            SetSkill(SkillName.Parry, 80.0, 90.0);
            SetSkill(SkillName.MagicResist, 90.0, 100.0);
            SetSkill(SkillName.DetectHidden, 90.0, 100.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 50;
        }

        public override string DefaultName => "brotherhoodsoldier1, the soldier brother";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBrotherhoodsoldier2 : BaseCreature
    {
        [Constructible]
        public ZuluBrotherhoodsoldier2() : base(AIType.AI_Melee)
        {
            Body = 400;
            Hue = 0x83F8;
            BaseSoundID = 0x15B;

            SetStr(250);
            SetDex(600);
            SetInt(75);
            SetHits(800);
            SetMana(0);
            SetStam(1200);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.WaterProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.AirProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 5, 5);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Anatomy, 90.0, 100.0);
            SetSkill(SkillName.Swords, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.Fencing, 90.0, 100.0);
            SetSkill(SkillName.Wrestling, 90.0, 100.0);
            SetSkill(SkillName.Parry, 80.0, 90.0);
            SetSkill(SkillName.MagicResist, 90.0, 100.0);
            SetSkill(SkillName.DetectHidden, 90.0, 100.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 50;
        }

        public override string DefaultName => "brotherhoodsoldier2, the soldier brother";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBrotherhoodsoldier3 : BaseCreature
    {
        [Constructible]
        public ZuluBrotherhoodsoldier3() : base(AIType.AI_Melee)
        {
            Body = 400;
            Hue = 0x83F8;
            BaseSoundID = 0x15B;

            SetStr(250);
            SetDex(600);
            SetInt(75);
            SetHits(800);
            SetMana(0);
            SetStam(1200);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.WaterProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.AirProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 5, 5);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Anatomy, 90.0, 100.0);
            SetSkill(SkillName.Swords, 90.0, 100.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.Fencing, 90.0, 100.0);
            SetSkill(SkillName.Wrestling, 90.0, 100.0);
            SetSkill(SkillName.Parry, 80.0, 90.0);
            SetSkill(SkillName.MagicResist, 90.0, 100.0);
            SetSkill(SkillName.DetectHidden, 90.0, 100.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 50;
        }

        public override string DefaultName => "brotherhoodsoldier3, the soldier brother";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBrotherhoodsummoner : BaseCreature
    {
        [Constructible]
        public ZuluBrotherhoodsummoner() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x83F8;
            BaseSoundID = 0x424;

            SetStr(450);
            SetDex(600);
            SetInt(350);
            SetHits(1500);
            SetMana(1000);
            SetStam(600);

            SetDamage(12, 35);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.WaterProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.AirProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.NecroProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 3, 3);

            SetSkill(SkillName.Tactics, 100.0, 110.0);
            SetSkill(SkillName.Anatomy, 100.0, 110.0);
            SetSkill(SkillName.Swords, 100.0, 110.0);
            SetSkill(SkillName.Macing, 100.0, 110.0);
            SetSkill(SkillName.Fencing, 100.0, 110.0);
            SetSkill(SkillName.Wrestling, 100.0, 110.0);
            SetSkill(SkillName.Parry, 110.0, 120.0);
            SetSkill(SkillName.MagicResist, 110.0, 120.0);
            SetSkill(SkillName.DetectHidden, 80.0, 90.0);
            SetSkill(SkillName.Magery, 105.0, 115.0);
            SetSkill(SkillName.EvalInt, 105.0, 115.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 64;
        }

        public override string DefaultName => "brotherhoodsummoner, the summoner brother";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBrotherhoodveteran1 : BaseCreature
    {
        [Constructible]
        public ZuluBrotherhoodveteran1() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x83F8;
            BaseSoundID = 0x424;

            SetStr(350);
            SetDex(600);
            SetInt(350);
            SetHits(500);
            SetMana(1000);
            SetStam(600);

            SetDamage(12, 35);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.WaterProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.AirProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 3, 3);

            SetSkill(SkillName.Tactics, 100.0, 110.0);
            SetSkill(SkillName.Anatomy, 100.0, 110.0);
            SetSkill(SkillName.Swords, 100.0, 110.0);
            SetSkill(SkillName.Macing, 100.0, 110.0);
            SetSkill(SkillName.Fencing, 100.0, 110.0);
            SetSkill(SkillName.Wrestling, 100.0, 110.0);
            SetSkill(SkillName.Parry, 110.0, 120.0);
            SetSkill(SkillName.MagicResist, 110.0, 120.0);
            SetSkill(SkillName.DetectHidden, 80.0, 90.0);
            SetSkill(SkillName.Magery, 105.0, 115.0);
            SetSkill(SkillName.EvalInt, 105.0, 115.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 64;
        }

        public override string DefaultName => "brotherhoodveteran1, the veteran brother";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBrotherhoodveteran2 : BaseCreature
    {
        [Constructible]
        public ZuluBrotherhoodveteran2() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x83F8;
            BaseSoundID = 0x425;

            SetStr(350);
            SetDex(600);
            SetInt(350);
            SetHits(500);
            SetMana(1000);
            SetStam(600);

            SetDamage(12, 35);
            z_Air_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.WaterProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.AirProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 3, 3);

            SetSkill(SkillName.Tactics, 100.0, 110.0);
            SetSkill(SkillName.Anatomy, 100.0, 110.0);
            SetSkill(SkillName.Swords, 100.0, 110.0);
            SetSkill(SkillName.Macing, 100.0, 110.0);
            SetSkill(SkillName.Fencing, 100.0, 110.0);
            SetSkill(SkillName.Wrestling, 100.0, 110.0);
            SetSkill(SkillName.Parry, 110.0, 120.0);
            SetSkill(SkillName.MagicResist, 110.0, 120.0);
            SetSkill(SkillName.DetectHidden, 80.0, 90.0);
            SetSkill(SkillName.Magery, 105.0, 115.0);
            SetSkill(SkillName.EvalInt, 105.0, 115.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 64;
        }

        public override string DefaultName => "brotherhoodveteran2, the veteran brother";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBrotherhoodveteran3 : BaseCreature
    {
        [Constructible]
        public ZuluBrotherhoodveteran3() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x83F8;
            BaseSoundID = 0x426;

            SetStr(350);
            SetDex(600);
            SetInt(350);
            SetHits(500);
            SetMana(1000);
            SetStam(600);

            SetDamage(12, 35);
            z_Air_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.WaterProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.AirProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 3, 3);

            SetSkill(SkillName.Tactics, 100.0, 110.0);
            SetSkill(SkillName.Anatomy, 100.0, 110.0);
            SetSkill(SkillName.Swords, 100.0, 110.0);
            SetSkill(SkillName.Macing, 100.0, 110.0);
            SetSkill(SkillName.Fencing, 100.0, 110.0);
            SetSkill(SkillName.Wrestling, 100.0, 110.0);
            SetSkill(SkillName.Parry, 110.0, 120.0);
            SetSkill(SkillName.MagicResist, 110.0, 120.0);
            SetSkill(SkillName.DetectHidden, 80.0, 90.0);
            SetSkill(SkillName.Magery, 105.0, 115.0);
            SetSkill(SkillName.EvalInt, 105.0, 115.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 64;
        }

        public override string DefaultName => "brotherhoodveteran3, the veteran brother";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBrotherhoodveteran4 : BaseCreature
    {
        [Constructible]
        public ZuluBrotherhoodveteran4() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x83F8;
            BaseSoundID = 0x427;

            SetStr(350);
            SetDex(600);
            SetInt(350);
            SetHits(500);
            SetMana(1000);
            SetStam(600);

            SetDamage(12, 35);
            z_Fire_DD = 50;
            z_Air_DD = 50;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.WaterProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.AirProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 3, 3);

            SetSkill(SkillName.Tactics, 100.0, 110.0);
            SetSkill(SkillName.Anatomy, 100.0, 110.0);
            SetSkill(SkillName.Swords, 100.0, 110.0);
            SetSkill(SkillName.Macing, 100.0, 110.0);
            SetSkill(SkillName.Fencing, 100.0, 110.0);
            SetSkill(SkillName.Wrestling, 100.0, 110.0);
            SetSkill(SkillName.Parry, 110.0, 120.0);
            SetSkill(SkillName.MagicResist, 110.0, 120.0);
            SetSkill(SkillName.DetectHidden, 80.0, 90.0);
            SetSkill(SkillName.Magery, 105.0, 115.0);
            SetSkill(SkillName.EvalInt, 105.0, 115.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 64;
        }

        public override string DefaultName => "brotherhoodveteran4, the veteran brother";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBrotherhoodveteran5 : BaseCreature
    {
        [Constructible]
        public ZuluBrotherhoodveteran5() : base(AIType.AI_Mage)
        {
            Body = 400;
            Hue = 0x83F8;
            BaseSoundID = 0x428;

            SetStr(350);
            SetDex(600);
            SetInt(350);
            SetHits(500);
            SetMana(1000);
            SetStam(600);

            SetDamage(12, 35);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 60, 60);
            AddMobZuluModifier(ZuluMod.WaterProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.AirProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 3, 3);

            SetSkill(SkillName.Tactics, 100.0, 110.0);
            SetSkill(SkillName.Anatomy, 100.0, 110.0);
            SetSkill(SkillName.Swords, 100.0, 110.0);
            SetSkill(SkillName.Macing, 100.0, 110.0);
            SetSkill(SkillName.Fencing, 100.0, 110.0);
            SetSkill(SkillName.Wrestling, 100.0, 110.0);
            SetSkill(SkillName.Parry, 110.0, 120.0);
            SetSkill(SkillName.MagicResist, 110.0, 120.0);
            SetSkill(SkillName.DetectHidden, 80.0, 90.0);
            SetSkill(SkillName.Magery, 105.0, 115.0);
            SetSkill(SkillName.EvalInt, 105.0, 115.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 64;
        }

        public override string DefaultName => "brotherhoodveteran5, the veteran brother";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBrotherhoodwarrior1 : BaseCreature
    {
        [Constructible]
        public ZuluBrotherhoodwarrior1() : base(AIType.AI_Melee)
        {
            Body = 400;
            Hue = 0x83F8;
            BaseSoundID = 0x15B;

            SetStr(200);
            SetDex(600);
            SetInt(75);
            SetHits(350);
            SetMana(0);
            SetStam(1200);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.WaterProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.AirProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 3, 3);

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

        public override string DefaultName => "brotherhoodwarrior1, the warrior brother";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.FilthyRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBrotherhoodwarrior2 : BaseCreature
    {
        [Constructible]
        public ZuluBrotherhoodwarrior2() : base(AIType.AI_Melee)
        {
            Body = 400;
            Hue = 0x83F8;
            BaseSoundID = 0x15B;

            SetStr(200);
            SetDex(600);
            SetInt(75);
            SetHits(350);
            SetMana(0);
            SetStam(1200);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.WaterProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.AirProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 3, 3);

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

        public override string DefaultName => "brotherhoodwarrior2, the warrior brother";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.FilthyRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluBrotherhoodwarrior3 : BaseCreature
    {
        [Constructible]
        public ZuluBrotherhoodwarrior3() : base(AIType.AI_Melee)
        {
            Body = 400;
            Hue = 0x83F8;
            BaseSoundID = 0x15B;

            SetStr(150);
            SetDex(600);
            SetInt(75);
            SetHits(350);
            SetMana(0);
            SetStam(1200);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.WaterProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.AirProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.HollyProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 3, 3);

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

        public override string DefaultName => "brotherhoodwarrior3, the warrior brother";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.FilthyRich);
        }
    }
}
