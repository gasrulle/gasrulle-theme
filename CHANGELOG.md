# Changelog

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
- Reset skills for all three ported themes (Rider Dark New UI, Rider Dark Darcula, Visual Studio Dark) with original reference theme files for easy restoration to initial state

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
- **Visual Studio Dark** — Faithful port of the VS IDE Dark theme with type differentiation (struct/interface/enum), properties/namespaces as white text, VS IDE string/comment colors, and more
- Full workbench color customization for both themes
- Syntax highlighting for: C#, TypeScript, JavaScript, Python, Java, HTML, CSS, JSON, YAML, Markdown, Shell/Bash, Regular Expressions
- Semantic token colors for enhanced highlighting
- Terminal ANSI color schemes for both themes
