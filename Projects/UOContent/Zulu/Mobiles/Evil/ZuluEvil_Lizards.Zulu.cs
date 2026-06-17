using ModernUO.Serialization;
using Server.Items;

namespace Server.Mobiles
{
    // Zulu Hotel — Lizards Evil NPCs
    // Auto-generated from npcdesc_zhbr.cfg (13 NPCs)
    // Source: POL 98 Zulu Hotel shard

    [SerializationGenerator(0, false)]
    public partial class ZuluForestlizard : BaseCreature
    {
        [Constructible]
        public ZuluForestlizard() : base(AIType.AI_Melee)
        {
            Body = 206;
            Hue = 0x499;
            BaseSoundID = 0x28E;

            SetStr(250);
            SetDex(140);
            SetInt(50);
            SetHits(250);
            SetMana(50);
            SetStam(600);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

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
            MinTameSkill = 90;
        }

        public override string DefaultName => "a forest lizard";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluLizardman : BaseCreature
    {
        [Constructible]
        public ZuluLizardman() : base(AIType.AI_Melee)
        {
            Body = 33;
            BaseSoundID = 0x1A6;

            SetStr(170);
            SetDex(100);
            SetInt(35);
            SetHits(300);
            SetMana(35);
            SetStam(90);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 60.0, 70.0);
            SetSkill(SkillName.Swords, 65.0, 75.0);
            SetSkill(SkillName.Parry, 55.0, 65.0);
            SetSkill(SkillName.MagicResist, 20.0, 30.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 27;
        }

        public override string DefaultName => "lizardman, the Lizardman";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluLizardman2 : BaseCreature
    {
        [Constructible]
        public ZuluLizardman2() : base(AIType.AI_Melee)
        {
            Body = 35;
            BaseSoundID = 0x1A6;

            SetStr(170);
            SetDex(100);
            SetInt(35);
            SetHits(300);
            SetMana(35);
            SetStam(90);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 60.0, 70.0);
            SetSkill(SkillName.Macing, 65.0, 75.0);
            SetSkill(SkillName.Parry, 55.0, 65.0);
            SetSkill(SkillName.MagicResist, 20.0, 30.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 27;
        }

        public override string DefaultName => "lizardman2, the Warrior";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluLizardman3 : BaseCreature
    {
        [Constructible]
        public ZuluLizardman3() : base(AIType.AI_Melee)
        {
            Body = 36;
            BaseSoundID = 0x1A6;

            SetStr(190);
            SetDex(95);
            SetInt(40);
            SetHits(300);
            SetMana(40);
            SetStam(95);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 70.0, 80.0);
            SetSkill(SkillName.Macing, 85.0, 95.0);
            SetSkill(SkillName.MagicResist, 50.0, 60.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 12;
        }

        public override string DefaultName => "lizardman3, the Warrior";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluLizardmanalchemist : BaseCreature
    {
        [Constructible]
        public ZuluLizardmanalchemist() : base(AIType.AI_Mage)
        {
            Body = 33;
            Hue = 0x48A;
            BaseSoundID = 0x1A6;

            SetStr(185);
            SetDex(105);
            SetInt(45);
            SetHits(185);
            SetMana(45);
            SetStam(105);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 65.0, 75.0);
            SetSkill(SkillName.Macing, 65.0, 75.0);
            SetSkill(SkillName.MagicResist, 40.0, 50.0);
            SetSkill(SkillName.Archery, 110.0, 120.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 10;
        }

        public override string DefaultName => "lizardmanalchemist, the Alchemist";

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluLizardmanchef : BaseCreature
    {
        [Constructible]
        public ZuluLizardmanchef() : base(AIType.AI_Melee)
        {
            Body = 33;
            Hue = 0x495;
            BaseSoundID = 0x1A6;

            SetStr(250);
            SetDex(140);
            SetInt(35);
            SetHits(400);
            SetMana(35);
            SetStam(90);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 60.0, 70.0);
            SetSkill(SkillName.Swords, 65.0, 75.0);
            SetSkill(SkillName.Parry, 55.0, 65.0);
            SetSkill(SkillName.MagicResist, 20.0, 30.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 27;
        }

        public override string DefaultName => "lizardmanchef, the Lizardman Chef";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluLizardmanking : BaseCreature
    {
        [Constructible]
        public ZuluLizardmanking() : base(AIType.AI_Melee)
        {
            Body = 33;
            Hue = 0x488;
            BaseSoundID = 0x1A6;

            SetStr(300);
            SetDex(200);
            SetInt(75);
            SetHits(300);
            SetMana(75);
            SetStam(200);

            SetDamage(12, 35);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 1, 1);

            SetSkill(SkillName.Tactics, 110.0, 120.0);
            SetSkill(SkillName.Macing, 90.0, 100.0);
            SetSkill(SkillName.MagicResist, 70.0, 80.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 16;
        }

        public override string DefaultName => "King lizardmanking";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluLizardmanshaman : BaseCreature
    {
        [Constructible]
        public ZuluLizardmanshaman() : base(AIType.AI_Mage)
        {
            Body = 33;
            Hue = 0x496;
            BaseSoundID = 0x1A6;

            SetStr(170);
            SetDex(110);
            SetInt(280);
            SetHits(250);
            SetMana(300);
            SetStam(100);

            SetDamage(8, 25);
            z_Air_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 70.0, 80.0);
            SetSkill(SkillName.Macing, 65.0, 75.0);
            SetSkill(SkillName.MagicResist, 80.0, 90.0);
            SetSkill(SkillName.Magery, 100.0, 110.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 18;
        }

        public override string DefaultName => "lizardmanshaman, the Shaman";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluRatman1 : BaseCreature
    {
        [Constructible]
        public ZuluRatman1() : base(AIType.AI_Melee)
        {
            Body = 42;

            SetStr(80);
            SetDex(90);
            SetInt(35);
            SetHits(80);
            SetMana(0);
            SetStam(50);

            SetDamage(5, 15);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 20, 20);

            SetSkill(SkillName.Tactics, 50.0, 60.0);
            SetSkill(SkillName.Swords, 55.0, 65.0);
            SetSkill(SkillName.Parry, 50.0, 60.0);
            SetSkill(SkillName.MagicResist, 10.0, 20.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 24;
        }

        public override string DefaultName => "ratman1, the Ratman";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluRatman2 : BaseCreature
    {
        [Constructible]
        public ZuluRatman2() : base(AIType.AI_Melee)
        {
            Body = 44;

            SetStr(80);
            SetDex(90);
            SetInt(35);
            SetHits(80);
            SetMana(0);
            SetStam(50);

            SetDamage(5, 15);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 20, 20);

            SetSkill(SkillName.Tactics, 40.0, 50.0);
            SetSkill(SkillName.Swords, 55.0, 65.0);
            SetSkill(SkillName.Macing, 55.0, 65.0);
            SetSkill(SkillName.Parry, 50.0, 60.0);
            SetSkill(SkillName.MagicResist, 10.0, 20.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 24;
        }

        public override string DefaultName => "ratman2, the Ratman Assassin";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluRatman3 : BaseCreature
    {
        [Constructible]
        public ZuluRatman3() : base(AIType.AI_Melee)
        {
            Body = 45;

            SetStr(80);
            SetDex(90);
            SetInt(35);
            SetHits(80);
            SetMana(0);
            SetStam(50);

            SetDamage(5, 15);
            z_Physical_DD = 100;

            SetSkill(SkillName.Tactics, 40.0, 50.0);
            SetSkill(SkillName.Swords, 55.0, 65.0);
            SetSkill(SkillName.Macing, 55.0, 65.0);
            SetSkill(SkillName.Parry, 50.0, 60.0);
            SetSkill(SkillName.MagicResist, 10.0, 20.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 24;
        }

        public override string DefaultName => "ratman3, the Ratman Warrior";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluRatmanLord : BaseCreature
    {
        [Constructible]
        public ZuluRatmanLord() : base(AIType.AI_Melee)
        {
            Body = 45;
            Hue = 0x488;

            SetStr(300);
            SetDex(150);
            SetInt(65);
            SetHits(300);
            SetMana(0);
            SetStam(50);

            SetDamage(12, 35);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Swords, 95.0, 105.0);
            SetSkill(SkillName.MagicResist, 65.0, 75.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 15;
        }

        public override string DefaultName => "ratman_lord, the Rat Leader";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluRatmanmarksman : BaseCreature
    {
        [Constructible]
        public ZuluRatmanmarksman() : base(AIType.AI_Mage)
        {
            Body = 42;

            SetStr(160);
            SetDex(180);
            SetInt(35);
            SetHits(160);
            SetMana(0);
            SetStam(50);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 20, 20);

            SetSkill(SkillName.Tactics, 50.0, 60.0);
            SetSkill(SkillName.Macing, 55.0, 65.0);
            SetSkill(SkillName.MagicResist, 30.0, 40.0);
            SetSkill(SkillName.Archery, 90.0, 100.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 8;
        }

        public override string DefaultName => "ratmanmarksman, the Ratman Alchemist";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }
}
