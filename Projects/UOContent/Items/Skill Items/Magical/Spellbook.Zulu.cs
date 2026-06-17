namespace Server.Items;

public partial class Spellbook
{
    public bool CanEquipZulu(Mobile from) => ZuluClassRestrictions.IsEquipAllowed(from, this);
}
