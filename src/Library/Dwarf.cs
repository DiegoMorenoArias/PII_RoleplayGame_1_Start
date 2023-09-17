using System;
using System.Collections.Generic;

namespace Library
{
    public class Dwarf
    {
        private string Name;
        private double Health;
        private double InitialHealth;
        List<Item> Items = new List<Item>{};

        public Dwarf(string name, double health)
        {
            this.Name = name;
            this.Health = health;
            this.InitialHealth = health;
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

        public void GetAttacked(double attackValue, string name)
        {
            this.Health -= attackValue*(100/(100+this.GetTotalDefenseValue())); // usamos la formula de armadura del LoL :)
            Console.WriteLine($"{name} atacó a {this.Name} por {attackValue*(100/(100+this.GetTotalDefenseValue()))}. \n {this.Name} ahora tiene {this.Health} puntos de vida. \n");
        }

        public void AttackWizard(Wizard wizard)
        {
            wizard.GetAttacked(this.GetTotalAttackValue(), this.Name);
        }
        public void AttackDwarf(Dwarf dwarf)
        {
            dwarf.GetAttacked(this.GetTotalAttackValue(), this.Name);
        }
        public void AttackElf(Elf elf)
        {
            elf.GetAttacked(this.GetTotalAttackValue(), this.Name);
        }
        public void GetHealed()
        {
            this.Health = this.InitialHealth;
            Console.WriteLine($"{this.Name} fue curado, y ahora tiene {this.Health} puntos de vida.");
        }
        public void HealWizardAlly(Wizard wizard)
        {
            wizard.GetHealed();
        }

        public void HealDwarfAlly(Dwarf dwarf)
        {
            dwarf.GetHealed();
        }

        public void HealElfAlly(Elf elf)
        {
            elf.GetHealed();
        }

        public void AddItem(Item item)
        {
            this.Items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            if(this.Items.Contains(item))
            {
                this.Items.Remove(item);
            }
            else
            {
                Console.WriteLine($"{this.Name} no tiene {item.Name}.");
            }
        }
    }
}
