using System;
using System.Collections.Generic;

namespace Library
{
    public class Dwarf : ICharacter // Clase de los objetos Enano
    {
        public string Name {get;}
        public double Health {get; private set;}
        public double InitialHealth {get;}
        public List<IAttackItem> AttackItems {get;}
        public List<IDefenseItem> DefenseItems {get;} // Lista de objetos items, son todos los items que tiene el personaje

        public Dwarf(string name, double health)
        {
            this.Name = name;
            this.Health = health;
            this.InitialHealth = health; // atributo que servirá cuando uno es curado
            this.AttackItems = new List<IAttackItem>{};
            this.DefenseItems = new List<IDefenseItem>{};
        }

        public double GetTotalAttackValue() // Método que se encarga de calcular el valor total del ataque del personaje, esto lo hace
        // sumando el valor de ataque de cada uno de sus items.
        {
            double total = 0;
            foreach (IAttackItem item in this.AttackItems)
            {
                total += item.GetItemAttackValue();
            }
            return total;
        }

        public double GetTotalDefenseValue() // Método que se encarga de calcular el valor total de la defensa del personaje, esto lo hace
        // sumando el valor de defensa de cada uno de sus items.
        {
            double total = 0;
            foreach (IDefenseItem item in this.DefenseItems)
            {
                total += item.GetItemDefenseValue();
            }
            return total;
        }

        public void GetAttacked(double attackValue, string name) // Método "Ser atacado" que efectúa el daño provocado por otro personaje, indicando
        // además quién lo atacó y cuánto daño le hizo.
        {
            this.Health -= attackValue*(100/(100+this.GetTotalDefenseValue())); // Se utilizó la fórmula de mitigación de daño del League of Legends.
            Console.WriteLine($"{name} atacó a {this.Name} por {attackValue*(100/(100+this.GetTotalDefenseValue()))}. \n {this.Name} ahora tiene {this.Health} puntos de vida. \n");
        }

        public void AttackCharacter(ICharacter character) // Método para atacar a un mago.
        {
            character.GetAttacked(this.GetTotalAttackValue(), this.Name);
        }
        public void GetHealed(string healerName) // Método "Ser curado" que efectúa la curación del personaje haciendo que su vida sea igual al
        // atributo InitialHealth. Además indica por quién fue curado y cuánta vida tiene ahora.
        {
            this.Health = this.InitialHealth;
            Console.WriteLine($"{this.Name} fue curado por {healerName}, y ahora tiene {this.Health} puntos de vida.");
        }
        public void HealAlly(ICharacter character) // Método para curar a un mago.
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
