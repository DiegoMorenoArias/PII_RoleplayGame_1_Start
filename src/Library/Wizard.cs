using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Library
{
    public class Wizard : ICharacter
    {
        public string Name {get;}
        public double Health {get; private set;}
        public double InitialHealth {get;}
        bool HasSpellBook = false; // Bool que sirve para saber si el mago tiene libro de hechizos o no, porque podría no tenerlo.
        SpellBook CharacterSpells = null; // Libro de hechizos del mago, comienza siendo null porque no necesariamente un mago tendrá uno.
        public List<IAttackItem> AttackItems {get;}
        public List<IDefenseItem> DefenseItems {get;}

        public Wizard(string name, double health)
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
            if(HasSpellBook) // Como es un mago, en caso de tener libro de hechizos, para calcular su daño total también se toma en cuenta
            // el attackValue del libro de hechizos.
            {
                total += CharacterSpells.GetBookAttackValue();
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
            if(HasSpellBook) // Como es un mago, en caso de tener libro de hechizos, para calcular la defensa total también se toma en cuenta
            // el defenseValue del libro de hechizos.
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
                if (Fan.ListOfTypes.Contains("wizard"))
                {
                    AttackItems.Add(new Fan());
                    DefenseItems.Add(new Fan());
                }
            }
            else if (name == "Shield")
            {
                if (Shield.ListOfTypes.Contains("wizard"))
                {
                    DefenseItems.Add(new Shield());
                }
            }
            else if (name == "Sword")
            {
                if (Sword.ListOfTypes.Contains("wizard"))
                {
                    AttackItems.Add(new Sword());
                }
            }
            else
            {
                Console.WriteLine($"El item {name} no existe o no es válido para este tipo de personaje.");
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

        public void AddSpellBook() // Le agrega el libro de hechizos
        {
            this.HasSpellBook = true; // Como ahora tendrá un libro de hechizos el booleano "TieneLibroDeHechizos" es true
            this.CharacterSpells = new SpellBook();
        }

        public void AddSpellToSpellBook(Spell spell) // Añade hechizos a su libro de hechizos
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
        public void RemoveSpellFromSpellBook(Spell spell) // Remueve hechizos de su libro de hechizos
        {
            this.CharacterSpells.RemoveSpell(spell);
        }
    }
}
