# Copilot Workspace Instructions

## Development Checklist

Before committing any changes, ensure:

- [ ] `dotnet build` passes with no errors
- [ ] `dotnet test` passes (when tests exist)
- [ ] Code follows C# conventions (PascalCase for public members)
- [ ] No unused variables or imports

## Project Overview

**Soc Ops** is a Social Bingo game built with Blazor WebAssembly (.NET 10). Players find people who match questions to mark squares and get 5 in a row.

## Architecture

```
SocOps/
├── Components/     # Reusable Blazor components
│   ├── BingoBoard.razor
│   ├── BingoSquare.razor
│   ├── BingoModal.razor
│   ├── GameScreen.razor
│   └── StartScreen.razor
├── Models/         # Data models (BingoSquareData, GameState)
├── Services/       # Business logic
│   ├── BingoGameService.cs    # State management
│   └── BingoLogicService.cs   # Game logic
├── Data/           # Static data (Questions.cs)
├── Pages/          # Routable pages (Home.razor)
└── wwwroot/        # Static assets & CSS
```

## Key Commands

```bash
dotnet build SocOps/SocOps.csproj  # Build
dotnet run --project SocOps       # Run dev server (port 5166)
dotnet test                        # Run tests
```

## State Management

- `BingoGameService` manages game state with event-driven updates
- State persisted to localStorage via JSInterop
- Components subscribe to `OnStateChanged` event

---

## Design Guide — Minimalist Mono / Scandinavian Calm / Desert Sand

### Design Philosophy

The visual identity draws from three converging aesthetics:

- **Minimalist Mono** — Monospace typography as primary voice. Clean geometry, no decorative flourishes. Precision over ornamentation.
- **Scandinavian Calm** — Generous whitespace, muted tones, serene restraint. Every element breathes. Less is always more.
- **Desert Sand** — Warm earth tones inspired by arid landscapes. Sand, clay, terracotta, parchment. Organic warmth over cold neutrals.

### Color Palette

All colors are defined as CSS custom properties in `:root` within `wwwroot/css/app.css`.

| Token            | Hex       | Usage                                    |
|------------------|-----------|------------------------------------------|
| `--sand`         | `#F2ECE4` | Primary background                       |
| `--sand-light`   | `#FAF7F3` | Elevated surfaces (header)               |
| `--sand-dark`    | `#E8E0D6` | Marked/selected states                   |
| `--dune`         | `#D9CEBD` | Borders, dividers, subtle backgrounds    |
| `--clay`         | `#C4956A` | Primary accent — winning states, icons   |
| `--clay-dark`    | `#A87B52` | Accent hover / active states             |
| `--terracotta`   | `#B5704F` | Error states, strong accent              |
| `--sage`         | `#A8B5A0` | Success / positive accent (sparingly)    |
| `--sage-light`   | `#D2DBCE` | Light success background                 |
| `--charcoal`     | `#2C2825` | Primary text, dark buttons               |
| `--warm-gray`    | `#8A8279` | Secondary text, muted labels             |
| `--warm-gray-l`  | `#B5AEA4` | Tertiary text, disabled states           |
| `--parchment`    | `#FFFCF8` | Card surfaces, light text on dark        |
| `--ink`          | `#3D3733` | Body text, slightly softer than charcoal |

**Rules:**
- Never use pure black (`#000`) or pure white (`#FFF`)
- Accent colors (clay, terracotta) are used sparingly for emphasis
- Background gradients use only sand-family colors at low opacity

### Typography

Two font families loaded from Google Fonts:

| Font                   | Variable        | Role                          |
|------------------------|-----------------|-------------------------------|
| **DM Mono**            | `--font-mono`   | Body text, UI labels, buttons |
| **Cormorant Garamond** | `--font-serif`  | Headlines, titles, display    |

**Rules:**
- DM Mono at weights 300 (light), 400 (regular), 500 (medium)
- Cormorant Garamond at weights 300 (light), 400 (regular) for headings
- Buttons and labels: uppercase, wide letter-spacing (`0.1em`–`0.25em`)
- Body text: `0.8125rem` (13px), line-height `1.6`
- Never use system fonts, Inter, Roboto, or Arial

### Spacing & Layout

- Generous padding — minimum `1rem` on interactive surfaces
- Sections separated by thin `1px solid var(--dune)` borders, not shadows
- Max content width: `22rem`–`26rem` depending on context
- Use CSS Grid for the bingo board (5×1fr columns, 3px gap)
- Flexbox for page-level layout (column direction)

### Borders & Surfaces

- **No rounded corners** — all elements are sharp rectangles
- **No box shadows** — depth conveyed through color shifts only
- Borders are always `1px solid var(--dune)` or lighter
- Surfaces layer: `--sand` → `--sand-light` → `--parchment` (lightest)

### Motion & Animation

Animations are restrained and purposeful:

| Animation       | Duration   | Easing                             | Usage                        |
|-----------------|------------|------------------------------------|------------------------------|
| `fade-up`       | `0.8s`     | `cubic-bezier(0.25, 0.1, 0.25, 1)`| Page entrance                |
| `fade-in`       | `0.3–0.4s` | Same                               | Overlays, banners            |
| `modal-rise`    | `0.5s`     | Same                               | Modal card entrance          |
| `gentle-pulse`  | `2s`       | `ease-in-out`, infinite            | Decorative icon emphasis     |
| Stagger delays  | `0.1s` increments | N/A                          | Sequential element reveals   |

**Rules:**
- Prefer `transform` and `opacity` for performance
- Transitions on interactive elements: `280ms` (the `--duration` token)
- Use `animation-fill-mode: both` to prevent flicker
- Active states use `scale(0.96–0.98)` — subtle press feedback
- No bouncing, no elastic easing, no confetti

### Component Patterns

- **Semantic CSS classes** — e.g., `.bingo-square--marked` not `.bg-green-100`
- **BEM-like naming** — `.block`, `.block-element`, `.block--modifier`
- State variants with double-dash: `--marked`, `--winning`, `--free`
- All component styles live in `app.css`, not scoped CSS files
- Razor components use `@code` blocks, not code-behind files

### Buttons

- Primary: `background: var(--charcoal)`, `color: var(--parchment)`, uppercase mono
- Ghost/back: No background, `color: var(--warm-gray)`, mono text
- Active state: Darken background, slight scale-down
- Never use colored backgrounds for buttons (no blue, no green)

### Accessibility

- All interactive elements have `aria-label` or visible text
- Bingo squares use `aria-pressed` for toggle state
- Color contrast ratios meet WCAG AA for all text/background combos
- Disabled elements use `cursor: default`
