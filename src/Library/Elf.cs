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

        public void AddAttackItem(IAttackItem item)
        {
            AttackItems.Add(item);
        }

        public void AddDefenseItem(IDefenseItem item)
        {
            DefenseItems.Add(item);
        }

        public void RemoveAttackItem(IAttackItem item)
        {
            AttackItems.Remove(item);
        }

        public void RemoveDefenseItem(IDefenseItem item)
        {
            DefenseItems.Remove(item);
        }
    }
}
