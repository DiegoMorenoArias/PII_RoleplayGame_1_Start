using System;

namespace Library
{
    class Spell
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

        public Spell CreateSpell(string name, double attackValue, double defenseValue)
        {
            if (!string.IsNullOrWhiteSpace(name) && !double.IsNaN(attackValue) && !double.IsNaN(defenseValue) && attackValue >= 0 && defenseValue >= 0)
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
    }
}
