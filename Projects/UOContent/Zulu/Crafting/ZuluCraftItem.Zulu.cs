using System;
using System.Collections.Generic;
using Server.Commands;
using Server.Items;
using Server.Logging;
using Server.Mobiles;

namespace Server.Zulu.Crafting
{
    public enum ZuluConsumeType
    {
        All,
        Half,
        None
    }

    public class ZuluCraftItem
    {
        private static readonly ILogger logger = LogFactory.GetLogger(typeof(ZuluCraftItem));

        private static readonly Dictionary<Type, int> _itemIds = new();

        private static readonly int[] m_HeatSources =
        {
            0x461, 0x48E,   // Sandstone oven/fireplace
            0x92B, 0x96C,   // Stone oven/fireplace
            0xDE3, 0xDE9,   // Campfire
            0xFAC, 0xFAC,   // Firepit
            0x184A, 0x184C, // Heating stand (left)
            0x184E, 0x1850, // Heating stand (right)
            0x398C, 0x399F, // Fire field
            0x2DDB, 0x2DDC, // Elven stove
            0x19AA, 0x19BB, // Veteran Reward Brazier
            0x197A, 0x19A9, // Large Forge
            0x0FB1, 0x0FB1, // Small Forge
            0x2DD8, 0x2DD8  // Elven Forge
        };

        private static readonly int[] m_Ovens =
        {
            0x461, 0x46F,  // Sandstone oven
            0x92B, 0x93F,  // Stone oven
            0x2DDB, 0x2DDC // Elven stove
        };

        private static readonly int[] m_Mills =
        {
            0x1920, 0x1921, 0x1922, 0x1923, 0x1924, 0x1295, 0x1926, 0x1928,
            0x192C, 0x192D, 0x192E, 0x129F, 0x1930, 0x1931, 0x1932, 0x1934
        };

        private static readonly Type[] m_ColoredItemTable =
        {
            typeof(BaseWeapon), typeof(BaseArmor), typeof(BaseClothing),
            typeof(BaseJewel)
        };

        private static readonly Type[] m_MarkableTable =
        {
            typeof(BaseArmor),
            typeof(BaseWeapon),
            typeof(BaseClothing),
            typeof(BaseTool)
        };

        private int _itemId;

        public ZuluCraftItem(Type type, string groupName, string name) : this(type, groupName, name, -1)
        {
        }

        public ZuluCraftItem(Type type, string groupName, string name, int itemId)
        {
            Resources = new List<ZuluCraftRes>();
            Skills = new List<ZuluCraftSkill>();

            ItemType = type;

            GroupName = groupName;
            Name = name;

            _itemId = itemId;
        }

        public bool ForceNonExceptional { get; set; }

        public bool UseSubRes2 { get; set; }

        public bool UseAllRes { get; set; }

        public bool NeedHeat { get; set; }

        public bool NeedOven { get; set; }

        public bool NeedMill { get; set; }

        public Type ItemType { get; }

        public int ItemHue { get; set; }

        public string GroupName { get; }

        public string Name { get; }

        public int ItemId => _itemId == -1 ? _itemId = ItemIDOf(ItemType) : _itemId;

        public List<ZuluCraftRes> Resources { get; }

        public List<ZuluCraftSkill> Skills { get; }

        public static int ItemIDOf(Type type)
        {
            if (_itemIds.TryGetValue(type, out var itemId))
            {
                return itemId;
            }

            if (itemId == 0)
            {
                var attrs = type.GetCustomAttributes(typeof(ZuluCraftItemIDAttribute), false);

                if (attrs.Length > 0)
                {
                    var craftItemID = (ZuluCraftItemIDAttribute)attrs[0];
                    itemId = craftItemID.ItemId;
                }
            }

            if (itemId == 0)
            {
                Item item = null;

                try
                {
                    item = type.CreateInstance<Item>();
                }
                catch
                {
                    // ignored
                }

                if (item != null)
                {
                    itemId = item.ItemID;
                    item.Delete();
                }
            }

            _itemIds[type] = itemId;

            return itemId;
        }

        public void AddRes(Type type, string name, int amount, string message = null)
        {
            var craftRes = new ZuluCraftRes(type, name, amount, message);
            Resources.Add(craftRes);
        }

        public void AddSkill(SkillName skillToMake, double minSkill, double maxSkill)
        {
            var craftSkill = new ZuluCraftSkill(skillToMake, minSkill, maxSkill);
            Skills.Add(craftSkill);
        }

        public bool IsMarkable(Type type)
        {
            if (ForceNonExceptional)
            {
                return false;
            }

            for (var i = 0; i < m_MarkableTable.Length; ++i)
            {
                if (type == m_MarkableTable[i] || type.IsSubclassOf(m_MarkableTable[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool RetainsColor(Type type)
        {
            var inItemTable = false;

            for (var i = 0; !inItemTable && i < m_ColoredItemTable.Length; ++i)
            {
                inItemTable = type == m_ColoredItemTable[i] || type.IsSubclassOf(m_ColoredItemTable[i]);
            }

            return inItemTable;
        }

        public static bool Find(Mobile from, int[] itemIDs)
        {
            var map = from.Map;

            if (map == null)
            {
                return false;
            }

            foreach (var item in map.GetItemsInRange(from.Location, 2))
            {
                if (item.Z + 16 > item.Z && item.Z + 16 > item.Z && Find(item.ItemID, itemIDs))
                {
                    return true;
                }
            }

            for (var x = -2; x <= 2; ++x)
            {
                for (var y = -2; y <= 2; ++y)
                {
                    var vx = from.X + x;
                    var vy = from.Y + y;

                    foreach (var tile in map.Tiles.GetStaticAndMultiTiles(vx, vy))
                    {
                        var z = tile.Z;
                        var id = tile.ID;

                        if (z + 16 > from.Z && from.Z + 16 > z && Find(id, itemIDs))
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        public static bool Find(int itemID, int[] itemIDs)
        {
            var contains = false;

            for (var i = 0; !contains && i < itemIDs.Length; i += 2)
            {
                contains = itemID >= itemIDs[i] && itemID <= itemIDs[i + 1];
            }

            return contains;
        }

        // Counts ZuluIngot stacks in container with matching MaterialId.
        private static int GetIngotAmount(Container cont, int materialId)
        {
            var amount = 0;
            foreach (var ingot in cont.FindItemsByType<ZuluIngot>())
            {
                if (ingot.MaterialId == materialId)
                {
                    amount += ingot.Amount;
                }
            }

            return amount;
        }

        // Consumes 'need' total from ZuluIngot stacks of the given materialId.
        private static bool ConsumeIngots(Container cont, int materialId, int need)
        {
            if (GetIngotAmount(cont, materialId) < need)
            {
                return false;
            }

            foreach (var ingot in cont.FindItemsByType<ZuluIngot>())
            {
                if (need <= 0)
                {
                    break;
                }

                if (ingot.MaterialId == materialId)
                {
                    var theirAmount = ingot.Amount;
                    if (theirAmount <= need)
                    {
                        need -= theirAmount;
                        ingot.Consume(theirAmount);
                    }
                    else
                    {
                        ingot.Consume(need);
                        need = 0;
                    }
                }
            }

            return need <= 0;
        }

        // Stamps the crafted item with Zulu material identity, applies quality/durability factors,
        // and writes ingredients-x-factor mod values into Item.ZuluModifiers[]. Mods are baked once
        // here at craft time; the Mobile aggregator reads ZuluModifiers[] from equipped items.
        private void ApplyZuluMaterial(Item item, int materialId)
        {
            var def = ZuluMaterialRegistry.Get(materialId);
            if (def == null)
            {
                return;
            }

            var ingots = Resources.Count > 0 ? Resources[0].Amount : 0;

            foreach (var mm in def.Mods)
            {
                item.ZuluModifiers[(int)mm.Mod] += ingots * mm.Factor;
            }

            switch (item)
            {
                case BaseArmor armor:
                    armor.MaxHitPoints = (int)(armor.MaxHitPoints * def.DurabilityFactor);
                    armor.HitPoints = armor.MaxHitPoints;
                    armor.ZuluMaterialId = materialId;
                    armor.ZuluMaterialName = def.Name;
                    break;
                case BaseWeapon weapon:
                    weapon.MaxHitPoints = (int)(weapon.MaxHitPoints * def.DurabilityFactor);
                    weapon.HitPoints = weapon.MaxHitPoints;
                    weapon.ZuluMaterialId = materialId;
                    weapon.ZuluMaterialName = def.Name;
                    break;
            }
        }

        public bool ConsumeRes(
            Mobile from, int materialId, ZuluCraftSystem craftSystem, ref int resHue, ref int maxAmount,
            ZuluConsumeType consumeType, ref string message
        ) => ConsumeRes(from, materialId, craftSystem, ref resHue, ref maxAmount, consumeType, ref message, false);

        public bool ConsumeRes(
            Mobile from, int materialId, ZuluCraftSystem craftSystem, ref int resHue, ref int maxAmount,
            ZuluConsumeType consumeType, ref string message, bool isFailure
        )
        {
            var ourPack = from.Backpack;

            if (ourPack == null)
            {
                return false;
            }

            if (NeedHeat && !Find(from, m_HeatSources))
            {
                message = "You must be near a fire source to cook.";
                return false;
            }

            if (NeedOven && !Find(from, m_Ovens))
            {
                message = "You must be near an oven to bake that.";
                return false;
            }

            if (NeedMill && !Find(from, m_Mills))
            {
                message = "You must be near a flour mill to do that.";
                return false;
            }

            maxAmount = int.MaxValue;
            resHue = 0;

            // Phase A assumption: every Zulu recipe consumes ZuluIngot of the chosen MaterialId.
            // Resources list is treated as a single primary resource entry — its Amount tells us
            // how many ingots one unit of the recipe needs. (Multi-ingredient recipes — logs, leather,
            // boards, etc. — are TODO Phase C.)
            if (Resources.Count == 0)
            {
                message = "This recipe has no resources defined.";
                return false;
            }

            var primary = Resources[0];
            var perUnit = primary.Amount;

            // Subresource skill check (selected material requires X skill).
            var resCol = UseSubRes2 ? craftSystem.CraftSubRes2 : craftSystem.CraftSubRes;
            var subResource = resCol?.SearchFor(materialId);
            if (subResource != null && from.Skills[craftSystem.MainSkill].Value < subResource.RequiredSkill)
            {
                message = subResource.Message ?? "You have no idea how to work this material.";
                return false;
            }

            // Compute how many full units we have ingots for.
            var available = GetIngotAmount(ourPack, materialId);

            if (UseAllRes)
            {
                maxAmount = perUnit > 0 ? available / perUnit : 0;
                if (maxAmount == 0)
                {
                    primary.SendMessage(from);
                    message = primary.Message ?? "You don't have the resources required to make that item.";
                    return false;
                }
            }
            else
            {
                maxAmount = -1;
            }

            var totalNeeded = UseAllRes ? perUnit * maxAmount : perUnit;

            if (isFailure && !craftSystem.ConsumeOnFailure(from, null, this))
            {
                totalNeeded = 0;
            }

            if (consumeType == ZuluConsumeType.None)
            {
                if (available < totalNeeded)
                {
                    message = primary.Message ?? "You don't have the resources required to make that item.";
                    return false;
                }

                return true;
            }

            if (consumeType == ZuluConsumeType.Half)
            {
                totalNeeded = Math.Max(1, totalNeeded / 2);
            }

            if (totalNeeded > 0 && !ConsumeIngots(ourPack, materialId, totalNeeded))
            {
                message = primary.Message ?? "You don't have the resources required to make that item.";
                return false;
            }

            // Set resHue from the material definition, so the crafted item can take its color.
            var matDef = ZuluMaterialRegistry.Get(materialId);
            if (matDef != null)
            {
                resHue = matDef.Hue;
            }

            return true;
        }

        public double GetExceptionalChance(ZuluCraftSystem system, double chance, Mobile from)
        {
            if (ForceNonExceptional)
            {
                return 0.0;
            }

            // TODO Phase C: Talisman bonuses to exceptional chance (vanilla used BaseTalisman).

            chance = system.ECA switch
            {
                ZuluCraftECA.FiftyPercentChanceMinusTenPercent => chance * 0.5 - 0.1,
                ZuluCraftECA.ChanceMinusSixtyToFortyFive => chance - Math.Clamp(
                    0.60 - (from.Skills[system.MainSkill].Value - 95.0) * 0.03,
                    0.45,
                    0.60
                ),
                _ => chance - 0.6
            };

            return chance;
        }

        public bool CheckSkills(
            Mobile from, int materialId, ZuluCraftSystem craftSystem, ref int quality, out bool allRequiredSkills
        ) => CheckSkills(from, materialId, craftSystem, ref quality, out allRequiredSkills, true);

        public bool CheckSkills(
            Mobile from, int materialId, ZuluCraftSystem craftSystem, ref int quality,
            out bool allRequiredSkills, bool gainSkills
        )
        {
            var chance = GetSuccessChance(from, materialId, craftSystem, gainSkills, out allRequiredSkills);

            if (GetExceptionalChance(craftSystem, chance, from) > Utility.RandomDouble())
            {
                quality = 2;
            }

            return chance > Utility.RandomDouble();
        }

        public double GetSuccessChance(
            Mobile from, int materialId, ZuluCraftSystem craftSystem, bool gainSkills,
            out bool allRequiredSkills
        )
        {
            var minMainSkill = 0.0;
            var maxMainSkill = 0.0;
            var valMainSkill = 0.0;

            allRequiredSkills = true;

            for (var i = 0; i < Skills.Count; i++)
            {
                var craftSkill = Skills[i];

                var minSkill = craftSkill.MinSkill;
                var maxSkill = craftSkill.MaxSkill;
                var valSkill = from.Skills[craftSkill.SkillToMake].Value;

                if (valSkill < minSkill)
                {
                    allRequiredSkills = false;
                }

                if (craftSkill.SkillToMake == craftSystem.MainSkill)
                {
                    minMainSkill = minSkill;
                    maxMainSkill = maxSkill;
                    valMainSkill = valSkill;
                }

                if (gainSkills)
                {
                    from.CheckSkill(craftSkill.SkillToMake, minSkill, maxSkill);
                }
            }

            if (!allRequiredSkills)
            {
                return 0;
            }

            var minChance = craftSystem.GetChanceAtMin(this);

            var range = maxMainSkill - minMainSkill;
            var chance = range > 0
                ? minChance + (valMainSkill - minMainSkill) / range * (1.0 - minChance)
                : minChance;

            // TODO Phase C: Talisman bonus to success chance.

            return chance;
        }

        public void Craft(Mobile from, ZuluCraftSystem craftSystem, int materialId, BaseTool tool)
        {
            if (!from.BeginAction<ZuluCraftSystem>())
            {
                from.SendLocalizedMessage(500119); // You must wait to perform another action
                return;
            }

            var chance = GetSuccessChance(from, materialId, craftSystem, false, out var allRequiredSkills);

            if (!allRequiredSkills || chance <= 0.0)
            {
                from.EndAction<ZuluCraftSystem>();
                from.SendLocalizedMessage(1044153); // You don't have the required skills to attempt this item.
                // TODO: Phase B — send ZuluCraftGump back to player
                return;
            }

            var badCraft = craftSystem.CanCraft(from, tool, ItemType);

            if (badCraft > 0)
            {
                from.EndAction<ZuluCraftSystem>();
                from.SendLocalizedMessage(badCraft);
                // TODO: Phase B — send ZuluCraftGump back to player
                return;
            }

            var resHue = 0;
            var maxAmount = 0;
            string message = null;

            if (!ConsumeRes(from, materialId, craftSystem, ref resHue, ref maxAmount, ZuluConsumeType.None, ref message))
            {
                from.EndAction<ZuluCraftSystem>();
                if (!string.IsNullOrEmpty(message))
                {
                    from.SendMessage(message);
                }
                // TODO: Phase B — send ZuluCraftGump back to player
                return;
            }

            var context = craftSystem.GetContext(from);
            context?.OnMade(this);

            var iMin = craftSystem.MinCraftEffect;
            var iMax = craftSystem.MaxCraftEffect - iMin + 1;
            var iRandom = Utility.Random(iMax);
            iRandom += iMin + 1;
            new InternalTimer(from, craftSystem, this, materialId, tool, iRandom).Start();
        }

        public void CompleteCraft(
            int quality, bool makersMark, Mobile from, ZuluCraftSystem craftSystem, int materialId,
            BaseTool tool
        )
        {
            var badCraft = craftSystem.CanCraft(from, tool, ItemType);

            if (badCraft > 0)
            {
                from.SendLocalizedMessage(badCraft);
                // TODO: Phase B — send ZuluCraftGump back to player
                return;
            }

            var checkResHue = 0;
            var checkMaxAmount = 0;
            string checkMessage = null;

            var consumeRes = ConsumeRes(
                from,
                materialId,
                craftSystem,
                ref checkResHue,
                ref checkMaxAmount,
                ZuluConsumeType.None,
                ref checkMessage
            );

            if (!consumeRes)
            {
                if (!string.IsNullOrEmpty(checkMessage))
                {
                    from.SendMessage(checkMessage);
                }
                // TODO: Phase B — send ZuluCraftGump back to player
                return;
            }

            var toolBroken = false;

            var ignored = 1;
            var endquality = 1;
            var resHue = 0;
            var maxAmount = 0;
            string message = null;
            var num = 0;

            if (CheckSkills(from, materialId, craftSystem, ref ignored, out var allRequiredSkills))
            {
                consumeRes = ConsumeRes(
                    from,
                    materialId,
                    craftSystem,
                    ref resHue,
                    ref maxAmount,
                    ZuluConsumeType.All,
                    ref message
                );

                if (!consumeRes)
                {
                    if (!string.IsNullOrEmpty(message))
                    {
                        from.SendMessage(message);
                    }
                    // TODO: Phase B — send ZuluCraftGump back to player
                    return;
                }

                tool.UsesRemaining--;

                if (tool.UsesRemaining < 1 && tool.BreakOnDepletion)
                {
                    toolBroken = true;
                }

                if (toolBroken)
                {
                    tool.Delete();
                }

                Item item;
                item = ItemType.CreateInstance<Item>();

                if (item != null)
                {
                    // TODO Phase B/C: invoke IZuluCraftable.OnCraft for quality/material/marker handling.
                    if (item.Hue == 0)
                    {
                        item.Hue = resHue;
                    }

                    if (maxAmount > 0)
                    {
                        if (!item.Stackable && item is IUsesRemaining remaining)
                        {
                            remaining.UsesRemaining *= maxAmount;
                        }
                        else
                        {
                            item.Amount = maxAmount;
                        }
                    }

                    ApplyZuluMaterial(item, materialId);

                    from.AddToBackpack(item);

                    if (from.AccessLevel > AccessLevel.Player)
                    {
                        CommandLogging.WriteLine(
                            from,
                            $"Crafting {CommandLogging.Format(item)} with craft system {craftSystem.GetType().Name}"
                        );
                    }
                }

                if (num == 0)
                {
                    num = craftSystem.PlayEndingEffect(from, false, true, toolBroken, endquality, makersMark, this);
                }

                // TODO: Phase B — send ZuluCraftGump back to player (with `num` message)
                if (num > 0)
                {
                    from.SendLocalizedMessage(num);
                }

                return;
            }

            if (!allRequiredSkills)
            {
                from.SendLocalizedMessage(1044153); // You don't have the required skills to attempt this item.
                // TODO: Phase B — send ZuluCraftGump back to player
                return;
            }

            var consumeType = UseAllRes ? ZuluConsumeType.Half : ZuluConsumeType.All;

            // Failure path — consume (possibly half) resources.
            if (!ConsumeRes(from, materialId, craftSystem, ref resHue, ref maxAmount, consumeType, ref message, true))
            {
                if (!string.IsNullOrEmpty(message))
                {
                    from.SendMessage(message);
                }
                // TODO: Phase B — send ZuluCraftGump back to player
                return;
            }

            tool.UsesRemaining--;

            if (tool.UsesRemaining < 1 && tool.BreakOnDepletion)
            {
                toolBroken = true;
            }

            if (toolBroken)
            {
                tool.Delete();
            }

            num = craftSystem.PlayEndingEffect(from, true, true, toolBroken, endquality, false, this);

            // TODO: Phase B — send ZuluCraftGump back to player (with `num` message)
            if (num > 0)
            {
                from.SendLocalizedMessage(num);
            }
        }

        private class InternalTimer : Timer
        {
            private readonly ZuluCraftItem m_CraftItem;
            private readonly ZuluCraftSystem m_CraftSystem;
            private readonly Mobile m_From;
            private readonly int m_iCountMax;
            private readonly BaseTool m_Tool;
            private readonly int m_MaterialId;
            private int m_iCount;

            public InternalTimer(
                Mobile from, ZuluCraftSystem craftSystem, ZuluCraftItem craftItem, int materialId, BaseTool tool,
                int iCountMax
            ) : base(TimeSpan.Zero, TimeSpan.FromSeconds(craftSystem.Delay), iCountMax)
            {
                m_From = from;
                m_CraftItem = craftItem;
                m_iCount = 0;
                m_iCountMax = iCountMax;
                m_CraftSystem = craftSystem;
                m_MaterialId = materialId;
                m_Tool = tool;
            }

            protected override void OnTick()
            {
                m_iCount++;

                m_From.DisruptiveAction();

                if (m_iCount < m_iCountMax)
                {
                    m_CraftSystem.PlayCraftEffect(m_From);
                    return;
                }

                m_From.EndAction<ZuluCraftSystem>();

                var badCraft = m_CraftSystem.CanCraft(m_From, m_Tool, m_CraftItem.ItemType);

                if (badCraft > 0)
                {
                    m_From.SendLocalizedMessage(badCraft);
                    // TODO: Phase B — send ZuluCraftGump back to player
                    return;
                }

                var quality = 1;

                m_CraftItem.CheckSkills(m_From, m_MaterialId, m_CraftSystem, ref quality, out _, false);

                var context = m_CraftSystem.GetContext(m_From);

                if (context == null)
                {
                    return;
                }

                var makersMark = false;

                if (quality == 2 && m_From.Skills[m_CraftSystem.MainSkill].Base >= 100.0)
                {
                    makersMark = m_CraftItem.IsMarkable(m_CraftItem.ItemType);
                }

                if (makersMark && context.MarkOption == ZuluCraftMarkOption.PromptForMark)
                {
                    // TODO: Phase B — send QueryMakersMark gump
                    m_CraftItem.CompleteCraft(quality, false, m_From, m_CraftSystem, m_MaterialId, m_Tool);
                }
                else
                {
                    if (context.MarkOption == ZuluCraftMarkOption.DoNotMark)
                    {
                        makersMark = false;
                    }

                    m_CraftItem.CompleteCraft(quality, makersMark, m_From, m_CraftSystem, m_MaterialId, m_Tool);
                }
            }
        }
    }
}
