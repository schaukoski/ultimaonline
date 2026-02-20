using System;
using System.Collections.Generic;
using System.Text;

namespace Server;

public class MageClass : ZuluClassBase
{
    public override string Name => "Mage";

    public override IReadOnlyList<SkillName> RequiredSkills => new List<SkillName> {
        SkillName.Alchemy,
        SkillName.ItemID,
        SkillName.EvalInt,
        SkillName.Inscribe,
        SkillName.MagicResist,
        SkillName.Meditation,
        SkillName.Magery,
        SkillName.SpiritSpeak,
    };

}
