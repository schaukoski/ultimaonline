

namespace Server.Mobiles
{
    public partial class BaseCreature
    {
        public void SetZuluDamageType(ResistanceType type, int val)
        {
            var element = type switch
            {
                ResistanceType.Physical => ZuluElement.Phys,
                ResistanceType.Fire     => ZuluElement.Fire,
                ResistanceType.Cold     => ZuluElement.Water,
                ResistanceType.Poison   => ZuluElement.Poison,
                ResistanceType.Energy   => ZuluElement.Air,
                _                       => (ZuluElement)(-1)
            };

            if ((int)element >= 0)
            {
                SetZuluDamageType(element, val);
            }
        }

        public void SetZuluDamageType(ZuluElement type, int val)
        {
            switch (type)
            {
                case ZuluElement.Phys:
                    {
                        z_Physical_DD = val;
                        break;
                    }
                case ZuluElement.Fire:
                    {
                        z_Fire_DD = val;
                        break;
                    }
                case ZuluElement.Water:
                    {
                        z_Water_DD = val;
                        break;
                    }
                case ZuluElement.Poison:
                    {
                        z_Poison_DD = val;
                        break;
                    }
                case ZuluElement.Air:
                    {
                        z_Air_DD = val;
                        break;
                    }
                case ZuluElement.Necro:
                    {
                        z_Necro_DD = val;
                        break;
                    }
                case ZuluElement.Holly:
                    {
                        z_Holly_DD = val;
                        break;
                    }
                case ZuluElement.Earth:
                    {
                        z_Earth_DD = val;
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
