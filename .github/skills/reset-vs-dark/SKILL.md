---
name: reset-vs-dark
description: Reset the Visual Studio Dark 2019 theme to its original faithful port from the initial commit. Use this when asked to reset, restore, or revert the VS Dark theme to its original state before any automated modifications.
---

# Reset Visual Studio Dark 2019 Theme

This skill restores `themes/vs-dark-color-theme.json` to its exact original state from the initial commit (`9def7a0b71910c21535f6fcfebbb8cb30d73a034`, 2026-02-13).

## When to use
- User asks to "reset", "restore", or "revert" the Visual Studio Dark 2019 theme
- User wants to undo all modifications made after the initial faithful port
- User wants the pre-modification baseline to start fresh

## Instructions

1. Read the file `vs-dark-original.json` from this skill's directory (`.github/skills/reset-vs-dark/vs-dark-original.json`)
2. Replace the **entire contents** of `themes/vs-dark-color-theme.json` with the contents of that file
3. Confirm the reset was applied

## What this resets
- All workbench `colors` to the original Visual Studio IDE Dark values
- All `tokenColors` to the original TextMate scope rules
- All `semanticTokenColors` to the original semantic token mappings
- Removes any overlay fixes, doc comment additions, contrast adjustments, or other modifications made after the initial commit

## Warning
This is a **destructive reset** — it removes ALL changes made since the initial commit, including intentional improvements like:
- WCAG contrast fixes
- Overlay visibility improvements
- XML doc comment semantic token entries
- Doc keyword color alignment (`#747980` → `#A89888`)
- `editorSuggestWidget.selectedForeground` additions

After resetting, you may want to re-apply specific fixes selectively.

## Source provenance
- **Commit**: `9def7a0b71910c21535f6fcfebbb8cb30d73a034`
- **Date**: 2026-02-13
- **Description**: Initial commit — faithful port of Visual Studio IDE Dark theme
