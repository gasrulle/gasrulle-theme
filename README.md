# Gasrulle Theme

A curated **theme pack** for Visual Studio Code — featuring faithfully ported IDE themes and original creations.

## Vision

This extension is a growing collection of themes:
- **Ported themes** — pixel-accurate recreations of popular IDE themes (JetBrains Rider, Visual Studio, and more)
- **Original themes** — unique color schemes designed from scratch

## Currently Included

### Rider Dark (New UI)
The modern JetBrains New UI dark theme (2023+), featuring the refined gray palette, blue accents, and updated syntax highlighting with distinct colors for functions (`#56A8F5`), keywords (`#CF8E6D`), strings (`#6AAB73`), and more.

### Rider Dark (Darcula)
The classic JetBrains Darcula theme, featuring the iconic warm color palette with golden functions (`#FFC66D`), orange keywords (`#CC7832`), green strings (`#6A8759`), and purple properties (`#9876AA`).

### Visual Studio Dark
A faithful port of the Visual Studio IDE Dark theme, with key differences from VS Code's built-in Dark+:
- **Type differentiation**: Structs (`#86C691`), interfaces/enums (`#B8D7A3`), and classes (`#4EC9B0`) each have distinct colors
- **Properties as white**: `.Services`, `.Length`, etc. render as plain text (`#DCDCDC`), not variable-blue
- **Namespaces as white**: `using System.Text` shows namespaces in white, not teal
- **`using` keyword in blue**: Treated as a regular keyword (`#569CD6`), not purple
- **VS IDE string color**: Pinkish `#D69D85` instead of orange `#CE9178`
- **VS IDE comment color**: Brighter green `#57A64A` instead of muted olive `#6A9955`
- **Control flow keywords**: Lavender `#D8A0DF` instead of purple `#C586C0`

Colors sourced from [Roslyn VisualStudio2019.xml](https://github.com/dotnet/roslyn/blob/main/src/VisualStudio/Core/Def/ColorSchemes/VisualStudio2019.xml) (MIT License).

---

### Apex Ember++ *(Original)*
An original "golden standard" dark theme synthesized from the best elements of the most popular community themes. Designed with warm pastels, accessibility research, and maximum C# semantic differentiation.

**Design Philosophy** — what makes this theme special:
- **Night Owl** — Accessibility-first: blue for functions (reading comprehension research), meaningful contrast hierarchy, muted UI chrome
- **Catppuccin** — Warm pastel harmony: soothing colors, balanced saturation, neither too dull nor too bright
- **Tokyo Night** — Semantic sophistication: rich semantic token scoping, intentionally low-contrast UI
- **One Dark Pro** — Clean C# scoping: well-organized type/variable differentiation
- **Dracula** — Vivid accent distinctiveness: every syntax role clearly separated

**C# Semantic Depth (++ = Maximum)**:
- Every type category has a unique color: classes (`#81C8BE` teal), structs (`#A6D9A6` sage), interfaces (`#B4BEFE` lavender), enums (`#EEBEBE` flamingo)
- Properties (`#F4B8E4` pink) are distinct from variables (`#C8CEE0` foreground)
- Parameters (`#E5C890` amber) are distinct from local variables
- Control flow keywords (`#D8B0F8` italic) stand out from regular keywords (`#C9A0F5`)
- Static members get italic styling across all categories
- Enum members use italic to distinguish from the enum type

**Apex Theme Family** — four color temperatures, each with maximum C# semantic depth:
| Variant | Color Temperature | Inspiration | Key Accent |
|---------|------------------|-------------|------------|
| **Ember++** | Warm pastels | Catppuccin + Night Owl warmth | `#8CAAEE` warm blue |
| **Frost++** | Cool & modern | Tokyo Night blue-tinted | `#7AA2F7` azure |
| **Steel++** | Balanced neutral | One Dark Pro balance | `#61AFEF` clear blue |
| **Neon++** | Vibrant & bold | Dracula high energy | `#BD93F9` vivid purple |
| **Carbon++** | Achromatic dark | Pure gray, measured saturation | `#6CAED4` steel blue |

All five use **maximum C# semantic depth (++)** — every type category gets a unique color, properties are distinct from variables, parameters are distinct from locals, static members get italic styling.

### Apex Frost++ *(Original — Cool & Modern)*
A cool blue-tinted dark theme inspired by Tokyo Night Storm. Sleek and professional with sharp syntax against quiet chrome.
- Keywords in azure blue (`#7AA2F7`), functions in cyan (`#7DCFFF`)
- Properties in teal-green (`#73DACA`) for a cool, functional feel
- Blue-gray comments (`#565F89`) blend into the cool background

### Apex Steel++ *(Original — Balanced Neutral)*
A neutral, balanced dark theme inspired by One Dark Pro. Professional clarity without color temperature bias.
- Keywords in purple (`#C678DD`), functions in blue (`#61AFEF`)
- Properties in red-rose (`#E06C75`), the One Dark signature
- Neutral gray comments (`#5C6370`) for clean readability

### Apex Neon++ *(Original — Vibrant & Bold)*
A high-energy dark theme inspired by Dracula. Maximum visual intensity with vivid, saturated colors.
- Keywords in hot pink (`#FF79C6`), functions in neon green (`#50FA7B`)
- Properties in bright orange (`#FFB86C`), electric and warm
- Dracula blue-gray comments (`#6272A4`) stay quiet while neon blazes

### Apex Carbon++ *(Original — Achromatic Dark)*
The only theme in the family with truly achromatic backgrounds (R=G=B). Pure graphite editor surface with zero color cast — every other Apex theme has blue or purple undertones. Syntax colors use measured saturation (25–54%) with hues evenly distributed across the color wheel for perfect temperature neutrality.
- Keywords in dusty rose (`#D4879C`), functions in steel blue (`#6CAED4`)
- Properties in copper (`#D4956C`), warm but never hot
- Pure gray comments (`#6A6A6A`) — achromatic scaffolding for measured syntax

## Planned Themes
- Visual Studio Light
- JetBrains Rider Light (New UI / IntelliJ)

## Installation

### From Source
1. Clone this repository
2. Copy the folder to your VS Code extensions directory:
   - **Windows:** `%USERPROFILE%\.vscode\extensions\`
   - **macOS:** `~/.vscode/extensions/`
   - **Linux:** `~/.vscode/extensions/`
3. Restart VS Code
4. Open **File > Preferences > Color Theme** and select either:
   - `Rider Dark (New UI)`
   - `Rider Dark (Darcula)`

### Using VSCE (for development)
```bash
npm install -g @vscode/vsce
vsce package
code --install-extension gasrulle-theme-0.4.0.vsix
```

## Color Palette Comparison

### Ported Themes

| Element        | New UI Dark   | Darcula       |
|----------------|---------------|---------------|
| Editor BG      | `#1E1F22`     | `#2B2B2B`     |
| Sidebar BG     | `#2B2D30`     | `#3C3F41`     |
| Foreground     | `#BCBEC4`     | `#A9B7C6`     |
| Keywords       | `#CF8E6D`     | `#CC7832`     |
| Strings        | `#6AAB73`     | `#6A8759`     |
| Functions      | `#56A8F5`     | `#FFC66D`     |
| Numbers        | `#2AACB8`     | `#6897BB`     |
| Properties     | `#C77DBB`     | `#9876AA`     |
| Comments       | `#7A7E85`     | `#808080`     |
| Annotations    | `#B3AE60`     | `#BBB529`     |
| Accent         | `#3574F0`     | `#4A88C7`     |

### Apex Ember++ (Warm Pastels)

| Role            | Hex       | Design Source |
|-----------------|-----------|---------------|
| Editor BG       | `#1C1D2A` | Warm purple-tinted dark |
| Sidebar BG      | `#232334` | Lower contrast than editor |
| Foreground      | `#C8CEE0` | Warm off-white |
| Keywords        | `#C9A0F5` | Catppuccin mauve + One Dark purple |
| Control Flow    | `#D8B0F8` | Brighter purple, italic |
| Strings         | `#A6D189` | Catppuccin green warmth |
| Functions       | `#8CAAEE` | Night Owl blue (readability) |
| Numbers         | `#F2B07A` | Peach/amber, warm |
| Properties      | `#F4B8E4` | Catppuccin pink family |
| Variables       | `#C8CEE0` | Foreground (Night Owl: data = white) |
| Parameters      | `#E5C890` | Warm amber, Tokyo Night style |
| Classes         | `#81C8BE` | Warm teal |
| Structs         | `#A6D9A6` | Muted sage |
| Interfaces      | `#B4BEFE` | Catppuccin lavender |
| Enums           | `#EEBEBE` | Flamingo/coral |
| Comments        | `#6C7086` | Warm muted gray |
| Accent          | `#8CAAEE` | Warm blue |

### Apex Frost++ (Cool & Modern)

| Role            | Hex       | Design Source |
|-----------------|-----------|---------------|
| Editor BG       | `#1A1B2E` | Cool blue-tinted dark |
| Sidebar BG      | `#212236` | Cool, lower contrast |
| Foreground      | `#A9B1D6` | Cool blue-white |
| Keywords        | `#7AA2F7` | Azure blue |
| Control Flow    | `#89B4FA` | Brighter blue, italic |
| Strings         | `#9ECE6A` | Cool green |
| Functions       | `#7DCFFF` | Tokyo Night cyan |
| Numbers         | `#FF9E64` | Warm orange contrast pop |
| Properties      | `#73DACA` | Teal-green |
| Variables       | `#C0CAF5` | Cool near-white |
| Parameters      | `#E0AF68` | Warm amber |
| Classes         | `#2AC3DE` | Aqua |
| Structs         | `#89DDFF` | Sky blue |
| Interfaces      | `#BB9AF7` | Lavender-purple |
| Enums           | `#F7768E` | Rose-pink |
| Comments        | `#565F89` | Cool blue-gray |
| Accent          | `#7AA2F7` | Azure blue |

### Apex Steel++ (Balanced Neutral)

| Role            | Hex       | Design Source |
|-----------------|-----------|---------------|
| Editor BG       | `#1E2127` | Neutral dark gray |
| Sidebar BG      | `#252830` | Neutral lighter |
| Foreground      | `#ABB2BF` | One Dark neutral |
| Keywords        | `#C678DD` | One Dark purple |
| Control Flow    | `#D183E8` | Brighter purple, italic |
| Strings         | `#98C379` | One Dark green |
| Functions       | `#61AFEF` | One Dark blue |
| Numbers         | `#D19A66` | One Dark orange |
| Properties      | `#E06C75` | One Dark red-rose |
| Variables       | `#ABB2BF` | Foreground |
| Parameters      | `#E5C07B` | Golden yellow |
| Classes         | `#56B6C2` | Cyan-teal |
| Structs         | `#73C990` | Balanced green |
| Interfaces      | `#C8A2D6` | Soft lavender |
| Enums           | `#E5A6A6` | Soft coral |
| Comments        | `#5C6370` | Neutral gray |
| Accent          | `#61AFEF` | Clear blue |

### Apex Neon++ (Vibrant & Bold)

| Role            | Hex       | Design Source |
|-----------------|-----------|---------------|
| Editor BG       | `#1A1A2E` | Deep neon-dark |
| Sidebar BG      | `#222240` | Dark purple |
| Foreground      | `#F0F0F8` | Bright near-white |
| Keywords        | `#FF79C6` | Hot pink |
| Control Flow    | `#FF92D0` | Brighter pink, italic |
| Strings         | `#F1FA8C` | Electric yellow-green |
| Functions       | `#50FA7B` | Neon green |
| Numbers         | `#BD93F9` | Vivid purple |
| Properties      | `#FFB86C` | Bright orange |
| Variables       | `#F0F0F8` | Near-white |
| Parameters      | `#FFD580` | Warm golden |
| Classes         | `#8BE9FD` | Electric cyan |
| Structs         | `#69FF94` | Bright green |
| Interfaces      | `#CAA0F5` | Vivid lavender |
| Enums           | `#FF6E6E` | Neon coral |
| Comments        | `#6272A4` | Dracula blue-gray |
| Accent          | `#BD93F9` | Vivid purple |

### Apex Carbon++ (Achromatic Dark)

| Role            | Hex       | Design Source |
|-----------------|-----------|---------------|
| Editor BG       | `#1C1C1C` | Pure gray (R=G=B=28) |
| Sidebar BG      | `#242424` | Pure gray, raised surface |
| Foreground      | `#B8B8B8` | Pure silver |
| Keywords        | `#D4879C` | Dusty rose (S:43%) |
| Control Flow    | `#E098AF` | Brighter rose, italic |
| Strings         | `#8BB87E` | Sage green (S:28%) |
| Functions       | `#6CAED4` | Steel blue (S:53%) |
| Numbers         | `#C9A06A` | Topaz amber (S:45%) |
| Properties      | `#D4956C` | Copper (S:54%) |
| Variables       | `#B8B8B8` | Pure silver (achromatic) |
| Parameters      | `#BBA870` | Citrine gold (S:35%) |
| Classes         | `#6AADAE` | Muted turquoise (S:30%) |
| Structs         | `#7DB898` | Malachite green (S:28%) |
| Interfaces      | `#A990C0` | Soft amethyst (S:28%) |
| Enums           | `#C09090` | Garnet (S:25%) |
| Comments        | `#6A6A6A` | Pure gray (achromatic) |
| Accent          | `#6CAED4` | Steel blue |

## Credits

JetBrains theme colors sourced from the official [JetBrains IntelliJ Community Edition](https://github.com/JetBrains/intellij-community) repository (Apache 2.0 License).

## License

[Apache 2.0](LICENSE)
