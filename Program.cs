using System;

namespace CodeQuest
{
    class Program
    {
        //Chapter 1
        //Constants: Messages
        //Global
        const string MsgDay = "Day {0}.";
        //Levels
        const string Level0 = "the Elantrí";
        const string Level1 = "the Bugged";
        const string Level2 = "Nullpointer";
        const string Level3 = "of the Brasses";
        const string Level4 = "the Gray";
        //Introduction
        const string MsgWelcome = "Welcome to CodeQuest!";
        const string MsgName = "Tell us your name: ";
        const string MsgErrorName = "That's not a name, tell us your name: >";
        const string MsgAfterName = " eh, cool name.";
        const string MsgEndIntroduction = "Now, before start, you will need to train. Good luck out there...";
        //Main menu
        const string MsgMenuName = "{0}: {1}";
        const string MsgMenuExp = "Experience: {0}";
        const string MsgMenuBits = "Bits: {0}. Excavators {1}";
        const string MsgMenuCh1Opt1 = "===MAIN MENU===";
        const string MsgMenuCh1Opt2 = "1. Train";
        const string MsgMenuCh1Opt3 = "2. Dungeon";
        const string MsgMenuCh1Opt4 = "3. Mine";
        const string MsgMenuCh1Opt5 = "0. Exit";
        const string MsgOption = "Select option: >";
        //Training
        const string MsgStartTraining = "You started your training";
        const string MsgFinishedTraining = "You trained for {0} hours and gained {1} experience.";
        const string MsgNewLevel = "Level up!\nYou are now level {0}\nYou are now {1}: {2}";
        const string MsgLevel = "You have {0} exp and are level {1}";
        const string MsgLevel0 = "You repeat in the 2nd call.";
        const string MsgLevel1 = "You still confuse the magic wand with a spoon";
        const string MsgLevel2 = "You are a Summoner of Magical Breezes.";
        const string MsgLevel3 = "Wow! You can summon dragons without burning down the lab!";
        const string MsgLevel4 = "You have reached the rank of Arcane Master!";

        //Chapter 2
        const string MsgEnterDungeon = "You entered RAMón's dungeon.\nYou need to pass 3 doors with a code to win.\nWatch out for the dragon.";
        const string MsgDungeonDoors = "You see a door with a code you need to get in";
        const string MsgDungeonDoor2 = "You passed the first door, 2 more and you win";
        const string MsgDungeonDoor3 = "You only need another door to win!";
        const string MsgDungeonWin = "The dragon respects you. You have unlocked the next level!";
        const string MsgDungeonLose = "The dragon has detected your presence and has expelled you from the server!";
        const string MsgDungeonInput = "What code will you enter? (From 1 to 5) >";
        const string MsgDungeonError = "The code introduced was incorrect. You have {0} tries remaining.";

        //Chapter 3
        const string MsgDungeonGetExcavators = "You got some excavators to mine bits!";
        const string MsgMineStart = "You started mining...";
        const string MsgMineFinish = "You finished you mining and winned {0} bits.\nYou have {1} excavations remaining";
        const string MsgMineGoldenGpu = "You’ve unlocked the gold GPU! Your spells now run at 120 FPS!";
        const string MsgMineNoGoldenGpu = "Your magic card is still integrated. It's time to defeat another dragon!";
        const string MsgMineError = "You don't have excavators to mine!";
        const string MsgMineNothing = "Today is not your lucky day, you found 0 bits.";


        public static void Main()
        {
            //Variables
            int menuOption, level, exp, day; 
            int dungOpt;
            int bits, excavators;
            string title;
            string name, menuOptionStr, dungeonOptionStr;

            //Initialize some variables
            exp = 0; 
            day = -1;
            level = 0;
            bits = 0;
            excavators = 0;

            title = Level0;

            //Set random
            var rand = new Random();


            //Introduction
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(MsgWelcome);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(MsgName);
            Console.ResetColor();
            name = Console.ReadLine();
            while (name == string.Empty)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(MsgErrorName);
                name = Console.ReadLine();
            }
            //REMOVE
            //Skip initial cutscrene and temp name
            /*
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(name + MsgAfterName);
            Console.WriteLine(MsgEndIntroduction);
            Thread.Sleep(5000);
            Console.Clear();
            */

            do
            {
                day++;
                //Menu (Chapter 1)
                Console.WriteLine();
                Console.WriteLine(MsgDay, day);
                Console.WriteLine(MsgMenuName, name, title);
                Console.WriteLine(MsgMenuExp, exp);
                Console.WriteLine(MsgMenuBits, bits, excavators);
                Console.WriteLine(MsgMenuCh1Opt1);
                Console.WriteLine(MsgMenuCh1Opt2);
                Console.WriteLine(MsgMenuCh1Opt3);
                Console.WriteLine(MsgMenuCh1Opt4);
                Console.WriteLine(MsgMenuCh1Opt5);
                Console.WriteLine();
                do
                {
                    Console.Write(MsgOption);
                    menuOptionStr = Console.ReadLine();
                } while (!int.TryParse(menuOptionStr, out menuOption));
                switch (menuOption)
                {
                    case 1:
                        Console.WriteLine(MsgStartTraining);
                        int timeRand = rand.Next(1, 25);
                        Thread.Sleep(2000);
                        int expRand = rand.Next(1, 11);
                        int beforeExp = exp;
                        exp += expRand; 
                        Console.WriteLine(MsgFinishedTraining, timeRand, expRand);
                        switch (exp)
                        {
                            case >= 40:
                                Console.WriteLine(MsgLevel4);
                                if (beforeExp < 40)
                                {
                                    level = 4;
                                    Console.WriteLine(MsgNewLevel, level, name, Level4);
                                    title = Level4;
                                }
                                break;
                            case >= 35 and < 40:
                                Console.WriteLine(MsgLevel3);
                                if (beforeExp < 35)
                                {
                                    level = 3;
                                    Console.WriteLine(MsgNewLevel, level, name, Level3);
                                    title = Level3;
                                }
                                break;
                            case >= 30 and < 35:
                                Console.WriteLine(MsgLevel2);
                                if (beforeExp < 30)
                                {
                                    level = 2;
                                    Console.WriteLine(MsgNewLevel, level, name, Level2);
                                    title = Level2;
                                }
                                break;
                            case >= 20 and < 30:
                                Console.WriteLine(MsgLevel1);
                                if (beforeExp < 20)
                                {
                                    level = 1;
                                    Console.WriteLine(MsgNewLevel, level, name, Level1);
                                    title = Level1;
                                }
                                break;
                            case < 20:
                                Console.WriteLine(MsgLevel0);
                                break;
                        }
                        Console.WriteLine(MsgLevel, exp, level);
                        break;
                    case 2:
                        Console.WriteLine(MsgEnterDungeon);
                        Thread.Sleep(1000);
                        Console.WriteLine(MsgDungeonDoors);

                        bool dungeonWin = true;
                        for (int i = 1; i <= 3; i++)
                        {
                            dungOpt = 0;
                            int correctOption = rand.Next(1, 6);
                            bool doorPassed = false;

                            for (int attempt = 1; attempt <= 3; attempt++)
                            {
                                switch (i)
                                {
                                    case 2:
                                        Console.WriteLine(MsgDungeonDoor2);
                                        break;
                                    case 3:
                                        Console.WriteLine(MsgDungeonDoor3);
                                        break;
                                    default:
                                        break;
                                }

                                do
                                {
                                    Console.Write(MsgDungeonInput);
                                    dungeonOptionStr = Console.ReadLine();
                                }
                                while (!int.TryParse(dungeonOptionStr, out dungOpt));

                                if (dungOpt == correctOption)
                                {
                                    doorPassed = true;
                                    attempt = 4;
                                }
                                else
                                {
                                    if (attempt == 3)
                                    {
                                        dungeonWin = false;
                                        Console.WriteLine(MsgDungeonLose);
                                    } else
                                    {
                                        Console.WriteLine(MsgDungeonError, (3 - attempt));
                                    }
                                }
                            }
                            if (!doorPassed)
                            {
                                i = 4;
                            }
                        }
                        if (dungeonWin)
                        {
                            Console.WriteLine(MsgDungeonWin);
                            excavators += 5;
                            Console.WriteLine(MsgDungeonGetExcavators);
                        }
                        break;
                    case 3:
                        if (excavators <= 0)
                        {
                            Console.WriteLine(MsgMineError);
                            day--;
                        } else
                        {
                            Console.WriteLine(MsgMineStart);
                            Thread.Sleep(1000);
                            if (rand.Next(1, 101) < 10)
                            {
                                Console.WriteLine(MsgMineNothing);
                                excavators--;
                            } else
                            {
                                int bitsEarned = rand.Next(5, 51);
                                excavators--;
                                Console.WriteLine(MsgMineFinish, bitsEarned, excavators);
                                bits += bitsEarned;
                            }
                            if (excavators == 0)
                            {
                                if (bits >= 200)
                                {
                                    Console.WriteLine(MsgMineGoldenGpu);
                                } else
                                {
                                    Console.WriteLine(MsgMineNoGoldenGpu);
                                }
                            }
                        }
                            break;
                    case 0:
                        Console.WriteLine("Exit");
                        break;

                }
            } while (menuOption != 0);

        }
    }
}