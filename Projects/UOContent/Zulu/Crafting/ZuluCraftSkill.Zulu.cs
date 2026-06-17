namespace Server.Zulu.Crafting;

public class ZuluCraftSkill
{
    public ZuluCraftSkill(SkillName skillToMake, double minSkill, double maxSkill)
    {
        SkillToMake = skillToMake;
        MinSkill = minSkill;
        MaxSkill = maxSkill;
    }

    public SkillName SkillToMake { get; }
    public double MinSkill { get; }
    public double MaxSkill { get; }
}
