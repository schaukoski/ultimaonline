using System;
using System.Collections.Generic;
using System.Text;

namespace Server;

public class ThiefClass : ZuluClassBase
{
    public override string Name => "Thief";

    public override IReadOnlyList<SkillName> RequiredSkills => new List<SkillName> {
        SkillName.Hiding,
        SkillName.Stealth,
        SkillName.Stealing,
        SkillName.DetectHidden,
        SkillName.RemoveTrap,
        SkillName.Poisoning,
        SkillName.Lockpicking,
        SkillName.Snooping,
    };

}
