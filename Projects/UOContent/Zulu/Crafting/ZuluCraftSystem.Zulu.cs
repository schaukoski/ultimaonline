using System;
using System.Collections.Generic;
using Server.Items;

namespace Server.Zulu.Crafting
{
    public enum ZuluCraftECA
    {
        ChanceMinusSixty,
        FiftyPercentChanceMinusTenPercent,
        ChanceMinusSixtyToFortyFive
    }

    public abstract class ZuluCraftSystem
    {
        private readonly Dictionary<Mobile, ZuluCraftContext> m_ContextTable = new();

        public ZuluCraftSystem(int minCraftEffect, int maxCraftEffect, double delay)
        {
            MinCraftEffect = minCraftEffect;
            MaxCraftEffect = maxCraftEffect;
            Delay = delay;

            CraftItems = new List<ZuluCraftItem>();
            CraftGroups = new List<ZuluCraftGroup>();
            CraftSubRes = new ZuluCraftSubResCol();
            CraftSubRes2 = new ZuluCraftSubResCol();

            InitCraftList();
        }

        public int MinCraftEffect { get; }

        public int MaxCraftEffect { get; }

        public double Delay { get; }

        public List<ZuluCraftItem> CraftItems { get; }

        public List<ZuluCraftGroup> CraftGroups { get; }

        public ZuluCraftSubResCol CraftSubRes { get; }

        public ZuluCraftSubResCol CraftSubRes2 { get; }

        public abstract SkillName MainSkill { get; }

        public virtual string GumpTitle => string.Empty;

        public virtual ZuluCraftECA ECA => ZuluCraftECA.ChanceMinusSixty;

        public bool Resmelt { get; set; }

        public bool Repair { get; set; }

        public bool MarkOption { get; set; }

        public bool CanEnhance { get; set; }

        public abstract double GetChanceAtMin(ZuluCraftItem item);

        public virtual bool RetainsColorFrom(ZuluCraftItem item, Type type) => false;

        public ZuluCraftContext GetContext(Mobile m)
        {
            if (m == null)
            {
                return null;
            }

            if (m.Deleted)
            {
                m_ContextTable.Remove(m);
                return null;
            }

            if (!m_ContextTable.TryGetValue(m, out var c))
            {
                m_ContextTable[m] = c = new ZuluCraftContext();
            }

            return c;
        }

        public void OnMade(Mobile m, ZuluCraftItem item)
        {
            GetContext(m)?.OnMade(item);
        }

        // Phase E: enhance/repair-on-failure semantics. For now keep vanilla default behavior.
        public virtual bool ConsumeOnFailure(Mobile from, Type resourceType, ZuluCraftItem craftItem) => true;

        public void CreateItem(Mobile from, Type type, int materialId, BaseTool tool, ZuluCraftItem realCraftItem)
        {
            // Verify if the type is in the list of the craftable items
            if (CraftItems.SearchFor(type) != null)
            {
                realCraftItem.Craft(from, this, materialId, tool);
            }
        }

        public int AddCraft(
            Type typeItem, string group, string name, double minSkill, double maxSkill,
            Type typeRes, string nameRes, int amount
        ) => AddCraft(typeItem, group, name, MainSkill, minSkill, maxSkill, typeRes, nameRes, amount, null);

        // Zulu-simplified overload: single resource, no max-skill, no cliloc, no message strings.
        // Used by ZuluBlacksmithy and other Zulu craft systems where the resource Type is irrelevant
        // (the actual MaterialId is selected at runtime via the gump). The Resources[0].Amount slot
        // is what the rest of the pipeline reads.
        public int AddCraft(Type typeItem, string group, string name, double minSkill, int ingotsRequired)
            => AddCraft(typeItem, group, name, MainSkill, minSkill, minSkill + 50.0, typeof(Server.Items.ZuluIngot), name, ingotsRequired, null);

        public int AddCraft(
            Type typeItem, string group, string name, int itemId, double minSkill, double maxSkill,
            Type typeRes, string nameRes, int amount
        ) => AddCraft(typeItem, group, name, itemId, MainSkill, minSkill, maxSkill, typeRes, nameRes, amount, null);

        public int AddCraft(
            Type typeItem, string group, string name, double minSkill, double maxSkill,
            Type typeRes, string nameRes, int amount, string message
        ) => AddCraft(typeItem, group, name, MainSkill, minSkill, maxSkill, typeRes, nameRes, amount, message);

        public int AddCraft(
            Type typeItem, string group, string name, int itemId, double minSkill, double maxSkill,
            Type typeRes, string nameRes, int amount, string message
        ) => AddCraft(typeItem, group, name, itemId, MainSkill, minSkill, maxSkill, typeRes, nameRes, amount, message);

        public int AddCraft(
            Type typeItem, string group, string name, SkillName skillToMake, double minSkill,
            double maxSkill, Type typeRes, string nameRes, int amount
        ) => AddCraft(typeItem, group, name, skillToMake, minSkill, maxSkill, typeRes, nameRes, amount, null);

        public int AddCraft(
            Type typeItem, string group, string name, int itemId, SkillName skillToMake, double minSkill,
            double maxSkill, Type typeRes, string nameRes, int amount
        ) => AddCraft(typeItem, group, name, itemId, skillToMake, minSkill, maxSkill, typeRes, nameRes, amount, null);

        public int AddCraft(
            Type typeItem, string group, string name, SkillName skillToMake, double minSkill,
            double maxSkill, Type typeRes, string nameRes, int amount, string message
        )
        {
            var craftItem = new ZuluCraftItem(typeItem, group, name);
            craftItem.AddRes(typeRes, nameRes, amount, message);
            craftItem.AddSkill(skillToMake, minSkill, maxSkill);

            DoGroup(group, craftItem);
            CraftItems.Add(craftItem);
            return CraftItems.Count - 1;
        }

        public int AddCraft(
            Type typeItem, string group, string name, int itemId, SkillName skillToMake, double minSkill,
            double maxSkill, Type typeRes, string nameRes, int amount, string message
        )
        {
            var craftItem = new ZuluCraftItem(typeItem, group, name, itemId);
            craftItem.AddRes(typeRes, nameRes, amount, message);
            craftItem.AddSkill(skillToMake, minSkill, maxSkill);

            DoGroup(group, craftItem);
            CraftItems.Add(craftItem);
            return CraftItems.Count - 1;
        }

        private void DoGroup(string groupName, ZuluCraftItem craftItem)
        {
            var index = CraftGroups.SearchFor(groupName);

            if (index == -1)
            {
                var craftGroup = new ZuluCraftGroup(groupName);
                craftGroup.AddCraftItem(craftItem);
                CraftGroups.Add(craftGroup);
            }
            else
            {
                CraftGroups[index].AddCraftItem(craftItem);
            }
        }

        public void SetItemHue(int index, int hue)
        {
            CraftItems[index].ItemHue = hue;
        }

        public void SetUseAllRes(int index, bool useAll)
        {
            CraftItems[index].UseAllRes = useAll;
        }

        public void SetNeedHeat(int index, bool needHeat)
        {
            CraftItems[index].NeedHeat = needHeat;
        }

        public void SetNeedOven(int index, bool needOven)
        {
            CraftItems[index].NeedOven = needOven;
        }

        public void SetNeedMill(int index, bool needMill)
        {
            CraftItems[index].NeedMill = needMill;
        }

        public void AddRes(int index, Type type, string name, int amount, string message = null)
        {
            CraftItems[index].AddRes(type, name, amount, message);
        }

        public void AddSkill(int index, SkillName skillToMake, double minSkill, double maxSkill)
        {
            CraftItems[index].AddSkill(skillToMake, minSkill, maxSkill);
        }

        public void SetUseSubRes2(int index, bool val)
        {
            CraftItems[index].UseSubRes2 = val;
        }

        public void ForceNonExceptional(int index)
        {
            CraftItems[index].ForceNonExceptional = true;
        }

        public void SetSubRes(string name)
        {
            CraftSubRes.NameString = name;
            CraftSubRes.Init = true;
        }

        public void AddSubRes(int materialId, string message = null)
        {
            CraftSubRes.Add(new ZuluCraftSubRes(materialId, message));
        }

        public void SetSubRes2(string name)
        {
            CraftSubRes2.NameString = name;
            CraftSubRes2.Init = true;
        }

        public void AddSubRes2(int materialId, string message = null)
        {
            CraftSubRes2.Add(new ZuluCraftSubRes(materialId, message));
        }

        public abstract void InitCraftList();

        public abstract void PlayCraftEffect(Mobile from);

        public abstract int PlayEndingEffect(
            Mobile from, bool failed, bool lostMaterial, bool toolBroken, int quality,
            bool makersMark, ZuluCraftItem item
        );

        public abstract int CanCraft(Mobile from, BaseTool tool, Type itemType);

        // Phase E: Repair / Enhance.
        public virtual void OnRepair(Mobile from, BaseTool tool, Item deed, Item itemToRepair) =>
            throw new NotImplementedException("Phase E: Repair/Enhance");

        public virtual void OnEnhance(Mobile from, BaseTool tool, Item itemToEnhance) =>
            throw new NotImplementedException("Phase E: Repair/Enhance");
    }
}
