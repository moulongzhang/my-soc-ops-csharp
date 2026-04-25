# Design Variation B — Reusable UI Primitives + Variant API

## Objective
Create a consistent component-level design system by introducing reusable UI primitives and variant-driven styling to reduce duplication and improve maintainability.

## Why this variation
- Improves long-term consistency and code health.
- Makes adding new screens and states faster.
- Encapsulates style semantics at component boundaries.

## Scope
1. Introduce reusable primitives in `SocOps/Components/` (or subfolder):
   - `AppButton.razor`
   - `AppCard.razor`
   - `AppBadge.razor` (optional)
2. Define parameters for style variants and states (e.g., `Variant`, `IsDisabled`, `Size`).
3. Migrate existing screens/components to use these primitives:
   - Start screen buttons
   - Modal actions
   - Any repeated card-like containers
4. Consolidate CSS patterns in `wwwroot/css/app.css`:
   - Shared primitive base classes
   - Modifier classes for variants
5. Add accessibility defaults:
   - Proper button types
   - ARIA labels where needed
   - Focus-visible styles that fit the design language

## Constraints
- No visual style drift from design guide.
- Keep naming semantic and BEM-compatible.
- Avoid over-abstracting tiny one-off elements.
- No external component libraries.

## Acceptance Criteria
- At least 2 existing UI areas migrated to primitives.
- Repeated style rules measurably reduced (qualitative reduction documented in PR).
- UI behavior unchanged.
- `dotnet build` passes.
- `dotnet test` passes if tests exist.

## Suggested Implementation Notes
- Prefer thin wrappers over deeply generic components.
- Keep primitive APIs minimal and explicit.
- Document variant usage briefly in comments or PR description.
