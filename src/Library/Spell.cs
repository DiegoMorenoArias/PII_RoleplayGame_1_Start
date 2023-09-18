using System;

namespace Library
{
    public class Spell // Clase de los objetos Hechizos.
    {
        string Name;
        double AttackValue;
        double DefenseValue;

        private Spell(string name, double attackValue, double defenseValue)
        {
            this.Name = name;
            this.AttackValue = attackValue;
            this.DefenseValue = defenseValue;
        }

        static public Spell CreateSpell(string name, double attackValue, double defenseValue) // Método que crea el hechizo en caso de ser
        // válido (que el nombre no sea nulo ni un espacio en blanco, y que el valor de ataque y el valor de defensa no sean menores a 0)
        {
            if (!string.IsNullOrWhiteSpace(name) && attackValue >= 0 && defenseValue >= 0)
            {
                return new Spell(name, attackValue, defenseValue);
            }
            else
            {
                Console.WriteLine("Al menos uno de los campos no es válido. No se pudo crear el hechizo.");
                return null;
            }
        }

        public double GetSpellAttackValue()
        {
            return this.AttackValue;
        }
        public double GetSpellDefenseValue()
        {
            return this.DefenseValue;
        }
        public string GetSpellName()
        {
            return this.Name;
        }
    }
}
