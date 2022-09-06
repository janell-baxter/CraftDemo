using System;
using System.Collections.Generic;
using System.Text;
using static CraftDemo.Utility;
using static System.Console;

namespace CraftDemo
{
    public class Game
    {
        Player player = new Player("Anonymous Person");

        public void Start()
        { 
            Title = "Welcome to Craft-O-Rama!";
            Print($"Welcome {player.Name}!");
            Pause();
            Menu();
        }

        private void Menu()
        {
            Clear();
            Print($"Player: {player.Name}, Currency: {player.Currency.ToString("c")}");
            string[] options = {"Change Name", "See Inventory" };
           
            Print("Please choose an option:");
            for (int i=0; i<options.Length;i++)
            {
                Print($"{i+1}) {options[i]}");
            }
            string input = ReadLine();

            switch(input)
            {
                case "1":
                    player.ChangeName();
                    Pause();
                    break;
                case "2":
                    Console.Clear();
                    Print($"Current inventory of {player.Name}: \n");
                    Print(player.ShowInventoryItems());
                    Pause();
                    break;
                default:
                    Print("Please enter only one of the options listed.");
                    Pause();
                    
                    break;
            }
            Menu();
        }
    }
}