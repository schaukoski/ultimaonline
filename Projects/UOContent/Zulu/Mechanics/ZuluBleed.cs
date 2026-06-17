using System;
using System.Collections.Generic;
using Server.Mobiles;
using Server.Spells;
using Server.Spells.Necromancy;

namespace Server.Items
{

    public static class ZuluBleed
    {
        private static readonly Dictionary<Mobile, Timer> _table = new();


        public static void StartBleed(Mobile attacker, Mobile defender, WorldLocation worldLocation)
        { 
            defender.PlaySound(0x133);
            defender.FixedParticles(0x377A, 244, 25, 9950, 31, 0, EffectLayer.Waist);

            BeginBleed(defender, attacker);
        }

        public static bool IsBleeding(Mobile m) => _table.ContainsKey(m);

        public static void BeginBleed(Mobile m, Mobile from)
        {
            _table.TryGetValue(m, out var timer);
            timer?.Stop();

            _table[m] = timer = new InternalTimer(from, m);
            timer.Start();
        }

        public static void DoBleed(Mobile m, Mobile from, int level)
        {
            if (m.Alive)
            {

                m.PlaySound(0x133);

                var blood = new Blood { ItemID = Utility.Random(0x122A, 5) };
                blood.MoveToWorld(m.Location, m.Map);

                ZuluModManager.SendSpecialHabilityOverHeadMessage(ZuluMod.BleedChance, from, m, level);
            }
            else
            {
                EndBleed(m, false);
            }
        }

        public static void EndBleed(Mobile m, bool message)
        {
            if (!_table.Remove(m, out var t))
            {
                return;
            }

            t.Stop();

            if (message)
            {
                m.SendLocalizedMessage(1060167); // The bleeding wounds have healed, you are no longer bleeding!
            }
        }

        private class InternalTimer : Timer
        {
            private readonly Mobile m_From;
            private readonly Mobile m_Mobile;

            public InternalTimer(Mobile from, Mobile m) : base(TimeSpan.FromSeconds(2.0), TimeSpan.FromSeconds(2.0), 5)
            {
                m_From = from;
                m_Mobile = m;
            }

            protected override void OnTick()
            {
                DoBleed(m_Mobile, m_From, 5 - Index);

                if (Index == 4)
                {
                    EndBleed(m_Mobile, true);
                }
            }
        }
    }
}
