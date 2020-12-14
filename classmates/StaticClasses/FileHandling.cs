using classmates.ObjectClasses;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;


namespace classmates.StaticClasses
{
    class FileHandling
    {
        static string pathway = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Classmates\\";
        static string file = "Serialized_data.save";
        static string pathwayFull = string.Concat(pathway, file);
        
        /*
         Method that checks the existance of a folder and file, and if it does not exist, it creates it.
         The file is used the first time this program runs on a computer. The purpose is to have some data
         for populating the classmates list with objects.
         */
        
        public static bool StartCheckExistance()
        {


            if (Directory.Exists(pathway))
            {
                if (StartCheckFileExistance(pathwayFull))
                    return true;
                else
                {
                    var myFile = File.Create(pathwayFull);
                    myFile.Close();
                }
            }
            else {
                Directory.CreateDirectory(pathway);
            }
            
            return false;
        }

        public static bool StartCheckFileExistance(string fullpath)
        {
            if(File.Exists(fullpath))
                return true;
            else
                return false;

        }

        public static void BinarySerializer(List<Classmates> list)
        {
            FileStream fileStream;
            BinaryFormatter bf = new BinaryFormatter();
            fileStream = File.Create(pathwayFull);
            bf.Serialize(fileStream, list);
            fileStream.Close();
        }
    }
}
