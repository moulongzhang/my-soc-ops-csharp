# Design Variation A — Tokenized Theming + Theme Switcher

## Objective
Introduce a robust design-token system with multiple curated themes while preserving the existing minimalist mono / Scandinavian calm / desert sand baseline.

## Why this variation
- Enables fast visual experimentation without large component rewrites.
- Keeps semantic CSS architecture intact.
- Supports future branding and event-specific themes.

## Scope
1. Refactor `wwwroot/css/app.css` into clear token groups:
   - Base tokens (spacing, typography scale, motion)
   - Color tokens (semantic aliases: `--color-bg`, `--color-surface`, `--color-text`, etc.)
   - Component tokens (`--btn-bg`, `--square-marked-bg`, etc.)
2. Add two optional theme variants using `data-theme` on `html` or `body`:
   - `desert` (current baseline)
   - `mono-night` (dark, high-contrast variant using warm off-black + parchment text)
3. Create a lightweight `ThemeService` to:
   - Persist selected theme in localStorage
   - Apply theme at startup and on change
   - Notify components if needed
4. Add a small theme toggle UI (non-intrusive) in an existing screen.
5. Keep all visual rules from repo instructions (no rounded corners, no shadows, restrained motion).

## Constraints
- Preserve current gameplay behavior.
- Do not introduce Tailwind or external UI frameworks.
- Keep component classes semantic and BEM-like.
- Maintain WCAG AA contrast for text.

## Acceptance Criteria
- Theme can be switched between at least 2 themes at runtime.
- Reload preserves selected theme.
- Existing components render correctly across themes.
- `dotnet build` passes.
- Any tests updated/added pass with `dotnet test`.

## Suggested Implementation Notes
- Prefer semantic aliases over hard-coded color tokens in components.
- Add clear comments in `app.css` section boundaries.
- Keep default theme unchanged for backward visual compatibility.
