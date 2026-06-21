# Unity 2D Beginner Refresher

A beginner-friendly Unity 2D project built as a step-by-step learning series.

This repository currently contains **Day 1**, where we set up a simple 2D scene, created a player object, added a sample ground, built a simple idle animation, saved the player as a prefab, and added keyboard movement with a C# script.

## Project Info

- Unity version: `6000.4.10f1`
- Render setup: Universal Render Pipeline 2D
- Input package: Unity Input System
- First scene: `Assets/Scenes/Day1.unity`

## Day 1 Features

- Player object in the scene
- Sample ground object
- Organized Unity folders:
  - `Animations`
  - `Materials`
  - `Prefabs`
  - `Scenes`
  - `Scripts`
  - `Settings`
  - `Sprites`
- `PlayerMovement2D` script for WASD and arrow-key movement
- Simple `Player_Idle` animation
- `Player` prefab saved in `Assets/Prefabs`

## Learning Branches

Each completed tutorial day is saved as its own Git branch so students can jump to that day's exact project state.

Current branches:

- `main` - latest stable tutorial state
- `day-1` - Day 1 player setup, idle animation, prefab, and movement

To get a specific day:

```bash
git fetch --all
git checkout day-1
```

Future days will follow the same pattern:

```text
day-2
day-3
day-4
```

## How to Open the Project

1. Clone or download this repository.
2. Open Unity Hub.
3. Choose **Add project from disk**.
4. Select this project folder.
5. Open it with Unity `6000.4.10f1` or a compatible Unity 6 version.
6. Open `Assets/Scenes/Day1.unity`.
7. Press **Play**.

## Controls

Use either control scheme:

- Move left: `A` or `Left Arrow`
- Move right: `D` or `Right Arrow`
- Move up: `W` or `Up Arrow`
- Move down: `S` or `Down Arrow`

## Main Script

The first gameplay script is:

```text
Assets/Scripts/PlayerMovement2D.cs
```

It reads keyboard input every frame, builds a movement direction, normalizes diagonal movement, and moves the player with `Time.deltaTime` so movement stays smooth across different frame rates.

## Tutorial Notes

The lesson notes for Day 1 are in:

```text
Docs/Day-01.md
```

## Next Steps

Future days can build on this project by adding collisions, better animation states, camera follow, tilemaps, collectibles, enemies, and a small playable level.
