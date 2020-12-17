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
            Console.Title = "My Classmates";
            if (FileHandling.CheckFileFolderExistance() > 0)
            {
                Classmates.Populate(myClassmates);

                //Method for saving mockdata and user changes to a file.
                FileHandling.BinarySerializer(myClassmates);

            }

            // Else read the file
            else
            {
                myClassmates = FileHandling.BinaryDeSerializer(myClassmates);
            }
            Console.SetWindowSize(100, 40);
            FileHandling.CreateLogos();

            //Runs the login method
            Login.UserLogin();
            //If the program had to add any files, then populate that file with the standard classmates

            Menus.StartMenu(myClassmates);
        }


    }
}
