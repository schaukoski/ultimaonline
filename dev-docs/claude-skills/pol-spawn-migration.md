# POL → ModernUO Spawn Migration Reference

## Overview

The Zulu Hotel POL server has **two distinct spawn systems**. Only one has static config files with coordinates.

| System | Source Files | Has Coordinates? | Scope |
|---|---|---|---|
| `spawnregion` | `spawnregions.cfg` + `spawregions.2.txt` + `spawngroups.cfg` | **Yes** — static config | 106 named regions |
| `spawnpoint` | `groups.cfg` / `groups1.cfg` (groups only) | **No** — saved in server state | 99+ groups, location-specific |

**Important**: The `spawnpoint` system stores spawner coordinates as properties of in-game items (type `0xa300`). These coordinates are in the POL server's live state, not in static config files. The groups.cfg only defines what mobs each group spawns — not where.

---

## System 1: spawnregion

### Files

```
pkg/systems/spawnregion/config/
  spawngroups.cfg    — 19 groups with templates + relative weights
  spawnregions.cfg   — named areas with Min_x/y/z, Max_x/y/z

data/ds/spawnregion/
  spawregions.2.txt  — 106 Elements linking Region + Group + N_Npcs + Time
```

### spawregions.2.txt Structure

```
Element Britain
{
    Group  i1          # group number (i=int, s=string but still a number)
    N_Npcs i100        # total creatures to maintain alive
    Region sBritain    # must match a key in spawnregions.cfg
    Time   i100        # respawn delay in MINUTES
}
```

### spawnregions.cfg Structure

```
Region Britain
{
    Min_x  1000
    Min_y  1400
    Max_x  1700
    Max_y  1850
}
```

**Warning**: The first 10 entries (desert 1-5, wrong 1-5) are **placeholders** with fake coordinates (10/20/40/50 and 100/200/400/500). Skip them. Real entries start from `YEW_ESP_1` onward.

### spawngroups.cfg Structure

```
group 1
{
Name            raidedtown
template skeleton       100     # template_name  relative_weight
template zombie         100
template lich           3
...
}
```

Weights are relative (not percentages). Conversion:
```python
probability = max(1, round(weight / max_weight * 100))
```

### Conversion to ModernUO JSON

Each Element in `spawregions.2.txt` becomes one `Spawner` JSON entry:

```json
{
  "type": "Spawner",
  "guid": "<generated-uuid>",
  "name": "Britain",
  "location": [<center_x>, <center_y>, 0],
  "map": "Felucca",
  "count": 100,
  "minDelay": "01:40:00",
  "maxDelay": "01:40:00",
  "team": 0,
  "homeRange": 10,
  "walkingRange": -1,
  "spawnBounds": [1000, 1400, -128, 700, 450, 256],
  "entries": [...]
}
```

- `location` = center of the region rectangle
- `spawnBounds` = `[min_x, min_y, min_z, width, height, depth]` — width = max_x - min_x, height = max_y - min_y
- `minDelay` = `maxDelay` = `"HH:MM:SS"` from Time (minutes)
- `homeRange` = 10 (arbitrary — actual containment is via spawnBounds)

---

## System 2: spawnpoint

### Files

```
pkg/systems/spawnpoint/config/
  groups.cfg     — 99+ groups with spawn templates (no weights, just spawn lists)
  groups1.cfg    — duplicate/mirror of groups.cfg (same format)
```

### groups.cfg Structure

```
group 34
{
spawn vampire1
spawn vampire2
spawn nosferatu
}
```

**No weights** — equal probability per entry.

### Key Groups Reference

| Group | Name | Notable Mobs |
|---|---|---|
| 3 | bewitched_items | evilspellbook, brigand1, rogueknight, drow, beholder |
| 5 | dragons | dragon1, dragon2, spectraldrake |
| 24 | Dragões Level 1 | (vanilla dragons) |
| 25 | Dragões Level 2 | (stronger dragons) |
| 26 | Dragões Level 3 | goldendragon |
| 34 | Shame Vampires | vampire1, vampire2, nosferatu, dracula |
| 35 | Shame Magus Army L1 | magus, magehunter |
| 36 | Shame Magus Army L2 | bloodliche, fallenangel |
| 51 | Condemned Child | condemned child mobs |
| 71 | Dragon Isle | goldendragon, infernodragon, shadowdragon |

### Spawnpoint Coordinate Problem

Spawner coordinates are stored as properties of in-game items (`ObjType 0xa300`) saved in `data/items.txt`. The available backup (`zhna 15-08-13`) only contains **3 SpawnPoint items** — the server was saved before spawnpoints were fully populated.

**Current state of available backups:**
- `data/items.txt` — 3 SpawnPoints (vampirebat @ 2563/486, drake @ 5454/1809, dracula @ 5578/1857)
- `zhna 15-08-13.rar` — same snapshot, not yet verified
- No other backup with populated spawnpoints found

**Migration options:**
1. **Parse items.txt** (automated, limited): The Python converter handles this — only 3 spawners result
2. **Manual placement**: Place spawners in ModernUO using `[Add Spawner` based on area knowledge and the group definitions in `groups.cfg`
3. **Future**: If a more complete backup is found, re-run the converter against its `items.txt`

---

## Template → ModernUO Class Mapping

### Vanilla UO Mobs (POL template → ModernUO class name)

| POL Template | ModernUO Class |
|---|---|
| `skeleton` | `Skeleton` |
| `skeleton2` | `Skeleton` |
| `skeleton3` | `Skeleton` |
| `skeletonwarrior` | `SkeletalKnight` |
| `skeletonmage` | `BoneKnight` |
| `skeletonsoldier` | `SkeletalKnight` |
| `zombie` | `Zombie` |
| `rottingcorpse` | `RottingCorpse` |
| `headless` | `HeadlessOne` |
| `patchworkskeleton` | `PatchworkSkeleton` |
| `spectre` | `Spectre` |
| `banshee` | `Banshee` |
| `apparition` | `Wraith` |
| `vampirebat` | `VampireBat` |
| `lich` | `Lich` |
| `lichking` | `LichLord` |
| `ghoul` | `Ghoul` |
| `imp` | `Imp` |
| `daemon` | `Daemon` |
| `dragon1` | `Dragon` |
| `dragon2` | `Dragon` |
| `spectraldrake` | `SpectralArmour` |
| `drake1` | `Drake` |
| `drake2` | `Drake` |
| `wyvern` | `Wyvern` |
| `orc1` | `Orc` |
| `orc2` | `Orc` |
| `orc3` | `Orc` |
| `orc4` | `Orc` |
| `orc_lord` | `OrcLord` |
| `orcmage` | `OrcMage` |
| `ettin` | `Ettin` |
| `ettin2` | `Ettin` |
| `cyclops` | `Cyclops` |
| `titan` | `Titan` |
| `troll` | `Troll` |
| `ogre` | `Ogre` |
| `ogrelord` | `OgreLord` |
| `giantspider` | `GiantSpider` |
| `dreadspider` | `DreadSpider` |
| `phasespider` | `PhaseSpider` |
| `flamingspider` | `FlameSpider` |
| `rockspider` | `GiantSpider` |
| `snake` | `Snake` |
| `giantserpent` | `GiantSerpent` |
| `giantscorpion` | `Scorpion` |
| `scorp` | `Scorpion` |
| `rockscorpion` | `Scorpion` |
| `lizardman1` | `Lizardman` |
| `lizardman2` | `Lizardman` |
| `lizardman3` | `Lizardman` |
| `lizardman4` | `Lizardman` |
| `lizardman5` | `Lizardman` |
| `lizardman6` | `Lizardman` |
| `mongbat` | `Mongbat` |
| `slime` | `Slime` |
| `ratman` | `Ratman` |
| `giantrat` | `GiantRat` |
| `rat` | `Rat` |
| `rabbit` | `Rabbit` |
| `bird` | `Bird` |
| `raven` | `Raven` |
| `crow` | `Raven` |
| `vulture` | `Eagle` |
| `evilbird` | `Bird` |
| `firecrow` | `FireBeetle` |
| `wingedavenger` | `Eagle` |
| `swampboar` | `Boar` |
| `raptor` | `Raptor` |
| `firelizard` | `FireSteed` |
| `deadlizard` | `Lizardman` |
| `horse` | `Horse` |
| `horse2` | `Horse` |
| `horse3` | `Horse` |
| `horse4` | `Horse` |
| `packhorse` | `PackHorse` |
| `pig` | `Pig` |
| `sheep` | `Sheep` |
| `sheep2` | `Sheep` |
| `goat` | `Goat` |
| `cat` | `Cat` |
| `chicken` | `Chicken` |
| `blackcat` | `Cat` |
| `blackbear` | `BlackBear` |
| `grizzlybear` | `GrizzlyBear` |
| `bear` | `BlackBear` |
| `polar` | `PolarBear` |
| `walrus` | `Walrus` |
| `frostwolf` | `GreyWolf` |
| `gorilla` | `Gorilla` |
| `wisp` | `Wisp` |
| `rabiddog` | `Wolf` |
| `rabidcat` | `Cat` |
| `wardog` | `Wolf` |
| `panther` | `Panther` |
| `jackal` | `Wolf` |
| `bullfrog` | `BullFrog` |
| `flailcorpser` | `Corpser` |
| `cursedtree` | `Treefellow` |
| `elemental` | `EarthElemental` |
| `waterelemental` | `WaterElemental` |
| `fireelemental` | `FireElemental` |
| `airelemental` | `AirElemental` |
| `bloodelemental` | `BloodElemental` |
| `terathan` | `TerathanWarrior` |
| `terathanmatriarch` | `TerathanMatriarch` |
| `terathanavenger` | `TerathanAvenger` |
| `ophidianwarrior` | `OphidianWarrior` |
| `ophidianshaman1` | `OphidianMage` |
| `ophidianshaman2` | `OphidianMage` |
| `ophidianshaman3` | `OphidianMage` |
| `ophidianshaman4` | `OphidianMage` |
| `ophidianshaman5` | `OphidianMage` |

### Zulu Custom Mobs (POL template → ModernUO class name)

| POL Template | ModernUO Class | Source File |
|---|---|---|
| `goldendragon` | `ZuluGoldendragon` | ZuluEvil_Dragons.Zulu.cs |
| `infernodragon` | `ZuluInfernodragon` | ZuluEvil_Dragons.Zulu.cs |
| `shadowdragon` | `ZuluShadowdragon` | ZuluEvil_Dragons.Zulu.cs |
| `frostdragon` | `ZuluFrostdragon` | ZuluEvil_Dragons.Zulu.cs |
| `desertdragon` | `ZuluDesertdragon` | ZuluEvil_Dragons.Zulu.cs |
| `amoebadragon` | `ZuluAmoebadragon` | ZuluEvil_Dragons.Zulu.cs |
| `amoeba` | `ZuluAmoeba` | ZuluEvil_Dragons.Zulu.cs |
| `fallenangel` | `ZuluFallenangel` | ZuluEvil_Humanoids.Zulu.cs |
| `dracula` | `ZuluDracula` | ZuluEvil_Humanoids.Zulu.cs |
| `nightmare` | `ZuluNightmare` | ZuluEvil_Humanoids.Zulu.cs |
| `magus` | `ZuluMagus` | ZuluEvil_Humanoids.Zulu.cs |
| `magehunter` | `ZuluMagehunter` | ZuluEvil_Humanoids.Zulu.cs |
| `troll1` | `ZuluTroll1` | ZuluEvil_Humanoids.Zulu.cs |
| `troll2` | `ZuluTroll2` | ZuluEvil_Humanoids.Zulu.cs |
| `troll3` | `ZuluTroll3` | ZuluEvil_Humanoids.Zulu.cs |
| `trollchief` | `ZuluTrollchief` | ZuluEvil_Humanoids.Zulu.cs |
| `trollking` | `ZuluTrollking` | ZuluEvil_Humanoids.Zulu.cs |
| `trollshaman` | `ZuluTrollshaman` | ZuluEvil_Humanoids.Zulu.cs |
| `bewitchedsword` | `ZuluBewitchedsword` | ZuluEvil_Humanoids.Zulu.cs |
| `bewitchedbardiche` | `ZuluBewitchedbardiche` | ZuluEvil_Humanoids.Zulu.cs |
| `bewitchedarmor` | `ZuluBewitchedarmor` | ZuluEvil_Humanoids.Zulu.cs |
| `bewitchedgauntlets` | `ZuluBewitchedgauntlets` | ZuluEvil_Humanoids.Zulu.cs |
| `bewitchedspear` | `ZuluBewitchedspear` | ZuluEvil_Humanoids.Zulu.cs |
| `bewitchedwarhammer` | `ZuluBewitchedwarhammer` | ZuluEvil_Humanoids.Zulu.cs |
| `bewitchedpeasant` | `ZuluBewitchedpeasant` | ZuluEvil_Humanoids.Zulu.cs |
| `brigand1` | `ZuluBrigand1` | ZuluEvil_Humanoids.Zulu.cs |
| `rogueknight` | `ZuluRogueknight` | ZuluEvil_Humanoids.Zulu.cs |
| `airmaster` | `ZuluAirmaster` | ZuluEvil_Humanoids.Zulu.cs |
| `beholder` | `ZuluBeholder` | ZuluEvil_Humanoids.Zulu.cs |
| `drow` | `ZuluDrow` | ZuluEvil_Humanoids.Zulu.cs |
| `drowarcher` | `ZuluDrowarcher` | ZuluEvil_Humanoids.Zulu.cs |
| `hauntedblade` | `ZuluHauntedblade` | ZuluEvil_Humanoids.Zulu.cs |
| `evilspellbook` | `ZuluEvilspellbook` | ZuluEvil_Humanoids.Zulu.cs |
| `bloodliche` | `ZuluBloodliche` | ZuluEvil_Undead.Zulu.cs |
| `boneknight` | `ZuluBoneknight` | ZuluEvil_Undead.Zulu.cs |
| `vampire1` | `ZuluVampire1` | ZuluEvil_Undead.Zulu.cs |
| `vampire2` | `ZuluVampire2` | ZuluEvil_Undead.Zulu.cs |
| `nosferatu` | `ZuluNosferatu` | ZuluEvil_Undead.Zulu.cs |

---

## Python Conversion Script

The migration uses a standalone Python script (no build required, one-time use).

See `docs/superpowers/plans/2026-04-12-pol-spawn-migration.md` for the full script.

### Quick Reference — Script Inputs/Outputs

**Inputs (3 files):**
```
D:/.../spawnregions.cfg       → region bounds
D:/.../spawngroups.cfg        → group templates + weights
D:/.../data/ds/spawnregion/spawregions.2.txt  → region↔group↔count↔time
```

**Output:**
```
Distribution/Data/Spawns/zulu/spawnregion_<name>.json
```

One JSON file per region area (e.g., `spawnregion_britain.json`, `spawnregion_deceit.json`).

---

## Key Gotchas

1. **Placeholder regions**: First 10 entries in `spawnregions.cfg` have fake coords. Filter by checking if `min_x < 100` or coords are in set `{10,20,40,50,100,200,400,500}`.

2. **Group prefix**: In `spawregions.2.txt`, `Group` value has prefix `i` (int) or `s` (string) — both are numeric. Strip the prefix before parsing.

3. **Time = minutes**: `Time i100` → `minDelay: "01:40:00"` (100 minutes = 1h40m).

4. **spawnBounds format**: `[min_x, min_y, min_z, width, height, depth]` where `width = max_x - min_x`, `height = max_y - min_y`, `depth = 256` (full Z range).

5. **spawnpoint has no coordinates**: Cannot be migrated from static files alone. Requires either POL server export or manual placement.

6. **Equal probability in spawnpoint groups**: Unlike `spawngroups.cfg`, `groups.cfg` has no weights — all templates equally likely.
