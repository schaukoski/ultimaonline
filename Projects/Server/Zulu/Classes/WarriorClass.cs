using System;
using System.Collections.Generic;
using System.Text;

namespace Server;

public class WarriorClass : ZuluClassBase
{
    public override string Name => "Warrior";

    public override IReadOnlyList<SkillName> RequiredSkills => new List<SkillName> {
        SkillName.Wrestling,
        SkillName.Tactics,
        SkillName.Healing,
        SkillName.Anatomy,
        SkillName.Swords,
        SkillName.Macing,
        SkillName.Fencing,
        SkillName.Parry,
    };

}
