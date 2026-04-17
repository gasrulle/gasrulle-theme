# Changelog

## [0.9.0] - 2026-04-17

### Added
- **Apex themes (all 6)**: Terminal UI chrome tokens — 18 new `terminal.*` / `terminalCursor.*` / `terminalCommandDecoration.*` / `terminalStickyScroll.*` / `terminalOverviewRuler.*` / `terminalCommandGuide.*` keys per theme. Covers: inactive selection, cursor background, find match highlights + border, command gutter decorations (success/error/default), hover highlight, terminal border, tab active border, initial hint text, drop target, sticky scroll, overview ruler markers, and command guide lines. All colors derived from each theme's existing palette (accent, string, comment, ANSI green/red).

### Fixed
- **Apex Steel++**: Brightened `terminal.ansiBrightBlack` from `#5B6270` (2.72:1) to `#5E6575` (2.85:1) to meet ≥2.75:1 minimum contrast requirement.

## [0.7.0] - 2025-07-16

### Added
- **Rider Light (New UI)**: New ported theme — the modern JetBrains 2023+ New UI light theme. White editor canvas, cool gray sidebar (`#F7F8FA`), dark title bar (`#27282E`), blue accent (`#3574F0`). Syntax: teal functions (`#00627A`), blue keywords (`#0033B3`), green strings (`#067D17`), purple fields (`#871094`), blue numbers (`#1750EB`). Type parameters in teal (`#007E8A`), metadata in olive (`#9E880D`). All 15 Roslyn custom semantic tokens + 10 XML doc comment tokens included.
- **Rider Light (Classic)**: New ported theme — the classic JetBrains IntelliJ light theme. Warm gray panels (`#F2F2F2`), light title bar, blue accent (`#4083C9`). Syntax from the Default scheme: bold blue keywords (`#000080`), bold green strings (`#008000`), blue numbers (`#0000FF`), bold purple fields (`#660E7A`), italic comments (`#808080`). Type parameters in teal (`#20999D`), metadata in olive (`#808000`). All 15 Roslyn custom semantic tokens + 10 XML doc comment tokens included.

## [0.6.7] - 2026-03-17

### Fixed
- **Apex Carbon++**: Brightened selection background from `#363636` to `#444444` across all 10 selection keys — old selection was nearly invisible (1.36:1 vs editor BG), now 1.69:1. All contrast requirements verified passing.
- **Apex Carbon++**: Increased diff/merge overlay alpha from `30`/`44` to `50`/`66` — inserted/removed text backgrounds were barely distinguishable from editor BG on achromatic surfaces. Effective inserted contrast improved from 1.54:1 to 2.14:1, removed from 1.31:1 to 1.63:1.
- **Apex Pastel++**: Fixed inactive selection consistency bug — `editor.inactiveSelectionBackground` and `list.inactiveSelectionBackground` were using wrong base (`#2C2C2C66`, effective contrast 1.06:1 — invisible) instead of matching active selection base (`#42424266`, effective contrast 1.20:1).
- **Apex Pastel++**: Increased diff/merge overlay alpha from `30`/`44` to `50`/`66` — same achromatic background visibility issue as Carbon++.

## [0.6.4] - 2026-03-07

### Changed
- **Apex Frost++**: "Midnight Frost" redesign — shifted theme from "fire and ice" to cohesive frost identity. Pronounced frost tint on all backgrounds (+6-8 blue channel: editor `#1A1D30`, sidebar `#22243A`, inputs `#323548`). Muted warm syntax colors: numbers from hot orange (`#FF9E64`) to peach-sand (`#E8B48A`), parameters from amber (`#E0AF68`) to dim frosted sand (`#BAA478`). Cooled bracket pair colors: level 1 from golden (`#ECCC78`) to frosted sage (`#B8D4C0`), level 3 from copper (`#B07858`) to frosted lavender (`#9890B8`). Brightened comments (`#586390`) to maintain 2.85:1 contrast vs darker BG. Warning UI colors kept amber by convention. All contrast ratios verified passing.

## [0.6.3] - 2026-03-07

### Changed
- **Apex Frost++**: Reduced blue-on-blue saturation across canvas and syntax. Desaturated all background surfaces — editor BG (`#1A1C2A`), sidebar BG (`#222332`), inputs (`#323540`), overlays — from heavy blue tint (S≈38%) to subtle cool tint (S≈24%), so azure blue keywords pop through saturation contrast against the canvas. Neutralized foreground/canvas colors — foreground (`#B0B4C4`), variables (`#C4C8D6`), operators (`#808498`) shifted from blue-tinted to neutral silver. Redistributed structs from cyan (`#89DDFF`) to frosted mint (`#8BD4A0`) to fix 3° hue gap vs classes. Blue syntax roles reduced from 80% to ~40% of palette. All contrast ratios verified passing; surface hierarchy maintained.

## [0.6.2] - 2026-03-06

### Changed
- **Apex Pastel++**: Shifted foreground colors toward achromatic to match pure gray backgrounds. Rose saturation reduced from 7–14% to 1–6% across foreground (`#BEBBBD`), comments (`#6E6A6C`), doc comments (`#5D5B5C`), doc keywords (`#6E6862`), inactive UI (`#535153`). All contrast ratios verified passing.

## [0.6.1] - 2026-03-06

### Changed
- **Apex Pastel++**: Replaced rose-tinted dusk backgrounds with achromatic pure gray (R=G=B). Editor BG `#1F1F1F`, sidebar `#272727`, inputs `#303030`. All foreground/syntax colors unchanged. All contrast ratios verified passing.

## [0.6.0] - 2026-03-06

### Added
- **Visual Studio Dark 2026**: Ported theme — VS 2026 shell appearance with Fluent Design System tokens. Darker environment (#1C1C1C), brighter lavender accent (#9184EE), unified surface hierarchy. Syntax highlighting identical to VS 2022/2019.

## [0.5.0] - 2026-02-22

### Added
- **Visual Studio Dark 2022**: New ported theme — VS 2022 shell appearance with identical syntax to VS 2019. Unified title bar + activity bar (`#1F1F1E`), purple accent indicators (`#715FE7`), gray status bar (`#424242`), updated input field colors. Shell colors sourced from Microsoft Color Value Reference and community references (best effort — no official machine-readable VS 2022 color file exists).
- **Apex Pastel++**: New original theme — rose-tinted dark pastel (Dusk direction) with 3-band WCAG luminance strategy. Rose background (`#170E11`, H≈340°) with teal keywords (`#8CBDC6`), lilac functions (`#AA8BC1`), amber classes (`#D5CFB5`), sage strings (`#97BF93`), salmon numbers (`#DECBC4`), rose properties (`#E2C8CF`), chartreuse parameters (`#C7D3B3`). Five distinct type colors: amber classes, jade structs, orchid interfaces, periwinkle enums. Full ++ tier C# semantic depth with XML doc comment support. All syntax tokens S≤36% (strict pastel).
- **Apex Pastel++**: Bold `function.declaration` and `method.declaration` semantic tokens — compensates for low-saturation keyword↔function hue similarity at S≤36%
- **Bold Declaration Rule**: New project rule — themes with all-pastel syntax (S≤40%) must use bold on function/method declarations to provide a secondary visual cue beyond color

## [0.4.10] - 2026-02-20

### Added
- **Rider Dark (New UI)**: C# XML doc comment semantic tokens (`xmlDocCommentText`, `xmlDocCommentDelimiter`, `xmlDocCommentName`, `xmlDocCommentAttributeName`, `xmlDocCommentAttributeQuotes`, `xmlDocCommentAttributeValue`, `xmlDocCommentCDataSection`, `xmlDocCommentEntityReference`, `xmlDocCommentProcessingInstruction`, `xmlDocCommentComment`) using official JetBrains colors (`#5F826B` / `#67A37C`)
- **Rider Dark (New UI)**: `newOperator` semantic token (`#CF8E6D`) and `event` semantic token (`#C77DBB`) sourced from official JetBrains syntax scheme
- **Rider Dark (New UI)**: `editorSuggestWidget.selectedForeground` set to `#DFE1E5` (JetBrains Gray12)
- **Ported Theme Primacy Rule**: New rule in copilot-instructions establishing that ported themes always follow the original creator's design — project-specific rules (bracket colors, overlay alphas, depth tiers, etc.) apply only to original themes

### Changed
- Scoped 6 sections in copilot-instructions to "original themes only": Overlay & Highlight Color Rules, Selection Color Consistency, Bracket Pair Colorization Rules, Minimum Contrast Requirements, C# Semantic Depth Tiers, Holistic Change Protocol
- Updated Rider Dark (New UI) reset skill (`SKILL.md` and reference JSON) to reflect verified faithful state with official JetBrains source provenance
- Fixed Rider Dark (New UI) doc comment palette in copilot-instructions from incorrect values to official `#5F826B` / `#67A37C`

### Removed
- **Rider Dark (New UI)**: Removed flat `"comment"` entry from `semanticTokenColors` — it was overriding all comment sub-types (including doc comments) with a single color

## [0.4.9] - 2026-02-19

### Fixed
- **Apex Neon++**: Changed enum color from `#FF6E6E` (neon coral) to `#718BF4` (electric blue) — the old color collided with the hot pink keyword color (`#FF79C6`), violating the ≥45° hue gap requirement
- **Apex Carbon++**: Changed enum color from `#D48C94` (garnet) to `#8A8EC8` (slate indigo) — the old color collided with the dusty rose keyword color (`#E68CA5`)

### Added
- Minimum hue gap rule (≥30° between all syntax roles, ≥45° for enum vs keyword) in copilot-instructions palette methodology
- Inter-token luminance contrast rule (≥1.2:1 for commonly adjacent syntax roles) in copilot-instructions
- Bracket pair colorization rules section in copilot-instructions with collision avoidance guidelines

## [0.4.8] - 2026-02-19

### Fixed
- **Bracket pair colorization**: Moved keyword color from bracket level 2 to level 5/6 across all five Apex themes — level 2 brackets (property accessors, inner blocks) were previously identical to keyword-colored tokens, making them invisible in lines like `{ get; private set; }`
- **Apex Carbon++ property visibility**: Changed property color from `#DB9685` (salmon) to `#E8A898` (bright salmon) — the old color had a 1.01:1 contrast ratio against keywords, making properties nearly indistinguishable in keyword-heavy lines

## [0.4.7] - 2026-02-16

### Changed
- Adjusted foreground colors across Apex Frost++, Apex Neon++, Apex Steel++, and Rider Dark (Darcula) for improved readability and visual harmony
- Updated `editorCodeLens`, tab, breadcrumb, and other UI element colors for consistency

## [0.4.6] - 2026-02-15

### Added
- Reset skills for all three ported themes (Rider Dark New UI, Rider Dark Darcula, Visual Studio Dark 2019) with original reference theme files for easy restoration to initial state

## [0.4.5] - 2026-02-15

### Changed
- Overhauled selection background colors across Apex Carbon++, Apex Ember++, Apex Frost++, Apex Neon++, and Apex Steel++ for improved visibility and consistency
- Updated inactive selection and related UI properties to match new selection scheme

### Removed
- Cleaned up misplaced icon file from root directory

## [0.4.4] - 2026-02-15

### Changed
- Refined color values across all five Apex themes for improved visibility and contrast consistency
- Updated doc comment color guidelines in copilot instructions

## [0.4.3] - 2026-02-15

### Changed
- Adjusted Apex Carbon++ color values for improved visibility and consistency

## [0.4.2] - 2026-02-14

### Changed
- Major color value overhaul across all five Apex themes to enhance visual consistency and readability
- Apex Carbon++ received the largest rework (~500 lines) for better UI cohesion
- Updated palette documentation in copilot instructions to reflect new color values

## [0.4.1] - 2026-02-14

### Added
- **C# XML Doc Comment support** across all 8 themes via Roslyn custom semantic tokens
  - Styled `xmlDocCommentText`, `xmlDocCommentDelimiter`, `xmlDocCommentName`, `xmlDocCommentAttributeName`, `xmlDocCommentAttributeQuotes`, `xmlDocCommentAttributeValue`, and more
  - Dimmed doc body text with italic styling, warm sand doc keywords for tag names
  - Each theme uses temperature-matched doc comment colors (see palette tables)
- Refined doc comment colors for improved visibility across all themes
- Updated extension icon

## [0.4.0] - 2026-02-13

### Added
- **Apex Carbon++** — Achromatic dark theme with pure gray backgrounds and measured syntax
  - First Apex variant with truly achromatic backgrounds (R=G=B, zero color tint)
  - Measured saturation (25–54%) syntax palette with evenly distributed hues
  - Dusty rose keywords, steel blue functions, copper properties, sage green strings
  - Pure gray foreground tiers — comments, operators, variables all achromatic
  - Maximum C# semantic depth (++) with full workbench, syntax, and semantic token coverage

## [0.3.0] - 2026-02-13

### Added
- **Apex Frost++** — Cool blue-tinted dark theme inspired by Tokyo Night Storm
  - Azure blue keywords, cyan functions, teal-green properties
  - Cool blue-gray comments, sky blue structs, lavender interfaces
- **Apex Steel++** — Neutral balanced dark theme inspired by One Dark Pro
  - Purple keywords, clear blue functions, red-rose properties
  - Neutral gray comments, balanced green structs, soft lavender interfaces
- **Apex Neon++** — Vibrant high-energy dark theme inspired by Dracula
  - Hot pink keywords, neon green functions, bright orange properties
  - Dracula blue-gray comments, electric cyan classes, vivid coral enums
- All three new themes include maximum C# semantic depth (++) with full workbench, syntax, and semantic token coverage

## [0.2.0] - 2026-02-13

### Added
- **Apex Ember++** — Dark theme with warm pastel palette
  - Synthesized from best elements of Night Owl, Catppuccin, Tokyo Night, One Dark Pro, and Dracula
  - Maximum C# semantic differentiation: unique colors for classes, structs, interfaces, enums, properties, parameters
  - Accessibility-informed design: blue for reading comprehension, meaningful contrast hierarchy
  - Warm purple-tinted backgrounds, italic control flow keywords, italic static modifiers
  - Full workbench, syntax, and semantic token coverage
  - First theme in the Apex family (Ember/Frost/Steel/Neon)

## [0.1.0] - 2026-02-13

### Added
- Initial release
- **Rider Dark (New UI)** — JetBrains New UI dark theme (2023+)
- **Rider Dark (Darcula)** — Classic JetBrains Darcula dark theme
- **Visual Studio Dark 2019** — Faithful port of the VS IDE Dark theme with type differentiation (struct/interface/enum), properties/namespaces as white text, VS IDE string/comment colors, and more
- Full workbench color customization for both themes
- Syntax highlighting for: C#, TypeScript, JavaScript, Python, Java, HTML, CSS, JSON, YAML, Markdown, Shell/Bash, Regular Expressions
- Semantic token colors for enhanced highlighting
- Terminal ANSI color schemes for both themes
