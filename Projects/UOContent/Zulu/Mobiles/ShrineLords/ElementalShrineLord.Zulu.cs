using System;
using System.Collections.Generic;
using ModernUO.Serialization;
using Server.Gumps;
using Server.Items;

namespace Server.Mobiles;

/// <summary>
/// Base Shrine Lord NPC for the pentagram collection system.
/// Invulnerable elemental NPC — when a player drops a matching pentagram piece,
/// the piece is NOT consumed immediately. Instead the NPC checks if the player
/// has all 9 pieces (searching sub-bags up to 3 levels deep).
/// If complete, opens the reward gump; otherwise tells the player what's missing.
/// Pieces are only consumed when the player picks a reward.
/// </summary>
[SerializationGenerator(0, false)]
public partial class ElementalShrineLord : BaseCreature
{
    [SerializableField(0)]
    private PentagramElement _element;

    [Constructible]
    public ElementalShrineLord() : this(PentagramElement.Water)
    {
    }

    public ElementalShrineLord(PentagramElement element) : base(AIType.AI_Mage)
    {
        _element = element;

        Body = PentagramElementInfo.GetShrineLordBody(element);
        Hue = PentagramElementInfo.GetShrineLordHue(element);

        SetStr(210);
        SetDex(210);
        SetInt(210);
        SetHits(200);
        SetMana(200);
        SetStam(200);

        SetSkill(SkillName.Magery, 90.0);
        SetSkill(SkillName.Meditation, 90.0);
        SetSkill(SkillName.Inscribe, 50.0);
        SetSkill(SkillName.Macing, 50.0);
        SetSkill(SkillName.Tactics, 50.0);
        SetSkill(SkillName.MagicResist, 90.0);

        Fame = 0;
        Karma = 10000;
        VirtualArmor = 50;

        Blessed = true;
    }

    public override string DefaultName =>
        $"The {PentagramElementInfo.GetName(_element)} Element Shrine Lord";

    public override bool IsInvulnerable => true;
    public override bool CanTeach => false;

    // ── Drop handler ─────────────────────────────────────────────────────────
    public override bool OnDragDrop(Mobile from, Item dropped)
    {
        if (dropped is not PentagramPiece piece)
        {
            Say("I have no use for that. Bring me pentagram pieces!");
            return false;
        }

        if (piece.Element != _element)
        {
            Say($"That is not a {PentagramElementInfo.GetName(_element)} pentagram piece.");
            return false;
        }

        var pack = from.Backpack;
        if (pack == null)
        {
            return false;
        }

        // Search for all pieces in the player's backpack (including sub-bags, 3 levels deep)
        var found = PentagramElementInfo.FindPieces(pack, _element);
        // Also account for the piece being dragged (not yet in pack)
        if (!found.ContainsKey(piece.PieceNumber))
        {
            found[piece.PieceNumber] = piece;
        }

        if (found.Count >= PentagramElementInfo.PieceCount)
        {
            Say("You have gathered all the pieces! Choose your reward.");
            from.SendGump(new ShrineLordRewardGump(from, this, _element));
        }
        else
        {
            var missing = new List<int>();
            for (var i = 1; i <= PentagramElementInfo.PieceCount; i++)
            {
                if (!found.ContainsKey(i))
                {
                    missing.Add(i);
                }
            }

            Say($"Good, piece {piece.PieceNumber}! You still need: {string.Join(", ", missing)}.");
        }

        // Always return false — never consume the piece on drop.
        // Pieces are consumed only when the player picks a reward in the gump.
        return false;
    }

    // ── Double-click ─────────────────────────────────────────────────────────
    public override void OnDoubleClick(Mobile from)
    {
        if (!from.InRange(Location, 4))
        {
            from.SendLocalizedMessage(500446); // That is too far away.
            return;
        }

        var name = PentagramElementInfo.GetName(_element);
        Say($"Bring me all 9 pieces of the {name} Pentagram, and I shall reward you handsomely.");
    }
}

// ── Convenience subclasses (each element gets a named class for [Add) ────────

[SerializationGenerator(0, false)]
public partial class WaterShrineLord : ElementalShrineLord
{
    [Constructible]
    public WaterShrineLord() : base(PentagramElement.Water) { }
}

[SerializationGenerator(0, false)]
public partial class EarthShrineLord : ElementalShrineLord
{
    [Constructible]
    public EarthShrineLord() : base(PentagramElement.Earth) { }
}

[SerializationGenerator(0, false)]
public partial class AirShrineLord : ElementalShrineLord
{
    [Constructible]
    public AirShrineLord() : base(PentagramElement.Air) { }
}

[SerializationGenerator(0, false)]
public partial class FireShrineLord : ElementalShrineLord
{
    [Constructible]
    public FireShrineLord() : base(PentagramElement.Fire) { }
}

[SerializationGenerator(0, false)]
public partial class ShadowShrineLord : ElementalShrineLord
{
    [Constructible]
    public ShadowShrineLord() : base(PentagramElement.Shadow) { }
}

[SerializationGenerator(0, false)]
public partial class PoisonShrineLord : ElementalShrineLord
{
    [Constructible]
    public PoisonShrineLord() : base(PentagramElement.Poison) { }
}
