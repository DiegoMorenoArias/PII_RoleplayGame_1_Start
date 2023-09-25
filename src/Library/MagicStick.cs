using System;
using System.Collections.Generic;

namespace Library
{
    public class MagicStick : IDefenseItem
    {
        public string Name {get;}
        public double ItemDefenseValue {get;}
        public static List<string> ListOfTypes = new List<string>{"wizard", "elf"};
        public MagicStick()
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