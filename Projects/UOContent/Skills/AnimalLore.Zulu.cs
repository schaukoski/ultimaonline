using System;
using Server.Gumps;
using Server.Mobiles;
using Server.Targeting;

namespace Server.SkillHandlers;

/// <summary>
/// Zulu Hotel override for the AnimalLore skill.
/// Replaces the vanilla callback (registered by AnimalLore.Initialize at priority 50)
/// with one that:
///   - Accepts any creature body type (animals, monsters, sea creatures)
///   - Removes the skill-level restrictions for untamed/non-tameable creatures
///   - Opens ZuluAnimalLoreGump instead of the vanilla AnimalLoreGump
///
/// Pattern for overriding skill callbacks without touching the original file:
///   [CallPriority(N)] where N > 50 (default) ensures this Initialize() runs
///   after the vanilla one, so our assignment wins.
/// </summary>
public static class AnimalLoreZulu
{
    [CallPriority(51)]
    public static void Initialize()
    {
        SkillInfo.Table[(int)SkillName.AnimalLore].Callback = OnUse;
    }

    private static TimeSpan OnUse(Mobile m)
    {
        m.Target = new ZuluInternalTarget();
        m.SendLocalizedMessage(500328); // What animal should I look at?
        return TimeSpan.FromSeconds(1.0);
    }

    private class ZuluInternalTarget : Target
    {
        public ZuluInternalTarget() : base(8, false, TargetFlags.None)
        {
        }

        protected override void OnTarget(Mobile from, object targeted)
        {
            if (!from.Alive)
            {
                from.SendLocalizedMessage(500331); // The spirits of the dead are not the province of animal lore.
                return;
            }

            if (targeted is not BaseCreature c)
            {
                from.SendLocalizedMessage(500329); // That's not an animal!
                return;
            }

            if (c.IsDeadPet)
            {
                from.SendLocalizedMessage(500331); // The spirits of the dead are not the province of animal lore.
                return;
            }

            if (!from.CheckTargetSkill(SkillName.AnimalLore, c, 0.0, 120.0))
            {
                from.SendLocalizedMessage(500334); // You can't think of anything you know offhand.
                return;
            }

            ZuluAnimalLoreGump.DisplayTo(from, c);
        }
    }
}
