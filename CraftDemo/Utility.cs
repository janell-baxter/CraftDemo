using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.IO;

namespace CraftDemo
{
    class Utility
    {

        static public void Print(string message)
        {
            Console.WriteLine(message);

        }
    public static void Pause()
        {
            Print("Enter any key to continue...");
            ReadKey();
        }

        public static string TextFromExternalFile(string filename)
        {
            if (File.Exists(filename))
            {
                return File.ReadAllText(filename);
            }

            return "(sorry, unavailable at this time)";
        }

        public static List<Item> ItemsInstantiatedFromExternalFile(string filename)
        {
            List<Item> list = new List<Item>();
            //temporary string array to hold the words on each line of the external text file
            string[] items = File.ReadAllLines(filename);
            if(File.Exists(filename))
            {
                foreach(string s in items)
                {
                    list.Add(new Item() {
                        Name = s 
                    });
                }
            }
            return list;
        }




    }
}
