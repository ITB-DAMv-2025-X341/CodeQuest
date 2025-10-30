using System;

namespace CodeQuest
{
    class Program
    {
        public static void Main()
        {
            //Chapter 1
            //Constants: Messages
            //Global
            const string MsgDay = "Day {0}.";
            //Levels
            const string Level0 = "the Bugged";
            const string Level1 = "Nullpointer";
            const string Level2 = "of the Brasses";
            const string Level3 = "the Gray";
            //Introduction
            const string MsgWelcome = "Welcome to CodeQuest!";
            const string MsgName = "Tell us your name: ";
            const string MsgErrorName = "That's not a name, tell us your name: >";
            const string MsgAfterName = " eh, cool name.";
            const string MsgEndIntroduction = "Now, before start, you will need to train. Good luck out there...";
            //Main menu
            const string MsgMenuCh1Opt1 = "===MAIN MENU===";
            const string MsgMenuCh1Opt2 = "1. Train";
            const string MsgMenuCh1Opt3 = "2. Fight (Locked)";
            const string MsgMenuCh1Opt4 = "0. Exit";
            const string MsgOption = "Select option: >";
            //Training
            const string MsgStartTraining = "You started your training";
            const string MsgFinishedTraining = "You trained for {0} hours and gained {1} experience.";
            const string MsgNewLevel = "Level up!\nYou are now level {0}\nYou are now ${1} {2}";
            const string MsgLevel = "You have {0} exp and are level {1}";
            const string MsgLevel0 = "You still confuse the magic wand with a spoon";
            const string MsgLevel1 = "You still confuse the magic wand with a spoon";
            const string MsgLevel2 = "You still confuse the magic wand with a spoon";
            const string MsgLevel3 = "You still confuse the magic wand with a spoon";
            

            //Variables
            int menuOption, level, exp, day;
            string name, menuOptionStr;

            //Initialize some variables
            exp = 0; 
            day = 0;

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
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(name + MsgAfterName);
            Console.WriteLine(MsgEndIntroduction);
            Thread.Sleep(5000);
            Console.Clear();

            
        }
    }
}