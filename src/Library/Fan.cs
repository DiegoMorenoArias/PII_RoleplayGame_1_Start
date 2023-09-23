using System;
using System.Collections.Generic;

namespace Library
{
    public class Fan : IAttackItem, IDefenseItem
    {
        public string Name {get;}
        public double ItemAttackValue {get;}
        public double ItemDefenseValue {get;}
        public static List<string> ListOfTypes = new List<string>{"wizard", "elf", "dwarf"};
        public Fan()
        {
            Name = "Fan";
            ItemAttackValue = 20;
            ItemDefenseValue = 10;
        }

        public double GetItemAttackValue()
        {
            return this.ItemAttackValue;
        }

        public double GetItemDefenseValue()
        {
            return this.ItemDefenseValue;
        }
    };
}