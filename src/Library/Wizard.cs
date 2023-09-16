using System;
using System.Runtime.CompilerServices;

namespace Library
{
    class Wizard
    {
        private string Name;
        private double Health;
        Item[] Items;

        public Wizard(string name, double health)
        {
            this.Name = name;
            this.Health = health;
        }

        public double GetTotalAttackValue()
        {
            double total = 0;
            foreach (Item item in this.Items)
            {
                total += item.GetItemAttackValue();
            }
            return total;
        }

        public double GetTotalDefenseValue()
        {
            double total = 0;
            foreach (Item item in this.Items)
            {
                total += item.GetItemDefenseValue();
            }
            return total;
        }

        public void GetAttacked(double attackValue)
        {
            this.Health -= attackValue;
        }
        public void AttackWizard(Wizard wizard)
        {
            wizard.GetAttacked(this.GetTotalAttackValue());
        }
        public void AttackDwarf(Dwarf dwarf)
        {
            dwarf.GetAttacked(this.GetTotalAttackValue());
        }
        public void AttackElf(Elf elf)
        {
            elf.GetAttacked(this.GetTotalAttackValue());
        }
    }
}
