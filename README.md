✅ Phase 0: Planning & Infrastructure (Week 1)
Establish the foundation for both frontend and backend components.

Tasks
 Set up Git repository & project board (e.g., GitHub Projects, Azure DevOps).

 Define technology stack (backend, frontend, database, Twitch API integration).

 Set up backend project (e.g., ASP.NET Core / Node.js).

 Set up frontend web app (e.g., Angular, React, or Blazor).

 Set up database (e.g., PostgreSQL, Firebase, or SQLite).

 Define schema:

Player (XP, gold, stats)

Class XP (Warrior, Cleric, etc.)

ChannelRecord

 Register Twitch app and set up OAuth flow.

🎮 Phase 1: MVP Core Gameplay Loop (Weeks 2–3)
Establish the basic loop: players earn XP, fight, and see results.

Backend
 Implement XP accumulation:

Idle XP (1 per 5 min)

XP via commands

 Implement 1 enemy: Goblin

 Implement 1 class: Fighter (STR, DEX, CON, INT, WIS, CHA)

 Combat logic:

rpg attack [monster]

Turn-based mechanics (simplified)

 Damage calculation & stat effects

 Player Leveling (PlayerXP and FighterXP)

Frontend/App
 Mobile-friendly web app:

Display player stats

Show current scene

Scene deck view

 Basic login with Twitch OAuth

 Chat command parser (via Twitch PubSub or IRC)

🧩 Phase 2: Scene System (Weeks 4–5)
Add the random scene deck and associated mechanics.

Scene Deck System
 Define scene types: Random Battle, Reward

 Shuffle and draw logic

 Weighted card frequency over time

 Ranger class ability (future-ready: remove cards)

App
 Visualize scene deck (card style)
 Show current scene drawn

Twitch Overlay
 Popup window on stream when scene/event occurs

 Timer for how long it stays visible

🧙 Phase 3: Progression & Persistence (Weeks 6–7)
Expand leveling, XP tracking, and database persistence.

 Persist player progress to DB

 Track gold and Health Potion drops
 Death Penalty logic (e.g., 10% XP loss or gold loss)
 Implement rpg stats command

 Implement cooldown system for class switching (1 hour lock)

⚔️ Phase 4: Expansion Features (Weeks 8–10)
Begin scaling the game with new content and gameplay variety.
 Add more scene types:

Boss Fight

Travel

NPC Encounter
 Add Shopping Scene and Gold Spend
 Add 2nd Class (Cleric or Rogue)
 Class switching logic
 Sub/bit XP bonuses
 Basic inventory management (Health Potion use)

📣 Phase 5: Alpha Test & Feedback (Week 11–12)
Invite a small group of viewers to test the system on stream.
 Internal playtesting
 Fix bugs from testing
 Deploy to test Twitch stream

 Collect player feedback

 Prioritize next features based on feedback

🧪 Optional Future Phases
Party mechanics (group vs. solo)

More classes and enemies

Spell system (rpg cast [spell])

Dynamic scene music and SFX

In-app push notifications

Achievements / collectibles

Patreon/subscriber perks