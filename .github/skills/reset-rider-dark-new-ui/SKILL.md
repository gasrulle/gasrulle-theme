---
name: reset-rider-dark-new-ui
description: Reset the Rider Dark (New UI) theme to its original faithful port from the initial commit. Use this when asked to reset, restore, or revert the Rider Dark New UI theme to its original state before any automated modifications.
---

# Reset Rider Dark (New UI) Theme

This skill restores `themes/rider-dark-new-ui-color-theme.json` to its verified faithful state — all colors sourced from official JetBrains `expUI_dark.theme.json` (UI) and `expUI_darkScheme.xml` (syntax).

## When to use
- User asks to "reset", "restore", or "revert" the Rider Dark (New UI) theme
- User wants to undo all modifications made after the initial faithful port
- User wants the pre-modification baseline to start fresh

## Instructions

1. Read the file `rider-dark-new-ui-original.json` from this skill's directory (`.github/skills/reset-rider-dark-new-ui/rider-dark-new-ui-original.json`)
2. Replace the **entire contents** of `themes/rider-dark-new-ui-color-theme.json` with the contents of that file
3. Confirm the reset was applied

## What this resets
- All workbench `colors` to the official JetBrains New UI values (from `expUI_dark.theme.json`)
- All `tokenColors` to the official TextMate scope rules (from `expUI_darkScheme.xml`)
- All `semanticTokenColors` including `xmlDocComment*` tokens, `newOperator`, `event`, and `editorSuggestWidget.selectedForeground`
- Removes any modifications not traceable to official JetBrains source files

## Included official features
This reference state includes all colors verified against JetBrains sources:
- `xmlDocComment*` semantic tokens (`DEFAULT_DOC_COMMENT` `#5F826B` / `DEFAULT_DOC_COMMENT_TAG` `#67A37C`)
- `newOperator` (`#CF8E6D` — `DEFAULT_KEYWORD`)
- `event` (`#C77DBB` — `DEFAULT_INSTANCE_FIELD`)
- `editorSuggestWidget.selectedForeground` (`#DFE1E5` — `Gray12` / `selectionForeground`)
- No flat `"comment"` semantic token entry (preserves doc vs regular comment distinction)
- No bracket pair colors (JetBrains does not define them)

## Source provenance
- **Official UI source**: `expUI_dark.theme.json` from `JetBrains/intellij-community`
- **Official syntax source**: `expUI_darkScheme.xml` from `JetBrains/intellij-community`
- **Base commit**: `9def7a0b71910c21535f6fcfebbb8cb30d73a034` (2026-02-13) + verified additions
