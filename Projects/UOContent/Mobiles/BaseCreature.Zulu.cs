

namespace Server.Mobiles
{
    public partial class BaseCreature
    {


        public void SetZuluDamageType(ResistanceType type, int val)
        {
            switch (type)
            {
                case ResistanceType.Physical:
                    {
                        z_Physical_DD = val;
                        break;
                    }
                case ResistanceType.Fire:
                    {
                        z_Fire_DD = val;
                        break;
                    }
                case ResistanceType.Cold:
                    {
                        z_Water_DD = val;
                        break;
                    }
                case ResistanceType.Poison:
                    {
                        z_Poison_DD = val;
                        break;
                    }
                case ResistanceType.Energy:
                    {
                        z_Air_DD = val;
                        break;
                    }
            }
        }

        public void SetZuluResistance(ResistanceType type, int val)
        {
            switch (type)
            {
                case ResistanceType.Physical:
                    {
                        ActiveZuluModifiers[(int)ZuluMod.PhysicalProtection] = val;
                        break;
                    }
                case ResistanceType.Fire:
                    {
                        ActiveZuluModifiers[(int)ZuluMod.FireProtection] = val;
                        break;
                    }
                case ResistanceType.Cold:
                    {
                        ActiveZuluModifiers[(int)ZuluMod.WaterProtection] = val;
                        break;
                    }
                case ResistanceType.Poison:
                    {
                        ActiveZuluModifiers[(int)ZuluMod.PoisonProtection] = val;
                        break;
                    }
                case ResistanceType.Energy:
                    {
                        ActiveZuluModifiers[(int)ZuluMod.AirProtection] = val;
                        break;
                    }
            }
        }

    }

}
