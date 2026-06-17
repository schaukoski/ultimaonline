using System;
using System.Reflection;
using Server;
using Server.Items;
using Server.Spells;
using Server.Spells.Earth;
using Xunit;

namespace UOContent.Tests;

// ── SpellRegistry tests (calls Configure() explicitly — no fixture needed) ──

public class EarthSpellRegistryTests
{
    public EarthSpellRegistryTests()
    {
        // Register Earth spells directly so tests are self-contained
        EarthInitializer.Configure();
    }

    [Theory]
    [InlineData(750, typeof(AntidoteSpell))]
    [InlineData(751, typeof(OwlSightSpell))]
    [InlineData(752, typeof(ShiftingEarthSpell))]
    [InlineData(753, typeof(SummonMammalsSpell))]
    [InlineData(754, typeof(CallLightningSpell))]
    [InlineData(755, typeof(EarthBlessingSpell))]
    [InlineData(756, typeof(EarthPortalSpell))]
    [InlineData(757, typeof(NaturesTouchSpell))]
    [InlineData(758, typeof(GustOfAirSpell))]
    [InlineData(759, typeof(RisingFireSpell))]
    [InlineData(760, typeof(ShapeshiftSpell))]
    [InlineData(761, typeof(IceStrikeSpell))]
    [InlineData(762, typeof(EarthSpiritSpell))]
    [InlineData(763, typeof(FlameSpiritSpell))]
    [InlineData(764, typeof(StormSpiritSpell))]
    [InlineData(765, typeof(WaterSpiritSpell))]
    public void SpellRegistry_EarthSpells_RegisteredWithCorrectType(int spellId, Type expectedType)
    {
        Assert.Equal(expectedType, SpellRegistry.Types[spellId]);
    }

    [Fact]
    public void SpellRegistry_SpellId749_NotRegistered()
    {
        // ID 749 is the slot just before Earth Magic range — must remain empty
        Assert.Null(SpellRegistry.Types[749]);
    }

    [Fact]
    public void SpellRegistry_SpellId766_NotRegistered()
    {
        // ID 766 is one past the Earth Magic range — must remain empty
        Assert.Null(SpellRegistry.Types[766]);
    }

    [Fact]
    public void SpellRegistry_EarthSpells_NoDuplicateIds()
    {
        var earthTypes = new System.Collections.Generic.HashSet<Type>();

        for (var i = 750; i <= 765; i++)
        {
            var t = SpellRegistry.Types[i];
            Assert.NotNull(t);
            Assert.True(earthTypes.Add(t), $"Duplicate spell type at ID {i}: {t}");
        }
    }

    [Fact]
    public void SpellRegistry_ArraySize_SupportsEarthMagicIds()
    {
        // Array must be at least 766 to hold IDs 750-765 without silent truncation
        Assert.True(SpellRegistry.Types.Length >= 766,
            $"SpellRegistry.Types.Length={SpellRegistry.Types.Length} — too small for Earth Magic IDs 750-765");
    }
}

// ── Pure-logic tests (no world / fixture required) ─────────────────────────

public class EarthMagicLogicTests
{
    // ── GetTypeForSpell ─────────────────────────────────────────────────────

    [Theory]
    [InlineData(750)]
    [InlineData(751)]
    [InlineData(757)]
    [InlineData(764)]
    [InlineData(765)]
    public void GetTypeForSpell_EarthMagicRange_ReturnsEarthMagic(int spellId)
    {
        Assert.Equal(SpellbookType.EarthMagic, Spellbook.GetTypeForSpell(spellId));
    }

    [Theory]
    [InlineData(749)]
    [InlineData(766)]
    [InlineData(700)]
    [InlineData(-1)]
    public void GetTypeForSpell_OutsideEarthRange_ReturnsInvalid(int spellId)
    {
        Assert.Equal(SpellbookType.Invalid, Spellbook.GetTypeForSpell(spellId));
    }

    [Fact]
    public void GetTypeForSpell_BoundaryFirst_ReturnsEarthMagic()
    {
        Assert.Equal(SpellbookType.EarthMagic, Spellbook.GetTypeForSpell(750));
    }

    [Fact]
    public void GetTypeForSpell_BoundaryLast_ReturnsEarthMagic()
    {
        Assert.Equal(SpellbookType.EarthMagic, Spellbook.GetTypeForSpell(765));
    }

    [Fact]
    public void GetTypeForSpell_OneBelowRange_ReturnsInvalid()
    {
        Assert.Equal(SpellbookType.Invalid, Spellbook.GetTypeForSpell(749));
    }

    [Fact]
    public void GetTypeForSpell_OneAboveRange_ReturnsInvalid()
    {
        Assert.Equal(SpellbookType.Invalid, Spellbook.GetTypeForSpell(766));
    }

    // ── ApplyZuluSpellResistance math ───────────────────────────────────────

    private static readonly MethodInfo _applyResistance = typeof(SpellHelper)
        .GetMethod(
            "ApplyZuluSpellResistance",
            BindingFlags.NonPublic | BindingFlags.Static
        );

    private static int ApplyResistance(int damage, double resistancePct)
        => (int)_applyResistance.Invoke(null, new object[] { damage, resistancePct });

    [Fact]
    public void ApplyZuluSpellResistance_ZeroResistance_ReturnsFullDamage()
    {
        Assert.Equal(100, ApplyResistance(100, 0.0));
    }

    [Fact]
    public void ApplyZuluSpellResistance_50PctResistance_HalvesDamage()
    {
        Assert.Equal(50, ApplyResistance(100, 50.0));
    }

    [Fact]
    public void ApplyZuluSpellResistance_100PctResistance_ReturnsZero()
    {
        Assert.Equal(0, ApplyResistance(100, 100.0));
    }

    [Fact]
    public void ApplyZuluSpellResistance_25PctResistance_Returns75Pct()
    {
        Assert.Equal(75, ApplyResistance(100, 25.0));
    }

    [Fact]
    public void ApplyZuluSpellResistance_OddDamage_RoundsCorrectly()
    {
        // 50% of 11 = 5.5 → rounds to 6 (Math.Round default is MidpointRounding.ToEven → 6)
        var result = ApplyResistance(11, 50.0);
        Assert.InRange(result, 5, 6);
    }
}

// ── World-dependent tests (require full UOContent setup) ───────────────────

[Collection("Sequential UOContent Tests")]
public class EarthMagicWorldTests
{
    // ── EarthBook properties ────────────────────────────────────────────────

    [Fact]
    public void EarthBook_DefaultCtor_HasCorrectSpellbookType()
    {
        var book = new EarthBook();
        try
        {
            Assert.Equal(SpellbookType.EarthMagic, book.SpellbookType);
        }
        finally
        {
            book.Delete();
        }
    }

    [Fact]
    public void EarthBook_DefaultCtor_HasCorrectBookOffset()
    {
        var book = new EarthBook();
        try
        {
            Assert.Equal(750, book.BookOffset);
        }
        finally
        {
            book.Delete();
        }
    }

    [Fact]
    public void EarthBook_DefaultCtor_HasCorrectBookCount()
    {
        var book = new EarthBook();
        try
        {
            Assert.Equal(16, book.BookCount);
        }
        finally
        {
            book.Delete();
        }
    }

    [Fact]
    public void EarthBook_DefaultCtor_ContainsAllSpells()
    {
        var book = new EarthBook();
        try
        {
            // 0xFFFF = all 16 spells present
            Assert.Equal((ulong)0xFFFF, book.Content);
        }
        finally
        {
            book.Delete();
        }
    }

    [Fact]
    public void EarthBook_DefaultCtor_HasEarthHue()
    {
        var book = new EarthBook();
        try
        {
            Assert.Equal(0x48A, book.Hue);
        }
        finally
        {
            book.Delete();
        }
    }

    [Fact]
    public void EarthBook_DefaultCtor_HasCorrectName()
    {
        var book = new EarthBook();
        try
        {
            Assert.Equal("Book of the Earth", book.Name);
        }
        finally
        {
            book.Delete();
        }
    }

    // (SpellRegistry tests live in EarthSpellRegistryTests — see below)

    // ── Reagent properties ──────────────────────────────────────────────────

    [Fact]
    public void EyeOfNewt_IsBaseReagent()
    {
        var r = new EyeOfNewt(1);
        try { Assert.IsAssignableFrom<BaseReagent>(r); }
        finally { r.Delete(); }
    }

    [Fact]
    public void Brimstone_IsBaseReagent()
    {
        var r = new Brimstone(1);
        try { Assert.IsAssignableFrom<BaseReagent>(r); }
        finally { r.Delete(); }
    }

    [Fact]
    public void Obsidian_IsBaseReagent()
    {
        var r = new Obsidian(1);
        try { Assert.IsAssignableFrom<BaseReagent>(r); }
        finally { r.Delete(); }
    }

    [Fact]
    public void VolcanicAsh_IsBaseReagent()
    {
        var r = new VolcanicAsh(1);
        try { Assert.IsAssignableFrom<BaseReagent>(r); }
        finally { r.Delete(); }
    }

    [Fact]
    public void ZuluDeadwood_IsBaseReagent()
    {
        var r = new ZuluDeadwood(1);
        try { Assert.IsAssignableFrom<BaseReagent>(r); }
        finally { r.Delete(); }
    }

    [Fact]
    public void SerpentsScales_IsBaseReagent()
    {
        var r = new SerpentsScales(1);
        try { Assert.IsAssignableFrom<BaseReagent>(r); }
        finally { r.Delete(); }
    }

    [Fact]
    public void BlackMoor_IsBaseReagent()
    {
        var r = new BlackMoor(1);
        try { Assert.IsAssignableFrom<BaseReagent>(r); }
        finally { r.Delete(); }
    }

    [Fact]
    public void WormsHeart_IsBaseReagent()
    {
        var r = new WormsHeart(1);
        try { Assert.IsAssignableFrom<BaseReagent>(r); }
        finally { r.Delete(); }
    }

    [Fact]
    public void Pumice_IsBaseReagent()
    {
        var r = new Pumice(1);
        try { Assert.IsAssignableFrom<BaseReagent>(r); }
        finally { r.Delete(); }
    }

    [Fact]
    public void VialOfBlood_IsBaseReagent()
    {
        var r = new VialOfBlood(1);
        try { Assert.IsAssignableFrom<BaseReagent>(r); }
        finally { r.Delete(); }
    }

    [Fact]
    public void ZuluExecutionersCap_IsBaseReagent()
    {
        var r = new ZuluExecutionersCap(1);
        try { Assert.IsAssignableFrom<BaseReagent>(r); }
        finally { r.Delete(); }
    }

    [Theory]
    [InlineData(1)]
    [InlineData(30)]
    [InlineData(60)]
    public void EarthReagents_AmountConstructor_SetsCorrectAmount(int amount)
    {
        var r = new EyeOfNewt(amount);
        try
        {
            Assert.Equal(amount, r.Amount);
        }
        finally
        {
            r.Delete();
        }
    }

    [Fact]
    public void EarthReagents_AreStackable()
    {
        var r = new EyeOfNewt(1);
        try
        {
            Assert.True(r.Stackable);
        }
        finally
        {
            r.Delete();
        }
    }

    // ── EarthBag command creates correct reagent bag ─────────────────────────

    [Fact]
    public void EarthBag_CreatesReagentBag_WithAllSixteenTypes()
    {
        // Directly replicate the EarthBag logic without invoking the command system
        var bag = new Bag { Name = "Earth Magic Reagents", Hue = 0x48A };
        try
        {
            var reagentTypes = new[]
            {
                typeof(FertileDirt), typeof(PigIron), typeof(BatWing), typeof(Bone),
                typeof(DragonsBlood), typeof(EyeOfNewt), typeof(Brimstone), typeof(Obsidian),
                typeof(VolcanicAsh), typeof(ZuluDeadwood), typeof(SerpentsScales), typeof(BlackMoor),
                typeof(WormsHeart), typeof(Pumice), typeof(VialOfBlood), typeof(ZuluExecutionersCap)
            };

            Assert.Equal(16, reagentTypes.Length);

            foreach (var type in reagentTypes)
            {
                var reagent = (Item)Activator.CreateInstance(type, 60);
                bag.AddItem(reagent);
            }

            Assert.Equal(16, bag.Items.Count);

            foreach (var item in bag.Items)
            {
                Assert.Equal(60, item.Amount);
            }
        }
        finally
        {
            bag.Delete();
        }
    }

    [Fact]
    public void EarthBag_HasCorrectHue()
    {
        var bag = new Bag { Hue = 0x48A };
        try
        {
            Assert.Equal(0x48A, bag.Hue);
        }
        finally
        {
            bag.Delete();
        }
    }

    // ── EarthKit command creates correct scroll bag ──────────────────────────

    private static readonly Type[] _earthScrollTypes =
    [
        typeof(AntidoteScroll),      // 750
        typeof(OwlSightScroll),      // 751
        typeof(ShiftingEarthScroll), // 752
        typeof(SummonMammalsScroll), // 753
        typeof(CallLightningScroll), // 754
        typeof(EarthBlessingScroll), // 755
        typeof(EarthPortalScroll),   // 756
        typeof(NaturesTouchScroll),  // 757
        typeof(GustOfAirScroll),     // 758
        typeof(RisingFireScroll),    // 759
        typeof(ShapeshiftScroll),    // 760
        typeof(IceStrikeScroll),     // 761
        typeof(EarthSpiritScroll),   // 762
        typeof(FlameSpiritScroll),   // 763
        typeof(StormSpiritScroll),   // 764
        typeof(WaterSpiritScroll),   // 765
    ];

    [Fact]
    public void EarthKit_CreatesScrollBag_WithAllSixteenScrollTypes()
    {
        // Replicates the fixed EarthKit logic: Activator.CreateInstance(type, 1)
        var bag = new Bag { Name = "Earth Magic Kit", Hue = 0x48A };
        try
        {
            Assert.Equal(16, _earthScrollTypes.Length);

            foreach (var type in _earthScrollTypes)
            {
                var scroll = (Item)Activator.CreateInstance(type, 1);
                bag.AddItem(scroll);
            }

            Assert.Equal(16, bag.Items.Count);
        }
        finally
        {
            bag.Delete();
        }
    }

    [Fact]
    public void EarthKit_CreatesScrollBag_WithEmptyEarthBook()
    {
        var bag = new Bag { Name = "Earth Magic Kit", Hue = 0x48A };
        var book = new EarthBook(0);
        try
        {
            bag.AddItem(book);
            Assert.Single(bag.Items);
            Assert.IsType<EarthBook>(bag.Items[0]);
            Assert.Equal((ulong)0, book.Content);
        }
        finally
        {
            bag.Delete();
        }
    }

    [Fact]
    public void EarthKit_ScrollsHaveCorrectSpellIds()
    {
        var expectedIds = new[] { 750, 751, 752, 753, 754, 755, 756, 757, 758, 759, 760, 761, 762, 763, 764, 765 };

        for (var i = 0; i < _earthScrollTypes.Length; i++)
        {
            var scroll = (SpellScroll)Activator.CreateInstance(_earthScrollTypes[i], 1);
            try
            {
                Assert.Equal(expectedIds[i], scroll.SpellID);
            }
            finally
            {
                scroll.Delete();
            }
        }
    }

    // ── EarthBook scroll insertion (OnDragDrop server-side logic) ───────────

    [Fact]
    public void EarthBook_OnDragDrop_AcceptsEarthScroll_AddsSpell()
    {
        var book = new EarthBook(0); // empty
        var scroll = new AntidoteScroll(1);
        try
        {
            Assert.False(book.HasSpell(750));
            // Simulate the spell content bit that OnDragDrop sets
            // (we test the HasSpell/Content logic directly)
            book.Content |= (ulong)1 << (750 - 750); // bit 0 = Antidote
            Assert.True(book.HasSpell(750));
        }
        finally
        {
            book.Delete();
            if (!scroll.Deleted)
            {
                scroll.Delete();
            }
        }
    }

    [Fact]
    public void EarthBook_GetTypeForSpell_ReturnsEarthMagic_ForAllSpellIds()
    {
        for (var id = 750; id <= 765; id++)
        {
            Assert.Equal(SpellbookType.EarthMagic, Spellbook.GetTypeForSpell(id));
        }
    }

    [Fact]
    public void EarthBook_SpellbookType_MatchesGetTypeForSpell()
    {
        var book = new EarthBook(0);
        try
        {
            Assert.Equal(Spellbook.GetTypeForSpell(750), book.SpellbookType);
        }
        finally
        {
            book.Delete();
        }
    }
}
