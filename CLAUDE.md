# ModernUO

.NET 10 Ultima Online server emulator. Single-threaded game loop. All game logic runs on one thread.

- **Server engine**: `Projects/Server/` — do NOT modify without explicit request
- **Game content**: `Projects/UOContent/` — primary editing target
- **Build**: `dotnet build` from repo root

## Code Audit Rules

Apply these when writing or reviewing `.cs` files under `Projects/`.

1. **LINQ** — Tier 1 (zero-cost patterns) free on hot paths; Tier 2 (low overhead) OK on warm paths; Tier 3 (allocating) forbidden on hot paths → `dev-docs/code-standards.md`
2. **No `Console.WriteLine`** — use `LogFactory.GetLogger(typeof(MyClass))` → `logger.Information(...)` (requires `using Server.Logging;`)
3. **No concurrency primitives** — no `lock`, `volatile`, `ConcurrentDictionary`, `Mutex`, etc. Server is single-threaded.
4. **No `World.Mobiles`/`World.Items` iteration** — use spatial queries: `map.GetMobilesInRange<T>()`, `map.GetItemsInRange<T>()`
5. **Clean up refs in `OnDelete()`/`OnAfterDelete()`** — null out `Item`/`Mobile` references
6. **Cancel timers in `OnDelete()`/`OnAfterDelete()`** — call `_token.Cancel()` or `_timer?.Stop()`
7. **`STArrayPool<T>.Shared`** not `ArrayPool<T>.Shared` — single-threaded optimized, no locks
8. **`PooledRefList<T>`** not `new List<T>()` on hot paths — zero GC pressure, stack-allocated ref struct
9. **Serialization** — class must be `partial`, constructor needs `[Constructible]`, `TimerExecutionToken` must NOT have `[SerializableField]`. New classes: use `[SerializationGenerator(version)]` (omit `encoded`). When bumping versions, add `MigrateFrom(VXContent)` (X = previous version). Never modify `Deserialize(reader, version)` for version bumps — that method is only for pre-codegen legacy saves. When migrating from pre-codegen Serialize/Deserialize: pass `false` if old code used `reader.ReadInt()`, bump version +1, and keep old logic as `private void Deserialize(IGenericReader reader, int version)`. **To add a new serialized field to an existing class without touching the vanilla file, drop a `[SerializableProperty(N)]` auto-property in the `.Zulu.cs` partial using a free index (above the highest existing one). Do NOT bump the version, do NOT add `[SerializableField]` (private fields require the same file as `[SerializationGenerator]`), and do NOT add `MigrateFrom`. Old saves load fine — missing fields default to their C# default. This is how `Item.ZuluModifiers[]` was added.** → `dev-docs/runuo-migration-docs/02-serialization.md`
10. **No `Task.Run`/`new Thread()`** in game code — game logic is single-threaded event loop
11. **Never assume era** — if code uses `Core.AOS`/`Core.SE`/etc., ask which expansion to target
12. **Naming** — `_camelCase` private fields, `PascalCase` properties/methods/classes; don't flag legacy `m_` but use `_` for new code
13. **No empty gumps** — every gump must produce visual elements. An empty gump leaks on client+server (no way to close it). Use static `DisplayTo()` to validate before constructing → `dev-docs/gump-system.md`
14. **PropertyList string literals must be holes** — `$"{"Map"}\t{value}"` not `$"Map\t{value}"`. The handler treats bare text as delimiters, `{}` holes as arguments. Only `\t` should be a bare literal → `dev-docs/property-lists.md`
15. **Braces required on all control flow** — `if`, `else`, `for`, `foreach`, `while`, `do`, `switch` must always have braces, even for single-line bodies → `dev-docs/code-standards.md`
16. **Prefer switch expressions and switch-when** — use switch expressions for value mapping and switch-when for pattern matching where they improve readability. Exception: skip if unreadable or cold path → `dev-docs/code-standards.md`
17. **No `System.Text.StringBuilder`** — use `ValueStringBuilder` with `stackalloc` (bounded output) or `ValueStringBuilder.Create()` (unbounded). Supports `$"..."` interpolation directly. Always use `using var` for disposal. Use `Reset()` instead of reassigning → `dev-docs/string-handling.md`

## Dev-Docs Reference

| Topic | File |
|---|---|
| Code standards & LINQ tiers | `dev-docs/code-standards.md` |
| Serialization system | `dev-docs/serialization.md` |
| Content patterns (Items, Mobiles, Creatures) | `dev-docs/content-patterns.md` |
| Era & expansion handling | `dev-docs/era-expansion.md` |
| Timer system | `dev-docs/timers.md` |
| Event scheduler (wall-clock/calendar) | `dev-docs/event-scheduler.md` |
| Object property lists (tooltips) | `dev-docs/property-lists.md` |
| Gump (UI dialog) system | `dev-docs/gump-system.md` |
| Commands & targeting | `dev-docs/commands-targeting.md` |
| Event system | `dev-docs/events.md` |
| Threading model | `dev-docs/threading-model.md` |
| Configuration system | `dev-docs/configuration.md` |
| Networking & packets | `dev-docs/networking-packets.md` |
| Region system | `dev-docs/regions.md` |
| String handling & ValueStringBuilder | `dev-docs/string-handling.md` |
| RunUO migration (overview) | `dev-docs/runuo-migration-docs/00-overview.md` |
| RunUO migration (all docs) | `dev-docs/runuo-migration-docs/` |

## Claude Skills (Opt-In)

Detailed Claude Code skills live in `dev-docs/claude-skills/`. They are **not auto-loaded** — they must be copied to `.claude/skills/` to activate.

**When to offer**: If the user is building complex content (new items, creatures, spells, gumps, quests, packets, serialization work, etc.), ask:

> I have detailed Claude Code skills for this kind of work. Want me to enable them?
> I'll copy the relevant files from `dev-docs/claude-skills/` to `.claude/skills/`.

Then copy only the relevant skill files based on the task:

| Task | Skills to enable |
|---|---|
| New Item or Mobile | `modernuo-content-patterns`, `modernuo-serialization`, `modernuo-property-lists` |
| Creature / spawn | `modernuo-content-patterns`, `modernuo-serialization`, `modernuo-timers` |
| Spell or ability | `modernuo-content-patterns`, `modernuo-serialization`, `modernuo-timers`, `modernuo-era-expansion` |
| Gump / UI dialog | `modernuo-gump-system`, `modernuo-commands-targeting` |
| Quest or event system | `modernuo-events`, `modernuo-content-patterns`, `modernuo-configuration` |
| Scheduled / seasonal / holiday events | `modernuo-event-scheduler`, `modernuo-timers` |
| Custom regions / dynamic areas | `modernuo-regions`, `modernuo-content-patterns` |
| Packet / networking | `modernuo-networking`, `modernuo-threading` |
| Commands | `modernuo-commands-targeting` |
| Timer work | `modernuo-timers`, `modernuo-serialization` |
| Config system | `modernuo-configuration` |
| Era-conditional code | `modernuo-era-expansion` |
| String building / formatting | `modernuo-string-handling` |
| Code review / audit | `modernuo-code-audit` |
| Any `.cs` file edit | `modernuo-code-audit` (always offer for code changes) |

To enable a skill: `cp dev-docs/claude-skills/<name>.md .claude/skills/`

Migration skills reference the deep docs in `dev-docs/runuo-migration-docs/` and point to existing ModernUO skills for best practices.

The `modernuo-code-audit` skill auto-triggers on `.cs` file edits and flags convention violations (warnings only, asks before fixing).

## Zulu Modifications
All the modifications and implementations requested, needs to be implemented in new partial classes with suffix .Zulu.cs if possible, or with MINIMAL changes in files that are not .Zulu.cs.

Every modification in files that are not .Zulu.cs, needs to be confirmed and with a region ##zulu mod for future reference and minimal changes. Never delete the original line — leave it commented out inside the region so the original intent is preserved.

Every new funcionalities, new files needs to be created with .Zulu.cs suffix.

### Overriding Skill Callbacks (preferred pattern)

To modify the behavior of any vanilla skill **without touching the original file**, override its `SkillInfo` callback from a `.Zulu.cs` file:

```csharp
// File: Skills/SomeSkill.Zulu.cs
public static class SomeSkillZulu
{
    [CallPriority(51)]  // > 50 (default) so this runs after the vanilla Initialize()
    public static void Initialize()
    {
        SkillInfo.Table[(int)SkillName.SomeSkill].Callback = OnUse;
    }

    private static TimeSpan OnUse(Mobile m) { ... }

    private class ZuluInternalTarget : Target { ... }
}
```

- Default `CallPriority` is **50**. Use **51+** to guarantee execution after the vanilla registration.
- The vanilla `Initialize()` runs first and registers the original callback; ours overwrites it.
- 0 changes to the original skill file — fully reversible by deleting the `.Zulu.cs`.
- Example: `Projects/UOContent/Skills/AnimalLore.Zulu.cs`

## About Zulu Hotel
- Im trying to reimplement the Zulu Hotel Shard modifications from a POL 98 server that are in a folder D:\OneDrive\Eduardo\Ultima Online Shards\zhna 15-08-13 in this ModernUO project.
You can look in this folder to see how things works, or look like for reference.

- Classes in ZuluHotel (Warrior, Mage, Ranger, etc.) are a set of benefits that a Mobile can have according to its skill distribution.
A class can grant bonuses in combat, skill usage, spellcasting, and item crafting, based on its proficiency level.
A class can also impose penalties in combat, skill usage, spellcasting, and item crafting, or even restrict equipping certain types of items, depending on its proficiency level.

- The ZuluClassManager.cs file defines which benefits and penalties a Mobile will have for each class.

- ActiveZuluClass and ActiveZuluClassLevel properties in Mobile.Zulu.cs defines the active class and level of the player after calculations. Classes are recalculated every equip/unequip, login, and when skill increase by setting the variable isZuluDirty = true. Or open Class/Skills Menu.

- ActiveZuluModifiers in the Mobile.Zulu.cs class defines the list of modifiers applied to the mobile, already aggregated in cases where the mobile has, for example, two sources of the same type of ZuluMod.
It must be recalculated whenever requested if isZuluDirty = true.

- ZuluModifierSources in the Mobile.Zulu.cs class is intended for future queries in UI screens, allowing us to identify—within the aggregated/summed ActiveZuluModifiers list—the breakdown of where a specific ZuluMod’s total is coming from.

- isZuluDirty property in Mobile.Zulu.cs defines if the mobile changed equiped items/increased skill/opened the menu or somenthing that may change its ActiveZuluModifiers, ZuluModifierSources, ActiveZuluClass and ActiveZuluClassLevel. If is set true it means that if anywhere in the code needs some of those properties, it must be recalculated before.
The purpose of this property is to avoid unnecessary recalculations of class, equipped items, etc., during combat/spellcasting, which occur much more frequently.

- The z_xxxx_DD properties in Mobile.Zulu.cs are intended exclusively for use with non-player Mobiles and simply define that Mobile’s damage distribution. For example, if a Mobile has 60 damage and the properties z_Air_DD = 40 and z_Physical_DD = 60, it means that the 60 damage will be distributed as 40% Air damage and 60% Physical damage.

- The ZuluMod enumerator is intended to simplify all damage and specific ability modifications that a Mobile can have. To avoid calculations scattered throughout the code, the idea is to accumulate all ZuluMod entries into ActiveZuluModifiers—a unified list of a Mobile’s modifications, regardless of their source (items, the mobile itself, classes, skills, etc.), using a consistent naming convention. It also allows listing for the player which modifiers are currently active.

## Plans
- At the end of each plan, give me a list of unresolved questions to answer, if any. Make the questions extremely concise. Sacrifice grammar for the sake of concision.

- Before you do any work, mention how you could verify that work.

## Update Skills and Claude.md
Update my Claude.md to remove anything thats no longer needed, contradictory, duplicate information or unecessary bloat impacting effectioness.

