using Server.Spells.Earth;

namespace Server.Spells;

// Zulu Hotel — registers all Earth Magic spells (IDs 750-765).
// Discovered automatically via Configure() convention — no changes to Initializer.cs needed.
public static class EarthInitializer
{
    public static void Configure()
    {
        SpellRegistry.Register(750, typeof(AntidoteSpell));
        SpellRegistry.Register(751, typeof(OwlSightSpell));
        SpellRegistry.Register(752, typeof(ShiftingEarthSpell));
        SpellRegistry.Register(753, typeof(SummonMammalsSpell));
        SpellRegistry.Register(754, typeof(CallLightningSpell));
        SpellRegistry.Register(755, typeof(EarthBlessingSpell));
        SpellRegistry.Register(756, typeof(EarthPortalSpell));
        SpellRegistry.Register(757, typeof(NaturesTouchSpell));
        SpellRegistry.Register(758, typeof(GustOfAirSpell));
        SpellRegistry.Register(759, typeof(RisingFireSpell));
        SpellRegistry.Register(760, typeof(ShapeshiftSpell));
        SpellRegistry.Register(761, typeof(IceStrikeSpell));
        SpellRegistry.Register(762, typeof(EarthSpiritSpell));
        SpellRegistry.Register(763, typeof(FlameSpiritSpell));
        SpellRegistry.Register(764, typeof(StormSpiritSpell));
        SpellRegistry.Register(765, typeof(WaterSpiritSpell));
    }
}
