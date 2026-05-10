# ModernUO Spawner System

## Overview

ModernUO has two spawner types both derived from `BaseSpawner`:

| Type | Location | Use case |
|---|---|---|
| `Spawner` | Fixed `Point3D` + optional `SpawnBounds` Rectangle3D | Most spawners |
| `RegionSpawner` | Uses a named `BaseRegion` | Region-wide spawns |

Both live in `Projects/UOContent/Engines/Spawners/`.

---

## JSON Format

Spawners are imported via `[ImportSpawners <glob>]` from `Distribution/Data/Spawns/`.

```json
[
  {
    "type": "Spawner",
    "guid": "3df0543a-373c-4673-a98b-8191686f4ab3",
    "name": "Spawner (Britain)",
    "location": [1496, 1628, 20],
    "map": "Felucca",
    "count": 5,
    "minDelay": "00:05:00",
    "maxDelay": "00:10:00",
    "team": 0,
    "homeRange": 10,
    "walkingRange": -1,
    "entries": [
      { "name": "Orc", "maxCount": 3, "probability": 80 },
      { "name": "OrcLord", "maxCount": 2, "probability": 20 }
    ]
  }
]
```

### Field Reference

| Field | Type | Notes |
|---|---|---|
| `type` | string | `"Spawner"` or `"RegionSpawner"` |
| `guid` | UUID | Unique; use `Guid.NewGuid().ToString()` or generate deterministically |
| `name` | string | Display name only |
| `location` | `[x, y, z]` | World coordinates — spawner item placed here |
| `map` | string | `"Felucca"`, `"Trammel"`, `"Ilshenar"`, `"Malas"`, `"Tokuno"` |
| `count` | int | Total number of creatures to maintain alive |
| `minDelay` | `"HH:MM:SS"` | Minimum respawn delay |
| `maxDelay` | `"HH:MM:SS"` | Maximum respawn delay |
| `team` | int | Team ID (0 = none) |
| `homeRange` | int | Radius from spawner where creatures can be placed (pixels) |
| `walkingRange` | int | How far creatures wander from home (`-1` = use homeRange) |
| `spawnBounds` | `[x,y,z,w,h,d]` | Optional Rectangle3D; restricts spawn area (Spawner only) |
| `entries` | array | List of creatures to spawn |
| `entries[].name` | string | C# class name (resolved via `AssemblyHandler.FindTypeByName`) |
| `entries[].maxCount` | int | Max simultaneous of this entry |
| `entries[].probability` | int | 1–100; relative weight for selection |

### RegionSpawner extra field

```json
{
  "type": "RegionSpawner",
  "spawnRegionName": "Britain",
  ...
}
```

`spawnRegionName` must match the `Name` property of an existing `BaseRegion`.

---

## Import Command

```
[ImportSpawners Data/Spawns/zulu/*.json
```

- Searches relative to `Distribution/` folder
- Supports glob patterns
- Accepts `.json`, `.xml` (Nerun Premium), `.map` (RunUO)
- Skips spawners with invalid types or maps (logs errors)
- Duplicate GUIDs: existing spawner is deleted and recreated

---

## Class Name Resolution

`entries[].name` is resolved via `AssemblyHandler.FindTypeByName(name)` — case-insensitive, searches all loaded assemblies. The name must match the C# class name exactly (ignoring case).

**Examples:**
- `"Orc"` → `Server.Mobiles.Orc`
- `"ZuluGoldendragon"` → `Server.Mobiles.ZuluGoldendragon`
- `"Dragon"` → `Server.Mobiles.Dragon`

If a class is not found, the spawner entry is skipped and an error is logged.

---

## Spawner Placement

- The spawner item itself is placed at `location`
- `homeRange` controls where creatures appear around the spawner
- With `spawnBounds`: creatures only appear within the Rectangle3D (overrides homeRange for placement)
- `walkingRange = -1` means creatures roam within `homeRange` of their spawn location
- `walkingRange >= 0` means creatures roam that many tiles from their spawn location

---

## Delay Conventions

| Purpose | Typical delays |
|---|---|
| Fast respawn (dungeon) | `minDelay: "00:05:00"`, `maxDelay: "00:10:00"` |
| Normal world | `minDelay: "00:10:00"`, `maxDelay: "00:20:00"` |
| Slow/rare | `minDelay: "00:30:00"`, `maxDelay: "01:00:00"` |

POL `Time` field is in **minutes** — convert: `"00:{Time}:00"` for both min and max.

---

## File Organization

```
Distribution/Data/Spawns/
  zulu/
    britain.json
    deceit.json
    ...
```

Files are organized by zone/dungeon. Each file is a JSON array of spawner objects.

---

## Zulu-Specific Class Names

All Zulu custom mobiles follow the naming pattern `Zulu{Templatename}` where `{Templatename}` is the POL template name with first letter capitalized.

| POL Template | ModernUO Class |
|---|---|
| `goldendragon` | `ZuluGoldendragon` |
| `fallenangel` | `ZuluFallenangel` |
| `dracula` | `ZuluDracula` |
| `nightmare` | `ZuluNightmare` |
| `evilspellbook` | `ZuluEvilspellbook` |
| `bloodliche` | `ZuluBloodliche` |
| `magus` | `ZuluMagus` |
| `magehunter` | `ZuluMagehunter` |

For the full mapping table, see `dev-docs/claude-skills/pol-spawn-migration.md`.
