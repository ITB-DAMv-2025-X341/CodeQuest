using System;
namespace CodeQuest
{
    public static class ConsoleHelper
    {
        private const string Reset = "\x1b[0m";
        private const string Bold = "\x1b[1m";
        private const string Underline = "\x1b[4m";

        public static void Print(string msg, ConsoleColor color = ConsoleColor.White, bool newLine = true, bool bold = false, bool underline = true)
        {
            if (bold) Console.Write(Bold);
            if (underline) Console.Write(Underline);

            Console.ForegroundColor = color;

            if (newLine)
            {
                Console.WriteLine(msg);
            }
            else
            {
                Console.Write(msg);
            }

            Console.Write(Reset);
        }
    }
}
