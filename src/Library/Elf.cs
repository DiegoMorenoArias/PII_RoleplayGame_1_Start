using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Library
{
    public class Elf : ICharacter
    {
        public string Name {get;}
        public double Health {get; private set;}
        public double InitialHealth {get;}
        public List<IAttackItem> AttackItems {get;}
        public List<IDefenseItem> DefenseItems {get;}

        public Elf(string name, double health)
        {
            this.Name = name;
            this.Health = health;
            this.InitialHealth = health;
            this.AttackItems = new List<IAttackItem>{};
            this.DefenseItems = new List<IDefenseItem>{};
        }

        public double GetTotalAttackValue()
        {
            double total = 0;
            foreach (IAttackItem item in this.AttackItems)
            {
                total += item.GetItemAttackValue();
            }
            return total;
        }

        public double GetTotalDefenseValue()
        {
            double total = 0;
            foreach (IDefenseItem item in this.DefenseItems)
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
        public void AttackCharacter(ICharacter character)
        {
            character.GetAttacked(this.GetTotalAttackValue(), this.Name);
        }
        public void GetHealed(string healerName)
        {
            this.Health = this.InitialHealth;
            Console.WriteLine($"{this.Name} fue curado por {healerName}, y ahora tiene {this.Health} puntos de vida.");
        }
        public void HealAlly(ICharacter character)
        {
            character.GetHealed(this.Name);
        }

        public void AddItem(string name)
        {
            if (name == "Fan")
            {
                if (Fan.ListOfTypes.Contains("elf"))
                {
                    AttackItems.Add(new Fan());
                    DefenseItems.Add(new Fan());
                }
            }
            else if (name == "Shield")
            {
                if (Shield.ListOfTypes.Contains("elf"))
                {
                    DefenseItems.Add(new Shield());
                }
            }
            else if (name == "Sword")
            {
                if (Sword.ListOfTypes.Contains("elf"))
                {
                    AttackItems.Add(new Sword());
                }
            }
            else
            {
                Console.WriteLine($"El item {name} no existe.");
            }
        }
        public void RemoveItem(string name)
        {
            foreach (IAttackItem item in AttackItems)
            {
                if (item.Name == name)
                {
                    AttackItems.Remove(item);
                } 
            }
            foreach (IDefenseItem item in DefenseItems)
            {
                if (item.Name == name)
                {
                    DefenseItems.Remove(item);
                }
            }
        }
    }
}
