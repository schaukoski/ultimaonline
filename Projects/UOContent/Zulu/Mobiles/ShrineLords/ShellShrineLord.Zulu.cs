using System.Collections.Generic;
using ModernUO.Serialization;
using Server.Gumps;
using Server.Items;

namespace Server.Mobiles;

// ─────────────────────────────────────────────────────────────────────────────
// Zulu Hotel — Shell Shrine Lord.
//
// Invulnerable NPC that accepts any of the 9 collectible FishShells. When a
// player drops a shell, the shrine lord searches the backpack (sub-bags up
// to 3 levels deep) for all 9 kinds. If complete, it opens the reward gump.
// Shells are NEVER consumed on drop — they are consumed only when the player
// picks a reward in the gump (so dying or closing the gump preserves the
// collection).
//
// Mirrors the ElementalShrineLord (pentagram) pattern.
// ─────────────────────────────────────────────────────────────────────────────

[SerializationGenerator(0, false)]
public partial class ShellShrineLord : BaseCreature
{
    [Constructible]
    public ShellShrineLord() : base(AIType.AI_Mage)
    {
        Body = 0x190; // human male
        Hue = 0x0489; // deep-sea blue

        SetStr(210);
        SetDex(210);
        SetInt(210);
        SetHits(200);
        SetMana(200);
        SetStam(200);

        SetSkill(SkillName.Magery, 90.0);
        SetSkill(SkillName.Meditation, 90.0);
        SetSkill(SkillName.Fishing, 120.0);
        SetSkill(SkillName.MagicResist, 90.0);

        Fame = 0;
        Karma = 10000;
        VirtualArmor = 50;

        Blessed = true;
    }

    public override string DefaultName => "The Shell Shrine Lord";

    public override bool IsInvulnerable => true;
    public override bool CanTeach       => false;

    // ── Drop handler ─────────────────────────────────────────────────────────
    public override bool OnDragDrop(Mobile from, Item dropped)
    {
        if (dropped is not FishShell shell)
        {
            Say("I have no use for that. Bring me fishing shells!");
            return false;
        }

        var pack = from.Backpack;
        if (pack == null)
        {
            return false;
        }

        // Search backpack (sub-bags up to 3 levels deep) for all shell kinds.
        var found = FishShellInfo.FindShells(pack);

        // Count the dropped piece too (not yet in pack).
        if (!found.ContainsKey(shell.Kind))
        {
            found[shell.Kind] = shell;
        }

        if (found.Count >= FishShellInfo.ShellCount)
        {
            Say("You have gathered all nine shells! Choose your reward.");
            from.SendGump(new ShellShrineLordRewardGump(from, this));
        }
        else
        {
            var missing = new List<string>();
            for (var i = 1; i <= FishShellInfo.ShellCount; i++)
            {
                var kind = (FishShellKind)i;
                if (!found.ContainsKey(kind))
                {
                    missing.Add(FishShellInfo.GetName(kind));
                }
            }

            Say($"Good, a {FishShellInfo.GetName(shell.Kind)}! You still need: {string.Join(", ", missing)}.");
        }

        // Always return false — never consume the piece on drop.
        return false;
    }

    public override void OnDoubleClick(Mobile from)
    {
        if (!from.InRange(Location, 4))
        {
            from.SendLocalizedMessage(500446); // That is too far away.
            return;
        }

        Say("Bring me all 9 collectible fishing shells, and I shall reward you handsomely.");
    }
}
