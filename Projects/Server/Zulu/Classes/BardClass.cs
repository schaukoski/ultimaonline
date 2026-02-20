using System;
using System.Collections.Generic;
using System.Text;

namespace Server;

public class BardClass : ZuluClassBase
{
    public override string Name => "Bard";

    public override IReadOnlyList<SkillName> RequiredSkills => new List<SkillName> {
        SkillName.Provocation,
        SkillName.Musicianship,
        SkillName.Herding,
        SkillName.Discordance,
        SkillName.TasteID,
        SkillName.Peacemaking,
        SkillName.Cartography,
        SkillName.Begging,
    };

}
