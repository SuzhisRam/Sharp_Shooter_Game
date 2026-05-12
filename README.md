# Sharp Shooter

Sharp Shooter is a first-person shooter prototype built in Unity as part of my learning path through the Udemy course [Complete C# Unity 3D Game Development in Unity 6](https://www.udemy.com/course/unitycourse2/).

The project focuses on building core FPS systems in C# and Unity: player movement, weapon handling, pickups, enemy behavior, health, UI feedback, camera effects, and reusable gameplay components.

## Preview

![Sharp Shooter level preview](Images/Captura%20de%20pantalla%202026-05-12%20135248.png)

## Portfolio Summary

This project demonstrates my ability to build and organize gameplay systems in Unity using C#. It includes a playable FPS loop where the player can move through a 3D level, collect weapons and ammo, shoot enemies, take damage, and interact with gameplay objects built from prefabs and configurable data assets.

I am using this project as a portfolio reference to show practical experience with Unity gameplay programming, component-based architecture, input handling, ScriptableObjects, enemy AI navigation, visual feedback, and scene setup.

## What I Learned

- Built gameplay logic using C# scripts, Unity components, serialized fields, prefabs, and scene objects.
- Implemented a first-person controller using Unity Starter Assets and the Unity Input System.
- Created a weapon system that supports multiple weapons, fire rates, ammo limits, raycast shooting, hit effects, and weapon switching.
- Used `ScriptableObject` assets to separate weapon data from gameplay logic, making weapons easier to tune and extend.
- Integrated Cinemachine for player camera behavior, zoom, recoil impulse, and death camera transitions.
- Created pickup systems using inheritance, trigger colliders, and reusable base classes.
- Implemented enemy behavior with `NavMeshAgent`, allowing enemies to chase the player through the level.
- Built player and enemy health systems with damage, destruction, explosion effects, and UI updates.
- Worked with Unity UI and TextMesh Pro to display ammo and player shield status.
- Organized project assets into clear folders for scripts, prefabs, scenes, materials, settings, animations, and ScriptableObjects.
- Used Unity packages such as Universal Render Pipeline, AI Navigation, Cinemachine, Input System, ProBuilder, and TextMesh Pro.
- Practiced version-control-friendly Unity project setup with a `.gitignore` that excludes generated folders while keeping required `.meta` files.

## Features

- First-person movement, camera look, jumping, sprinting, shooting, and zooming.
- Multiple weapons: pistol, machine gun, and sniper rifle.
- Configurable weapon stats such as damage, fire rate, zoom, automatic fire, and magazine size.
- Ammo pickups and weapon pickups.
- Enemy spawners that continue generating enemies while the player is alive.
- Enemy chase behavior using Unity NavMesh.
- Player shield UI and death camera behavior.
- Particle effects for muzzle flashes, bullet impacts, and explosions.
- Main playable scene included in Unity build settings.

## Technologies

- Unity `6000.4.1f1`
- C#
- Universal Render Pipeline
- Unity Input System
- Cinemachine
- Unity AI Navigation / NavMesh
- TextMesh Pro
- Starter Assets - First Person Controller

## Course Reference

This project was developed while following:

[Complete C# Unity 3D Game Development in Unity 6](https://www.udemy.com/course/unitycourse2/)  
Created by Rick Davidson, GameDev.tv Team, and Stephen Hubbard.

The course covers C# fundamentals, Unity workflows, gameplay mechanics, player movement, collisions, enemy AI, raycasting, weapon switching, world building, and project-based game development. This repository reflects the FPS section and the systems I implemented while applying those concepts.

## How to Open the Project

1. Clone the repository:

```bash
git clone https://github.com/your-username/sharp-shooter.git
```

2. Open Unity Hub.
3. Select **Add project from disk**.
4. Choose the cloned project folder.
5. Open it with Unity `6000.4.1f1` or a compatible Unity 6 version.
6. Open the main scene:

```text
Assets/Scenes/Main.unity
```

7. Press **Play** in the Unity Editor.

## Controls

| Action | Keyboard and Mouse | Gamepad |
| --- | --- | --- |
| Move | WASD or arrow keys | Left stick |
| Look | Mouse | Right stick |
| Jump | Space | South button |
| Sprint | Left Shift | Left stick press |
| Shoot | Left mouse button | Right trigger |
| Zoom | Right mouse button | Left trigger |

## Weapon Data

| Weapon | Damage | Fire Rate | Automatic | Zoom | Magazine |
| --- | ---: | ---: | --- | --- | ---: |
| Pistol | 100 | 0.5 s | No | No | 12 |
| Machine Gun | 30 | 0.07 s | Yes | No | 99 |
| Sniper Rifle | 300 | 3 s | No | Yes | 5 |

## Project Structure

```text
Assets/
  Animations/          Weapon and enemy animations
  ImportedAssets/      External assets used by the project
  Material/            Game materials
  Prefab/              Player, weapons, enemies, pickups, and VFX prefabs
  Scenes/              Unity scenes
  ScriptableObjects/   Weapon configuration assets
  Scripts/             Core gameplay scripts
  Settings/            Input, render pipeline, and project settings
Packages/              Unity package dependencies
ProjectSettings/       Unity project configuration
```

## Main Scripts

- `ActiveWeapon.cs`: manages the equipped weapon, shooting, ammo, zoom, and weapon switching.
- `Weapon.cs`: handles raycast shooting, muzzle flash, hit effects, camera impulse, and enemy damage.
- `WeaponSO.cs`: stores configurable weapon data.
- `PlayerHealth.cs`: manages player health, shield UI, and death camera behavior.
- `EnemyHealth.cs`: manages enemy health and destruction.
- `Duck.cs`: controls enemy pursuit behavior using NavMesh.
- `SpawnGate.cs`: spawns enemies while the player is alive.
- `Pickup.cs`: base class for collectible items.
- `AmmoPickup.cs`: adds ammo to the active weapon.
- `WeaponPickup.cs`: changes the active weapon.
- `Explosion.cs`: applies area damage to the player.

## GitHub Notes

The repository includes a Unity-focused `.gitignore`. Generated folders such as `Library`, `Temp`, `Logs`, `Build`, and `UserSettings` should not be committed. Unity `.meta` files should be committed because they preserve asset references.

Recommended files and folders to include:

- `Assets/`
- `Packages/`
- `ProjectSettings/`
- `.gitignore`
- `README.md`

Do not commit:

- `Library/`
- `Temp/`
- `Logs/`
- `UserSettings/`
- Generated `.csproj` or solution files

## Status

Playable learning project with a functional FPS gameplay loop, reusable weapon data, enemy AI, pickups, UI feedback, and core player combat systems.
