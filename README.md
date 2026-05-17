# Sharp Shooter

Sharp Shooter is a first-person shooter prototype built in Unity. This repository reflects the work I implemented from the **Sharp Shooter** section of the Udemy course [Complete C# Unity 3D Game Development in Unity 6](https://www.udemy.com/course/unitycourse2/).

The project focuses on a compact FPS gameplay loop: moving through a 3D level, switching weapons, collecting pickups, shooting enemies with raycasts, managing ammo, using weapon zoom, taking damage, and surviving enemy spawns.

## Preview

![Sharp Shooter level preview](Images/Captura%20de%20pantalla%202026-05-12%20135248.png)

## Portfolio Summary

This project demonstrates my ability to implement gameplay systems in Unity using C# and the component-based workflow. The code and scene setup focus specifically on FPS mechanics from the Sharp Shooter course section, including weapon behavior, pickups, enemy damage, player health, UI feedback, VFX, and camera effects.

I use this project as a portfolio reference because it shows practical Unity development skills in a playable prototype rather than only isolated exercises.

## Sharp Shooter Section Scope

This repository is based on the **Sharp Shooter** section of the course. The implemented topics include:

- Machine gun setup and automatic fire behavior.
- Weapon pickups and runtime weapon switching.
- Sniper rifle setup with zoom functionality.
- Base pickup behavior using inheritance.
- Raycast shooting and raycast overload usage.
- Ammo management and ammo pickups.
- Separate weapon viewport/camera setup.
- Gun recoil and camera impulse feedback.
- Robot explosion visual effects.
- Explosion radius visualization with `OnDrawGizmos`.
- Area damage using `Physics.OverlapSphere`.
- Death camera transition with Cinemachine.
- Player shield UI.
- Enemy spawn gate behavior.
- Turret enemy setup with projectile-based attacks.
- Game over, restart, quit, enemy counter, and win-state UI.

## What I Learned

- How to structure Unity gameplay features through small, focused C# components.
- How to expose gameplay values through serialized fields and `ScriptableObject` assets.
- How to create a reusable weapon system with configurable damage, fire rate, magazine size, zoom, and automatic fire.
- How to instantiate and destroy prefabs at runtime for weapons, hit effects, explosions, pickups, and enemies.
- How to use raycasting for FPS shooting and apply damage based on hit results.
- How to build a pickup architecture using inheritance and trigger colliders.
- How to update UI elements for ammo and player shield state.
- How to use Cinemachine for zoom, camera shake/recoil, and death camera transitions.
- How to use Unity physics queries such as `Physics.Raycast` and `Physics.OverlapSphere`.
- How to use NavMesh-based enemy movement and spawn enemies while the player is alive.
- How to implement turret enemies that track the player and fire projectiles on a timed coroutine.
- How to initialize projectile damage, move projectiles with a Rigidbody, detect trigger collisions, and spawn impact VFX.
- How to use `GetComponentInParent` when applying damage to enemies with nested colliders.
- How to track enemy count through a central `GameManager` and display win-state UI.
- How to reload the active scene with `SceneManager` and expose restart/quit actions for UI buttons.
- How to manage cursor lock state when entering gameplay and when showing the game-over screen.
- How to organize Unity project files for scripts, prefabs, scenes, materials, settings, animations, and data assets.

## Features

- First-person movement, camera look, jumping, sprinting, shooting, and zooming.
- Multiple weapons: pistol, machine gun, and sniper rifle.
- Configurable weapon stats through `WeaponSO` assets.
- Ammo pickups and weapon pickups.
- Enemy spawners that generate enemies while the player is alive.
- Enemy pursuit behavior using Unity NavMesh.
- Turret enemies that rotate toward the player and fire projectile prefabs.
- Projectile damage, collision handling, and projectile impact VFX.
- Enemy counter and win-state UI.
- Player shield UI, game-over UI, and death camera behavior.
- Restart and quit actions managed through a central game manager.
- Muzzle flash, hit VFX, projectile hit VFX, explosion VFX, and recoil feedback.
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

This project was developed while following the **Sharp Shooter** section of:

[Complete C# Unity 3D Game Development in Unity 6](https://www.udemy.com/course/unitycourse2/)  
Created by Rick Davidson, GameDev.tv Team, and Stephen Hubbard.

This repository does not represent the full course. It focuses on the FPS systems and gameplay mechanics implemented during the Sharp Shooter section.

## How to Open the Project

1. Clone the repository:

```bash
git clone https://github.com/SuzhisRam/Sharp_Shooter_Game.git
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
Images/                README preview images
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
- `Turret.cs`: rotates a turret head toward the player and fires projectiles on a timer.
- `Projectile.cs`: moves turret shots forward, applies player damage, and spawns impact VFX.
- `SpawnGate.cs`: spawns enemies while the player is alive.
- `Pickup.cs`: base class for collectible items.
- `AmmoPickup.cs`: adds ammo to the active weapon.
- `WeaponPickup.cs`: changes the active weapon.
- `Explosion.cs`: applies area damage to the player.
- `GameManager.cs`: tracks remaining enemies, displays win UI, and exposes restart/quit actions.

## GitHub Notes

The repository includes a Unity-focused `.gitignore`. Generated folders such as `Library`, `Temp`, `Logs`, `Build`, and `UserSettings` should not be committed. Unity `.meta` files should be committed because they preserve asset references.

Recommended files and folders to include:

- `Assets/`
- `Images/`
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

Playable learning project focused on the Sharp Shooter FPS section, with weapon switching, ammo, pickups, raycast shooting, enemy spawning, turret projectiles, explosions, enemy counter/win UI, game-over flow, shield UI, and camera feedback.
