# CodeQuest

# Joc de proves
## Capitol 1
| Opció menú | nivell | exp | dia | títol            | nom     | Sortida (Output)                                                                                                                                                                                         |
| ---------- | ------ | --- | --- | ---------------- | ------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| 1          | 0      | 0   | 0   | "the Elantrí"    | "Pablo" | "You started your training" -> "You trained for 5 hours and gained 6 experience." -> "You repeat in the 2nd call." -> "You have 6 exp and are level 0."                                             |
| 1          | 0      | 6   | 0   | "the Elantrí"    | "Pablo" | "You started your training" -> "You trained for 12 hours and gained 3 experience." -> "You repeat in the 2nd call." -> "You have 9 exp and are level 0."                                             |
| 1          | 0      | 9   | 1   | "the Elantrí"    | "Pablo" | "You started your training" -> "You trained for 21 hours and gained 4 experience." -> "You repeat in the 2nd call." -> "You have 13 exp and are level 0."                                            |
| 1          | 1      | 21  | 3   | "the Bugged"     | "Pablo" | "You started your training" -> "You trained for 2 hours and gained 8 experience." -> "You still confuse the magic wand with a spoon" -> "Level up! You are now level 1: the Bugged"                 |
| 1          | 2      | 31  | 4   | "Nullpointer"    | "Pablo" | "You started your training" -> "You trained for 18 hours and gained 10 experience." -> "You are a Summoner of Magical Breezes." -> "Level up! You are now level 2: Nullpointer"                      |
| 1          | 3      | 36  | 5   | "of the Brasses" | "Pablo" | "You started your training" -> "You trained for 15 hours and gained 5 experience." -> "Wow! You can summon dragons without burning down the lab!" -> "Level up! You are now level 3: of the Brasses" |
| 1          | 4      | 41  | 6   | "the Gray"       | "Pablo" | "You started your training" -> "You trained for 2 hours and gained 5 experience." -> "You have reached the rank of Arcane Master!" -> "Level up! You are now level 4: the Gray"                     |


## Capitol 2
### Situació de victoria
| Porta (i) | Codi correcte | Codi introduït | Intent | Porta superada | dungeonWin | Sortida (Output)                                                                                                                                    |
| --------- | ------------- | -------------- | ------ | -------------- | ---------- | --------------------------------------------------------------------------------------------------------------------------------------------------- |
| 1         | 3             | 2              | 1      | false          | true       | "The code introduced was incorrect. You have 2 tries remaining."                                                                                  |
| 1         | 3             | 4              | 2      | false          | true       | "The code introduced was incorrect. You have 1 tries remaining."                                                                                  |
| 1         | 3             | 3              | 3      | true           | true       | "You entered correctly!"                                                                                                                          |
| 2         | 5             | 5              | 3      | true           | true       | "You passed the first door, 2 more and you win"                                                                                                   |
| 3         | 2             | 2              | 1      | true           | true       | "You only need another door to win!" -> "The dragon respects you. You have unlocked the next level!" -> "You got some excavators to mine bits!" |

### Situació de derrota
| Porta (i) | Codi correcte | Codi introduït | Intent | Porta superada | dungeonWin | Sortida (Output)                                                                |
| --------- | ------------- | -------------- | ------ | -------------- | ---------- | ------------------------------------------------------------------------------- |
| 1         | 4             | 4              | 1      | true           | true       | "Door passed successfully."                                                   |
| 2         | 1             | 2              | 1      | false          | true       | "The code introduced was incorrect. You have 2 tries remaining."              |
| 2         | 1             | 3              | 2      | false          | true       | "The code introduced was incorrect. You have 1 tries remaining."              |
| 2         | 1             | 5              | 3      | false          | false      | "The dragon has detected your presence and has expelled you from the server!" |

## Capitol 3
| Acció      | bits (abans) | excavadores (abans) | bits guanyats | bits (després) | excavadores (després) | Sortida (Output)                                                                                                                                                                              |
| ---------- | ------------ | ------------------- | ------------- | -------------- | --------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Inici mina | 0            | 5                   | 27            | 27             | 4                     | "You started mining..." -> "You finished your mining and winned 27 bits. You have 4 excavations remaining."                                                                                |
| Inici mina | 27           | 4                   | 10            | 37             | 3                     | "You started mining..." -> "You finished your mining and winned 10 bits. You have 3 excavations remaining."                                                                                |
| Inici mina | 37           | 3                   | 0             | 37             | 2                     | "You started mining..." -> "Today is not your lucky day, you found 0 bits."                                                                                                                |
| Inici mina | 37           | 2                   | 45            | 82             | 1                     | "You started mining..." -> "You finished your mining and winned 45 bits. You have 1 excavations remaining."                                                                                |
| Inici mina | 82           | 1                   | 38            | 120            | 0                     | "You started mining..." -> "You finished your mining and winned 38 bits. You have 0 excavations remaining." -> "Your magic card is still integrated. It's time to defeat another dragon!" |
| Inici mina | 180          | 1                   | 30            | 210            | 0                     | "You started mining..." -> "You finished your mining and winned 30 bits. You have 0 excavations remaining." -> "You’ve unlocked the gold GPU! Your spells now run at 120 FPS!"            |
| Inici mina | 134          | 0                   | —             | 134            | 0                     | "You don't have excavators to mine!"                                                                                                                                                        |
| Inici mina | 82           | 3                   | 0             | 82             | 2                     | "You started mining..." -> "Today is not your lucky day, you found 0 bits."                                                                                                                |



