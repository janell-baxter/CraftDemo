using System;
using System.Collections.Generic;
using System.Text;

namespace CraftDemo
{
    public class Item
    {

        public string Name;
        public double Amount;
        public string AmountType = "cups";
        public double Value;

        //public string ItemDescription() => $"{Amount} {AmountType} of {Name} ({Value})";

        public string ItemDescription()
        {
            return $"{Amount} {AmountType} of {Name} ({Value.ToString("c")})";
        }

    }
}