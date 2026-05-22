# U.V.S. Nirmana Gameplay Data Extraction

## Method

- Target executable: `C:\fdc\U.V.S. Nirmana.exe` in the Wine prefix `/Users/edik/Applications/Sikarugir/Untitled.app/Contents/SharedSupport/prefix`.
- The executable is a Mono/.NET PE32+ assembly targeting .NET Framework 4.6.1. Static decompilation with ILSpy exposed the game model (`Puzzle`, `ToolType`, `SignalInfo`, `Pipeline`, `Solution`, `GameScreen`).
- Runtime reflection under Wine initialized the game localization/resources and invoked the real static constructors for `ToolType` and `Puzzle`, then dumped the authored module and level data. r2frida is installed and available, but reflection was the lower-friction dynamic path for this managed binary.

## Layout And Connection Model

- Pipeline/table modules are placed on integer grid coordinates. A module occupies its declared `width x height` footprint.
- Ports are local vertical lanes inside that footprint, written as `InputN`/`OutputN`. For example, `BUFFER` is `2x3` with `Input1,Output1`, so its ports sit on the middle lane of a 3-high body.
- Pipeline input/source endpoints are pseudo-tools at x=0 with an output port; pipeline output/destination endpoints are pseudo-tools at x=13 with an input port. This makes the authored pipeline span 14 columns (`0..13`).
- Output ports have an editable extension vector `(x,y)`. Inputs do not extend. A connection is made when the extended output endpoint is immediately left of an input port: `output_port_position + extension + (1,0) == input_port_position`.
- Output extensions can run rightward any valid table distance, but their vertical offset is clamped to `-2..2`. Direct lower-left to higher-right connections are therefore possible when the row difference is at most two lanes and the lead does not collide with occupied cells or blocked lead ends.
- Signal rows are integer lanes. Authored normal signals mostly use rows 2..8; level 29 also uses row 100 as a special label/grouping lane.
- The separate circuit/program space uses two instruction cells: `Driver` and `Relay`. Matrix input signals drive row booleans; `Relay` copies active columns to rows, and `Driver` copies active rows to columns. Several modules then read the active state of their own column as control input.
- Pipeline colors are `Green`, `Red`, `Yellow`, or empty. Matrix signals are binary. The 32-character sequence notation below uses `G/R/Y/.` for pipeline colors and `1/.` for matrix activity.

## Modules

| id | name | size | ports | placeable | pseudo | flippable | behavior |
|---:|---|---:|---|---|---|---|---|
| 1 | VALVE | 1x1 | Input0,Output0 | True | False | True | Control-gated pass-through: input0 reaches output0 only while the module column is active in the circuit. |
| 2 | DEMUX | 1x2 | Input1,Output0,Output1 | True | False | True | One-to-two selector: input lane 1 is sent to output lane 0 or 1 depending on circuit control. |
| 3 | MUX | 1x2 | Input0,Input1,Output1 | True | False | True | Two-to-one selector: input lane 0 or 1 is selected to output lane 1 depending on circuit control. |
| 4 | SENSE | 1x1 | Input0,Output0 | True | False | True | Pass-through plus detector: copies input0 to output0 and activates its circuit column when any output color is present. |
| 5 | BUFFER | 2x3 | Input1,Output1 | True | False | False | 2x3 middle-lane storage/buffer module; has internal color/count state and releases compatible queued pipeline values. |
| 6 | ??? | 1x1 | Output0 | False | True | False | Pseudo source endpoint used for pipeline inputs at the left edge; not placeable. |
| 7 | ??? | 1x1 | Input0 | False | True | False | Pseudo sink endpoint used for pipeline outputs at the right edge; not placeable. |
| 8 | PIPE | 1x1 | Input0,Output0 | True | False | False | Unconditional pipe: copies input0 to output0. |
| 9 | NEGATE | 2x3 | Input1,Output1 | True | False | False | Color inverter: Green becomes Red, Red becomes Green, all other colors become empty. |
| 10 | DELAY | 1x1 | Input0,Output0 | True | False | True | Pass-through with delay/counter state; can also activate its circuit column while delayed output is present. |
| 11 | MIXER | 2x3 | Input0,Input2,Output1 | True | False | False | Mixer: Green plus Red on its two inputs produces Yellow on the middle output. |
| 12 | ??? | 1x2 | Input0,Output0,Output1 | True | False | True | Alternate DEMUX orientation paired with tool 2; one input, two outputs. |
| 13 | ??? | 1x2 | Input0,Input1,Output0 | True | False | True | Alternate MUX orientation paired with tool 3; two inputs, one output. |
| 14 | TOGGLE | 1x3 | Input1,Output0,Output2 | True | False | False | Toggle splitter: common middle input alternates between top and bottom outputs. |
| 15 | RED | 1x1 | Input0,Output0 | True | False | True | Pass-through plus red detector: activates its circuit column when observed output is Red. |
| 16 | GREEN | 1x1 | Input0,Output0 | True | False | True | Pass-through plus green detector: activates its circuit column when observed output is Green. |
| 17 | CLEAN | 2x3 | Input1,Output1 | True | False | False | Cleaner/translator: Red becomes Yellow, Yellow becomes Green, all other colors become empty. |
| 18 | XLATE | 2x3 | Input1,Output1 | True | False | False | Translator: any non-empty input becomes Yellow; empty stays empty. |

## Level Toolbox Summary

| level | location | title | unlock | available modules | aux/preloaded modules |
|---:|---|---|---:|---|---|
| 1 | J9 Takka | Infected Transfer Station | 8 | 11:MIXER | (none) |
| 2 | Kita Oriens | Nonrepeating Crystal Field | 25 | 10:DELAY | (none) |
| 3 | Nalanda-1 | The Library Planet | 19 | 5:BUFFER | (none) |
| 4 | U.V.S. Nayuta | Sister Ship of the U.V.S. Nirmana | 28 | (none) | (none) |
| 5 | Maha Talakan | Cultural Exchange Nexus | 5 | 10:DELAY | (none) |
| 6 | Tamra Occidens | Negated Civilization | 22 | 9:NEGATE | (none) |
| 7 | Kamarupa | The Dream-Reality Realm | 16 | 5:BUFFER | (none) |
| 8 | Atali-4 | Alien Mining Colony | 18 | 14:TOGGLE | (none) |
| 9 | B7 Mimohe | Abandoned Transfer Station | 24 | (none) | 2:DEMUX, 3:MUX |
| 10 | Gostana-1 | Ruins of a Lost Civilization | 29 | 15:RED, 10:DELAY | (none) |
| 11 | Udyana-3 | Home of the Eternal Society | 17 | 5:BUFFER | (none) |
| 12 | Wakhsh Prime | Hostile Alien Homeworld | 27 | 14:TOGGLE, 5:BUFFER | (none) |
| 13 | D7 Balura | Phase-Shifted Transfer Station | 14 | (none) | (none) |
| 14 | Syghinan Prime | Graveyard of the Syghinan Empire | 10 | 16:GREEN, 17:CLEAN | (none) |
| 15 | The Batira Object | Galactic Barrier | 15 | 14:TOGGLE | (none) |
| 16 | Invakan-3 | Endangered Civilization | 21 | 10:DELAY | (none) |
| 17 | Mathura Nova | Home of the Great Council | 13 | 15:RED, 9:NEGATE | (none) |
| 18 | SMO | Spherical Metabolic Object | 12 | 14:TOGGLE | (none) |
| 19 | K.N. Uda | Gateway to Tenfold Void | 4 | (none) | (none) |
| 20 | N2 Kurana | Devout Transfer Station | 20 | 16:GREEN, 5:BUFFER | (none) |
| 21 | Hrum-Simigan | Binary Satellite System | 26 | 18:XLATE | 2:DEMUX |
| 22 | Object Jaguda | Space-Time Anomaly | 11 | 14:TOGGLE | (none) |
| 23 | S1 Varnu | Distant Transfer Station | 7 | 16:GREEN, 15:RED | (none) |
| 24 | N.S. Huoh | Compromised Generation Ship | 23 | 15:RED, 9:NEGATE | (none) |
| 25 | Nagarahara | The Nebula of Re-Observation | 3 | 16:GREEN, 15:RED | 2:DEMUX |
| 26 | Komidai-2 | Holographic Civilization | 9 | (none) | 1:VALVE, 2:DEMUX, 3:MUX, 4:SENSE |
| 27 | Z0 Yani | Final Transfer Station | 6 | 5:BUFFER | (none) |
| 28 | Unknown | The Edge of the Universe | 2 | 10:DELAY, 5:BUFFER | (none) |
| 29 | Unknown | Gateway to Nirodha | 1 | 9:NEGATE | (none) |
| 30 | Nirodha | The End of the Universe | 0 | 10:DELAY, 5:BUFFER | (none) |

## Module Availability By Level

| id | name | available in | aux/preloaded in |
|---:|---|---|---|
| 1 | VALVE | (none) | 26:Holographic Civilization |
| 2 | DEMUX | (none) | 9:Abandoned Transfer Station; 21:Binary Satellite System; 25:The Nebula of Re-Observation; 26:Holographic Civilization |
| 3 | MUX | (none) | 9:Abandoned Transfer Station; 26:Holographic Civilization |
| 4 | SENSE | (none) | 26:Holographic Civilization |
| 5 | BUFFER | 3:The Library Planet; 7:The Dream-Reality Realm; 11:Home of the Eternal Society; 12:Hostile Alien Homeworld; 20:Devout Transfer Station; 27:Final Transfer Station; 28:The Edge of the Universe; 30:The End of the Universe | (none) |
| 6 | ??? | (none) | (none) |
| 7 | ??? | (none) | (none) |
| 8 | PIPE | (none) | (none) |
| 9 | NEGATE | 6:Negated Civilization; 17:Home of the Great Council; 24:Compromised Generation Ship; 29:Gateway to Nirodha | (none) |
| 10 | DELAY | 2:Nonrepeating Crystal Field; 5:Cultural Exchange Nexus; 10:Ruins of a Lost Civilization; 16:Endangered Civilization; 28:The Edge of the Universe; 30:The End of the Universe | (none) |
| 11 | MIXER | 1:Infected Transfer Station | (none) |
| 12 | ??? | (none) | (none) |
| 13 | ??? | (none) | (none) |
| 14 | TOGGLE | 8:Alien Mining Colony; 12:Hostile Alien Homeworld; 15:Galactic Barrier; 18:Spherical Metabolic Object; 22:Space-Time Anomaly | (none) |
| 15 | RED | 10:Ruins of a Lost Civilization; 17:Home of the Great Council; 23:Distant Transfer Station; 24:Compromised Generation Ship; 25:The Nebula of Re-Observation | (none) |
| 16 | GREEN | 14:Graveyard of the Syghinan Empire; 20:Devout Transfer Station; 23:Distant Transfer Station; 25:The Nebula of Re-Observation | (none) |
| 17 | CLEAN | 14:Graveyard of the Syghinan Empire | (none) |
| 18 | XLATE | 21:Binary Satellite System | (none) |

## Full Level Signals And Goals

Directions are from the puzzle authoring perspective: `Input` means initial/feed data into the machine, and `Output` means the win-condition target. Objectives preserve the game text with marker syntax.

### 1. Infected Transfer Station (J9 Takka)

Toolbox: 11:MIXER. Aux/preloaded: (none).

Goal: When the *dextro* signal is on, route *❶dextro❶* to *dose*. || When the *levo* signal is on, route *❷levo❷* to *dose*. || When the *mixed* signal is on, use the *mixer* to combine *❶dextro❶* and *❷levo❷* and route the *❸mixture❸* to *dose*.

| kind | dir | row | name | sequence |
|---|---|---:|---|---|
| Pipeline | Input | 6 | DEXTRO | `GGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGG` |
| Pipeline | Input | 4 | LEVO | `RRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRR` |
| Pipeline | Output | 5 | DOSE | `.R.G.R.Y.GG.YY.G.Y.GG.R.G.RR.YY.` |
| Matrix | Input | 5 | DEXTRO | `...1.....11....1...11...1.......` |
| Matrix | Input | 4 | LEVO | `.1...1................1...11....` |
| Matrix | Input | 3 | MIXED | `.......1....11...1...........11.` |

### 2. Nonrepeating Crystal Field (Kita Oriens)

Toolbox: 10:DELAY. Aux/preloaded: (none).

Goal: When the *north*, *east*, *south*, or *west* signal turns on, use the *❶prāna❶* supply to ping the corresponding *❶site❶* for a single cycle.

| kind | dir | row | name | sequence |
|---|---|---:|---|---|
| Pipeline | Input | 5 | +PR | `GGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGG` |
| Matrix | Input | 5 | NORTH | `..11..................1111......` |
| Matrix | Input | 4 | EAST | `......111..........111....1111..` |
| Matrix | Input | 3 | SOUTH | `....11...11...111...............` |
| Matrix | Input | 2 | WEST | `11.........111...11...........11` |
| Pipeline | Output | 8 | NORTH | `..G...................G.........` |
| Pipeline | Output | 6 | EAST | `......G............G......G.....` |
| Pipeline | Output | 4 | SOUTH | `....G....G....G.................` |
| Pipeline | Output | 2 | WEST | `G..........G.....G............G.` |

### 3. The Library Planet (Nalanda-1)

Toolbox: 5:BUFFER. Aux/preloaded: (none).

Goal: Use *buffers* to stream all incoming data to the *archive*, prioritizing *❶text❶* over *❷notes❷* and *❷notes❷* over the *❸index❸*.

| kind | dir | row | name | sequence |
|---|---|---:|---|---|
| Pipeline | Input | 7 | TEXT | `GG..GGG.G...GG.G....G..GGG......` |
| Pipeline | Input | 5 | NOTES | `RR...R...RR...RR......R.R...RR..` |
| Pipeline | Input | 3 | INDEX | `.Y.....Y.Y...YY.....Y...Y..Y....` |
| Pipeline | Output | 5 | ARCHIVE | `GGRRGGGRGRRYGGRGRYYYGYRGGGRYRRYY` |

### 4. Sister Ship of the U.V.S. Nirmana (U.V.S. Nayuta)

Toolbox: (none). Aux/preloaded: (none).

Goal: Activate the *form* signal when only *❶form❶* is present. || Activate the *mind* signal when only *❷mind❷* is present. || Activate the *both* signal when both *❶form❶* and *❷mind❷* are present.

| kind | dir | row | name | sequence |
|---|---|---:|---|---|
| Pipeline | Input | 6 | FORM | `GG..GGG..G.GGG.GG.G.G...GGGGG.GG` |
| Pipeline | Input | 4 | MIND | `..R..RRR.RR...RRR.....R..R.R....` |
| Pipeline | Output | 6 | FORM | `GG..GGG..G.GGG.GG.G.G...GGGGG.GG` |
| Pipeline | Output | 4 | MIND | `..R..RRR.RR...RRR.....R..R.R....` |
| Matrix | Output | 5 | FORM | `11..1......111....1.1...1.1.1.11` |
| Matrix | Output | 4 | MIND | `..1....1..1...1.......1.........` |
| Matrix | Output | 3 | BOTH | `.....11..1.....11........1.1....` |

### 5. Cultural Exchange Nexus (Maha Talakan)

Toolbox: 10:DELAY. Aux/preloaded: (none).

Goal: When the *dose* signal is on, dispense *❸drugs❸* to the different regions of the ambassador's *❸brain❸* as indicated.

| kind | dir | row | name | sequence |
|---|---|---:|---|---|
| Pipeline | Input | 5 | DRUGS | `YYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYY` |
| Matrix | Input | 5 | DOSE | `.1..11..111..1111..1111111111111` |
| Pipeline | Output | 7 | STEM | `.Y..Y...Y....Y.....Y............` |
| Pipeline | Output | 6 | BACK | `.....Y...Y....Y.....Y...........` |
| Pipeline | Output | 5 | LEFT | `..........Y....Y.....Y..........` |
| Pipeline | Output | 4 | RIGHT | `................Y.....Y.........` |
| Pipeline | Output | 3 | FRONT | `.......................YYYYYYYYY` |

### 6. Negated Civilization (Tamra Occidens)

Toolbox: 9:NEGATE. Aux/preloaded: (none).

Goal: Use the *negation engine* to change *❶form❶* into *❷mind❷* and *❷mind❷* into *❶form❶*.

| kind | dir | row | name | sequence |
|---|---|---:|---|---|
| Pipeline | Input | 6 | FORM | `G...GGG.G.GGG.GGGG..GGG.GG..G.G.` |
| Pipeline | Input | 4 | MIND | `..R..RR...RRRRR..R.RRR.R..R.R...` |
| Pipeline | Output | 6 | MIND | `R...RRR.R.RRR.RRRR..RRR.RR..R.R.` |
| Pipeline | Output | 4 | FORM | `..G..GG...GGGGG..G.GGG.G..G.G...` |

### 7. The Dream-Reality Realm (Kamarupa)

Toolbox: 5:BUFFER. Aux/preloaded: (none).

Goal: Use *buffers* to balance between beliefs in the importance of *❶wealth❶*, *❷fame❷*, or *❸power❸*, releasing them only when all three are present.

| kind | dir | row | name | sequence |
|---|---|---:|---|---|
| Pipeline | Input | 7 | WEALTH | `G..G...G..G..GGG.GGGG..GGG..GG..` |
| Pipeline | Input | 5 | FAME | `.R.....RRR..R.RRRRR.R.RR.R.R..R.` |
| Pipeline | Input | 3 | POWER | `..YY..Y..YYYYY.Y.Y...Y..Y..YYY.Y` |
| Pipeline | Output | 7 | WEALTH | `..G....GG.G..GGG.GGG.G..G..GGG.G` |
| Pipeline | Output | 5 | FAME | `..R....RR.R..RRR.RRR.R..R..RRR.R` |
| Pipeline | Output | 3 | POWER | `..Y....YY.Y..YYY.YYY.Y..Y..YYY.Y` |

### 8. Alien Mining Colony (Atali-4)

Toolbox: 14:TOGGLE. Aux/preloaded: (none).

Goal: Use the *❶prāna❶* and *❷apāna❷* supplies to create both *❶near❶* and *❷far❷* field pulse-waves.

| kind | dir | row | name | sequence |
|---|---|---:|---|---|
| Pipeline | Input | 7 | +PR | `GGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGG` |
| Pipeline | Input | 3 | +AP | `RRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRR` |
| Pipeline | Output | 8 | NEAR | `G.G.G.G.G.G.G.G.G.G.G.G.G.G.G.G.` |
| Pipeline | Output | 6 | NEAR' | `.G.G.G.G.G.G.G.G.G.G.G.G.G.G.G.G` |
| Pipeline | Output | 4 | FAR | `.R.R.R.R.R.R.R.R.R.R.R.R.R.R.R.R` |
| Pipeline | Output | 2 | FAR' | `R.R.R.R.R.R.R.R.R.R.R.R.R.R.R.R.` |

### 9. Abandoned Transfer Station (B7 Mimohe)

Toolbox: (none). Aux/preloaded: 2:DEMUX, 3:MUX.

Goal: Use the *❶prāna❶* supply to amplify the prāna *❶trace❶* into *❶form❶*.

| kind | dir | row | name | sequence |
|---|---|---:|---|---|
| Pipeline | Input | 7 | +PR | `GGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGG` |
| Pipeline | Input | 5 | TRACE | `G..GG.G.GG.GGG.....GG.G...GG.G..` |
| Pipeline | Input | 3 | +PR | `GGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGG` |
| Pipeline | Output | 7 | FORM | `G..GG.G.GG.GGG.....GG.G...GG.G..` |
| Pipeline | Output | 5 | FORM | `G..GG.G.GG.GGG.....GG.G...GG.G..` |
| Pipeline | Output | 3 | FORM | `G..GG.G.GG.GGG.....GG.G...GG.G..` |

### 10. Ruins of a Lost Civilization (Gostana-1)

Toolbox: 15:RED, 10:DELAY. Aux/preloaded: (none).

Goal: Using the *sense* input, detect *❷alpha❷* and *❸beta❸* radiation. || Activate the *alpha*, *alpha'*, and *alpha''* signals when *❷alpha❷* radiation is present for at least one, two, and three cycles respectively. || Activate the *beta*, *beta'*, and *beta''* signals when *❸beta❸* radiation is present for at least one, two, and three cycles respectively.

| kind | dir | row | name | sequence |
|---|---|---:|---|---|
| Pipeline | Input | 5 | SENSE | `Y.YYY.RRR.R.Y.Y.YYY.Y.Y.R.R.R.YY` |
| Pipeline | Output | 5 | SENSE | `Y.YYY.RRR.R.Y.Y.YYY.Y.Y.R.R.R.YY` |
| Matrix | Output | 5 | ALPHA | `1.111.......1.1.111.1.1.......11` |
| Matrix | Output | 4 | ALPHA' | `...11............11............1` |
| Matrix | Output | 3 | ALPHA'' | `....1.............1.............` |
| Matrix | Output | 2 | BETA | `......111.1.............1.1.1...` |
| Matrix | Output | 1 | BETA' | `.......11.......................` |
| Matrix | Output | 0 | BETA'' | `........1.......................` |

### 11. Home of the Eternal Society (Udyana-3)

Toolbox: 5:BUFFER. Aux/preloaded: (none).

Goal: Use *buffers* to store *❸solar❸* power. || When the *inner* signal is on, energize the *❸inner❸* shield. || When the *outer* signal is on, energize the *❸outer❸* shield.

| kind | dir | row | name | sequence |
|---|---|---:|---|---|
| Pipeline | Input | 6 | SOLAR | `YYYYYYYY........YYYYYYYY........` |
| Pipeline | Input | 4 | SOLAR | `YYYYYYYY........YYYYYYYY........` |
| Matrix | Input | 5 | INNER | `..1.11.1111...1...1..111....1111` |
| Matrix | Input | 4 | OUTER | `11....111....1111..111..1..11..1` |
| Pipeline | Output | 6 | INNER | `..Y.YY.YYYY...Y...Y..YYY....YYYY` |
| Pipeline | Output | 4 | OUTER | `YY....YYY....YYYY..YYY..Y..YY..Y` |

### 12. Hostile Alien Homeworld (Wakhsh Prime)

Toolbox: 14:TOGGLE, 5:BUFFER. Aux/preloaded: (none).

Goal: When the *fire* signal is on, route *buffered* *❷antimemes❷* back toward the hostile alien beings.

| kind | dir | row | name | sequence |
|---|---|---:|---|---|
| Pipeline | Input | 5 | MEMES | `RRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRR` |
| Matrix | Input | 5 | FIRE | `......1.....11...1.........111..` |
| Pipeline | Output | 8 | MEMES | `......R.....RR...R.........RRR..` |
| Pipeline | Output | 6 | MEMES | `......R.....RR...R.........RRR..` |
| Pipeline | Output | 4 | MEMES | `......R.....RR...R.........RRR..` |
| Pipeline | Output | 2 | MEMES | `......R.....RR...R.........RRR..` |

### 13. Phase-Shifted Transfer Station (D7 Balura)

Toolbox: (none). Aux/preloaded: (none).

Goal: When the *phase* signal is off, route the ship's *❶prāna❶*, *❷apāna❷*, and *❸vyāna❸* supplies to the transfer station. || When the *phase* signal is on, route *❶prāna❶* to *❷apāna❷*, *❷apāna❷*, to *❸vyāna❸*, and *❸vyāna❸* to *❶prāna❶*.

| kind | dir | row | name | sequence |
|---|---|---:|---|---|
| Matrix | Input | 5 | PHASE | `..1.1.1..1.1...11.111..1111.1..1` |
| Pipeline | Input | 7 | +PR | `GGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGG` |
| Pipeline | Input | 5 | +AP | `RRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRR` |
| Pipeline | Input | 3 | +VY | `YYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYY` |
| Pipeline | Output | 7 | +PR | `GGYGYGYGGYGYGGGYYGYYYGGYYYYGYGGY` |
| Pipeline | Output | 5 | +AP | `RRGRGRGRRGRGRRRGGRGGGRRGGGGRGRRG` |
| Pipeline | Output | 3 | +VY | `YYRYRYRYYRYRYYYRRYRRRYYRRRRYRYYR` |

### 14. Graveyard of the Syghinan Empire (Syghinan Prime)

Toolbox: 16:GREEN, 17:CLEAN. Aux/preloaded: (none).

Goal: Use *prāna cleaners* to clean the prāna *❶trace❶* as it passes through the vega drive.

| kind | dir | row | name | sequence |
|---|---|---:|---|---|
| Pipeline | Input | 5 | TRACE | `.RY.G..R.Y.R.GG.YYYR...G.GR.Y.R.` |
| Pipeline | Output | 5 | TRACE | `.GG.G..G.G.G.GG.GGGG...G.GG.G.G.` |

### 15. Galactic Barrier (The Batira Object)

Toolbox: 14:TOGGLE. Aux/preloaded: (none).

Goal: Use the *❶prāna❶*, *❷apāna❷*, and *❸vyāna❸* supplies to create a *bridge* wave-pattern.

| kind | dir | row | name | sequence |
|---|---|---:|---|---|
| Pipeline | Input | 7 | +PR | `GGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGG` |
| Pipeline | Input | 5 | +AP | `RRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRR` |
| Pipeline | Input | 3 | +VY | `YYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYY` |
| Pipeline | Output | 5 | BRIDGE | `GRY.GRY.GRY.GRY.GRY.GRY.GRY.GRY.` |

### 16. Endangered Civilization (Invakan-3)

Toolbox: 10:DELAY. Aux/preloaded: (none).

Goal: Hack the *❷apāna❷* flow of the mahachakra to match the specified pattern.

| kind | dir | row | name | sequence |
|---|---|---:|---|---|
| Pipeline | Input | 5 | ?? | `RRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRR` |
| Matrix | Input | 5 | ?? | `11111.11111.11111.11111.11111.11` |
| Pipeline | Output | 7 | ?? | `R...R.R...R.R...R.R...R.R...R.R.` |
| Pipeline | Output | 6 | ?? | `.R.....R.....R.....R.....R.....R` |
| Pipeline | Output | 5 | ?? | `................................` |
| Pipeline | Output | 4 | ?? | `..RR....RR....RR....RR....RR....` |
| Pipeline | Output | 3 | ?? | `................................` |

### 17. Home of the Great Council (Mathura Nova)

Toolbox: 15:RED, 9:NEGATE. Aux/preloaded: (none).

Goal: Use the *negation engine* to ensure that *❶canon❶* and *❷heresy❷* are each correct.

| kind | dir | row | name | sequence |
|---|---|---:|---|---|
| Pipeline | Input | 6 | CANON | `RG...RRGRRG.R..G.RGGG.G.R.GRR.G.` |
| Pipeline | Input | 4 | HERESY | `RG...RRGRRG.R..G.RGGG.G.R.GRR.G.` |
| Pipeline | Output | 6 | CANON | `GG...GGGGGG.G..G.GGGG.G.G.GGG.G.` |
| Pipeline | Output | 4 | HERESY | `RR...RRRRRR.R..R.RRRR.R.R.RRR.R.` |

### 18. Spherical Metabolic Object (SMO)

Toolbox: 14:TOGGLE. Aux/preloaded: (none).

Goal: Use the *❸vyāna❸* supply to create a *❸sound❸* wave that is either *high* or *low* frequency depending on which signal is on.

| kind | dir | row | name | sequence |
|---|---|---:|---|---|
| Pipeline | Input | 5 | +VY | `YYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYY` |
| Matrix | Input | 5 | HIGH | `.1111111111..............111111.` |
| Matrix | Input | 4 | LOW | `............111111111111........` |
| Pipeline | Output | 6 | SOUND | `.Y.Y.Y.Y.Y..YY..YY..YY...Y.Y.Y..` |
| Pipeline | Output | 4 | SOUND' | `..Y.Y.Y.Y.Y...YY..YY..YY..Y.Y.Y.` |

### 19. Gateway to Tenfold Void (K.N. Uda)

Toolbox: (none). Aux/preloaded: (none).

Goal: When the *X*, *Y*, or *Z* signal is on, route a *❶prāna❶* supply to *❶X❶*, *❶Y❶*, or *❶Z❶* accordingly. || When the *X+Y*, *X+Z*, or *Y+Z* signal is on, route both *❶prāna❶* supplies to those outputs.

| kind | dir | row | name | sequence |
|---|---|---:|---|---|
| Pipeline | Input | 6 | +PR | `GGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGG` |
| Pipeline | Input | 4 | +PR | `GGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGG` |
| Matrix | Input | 5 | X | `1....1......1........1......1...` |
| Matrix | Input | 4 | Y | `..1............1......1..11...1.` |
| Matrix | Input | 3 | Z | `...1....111.....................` |
| Matrix | Input | 2 | X+Y | `.1...........1..1..........1.1..` |
| Matrix | Input | 1 | X+Z | `......11...1.....11.1..11.......` |
| Matrix | Input | 0 | Y+Z | `....1.........1....1...........1` |
| Pipeline | Output | 7 | X | `GG...GGG...GGG..GGG.GG.GG..GGG..` |
| Pipeline | Output | 5 | Y | `.GG.G........GGGG..G..G..GGG.GGG` |
| Pipeline | Output | 3 | Z | `...GG.GGGGGG..G..GGGG..GG......G` |

### 20. Devout Transfer Station (N2 Kurana)

Toolbox: 16:GREEN, 5:BUFFER. Aux/preloaded: (none).

Goal: Use *buffers* to store the *words* of *❶prayers❶* and *❸mantras❸*. || When the *amen* signal turns on, release all stored *❶prayers❶* to *❶form❶*. || When the *svāhā* signal turns on, release all stored *❸mantras❸* to *❸form❸*.

| kind | dir | row | name | sequence |
|---|---|---:|---|---|
| Pipeline | Input | 5 | WORDS | `.GGGG.YYYY.GG.YYGG..Y.Y.GGGG....` |
| Matrix | Input | 5 | AMEN | `....1............1.........1....` |
| Matrix | Input | 4 | SVAHA | `.........1............1.........` |
| Pipeline | Output | 5 | FORM | `....GGGG.YYYY....GGGG.YYYY.GGGG.` |

### 21. Binary Satellite System (Hrum-Simigan)

Toolbox: 18:XLATE. Aux/preloaded: 2:DEMUX.

Goal: Use the *universal translator* to change *❶light❶* and *❷sound❷* into *❸thought❸*.

| kind | dir | row | name | sequence |
|---|---|---:|---|---|
| Pipeline | Input | 6 | LIGHT | `GG.GG...G.G.......G...GG..GG..G.` |
| Pipeline | Input | 4 | SOUND | `.....R.....R.R..R..RRR.......R.R` |
| Pipeline | Output | 5 | THOUGHT | `YY.YYY..Y.YY.Y..Y.YYYYYY..YY.YYY` |

### 22. Space-Time Anomaly (Object Jaguda)

Toolbox: 14:TOGGLE. Aux/preloaded: (none).

Goal: Use the *❶prāna❶* and *❷apāna❷* supplies to stitch the conceptual *thread*.

| kind | dir | row | name | sequence |
|---|---|---:|---|---|
| Pipeline | Input | 6 | +PR | `GGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGG` |
| Pipeline | Input | 4 | +AP | `RRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRR` |
| Pipeline | Output | 6 | THREAD | `GRGRGRGRGRGRGRGRGRGRGRGRGRGRGRGR` |
| Pipeline | Output | 4 | THREAD' | `RGRGRGRGRGRGRGRGRGRGRGRGRGRGRGRG` |

### 23. Distant Transfer Station (S1 Varnu)

Toolbox: 16:GREEN, 15:RED. Aux/preloaded: (none).

Goal: Route *main* to *main* and *backup* to *backup* when both memories are the same.

| kind | dir | row | name | sequence |
|---|---|---:|---|---|
| Pipeline | Input | 6 | MAIN | `GYYGYRRRGYRGGRYGRYYGYGYRYYGGGGGR` |
| Pipeline | Input | 4 | BACKUP | `YYGGYGRRGGYRGRGRRRGGYYRGGYRYYGGR` |
| Pipeline | Output | 6 | MAIN | `.Y.GY.RRG...GR..R..GY....Y...GGR` |
| Pipeline | Output | 4 | BACKUP | `.Y.GY.RRG...GR..R..GY....Y...GGR` |

### 24. Compromised Generation Ship (N.S. Huoh)

Toolbox: 15:RED, 9:NEGATE. Aux/preloaded: (none).

Goal: Use the *negation engine* to negate *❷incorrect❷* beliefs about what is *❶real❶* and *❶finite❶*.

| kind | dir | row | name | sequence |
|---|---|---:|---|---|
| Pipeline | Input | 6 | REAL | `GGGGRRGGGRGGGRRGRGGGGGRGGGGGGGGG` |
| Pipeline | Input | 4 | FINITE | `GGGRGGGRGGGGGGGRGGGGRRGGGRGRGGGG` |
| Pipeline | Output | 6 | REAL | `GGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGG` |
| Pipeline | Output | 4 | FINITE | `GGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGG` |

### 25. The Nebula of Re-Observation (Nagarahara)

Toolbox: 16:GREEN, 15:RED. Aux/preloaded: 2:DEMUX.

Goal: Use the *❶prāna❶*, *❷apāna❷*, and *❸vyāna❸* supplies to imitate *sense* and route it to *mirror*.

| kind | dir | row | name | sequence |
|---|---|---:|---|---|
| Pipeline | Input | 7 | SENSE | `YRGYYGYGYGRYRYRRRYYYYRYYGRRYGRRR` |
| Pipeline | Input | 5 | +PR | `GGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGG` |
| Pipeline | Input | 4 | +AP | `RRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRR` |
| Pipeline | Input | 3 | +VY | `YYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYY` |
| Pipeline | Output | 6 | SENSE | `YRGYYGYGYGRYRYRRRYYYYRYYGRRYGRRR` |
| Pipeline | Output | 4 | MIRROR | `YRGYYGYGYGRYRYRRRYYYYRYYGRRYGRRR` |

### 26. Holographic Civilization (Komidai-2)

Toolbox: (none). Aux/preloaded: 1:VALVE, 2:DEMUX, 3:MUX, 4:SENSE.

Goal: Reroute *❶shape❶* to *❶motion❶*,  *❸motion❸* to *❸depth❸*, and *❷depth❷* to *❷shape❷*.

| kind | dir | row | name | sequence |
|---|---|---:|---|---|
| Pipeline | Input | 7 | SHAPE | `GGGGGGG.GGGGGGG.GGGGGGGGG.GGGGGG` |
| Pipeline | Input | 5 | MOTION | `YYYYYYYYYY.YYYYYYYYY.YYYYYYYYYYY` |
| Pipeline | Input | 3 | DEPTH | `RRRRR.RRRRRR.RRRR.RRRR.RRRRR.RRR` |
| Pipeline | Output | 7 | SHAPE | `RRRRR.RRRRRR.RRRR.RRRR.RRRRR.RRR` |
| Pipeline | Output | 5 | MOTION | `GGGGGGG.GGGGGGG.GGGGGGGGG.GGGGGG` |
| Pipeline | Output | 3 | DEPTH | `YYYYYYYYYY.YYYYYYYYY.YYYYYYYYYYY` |

### 27. Final Transfer Station (Z0 Yani)

Toolbox: 5:BUFFER. Aux/preloaded: (none).

Goal: Use *buffers* to store and release 48 units of *❸snacks❸*.

| kind | dir | row | name | sequence |
|---|---|---:|---|---|
| Pipeline | Input | 8 | SNACKS | `YY..Y..Y.YY.YY.YY.YY............` |
| Pipeline | Input | 6 | SNACKS | `YY.YYY..Y.Y.Y...YYYY............` |
| Pipeline | Input | 4 | SNACKS | `Y.YYYY.YY..Y..YYY..Y............` |
| Pipeline | Input | 2 | SNACKS | `YYY...Y.YYYYY...YY.Y............` |
| Pipeline | Output | 8 | SNACKS | `....................YYYYYYYYYYYY` |
| Pipeline | Output | 6 | SNACKS | `....................YYYYYYYYYYYY` |
| Pipeline | Output | 4 | SNACKS | `....................YYYYYYYYYYYY` |
| Pipeline | Output | 2 | SNACKS | `....................YYYYYYYYYYYY` |

### 28. The Edge of the Universe (Unknown)

Toolbox: 10:DELAY, 5:BUFFER. Aux/preloaded: (none).

Goal: Use *buffers* to store four units of *mind* information. || Then release that information to *who*, *what*, *where*, and *when* at the same time.

| kind | dir | row | name | sequence |
|---|---|---:|---|---|
| Pipeline | Input | 5 | MIND | `.RRGG.GYGG.GGRG..GGRY.YYYG.GRYG.` |
| Pipeline | Output | 8 | WHO | `....R....G....G.....G....Y....G.` |
| Pipeline | Output | 6 | WHAT | `....R....Y....G.....G....Y....R.` |
| Pipeline | Output | 4 | WHERE | `....G....G....R.....R....Y....Y.` |
| Pipeline | Output | 2 | WHEN | `....G....G....G.....Y....G....G.` |

### 29. Gateway to Nirodha (Unknown)

Toolbox: 9:NEGATE. Aux/preloaded: (none).

Goal: Use the *negation engine* to mirror *❶space❶* and *❶time❶* with *❷anti-space❷* and *❷anti-time❷*.

| kind | dir | row | name | sequence |
|---|---|---:|---|---|
| Pipeline | Input | 8 | +X | `.G........G....G......G.........` |
| Pipeline | Input | 7 | -X | `..G....G.G...G.....G.G....G.....` |
| Pipeline | Input | 6 | +Y | `.....G...........G.....G....G...` |
| Pipeline | Input | 5 | -Y | `G...................G.........G.` |
| Pipeline | Input | 4 | +Z | `...G....G..G......G.............` |
| Pipeline | Input | 3 | -Z | `......G.....G............G.G.G..` |
| Pipeline | Input | 2 | T | `....G.........G.G.......G......G` |
| Pipeline | Input | 100 | X/Y/Z/T | `GGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGG` |
| Pipeline | Output | 8 | +X | `.R........R....R......R.........` |
| Pipeline | Output | 7 | -X | `..R....R.R...R.....R.R....R.....` |
| Pipeline | Output | 6 | +Y | `.....R...........R.....R....R...` |
| Pipeline | Output | 5 | -Y | `R...................R.........R.` |
| Pipeline | Output | 4 | +Z | `...R....R..R......R.............` |
| Pipeline | Output | 3 | -Z | `......R.....R............R.R.R..` |
| Pipeline | Output | 2 | T | `....R.........R.R.......R......R` |

### 30. The End of the Universe (Nirodha)

Toolbox: 10:DELAY, 5:BUFFER. Aux/preloaded: (none).

Goal: *❶????❶*

| kind | dir | row | name | sequence |
|---|---|---:|---|---|
| Pipeline | Input | 6 | CAUSE | `.GG...GGGG...GG...GGG...GGGGG...` |
| Pipeline | Input | 4 | EFFECT | `...GG...GGGG...GG...GGG...GGGGG.` |
| Pipeline | Output | 5 | SENSE | `..GG...GGGG...GG...GGG...GGGGG..` |
