using System;
using System.Collections.Generic;
using System.Text;
using static CraftDemo.Utility;

namespace CraftDemo
{
    public class Game
    {
        Player player = new Player("Anonymous Person");

        public void Start()
        { float amount = 12.45678687687f;
            Console.Title = "My awesome app!";
            //concatenation
            Print("Welcome to my Craft app " + player.Name + "!");
            //composite formatting
            Console.WriteLine("Welcome to my Craft app {0}!", player.Name);
            //Interpolation 
            Print($"Welcome to my Craft app {player.Name}!");
            Print($"{amount}");
            Print($"{amount.ToString("c")}");

            player.Inventory.Add(
                new Item() {
                    Name = "Map", 
                    Description = "A unique old map that looks important." 
                }
                );

            Console.ReadKey();
        }
    }
}