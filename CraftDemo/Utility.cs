using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

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
    }
}
