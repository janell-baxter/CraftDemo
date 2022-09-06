using System;
using System.Collections.Generic;
using System.Text;
using static CraftDemo.Utility;

namespace CraftDemo
{
   /* Let a player modify/update their name.
   */
    public class Player
    {
        private string name = "Anonymous Player";
        public double Currency = 20;

        public string Name 
        { 
            get => name; 
            set => name = value; 
        }
        //declarative statement
        //The ice cream is pink
        //A player changes their name
        public void ChangeName()
        {
            Print("Enter your name:");
            Name = Console.ReadLine();
            Print($"Your name has been changed to {name}.");
        }
        public List<Item> Inventory = new List<Item>()
        {
            new Item()
            {
            Name = "Sugar",
            Amount = 4,
            AmountType = "cup(s)",
            Value = 2.00
            },
            new Item()
            {
            Name = "Bread",
            Amount = 9,
            AmountType = "slice(s)",
            Value = .90
            },
            new Item()
            {
            Name = "Chocolate",
            Amount = 15,
            AmountType = "bar(s)",
            Value = 18.75
            },
            new Item()
            {
            Name = "Oatmilk",
            Amount = 12,
            AmountType = "ounce(s)",
            Value = 1.99
            }
        };

        public Player(string _name)
        {
            name = _name;
        }

        public string ShowInventoryItems()
        {
            
            
            string output = "";
            foreach(Item i in Inventory)
            {
                output += i.ItemDescription() + Environment.NewLine;
            }

            return output;
        }
    }
}