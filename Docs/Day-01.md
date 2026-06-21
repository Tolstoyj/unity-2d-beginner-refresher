# Day 1 - Player Setup, Idle Animation, and Movement

This lesson starts a beginner Unity 2D project from a clean scene and introduces the first gameplay script.

## Goal

By the end of Day 1, the project has:

- A saved scene named `Day1`
- A player object
- A simple ground object
- Organized asset folders
- A player idle animation
- A reusable player prefab
- A movement script attached to the player prefab

## Folder Structure

Inside `Assets`, the project is organized like this:

```text
Assets
  Animations
  Materials
  Prefabs
  Scenes
  Scripts
  Settings
  Sprites
```

This keeps the project easy to understand as it grows.

## Scene

The first scene is:

```text
Assets/Scenes/Day1.unity
```

It contains the basic objects needed to start testing:

- `Main Camera`
- `Global Light 2D`
- `Ground`
- `Player`

## Player Prefab

The player is saved as a prefab:

```text
Assets/Prefabs/Player.prefab
```

Using a prefab means the player can be reused in future scenes without rebuilding it every time.

## Idle Animation

The first animation is:

```text
Assets/Animations/Player_Idle.anim
```

The animation controller is:

```text
Assets/Animations/Player.controller
```

This gives the player an animation setup that can later be expanded with walking, jumping, attacking, or taking damage.

## Movement Script

The movement script is:

```text
Assets/Scripts/PlayerMovement2D.cs
```

It uses Unity's Input System to read the keyboard:

- `A` or `Left Arrow` moves left
- `D` or `Right Arrow` moves right
- `W` or `Up Arrow` moves up
- `S` or `Down Arrow` moves down

The script exposes this value in the Inspector:

```csharp
public float speed = 5f;
```

That means the player's speed can be changed in Unity without editing the code.

## Important Code Ideas

`Update()` runs once every frame while the game is playing.

`movement.x` controls left and right movement.

`movement.y` controls up and down movement.

`movement.normalized` keeps diagonal movement from being faster than straight movement.

`Time.deltaTime` makes movement smooth and frame-rate independent.

## Test Checklist

Before moving to Day 2:

- Open `Assets/Scenes/Day1.unity`
- Press **Play**
- Move the player with WASD
- Move the player with arrow keys
- Confirm the player prefab exists in `Assets/Prefabs`
- Confirm the movement speed can be edited from the Inspector
