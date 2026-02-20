using System;
using System.Collections.Generic;
using System.Text;

namespace Server;

public interface IZuluClass
{
    string Name { get; }

    IReadOnlyList<SkillName> RequiredSkills { get; }

    
}
