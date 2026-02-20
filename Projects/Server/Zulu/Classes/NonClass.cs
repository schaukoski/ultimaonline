using System;
using System.Collections.Generic;
using System.Text;

namespace Server;

public class NonClass : ZuluClassBase
{
    public override string Name => "None";

    public override IReadOnlyList<SkillName> RequiredSkills => new List<SkillName>();
}
