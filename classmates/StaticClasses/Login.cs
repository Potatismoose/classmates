using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using classmates.StaticClasses;

namespace classmates
{
    class Login
    {

        /*
         ---------------------------------------------------------------
                            METHOD FOR USER LOGIN
         ---------------------------------------------------------------
         */

        public static bool UserLogin()
        {
            
            //Method that prints out the logo, checks the input password and log in the user if correct.

            bool loggedIn = default(bool);
            string error = default(string);
            int loginCount = default(int);
            do
            {
                
                Console.Clear();
                //Method to print logo
                //Outputs.LogoPrint(path[0] + "logo.txt");

                //If wrong password, errormessage is printed in red as long as logincount is less than 3.
                if (!string.IsNullOrEmpty(error) && loginCount <3)
                {
                    Console.SetCursorPosition(15, 9);
                    Print.Red(error);
                    error = default(string);
                }
                Console.SetCursorPosition(15, 6);
                var pass = default(string);
                ConsoleKey key;
                Console.WriteLine("Ange lösenordet (eller q för att avsluta)");
                Console.SetCursorPosition(15, 7);
                Print.Grey(@"Lösenord\> ");
                Console.SetCursorPosition(26, 7);

                
                /*
                 If logincount is 3 or more, print out that the program will stop, and then exit the program after 3 seconds.
                 */
                if (loginCount >= 3)
                {
                    Print.Red("Du har skrivit fel lösenord för många gånger. Programmet avslutas");
                    Thread.Sleep(3000);
                    Environment.Exit(0);
                }

                /*Do while that checks the keys that the user presses and overrides that key
                 * and prints an * insted. Real password gets saved into pass variable and then checked in a switch case.
                 */

                do
                {
                    //Overrids ReadKey so the typed Char is not displayed. This will be replaced further down.
                    var keyInfo = Console.ReadKey(intercept: true);
                    key = keyInfo.Key;
                    //Check if backspace is pressed and string is longer than 1 char.
                    if (key == ConsoleKey.Backspace && pass.Length > 0)
                    {
                        //Does 2 backspace and replaces the earlier saved password with everything in password until second last index
                        Console.Write("\b \b");
                        pass = pass[0..^1];
                    }

                    //If not a controlbutton is pressed, print out * and save the keypress in pass variable
                    else if (!char.IsControl(keyInfo.KeyChar))
                    {
                        Console.Write("*");
                        pass += keyInfo.KeyChar;
                    }
                } while (key != ConsoleKey.Enter);

                // Check if password matches a switch case
                switch (pass.ToLower())
                {
                    case "norrlänningarna":
                    case "1":
                        loggedIn = true;

                        break;
                    case "q":
                        Environment.Exit(0);
                        break;
                    default:
                        error = "Fel lösenord, försök igen";
                        loginCount++;
                        break;
                }
            } while (!loggedIn);

            //Return true when the login is successful
            return true;
        }
    }
}
