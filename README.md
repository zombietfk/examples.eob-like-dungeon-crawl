# EOB-like-dungeon-crawl
A Unity project, mimicking the old eye of the beholder games!

My first ever unity project, originally made in unity 5.1 in 2017

Having lived though the Unity year based versioning system completely untouched, now updated for Unity 6.0 compatability! The first updates seen in 8 long years.

Half proud, half ashamed of this project, it has all the original bugs and warts with the updated version*. A remake is certainly on the cards although will almost certainly be done in Godot, as my preferred game engine these days. Feel free to check out the build for linux, windows or on my itch.io account, and perhaps anyone starting their Unity journey can take some of the code to see how I did things (Although I had no idea what I was doing at the time! So take what you will, with a grain of salt ;))

*Difficulty was lowered as the original was too damn hard for me now, and some unused UI elements were removed, but everything else has remained the same! See 1.1.0 Release notes for details

# Game Manual
## Stats
As you kill enemies, you will gain experience. It is tracked by the yellow bar in the UI. Every time you level up, you gain TWO points to spend. You additionally begin the game with 3 points.

- Strength increase attack cooldown and increases your health.
- Intelligence reduces spell cooldown, increases spell damage, and gives more mana.
- Luck increases light radius
- Dexterity makes you move faster, making it easier to evade traps and enemies.

## General Hints
- When you start the game, behind you is a map. You should grab it. There are only 5 levels in the game but it's pretty dark and easy to get lost!
- Heavier weapons do more damage but attack slower.
- When you level up, prioritise Strength. It makes your standard attack faster and increase HP.
- Dexterity does not need to be increased beyong a certain level.
- Intelligence is most useful for casting the ice spell - Try to save your mana for the late game where it will allow you to safely take care of the strongest enemies (Black Knights, Kebab)
- Don't bother investing too many points on luck. Especially if you have the map.
- Enemies have an attach pattern. Try to dance around them and attack after they have moved.
- Some walls are fake. Try finding as many secrets as you can!
- Some switches will activate timed effects. If you want to reset them, turn the switch off and on again (Twice, not once).
- If you are really in a pinch. Go outside for a walk. Have a coffee. Do some work. You regenerate health although at quite a slow rate.

## Enemies
### Bats
<img width="64" height="128" alt="bat" src="https://github.com/user-attachments/assets/42c8a656-32e2-492e-9c37-22a38a51d231" />

Basic enemies. No real threat. Can fly over some obsticles.

### Snakes
<img width="64" height="128" alt="snake" src="https://github.com/user-attachments/assets/4440748b-f5ca-404d-bae0-9cb42566a726" />

Slightly faster than bats, but not much of a threat.

### Skeletons
<img width="64" height="128" alt="skeleton" src="https://github.com/user-attachments/assets/c9be8b61-44b4-4af5-9a95-13c46761dce6" />

Skeletons look intimidating but are quite slow, even if they have slightly more HP than bats or snakes.

### Grorklin
<img width="64" height="128" alt="goblin" src="https://github.com/user-attachments/assets/73bb5189-a8c9-4eb0-be3f-2d3bf1b86177" />

Very fast. Be careful as they usually attack in small swarms after activating traps. These enemies are a real threat.

### Grork
<img width="64" height="128" alt="grork" src="https://github.com/user-attachments/assets/0cf7e663-d595-4101-9958-756c76a9b934" />

Quite simple to deal with one on one. Not as fast as their smaller kin, the grorklin, but pack a strong punch.

### Super Grork
<img width="64" height="128" alt="supergrork" src="https://github.com/user-attachments/assets/d41e252a-3d03-461c-ae1b-392d9dd61ef1" />

Beware! These guys are always dangerous. They hit very, very hard, and can enter an enraged state, which will also make nearby Grorks enter a rage. They will attack and move incredibly fast when they do this, so RUN

### Bomba
<img width="64" height="128" alt="bomba" src="https://github.com/user-attachments/assets/db7cd266-5263-4638-a264-84d4dc16ef92" />

Do NOT let them get close enough to explode or even kill them. They will do significant damage when they do. Just run away and hope they lose track of you.

### Black Knight
<img width="64" height="128" alt="blackknight" src="https://github.com/user-attachments/assets/b718644a-723b-4ce2-9667-f17630826341" />

These dark warriors are found in the darkest parts of the dungeon. They are the vassals of the fire demon, kebab, who has granted them the arcane ability to launch fire at their enemies. They are also increible martial warriors. They are almost in every way as powerful as yourself, and you will not get away unscathed. Try to use magic to defeat their meager arcane gifts rather than going into melee. They emit an eriee purple glow, so ata distance you will see them, before they see you.

### The Demon, Kebab
<img width="128" height="256" alt="demon" src="https://github.com/user-attachments/assets/06cf0072-42e7-477c-839d-33b76b34cdef" />

The lord of the dungeon, the fire demon - Kebab. Has powerful innate arcane talents. Try taking him out from a distance using arcane powers. His mighty firebreath can kill even the mightiest of warriors if they are face to face with the beast. Even those skilled in the magical arts from a range are not safe, but may live to continue the fight if they are unable to avoid it.
