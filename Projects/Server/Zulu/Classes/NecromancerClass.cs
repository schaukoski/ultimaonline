using System;
using System.Collections.Generic;
using System.Text;

namespace Server;

public class NecromancerClass : ZuluClassBase
{
    public override string Name => "Necromancer";

    public override IReadOnlyList<SkillName> RequiredSkills => new List<SkillName> {
        SkillName.Wrestling,
        SkillName.ItemID,
        SkillName.EvalInt,
        SkillName.Inscribe,
        SkillName.MagicResist,
        SkillName.Meditation,
        SkillName.Necromancy,
        SkillName.SpiritSpeak,
    };

}
