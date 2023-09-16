using System;
using System.Collections.Generic;

namespace Library
{
    class Item
    {
        static List<Item> Items;
        string Name;
        string[] ValidTypes;
        private double AttackValue; 
        private double DefenseValue;

        public Item(string name, string[] validTypes, double attackValue, double defenseValue)
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
