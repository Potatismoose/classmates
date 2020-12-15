using classmates.ObjectClasses;
using classmates.StaticClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;


namespace classmates
{
    static class Start
    {
        private static List<Classmates> myClassmates = new List<Classmates>();
        
        public static void StartProgram()
        {
            if (FileHandling.CheckFileFolderExistance() > 0)
            {
                Classmates.Populate(myClassmates);
                Console.WriteLine("Klassen är nu fylld med nya medlemmar");
                //Metod för att spara ner klasskamraterna till en fil
                FileHandling.BinarySerializer(myClassmates);
                foreach (var item in myClassmates)
                {
                    Console.WriteLine(item.Name);
                }
            }

            // Else read the file
            else
            {
                myClassmates = FileHandling.BinaryDeSerializer(myClassmates);
            }
            Console.SetWindowSize(100,40);
            FileHandling.CreateLogos();
            
            //Runs the login method
            Login.UserLogin();
            //If the program had to add any files, then populate that file with the standard classmates
            
            Menus.StartMenu();
        }

        
    }
}
