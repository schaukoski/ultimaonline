using ModernUO.Serialization;

namespace Server.Mobiles
{
    // Zulu Hotel - Lacaio do Mordrath, the Soulbound.
    // Ele eh invocado pela MordrathSoulLinkAbility e mantem o Mordrath
    // invulneravel enquanto pelo menos 1 lacaio estiver vivo.
    // Nao persiste em saves (luta efemera): Master e nao-serializado.

    [SerializationGenerator(0, false)]
    public partial class MordrathSoulboundMinion : BaseCreature
    {
        // Master eh setado pela ability ao invocar. Nao serializado de proposito:
        // se o servidor reiniciar no meio da luta, lacaios viram mobs comuns
        // e o boss respawna limpo.
        public MordrathTheSoulbound Master { get; set; }

        [Constructible]
        public MordrathSoulboundMinion() : base(AIType.AI_Mage)
        {
            Body = 148;            // skeletal mage
            BaseSoundID = 451;
            Hue = 0x47E;           // tom roxo-fantasma para identidade visual

            SetStr(160, 180);
            SetDex(80, 100);
            SetInt(220, 260);

            // HP fixo conforme decisao: lacaios sempre com mesma HP em todas as levas.
            SetHits(450);

            SetDamage(8, 14);

            // 100% dano fisico. Nao chamar SetDamageType: no ZH redireciona
            // pra SetZuluDamageType (duplicaria z_Physical_DD).
            z_Physical_DD = 100;

            SetResistance(ResistanceType.Physical, 40, 50);
            SetResistance(ResistanceType.Fire, 30, 40);
            SetResistance(ResistanceType.Cold, 60, 70);
            SetResistance(ResistanceType.Poison, 60, 70);
            SetResistance(ResistanceType.Energy, 30, 40);

            SetSkill(SkillName.EvalInt, 80.0, 90.0);
            SetSkill(SkillName.Magery, 85.0, 95.0);
            SetSkill(SkillName.MagicResist, 90.0, 100.0);
            SetSkill(SkillName.Tactics, 85.0, 95.0);
            SetSkill(SkillName.Wrestling, 75.0, 85.0);
            SetSkill(SkillName.Necromancy, 90.0, 100.0);
            SetSkill(SkillName.SpiritSpeak, 90.0, 100.0);

            Fame = 8000;
            Karma = -8000;
            VirtualArmor = 40;
        }

        public override string CorpseName => "a soulbound minion's corpse";
        public override string DefaultName => "a soulbound minion";

        public override OppositionGroup OppositionGroup => OppositionGroup.FeyAndUndead;
        public override bool BleedImmune => true;
        public override Poison PoisonImmune => Poison.Greater;
        public override bool AlwaysMurderer => true;

        // Sem loot: lacaios sao puramente mecanica de fase.
        public override void GenerateLoot()
        {
        }

        public override void OnAfterDelete()
        {
            // Notifica boss para atualizar a contagem de lacaios vivos
            // e disparar o efeito de "corrente quebrando".
            Master?.OnMinionDied(this);
            Master = null;

            base.OnAfterDelete();
        }
    }
}
