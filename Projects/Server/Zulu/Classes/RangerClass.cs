using System;
using System.Collections.Generic;
using System.Text;

namespace Server;

public class RangerClass : ZuluClassBase
{
    public override string Name => "Ranger";

    public override IReadOnlyList<SkillName> RequiredSkills => new List<SkillName> {
        SkillName.Tracking,
        SkillName.Archery,
        SkillName.AnimalLore,
        SkillName.Veterinary,
        SkillName.AnimalTaming,
        SkillName.Fishing,
        SkillName.Camping,
        SkillName.Cooking,
    };

}
