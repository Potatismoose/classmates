using classmates.ObjectClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace classmates.StaticClasses
{
    class Menus
    {
        private static int left = 35;
        private static int top = 7;

        private static List<string> startMenu = new List<string>() { 
            "Lista alla klasskamrater", 
            "Detaljer om klasskamrater",
            "Infotext om mina klasskamrater",
            "Redigera en klasskamrat",
            "Ta bort en klasskamrat",
            "Avsluta programmet" };

        private static List<string> listAllClassmatesMenu = new List<string>() {
            "Tillbaka",
            "Avsluta programmet"
             };
        private static List<string> listBasicClassmatesMenu = new List<string>() {
            "Tillbaka",
            "Avsluta programmet"
             };

        static bool continueOn = default(bool);
        /*----------------------------------------------------------
                            DIFFERENT MENUES
         ----------------------------------------------------------*/

        public static void StartMenu(List<Classmates> listOfClassmates)
        {
            
            do
            {
                Console.Clear();
                FileHandling.LogoPrint("start");

                PrintMenu(startMenu);
                Print.Blue(@"Ange ett alternativ \>");
                int menuChoice;
                int.TryParse(Console.ReadLine(), out menuChoice);

                switch (menuChoice)
                {

                    case 1:
                        Menus.ListAllClassmates(listOfClassmates);
                        break;
                    case 2:
                        Menus.ListDetailsClassmates(listOfClassmates, listBasicClassmatesMenu);
                        break;
                    case 3:
                        
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    case 0:
                    default:
                        top = startMenu.Count + 11;
                        left = 0;
                        Console.SetCursorPosition(left, top);
                        Print.Red("Felaktigt val, försök igen");
                        Thread.Sleep(1500);
                        
                        break;

                } 
            } while (true);
        }

        public static void ListAllClassmates(List<Classmates> listOfClassmates)
        {
            do
            {
                top = 7;
                left = 35;
                FileHandling.LogoPrint("start");

                PrintMenu(listAllClassmatesMenu);


                Console.SetCursorPosition(left, top);
                Print.Yellow($"Det finns {listOfClassmates.Count} st i klassen, och dessa är:");
                for (int i = 0; i < listOfClassmates.Count; i++)
                {
                    top++;
                    Console.SetCursorPosition(left, top);
                    Console.WriteLine($"{listOfClassmates[i].Name}, {listOfClassmates[i].Age} år");
                }
                top = listAllClassmatesMenu.Count+10;
                left = 0;
                Console.SetCursorPosition(left, top);
                Print.Blue(@"Ange ett alternativ \>");

                string userInput = Console.ReadLine().ToLower();
            
          

                    switch (userInput)
                    {

                        case "b":
                            StartMenu(listOfClassmates);
                            break;
                        case "a":
                            Environment.Exit(0);
                            break;

                        default:
                            top = listAllClassmatesMenu.Count + 11;
                            left = 0;
                            Console.SetCursorPosition(left, top);
                            Print.Red("Felaktigt val, försök igen");
                            Thread.Sleep(1500);
                            ListAllClassmates(listOfClassmates);
                            break;
                    }

            } while (true);
 
        }

        public static void ListDetailsClassmates(List<Classmates> listOfClassmates, List<string> menuList)
        {
            do
            {
                top = menuList.Count + 6;
                left = 35;
                FileHandling.LogoPrint("details");
                PrintMenu(menuList);

                Console.SetCursorPosition(left, top);
                Print.Yellow($"Visa info om:");
                for (int i = 0; i < listOfClassmates.Count; i++)
                {
                    top++;
                    Console.SetCursorPosition(left, top);
                    Console.WriteLine($"{i + 1}. {listOfClassmates[i].Name}");
                }
                top = menuList.Count + 11;
                left = 0;
                Console.SetCursorPosition(left, top);
                Print.Blue(@"Ange ett alternativ \>");
                string userInput = Console.ReadLine().ToLower();
                int convertedInput = 100;
                try
                {
                    convertedInput = Convert.ToInt32(userInput);
                }
                catch
                {

                    switch (userInput)
                    {

                        case "b":
                            StartMenu(listOfClassmates);
                            break;
                        case "a":
                            Environment.Exit(0);
                            break;

                        default:
                            top = listAllClassmatesMenu.Count + 12;
                            left = 0;
                            Console.SetCursorPosition(left, top);
                            Print.Red("Felaktigt val, försök igen");
                            Thread.Sleep(1500);

                            break;
                    }
                }

                if (convertedInput != 100)
                {
                    switch (convertedInput)
                    {

                        case 1:
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                        case 10:
                            
                            listOfClassmates[convertedInput - 1].ShowDetails();
                            break;
                        default:
                            top = listAllClassmatesMenu.Count + 12;
                            left = 0;
                            Console.SetCursorPosition(left, top);
                            Print.Red("Felaktigt val, försök igen");
                            Thread.Sleep(1500);
                            
                            break;

                    }
                } 
            } while (true);
        }

        public static void ListInfotextClassmates(List<Classmates> listOfClassmates, List<string> menuList)
        {
            do
            {
                top = menuList.Count + 6;
                left = 35;
                FileHandling.LogoPrint("details");
                PrintMenu(menuList);

                Console.SetCursorPosition(left, top);
                Print.Yellow($"Visa info om:");
                for (int i = 0; i < listOfClassmates.Count; i++)
                {
                    top++;
                    Console.SetCursorPosition(left, top);
                    Console.WriteLine($"{i + 1}. {listOfClassmates[i].Name}");
                }
                top = menuList.Count + 11;
                left = 0;
                Console.SetCursorPosition(left, top);
                Print.Blue(@"Ange ett alternativ \>");
                string userInput = Console.ReadLine().ToLower();
                int convertedInput = 100;
                try
                {
                    convertedInput = Convert.ToInt32(userInput);
                }
                catch
                {

                    switch (userInput)
                    {

                        case "b":
                            StartMenu(listOfClassmates);
                            break;
                        case "a":
                            Environment.Exit(0);
                            break;

                        default:
                            top = listAllClassmatesMenu.Count + 12;
                            left = 0;
                            Console.SetCursorPosition(left, top);
                            Print.Red("Felaktigt val, försök igen");
                            Thread.Sleep(1500);

                            break;
                    }
                }

                if (convertedInput != 100)
                {
                    switch (convertedInput)
                    {

                        case 1:
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                        case 10:

                            listOfClassmates[convertedInput - 1].ShowDetails();
                            break;
                        default:
                            top = listAllClassmatesMenu.Count + 12;
                            left = 0;
                            Console.SetCursorPosition(left, top);
                            Print.Red("Felaktigt val, försök igen");
                            Thread.Sleep(1500);

                            break;

                    }
                }
            } while (true);
        }

        private static void PrintMenu(List<string> menuList)
        {
            //List that´s used if the menu is only 2 counts long. That menu is used only if the user has the
            //list of classmates to choose from AND want´s to use characters to navigate back to menu or quit program
            List<char> abc = new List<char>(){ 'b','a'};
            do
            {
                Console.WriteLine();
                int longestEntity = default(int);
                //Itterate thru the menu that´s passed into the method
                for (int i = 0; i < menuList.Count; i++)
                {
                    //Measures the longest menu alternative to be able to print the _ in the end of the menu
                    if (menuList[i].Length > longestEntity)
                    {
                        longestEntity = menuList[i].Length;
                    }

                    //If the menu is has no more then max 2 entities
                    if (menuList.Count <= 2)
                    {
                        Console.WriteLine();
                        
                        if (i == menuList.Count - 1)
                        {
                            
                            Print.Blue($"{abc[i]}. {menuList[i]}");
                            for (int j = 0; j < longestEntity + 4; j++)
                            {
                                Console.Write("_");
                            }
                            
                        }
                        else {
                            Print.Blue($"{abc[i]}. {menuList[i]}");
                        }
                    }


                    else if (i == 0 && menuList.Count != 1)
                    {
                        
                        Console.WriteLine();

                        Print.Blue($"{i + 1}. {menuList[i]}");
                    }


                    else if (i == menuList.Count - 1)
                    {
                        if (menuList.Count == 1)
                        {
                            Console.WriteLine();
                        }
                        Console.WriteLine();

                        Print.Blue($"{i + 1}. {menuList[i]}");
                        for (int j = 0; j < longestEntity + 4; j++)
                        {
                            Console.Write("_");
                        }
                        continueOn = true;
                        Console.WriteLine(Environment.NewLine);

                        if (menuList.Count == 1)
                        {
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Print.Blue($"{i + 1}. {menuList[i]}");
                    }


                }


            } while (!continueOn);
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

        /*----------------------------------------------------------
         [END OF]           DIFFERENT MENUES
         ----------------------------------------------------------*/
    }
}
