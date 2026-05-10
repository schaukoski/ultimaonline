using System.Collections.Generic;
using Server;
using Server.Items;
using Xunit;

namespace UOContent.Tests;

// ─────────────────────────────────────────────────────────────────────────────
// Zulu Hotel — Fish Shell collection system unit tests.
//
// Covers: FishShellInfo.FindShells (depth search, duplicates, early-exit),
//         shell item properties, and reward-gump consume-one-per-kind semantics.
//
// Tests that require Item creation use [Collection("Sequential UOContent Tests")]
// because Item constructors allocate a Serial from the World (single-threaded).
// ─────────────────────────────────────────────────────────────────────────────

// ── Pure static-info tests (no World needed) ─────────────────────────────────

public class FishShellInfoStaticTests
{
    [Fact]
    public void ShellCount_Is9()
    {
        Assert.Equal(9, FishShellInfo.ShellCount);
    }

    [Theory]
    [InlineData(FishShellKind.Aquaria,          "Aquaria Shell")]
    [InlineData(FishShellKind.Capricornia,       "Capricornia Shell")]
    [InlineData(FishShellKind.SeaNymph,          "Sea Nymph Shell")]
    [InlineData(FishShellKind.NeptunesNautilus,  "Neptune's Nautilus")]
    [InlineData(FishShellKind.SandDollar,        "Sea Shore Sand Dollar")]
    [InlineData(FishShellKind.Divinia,           "Divinia Shell")]
    [InlineData(FishShellKind.Mermaid,           "Mermaid Shell")]
    [InlineData(FishShellKind.OceanOdyssey,      "Ocean Odyssey")]
    [InlineData(FishShellKind.Talimari,          "Talimari Shell")]
    public void GetName_ReturnsCorrectName(FishShellKind kind, string expected)
    {
        Assert.Equal(expected, FishShellInfo.GetName(kind));
    }

    [Theory]
    [InlineData(FishShellKind.Aquaria)]
    [InlineData(FishShellKind.Capricornia)]
    [InlineData(FishShellKind.SeaNymph)]
    [InlineData(FishShellKind.NeptunesNautilus)]
    [InlineData(FishShellKind.SandDollar)]
    [InlineData(FishShellKind.Divinia)]
    [InlineData(FishShellKind.Mermaid)]
    [InlineData(FishShellKind.OceanOdyssey)]
    [InlineData(FishShellKind.Talimari)]
    public void GetGraphic_NonZero_ForAllKinds(FishShellKind kind)
    {
        Assert.NotEqual(0, FishShellInfo.GetGraphic(kind));
    }

    [Theory]
    [InlineData(FishShellKind.Aquaria)]
    [InlineData(FishShellKind.Capricornia)]
    [InlineData(FishShellKind.SeaNymph)]
    [InlineData(FishShellKind.NeptunesNautilus)]
    [InlineData(FishShellKind.SandDollar)]
    [InlineData(FishShellKind.Divinia)]
    [InlineData(FishShellKind.Mermaid)]
    [InlineData(FishShellKind.OceanOdyssey)]
    [InlineData(FishShellKind.Talimari)]
    public void GetHue_NonZero_ForAllKinds(FishShellKind kind)
    {
        Assert.NotEqual(0, FishShellInfo.GetHue(kind));
    }

    [Fact]
    public void FindShells_NullContainer_ReturnsEmptyDictionary()
    {
        // Must not throw; returns empty.
        var result = FishShellInfo.FindShells(null!);
        Assert.Empty(result);
    }
}

// ── Tests that create Item/Container objects (World required) ─────────────────

[Collection("Sequential UOContent Tests")]
public class FishShellFindTests
{
    // ── Helpers ──────────────────────────────────────────────────────────────

    private static Backpack CreateBackpack() => new();

    private static FishShell Shell(FishShellKind kind) => new(kind);

    private static void AddAllShells(Container bag)
    {
        foreach (FishShellKind kind in System.Enum.GetValues<FishShellKind>())
        {
            bag.AddItem(Shell(kind));
        }
    }

    private static void CleanUp(params Item[] items)
    {
        foreach (var item in items)
        {
            if (!item.Deleted)
            {
                item.Delete();
            }
        }
    }

    // ── FindShells — top-level bag ────────────────────────────────────────────

    [Fact]
    public void FindShells_AllPresent_TopLevel_ReturnsAll9()
    {
        var bag = CreateBackpack();
        try
        {
            AddAllShells(bag);
            var result = FishShellInfo.FindShells(bag);
            Assert.Equal(FishShellInfo.ShellCount, result.Count);
        }
        finally
        {
            bag.Delete();
        }
    }

    [Fact]
    public void FindShells_EmptyBag_ReturnsEmpty()
    {
        var bag = CreateBackpack();
        try
        {
            var result = FishShellInfo.FindShells(bag);
            Assert.Empty(result);
        }
        finally
        {
            bag.Delete();
        }
    }

    [Fact]
    public void FindShells_PartialSet_ReturnsCorrectCount()
    {
        var bag = CreateBackpack();
        try
        {
            bag.AddItem(Shell(FishShellKind.Aquaria));
            bag.AddItem(Shell(FishShellKind.Divinia));
            bag.AddItem(Shell(FishShellKind.Talimari));

            var result = FishShellInfo.FindShells(bag);

            Assert.Equal(3, result.Count);
            Assert.True(result.ContainsKey(FishShellKind.Aquaria));
            Assert.True(result.ContainsKey(FishShellKind.Divinia));
            Assert.True(result.ContainsKey(FishShellKind.Talimari));
        }
        finally
        {
            bag.Delete();
        }
    }

    // ── FindShells — duplicate handling ──────────────────────────────────────

    [Fact]
    public void FindShells_DuplicateKind_ReturnsOnlyOnePerKind()
    {
        var bag = CreateBackpack();
        try
        {
            // Add 3 Aquaria shells and 1 of every other kind.
            bag.AddItem(Shell(FishShellKind.Aquaria));
            bag.AddItem(Shell(FishShellKind.Aquaria));
            bag.AddItem(Shell(FishShellKind.Aquaria));
            for (var k = FishShellKind.Capricornia; k <= FishShellKind.Talimari; k++)
            {
                bag.AddItem(Shell(k));
            }

            var result = FishShellInfo.FindShells(bag);

            // Still exactly 9 kinds.
            Assert.Equal(FishShellInfo.ShellCount, result.Count);
            // The dict has exactly one entry per kind.
            Assert.True(result.ContainsKey(FishShellKind.Aquaria));
        }
        finally
        {
            bag.Delete();
        }
    }

    // ── FindShells — sub-bag depth ────────────────────────────────────────────

    [Fact]
    public void FindShells_ShellsInSubBagDepth1_Found()
    {
        var bag = CreateBackpack();
        var sub = new Bag();
        try
        {
            bag.AddItem(sub);
            AddAllShells(sub);

            var result = FishShellInfo.FindShells(bag);
            Assert.Equal(FishShellInfo.ShellCount, result.Count);
        }
        finally
        {
            bag.Delete();
        }
    }

    [Fact]
    public void FindShells_ShellsInSubBagDepth2_Found()
    {
        var bag = CreateBackpack();
        var sub1 = new Bag();
        var sub2 = new Bag();
        try
        {
            bag.AddItem(sub1);
            sub1.AddItem(sub2);
            AddAllShells(sub2);

            var result = FishShellInfo.FindShells(bag);
            Assert.Equal(FishShellInfo.ShellCount, result.Count);
        }
        finally
        {
            bag.Delete();
        }
    }

    [Fact]
    public void FindShells_ShellsInSubBagDepth3_Found()
    {
        var bag = CreateBackpack();
        var sub1 = new Bag();
        var sub2 = new Bag();
        var sub3 = new Bag();
        try
        {
            bag.AddItem(sub1);
            sub1.AddItem(sub2);
            sub2.AddItem(sub3);
            AddAllShells(sub3);

            var result = FishShellInfo.FindShells(bag);
            Assert.Equal(FishShellInfo.ShellCount, result.Count);
        }
        finally
        {
            bag.Delete();
        }
    }

    [Fact]
    public void FindShells_ShellsInSubBagDepth4_NotFound()
    {
        // maxDepth=3 means depth-4 containers are NOT searched.
        var bag = CreateBackpack();
        var sub1 = new Bag();
        var sub2 = new Bag();
        var sub3 = new Bag();
        var sub4 = new Bag();
        try
        {
            bag.AddItem(sub1);
            sub1.AddItem(sub2);
            sub2.AddItem(sub3);
            sub3.AddItem(sub4);
            AddAllShells(sub4);

            var result = FishShellInfo.FindShells(bag);
            Assert.Empty(result);
        }
        finally
        {
            bag.Delete();
        }
    }

    // ── Reward-gump consume semantics ─────────────────────────────────────────

    /// <summary>
    /// Simulates what ShellShrineLordRewardGump.OnResponse does:
    /// FindShells → delete each value. Duplicates of the same kind must survive.
    /// </summary>
    [Fact]
    public void ConsumeShells_DeletesOnePerKind_PreservesDuplicates()
    {
        var bag = CreateBackpack();
        try
        {
            // Add all 9 kinds, then a second Aquaria → 10 shells total.
            AddAllShells(bag);
            bag.AddItem(Shell(FishShellKind.Aquaria));

            var found = FishShellInfo.FindShells(bag);
            Assert.Equal(FishShellInfo.ShellCount, found.Count);

            // Simulate gump consume: delete exactly one of each kind.
            foreach (var kvp in found)
            {
                kvp.Value.Delete();
            }

            // Exactly one Aquaria must remain; all others are gone.
            var remaining = FishShellInfo.FindShells(bag);
            Assert.Single(remaining);
            Assert.True(remaining.ContainsKey(FishShellKind.Aquaria));
        }
        finally
        {
            bag.Delete();
        }
    }

    /// <summary>
    /// Re-validation guard: if shells are removed from the bag between gump
    /// open and response, FindShells returns fewer than 9 and the gump should
    /// reject. We verify the count check logic directly.
    /// </summary>
    [Fact]
    public void FindShells_AfterRemoval_CountDropsBelowThreshold()
    {
        var bag = CreateBackpack();
        try
        {
            AddAllShells(bag);
            var first = FishShellInfo.FindShells(bag);
            Assert.Equal(FishShellInfo.ShellCount, first.Count);

            // Simulate player moving a shell out of bag.
            first[FishShellKind.Aquaria].Delete();

            var second = FishShellInfo.FindShells(bag);
            Assert.True(second.Count < FishShellInfo.ShellCount);
        }
        finally
        {
            bag.Delete();
        }
    }

    // ── FishShell item properties ─────────────────────────────────────────────

    [Theory]
    [InlineData(FishShellKind.Aquaria)]
    [InlineData(FishShellKind.Capricornia)]
    [InlineData(FishShellKind.SeaNymph)]
    [InlineData(FishShellKind.NeptunesNautilus)]
    [InlineData(FishShellKind.SandDollar)]
    [InlineData(FishShellKind.Divinia)]
    [InlineData(FishShellKind.Mermaid)]
    [InlineData(FishShellKind.OceanOdyssey)]
    [InlineData(FishShellKind.Talimari)]
    public void FishShell_Constructor_SetsKindAndProperties(FishShellKind kind)
    {
        var shell = Shell(kind);
        try
        {
            Assert.Equal(kind, shell.Kind);
            Assert.Equal(FishShellInfo.GetName(kind), shell.Name);
            Assert.Equal(FishShellInfo.GetHue(kind), shell.Hue);
            Assert.Equal(FishShellInfo.GetGraphic(kind), shell.ItemID);
            Assert.Equal(1.0, shell.Weight);
        }
        finally
        {
            shell.Delete();
        }
    }
}
