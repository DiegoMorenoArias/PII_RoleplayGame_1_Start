using System;
using System.Collections.Generic;

namespace Library
{
    class Item
    {
        public static List<Item> Items;
        public string Name;
        List<string> ValidTypes;
        private double AttackValue; 
        private double DefenseValue;

        public Item(string name, List<string> validTypes, double attackValue, double defenseValue)
        {
            this.Name = name;
            this.ValidTypes = validTypes;
            this.AttackValue = attackValue;
            this.DefenseValue = defenseValue;
            Items.Add(this);
        }

        public double GetItemAttackValue()
        {
            return this.AttackValue;
        }

        public double GetItemDefenseValue()
        {
            return this.DefenseValue;
        }
    }
}
