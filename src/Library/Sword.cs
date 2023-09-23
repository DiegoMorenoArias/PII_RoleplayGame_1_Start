using System;
using System.Collections.Generic;

namespace Library
{
    public class Sword : IAttackItem
    {
        public string Name {get;}
        public double ItemAttackValue {get;}
        public static List<string> ListOfTypes = new List<string>{"wizard", "elf", "dwarf"};
        public Sword()
        {
            Name = "Sword";
            ItemAttackValue = 25;
        }

        public double GetItemAttackValue()
        {
            return this.ItemAttackValue;
        }
    }
}