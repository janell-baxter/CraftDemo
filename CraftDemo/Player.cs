using System;
using System.Collections.Generic;
using System.Text;

namespace CraftDemo
{
    public class Player
    {
        private string name = "Anonymous Player";

        public string Name 
        { 
            get => name; 
            set => name = value; 
        }

        public List<Item> Inventory= new List<Item>();

        public Player(string _name)
        {
            name = _name;
        }
    }
}