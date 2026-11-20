# Crownfall – Game Design Document (GDD)

**Project Name:** Crownfall  
**Created By:** Ganzorig Arvinbileg  
**Genre:** 2D Fantasy Real-Time Strategy (RTS)  
**Game Engine:** Unity 6.6  
**Programming Language:** C#  
**Game Mode:** Offline Player vs AI  
**Version:** 0.1  
**Document Status:** Initial Design

---

## 1. Game Overview

Crownfall is a 2D fantasy real-time strategy game inspired by classic army management and kingdom warfare games.

Players control a kingdom and compete against an opposing AI-controlled kingdom. They collect resources, recruit soldiers, manage their armies, and issue strategic commands to defeat their opponent.

Unlike games where players directly control individual characters, Crownfall focuses on army management and strategic decisions. Soldiers automatically move and fight based on their behavior and the commands given by the player.

The main objective is to destroy the enemy castle while protecting your own.

## 2. Game Vision

The goal is to create an enjoyable and accessible strategy game with simple controls and meaningful strategic decisions.

The game should provide:
- Easy-to-understand gameplay.
- Different unit roles and abilities.
- Resource management.
- Strategic army commands.
- Automatic combat.
- A challenging AI opponent.
- Clear victory and defeat conditions.

## 3. Target Gameplay

### Game Perspective

- 2D side-view battlefield.
- Two opposing kingdoms.
- One player-controlled kingdom.
- One AI-controlled kingdom.
- Real-time strategy gameplay.

### Main Objective

Destroy the enemy castle while keeping your own castle alive.

### Match Structure

1. The player enters the battlefield.
2. Both kingdoms start with an initial amount of gold.
3. Players recruit miners to collect gold.
4. Gold is used to recruit military units.
5. Players issue commands to their armies.
6. Soldiers automatically move and engage enemies.
7. The battle continues until one castle is destroyed.

## 4. Core Gameplay Systems

### 4.1 Resource Management

Gold is the primary resource in Version 0.1.

Gold is required to:
- Recruit miners.
- Recruit soldiers.
- Maintain and expand the army.

Initial rules:
- Both sides start with equal resources.
- Miners automatically collect gold.
- Each unit has a recruitment cost.
- Gold cannot become negative.
- Recruitment is rejected when the player has insufficient gold.

### 4.2 Unit Recruitment

Players can recruit units using the recruitment interface.

Each unit has:
- Recruitment cost.
- Health.
- Attack damage.
- Attack speed.
- Movement speed.
- Attack range.

### 4.3 Unit Types

Version 0.1 will include three initial units.

#### Miner
**Role:** Resource collection

- Collects gold.
- Does not normally participate in combat.
- Can be attacked by enemy units.
- Supports the kingdom's economy.

#### Swordsman
**Role:** Melee combat

- Attacks enemies at close range.
- Serves as a basic frontline soldier.
- Has moderate health and damage.
- Suitable for early attacks and defense.

#### Archer
**Role:** Ranged combat

- Attacks enemies from a distance.
- Supports frontline soldiers.
- Deals damage before enemies reach close range.
- Has lower durability than frontline units.

Additional units, such as guardians, mages, cavalry, and siege weapons, may be introduced in future versions.

### 4.4 Army Command System

Players manage their armies through strategic commands rather than directly controlling individual soldiers.

Initial commands:

**Defend**
- Units protect their assigned area.
- Units engage enemies that enter their defensive range.

**Hold Position**
- Units remain near their assigned position.
- Units do not advance toward the enemy.

**Attack**
- Units advance toward enemy territory.
- Units engage enemies according to their combat behavior.

**Retreat**
- Units move toward their own castle.

The commands should affect how units behave during a match.

### 4.5 Combat System

Combat happens automatically when opposing units enter their attack range.

Combat rules:
- Units detect valid enemy targets.
- Units attack when targets are within range.
- Attacks reduce the target's health.
- Units are defeated when their health reaches zero.
- Defeated units are removed from the battlefield.

Combat behavior should be consistent and predictable.

### 4.6 Castle System

Each kingdom has one main castle.

Castle properties:
- Health.
- Ownership.
- Position.
- Damage handling.

The castle can receive damage from enemy attacks.

The match ends when a castle's health reaches zero.

## 5. AI Opponent

Version 0.1 will include a basic AI-controlled opponent.

The AI should be able to:
- Collect resources.
- Recruit miners.
- Recruit military units.
- Maintain a basic army.
- Defend its castle.
- Send units to attack the player's kingdom.

The initial AI does not need advanced decision-making. Its purpose is to provide a functional opponent for testing and gameplay.

## 6. Game Interface

The game will include the following screens and interface elements.

### Main Menu
- Start Game.
- Settings.
- Exit Game.

### Gameplay Interface (HUD)
- Player gold.
- Enemy gold (if displayed).
- Recruitment buttons.
- Current army information.
- Army command buttons.
- Player castle health.
- Enemy castle health.

### Pause Menu
- Resume.
- Restart.
- Main Menu.

### Victory Screen
- Displays when the enemy castle is destroyed.
- Provides an option to play again or return to the main menu.

### Defeat Screen
- Displays when the player's castle is destroyed.
- Provides an option to restart or return to the main menu.

## 7. Battlefield and Visual Design

Crownfall will use a 2D fantasy medieval visual style.

The environment may include:
- Medieval castles.
- Grass and natural terrain.
- Mountains and distant backgrounds.
- Fantasy-themed characters.
- Weapons and combat effects.

The first version will contain one battlefield called Green Valley.

The visual design should make the two opposing teams easy to distinguish.

All character designs, artwork, animations, and other creative assets will be original or properly licensed.

## 8. Audio Design

Audio may include:
- Background music.
- Unit movement sounds.
- Mining sounds.
- Attack and impact sounds.
- Unit defeat sounds.
- Button interaction sounds.
- Victory and defeat sounds.

Audio implementation will be kept simple in the first version.

## 9. Technical Design

### Development Environment

| Component | Technology |
|---|---|
| Game Engine | Unity 6.6 |
| Programming Language | C# |
| Game Type | 2D |
| Physics | Unity 2D Physics |
| IDE | Visual Studio |
| Version Control | Git |
| Repository | GitHub |

### Main Game Systems

The project will be organized into separate systems.

**Game Manager**
- Controls the overall game state.
- Starts and ends matches.
- Tracks victory and defeat conditions.

**Economy Manager**
- Tracks player resources.
- Handles gold collection.
- Validates recruitment costs.

**Army Manager**
- Handles unit recruitment.
- Tracks active units.
- Manages army information.

**Battle Manager**
- Handles combat interactions.
- Processes damage.
- Manages unit defeat.

**Command Manager**
- Handles player commands.
- Controls army behavior.

**AI Manager**
- Controls the enemy kingdom.
- Handles recruitment and basic strategic decisions.

**UI Manager**
- Controls menus and gameplay interface.
- Updates resource and health displays.

These systems may be implemented and adjusted as development progresses.

## 10. Initial Game Rules

The following rules will guide the initial implementation:

1. Both kingdoms begin with equal starting resources.
2. Players cannot spend more gold than they have.
3. Units must have valid targets before attacking.
4. Units cannot attack targets outside their attack range.
5. Units are defeated when their health reaches zero.
6. Miners collect gold rather than participating in normal combat.
7. The player can issue strategic commands to their army.
8. The match ends when either castle reaches zero health.
9. Only one victory or defeat result should be recorded per match.
10. Restarting a match should reset the relevant game state.

Exact numerical values, such as unit health, recruitment costs, attack damage, and resource collection rates, will be determined and adjusted during implementation and gameplay testing.

## 11. Quality Assurance Considerations

QA will be included throughout development.

Important testing areas include:

- Resource collection and calculations.
- Unit recruitment and costs.
- Unit movement.
- Combat and damage calculations.
- Attack range.
- Army commands.
- AI behavior.
- Castle health.
- Victory and defeat conditions.
- Pause and restart functionality.
- User interface behavior.
- Game-state consistency.

Testing will include functional testing, exploratory testing, negative testing, boundary testing, regression testing, and basic automated testing.

Actual defects will be documented with reproduction steps, expected results, actual results, severity, and supporting evidence.

## 12. Future Development Possibilities

The following features are outside Version 0.1 but may be considered later:

- Online 1v1 multiplayer.
- Private multiplayer rooms.
- Public matchmaking.
- Multiple battlefield maps.
- Additional unit types.
- Unit upgrades.
- Special abilities and magic.
- Defensive structures.
- Advanced AI.
- Ranking and progression systems.
- Match history and replays.

These features will only be considered after the initial offline game is completed and tested.

## 13. Project Scope Summary

Version 0.1 focuses on creating a small but functional offline strategy game.

The main priorities are:
1. Resource management.
2. Unit recruitment.
3. Unit movement and combat.
4. Strategic commands.
5. Basic AI opponent.
6. Castle destruction and match completion.
7. Quality assurance and documentation.

The game should be playable, testable, and suitable for demonstrating practical game QA skills.

---

**Author:** Ganzorig Arvinbileg  
**Project:** Crownfall  
**Repository:** https://github.com/GanzorigA24/Crownfall  
**Document:** Project Work Plan  
**Version:** 1.0
