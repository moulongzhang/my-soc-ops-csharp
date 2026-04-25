# Project Guidelines

## Build and Test
- Use .NET 10 SDK or newer.
- Build command: `dotnet build SocOps/SocOps.csproj`
- Run command: `dotnet run --project SocOps/SocOps.csproj`
- Test command: `dotnet test` (run when test projects exist)
- Before finalizing code changes, run at least the build command and report result.

## Architecture
- Main app is a Blazor WebAssembly project in `SocOps/`.
- UI composition lives in `SocOps/Components/` and routing entry page is `SocOps/Pages/Home.razor`.
- Game state lifecycle is managed by `SocOps/Services/BingoGameService.cs`.
- Pure bingo rules and board generation live in `SocOps/Services/BingoLogicService.cs` (static logic service).
- Domain models are in `SocOps/Models/` and question data is in `SocOps/Data/Questions.cs`.

## Conventions
- Keep business rules in services; keep components focused on rendering and event wiring.
- For stateful UI updates, use the existing `BingoGameService.OnStateChanged` subscription pattern and unsubscribe in `Dispose`.
- Preserve current utility-class styling approach from `SocOps/wwwroot/css/app.css`; do not introduce external CSS frameworks.
- Reuse existing utility classes when possible. If a utility is missing, add a small single-purpose class to `SocOps/wwwroot/css/app.css`.
- Keep C# nullable safety and implicit usings aligned with `SocOps/SocOps.csproj` settings.

## Documentation Links
- Setup and usage: `README.md`
- Workshop walkthroughs: `workshop/GUIDE.md`
- Styling guidance for utility classes: `.github/instructions/css-utilities.instructions.md`
- Frontend design direction for redesign tasks: `.github/instructions/frontend-design.instructions.md`

## Pitfalls
- The app uses browser localStorage (`bingo-game-state`) via JS interop in `BingoGameService`; avoid breaking stored shape unless you also handle version migration.
- `dotnet run` uses launch settings and typically serves on `http://localhost:5166` in this workspace.
