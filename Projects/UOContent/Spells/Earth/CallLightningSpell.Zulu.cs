using System;
using Server.Items;
using Server.Targeting;

namespace Server.Spells.Earth;

// Spell 754 — Call Lightning (Glaoch Ar Dhia)
// Circle 1 | Mana: 10 | Skill: 80 | Element: Air
// Single target air/lightning damage.
public class CallLightningSpell : EarthSpell, ITargetingSpell<Mobile>
{
    private static readonly SpellInfo _info = new(
        "Call Lightning",
        "Batida do Deus",
        -1,
        9002,
        typeof(WormsHeart),
        typeof(PigIron),
        typeof(Bone)
    );

    public CallLightningSpell(Mobile caster, Item scroll = null) : base(caster, scroll, _info)
    {
    }

    public override TimeSpan CastDelayBase => TimeSpan.FromSeconds(2.0);
    public override double RequiredSkill => 80.0;
    public override int RequiredMana => 10;

    public void Target(Mobile m)
    {
        if (!CheckHSequence(m))
        {
            return;
        }

        SpellHelper.Turn(Caster, m);
        SpellHelper.CheckReflect((int)SpellCircle.Second, Caster, ref m);

        var damage = GetEarthDamage(12, 24);

        Effects.SendBoltEffect(m, true, 0);
        Effects.SendBoltEffect(m, true, 0);
        m.PlaySound(0x207);
        m.PlaySound(0x207);

        SpellHelper.ZuluDamage(this, m, damage, 0, 0, 0, 0, 100, 0, 0, 0); // air
    }

    public override void OnCast()
    {
        Caster.Target = new SpellTarget<Mobile>(this, TargetFlags.Harmful);
    }
}
