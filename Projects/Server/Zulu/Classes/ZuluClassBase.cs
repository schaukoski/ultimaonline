using System;
using System.Collections.Generic;
using System.Text;

namespace Server;

public abstract class ZuluClassBase : IZuluClass
{
    public abstract string Name { get; }

    public abstract IReadOnlyList<SkillName> RequiredSkills  {get; }
}
