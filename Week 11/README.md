# Week 11
## Overview
Matias Created an arrow that spawns when touching the trap. Lorenzo created a fireball attack that consumes mana and a health pack.

## Matias' Changes:
### arrow.cs
New Script that spawns arrows from above dealing damage and disapearing on impact

### Trap.cs
Changed the trap to spawn arrows on contact

## Lorenzo's Changes:
### Enemy.cs
Enemy detects when fireball hits it, destroys fireball and takes damage.

### Fireball.cs
New script that moves the fireball.

### HealthPack.cs
New script that adds 30 health to the player when collided with.

### PlayerAttack.cs
Spawns fireball and consumes mana when player presses spacebar and moves in in direction of where mouse is from the player.

### PlayerHealth.cs
Created a AddHealth method to monitor if max health is reached.

### PlayerMana.cs
New Script that handles mana and regenerates it after a cooldown.

### PlayerMovement.cs
Made movement code more concise and pretty.

## Playthrough Video Link: 
https://youtu.be/UZVg47cEo2k