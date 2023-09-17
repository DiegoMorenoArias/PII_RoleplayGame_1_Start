using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Library
{
    class Wizard
    {
        private string Name;
        private double Health;
        private double InitialHealth;
        bool HasSpellBook = false;
        SpellBook Spells = null;
        List<Item> Items;

        public Wizard(string name, double health)
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
            if(HasSpellBook)
            {
                total += Spells.GetBookAttackValue();
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
            if(HasSpellBook)
            {
                total += Spells.GetBookDefenseValue();
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

        public void AddSpellBook()
        {
            this.HasSpellBook = true;
            this.Spells = new SpellBook();
        }

        public void AddSpellToSpellBook(Spell spell)
        {
            if(this.HasSpellBook)
            {
                this.Spells.AddSpell(spell);
            }
            else
            {
                Console.WriteLine($"{this.Name} no tiene libro de hechizos, por lo que no se pudo agregar el hechizo.");
            }
        }

    }
}
