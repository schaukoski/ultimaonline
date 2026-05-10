using System;
using Server.Engines.Craft; // for ForgeAttribute / AnvilAttribute (defined alongside the vanilla DefBlacksmithy)
using Server.Items;

namespace Server.Zulu.Crafting.Systems;

/// <summary>
/// Zulu Hotel adaptation of the vanilla blacksmithy craft system.
/// All recipes use the simplified Zulu AddCraft overload — material selection
/// is done by the player at the gump (ZuluCraftSubResCol), not at registration time.
/// </summary>
public class ZuluBlacksmithy : ZuluCraftSystem
{
    private static readonly Type typeofAnvil = typeof(AnvilAttribute);
    private static readonly Type typeofForge = typeof(ForgeAttribute);

    private static ZuluCraftSystem _craftSystem;

    public static void Initialize()
    {
        _craftSystem = new ZuluBlacksmithy();
    }

    private ZuluBlacksmithy() : base(1, 1, 1.25)
    {
    }

    public override SkillName MainSkill => SkillName.Blacksmith;

    public override string GumpTitle => "Blacksmithy";

    public static ZuluCraftSystem CraftSystem => _craftSystem ??= new ZuluBlacksmithy();

    public override ZuluCraftECA ECA => ZuluCraftECA.ChanceMinusSixtyToFortyFive;

    public override double GetChanceAtMin(ZuluCraftItem item) => 0.0;

    public static void CheckAnvilAndForge(Mobile from, int range, out bool anvil, out bool forge)
    {
        anvil = false;
        forge = false;

        var map = from.Map;

        if (map == null)
        {
            return;
        }

        foreach (var item in map.GetItemsInRange(from.Location, range))
        {
            var type = item.GetType();

            var isAnvil = type.IsDefined(typeofAnvil, false) || item.ItemID is 4015 or 4016 or 11733 or 11734;
            var isForge = type.IsDefined(typeofForge, false) || item.ItemID is 4017 or >= 6522 and <= 6569 or 11736;

            if (isAnvil || isForge)
            {
                if (from.Z + 16 < item.Z || item.Z + 16 < from.Z || !from.InLOS(item))
                {
                    continue;
                }

                anvil = anvil || isAnvil;
                forge = forge || isForge;

                if (anvil && forge)
                {
                    break;
                }
            }
        }

        for (var x = -range; (!anvil || !forge) && x <= range; ++x)
        {
            for (var y = -range; (!anvil || !forge) && y <= range; ++y)
            {
                foreach (var tile in map.Tiles.GetStaticAndMultiTiles(from.X + x, from.Y + y))
                {
                    var id = tile.ID;

                    var isAnvil = id is 4015 or 4016 or 11733 or 11734;
                    var isForge = id is 4017 or >= 6522 and <= 6569 or 11736;

                    if (isAnvil || isForge)
                    {
                        if (from.Z + 16 < tile.Z || tile.Z + 16 < from.Z ||
                            !from.InLOS(new Point3D(from.X + x, from.Y + y, tile.Z + tile.Height / 2 + 1)))
                        {
                            continue;
                        }

                        anvil = anvil || isAnvil;
                        forge = forge || isForge;
                    }
                }
            }
        }
    }

    public override int CanCraft(Mobile from, BaseTool tool, Type itemType)
    {
        if (tool?.Deleted != false || tool.UsesRemaining < 0)
        {
            return 1044038; // You have worn out your tool!
        }

        // TODO Phase D: enforce ZuluSmithHammer-only check via BaseTool subclass once it exists.
        if (!BaseTool.CheckAccessible(tool, from))
        {
            return 1044263; // The tool must be on your person to use.
        }

        CheckAnvilAndForge(from, 2, out var anvil, out var forge);

        if (anvil && forge)
        {
            return 0;
        }

        return 1044267; // You must be near an anvil and a forge to smith items.
    }

    public override void PlayCraftEffect(Mobile from)
    {
        // 0.7 second hammer sound
        from.PlaySound(0x2A);
    }

    public override int PlayEndingEffect(
        Mobile from, bool failed, bool lostMaterial, bool toolBroken, int quality,
        bool makersMark, ZuluCraftItem item
    )
    {
        if (toolBroken)
        {
            from.SendLocalizedMessage(1044038); // You have worn out your tool
        }

        if (failed)
        {
            if (lostMaterial)
            {
                return 1044043; // You failed to create the item, and some of your materials are lost.
            }

            return 1044157; // You failed to create the item, but no materials were lost.
        }

        if (quality == 0)
        {
            return 502785; // You were barely able to make this item.  It's quality is below average.
        }

        if (makersMark && quality == 2)
        {
            return 1044156; // You create an exceptional quality item and affix your maker's mark.
        }

        if (quality == 2)
        {
            return 1044155; // You create an exceptional quality item.
        }

        return 1044154; // You create the item.
    }

    public override void InitCraftList()
    {
        // ----- Ringmail -----
        AddCraft(typeof(RingmailGloves), "Ringmail", "Ringmail Gloves", 12.0, 10);
        AddCraft(typeof(RingmailLegs), "Ringmail", "Ringmail Legs", 19.4, 16);
        AddCraft(typeof(RingmailArms), "Ringmail", "Ringmail Sleeves", 16.9, 14);
        AddCraft(typeof(RingmailChest), "Ringmail", "Ringmail Tunic", 21.9, 18);

        // ----- Chainmail -----
        AddCraft(typeof(ChainCoif), "Chainmail", "Chain Coif", 14.5, 10);
        AddCraft(typeof(ChainLegs), "Chainmail", "Chain Leggings", 36.7, 18);
        AddCraft(typeof(ChainChest), "Chainmail", "Chain Tunic", 39.1, 20);

        // ----- Plate Armor -----
        AddCraft(typeof(PlateArms), "Plate Armor", "Plate Arms", 66.3, 18);
        AddCraft(typeof(PlateGloves), "Plate Armor", "Plate Gloves", 58.9, 12);
        AddCraft(typeof(PlateGorget), "Plate Armor", "Plate Gorget", 56.4, 10);
        AddCraft(typeof(PlateLegs), "Plate Armor", "Plate Leggings", 68.8, 20);
        AddCraft(typeof(PlateChest), "Plate Armor", "Plate Tunic", 75.0, 25);
        AddCraft(typeof(FemalePlateChest), "Plate Armor", "Female Plate Chest", 44.1, 20);
        AddCraft(typeof(DragonBardingDeed), "Plate Armor", "Dragon Barding Deed", 72.5, 750);

        AddCraft(typeof(PlateMempo), "Plate Armor", "Plate Mempo", 80.0, 18);
        AddCraft(typeof(PlateDo), "Plate Armor", "Plate Do", 87.0, 28);
        AddCraft(typeof(PlateHiroSode), "Plate Armor", "Plate Hiro Sode", 80.0, 16);
        AddCraft(typeof(PlateSuneate), "Plate Armor", "Plate Suneate", 65.0, 20);
        AddCraft(typeof(PlateHaidate), "Plate Armor", "Plate Haidate", 65.0, 20);

        // ----- Helmets -----
        AddCraft(typeof(Bascinet), "Helmets", "Bascinet", 8.3, 15);
        AddCraft(typeof(CloseHelm), "Helmets", "Close Helm", 37.9, 15);
        AddCraft(typeof(Helmet), "Helmets", "Helmet", 37.9, 15);
        AddCraft(typeof(NorseHelm), "Helmets", "Norse Helm", 37.9, 15);
        AddCraft(typeof(PlateHelm), "Helmets", "Plate Helm", 62.6, 15);

        AddCraft(typeof(ChainHatsuburi), "Helmets", "Chain Hatsuburi", 30.0, 20);
        AddCraft(typeof(PlateHatsuburi), "Helmets", "Plate Hatsuburi", 45.0, 20);
        AddCraft(typeof(HeavyPlateJingasa), "Helmets", "Heavy Plate Jingasa", 45.0, 20);
        AddCraft(typeof(LightPlateJingasa), "Helmets", "Light Plate Jingasa", 45.0, 20);
        AddCraft(typeof(SmallPlateJingasa), "Helmets", "Small Plate Jingasa", 45.0, 20);
        AddCraft(typeof(DecorativePlateKabuto), "Helmets", "Decorative Plate Kabuto", 90.0, 25);
        AddCraft(typeof(PlateBattleKabuto), "Helmets", "Plate Battle Kabuto", 90.0, 25);
        AddCraft(typeof(StandardPlateKabuto), "Helmets", "Standard Plate Kabuto", 90.0, 25);

        AddCraft(typeof(Circlet), "Helmets", "Circlet", 62.1, 6);
        AddCraft(typeof(RoyalCirclet), "Helmets", "Royal Circlet", 70.0, 6);
        // TODO Phase D: GemmedCirclet originally required gemstones (Tourmaline/Amethyst/BlueDiamond) — gem reqs dropped.
        AddCraft(typeof(GemmedCirclet), "Helmets", "Gemmed Circlet", 75.0, 6);

        // ----- Shields -----
        AddCraft(typeof(Buckler), "Shields", "Buckler", -25.0, 10);
        AddCraft(typeof(BronzeShield), "Shields", "Bronze Shield", -15.2, 12);
        AddCraft(typeof(HeaterShield), "Shields", "Heater Shield", 24.3, 18);
        AddCraft(typeof(MetalShield), "Shields", "Metal Shield", -10.2, 14);
        AddCraft(typeof(MetalKiteShield), "Shields", "Metal Kite Shield", 4.6, 16);
        AddCraft(typeof(WoodenKiteShield), "Shields", "Wooden Kite Shield", -15.2, 8);
        AddCraft(typeof(ChaosShield), "Shields", "Chaos Shield", 85.0, 25);
        AddCraft(typeof(OrderShield), "Shields", "Order Shield", 85.0, 25);

        // ----- Bladed Weapons -----
        AddCraft(typeof(BoneHarvester), "Bladed Weapons", "Bone Harvester", 33.0, 10);
        AddCraft(typeof(Broadsword), "Bladed Weapons", "Broadsword", 35.4, 10);
        AddCraft(typeof(CrescentBlade), "Bladed Weapons", "Crescent Blade", 45.0, 14);
        AddCraft(typeof(Cutlass), "Bladed Weapons", "Cutlass", 24.3, 8);
        AddCraft(typeof(Dagger), "Bladed Weapons", "Dagger", -0.4, 3);
        AddCraft(typeof(Katana), "Bladed Weapons", "Katana", 44.1, 8);
        AddCraft(typeof(Kryss), "Bladed Weapons", "Kryss", 36.7, 8);
        AddCraft(typeof(Longsword), "Bladed Weapons", "Longsword", 28.0, 12);
        AddCraft(typeof(Scimitar), "Bladed Weapons", "Scimitar", 31.7, 10);
        AddCraft(typeof(VikingSword), "Bladed Weapons", "Viking Sword", 24.3, 14);

        AddCraft(typeof(NoDachi), "Bladed Weapons", "No-Dachi", 75.0, 18);
        AddCraft(typeof(Wakizashi), "Bladed Weapons", "Wakizashi", 50.0, 8);
        AddCraft(typeof(Lajatang), "Bladed Weapons", "Lajatang", 80.0, 25);
        AddCraft(typeof(Daisho), "Bladed Weapons", "Daisho", 60.0, 15);
        AddCraft(typeof(Tekagi), "Bladed Weapons", "Tekagi", 55.0, 12);
        AddCraft(typeof(Shuriken), "Bladed Weapons", "Shuriken", 45.0, 5);
        AddCraft(typeof(Kama), "Bladed Weapons", "Kama", 40.0, 14);
        AddCraft(typeof(Sai), "Bladed Weapons", "Sai", 50.0, 12);

        // ----- ML Bladed Weapons (gem/recipe requirements stripped — TODO Phase D for special crafting) -----
        AddCraft(typeof(RadiantScimitar), "Bladed Weapons", "Radiant Scimitar", 75.0, 15);
        AddCraft(typeof(WarCleaver), "Bladed Weapons", "War Cleaver", 70.0, 18);
        AddCraft(typeof(ElvenSpellblade), "Bladed Weapons", "Elven Spellblade", 70.0, 14);
        AddCraft(typeof(AssassinSpike), "Bladed Weapons", "Assassin Spike", 70.0, 9);
        AddCraft(typeof(Leafblade), "Bladed Weapons", "Leafblade", 70.0, 12);
        AddCraft(typeof(RuneBlade), "Bladed Weapons", "Rune Blade", 70.0, 15);
        AddCraft(typeof(ElvenMachete), "Bladed Weapons", "Elven Machete", 70.0, 14);
        AddCraft(typeof(RuneCarvingKnife), "Bladed Weapons", "Rune Carving Knife", 70.0, 9);
        AddCraft(typeof(ColdForgedBlade), "Bladed Weapons", "Cold Forged Blade", 70.0, 18);
        AddCraft(typeof(OverseerSunderedBlade), "Bladed Weapons", "Overseer Sundered Blade", 70.0, 15);
        AddCraft(typeof(LuminousRuneBlade), "Bladed Weapons", "Luminous Rune Blade", 70.0, 15);
        AddCraft(typeof(TrueSpellblade), "Bladed Weapons", "True Spellblade", 75.0, 14);
        AddCraft(typeof(IcySpellblade), "Bladed Weapons", "Icy Spellblade", 75.0, 14);
        AddCraft(typeof(FierySpellblade), "Bladed Weapons", "Fiery Spellblade", 75.0, 14);
        AddCraft(typeof(SpellbladeOfDefense), "Bladed Weapons", "Spellblade Of Defense", 75.0, 18);
        AddCraft(typeof(TrueAssassinSpike), "Bladed Weapons", "True Assassin Spike", 75.0, 9);
        AddCraft(typeof(ChargedAssassinSpike), "Bladed Weapons", "Charged Assassin Spike", 75.0, 9);
        AddCraft(typeof(MagekillerAssassinSpike), "Bladed Weapons", "Magekiller Assassin Spike", 75.0, 9);
        AddCraft(typeof(WoundingAssassinSpike), "Bladed Weapons", "Wounding Assassin Spike", 75.0, 9);
        AddCraft(typeof(TrueLeafblade), "Bladed Weapons", "True Leafblade", 75.0, 12);
        AddCraft(typeof(Luckblade), "Bladed Weapons", "Luckblade", 75.0, 12);
        AddCraft(typeof(MagekillerLeafblade), "Bladed Weapons", "Magekiller Leafblade", 75.0, 12);
        AddCraft(typeof(LeafbladeOfEase), "Bladed Weapons", "Leafblade Of Ease", 75.0, 12);
        AddCraft(typeof(KnightsWarCleaver), "Bladed Weapons", "Knight's War Cleaver", 75.0, 18);
        AddCraft(typeof(ButchersWarCleaver), "Bladed Weapons", "Butcher's War Cleaver", 75.0, 18);
        AddCraft(typeof(SerratedWarCleaver), "Bladed Weapons", "Serrated War Cleaver", 75.0, 18);
        AddCraft(typeof(TrueWarCleaver), "Bladed Weapons", "True War Cleaver", 75.0, 18);
        AddCraft(typeof(AdventurersMachete), "Bladed Weapons", "Adventurer's Machete", 75.0, 14);
        AddCraft(typeof(OrcishMachete), "Bladed Weapons", "Orcish Machete", 75.0, 14);
        AddCraft(typeof(MacheteOfDefense), "Bladed Weapons", "Machete Of Defense", 75.0, 14);
        AddCraft(typeof(DiseasedMachete), "Bladed Weapons", "Diseased Machete", 75.0, 14);
        AddCraft(typeof(Runesabre), "Bladed Weapons", "Runesabre", 75.0, 15);
        AddCraft(typeof(MagesRuneBlade), "Bladed Weapons", "Mage's Rune Blade", 75.0, 15);
        AddCraft(typeof(RuneBladeOfKnowledge), "Bladed Weapons", "Rune Blade Of Knowledge", 75.0, 15);
        AddCraft(typeof(CorruptedRuneBlade), "Bladed Weapons", "Corrupted Rune Blade", 75.0, 15);
        AddCraft(typeof(TrueRadiantScimitar), "Bladed Weapons", "True Radiant Scimitar", 75.0, 15);
        AddCraft(typeof(DarkglowScimitar), "Bladed Weapons", "Darkglow Scimitar", 75.0, 15);
        AddCraft(typeof(IcyScimitar), "Bladed Weapons", "Icy Scimitar", 75.0, 15);
        AddCraft(typeof(TwinklingScimitar), "Bladed Weapons", "Twinkling Scimitar", 75.0, 15);
        AddCraft(typeof(BoneMachete), "Bladed Weapons", "Bone Machete", 45.0, 20);

        // ----- Axes -----
        AddCraft(typeof(Axe), "Axes", "Axe", 34.2, 14);
        AddCraft(typeof(BattleAxe), "Axes", "Battle Axe", 30.5, 14);
        AddCraft(typeof(DoubleAxe), "Axes", "Double Axe", 29.3, 12);
        AddCraft(typeof(ExecutionersAxe), "Axes", "Executioner's Axe", 34.2, 14);
        AddCraft(typeof(LargeBattleAxe), "Axes", "Large Battle Axe", 28.0, 12);
        AddCraft(typeof(TwoHandedAxe), "Axes", "Two-Handed Axe", 33.0, 16);
        AddCraft(typeof(WarAxe), "Axes", "War Axe", 39.1, 16);

        AddCraft(typeof(OrnateAxe), "Axes", "Ornate Axe", 70.0, 18);
        AddCraft(typeof(GuardianAxe), "Axes", "Guardian Axe", 75.0, 15);
        AddCraft(typeof(SingingAxe), "Axes", "Singing Axe", 75.0, 15);
        AddCraft(typeof(ThunderingAxe), "Axes", "Thundering Axe", 75.0, 15);
        AddCraft(typeof(HeavyOrnateAxe), "Axes", "Heavy Ornate Axe", 75.0, 15);

        // ----- Polearms -----
        AddCraft(typeof(Bardiche), "Polearms", "Bardiche", 31.7, 18);
        AddCraft(typeof(BladedStaff), "Polearms", "Bladed Staff", 40.0, 12);
        AddCraft(typeof(DoubleBladedStaff), "Polearms", "Double-Bladed Staff", 45.0, 16);
        AddCraft(typeof(Halberd), "Polearms", "Halberd", 39.1, 20);
        AddCraft(typeof(Lance), "Polearms", "Lance", 48.0, 20);
        AddCraft(typeof(Pike), "Polearms", "Pike", 47.0, 12);
        AddCraft(typeof(ShortSpear), "Polearms", "Short Spear", 45.3, 6);
        AddCraft(typeof(Scythe), "Polearms", "Scythe", 39.0, 14);
        AddCraft(typeof(Spear), "Polearms", "Spear", 49.0, 12);
        AddCraft(typeof(WarFork), "Polearms", "War Fork", 42.9, 12);

        // ----- Mace Weapons -----
        AddCraft(typeof(HammerPick), "Mace Weapons", "Hammer Pick", 34.2, 16);
        AddCraft(typeof(Mace), "Mace Weapons", "Mace", 14.5, 6);
        AddCraft(typeof(Maul), "Mace Weapons", "Maul", 19.4, 10);
        AddCraft(typeof(Scepter), "Mace Weapons", "Scepter", 21.4, 10);
        AddCraft(typeof(WarMace), "Mace Weapons", "War Mace", 28.0, 14);
        AddCraft(typeof(WarHammer), "Mace Weapons", "War Hammer", 34.2, 16);
        // TODO Phase D: Tessen originally needed Tailoring + Cloth — secondary skill/resource dropped.
        AddCraft(typeof(Tessen), "Mace Weapons", "Tessen", 85.0, 16);
        AddCraft(typeof(DiamondMace), "Mace Weapons", "Diamond Mace", 70.0, 20);
        AddCraft(typeof(ShardThrasher), "Mace Weapons", "Shard Thrasher", 70.0, 20);
        AddCraft(typeof(RubyMace), "Mace Weapons", "Ruby Mace", 75.0, 20);
        AddCraft(typeof(EmeraldMace), "Mace Weapons", "Emerald Mace", 75.0, 20);
        AddCraft(typeof(SapphireMace), "Mace Weapons", "Sapphire Mace", 75.0, 20);
        AddCraft(typeof(SilverEtchedMace), "Mace Weapons", "Silver Etched Mace", 75.0, 20);

        // ----- Dragon Scale Armor (uses SubRes2 = scales) -----
        int index;
        index = AddCraft(typeof(DragonGloves), "Dragon Scale", "Dragon Gloves", 68.9, 16);
        SetUseSubRes2(index, true);

        index = AddCraft(typeof(DragonHelm), "Dragon Scale", "Dragon Helm", 72.6, 20);
        SetUseSubRes2(index, true);

        index = AddCraft(typeof(DragonLegs), "Dragon Scale", "Dragon Legs", 78.8, 28);
        SetUseSubRes2(index, true);

        index = AddCraft(typeof(DragonArms), "Dragon Scale", "Dragon Arms", 76.3, 24);
        SetUseSubRes2(index, true);

        index = AddCraft(typeof(DragonChest), "Dragon Scale", "Dragon Chest", 85.0, 36);
        SetUseSubRes2(index, true);

        // ----- Materials submenu (metals) -----
        // Replace the vanilla 9 hard-coded ingot AddSubRes calls with a registry-driven loop.
        SetSubRes("Materials");
        foreach (var material in ZuluMaterialRegistry.ByCategory(ZuluCraftCategory.Metal))
        {
            AddSubRes(material.Id);
        }

        // ----- Materials2 submenu (dragon scales) -----
        // TODO Phase D: scales are not yet modelled in ZuluMaterialRegistry. Names kept as
        // hard-coded materialIds so the existing Resmelt/Repair plumbing continues to compile;
        // when the Leather/Scales category is registered, swap to a ByCategory loop.
        SetSubRes2("Scales");

        Resmelt = true;
        Repair = true;
        MarkOption = true;
        CanEnhance = true;
    }
}

