using Server.Commands;
using Server.Mobiles;
using Server.Targeting;

namespace Server.Zulu.Commands;

public static class AnimalLoreGumpCommand
{
    public static void Configure()
    {
        CommandSystem.Register("AnimalLore", AccessLevel.GameMaster, OnCommand);
    }

    [Usage("AnimalLore")]
    [Description("Opens the Zulu Animal Lore gump on a targeted creature (bypasses skill check).")]
    private static void OnCommand(CommandEventArgs e)
    {
        e.Mobile.SendMessage("Target the creature to inspect.");
        e.Mobile.Target = new InternalTarget();
    }

    private class InternalTarget : Target
    {
        public InternalTarget() : base(12, false, TargetFlags.None)
        {
        }

        protected override void OnTarget(Mobile from, object targeted)
        {
            if (targeted is BaseCreature creature)
            {
                ZuluAnimalLoreGump.DisplayTo(from, creature);
            }
            else
            {
                from.SendMessage("That is not a creature.");
            }
        }
    }
}
