using System;
using ModernUO.Serialization;

namespace Server.Items;

// ── Water: War Fork ──────────────────────────────────────────────────────────
// POL: graphic 0x1404, Fencing, 4d6+25 dmg, speed 45, maxhp 70
[Flippable(0x1405, 0x1404)]
[SerializationGenerator(0, false)]
public partial class WaterElementWarFork : BaseSpear
{
    [Constructible]
    public WaterElementWarFork() : base(0x1405)
    {
        Name = "War Fork of the Water Element";
        Hue = 1167;
    }

    public override int OldMinDamage => 29;
    public override int OldMaxDamage => 49;
    public override int OldSpeed => 45;
    public override int OldStrengthReq => 100;
    public override int InitMinHits => 70;
    public override int InitMaxHits => 70;
    public override int AosMinDamage => 29;
    public override int AosMaxDamage => 49;
    public override int AosStrengthReq => 100;
    public override WeaponAnimation DefAnimation => WeaponAnimation.Pierce1H;
}

// ── Earth: War Hammer ────────────────────────────────────────────────────────
// POL: graphic 0x1439, Mace, 4d6+30 dmg, speed 32, maxhp 110
[Flippable(0x1439, 0x1438)]
[SerializationGenerator(0, false)]
public partial class EarthElementWarHammer : BaseBashing
{
    [Constructible]
    public EarthElementWarHammer() : base(0x1439)
    {
        Name = "War Hammer of the Earth Element";
        Hue = 1538;
    }

    public override int OldMinDamage => 34;
    public override int OldMaxDamage => 54;
    public override int OldSpeed => 32;
    public override int OldStrengthReq => 110;
    public override int InitMinHits => 110;
    public override int InitMaxHits => 110;
    public override int AosMinDamage => 34;
    public override int AosMaxDamage => 54;
    public override int AosStrengthReq => 110;
    public override WeaponAnimation DefAnimation => WeaponAnimation.Bash2H;
}

// ── Air: Bow ─────────────────────────────────────────────────────────────────
// POL: graphic 0x13B2, Archery, 4d4+20 dmg, speed 55, maxhp 65, 2-handed
[Flippable(0x13B2, 0x13B1)]
[SerializationGenerator(0, false)]
public partial class AirElementBow : BaseRanged
{
    [Constructible]
    public AirElementBow() : base(0x13B2)
    {
        Name = "Bow of the Air Element";
        Hue = 1161;
    }

    public override int EffectID => 0xF42;
    public override Type AmmoType => typeof(Arrow);
    public override Item Ammo => new Arrow();
    public override int OldMinDamage => 24;
    public override int OldMaxDamage => 36;
    public override int OldSpeed => 55;
    public override int OldStrengthReq => 60;
    public override int InitMinHits => 65;
    public override int InitMaxHits => 65;
    public override int AosMinDamage => 24;
    public override int AosMaxDamage => 36;
    public override int AosStrengthReq => 60;
    public override float MlSpeed => 4.25f;
    public override int DefMaxRange => 10;
    public override WeaponAnimation DefAnimation => WeaponAnimation.ShootBow;
}

// ── Fire: Katana ─────────────────────────────────────────────────────────────
// POL: graphic 0x13FE, Swords, 1d16+25 dmg, speed 58, maxhp 90
// CProp: ChanceOfEffect i30, EffectCircle i5, HitWithSpell i18 (Flamestrike on hit)
[Flippable(0x13FF, 0x13FE)]
[SerializationGenerator(0, false)]
public partial class FireElementKatana : BaseSword
{
    [Constructible]
    public FireElementKatana() : base(0x13FF)
    {
        Name = "Katana of the Fire Element";
        Hue = 139;
    }

    public override int OldMinDamage => 26;
    public override int OldMaxDamage => 41;
    public override int OldSpeed => 58;
    public override int OldStrengthReq => 100;
    public override int InitMinHits => 90;
    public override int InitMaxHits => 90;
    public override int AosMinDamage => 26;
    public override int AosMaxDamage => 41;
    public override int AosStrengthReq => 100;
    public override WeaponAnimation DefAnimation => WeaponAnimation.Slash1H;
}

// ── Shadow: Pitchfork ────────────────────────────────────────────────────────
// POL: graphic 0x0E87, Fencing, 5d4+28 dmg, speed 50, maxhp 70, 2-handed
[SerializationGenerator(0, false)]
public partial class ShadowElementPitchfork : BaseSpear
{
    [Constructible]
    public ShadowElementPitchfork() : base(0x0E87)
    {
        Name = "Pitchfork of the Shadow Element";
        Hue = 1157;
        Layer = Layer.TwoHanded;
    }

    public override int OldMinDamage => 33;
    public override int OldMaxDamage => 48;
    public override int OldSpeed => 50;
    public override int OldStrengthReq => 15;
    public override int InitMinHits => 70;
    public override int InitMaxHits => 70;
    public override int AosMinDamage => 33;
    public override int AosMaxDamage => 48;
    public override int AosStrengthReq => 15;
    public override WeaponAnimation DefAnimation => WeaponAnimation.Pierce2H;
}

// ── Poison: Kryss ────────────────────────────────────────────────────────────
// POL: graphic 0x1401, Fencing, 2d4+18 dmg, speed 98, maxhp 90
// CProp: Poisonlvl i3 (applies Greater Poison on hit)
[Flippable(0x1401, 0x1400)]
[SerializationGenerator(0, false)]
public partial class PoisonElementKryss : BaseSword
{
    [Constructible]
    public PoisonElementKryss() : base(0x1401)
    {
        Name = "Kryss of the Poison Element";
        Hue = 1162;
        Poison = Poison.Greater;
        PoisonCharges = 999;
    }

    public override int OldMinDamage => 20;
    public override int OldMaxDamage => 26;
    public override int OldSpeed => 98;
    public override int OldStrengthReq => 10;
    public override int InitMinHits => 90;
    public override int InitMaxHits => 90;
    public override int AosMinDamage => 20;
    public override int AosMaxDamage => 26;
    public override int AosStrengthReq => 10;
    public override WeaponAnimation DefAnimation => WeaponAnimation.Pierce1H;
}
