using System;
using System.Collections.Generic;
using System.Text;

namespace Server;

public class CrafterClass : ZuluClassBase
{
    public override string Name => "Crafter";

    public override IReadOnlyList<SkillName> RequiredSkills => new List<SkillName> {
        SkillName.Tinkering,
        SkillName.ArmsLore,
        SkillName.Fletching,
        SkillName.Tailoring,
        SkillName.Mining,
        SkillName.Lumberjacking,
        SkillName.Carpentry,
        SkillName.Blacksmith,
    };

}
