using System;
using System.Collections.Generic;
using System.Text;

namespace classmates.StaticClasses
{
    static class Print
    {
        /*
        ---------------------------------------------------------------
        METHODS FOR FORMATING AND PRINTING TEXT IN DIFFERENT COLORS
        ---------------------------------------------------------------
        */
        public static void Red(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ResetColor();
        }
        public static void Yellow(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(text);
            Console.ResetColor();
        }
        public static void YellowW(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(text);
            Console.ResetColor();
        }
        public static void Green(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(text);
            Console.ResetColor();
        }
        public static void Grey(string text)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(text);
            Console.ResetColor();

        }
        public static void Blue(string text)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            if (text.Contains("alternativ"))
            {
                Console.Write(text);
            }
            else
            {
                Console.WriteLine(text);
            }
            Console.ResetColor();

        }

    }
}
