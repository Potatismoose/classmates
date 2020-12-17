using classmates.ObjectClasses;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;


namespace classmates.StaticClasses
{
    static class FileHandling
    {
        static string pathway = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Classmates\\";
        static string file = "Serialized_data.save";
        static string logo = "logo.txt";
        static string removeLogo = "removelogo.txt";
        static string editLogo = "editlogo.txt";
        static string detailLogo = "detaillogo.txt";
        static string infoLogo = "infologo.txt";
        static string pathwayFull = string.Concat(pathway, file);

        static string pathwayToMainLogo = string.Concat(pathway, logo);
        static string pathwayToRemoveLogo = string.Concat(pathway, removeLogo);
        static string pathwayToEditLogo = string.Concat(pathway, editLogo);
        static string pathwayToDetailsLogo = string.Concat(pathway, detailLogo);
        static string pathwayToInfoLogo = string.Concat(pathway, infoLogo);


        /*----------------------------------------------------------------------
                     CHECK EXISTANCE OF FILES AND FOLDERS AT STARTUP
         ----------------------------------------------------------------------
        
         Method that checks the existance of a folder and file, and if it does not exist, it creates it.
         The file is used the first time this program runs on a computer. The purpose is to have some data
         for populating the classmates list with objects.
         */
        public static bool StartCheckExistance()
        {


            if (Directory.Exists(pathway))
            {
                if (File.Exists(pathwayFull))
                    return true;
                else
                {
                    var saveFile = File.Create(pathwayFull);
                    saveFile.Close();
                }
            }
            else
            {
                Directory.CreateDirectory(pathway);
            }

            return false;
        }
        public static int CheckFileFolderExistance()
        {


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


            return errorCounter;
        }
        /*----------------------------------------------------------------------
         [END OF]            CHECK EXISTANCE OF FILES AND FOLDERS AT STARTUP
         ----------------------------------------------------------------------*/







        /*----------------------------------------------------------------------
                          SAVE AND READ CLASSLIST TO/FROM FILE
         ----------------------------------------------------------------------*/
        //Method for writing the classlist as an object(List with instances of an class) to a file
        public static void BinarySerializer(List<Classmates> list)
        {
            //Startar en filestream och skapar en BinaryFormatter som jag döper till bd
            FileStream fileStream;
            
            BinaryFormatter bf = new BinaryFormatter();
            fileStream = File.Create(pathwayFull);
            bf.Serialize(fileStream, list);
            fileStream.Close();
        }

        //Method for reading the above file and restoring the previous state for the program.
        public static List<Classmates> BinaryDeSerializer(List<Classmates> myList)
        {
            myList.Clear();
            FileStream fileStream;
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(pathwayFull))
            {
                fileStream = File.OpenRead(pathwayFull);
                myList = (List<Classmates>)bf.Deserialize(fileStream);
                fileStream.Close();
            }

            return myList;
        }

        /*----------------------------------------------------------------------
         [END OF]           SAVE AND READ CLASSLIST TO/FROM FILE
         ----------------------------------------------------------------------*/






        /*----------------------------------------------------------------------
                          SAVE AND PRINT LOGOS TO/FROM FILE
         ----------------------------------------------------------------------*/

        //Writes the logos for main, edit and remove to hard drive
        public static void CreateLogos()
        {
            using FileStream main = File.Create(pathwayToMainLogo);
            main.Close();
            using FileStream remove = File.Create(pathwayToRemoveLogo);
            remove.Close();
            using FileStream edit = File.Create(pathwayToEditLogo);
            edit.Close();
            using FileStream details = File.Create(pathwayToDetailsLogo);
            details.Close();
            using FileStream info = File.Create(pathwayToInfoLogo);
            info.Close();

            string[] mainLogoSave = {
                " ,-----.,--.                                          ,--.                  ",
                "'  .--./|  | ,--,--. ,---.  ,---. ,--,--,--. ,--,--.,-'  '-. ,---.   ,---.  ",
                "|  |    |  |' ,-.  |(  .-' (  .-' |        |' ,-.  |'-.  .-'| .-. : (  .-'  ",
                @"'  '--'\|  |\ '-'  |.-' `) .-' `) |  |  |  |\ '-'  |  |  |  \   --. .-' `) ",
                " `-----'`--' `--`--'`----' `----' `--`--`--' `--`--'  `--'   `----' `----'  "
                       };
            //Prints logo til file in repros debug \Classmates\logo.txt
            using (StreamWriter file =
            new StreamWriter($"{pathwayToMainLogo}"))
            {
                //Prints every line in array to file.
                foreach (string line in mainLogoSave)
                {
                    file.WriteLine(line);
                }
            }


            string[] infoLogoSave = {
                ",--. ,--.                ,--.      ,--.         ,---.   ",
                "|  .'   / ,---. ,--.--.,-'  '-.    `--',--,--, /  .-' ,---.",
                @"|  .   ' | .-. ||  .--''-.  .-'    ,--.|      \|  `-,| .-. |",
                @"|  |\   \' '-' '|  |     |  |      |  ||  ||  ||  .-'' '-' ' ",
                "`--' '--' `---' `--'     `--'      `--'`--''--'`--'   `---'"
                       };
            //Prints logo til file in repros debug \Classmates\infologo.txt
            using (StreamWriter file =
            new StreamWriter($"{pathwayToInfoLogo}"))
            {
                //Prints every line in array to file.
                foreach (string line in infoLogoSave)
                {
                    file.WriteLine(line);
                }
            }


            string[] removeLogoSave = {
                ",--------.           ,--.                   ,--.   ",
                "'--.  .--',--,--.    |  |-.  ,---. ,--.--.,-'  '-.",
                "   |  |  ' ,-.  |    | .-. '| .-. ||  .--''-.  .-' ",
               @"   |  |  \ '-'  |    | `-' |' '-' '|  |     |  |   ",
                "   `--'   `--`--'     `---'  `---' `--'     `--'   " };
            //Prints logo til file in repros debug \Classmates\remove.txt
            using (StreamWriter file =
            new StreamWriter($"{pathwayToRemoveLogo}"))
            {
                //Prints every line in array to file.
                foreach (string line in removeLogoSave)
                {
                    file.WriteLine(line);
                }
            }

            string[] editLogoSave = {
                ",------.           ,--.,--.                              ",
                "|  .--. ' ,---.  ,-|  |`--' ,---.  ,---. ,--.--. ,--,--.",
                "|  '--'.'| .-. :' .-. |,--.| .-. || .-. :|  .--'' ,-.  |",
                @"|  |\  \ \   --.\ `-' ||  |' '-' '\   --.|  |   \ '-'  | ",
                "`--' '--' `----' `---' `--'.`-  /  `----'`--'    `--`--' ",
                "                           `---'                       "
            };
            //Prints logo til file in repros debug \Classmates\edit.txt
            using (StreamWriter file =
            new StreamWriter($"{pathwayToEditLogo}"))
            {
                //Prints every line in array to file.
                foreach (string line in editLogoSave)
                {
                    file.WriteLine(line);
                }
            }


            string[] detailsLogoSave = {
                ",------.           ,--.          ,--.  ,--.",
                @"|  .-.  \  ,---. ,-'  '-. ,--,--.|  |  `--' ,---. ,--.--. ",
                @"|  |  \ : | .-. :'-.  .-'' ,-.  ||  |  ,--.| .-. :|  .--'",
                @"|  '--' / \   --.  |  |  \ '-'  ||  |  |  |\   --.|  |",
                "`-------'  `----'  `--'   `--`--'`--'.-'  / `----'`--'",
                "                                     '---'"
            };
            //Prints logo til file in repros debug \Classmates\detaillogo.txt
            using (StreamWriter file =
            new StreamWriter($"{pathwayToDetailsLogo}"))
            {
                //Prints every line in array to file.
                foreach (string line in detailsLogoSave)
                {
                    file.WriteLine(line);
                }
            }
        }

        //Method for printing the logo
        public static void LogoPrint(string menu)
        {
            List<string> lines = new List<string>();
            Console.Clear();
            switch (menu.ToLower())
            {
                case "start":
                    lines = System.IO.File.ReadAllLines(pathwayToMainLogo).ToList();
                    break;
                case "remove":
                    lines = System.IO.File.ReadAllLines(pathwayToRemoveLogo).ToList();
                    break;
                case "edit":
                    lines = System.IO.File.ReadAllLines(pathwayToEditLogo).ToList();
                    break;
                case "details":
                    lines = System.IO.File.ReadAllLines(pathwayToDetailsLogo).ToList();
                    break;
                case "info":
                    lines = System.IO.File.ReadAllLines(pathwayToInfoLogo).ToList();
                    break;
            }

            int longest = default(int);
            foreach (string line in lines)
            {
                if (line.Length > longest)
                {
                    longest = line.Length;
                }
                Print.Yellow(line);
            }
            //Prints out a line thats as long as the longest line in the logo textfile.
            for (int i = 0; i < longest; i++)
            {
                Console.Write("_");
            }


        }

        /*----------------------------------------------------------------------
         [END OF]                 SAVE AND PRINT LOGOS TO/FROM FILE
         ----------------------------------------------------------------------*/
    }
}
