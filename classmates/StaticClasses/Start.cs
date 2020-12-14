using classmates.ObjectClasses;
using classmates.StaticClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace classmates
{
    class Start
    {

        public static void StartProgram()
        {

            //Runs the login method
            Login.UserLogin();
            
            bool fileAndFolderExisting = default(bool);
            int errorCounter = 0;
            
            /*
             If program fails to check, create folder or file 3 times, it will exit. Else it will fall out
            of the loop after checking existance of file and folder, and, if needed, created them.
             */
            do
            {
                fileAndFolderExisting = FileHandling.StartCheckExistance();
                if (!fileAndFolderExisting)
                    errorCounter++;
                if (errorCounter >= 3)
                    Environment.Exit(0);

            } while (!fileAndFolderExisting);
            List<Classmates> myClassmates = new List<Classmates>();

            //If the program has failed to find the program folder and files /classmate folder, then populate
            // the list with standard classmates.
            if (errorCounter > 0)
            {
                Classmates.Populate(myClassmates);
                Console.WriteLine("Klassen är nu fylld med nya medlemmar");
                FileHandling.BinarySerializer(myClassmates);
                foreach (var item in myClassmates)
                {
                    Console.WriteLine(item.Name);
                }
            }

            // Else read the file
            else
            {
                Console.WriteLine("Klassen existerar och laddas från filen");
            }
            Console.ReadKey();

        }

        
    }
}
