using System;
using System.Collections.Generic;

namespace Library
{
    public class Dwarf // Clase de los objetos Enano
    {
        private string Name;
        private double Health;
        private double InitialHealth;
        List<Item> Items = new List<Item>{}; // Lista de objetos items, son todos los items que tiene el personaje

        public Dwarf(string name, double health)
        {
            this.Name = name;
            this.Health = health;
            this.InitialHealth = health; // atributo que servirá cuando uno es curado
        }

        public double GetTotalAttackValue() // Método que se encarga de calcular el valor total del ataque del personaje, esto lo hace
        // sumando el valor de ataque de cada uno de sus items.
        {
            double total = 0;
            foreach (Item item in this.Items)
            {
                total += item.GetItemAttackValue();
            }
            return total;
        }

        public double GetTotalDefenseValue() // Método que se encarga de calcular el valor total de la defensa del personaje, esto lo hace
        // sumando el valor de defensa de cada uno de sus items.
        {
            double total = 0;
            foreach (Item item in this.Items)
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

        public void AttackWizard(Wizard wizard) // Método para atacar a un mago.
        {
            wizard.GetAttacked(this.GetTotalAttackValue(), this.Name);
        }
        public void AttackDwarf(Dwarf dwarf) // Método para atacar a un enano.
        {
            dwarf.GetAttacked(this.GetTotalAttackValue(), this.Name);
        }
        public void AttackElf(Elf elf) // Método para atacar a un elfo.
        {
            elf.GetAttacked(this.GetTotalAttackValue(), this.Name);
        }
        public void GetHealed(string healerName) // Método "Ser curado" que efectúa la curación del personaje haciendo que su vida sea igual al
        // atributo InitialHealth. Además indica por quién fue curado y cuánta vida tiene ahora.
        {
            this.Health = this.InitialHealth;
            Console.WriteLine($"{this.Name} fue curado por {healerName}, y ahora tiene {this.Health} puntos de vida.");
        }
        public void HealWizardAlly(Wizard wizard) // Método para curar a un mago.
        {
            wizard.GetHealed(this.Name);
        }

        public void HealDwarfAlly(Dwarf dwarf) // Método para curar a un enano.
        {
            dwarf.GetHealed(this.Name);
        }

        public void HealElfAlly(Elf elf) // Método para curar a un elfo.
        {
            elf.GetHealed(this.Name);
        }

        public void AddItem(Item item) // Método para añadir un item a la lista de items del personaje.
        {
            this.Items.Add(item);
        }

        public void RemoveItem(Item item) // Método para remover un item de la lista de items del personaje.
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
