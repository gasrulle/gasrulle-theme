# Gasrulle Theme

A curated **theme pack** for Visual Studio Code — featuring faithfully ported IDE themes and original creations.

![Theme Preview](https://raw.githubusercontent.com/gasrulle/gasrulle-theme/main/theme-hero.gif)

## Currently Included

### Rider Dark (New UI)
The modern JetBrains New UI dark theme (2023+), featuring the refined gray palette, blue accents, and updated syntax highlighting with distinct colors for functions (`#56A8F5`), keywords (`#CF8E6D`), strings (`#6AAB73`), and more.

### Rider Dark (Darcula)
The classic JetBrains Darcula theme, featuring the iconic warm color palette with golden functions (`#FFC66D`), orange keywords (`#CC7832`), green strings (`#7EA86D`), and purple properties (`#A885B8`).

### Visual Studio Dark 2019
A faithful port of the Visual Studio IDE Dark theme, with key differences from VS Code's built-in Dark+:
- **Type differentiation**: Structs (`#86C691`), interfaces/enums (`#B8D7A3`), and classes (`#4EC9B0`) each have distinct colors
- **Properties as white**: `.Services`, `.Length`, etc. render as plain text (`#DCDCDC`), not variable-blue
- **Namespaces as white**: `using System.Text` shows namespaces in white, not teal
- **`using` keyword in blue**: Treated as a regular keyword (`#569CD6`), not purple
- **VS IDE string color**: Pinkish `#D69D85` instead of orange `#CE9178`
- **Comment color**: Muted gray `#7A7E85` instead of olive `#6A9955`
- **Control flow keywords**: Lavender `#D8A0DF` instead of purple `#C586C0`

Colors sourced from [Roslyn VisualStudio2019.xml](https://github.com/dotnet/roslyn/blob/main/src/VisualStudio/Core/Def/ColorSchemes/VisualStudio2019.xml) (MIT License).

### Visual Studio Dark 2022
The updated VS 2022 shell appearance with identical syntax highlighting to VS 2019. Key visual differences:
- **Unified title bar + activity bar**: Both use `#1F1F1E` for a seamless top chrome (vs `#383838`/`#313131` in 2019)
- **Purple accent indicators**: Active tab top border, activity bar indicator, and panel title border use `#715FE7` (vs blue `#0078D4`)
- **Gray status bar**: `#424242` instead of blue `#007ACC`
- **Updated input fields**: Darker `#333337` background with `#434346` border

Shell colors sourced from the [Microsoft Color Value Reference](https://learn.microsoft.com/en-us/visualstudio/extensibility/ux-guidelines/color-value-reference-for-visual-studio?view=vs-2022) and community references (best effort — no official machine-readable color file exists for VS 2022).

### Visual Studio Dark 2026
The VS 2026 shell appearance built on the Fluent Design System, with identical syntax highlighting to VS 2022/2019. Key visual differences from VS 2022:
- **Darker environment**: `#1C1C1C` environment background (vs `#1F1F1E` in 2022)
- **Editor background**: `#1C1C1C` (vs `#1E1E1E`)
- **Brighter lavender accent**: `#9184EE` for active indicators and focus borders (vs `#715FE7`)
- **Fluent surface hierarchy**: Sidebar/widgets use `#2C2C2C`, tab strip/inputs use `#282828`

Shell colors sourced from VS 2026 Fluent Design System tokens documented in the [Modernize Theme Colors](https://learn.microsoft.com/en-us/visualstudio/extensibility/migration/modernize-theme-colors?view=visualstudio) migration guide. Syntax highlighting identical to VS 2022/2019.

---

### Apex Ember++
An original "golden standard" dark theme synthesized from the best elements of the most popular community themes. Designed with warm pastels, accessibility research, and maximum C# semantic differentiation.

**Design Philosophy** — what makes this theme special:
- **Night Owl** — Accessibility-first: blue for functions (reading comprehension research), meaningful contrast hierarchy, muted UI chrome
- **Catppuccin** — Warm pastel harmony: soothing colors, balanced saturation, neither too dull nor too bright
- **Tokyo Night** — Semantic sophistication: rich semantic token scoping, intentionally low-contrast UI
- **One Dark Pro** — Clean C# scoping: well-organized type/variable differentiation
- **Dracula** — Vivid accent distinctiveness: every syntax role clearly separated

**C# Semantic Depth (++ = Maximum)**:
- Every type category has a unique color: classes (`#81C8BE` teal), structs (`#A6D9A6` sage), interfaces (`#B4BEFE` lavender), enums (`#EEBEBE` flamingo)
- Properties (`#F4B8E4` pink) are distinct from variables (`#B6BCCE` foreground)
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
| **Carbon++** | Achromatic dark | Pure gray, measured saturation | `#78C8F0` steel blue |
| **Pastel++** | Soft pastel | Rose-tinted dusk, chalky pastels | `#8CBDC6` teal |

All five use **maximum C# semantic depth (++)** — every type category gets a unique color, properties are distinct from variables, parameters are distinct from locals, static members get italic styling.

### Apex Pastel++ *(Soft & Chalky)*
A rose-tinted dark theme with soft, chalky pastel syntax. Warm dusk backgrounds (H≈340°) paired with teal keywords, lilac functions, and amber classes — entirely different hue families from Ember. Uses a 3-band WCAG luminance strategy to maintain readability across all pastels (S≤36%).
- Keywords in pastel teal (`#8CBDC6`), functions in lilac (`#AA8BC1`)
- Properties in pastel rose (`#E2C8CF`), parameters in chartreuse (`#C7D3B3`)
- Five distinct type colors: classes in amber (`#D5CFB5`), structs in jade (`#8EBFAB`), interfaces in orchid (`#BB87B2`), enums in periwinkle (`#9393C5`)

### Apex Frost++ *(Cool & Modern temperature)*
A cool blue-tinted dark theme inspired by Tokyo Night Storm. Sleek and professional with sharp syntax against quiet chrome.
- Keywords in azure blue (`#7AA2F7`), functions in cyan (`#7DCFFF`)
- Properties in teal-green (`#73DACA`) for a cool, functional feel
- Blue-gray comments (`#535D87`) blend into the cool background

### Apex Steel++ *(Balanced Neutral)*
A neutral, balanced dark theme inspired by One Dark Pro. Professional clarity without color temperature bias.
- Keywords in purple (`#C678DD`), functions in blue (`#61AFEF`)
- Properties in red-rose (`#E06C75`), the One Dark signature
- Neutral gray comments (`#5B6270`) for clean readability

### Apex Neon++ *(Vibrant & Bold)*
A high-energy dark theme inspired by Dracula. Maximum visual intensity with vivid, saturated colors.
- Keywords in hot pink (`#FF79C6`), functions in neon green (`#50FA7B`)
- Properties in bright orange (`#FFB86C`), electric and warm
- Dracula blue-gray comments (`#566698`) stay quiet while neon blazes

### Apex Carbon++ *(Achromatic Dark)*
The only theme in the family with truly achromatic backgrounds (R=G=B). Pure graphite editor surface with zero color cast — every other Apex theme has blue or purple undertones. Syntax colors use measured saturation (25–54%) with hues evenly distributed across the color wheel for perfect temperature neutrality.
- Keywords in dusty rose (`#E68CA5`), functions in steel blue (`#78C8F0`)
- Properties in bright salmon (`#E8A898`), warm and clearly visible
- Pure gray comments (`#6E6E6E`) — achromatic scaffolding for measured syntax

## Color Palette Comparison

### Ported Themes

| Element        | New UI Dark   | Darcula       |
|----------------|---------------|---------------|
| Editor BG      | `#1E1F22`     | `#242424`     |
| Sidebar BG     | `#2B2D30`     | `#2D2F31`     |
| Foreground     | `#BCBEC4`     | `#A9B7C6`     |
| Keywords       | `#CF8E6D`     | `#CC7832`     |
| Strings        | `#6AAB73`     | `#7EA86D`     |
| Functions      | `#56A8F5`     | `#FFC66D`     |
| Numbers        | `#2AACB8`     | `#6897BB`     |
| Properties     | `#C77DBB`     | `#A885B8`     |
| Comments       | `#7A7E85`     | `#727272`     |
| Annotations    | `#B3AE60`     | `#BBB529`     |
| Accent         | `#3574F0`     | `#4A88C7`     |

### Apex Ember++ (Warm Pastels)

| Role            | Hex       | Design Source |
|-----------------|-----------|---------------|
| Editor BG       | `#141522` | Warm purple-tinted dark |
| Sidebar BG      | `#1B1B2C` | Lower contrast than editor |
| Foreground      | `#B6BCCE` | Warm off-white (softened) |
| Keywords        | `#C9A0F5` | Catppuccin mauve + One Dark purple |
| Control Flow    | `#D8B0F8` | Brighter purple, italic |
| Strings         | `#A6D189` | Catppuccin green warmth |
| Functions       | `#8CAAEE` | Night Owl blue (readability) |
| Numbers         | `#F2B07A` | Peach/amber, warm |
| Properties      | `#F4B8E4` | Catppuccin pink family |
| Variables       | `#B6BCCE` | Foreground (Night Owl: data = white) |
| Parameters      | `#E5C890` | Warm amber, Tokyo Night style |
| Classes         | `#81C8BE` | Warm teal |
| Structs         | `#A6D9A6` | Muted sage |
| Interfaces      | `#B4BEFE` | Catppuccin lavender |
| Enums           | `#EEBEBE` | Flamingo/coral |
| Comments        | `#60647A` | Warm muted gray |
| Accent          | `#8CAAEE` | Warm blue |

### Apex Frost++ (Cool & Modern)

| Role            | Hex       | Design Source |
|-----------------|-----------|---------------|
| Editor BG       | `#121326` | Cool blue-tinted dark |
| Sidebar BG      | `#191A2E` | Cool, lower contrast |
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
| Comments        | `#535D87` | Cool blue-gray |
| Accent          | `#7AA2F7` | Azure blue |

### Apex Steel++ (Balanced Neutral)

| Role            | Hex       | Design Source |
|-----------------|-----------|---------------|
| Editor BG       | `#16191F` | Neutral dark gray |
| Sidebar BG      | `#1D2028` | Neutral lighter |
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
| Comments        | `#5B6270` | Neutral gray |
| Accent          | `#61AFEF` | Clear blue |

### Apex Neon++ (Vibrant & Bold)

| Role            | Hex       | Design Source |
|-----------------|-----------|---------------|
| Editor BG       | `#16162A` | Deep neon-dark |
| Sidebar BG      | `#1E1E40` | Dark purple |
| Foreground      | `#C2C2CA` | Softened near-white |
| Keywords        | `#FF79C6` | Hot pink |
| Control Flow    | `#FF92D0` | Brighter pink, italic |
| Strings         | `#F1FA8C` | Electric yellow-green |
| Functions       | `#50FA7B` | Neon green |
| Numbers         | `#BD93F9` | Vivid purple |
| Properties      | `#FFB86C` | Bright orange |
| Variables       | `#C2C2CA` | Softened near-white |
| Parameters      | `#FFD580` | Warm golden |
| Classes         | `#8BE9FD` | Electric cyan |
| Structs         | `#69FF94` | Bright green |
| Interfaces      | `#CAA0F5` | Vivid lavender |
| Enums           | `#FF6E6E` | Neon coral |
| Comments        | `#566698` | Dracula blue-gray |
| Accent          | `#BD93F9` | Vivid purple |

### Apex Carbon++ (Achromatic Dark)

| Role            | Hex       | Design Source |
|-----------------|-----------|---------------|
| Editor BG       | `#181818` | Pure gray (R=G=B=24) |
| Sidebar BG      | `#202020` | Pure gray, raised surface |
| Foreground      | `#C2C2C2` | Softened silver |
| Keywords        | `#E68CA5` | Dusty rose, brighter |
| Control Flow    | `#F09CB5` | Brighter rose, italic |
| Strings         | `#9AD68A` | Sage green, brighter |
| Functions       | `#78C8F0` | Steel blue, brighter |
| Numbers         | `#D9B086` | Warm sand |
| Properties      | `#E8A898` | Bright salmon (hue ~9°, brighter for visibility) |
| Variables       | `#C2C2C2` | Softened silver (achromatic) |
| Parameters      | `#A8C98E` | Eucalyptus sage (hue ~100°, cooled) |
| Classes         | `#66CACA` | Bright turquoise, brighter |
| Structs         | `#7AD6A2` | Malachite green, brighter |
| Interfaces      | `#B896D8` | Bright amethyst, brighter |
| Enums           | `#D48C94` | Bright garnet, brighter |
| Comments        | `#6E6E6E` | Pure gray (achromatic) |
| Accent          | `#78C8F0` | Steel blue |

### Apex Pastel++ (Soft & Chalky)

| Role            | Hex       | Design Source |
|-----------------|-----------|---------------|
| Editor BG       | `#170E11` | Rose-tinted dark (Dusk) |
| Sidebar BG      | `#201418` | Rose, raised surface |
| Foreground      | `#C3B9BD` | Rose-tinted near-white |
| Keywords        | `#8CBDC6` | Pastel teal (signature) |
| Control Flow    | `#ABCBD2` | Brighter teal, italic |
| Strings         | `#97BF93` | Pastel sage |
| Functions       | `#AA8BC1` | Pastel lilac (LOW band) |
| Numbers         | `#DECBC4` | Pastel salmon |
| Properties      | `#E2C8CF` | Pastel rose (HIGH band) |
| Variables       | `#C3B9BD` | Foreground |
| Parameters      | `#C7D3B3` | Pastel chartreuse |
| Classes         | `#D5CFB5` | Pastel amber (HIGH band) |
| Structs         | `#8EBFAB` | Pastel jade (MID band) |
| Interfaces      | `#BB87B2` | Pastel orchid (LOW band) |
| Enums           | `#9393C5` | Pastel periwinkle (LOW band) |
| Comments        | `#716066` | Rose-tinted muted gray |
| Accent          | `#8CBDC6` | Teal |

## Credits

JetBrains theme colors sourced from the official [JetBrains IntelliJ Community Edition](https://github.com/JetBrains/intellij-community) repository (Apache 2.0 License).

Visual Studio Dark 2019 theme colors sourced from the [Roslyn VisualStudio2019.xml](https://github.com/dotnet/roslyn/blob/main/src/VisualStudio/Core/Def/ColorSchemes/VisualStudio2019.xml) color scheme (MIT License).

Visual Studio Dark 2022 shell colors sourced from the [Microsoft Color Value Reference](https://learn.microsoft.com/en-us/visualstudio/extensibility/ux-guidelines/color-value-reference-for-visual-studio?view=vs-2022) and community references. Syntax highlighting identical to VS 2019.

## License

[Apache 2.0](LICENSE)
