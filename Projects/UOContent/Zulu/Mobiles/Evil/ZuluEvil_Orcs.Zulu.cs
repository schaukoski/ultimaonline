using ModernUO.Serialization;
using Server.Items;

namespace Server.Mobiles
{
    // Zulu Hotel — Orcs Evil NPCs
    // Auto-generated from npcdesc_zhbr.cfg (19 NPCs)
    // Source: POL 98 Zulu Hotel shard

    [SerializationGenerator(0, false)]
    public partial class ZuluCoveorc1 : BaseCreature
    {
        [Constructible]
        public ZuluCoveorc1() : base(AIType.AI_Melee)
        {
            Body = 17;
            Hue = 0x484;

            SetStr(80);
            SetDex(90);
            SetInt(35);
            SetHits(80);
            SetMana(35);
            SetStam(90);

            SetDamage(5, 15);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 20, 20);

            SetSkill(SkillName.Tactics, 50.0, 60.0);
            SetSkill(SkillName.Fencing, 55.0, 65.0);
            SetSkill(SkillName.Parry, 45.0, 55.0);
            SetSkill(SkillName.MagicResist, 20.0, 30.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 24;
        }

        public override string DefaultName => "coveorc1";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluCoveorc2 : BaseCreature
    {
        [Constructible]
        public ZuluCoveorc2() : base(AIType.AI_Melee)
        {
            Body = 41;
            Hue = 0x484;

            SetStr(160);
            SetDex(190);
            SetInt(35);
            SetHits(160);
            SetMana(35);
            SetStam(190);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 80.0, 90.0);
            SetSkill(SkillName.Macing, 85.0, 95.0);
            SetSkill(SkillName.MagicResist, 50.0, 60.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 12;
        }

        public override string DefaultName => "coveorc2, the Warrior";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluCoveorc3 : BaseCreature
    {
        [Constructible]
        public ZuluCoveorc3() : base(AIType.AI_Melee)
        {
            Body = 41;
            Hue = 0x498;

            SetStr(160);
            SetDex(190);
            SetInt(35);
            SetHits(160);
            SetMana(35);
            SetStam(190);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 80.0, 90.0);
            SetSkill(SkillName.Macing, 85.0, 95.0);
            SetSkill(SkillName.MagicResist, 50.0, 60.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 12;
        }

        public override string DefaultName => "coveorc3, the Soldier";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluCoveorcbutcher : BaseCreature
    {
        [Constructible]
        public ZuluCoveorcbutcher() : base(AIType.AI_Melee)
        {
            Body = 400;
            Hue = 0x484;

            SetStr(205);
            SetDex(90);
            SetInt(30);
            SetHits(205);
            SetMana(30);
            SetStam(90);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Swords, 110.0, 120.0);
            SetSkill(SkillName.MagicResist, 70.0, 80.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 16;
        }

        public override string DefaultName => "coveorcbutcher, the Butcher";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluCoveorcleader : BaseCreature
    {
        [Constructible]
        public ZuluCoveorcleader() : base(AIType.AI_Melee)
        {
            Body = 400;
            Hue = 0x498;

            SetStr(205);
            SetDex(90);
            SetInt(30);
            SetHits(205);
            SetMana(30);
            SetStam(90);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Swords, 110.0, 120.0);
            SetSkill(SkillName.MagicResist, 70.0, 80.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 16;
        }

        public override string DefaultName => "coveorcleader, the Chief";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluCoveorcpreacher : BaseCreature
    {
        [Constructible]
        public ZuluCoveorcpreacher() : base(AIType.AI_Mage)
        {
            Body = 17;
            Hue = 0x498;

            SetStr(215);
            SetDex(90);
            SetInt(290);
            SetHits(215);
            SetMana(290);
            SetStam(80);

            SetDamage(8, 25);
            z_Air_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 40.0, 50.0);
            SetSkill(SkillName.Macing, 65.0, 75.0);
            SetSkill(SkillName.MagicResist, 70.0, 80.0);
            SetSkill(SkillName.Magery, 90.0, 100.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 16;
        }

        public override string DefaultName => "coveorcpreacher, the Preacher";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluCoveorcsentinel : BaseCreature
    {
        [Constructible]
        public ZuluCoveorcsentinel() : base(AIType.AI_Melee)
        {
            Body = 41;
            Hue = 0x455;

            SetStr(160);
            SetDex(190);
            SetInt(35);
            SetHits(160);
            SetMana(35);
            SetStam(190);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 80.0, 90.0);
            SetSkill(SkillName.Macing, 85.0, 95.0);
            SetSkill(SkillName.MagicResist, 50.0, 60.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 12;
        }

        public override string DefaultName => "coveorcsentinel, the Sentinel";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluCoveorcshaman : BaseCreature
    {
        [Constructible]
        public ZuluCoveorcshaman() : base(AIType.AI_Mage)
        {
            Body = 17;
            Hue = 0x498;

            SetStr(215);
            SetDex(90);
            SetInt(290);
            SetHits(215);
            SetMana(290);
            SetStam(80);

            SetDamage(8, 25);
            z_Air_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 40.0, 50.0);
            SetSkill(SkillName.Macing, 65.0, 75.0);
            SetSkill(SkillName.MagicResist, 70.0, 80.0);
            SetSkill(SkillName.Magery, 90.0, 100.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 16;
        }

        public override string DefaultName => "coveorcshaman, the Shaman";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluCoveorctowerguard : BaseCreature
    {
        [Constructible]
        public ZuluCoveorctowerguard() : base(AIType.AI_Melee)
        {
            Body = 17;
            Hue = 0x484;

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

        public override string DefaultName => "coveorctowerguard, the Tower Guard";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluHuntingorc : BaseCreature
    {
        [Constructible]
        public ZuluHuntingorc() : base(AIType.AI_Melee)
        {
            Body = 41;
            Hue = 0x602;

            SetStr(160);
            SetDex(190);
            SetInt(35);
            SetHits(160);
            SetMana(35);
            SetStam(190);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 80.0, 90.0);
            SetSkill(SkillName.Macing, 85.0, 95.0);
            SetSkill(SkillName.MagicResist, 50.0, 60.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 12;
        }

        public override string DefaultName => "huntingorc, the hunter";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluOrc1 : BaseCreature
    {
        [Constructible]
        public ZuluOrc1() : base(AIType.AI_Melee)
        {
            Body = 17;

            SetStr(80);
            SetDex(90);
            SetInt(35);
            SetHits(80);
            SetMana(35);
            SetStam(90);

            SetDamage(5, 15);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 20, 20);

            SetSkill(SkillName.Tactics, 50.0, 60.0);
            SetSkill(SkillName.Fencing, 55.0, 65.0);
            SetSkill(SkillName.Parry, 45.0, 55.0);
            SetSkill(SkillName.MagicResist, 20.0, 30.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 24;
        }

        public override string DefaultName => "orc1";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluOrc2 : BaseCreature
    {
        [Constructible]
        public ZuluOrc2() : base(AIType.AI_Melee)
        {
            Body = 41;

            SetStr(160);
            SetDex(190);
            SetInt(35);
            SetHits(160);
            SetMana(35);
            SetStam(190);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 80.0, 90.0);
            SetSkill(SkillName.Macing, 85.0, 95.0);
            SetSkill(SkillName.MagicResist, 50.0, 60.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 12;
        }

        public override string DefaultName => "orc2, the warrior";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluOrcblacksmith : BaseCreature
    {
        [Constructible]
        public ZuluOrcblacksmith() : base(AIType.AI_Melee)
        {
            Body = 41;
            Hue = 0x494;

            SetStr(160);
            SetDex(190);
            SetInt(35);
            SetHits(160);
            SetMana(35);
            SetStam(190);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 80.0, 90.0);
            SetSkill(SkillName.Macing, 85.0, 95.0);
            SetSkill(SkillName.MagicResist, 50.0, 60.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 12;
        }

        public override string DefaultName => "orcblacksmith, the Blacksmith";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluOrccatapultoperator : BaseCreature
    {
        [Constructible]
        public ZuluOrccatapultoperator() : base(AIType.AI_Melee)
        {
            Body = 17;
            Hue = 0x488;

            SetStr(80);
            SetDex(90);
            SetInt(35);
            SetHits(80);
            SetMana(35);
            SetStam(90);

            SetDamage(5, 15);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 20, 20);

            SetSkill(SkillName.Tactics, 50.0, 60.0);
            SetSkill(SkillName.Fencing, 55.0, 65.0);
            SetSkill(SkillName.Parry, 45.0, 55.0);
            SetSkill(SkillName.MagicResist, 20.0, 30.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 24;
        }

        public override string DefaultName => "orccatapultoperator, the Catapult Operator";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluOrccommander : BaseCreature
    {
        [Constructible]
        public ZuluOrccommander() : base(AIType.AI_Melee)
        {
            Body = 400;
            Hue = 0x494;

            SetStr(205);
            SetDex(90);
            SetInt(30);
            SetHits(205);
            SetMana(30);
            SetStam(90);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Swords, 110.0, 120.0);
            SetSkill(SkillName.MagicResist, 70.0, 80.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 16;
        }

        public override string DefaultName => "orccommander, the fort Commander";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluOrcforthealer : BaseCreature
    {
        [Constructible]
        public ZuluOrcforthealer() : base(AIType.AI_Mage)
        {
            Body = 17;
            Hue = 0x495;

            SetStr(215);
            SetDex(90);
            SetInt(290);
            SetHits(215);
            SetMana(290);
            SetStam(80);

            SetDamage(8, 25);
            z_Air_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 40.0, 50.0);
            SetSkill(SkillName.Macing, 65.0, 75.0);
            SetSkill(SkillName.MagicResist, 70.0, 80.0);
            SetSkill(SkillName.Magery, 90.0, 100.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 16;
        }

        public override string DefaultName => "orcforthealer, the fort Healer";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluOrcleader : BaseCreature
    {
        [Constructible]
        public ZuluOrcleader() : base(AIType.AI_Melee)
        {
            Body = 400;
            Hue = 0x83F8;

            SetStr(205);
            SetDex(90);
            SetInt(30);
            SetHits(205);
            SetMana(30);
            SetStam(90);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Swords, 110.0, 120.0);
            SetSkill(SkillName.MagicResist, 70.0, 80.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 16;
        }

        public override string DefaultName => "orcleader, the Orc Leader";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluOrcmage : BaseCreature
    {
        [Constructible]
        public ZuluOrcmage() : base(AIType.AI_Mage)
        {
            Body = 17;
            Hue = 0x579;

            SetStr(215);
            SetDex(90);
            SetInt(290);
            SetHits(215);
            SetMana(290);
            SetStam(80);

            SetDamage(8, 25);
            z_Air_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 40.0, 50.0);
            SetSkill(SkillName.Macing, 65.0, 75.0);
            SetSkill(SkillName.MagicResist, 70.0, 80.0);
            SetSkill(SkillName.Magery, 90.0, 100.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 16;
        }

        public override string DefaultName => "orcmage, the Shaman";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluOrcsentinel : BaseCreature
    {
        [Constructible]
        public ZuluOrcsentinel() : base(AIType.AI_Melee)
        {
            Body = 41;
            Hue = 0x488;

            SetStr(160);
            SetDex(190);
            SetInt(35);
            SetHits(160);
            SetMana(35);
            SetStam(190);

            SetDamage(8, 25);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);

            SetSkill(SkillName.Tactics, 80.0, 90.0);
            SetSkill(SkillName.Macing, 85.0, 95.0);
            SetSkill(SkillName.MagicResist, 50.0, 60.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 12;
        }

        public override string DefaultName => "orcsentinel, the Sentinel";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
        }
    }
}
