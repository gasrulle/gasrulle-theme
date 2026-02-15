---
name: reset-rider-dark-new-ui
description: Reset the Rider Dark (New UI) theme to its original faithful port from the initial commit. Use this when asked to reset, restore, or revert the Rider Dark New UI theme to its original state before any automated modifications.
---

# Reset Rider Dark (New UI) Theme

This skill restores `themes/rider-dark-new-ui-color-theme.json` to its exact original state from the initial commit (`9def7a0b71910c21535f6fcfebbb8cb30d73a034`, 2026-02-13).

## When to use
- User asks to "reset", "restore", or "revert" the Rider Dark (New UI) theme
- User wants to undo all modifications made after the initial faithful port
- User wants the pre-modification baseline to start fresh

## Instructions

1. Read the file `rider-dark-new-ui-original.json` from this skill's directory (`.github/skills/reset-rider-dark-new-ui/rider-dark-new-ui-original.json`)
2. Replace the **entire contents** of `themes/rider-dark-new-ui-color-theme.json` with the contents of that file
3. Confirm the reset was applied

## What this resets
- All workbench `colors` to the original JetBrains New UI values
- All `tokenColors` to the original TextMate scope rules
- All `semanticTokenColors` to the original semantic token mappings
- Removes any overlay fixes, doc comment additions, contrast adjustments, or other modifications made after the initial commit

## Warning
This is a **destructive reset** — it removes ALL changes made since the initial commit, including intentional improvements like:
- WCAG contrast fixes
- Overlay visibility improvements
- XML doc comment semantic token entries
- `editorSuggestWidget.selectedForeground` additions

After resetting, you may want to re-apply specific fixes selectively.

## Source provenance
- **Commit**: `9def7a0b71910c21535f6fcfebbb8cb30d73a034`
- **Date**: 2026-02-13
- **Description**: Initial commit — faithful port of JetBrains Rider New UI dark theme
