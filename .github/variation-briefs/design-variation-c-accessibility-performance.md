# Design Variation C — Accessibility-First UX + Render Performance Pass

## Objective
Prioritize inclusive interaction and smoother rendering by improving keyboard/screen-reader UX and reducing unnecessary re-renders in the Blazor UI.

## Why this variation
- Improves usability for all players, including keyboard and assistive tech users.
- Targets responsive feel during frequent square toggles and modal interactions.
- Produces practical quality gains without major visual redesign.

## Scope
1. Accessibility improvements:
   - Ensure all interactive controls have discernible names.
   - Validate `aria-pressed` usage for bingo squares.
   - Improve keyboard navigation order and focus management for modal open/close.
   - Add/adjust `aria-live` region for bingo/win status updates.
2. Performance-focused cleanup:
   - Audit component rerender patterns (`ShouldRender`, parameter granularity, event callbacks).
   - Avoid avoidable allocations in frequently-run UI paths.
   - Ensure state change events trigger only necessary updates.
3. Add targeted tests:
   - Component tests or service tests for state/update behavior where feasible.
4. Keep the current visual identity unchanged.

## Constraints
- No framework switch.
- Do not degrade readability or code simplicity for micro-optimizations.
- Preserve game logic correctness.

## Acceptance Criteria
- Keyboard-only play flow is improved and documented.
- Modal focus handling is deterministic.
- At least one measurable render/perf improvement is documented qualitatively (or quantitatively if local profiling is available).
- `dotnet build` passes.
- `dotnet test` passes.

## Suggested Implementation Notes
- Prefer pragmatic wins: focus trap/focus return, reduced rerender surface, clearer ARIA semantics.
- Include before/after reasoning in PR description.
