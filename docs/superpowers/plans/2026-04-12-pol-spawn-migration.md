# POL Spawn Migration — Implementation Plan

> **For agentic workers:** REQUIRED SUB-SKILL: Use superpowers:subagent-driven-development (recommended) or superpowers:executing-plans to implement this plan task-by-task. Steps use checkbox (`- [ ]`) syntax for tracking.

**Goal:** Converter os 106 spawn regions do POL (Zulu Hotel) para arquivos JSON do ModernUO em `Distribution/Data/Spawns/zulu/`, usando um script Python descartável (sem build, sem projeto C#).

**Architecture:** Script Python único `Tools/pol_spawn_converter.py` lê os 3 arquivos de configuração POL e gera JSONs compatíveis com `[ImportSpawners`. O sistema `spawnpoint` (99+ grupos) NÃO tem coordenadas em arquivos estáticos — suas posições ficam no estado salvo do servidor POL e requerem migração manual separada.

**Tech Stack:** Python 3.x (stdlib only — json, re, uuid, os, pathlib), arquivos POL em `D:/OneDrive/Eduardo/Ultima Online Shards/zhna 15-08-13/`

---

## Contexto de referência rápida

### Dois sistemas de spawn no POL

| Sistema | Tem coordenadas estáticas? | Escopo | Status |
|---|---|---|---|
| `spawnregion` | **Sim** — spawnregions.cfg | 106 regiões nomeadas, biomas e masmorras | **Este plano** |
| `spawnpoint` | **Não** — coords no estado do servidor | 99+ grupos, spawns específicos (Dragon Isle, etc.) | Migração manual futura |

### Arquivos fonte POL (sistema spawnregion)

| Arquivo | O que contém |
|---|---|
| `pkg/systems/spawnregion/config/spawnregions.cfg` | Áreas nomeadas com Min_x/y/z, Max_x/y/z |
| `pkg/systems/spawnregion/config/spawngroups.cfg` | 19 grupos com templates e pesos relativos |
| `data/ds/spawnregion/spawregions.2.txt` | 106 Elements: Region + Group + N_Npcs + Time |

### Destino ModernUO

```
Distribution/Data/Spawns/zulu/
```

Carregado via `[ImportSpawners Data/Spawns/zulu/*.json`

### Formato JSON alvo

```json
{
  "type": "Spawner",
  "guid": "3df0543a-373c-4673-a98b-8191686f4ab3",
  "name": "ZuluSpawner_BRITAIN_FLO_1",
  "location": [1350, 1625, 0],
  "map": "Felucca",
  "count": 30,
  "minDelay": "01:30:00",
  "maxDelay": "01:30:00",
  "team": 0,
  "homeRange": 0,
  "walkingRange": -1,
  "spawnBounds": [1000, 1400, -128, 700, 450, 256],
  "entries": [
    { "name": "Skeleton", "maxCount": 5, "probability": 100 },
    { "name": "ZuluBloodliche", "maxCount": 1, "probability": 3 }
  ]
}
```

**Campos chave:**
- `spawnBounds`: `[min_x, min_y, -128, width, height, 256]` onde `width = max_x - min_x`, `height = max_y - min_y`
- `location`: centro do retângulo `[(min_x+max_x)//2, (min_y+max_y)//2, 0]`
- `minDelay` = `maxDelay` = Time em minutos: `f"{time//60:02d}:{time%60:02d}:00"`
- `count` = `N_Npcs`
- `probability`: peso convertido — `max(1, round(weight / max_weight * 100))`
- `maxCount` por entry: `max(1, round(N_Npcs * weight / total_weight))`

### Regiões placeholder (filtrar)

Os primeiros 10 entries em `spawnregions.cfg` têm coordenadas falsas (`{10,20,40,50,100,200,400,500}`). Filtrar qualquer região onde `max_x - min_x < 100`.

### Mapeamento de templates POL → classe ModernUO

**Vanilla UO:**

| POL template | Classe ModernUO |
|---|---|
| `skeleton`, `skeleton2`, `skeleton3` | `Skeleton` |
| `skeletonwarrior`, `skeletonsoldier` | `SkeletalKnight` |
| `skeletonmage` | `BoneKnight` |
| `patchworkskeleton` | `PatchworkSkeleton` |
| `zombie` | `Zombie` |
| `rottingcorpse` | `RottingCorpse` |
| `headless` | `HeadlessOne` |
| `spectre` | `Spectre` |
| `banshee` | `Banshee` |
| `apparition` | `Wraith` |
| `vampirebat` | `VampireBat` |
| `lich` | `Lich` |
| `lichking` | `LichLord` |
| `ghoul` | `Ghoul` |
| `imp` | `Imp` |
| `daemon` | `Daemon` |
| `dragon1`, `dragon2` | `Dragon` |
| `spectraldrake` | `SpectralArmour` |
| `drake1`, `drake2` | `Drake` |
| `wyvern` | `Wyvern` |
| `orc1`, `orc2`, `orc3`, `orc4` | `Orc` |
| `orc_lord` | `OrcLord` |
| `orcmage` | `OrcMage` |
| `ettin`, `ettin2` | `Ettin` |
| `cyclops` | `Cyclops` |
| `titan` | `Titan` |
| `ogre` | `Ogre` |
| `ogrelord` | `OgreLord` |
| `troll` | `Troll` |
| `giantspider` | `GiantSpider` |
| `dreadspider` | `DreadSpider` |
| `phasespider` | `PhaseSpider` |
| `flamingspider`, `rockspider` | `GiantSpider` |
| `snake` | `Snake` |
| `giantserpent` | `GiantSerpent` |
| `giantscorpion`, `scorp`, `rockscorpion` | `Scorpion` |
| `lizardman1`, `lizardman2`, `lizardman3`, `lizardman4`, `lizardman5`, `lizardman6` | `Lizardman` |
| `mongbat` | `Mongbat` |
| `slime` | `Slime` |
| `ratman` | `Ratman` |
| `giantrat` | `GiantRat` |
| `rat` | `Rat` |
| `rabbit` | `Rabbit` |
| `bird`, `evilbird` | `Bird` |
| `raven`, `crow` | `Raven` |
| `vulture`, `wingedavenger` | `Eagle` |
| `firecrow` | `FireBeetle` |
| `swampboar` | `Boar` |
| `raptor` | `Raptor` |
| `firelizard` | `FireSteed` |
| `deadlizard` | `Lizardman` |
| `horse`, `horse2`, `horse3`, `horse4` | `Horse` |
| `packhorse` | `PackHorse` |
| `pig` | `Pig` |
| `sheep`, `sheep2` | `Sheep` |
| `goat` | `Goat` |
| `cat`, `blackcat`, `rabidcat` | `Cat` |
| `chicken` | `Chicken` |
| `blackbear`, `bear` | `BlackBear` |
| `grizzlybear` | `GrizzlyBear` |
| `polar` | `PolarBear` |
| `walrus` | `Walrus` |
| `frostwolf`, `rabiddog`, `wardog`, `jackal` | `GreyWolf` |
| `gorilla` | `Gorilla` |
| `wisp`, `wanderingspirit` | `Wisp` |
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
| `ophidianshaman1`, `ophidianshaman2`, `ophidianshaman3`, `ophidianshaman4`, `ophidianshaman5` | `OphidianMage` |
| `brigandmarksmen`, `brigandarcher`, `brigandhorseman`, `mountedbrigandarcher` | `Brigand` |
| `servantofcain` | `Brigand` |
| `gargoyle` | `Gargoyle` |
| `flamegargoyle` | `FireGargoyle` |
| `frostgargoyle` | `StoneGargoyle` |
| `etherealllama` | `EtherealLlama` |
| `etherealostard` | `EtherealOstard` |
| `squirrel` | `Squirrel` |
| `hildisvini` | `GreatHart` |

**Zulu Custom (prefixo `Zulu`):**

| POL template | Classe ModernUO |
|---|---|
| `goldendragon` | `ZuluGoldendragon` |
| `infernodragon` | `ZuluInfernodragon` |
| `shadowdragon` | `ZuluShadowdragon` |
| `frostdragon` | `ZuluFrostdragon` |
| `desertdragon` | `ZuluDesertdragon` |
| `amoebadragon` | `ZuluAmoebadragon` |
| `amoeba` | `ZuluAmoeba` |
| `fallenangel` | `ZuluFallenangel` |
| `dracula` | `ZuluDracula` |
| `nightmare`, `nightmare1`, `nightmare2`, `nightmare3`, `nightmare4` | `ZuluNightmare` |
| `magus` | `ZuluMagus` |
| `magehunter` | `ZuluMagehunter` |
| `bloodliche` | `ZuluBloodliche` |
| `boneknight` | `ZuluBoneknight` |
| `vampire1` | `ZuluVampire1` |
| `vampire2` | `ZuluVampire2` |
| `nosferatu` | `ZuluNosferatu` |
| `ghostlyhorse` | `ZuluGhostlyhorse` |
| `troll1` | `ZuluTroll1` |
| `troll2` | `ZuluTroll2` |
| `troll3` | `ZuluTroll3` |
| `trollchief` | `ZuluTrollchief` |
| `trollking` | `ZuluTrollking` |
| `trollshaman` | `ZuluTrollshaman` |
| `bewitchedsword` | `ZuluBewitchedsword` |
| `bewitchedbardiche` | `ZuluBewitchedbardiche` |
| `bewitchedarmor` | `ZuluBewitchedarmor` |
| `bewitchedgauntlets` | `ZuluBewitchedgauntlets` |
| `bewitchedspear` | `ZuluBewitchedspear` |
| `bewitchedwarhammer` | `ZuluBewitchedwarhammer` |
| `bewitchedpeasant` | `ZuluBewitchedpeasant` |
| `brigand1` | `ZuluBrigand1` |
| `rogueknight` | `ZuluRogueknight` |
| `airmaster` | `ZuluAirmaster` |
| `beholder` | `ZuluBeholder` |
| `drow` | `ZuluDrow` |
| `drowarcher` | `ZuluDrowarcher` |
| `hauntedblade` | `ZuluHauntedblade` |
| `evilspellbook` | `ZuluEvilspellbook` |

---

## Estrutura de arquivos

| Arquivo | Responsabilidade |
|---|---|
| `Tools/pol_spawn_converter.py` | Script único: parseia CFGs, gera JSONs |
| `Distribution/Data/Spawns/zulu/spawnregion.json` | Output: todos os 106 spawners |

---

## Task 1: Criar o script de conversão

**Files:**
- Create: `Tools/pol_spawn_converter.py`

- [ ] **Step 1: Criar o script**

Criar `Tools/pol_spawn_converter.py`:

```python
#!/usr/bin/env python3
"""
POL → ModernUO spawn region converter.
Reads spawnregions.cfg + spawngroups.cfg + spawregions.2.txt
Outputs Distribution/Data/Spawns/zulu/spawnregion.json
"""

import json
import re
import uuid
import os
import sys

POL_ROOT = r"D:\OneDrive\Eduardo\Ultima Online Shards\zhna 15-08-13"
OUTPUT_FILE = os.path.join(
    os.path.dirname(__file__), "..",
    "Distribution", "Data", "Spawns", "zulu", "spawnregion.json"
)

# ─── Template mapping ────────────────────────────────────────────────────────

TEMPLATE_MAP = {
    # skeleton / undead
    "skeleton": "Skeleton", "skeleton2": "Skeleton", "skeleton3": "Skeleton",
    "skeletonwarrior": "SkeletalKnight", "skeletonsoldier": "SkeletalKnight",
    "skeletonmage": "BoneKnight", "patchworkskeleton": "PatchworkSkeleton",
    "zombie": "Zombie", "rottingcorpse": "RottingCorpse",
    "headless": "HeadlessOne", "spectre": "Spectre", "banshee": "Banshee",
    "apparition": "Wraith", "vampirebat": "VampireBat",
    "lich": "Lich", "lichking": "LichLord", "ghoul": "Ghoul",
    # demons
    "imp": "Imp", "daemon": "Daemon",
    # dragons
    "dragon1": "Dragon", "dragon2": "Dragon", "spectraldrake": "SpectralArmour",
    "drake1": "Drake", "drake2": "Drake", "wyvern": "Wyvern",
    # humanoids
    "orc1": "Orc", "orc2": "Orc", "orc3": "Orc", "orc4": "Orc",
    "orc_lord": "OrcLord", "orcmage": "OrcMage",
    "ettin": "Ettin", "ettin2": "Ettin", "cyclops": "Cyclops",
    "titan": "Titan", "ogre": "Ogre", "ogrelord": "OgreLord", "troll": "Troll",
    "lizardman1": "Lizardman", "lizardman2": "Lizardman", "lizardman3": "Lizardman",
    "lizardman4": "Lizardman", "lizardman5": "Lizardman", "lizardman6": "Lizardman",
    # arthropods
    "giantspider": "GiantSpider", "dreadspider": "DreadSpider",
    "phasespider": "PhaseSpider", "flamingspider": "GiantSpider",
    "rockspider": "GiantSpider",
    "snake": "Snake", "giantserpent": "GiantSerpent",
    "giantscorpion": "Scorpion", "scorp": "Scorpion", "rockscorpion": "Scorpion",
    # animals
    "mongbat": "Mongbat", "slime": "Slime",
    "ratman": "Ratman", "giantrat": "GiantRat", "rat": "Rat",
    "rabbit": "Rabbit", "bird": "Bird", "evilbird": "Bird",
    "raven": "Raven", "crow": "Raven", "vulture": "Eagle",
    "wingedavenger": "Eagle", "firecrow": "FireBeetle",
    "swampboar": "Boar", "raptor": "Raptor", "firelizard": "FireSteed",
    "deadlizard": "Lizardman",
    "horse": "Horse", "horse2": "Horse", "horse3": "Horse", "horse4": "Horse",
    "packhorse": "PackHorse", "pig": "Pig",
    "sheep": "Sheep", "sheep2": "Sheep", "goat": "Goat",
    "cat": "Cat", "blackcat": "Cat", "rabidcat": "Cat",
    "chicken": "Chicken",
    "blackbear": "BlackBear", "bear": "BlackBear",
    "grizzlybear": "GrizzlyBear", "polar": "PolarBear", "walrus": "Walrus",
    "frostwolf": "GreyWolf", "rabiddog": "GreyWolf",
    "wardog": "GreyWolf", "jackal": "GreyWolf",
    "gorilla": "Gorilla", "wisp": "Wisp", "wanderingspirit": "Wisp",
    "bullfrog": "BullFrog", "panther": "Panther",
    "hildisvini": "GreatHart",
    # nature
    "flailcorpser": "Corpser", "cursedtree": "Treefellow",
    # elementals
    "elemental": "EarthElemental", "waterelemental": "WaterElemental",
    "fireelemental": "FireElemental", "airelemental": "AirElemental",
    "bloodelemental": "BloodElemental",
    # terathans/ophidians
    "terathan": "TerathanWarrior", "terathanmatriarch": "TerathanMatriarch",
    "terathanavenger": "TerathanAvenger", "ophidianwarrior": "OphidianWarrior",
    "ophidianshaman1": "OphidianMage", "ophidianshaman2": "OphidianMage",
    "ophidianshaman3": "OphidianMage", "ophidianshaman4": "OphidianMage",
    "ophidianshaman5": "OphidianMage",
    # brigands
    "brigandmarksmen": "Brigand", "brigandarcher": "Brigand",
    "brigandhorseman": "Brigand", "mountedbrigandarcher": "Brigand",
    "servantofcain": "Brigand",
    # gargoyles
    "gargoyle": "Gargoyle", "flamegargoyle": "FireGargoyle",
    "frostgargoyle": "StoneGargoyle",
    # misc
    "etherealllama": "EtherealLlama", "etherealostard": "EtherealOstard",
    "squirrel": "Squirrel",
    # ─── Zulu custom ─────────────────────────────────────────────────────────
    "goldendragon": "ZuluGoldendragon", "infernodragon": "ZuluInfernodragon",
    "shadowdragon": "ZuluShadowdragon", "frostdragon": "ZuluFrostdragon",
    "desertdragon": "ZuluDesertdragon", "amoebadragon": "ZuluAmoebadragon",
    "amoeba": "ZuluAmoeba",
    "fallenangel": "ZuluFallenangel", "dracula": "ZuluDracula",
    "nightmare": "ZuluNightmare", "nightmare1": "ZuluNightmare",
    "nightmare2": "ZuluNightmare", "nightmare3": "ZuluNightmare",
    "nightmare4": "ZuluNightmare",
    "magus": "ZuluMagus", "magehunter": "ZuluMagehunter",
    "bloodliche": "ZuluBloodliche", "boneknight": "ZuluBoneknight",
    "vampire1": "ZuluVampire1", "vampire2": "ZuluVampire2",
    "nosferatu": "ZuluNosferatu", "ghostlyhorse": "ZuluGhostlyhorse",
    "troll1": "ZuluTroll1", "troll2": "ZuluTroll2", "troll3": "ZuluTroll3",
    "trollchief": "ZuluTrollchief", "trollking": "ZuluTrollking",
    "trollshaman": "ZuluTrollshaman",
    "bewitchedsword": "ZuluBewitchedsword",
    "bewitchedbardiche": "ZuluBewitchedbardiche",
    "bewitchedarmor": "ZuluBewitchedarmor",
    "bewitchedgauntlets": "ZuluBewitchedgauntlets",
    "bewitchedspear": "ZuluBewitchedspear",
    "bewitchedwarhammer": "ZuluBewitchedwarhammer",
    "bewitchedpeasant": "ZuluBewitchedpeasant",
    "brigand1": "ZuluBrigand1", "rogueknight": "ZuluRogueknight",
    "airmaster": "ZuluAirmaster", "beholder": "ZuluBeholder",
    "drow": "ZuluDrow", "drowarcher": "ZuluDrowarcher",
    "hauntedblade": "ZuluHauntedblade", "evilspellbook": "ZuluEvilspellbook",
}

def resolve(template: str) -> str:
    """Map POL template name to ModernUO class name."""
    key = template.lower().strip()
    if key in TEMPLATE_MAP:
        return TEMPLATE_MAP[key]
    # Unknown: emit with comment-style name so it fails loud at import time
    print(f"  [WARN] Unknown template: {template!r} — using raw name")
    return template

# ─── Parsers ─────────────────────────────────────────────────────────────────

def parse_spawnregions(path: str) -> dict:
    """Returns {region_name: {min_x, min_y, max_x, max_y}} (placeholders filtered)."""
    regions = {}
    current = None
    data = {}
    with open(path, encoding="latin-1") as f:
        for line in f:
            line = line.strip()
            if not line or line.startswith("#"):
                continue
            m = re.match(r'^Region\s+(\S+)', line, re.IGNORECASE)
            if m:
                current = m.group(1)
                data = {}
                continue
            if line == "}" and current:
                # Filter placeholders: real regions have width/height >= 100
                w = data.get("max_x", 0) - data.get("min_x", 0)
                h = data.get("max_y", 0) - data.get("min_y", 0)
                if w >= 100 and h >= 100:
                    regions[current] = data
                current = None
                continue
            for key in ("Min_x", "Min_y", "Max_x", "Max_y"):
                m2 = re.match(rf'^{key}\s+(-?\d+)', line, re.IGNORECASE)
                if m2:
                    data[key.lower()] = int(m2.group(1))
    return regions


def parse_spawngroups(path: str) -> dict:
    """Returns {group_id: [(template, weight), ...]}"""
    groups = {}
    current_id = None
    entries = []
    with open(path, encoding="latin-1") as f:
        for line in f:
            line = line.strip()
            if not line or line.startswith("#"):
                continue
            m = re.match(r'^group\s+(\d+)', line, re.IGNORECASE)
            if m:
                current_id = int(m.group(1))
                entries = []
                continue
            if line == "}" and current_id is not None:
                groups[current_id] = entries
                current_id = None
                continue
            if current_id is not None:
                # skip Name line
                if re.match(r'^Name\s+', line, re.IGNORECASE):
                    continue
                m2 = re.match(r'^template\s+(\S+)\s+(\d+)', line, re.IGNORECASE)
                if m2:
                    entries.append((m2.group(1), int(m2.group(2))))
    return groups


def parse_elements(path: str) -> list:
    """Returns [{name, group_id, n_npcs, time_min}, ...]"""
    elements = []
    current = None
    data = {}
    with open(path, encoding="latin-1") as f:
        for line in f:
            line = line.strip()
            if not line or line.startswith("#"):
                continue
            m = re.match(r'^Element\s+(\S+)', line)
            if m:
                current = m.group(1)
                data = {}
                continue
            if line == "}" and current:
                if "group" in data and "n_npcs" in data and "region" in data:
                    elements.append({
                        "name": current,
                        "group_id": data["group"],
                        "n_npcs": data["n_npcs"],
                        "time_min": data.get("time", 100),
                        "region": data["region"],
                    })
                current = None
                continue
            if current is None:
                continue
            # Group  i1  or  s2
            m2 = re.match(r'^Group\s+[is](\d+)', line, re.IGNORECASE)
            if m2:
                data["group"] = int(m2.group(1))
            m3 = re.match(r'^N_Npcs\s+i(\d+)', line, re.IGNORECASE)
            if m3:
                data["n_npcs"] = int(m3.group(1))
            m4 = re.match(r'^Region\s+s(\S+)', line, re.IGNORECASE)
            if m4:
                data["region"] = m4.group(1)
            m5 = re.match(r'^Time\s+i(\d+)', line, re.IGNORECASE)
            if m5:
                data["time"] = int(m5.group(1))
    return elements

# ─── Generator ───────────────────────────────────────────────────────────────

def make_delay(minutes: int) -> str:
    h, m = divmod(minutes, 60)
    return f"{h:02d}:{m:02d}:00"


def build_spawner(elem: dict, region: dict, group_entries: list) -> dict:
    min_x, min_y = region["min_x"], region["min_y"]
    max_x, max_y = region["max_x"], region["max_y"]
    cx = (min_x + max_x) // 2
    cy = (min_y + max_y) // 2

    n_npcs = elem["n_npcs"]
    delay_str = make_delay(elem["time_min"])

    max_weight = max(w for _, w in group_entries) if group_entries else 1
    total_weight = sum(w for _, w in group_entries) if group_entries else 1

    entries = []
    for tmpl, weight in group_entries:
        probability = max(1, round(weight / max_weight * 100))
        max_count = max(1, round(n_npcs * weight / total_weight))
        entries.append({
            "name": resolve(tmpl),
            "maxCount": max_count,
            "probability": probability,
        })

    return {
        "type": "Spawner",
        "guid": str(uuid.uuid4()),
        "name": f"ZuluSpawner_{elem['name']}",
        "location": [cx, cy, 0],
        "map": "Felucca",
        "count": n_npcs,
        "minDelay": delay_str,
        "maxDelay": delay_str,
        "team": 0,
        "homeRange": 0,
        "walkingRange": -1,
        "spawnBounds": [min_x, min_y, -128, max_x - min_x, max_y - min_y, 256],
        "entries": entries,
    }

# ─── Main ─────────────────────────────────────────────────────────────────────

def main():
    pol = POL_ROOT
    regions_path  = os.path.join(pol, "pkg", "systems", "spawnregion", "config", "spawnregions.cfg")
    groups_path   = os.path.join(pol, "pkg", "systems", "spawnregion", "config", "spawngroups.cfg")
    elements_path = os.path.join(pol, "data", "ds", "spawnregion", "spawregions.2.txt")

    print("Parsing spawnregions.cfg...")
    regions = parse_spawnregions(regions_path)
    print(f"  {len(regions)} real regions found")

    print("Parsing spawngroups.cfg...")
    groups = parse_spawngroups(groups_path)
    print(f"  {len(groups)} groups found")

    print("Parsing spawregions.2.txt...")
    elements = parse_elements(elements_path)
    print(f"  {len(elements)} elements found")

    spawners = []
    skipped = []

    for elem in elements:
        region_name = elem["region"]
        group_id = elem["group_id"]

        if region_name not in regions:
            skipped.append(f"{elem['name']}: region '{region_name}' not found")
            continue
        if group_id not in groups:
            skipped.append(f"{elem['name']}: group {group_id} not found")
            continue

        spawner = build_spawner(elem, regions[region_name], groups[group_id])
        spawners.append(spawner)

    out_path = os.path.abspath(OUTPUT_FILE)
    os.makedirs(os.path.dirname(out_path), exist_ok=True)
    with open(out_path, "w", encoding="utf-8") as f:
        json.dump(spawners, f, indent=2, ensure_ascii=False)

    print(f"\nDone: {len(spawners)} spawners written to {out_path}")
    if skipped:
        print(f"Skipped ({len(skipped)}):")
        for s in skipped:
            print(f"  - {s}")


if __name__ == "__main__":
    main()
```

- [ ] **Step 2: Verificar que o script existe**

```bash
ls Tools/pol_spawn_converter.py
```

Expected: arquivo listado.

- [ ] **Step 3: Commit**

```bash
git add Tools/pol_spawn_converter.py
git commit -m "chore: add POL spawnregion → ModernUO JSON converter script"
```

---

## Task 2: Executar o script e verificar output

**Files:**
- Create: `Distribution/Data/Spawns/zulu/spawnregion.json`

- [ ] **Step 1: Criar pasta de destino se não existir**

```bash
mkdir -p Distribution/Data/Spawns/zulu
```

- [ ] **Step 2: Executar o script**

```bash
python Tools/pol_spawn_converter.py
```

Expected output:
```
Parsing spawnregions.cfg...
  96+ real regions found
Parsing spawngroups.cfg...
  19 groups found
Parsing spawregions.2.txt...
  106 elements found

Done: 90+ spawners written to .../Distribution/Data/Spawns/zulu/spawnregion.json
```

Se houver `[WARN] Unknown template:` — adicionar o template ao `TEMPLATE_MAP` e re-executar.

- [ ] **Step 3: Inspecionar o JSON**

```bash
python -c "
import json
data = json.load(open('Distribution/Data/Spawns/zulu/spawnregion.json'))
print(f'{len(data)} spawners')
print('Sample:', json.dumps(data[0], indent=2))
"
```

Verificar:
- `spawnBounds` tem 6 elementos `[x, y, z, w, h, d]`
- `entries` tem nomes de classes válidos (não templates POL raw)
- `count` > 0 em todos
- `guid` único em todos

- [ ] **Step 4: Commit do output**

```bash
git add Distribution/Data/Spawns/zulu/spawnregion.json
git commit -m "feat: add Zulu Hotel spawnregion spawns (106 regions → ModernUO JSON)"
```

---

## Task 3: Importar e testar no ModernUO

- [ ] **Step 1: Iniciar o servidor ModernUO**

```bash
dotnet run --project Projects/Server
```

- [ ] **Step 2: Importar os spawners**

No cliente UO com conta Developer+:
```
[ImportSpawners Data/Spawns/zulu/spawnregion.json
```

Expected: mensagem no chat confirmando número de spawners criados sem erros.

- [ ] **Step 3: Verificar um spawner in-game**

```
[Go 1496 1628 0
```

Usar `[Props` em um spawner próximo para ver sua configuração. Verificar `SpawnBounds`, `Count`, `Entries`.

- [ ] **Step 4: Verificar logs por erros**

No console do servidor, procurar por:
- `Invalid spawner type` — classe não encontrada
- `Spawner created on Internal map` — coordenadas inválidas

Corrigir qualquer classe inválida no `TEMPLATE_MAP` e re-executar Task 2 se necessário.

---

## Task 4: Migrar sistema spawnpoint (items.txt)

O sistema `spawnpoint` armazena SpawnPoints como items físicos no mundo. As coordenadas estão em `data/items.txt` (save estático do servidor POL). Apenas ~3 SpawnPoints existem no save atual — o servidor estava pouco populado.

**Arquivo fonte:** `D:\OneDrive\Eduardo\Ultima Online Shards\zhna 15-08-13\data\items.txt`

**Formato de cada SpawnPoint:**
```
Name    SpawnPoint [2 vampirebat]
Serial  0x41141ED5
ObjType 0xa300
X       2563
Y       486
Z       0
PointData  ...
```

**Files:**
- Modify: `Tools/pol_spawn_converter.py` (adicionar parser de items.txt)
- Modify: `Distribution/Data/Spawns/zulu/spawnregion.json` ou novo `spawnpoint.json`

- [ ] **Step 1: Adicionar parser de items.txt ao script**

Adicionar ao final de `Tools/pol_spawn_converter.py`, antes do `if __name__ == "__main__":`:

```python
def parse_spawnpoint_items(items_path: str, groups_cfg_path: str) -> list:
    """
    Reads data/items.txt and groups.cfg to produce spawner dicts.
    SpawnPoint items (ObjType 0xa300) have X/Y/Z and Name = 'SpawnPoint [N template]'
    groups.cfg maps group numbers to template lists (equal probability, no weights).
    """
    # Parse groups.cfg (spawnpoint) — equal weight, no numbers
    sp_groups = {}
    current_id = None
    entries = []
    with open(groups_cfg_path, encoding="latin-1") as f:
        for line in f:
            line = line.strip()
            if not line or line.startswith("#"):
                continue
            m = re.match(r'^group\s+(\d+)', line, re.IGNORECASE)
            if m:
                current_id = int(m.group(1))
                entries = []
                continue
            if line == "}" and current_id is not None:
                sp_groups[current_id] = entries
                current_id = None
                continue
            if current_id is not None and not re.match(r'^Name\s+', line, re.IGNORECASE):
                m2 = re.match(r'^spawn\s+(\S+)', line, re.IGNORECASE)
                if m2:
                    entries.append(m2.group(1))

    # Parse items.txt — find all ObjType 0xa300 blocks
    spawners = []
    current = {}
    in_block = False
    with open(items_path, encoding="latin-1") as f:
        for line in f:
            line = line.strip()
            if not line:
                if in_block and current.get("objtype") == "0xa300":
                    # Build spawner from current block
                    name_field = current.get("name", "")
                    # Name format: "SpawnPoint [N template]" or "SpawnPoint [N group:N]"
                    m_tmpl = re.match(r'SpawnPoint\s+\[(\d+)\s+(\S+)\]', name_field, re.IGNORECASE)
                    if m_tmpl and "x" in current and "y" in current:
                        count = int(m_tmpl.group(1))
                        tmpl_or_group = m_tmpl.group(2)
                        x = int(current["x"])
                        y = int(current["y"])
                        z = int(current.get("z", 0))
                        # Determine entries
                        m_grp = re.match(r'group:(\d+)', tmpl_or_group, re.IGNORECASE)
                        if m_grp:
                            gid = int(m_grp.group(1))
                            tmpls = sp_groups.get(gid, [tmpl_or_group])
                        else:
                            tmpls = [tmpl_or_group]
                        entries_out = [
                            {"name": resolve(t), "maxCount": count, "probability": 100}
                            for t in tmpls
                        ]
                        spawners.append({
                            "type": "Spawner",
                            "guid": str(uuid.uuid4()),
                            "name": f"ZuluSpawnpoint_{current.get('serial','?')}",
                            "location": [x, y, z],
                            "map": "Felucca",
                            "count": count,
                            "minDelay": "00:30:00",
                            "maxDelay": "01:00:00",
                            "team": 0,
                            "homeRange": 5,
                            "walkingRange": -1,
                            "entries": entries_out,
                        })
                current = {}
                in_block = False
                continue
            parts = line.split(None, 1)
            if len(parts) == 2:
                key, val = parts[0].lower(), parts[1].strip()
                current[key] = val
                in_block = True
    return spawners
```

Então no `main()`, após gerar `spawners`, adicionar:

```python
    items_path   = os.path.join(pol, "data", "items.txt")
    sp_groups_path = os.path.join(pol, "pkg", "systems", "spawnpoint", "config", "groups.cfg")
    if os.path.exists(items_path):
        print("Parsing spawnpoint items.txt...")
        sp_spawners = parse_spawnpoint_items(items_path, sp_groups_path)
        print(f"  {len(sp_spawners)} spawnpoint spawners found")
        spawners.extend(sp_spawners)
    else:
        print(f"[SKIP] items.txt not found at {items_path}")
```

- [ ] **Step 2: Re-executar o script**

```bash
python Tools/pol_spawn_converter.py
```

Expected: output agora inclui linha `X spawnpoint spawners found` além dos spawnregion spawners.

- [ ] **Step 3: Commit**

```bash
git add Tools/pol_spawn_converter.py Distribution/Data/Spawns/zulu/spawnregion.json
git commit -m "feat: include spawnpoint items.txt in POL spawn converter"
```
