using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Library
{
    public class Wizard
    {
        private string Name;
        private double Health;
        private double InitialHealth;
        bool HasSpellBook = false;
        SpellBook CharacterSpells = null;
        List<Item> Items = new List<Item>{};

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
                total += CharacterSpells.GetBookAttackValue();
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
                total += CharacterSpells.GetBookDefenseValue();
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

        public void GetHealed(string healerName)
        {
            this.Health = this.InitialHealth;
            Console.WriteLine($"{this.Name} fue curado por {healerName}, y ahora tiene {this.Health} puntos de vida.");
        }

        public void HealWizardAlly(Wizard wizard)
        {
            wizard.GetHealed(this.Name);
        }

        public void HealDwarfAlly(Dwarf dwarf)
        {
            dwarf.GetHealed(this.Name);
        }

        public void HealElfAlly(Elf elf)
        {
            elf.GetHealed(this.Name);
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
            this.CharacterSpells = new SpellBook();
        }

        public void AddSpellToSpellBook(Spell spell)
        {
            if(this.HasSpellBook)
            {
                this.CharacterSpells.AddSpell(spell);
            }
            else
            {
                Console.WriteLine($"{this.Name} no tiene libro de hechizos, por lo que no se pudo agregar el hechizo.");
            }
        }
        public void RemoveSpellFromSpellBook(Spell spell)
        {
            if(this.CharacterSpells.Spells.Contains(spell))
            {
                this.CharacterSpells.RemoveSpell(spell);
            }
            else
            {
                Console.WriteLine($"{this.Name} no tiene el hechizo en su libro.");
            }
        }
    }
}
