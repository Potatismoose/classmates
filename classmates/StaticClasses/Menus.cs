using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classmates.StaticClasses
{
    class Menus
    {
        private static List<string> startMenu = new List<string>() { 
            "Lista alla klasskamrater", 
            "Detaljer om klasskamrater",
            "Infotext om mina klasskamrater",
            "Redigera en klasskamrat",
            "Ta bort en klasskamrat",
            "Avsluta programmet" };

        private static List<string> listAllClassmatesMenu = new List<string>() {
            "Tillbaka"
             };

        static bool continueOn = default(bool);

        public static void StartMenu()
        {
            FileHandling.LogoPrint("start");
            
            do
            {
                int longestEntity = default(int);
                for (int i = 0; i < startMenu.Count; i++)
                {
                    if (startMenu[i].Length > longestEntity)
                    {
                        longestEntity = startMenu[i].Length;
                    }
                    if (i == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine();

                        Console.WriteLine($"{i + 1}. {startMenu[i]}");
                    }
                    else if (i == startMenu.Count - 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"{i + 1}. {startMenu[i]}");
                        for (int j = 0; j < longestEntity+4; j++)
                        {
                            Console.Write("_"); 
                        }
                        continueOn = true;
                        Console.WriteLine(Environment.NewLine);
                        
                    }
                    else
                    {
                        Console.WriteLine($"{i + 1}. {startMenu[i]}");
                    }
                    
                    
                } 


            } while (!continueOn);
            Console.Write(@"Ange ett alternativ \>");
            int menuChoice;
            int.TryParse(Console.ReadLine(), out menuChoice);

            switch (menuChoice) {

                case 1:

                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 0:
                default:
                    break;

            }
        }

        public static void ListAllClassmates()
        {
            FileHandling.LogoPrint("start");

            do
            {
                int longestEntity = default(int);
                for (int i = 0; i < listAllClassmatesMenu.Count; i++)
                {
                    if (startMenu[i].Length > longestEntity)
                    {
                        longestEntity = startMenu[i].Length;
                    }
                    if (i == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine();

                        Console.WriteLine($"{i + 1}. {startMenu[i]}");
                    }
                    else if (i == startMenu.Count - 1)
                    {
                        if (startMenu.Count == 1)
                        {
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        Console.WriteLine($"{i + 1}. {startMenu[i]}");
                        for (int j = 0; j < longestEntity + 4; j++)
                        {
                            Console.Write("_");
                        }
                        continueOn = true;
                        Console.WriteLine(Environment.NewLine);

                    }
                    else
                    {
                        Console.WriteLine($"{i + 1}. {startMenu[i]}");
                    }


                }


            } while (!continueOn);
            Console.Write(@"Ange ett alternativ \>");
            int menuChoice;
            int.TryParse(Console.ReadLine(), out menuChoice);

            switch (menuChoice)
            {

                case 1:

                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 0:
                default:
                    break;

            }
        }

        public static void EditMenu()
        {

        }

        public static void RemoveMenu()
        {

        }

        public static void DetailsMenu()
        {

        }
    }
}
