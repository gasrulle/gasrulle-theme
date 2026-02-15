---
name: reset-rider-dark-darcula
description: Reset the Rider Dark (Darcula) theme to its original faithful port from the initial commit. Use this when asked to reset, restore, or revert the Rider Dark Darcula theme to its original state before any automated modifications.
---

# Reset Rider Dark (Darcula) Theme

This skill restores `themes/rider-dark-darcula-color-theme.json` to its exact original state from the initial commit (`9def7a0b71910c21535f6fcfebbb8cb30d73a034`, 2026-02-13).

## When to use
- User asks to "reset", "restore", or "revert" the Rider Dark (Darcula) theme
- User wants to undo all modifications made after the initial faithful port
- User wants the pre-modification baseline to start fresh

## Instructions

1. Read the file `rider-dark-darcula-original.json` from this skill's directory (`.github/skills/reset-rider-dark-darcula/rider-dark-darcula-original.json`)
2. Replace the **entire contents** of `themes/rider-dark-darcula-color-theme.json` with the contents of that file
3. Confirm the reset was applied

## What this resets
- All workbench `colors` to the original JetBrains Darcula values (including editor background `#2B2B2B`, sidebar `#3C3F41`)
- All `tokenColors` to the original TextMate scope rules
- All `semanticTokenColors` to the original semantic token mappings
- Removes any overlay fixes, doc comment additions, contrast adjustments, background darkening, or other modifications made after the initial commit

## Warning
This is a **destructive reset** — it removes ALL changes made since the initial commit, including intentional improvements like:
- Editor background darkening (`#2B2B2B` → `#242424`)
- Sidebar/foreground adjustments
- WCAG contrast fixes
- Overlay visibility improvements
- XML doc comment semantic token entries
- `editorSuggestWidget.selectedForeground` additions

After resetting, you may want to re-apply specific fixes selectively.

## Source provenance
- **Commit**: `9def7a0b71910c21535f6fcfebbb8cb30d73a034`
- **Date**: 2026-02-13
- **Description**: Initial commit — faithful port of JetBrains Rider Darcula theme
