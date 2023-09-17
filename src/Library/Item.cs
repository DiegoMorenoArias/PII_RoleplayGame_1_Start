using System;
using System.Collections.Generic;

namespace Library
{
    public class Item
    {
        public static List<Item> Items = new List<Item>{};
        public string Name;
        //List<string> ValidTypes; usaríamos esto para validar los tipos de character que pueden tener el objeto, pero como el único objeto de este tipo es el spellbook no lo usamos uwu
        private double AttackValue; 
        private double DefenseValue;

        public Item(string name, double attackValue, double defenseValue)
        {
            this.Name = name;
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
