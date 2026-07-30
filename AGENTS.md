Include ..\AGENTS.md

# No Camera Shift — Mod-Specific Agent Instructions

## Identity
- **Assembly:** `nocamerashift`
- **Namespace:** `Calloatti.NoCameraShift`
- **Framework:** Harmony
- **ModId:** `Calloatti.NoCameraShift`
- **Min Game Version:** 1.0.12.5 — uses `timberborn-decompiled-1.0.*`

## What This Mod Does
Prevents the camera from shifting horizontally when selecting buildings or entities, keeping the view stable.

## Source Architecture (`Version-1.0/Source/`)

| File | Role |
|---|---|
| `ModStarter.cs` | Entry point — `IModStarter` |
| `CameraHorizontalShifterPatch.cs` | Harmony patch on camera shift behavior |
