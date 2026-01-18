# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Build and Run Commands

```bash
# Build the entire solution
dotnet build DotaPalyerData.sln

# Run tests
dotnet test DotaPlayerData.Tests/DotaPlayerData.Tests.csproj

# Run a single test
dotnet test DotaPlayerData.Tests/DotaPlayerData.Tests.csproj --filter "FullyQualifiedName~TestMethodName"

# Run the UI (requires MAUI workload)
dotnet build DotaPlayerData.UI/DotaPlayerData.UI.csproj -f net10.0-android
```

Note: The solution file has a typo in its name (`DotaPalyerData.sln` instead of `DotaPlayerData.sln`).

## Architecture Overview

This is a .NET 10 MAUI Blazor application for viewing Dota 2 player statistics. The app aggregates data from two external APIs (OpenDota and Stratz) to provide player information.

### Project Structure

- **DotaPlayerData.UI**: MAUI Blazor frontend using MudBlazor components. Contains Razor pages and the `SearchController` which coordinates UI data fetching.

- **DotaPlayerData.Core**: Business logic layer with services (`IPlayerService`, `IHeroService`) and domain models. Models are split between `OpenDota/` and `Stratz/` subfolders reflecting their API source.

- **DotaPlayerData.API**: HTTP client layer using Flurl.Http. Contains `IOpenDotaApiClient` and `IStratzApi` interfaces with implementations that return raw JSON strings.

- **DotaPlayerData.Tests**: NUnit tests with FluentAssertions and Moq.

### Data Flow

1. UI pages inject `SearchController`
2. `SearchController` calls Core services (`PlayerService`, `HeroService`)
3. Services call API clients and deserialize JSON responses
4. `PlayerService.GetCurrentPlayerInfos()` merges data from both OpenDota and Stratz APIs into a unified `Player` model

### Key Patterns

- API clients return raw JSON strings; deserialization happens in the service layer
- Configuration (API keys, base URLs) is loaded from `appsettings.json` via `IConfiguration`
- Dependency injection is configured in `MauiProgram.cs`
