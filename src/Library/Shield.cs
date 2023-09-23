using System;
using System.Collections.Generic;

namespace Library
{
    public class Shield : IDefenseItem
    {
        public string Name {get;}
        public double ItemDefenseValue {get;}
        public static List<string> ListOfTypes = new List<string>{"wizard", "elf", "dwarf"};
        public Shield()
        {
            Name = "Shield";
            ItemDefenseValue = 25;
        }

        public double GetItemDefenseValue()
        {
            return this.ItemDefenseValue;
        }
    }
}