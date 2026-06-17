using ModernUO.Serialization;
using Server.Items;

namespace Server.Mobiles
{
    // Zulu Hotel — Slimes Evil NPCs
    // Auto-generated from npcdesc_zhbr.cfg (5 NPCs)
    // Source: POL 98 Zulu Hotel shard

    [SerializationGenerator(0, false)]
    public partial class ZuluBroodling : BaseCreature
    {
        [Constructible]
        public ZuluBroodling() : base(AIType.AI_Melee)
        {
            Body = 51;
            Hue = 0x488;
            BaseSoundID = 0x1CC;

            SetStr(100);
            SetDex(600);
            SetInt(15);
            SetHits(250);
            SetMana(0);
            SetStam(600);

            SetDamage(5, 15);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.PhysicalProtection, 40, 40);
            AddMobZuluModifier(ZuluMod.WaterProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.AirProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.HollyProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.EarthProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 2, 2);

            SetSkill(SkillName.Tactics, 80.0, 90.0);
            SetSkill(SkillName.Anatomy, 80.0, 90.0);
            SetSkill(SkillName.Swords, 80.0, 90.0);
            SetSkill(SkillName.Macing, 80.0, 90.0);
            SetSkill(SkillName.Fencing, 80.0, 90.0);
            SetSkill(SkillName.Wrestling, 80.0, 90.0);
            SetSkill(SkillName.Parry, 80.0, 90.0);
            SetSkill(SkillName.MagicResist, 40.0, 50.0);

            Fame = 50000;
            Karma = -50000;
            VirtualArmor = 40;
            MinTameSkill = 110;
        }

        public override string DefaultName => "a broodling";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluHydralisk : BaseCreature
    {
        [Constructible]
        public ZuluHydralisk() : base(AIType.AI_Melee)
        {
            Body = 265;
            Hue = 0x485;
            BaseSoundID = 0x285;

            SetStr(500);
            SetDex(1000);
            SetInt(150);
            SetHits(1500);
            SetMana(0);
            SetStam(2000);

            SetDamage(18, 50);
            z_Physical_DD = 100;

            AddMobZuluModifier(ZuluMod.WaterProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.AirProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.NecroProtection, 10, 10);
            AddMobZuluModifier(ZuluMod.HollyProtection, 20, 20);
            AddMobZuluModifier(ZuluMod.EarthProtection, 30, 30);
            AddMobZuluModifier(ZuluMod.MagicImmunityCircle, 3, 3);

            SetSkill(SkillName.Tactics, 90.0, 100.0);
            SetSkill(SkillName.Anatomy, 130.0, 140.0);
            SetSkill(SkillName.Swords, 130.0, 140.0);
            SetSkill(SkillName.Macing, 130.0, 140.0);
            SetSkill(SkillName.Fencing, 130.0, 140.0);
            SetSkill(SkillName.Wrestling, 130.0, 140.0);
            SetSkill(SkillName.Parry, 100.0, 110.0);
            SetSkill(SkillName.MagicResist, 100.0, 110.0);
            SetSkill(SkillName.DetectHidden, 100.0, 110.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 58;
        }

        public override string DefaultName => "an hydralisk";
        public override bool AlwaysMurderer => true;
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluLivingmagmadrop : BaseCreature
    {
        [Constructible]
        public ZuluLivingmagmadrop() : base(AIType.AI_Melee)
        {
            Body = 51;
            Hue = 0x494;

            SetStr(40);
            SetDex(50);
            SetInt(15);
            SetHits(40);
            SetMana(0);
            SetStam(50);

            SetDamage(5, 15);
            z_Physical_DD = 100;

            SetSkill(SkillName.Tactics, 40.0, 50.0);
            SetSkill(SkillName.Swords, 20.0, 30.0);
            SetSkill(SkillName.Parry, 8.0, 18.0);
            SetSkill(SkillName.MagicResist, 10.0, 20.0);
            SetSkill(SkillName.Poisoning, 30.0, 40.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 10;
            MinTameSkill = 20;
        }

        public override string DefaultName => "a living magma drop";
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluMagmamonster : BaseCreature
    {
        [Constructible]
        public ZuluMagmamonster() : base(AIType.AI_Mage)
        {
            Body = 199;
            Hue = 0x486;

            SetStr(140);
            SetDex(70);
            SetInt(110);
            SetHits(225);
            SetMana(125);
            SetStam(65);

            SetDamage(5, 15);
            z_Fire_DD = 100;

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

        public override string DefaultName => "a magma monster";
        public override bool AlwaysMurderer => true;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }

    [SerializationGenerator(0, false)]
    public partial class ZuluSlime : BaseCreature
    {
        [Constructible]
        public ZuluSlime() : base(AIType.AI_Melee)
        {
            Body = 51;
            Hue = 0x83F8;

            SetStr(40);
            SetDex(50);
            SetInt(15);
            SetHits(40);
            SetMana(0);
            SetStam(50);

            SetDamage(5, 15);
            z_Physical_DD = 100;

            SetSkill(SkillName.Tactics, 40.0, 50.0);
            SetSkill(SkillName.Swords, 20.0, 30.0);
            SetSkill(SkillName.Parry, 8.0, 18.0);
            SetSkill(SkillName.MagicResist, 10.0, 20.0);
            SetSkill(SkillName.Poisoning, 30.0, 40.0);

            Fame = 15000;
            Karma = -15000;
            VirtualArmor = 10;
            MinTameSkill = 20;
        }

        public override string DefaultName => "a slime";
        public override Poison PoisonImmune => Poison.Lethal;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
        }
    }
}
