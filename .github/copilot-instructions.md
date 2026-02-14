# Copilot Instructions — Gasrulle Theme Pack

## Project Overview
This is a **VS Code theme pack extension** containing a growing collection of color themes:

- **Ported themes** — faithful recreations of IDE themes from JetBrains Rider, Visual Studio, and others
- **Original themes** — unique color schemes designed from scratch

### Currently Implemented
- **Rider Dark (New UI)** — The modern JetBrains 2023+ New UI dark theme (`themes/rider-dark-new-ui-color-theme.json`)
- **Rider Dark (Darcula)** — The classic JetBrains Darcula theme (`themes/rider-dark-darcula-color-theme.json`)
- **Visual Studio Dark** — Faithful VS IDE Dark port (`themes/vs-dark-color-theme.json`)
- **Apex Ember++** — Original warm pastel dark theme, max C# depth (`themes/apex-ember-pp-color-theme.json`)
- **Apex Frost++** — Original cool blue-tinted dark theme, Tokyo Night inspired, max C# depth (`themes/apex-frost-pp-color-theme.json`)
- **Apex Steel++** — Original neutral balanced dark theme, One Dark Pro inspired, max C# depth (`themes/apex-steel-pp-color-theme.json`)
- **Apex Neon++** — Original vibrant high-energy dark theme, Dracula inspired, max C# depth (`themes/apex-neon-pp-color-theme.json`)
- **Apex Carbon++** — Original achromatic dark theme, pure gray backgrounds, measured syntax, max C# depth (`themes/apex-carbon-pp-color-theme.json`)

### Planned
- Visual Studio Light
- JetBrains Rider Light (New UI / IntelliJ)

This is a **pure JSON declarative extension** — no TypeScript, no compilation, no runtime code.

## File Structure
- `package.json` — Extension manifest; registers all themes via `contributes.themes`
- `themes/` — Theme JSON files, one per theme variant
  - `rider-dark-new-ui-color-theme.json` — New UI Dark workbench colors, tokenColors, and semanticTokenColors
  - `rider-dark-darcula-color-theme.json` — Classic Darcula workbench colors, tokenColors, and semanticTokenColors
  - `vs-dark-color-theme.json` — Visual Studio IDE Dark port
  - `apex-ember-pp-color-theme.json` — Original Apex Ember++ (warm pastels, max C# depth)
  - `apex-frost-pp-color-theme.json` — Original Apex Frost++ (cool blue-tinted, Tokyo Night inspired)
  - `apex-steel-pp-color-theme.json` — Original Apex Steel++ (neutral balanced, One Dark Pro inspired)
  - `apex-neon-pp-color-theme.json` — Original Apex Neon++ (vibrant high-energy, Dracula inspired)
  - `apex-carbon-pp-color-theme.json` — Original Apex Carbon++ (achromatic dark, measured syntax)
- `README.md` — User-facing documentation
- `CHANGELOG.md` — Version history
- `LICENSE` — Apache 2.0

## Theme Naming Convention
- All theme labels in `package.json` must be prefixed with `Gasrulle - ` for discoverability in the VS Code theme picker
- Ported themes: `Gasrulle - {Source IDE} {Variant}` (e.g., `Gasrulle - Rider Dark (New UI)`, `Gasrulle - Visual Studio Dark`)
- Original themes: `Gasrulle - {Name}` (e.g., `Gasrulle - Midnight`)
- Theme file names: `{source}-{variant}-color-theme.json` (e.g., `rider-dark-new-ui-color-theme.json`)

## Adding a New Theme
1. **Clone structure**: Copy the closest existing theme file as a starting point (for Apex themes, use an existing Apex file at your target tier; for ported themes, use the closest existing port). This ensures correct workbench color keys, TextMate scope structure, and semantic token patterns are inherited.
2. **Design the palette**: For new Apex variants, follow the **Creating a New Apex Palette** methodology section. For ported themes, extract colors from official sources.
3. **Apply colors**: Replace all hex values in the cloned file with your new palette. Do not remove or reorder existing scopes — only change color values and font styles as needed for your tier.
4. **Register it** in `package.json` under `contributes.themes` following the naming convention.
5. **Choose a depth tier** (base/+/++) — see **C# Semantic Depth Tiers** section for the full specification. Adjust `semanticTokenColors` and `tokenColors` to match.
6. **Validate**: Run `get_errors` on the new theme file to catch invalid/deprecated properties and transparency issues.
7. **Document**: Update `README.md`, `CHANGELOG.md`, and this file (`.github/copilot-instructions.md`) with the new theme's palette table and file listing.
8. **Bump version** in `package.json`.

## Color Sources & Accuracy
For ported themes, colors must be sourced from official repositories to maintain fidelity.

### JetBrains Rider Themes
Sourced from the official [JetBrains IntelliJ Community Edition](https://github.com/JetBrains/intellij-community) repository (Apache 2.0):

- **New UI Dark**: `expUI_dark.theme.json` (workbench) + `expUI_darkScheme.xml` (syntax)
- **Classic Darcula**: `darcula.theme.json` (workbench) + classic Darcula syntax defaults

When modifying or adding colors, always cross-reference the official JetBrains sources above to maintain fidelity.

## Key Color Palettes

### New UI Dark
| Role        | Hex       | Source Key               |
|-------------|-----------|--------------------------|
| Editor BG   | `#1E1F22` | Gray1                    |
| Sidebar BG  | `#2B2D30` | Gray2                    |
| Foreground  | `#BCBEC4` | TEXT foreground           |
| Keywords    | `#CF8E6D` | DEFAULT_KEYWORD          |
| Strings     | `#6AAB73` | DEFAULT_STRING           |
| Functions   | `#56A8F5` | DEFAULT_FUNCTION_DECLARATION |
| Numbers     | `#2AACB8` | DEFAULT_NUMBER           |
| Properties  | `#C77DBB` | DEFAULT_INSTANCE_FIELD   |
| Comments    | `#7A7E85` | DEFAULT_BLOCK_COMMENT    |
| Annotations | `#B3AE60` | DEFAULT_METADATA         |
| Accent      | `#3574F0` | Blue6                    |
| Doc Comments| `#636770` | Dimmed gray, italic      |
| Doc Keywords| `#A89888` | Warm sand                |

### Classic Darcula
| Role        | Hex       |
|-------------|-----------|
| Editor BG   | `#242424` |
| Sidebar BG  | `#2D2F31` |
| Foreground  | `#A9B7C6` |
| Keywords    | `#CC7832` |
| Strings     | `#6A8759` |
| Functions   | `#FFC66D` |
| Numbers     | `#6897BB` |
| Properties  | `#9876AA` |
| Comments    | `#808080` |
| Doc Comments| `#6E7074` | Dimmed gray, italic      |
| Doc Keywords| `#A89888` | Warm sand                |
| Annotations | `#BBB529` |
| Accent      | `#4A88C7` |

### Apex Ember++ (Original)
Synthesized from Night Owl (accessibility), Catppuccin (warmth), Tokyo Night (semantics), One Dark Pro (C# scoping), Dracula (distinctiveness).

| Role            | Hex       | Design Source                        |
|-----------------|-----------|--------------------------------------|
| Editor BG       | `#1C1D2A` | Warm purple-tinted dark              |
| Sidebar BG      | `#232334` | Lower contrast than editor           |
| Foreground      | `#C8CEE0` | Warm off-white                       |
| Keywords        | `#C9A0F5` | Catppuccin mauve + One Dark purple   |
| Control Flow    | `#D8B0F8` | Brighter purple, italic              |
| Strings         | `#A6D189` | Catppuccin green warmth              |
| Functions       | `#8CAAEE` | Night Owl blue (readability)         |
| Numbers         | `#F2B07A` | Peach/amber                          |
| Properties      | `#F4B8E4` | Catppuccin pink family               |
| Variables       | `#C8CEE0` | Foreground (Night Owl: data = white) |
| Parameters      | `#E5C890` | Warm amber, Tokyo Night style        |
| Classes         | `#81C8BE` | Warm teal                            |
| Structs         | `#A6D9A6` | Muted sage (++ only)                 |
| Interfaces      | `#B4BEFE` | Catppuccin lavender (++ only)        |
| Enums           | `#EEBEBE` | Flamingo/coral (++ only)             |
| Comments        | `#6C7086` | Warm muted gray                      |
| Accent          | `#8CAAEE` | Warm blue                            |
| Doc Comments    | `#5E6270` | Dimmed purple-gray, italic             |
| Doc Keywords    | `#A8907E` | Warm amber-sand                        |

### Apex Frost++ (Original — Cool & Modern)
Inspired by Tokyo Night Storm. Cool blue tones, desaturated, sleek.

| Role            | Hex       | Design Source                        |
|-----------------|-----------|--------------------------------------|
| Editor BG       | `#1A1B2E` | Cool blue-tinted dark                |
| Sidebar BG      | `#212236` | Cool, lower contrast                 |
| Foreground      | `#A9B1D6` | Cool blue-white                      |
| Keywords        | `#7AA2F7` | Azure blue                           |
| Control Flow    | `#89B4FA` | Brighter blue, italic                |
| Strings         | `#9ECE6A` | Cool green                           |
| Functions       | `#7DCFFF` | Tokyo Night cyan                     |
| Numbers         | `#FF9E64` | Warm orange contrast pop             |
| Properties      | `#73DACA` | Teal-green                           |
| Variables       | `#C0CAF5` | Cool near-white                      |
| Parameters      | `#E0AF68` | Warm amber                           |
| Classes         | `#2AC3DE` | Aqua                                 |
| Structs         | `#89DDFF` | Sky blue (++ only)                   |
| Interfaces      | `#BB9AF7` | Lavender-purple (++ only)            |
| Enums           | `#F7768E` | Rose-pink (++ only)                  |
| Comments        | `#565F89` | Cool blue-gray                       |
| Accent          | `#7AA2F7` | Azure blue                           |
| Doc Comments    | `#4C5576` | Dimmed blue-gray, italic               |
| Doc Keywords    | `#7E90A8` | Cool steel-blue                        |

### Apex Steel++ (Original — Balanced Neutral)
Inspired by One Dark Pro. Clean, balanced, no strong color temperature bias.

| Role            | Hex       | Design Source                        |
|-----------------|-----------|--------------------------------------|
| Editor BG       | `#1E2127` | Neutral dark gray                    |
| Sidebar BG      | `#252830` | Neutral lighter                      |
| Foreground      | `#ABB2BF` | One Dark neutral                     |
| Keywords        | `#C678DD` | One Dark purple                      |
| Control Flow    | `#D183E8` | Brighter purple, italic              |
| Strings         | `#98C379` | One Dark green                       |
| Functions       | `#61AFEF` | One Dark blue                        |
| Numbers         | `#D19A66` | One Dark orange                      |
| Properties      | `#E06C75` | One Dark red-rose                    |
| Variables       | `#ABB2BF` | Foreground                           |
| Parameters      | `#E5C07B` | Golden yellow                        |
| Classes         | `#56B6C2` | Cyan-teal                            |
| Structs         | `#73C990` | Balanced green (++ only)             |
| Interfaces      | `#C8A2D6` | Soft lavender (++ only)              |
| Enums           | `#E5A6A6` | Soft coral (++ only)                 |
| Comments        | `#5C6370` | Neutral gray                         |
| Accent          | `#61AFEF` | Clear blue                           |
| Doc Comments    | `#515660` | Dimmed neutral gray, italic            |
| Doc Keywords    | `#A89888` | Warm sand                              |

### Apex Neon++ (Original — Vibrant & Bold)
Inspired by Dracula. Maximum visual energy, vivid saturated colors.

| Role            | Hex       | Design Source                        |
|-----------------|-----------|--------------------------------------|
| Editor BG       | `#1A1A2E` | Deep neon-dark                       |
| Sidebar BG      | `#222240` | Dark purple                          |
| Foreground      | `#F0F0F8` | Bright near-white                    |
| Keywords        | `#FF79C6` | Hot pink                             |
| Control Flow    | `#FF92D0` | Brighter pink, italic                |
| Strings         | `#F1FA8C` | Electric yellow-green                |
| Functions       | `#50FA7B` | Neon green                           |
| Numbers         | `#BD93F9` | Vivid purple                         |
| Properties      | `#FFB86C` | Bright orange                        |
| Variables       | `#F0F0F8` | Near-white                           |
| Parameters      | `#FFD580` | Warm golden                          |
| Classes         | `#8BE9FD` | Electric cyan                        |
| Structs         | `#69FF94` | Bright green (++ only)               |
| Interfaces      | `#CAA0F5` | Vivid lavender (++ only)             |
| Enums           | `#FF6E6E` | Neon coral (++ only)                 |
| Comments        | `#6272A4` | Dracula blue-gray                    |
| Accent          | `#BD93F9` | Vivid purple                         |
| Doc Comments    | `#565E90` | Dimmed blue-purple, italic             |
| Doc Keywords    | `#A898B0` | Muted lilac                            |

### Apex Carbon++ (Original — Achromatic Dark)
Pure graphite. Zero color cast in backgrounds (R=G=B). Measured saturation syntax with evenly distributed hues. De-yellowed: warm tokens redistributed across hue wheel to eliminate amber cast.

| Role            | Hex       | Design Source                        |
|-----------------|-----------|--------------------------------------|
| Editor BG       | `#202020` | Pure gray (R=G=B=32)                 |
| Sidebar BG      | `#282828` | Pure gray, raised surface            |
| Foreground      | `#D8D8D8` | Pure silver                          |
| Keywords        | `#D8809A` | Dusty rose, brighter                 |
| Control Flow    | `#E090AA` | Brighter rose, italic                |
| Strings         | `#8CC47C` | Sage green, brighter                 |
| Functions       | `#68B8E4` | Steel blue, brighter                 |
| Numbers         | `#C8A078` | Desaturated sand (S:28%, cooled)     |
| Properties      | `#C88878` | Muted terracotta (hue 12°, cooled)   |
| Variables       | `#D4D4D4` | Pure silver (achromatic)             |
| Parameters      | `#98B880` | Eucalyptus sage (hue ~100°, cooled)  |
| Classes         | `#58B8B8` | Muted turquoise, brighter            |
| Structs         | `#68C490` | Malachite green, brighter            |
| Interfaces      | `#A888C8` | Soft amethyst, brighter              |
| Enums           | `#C48088` | Garnet, brighter                     |
| Comments        | `#7A7A7A` | Pure gray (achromatic)               |
| Accent          | `#68B8E4` | Steel blue                           |
| Doc Comments    | `#686868` | Pure gray (R=G=B), italic              |
| Doc Keywords    | `#A09890` | Near-achromatic sand (S≈5%)            |

### Apex Theme Family Naming
- **Variants**: Ember (warm), Frost (cool), Steel (neutral), Neon (vibrant), Carbon (achromatic)
- **C# depth**: Only ++ (maximum) tier is currently implemented
- **Labels**: `Gasrulle - Apex {Variant}++`
- **File names**: `apex-{variant}-pp-color-theme.json`

## Creating a New Apex Palette — Design Methodology

When creating a brand-new Apex color variant (not converting tiers), follow this process to produce a cohesive palette that fits the family.

### Step 1: Choose a Color Temperature & Inspiration
- Pick a temperature identity: **warm**, **cool**, **neutral**, **vibrant**, or **achromatic**
- Name the variant with an evocative single word that communicates the mood (e.g., Ember = warm fire, Frost = icy, Carbon = graphite)
- Optionally pick 1–3 popular themes as inspiration sources (e.g., Catppuccin, Tokyo Night, One Dark Pro, Dracula, Night Owl)

### Step 2: Design the Background Surface Stack
All backgrounds should share the same color temperature. Build from darkest to lightest:

| Surface | Lightness guideline | Notes |
|---------|--------------------|---------|
| Editor BG | Darkest (~L 10–13%) | Primary canvas |
| Sidebar / Activity Bar | +2–4 lightness steps | Subtle distinction |
| Panel / Terminal BG | Same as sidebar or editor | Depends on preference |
| Input / Dropdown BG | +1–3 above sidebar | Interactive surfaces |
| Hover / Selection | Editor BG + alpha overlay | Use `#RRGGBBAA` with `30`–`50` alpha |

**Achromatic rule**: If the variant has no color cast, all background channels must satisfy R=G=B (pure gray).

**Color-tinted rule**: Add a subtle hue shift to all backgrounds matching the temperature (e.g., Ember adds warm purple `#1C1D2A`, Frost adds cool blue `#1A1B2E`).

### Step 3: Derive the Core Syntax Palette
Assign colors to these roles, ensuring they are visually distinct from each other and readable against the editor BG:

| Role | Design guidance |
|------|-----------------|
| **Foreground** | Match temperature. Warm → off-white with warm tint. Cool → blue-white. Achromatic → pure gray `#B8B8B8`. |
| **Keywords** | The theme's signature color. Should be bold and recognizable. |
| **Control Flow** | Brighter/lighter version of keyword color. Must remain in the same hue family. Always italic in + and ++ tiers. |
| **Strings** | Green family is near-universal convention (sage, forest, lime, electric). Stay in green hues. |
| **Functions** | High-readability color, often blue or cyan. Must contrast clearly with keywords. |
| **Numbers** | Warm accent (orange, amber, peach) or a hue distinct from strings and keywords. |
| **Properties** | Distinct from both foreground/variables and functions. Pink, red, copper, or teal work well. |
| **Parameters** | Warm amber/gold tones work across all temperatures. Must differ from properties and foreground. Only distinct in ++ tier. |
| **Classes** | Teal/cyan family is conventional. Serves as the "anchor" type color. |
| **Structs** | Related to but lighter/greener than class color. Only distinct in ++ tier. |
| **Interfaces** | Lavender/purple family to contrast with teal classes. Only distinct in ++ tier. |
| **Enums** | Coral/pink/rose to contrast with other type colors. Only distinct in ++ tier. |
| **Comments** | Muted gray matching the background temperature. Should be clearly de-emphasized. |
| **Doc Comments** | Dimmed below regular comments so documentation recedes behind code. Temperature-tinted gray matching the theme's comment hue family. Must be distinct from regular comments but never compete with syntax. |
| **Accent** | Usually matches function or keyword color. Used for links, focus borders, buttons. |

### Step 4: Saturation & Contrast Checks
- **Minimum contrast**: All syntax colors should be clearly readable against the editor BG. Aim for WCAG AA (~4.5:1) for primary tokens (keywords, functions, strings), relaxed for secondary tokens (comments).
- **Saturation range**: Decide on a saturation character:
  - Vibrant themes: 60–100% saturation (Neon)
  - Standard themes: 40–70% saturation (Ember, Frost, Steel)
  - Achromatic themes: 25–54% saturation with even hue distribution (Carbon)
- **Hue distribution**: For achromatic/neutral variants, distribute hues evenly across the color wheel so no temperature dominates. For temperature-biased variants, cluster syntax hues around the chosen temperature with 1–2 complementary contrast pops (e.g., Frost uses warm orange `#FF9E64` for numbers as a deliberate contrast against cool blues).

### Step 5: Build the Workbench Colors
Clone the `colors` section from the closest existing Apex theme, then:
1. Replace all background hex values with your new surface stack
2. Replace foreground/text hex values with your new foreground
3. Replace accent-colored UI elements (buttons, links, focus borders, badges) with your accent color
4. Adjust selection/highlight overlays — keep the same alpha values, change the base hue
5. Ensure all overlay colors include alpha channels (`#RRGGBBAA`)

### Step 6: Build tokenColors and semanticTokenColors
1. Clone from the closest existing Apex theme at the same tier
2. Replace every hex value with the corresponding role from your palette table
3. Do NOT change scope selectors, font styles, or structural patterns — only colors
4. Follow the tier specification (base/+/++) from the section below

### Palette Documentation
After creating a new variant, add its palette table to this file following the existing format:
- Include all roles from Foreground through Accent
- Add "Design Source" descriptions explaining each color choice
- For achromatic themes, include saturation percentages
- For inspired themes, note which source theme influenced each color

## C# Semantic Depth Tiers — Base / + / ++

The Apex family supports three depth tiers controlling how many distinct semantic tokens are used. Each tier builds on the previous. When creating a new theme or converting between tiers, use this reference.

### Tier Overview

| Aspect | Base (minimal) | + (moderate) | ++ (maximum) |
|--------|----------------|--------------|--------------|
| Type colors | 1 color for all types | class ≠ interface | class ≠ struct ≠ interface ≠ enum ≠ typeParameter (5 distinct) |
| Property vs variable | Same color (foreground) | Properties get a unique color | Properties get a unique color |
| Parameter vs variable | Same color (foreground) | Same color (foreground) | Parameters get a unique color |
| Enum members | Same as constants | Same as enum type | Number color + italic |
| Control flow keywords | Same as keywords | Brighter shade + italic | Brighter shade + italic |
| Static modifiers | No italic | Italic on properties and methods | Italic on all: property, variable, function, method |
| Variable.readonly | No italic | No italic | Italic |
| Events | Same as type color | Same as type color | Explicit type color entry |
| Ideal audience | Users who prefer simplicity | C# devs wanting key distinctions | C# devs wanting maximum information density |

### Base (Minimal) — Scope Reduction Guide

When creating a **base** theme from a ++ theme, make these changes to `semanticTokenColors`:

```jsonc
"semanticTokenColors": {
    // Types — single color for all
    "type": "{CLASS_COLOR}",
    "class": "{CLASS_COLOR}",
    "struct": "{CLASS_COLOR}",          // ← same as class (was unique in ++)
    "interface": "{CLASS_COLOR}",       // ← same as class (was unique in ++)
    "enum": "{CLASS_COLOR}",            // ← same as class (was unique in ++)
    "typeParameter": "{CLASS_COLOR}",   // ← same as class (was unique in ++)
    "namespace": "{NAMESPACE_COLOR}",
    // Functions
    "function": "{FUNCTION_COLOR}",
    "method": "{FUNCTION_COLOR}",
    "function.declaration": "{FUNCTION_COLOR}",
    "method.declaration": "{FUNCTION_COLOR}",
    // Properties — same as foreground (no distinction)
    "property": "{FOREGROUND}",         // ← same as variables (was unique in ++)
    // Variables — all the same
    "variable": "{FOREGROUND}",
    "parameter": "{FOREGROUND}",        // ← same as variables (was unique in ++)
    // Enum Members — same as constants, no italic
    "enumMember": "{NUMBER_COLOR}",     // ← no italic, no enum color
    // Events — same as type
    "event": "{CLASS_COLOR}",
    // Keywords — no control flow distinction
    "keyword": "{KEYWORD_COLOR}",
    // ← REMOVE keyword.controlFlow (no distinction)
    "operator": "{OPERATOR_COLOR}",
    "newOperator": "{KEYWORD_COLOR}",
    // Strings / Numbers
    "string": "{STRING_COLOR}",
    "number": "{NUMBER_COLOR}",
    // Other
    "regexp": "{REGEXP_COLOR}",
    "decorator": "{DECORATOR_COLOR}",
    "comment": "{COMMENT_COLOR}"
    // ← REMOVE all .static entries (no italic modifiers)
    // ← REMOVE variable.readonly (no italic)
    // ← REMOVE stringLiteral, numberLiteral, customLiteral (unnecessary aliases)
    // ← REMOVE macro, label (keep simple)
}
```

Also in `tokenColors`:
- **Remove** the separate `keyword.control.conditional` / `keyword.control.flow` / `keyword.control.loop` / `keyword.control.trycatch` rule (merge into main keyword rule)
- **Change** all type scopes (`entity.name.type.class`, `.struct`, `.interface`, `.enum`) to use the same single color

### + (Moderate) — Scope Reduction Guide

When creating a **+** theme from a ++ theme, make these changes:

```jsonc
"semanticTokenColors": {
    // Types — class ≠ interface, but struct/enum share class color
    "type": "{CLASS_COLOR}",
    "class": "{CLASS_COLOR}",
    "struct": "{CLASS_COLOR}",          // ← same as class (was unique in ++)
    "interface": "{INTERFACE_COLOR}",   // ← keeps distinct color from ++
    "enum": "{CLASS_COLOR}",            // ← same as class (was unique in ++)
    "typeParameter": "{CLASS_COLOR}",   // ← same as class (was unique in ++)
    "namespace": "{NAMESPACE_COLOR}",
    // Functions
    "function": "{FUNCTION_COLOR}",
    "method": "{FUNCTION_COLOR}",
    "function.declaration": "{FUNCTION_COLOR}",
    "method.declaration": "{FUNCTION_COLOR}",
    // Properties — distinct from variables (keeps ++ behavior)
    "property": "{PROPERTY_COLOR}",
    "property.static": {
        "foreground": "{PROPERTY_COLOR}",
        "fontStyle": "italic"           // ← static italic retained for properties
    },
    // Variables — parameters same as variables (unlike ++)
    "variable": "{FOREGROUND}",
    "parameter": "{FOREGROUND}",        // ← same as variables (was unique in ++)
    // ← REMOVE variable.readonly (no italic)
    // ← REMOVE variable.static (no italic)
    // Enum Members — same as enum type, no italic
    "enumMember": "{CLASS_COLOR}",      // ← no italic, uses class/type color
    // Events — same as type
    "event": "{CLASS_COLOR}",
    // Keywords — control flow gets distinction (keeps ++ behavior)
    "keyword": "{KEYWORD_COLOR}",
    "keyword.controlFlow": {
        "foreground": "{CONTROL_FLOW_COLOR}",
        "fontStyle": "italic"
    },
    "operator": "{OPERATOR_COLOR}",
    "newOperator": "{KEYWORD_COLOR}",
    // Strings / Numbers
    "string": "{STRING_COLOR}",
    "number": "{NUMBER_COLOR}",
    // Other
    "regexp": "{REGEXP_COLOR}",
    "decorator": "{DECORATOR_COLOR}",
    "comment": "{COMMENT_COLOR}",
    // Static — only properties and methods get italic
    "function.static": {
        "foreground": "{FUNCTION_COLOR}",
        "fontStyle": "italic"
    },
    "method.static": {
        "foreground": "{FUNCTION_COLOR}",
        "fontStyle": "italic"
    }
    // ← REMOVE stringLiteral, numberLiteral, customLiteral
    // ← REMOVE macro, label
}
```

Also in `tokenColors`:
- **Keep** the separate control flow keyword rule (italic + brighter shade)
- **Change** type scopes: `entity.name.type.struct` and `.enum` share the class color; `.interface` stays distinct

### ++ (Maximum) — Full Specification

The ++ tier is what all current Apex themes implement. The full `semanticTokenColors` pattern:

```jsonc
"semanticTokenColors": {
    // Types — every category distinct
    "type": "{CLASS_COLOR}",
    "class": "{CLASS_COLOR}",
    "struct": "{STRUCT_COLOR}",         // unique
    "interface": "{INTERFACE_COLOR}",   // unique
    "enum": "{ENUM_COLOR}",             // unique
    "typeParameter": "{TYPE_PARAM_COLOR}", // unique
    "namespace": "{NAMESPACE_COLOR}",
    // Functions
    "function": "{FUNCTION_COLOR}",
    "method": "{FUNCTION_COLOR}",
    "function.declaration": "{FUNCTION_COLOR}",
    "method.declaration": "{FUNCTION_COLOR}",
    // Properties — distinct from variables
    "property": "{PROPERTY_COLOR}",
    "property.static": { "foreground": "{PROPERTY_COLOR}", "fontStyle": "italic" },
    // Variables
    "variable": "{FOREGROUND}",
    "variable.readonly": { "foreground": "{FOREGROUND}", "fontStyle": "italic" },
    "variable.static": { "foreground": "{FOREGROUND}", "fontStyle": "italic" },
    // Parameters — distinct from variables
    "parameter": "{PARAMETER_COLOR}",   // unique
    // Enum Members — number color + italic for constant-like feel
    "enumMember": { "foreground": "{NUMBER_COLOR}", "fontStyle": "italic" },
    // Events — explicit type entry
    "event": "{CLASS_COLOR}",
    // Keywords with control flow distinction
    "keyword": "{KEYWORD_COLOR}",
    "keyword.controlFlow": { "foreground": "{CONTROL_FLOW_COLOR}", "fontStyle": "italic" },
    // Operators
    "operator": "{OPERATOR_COLOR}",
    "newOperator": "{KEYWORD_COLOR}",
    // Strings / Numbers (with literal aliases)
    "string": "{STRING_COLOR}",
    "stringLiteral": "{STRING_COLOR}",
    "number": "{NUMBER_COLOR}",
    "numberLiteral": "{NUMBER_COLOR}",
    // Other
    "regexp": "{REGEXP_COLOR}",
    "decorator": "{DECORATOR_COLOR}",
    "comment": "{COMMENT_COLOR}",
    "customLiteral": "{NUMBER_COLOR}",
    "macro": "{DECORATOR_COLOR}",
    "label": "{OPERATOR_COLOR}",
    // Static modifiers — italic across all categories
    "function.static": { "foreground": "{FUNCTION_COLOR}", "fontStyle": "italic" },
    "method.static": { "foreground": "{FUNCTION_COLOR}", "fontStyle": "italic" },
    // C# XML Doc Comments (Roslyn custom tokens)
    "xmlDocCommentText": { "foreground": "{DOC_COMMENT_COLOR}", "fontStyle": "italic" },
    "xmlDocCommentDelimiter": "{DOC_COMMENT_COLOR}",
    "xmlDocCommentName": "{DOC_KEYWORD_COLOR}",
    "xmlDocCommentAttributeName": "{DOC_KEYWORD_COLOR}",
    "xmlDocCommentAttributeQuotes": "{DOC_COMMENT_COLOR}",
    "xmlDocCommentAttributeValue": "{DOC_KEYWORD_COLOR}",
    "xmlDocCommentCDataSection": { "foreground": "{DOC_COMMENT_COLOR}", "fontStyle": "italic" },
    "xmlDocCommentEntityReference": "{DOC_KEYWORD_COLOR}",
    "xmlDocCommentProcessingInstruction": "{DOC_KEYWORD_COLOR}",
    "xmlDocCommentComment": "{COMMENT_COLOR}"
}
```

### Quick Reference: What Changes Between Tiers

| Token | Base | + | ++ |
|-------|------|---|-----|
| `struct` | = class | = class | **unique color** |
| `interface` | = class | **unique color** | **unique color** |
| `enum` | = class | = class | **unique color** |
| `typeParameter` | = class | = class | **unique color** |
| `property` | = foreground | **unique color** | **unique color** |
| `parameter` | = foreground | = foreground | **unique color** |
| `enumMember` | = number | = class | **number color + italic** |
| `keyword.controlFlow` | = keyword | **brighter + italic** | **brighter + italic** |
| `variable.readonly` | normal | normal | **italic** |
| `variable.static` | normal | normal | **italic** |
| `property.static` | normal | **italic** | **italic** |
| `function.static` | normal | **italic** | **italic** |
| `method.static` | normal | **italic** | **italic** |
| `stringLiteral` etc. | omitted | omitted | **included** |
| `macro`, `label` | omitted | omitted | **included** |

### File Naming by Tier
| Tier | Label suffix | File suffix | Example |
|------|-------------|-------------|---------|
| Base | (none) | `-color-theme.json` | `apex-ember-color-theme.json` |
| + | `+` | `-p-color-theme.json` | `apex-ember-p-color-theme.json` |
| ++ | `++` | `-pp-color-theme.json` | `apex-ember-pp-color-theme.json` |

### Design Principles Across All Tiers
Regardless of C# depth tier, every Apex theme must:
1. Follow the variant's color palette (backgrounds, foreground, accent, comment color stay the same across tiers)
2. Maintain the variant's color temperature (warm/cool/neutral/vibrant/achromatic)
3. Use the same workbench `colors` section — tier only affects `tokenColors` and `semanticTokenColors`
4. Keep `semanticHighlighting: true` in all tiers (even base uses some semantic tokens)

## Conventions & Rules

### Theme JSON Structure
Each theme file uses this structure (with JSONC — comments are allowed):
```jsonc
{
  "name": "...",
  "type": "dark",
  "semanticHighlighting": true,
  "colors": { /* workbench colors */ },
  "tokenColors": [ /* TextMate scope rules */ ],
  "semanticTokenColors": { /* semantic token overrides */ }
}
```

### When Adding New Token Colors
1. For ported themes: map source IDE attribute names → VS Code TextMate scopes (e.g., JetBrains `DEFAULT_KEYWORD` → `keyword`, `keyword.control`)
2. When updating a theme family (e.g., Rider), add the rule to **all** variants with the appropriate color for each palette
3. Use semantic token colors where VS Code supports them for more precise highlighting
4. Keep scope arrays sorted alphabetically within each rule
5. **Never** add a flat `"comment"` entry to `semanticTokenColors` — it overrides all comment sub-types (including doc comments) with a single color. Instead, rely on TextMate `tokenColors` for comment styling.

### C# XML Doc Comment Semantic Tokens
C# Roslyn emits custom semantic token types for XML doc comments that are **not** part of the standard VS Code semantic token set. All themes must include explicit entries in `semanticTokenColors` to prevent these from falling back to default comment gray:

```jsonc
"semanticTokenColors": {
    // ... other tokens ...
    // ── C# XML Doc Comments (custom semantic tokens from Roslyn) ──
    "xmlDocCommentText": { "foreground": "{DOC_COMMENT_COLOR}", "fontStyle": "italic" },
    "xmlDocCommentDelimiter": "{DOC_COMMENT_COLOR}",
    "xmlDocCommentName": "{DOC_KEYWORD_COLOR}",
    "xmlDocCommentAttributeName": "{DOC_KEYWORD_COLOR}",
    "xmlDocCommentAttributeQuotes": "{DOC_COMMENT_COLOR}",
    "xmlDocCommentAttributeValue": "{DOC_KEYWORD_COLOR}",
    "xmlDocCommentCDataSection": { "foreground": "{DOC_COMMENT_COLOR}", "fontStyle": "italic" },
    "xmlDocCommentEntityReference": "{DOC_KEYWORD_COLOR}",
    "xmlDocCommentProcessingInstruction": "{DOC_KEYWORD_COLOR}",
    "xmlDocCommentComment": "{REGULAR_COMMENT_COLOR}"
}
```

**Current doc comment colors per theme:**
| Theme | Doc Body | Doc Keywords | Style |
|-------|---------|-------------|-------|
| Rider New UI | `#636770` | `#A89888` | Dimmed gray + warm sand |
| Rider Darcula | `#6E7074` | `#A89888` | Dimmed gray + warm sand |
| Visual Studio Dark | `#656A6E` | `#A89888` | Dimmed gray + warm sand |
| Apex Ember++ | `#5E6270` | `#A8907E` | Dimmed purple-gray + warm amber-sand |
| Apex Frost++ | `#4C5576` | `#7E90A8` | Dimmed blue-gray + cool steel-blue |
| Apex Steel++ | `#515660` | `#A89888` | Dimmed neutral gray + warm sand |
| Apex Neon++ | `#565E90` | `#A898B0` | Dimmed blue-purple + muted lilac |
| Apex Carbon++ | `#686868` | `#A09890` | Pure gray + near-achromatic sand |

### When Adding Workbench Colors
1. Look up the VS Code color key in the [Theme Color Reference](https://code.visualstudio.com/api/references/theme-color)
2. Transparency is **required** for overlay/highlight colors (e.g., `editor.wordHighlightBackground` must include alpha like `#RRGGBBAA`)
3. Use the deprecated key checker — prefer `editorIndentGuide.background1` over `editorIndentGuide.background`
4. Add the color to **all** theme files in the same family

### Quality Checks
- Run `get_errors` on all modified theme files after any edit to catch invalid/deprecated properties and transparency requirements
- Colors marked "must be transparent" by VS Code need an alpha channel suffix (e.g., `CC`, `80`, `44`)
- Property names must exist in the VS Code API — invalid ones cause warnings
- For ported themes: verify colors match official sources before committing

### Packaging
```bash
npm install -g @vscode/vsce
vsce package
```
This produces a `.vsix` file for distribution.

### Testing
Press `F5` in VS Code to launch the Extension Development Host, then select the theme under **File > Preferences > Color Theme**.
