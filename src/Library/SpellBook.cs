using System;
using System.Collections.Generic;

namespace Library
{
    public class SpellBook // Clase del Libro de Hechizos
    {
        public List<Spell> Spells = new List<Spell>{}; // Es una lista de objetos hechizos.

        public SpellBook()
        {
        }

        public double GetBookAttackValue()
        {
            double total = 0;
            foreach(Spell spell in Spells)
            {
                total += spell.GetSpellAttackValue();
            }
            return total;
        }
        public double GetBookDefenseValue()
        {
            double total = 0;
            foreach(Spell spell in Spells)
            {
                total += spell.GetSpellDefenseValue();
            }
            return total;
        }

        public void AddSpell(Spell spell)
        {
            if (!this.Spells.Contains(spell))
            {
                this.Spells.Add(spell);
            }
            else
            {
                Console.WriteLine($"El hechizo '{spell.GetSpellName()}' ya se encuentra actualmente en este libro de hechizos.");
            }
        }

        public void RemoveSpell(Spell spell)
        {
            if(this.Spells.Contains(spell))
            {
                this.Spells.Remove(spell);
            }
            else
            {
                Console.WriteLine($"No se encontró el hechizo {spell.GetSpellName()} en este libro de hechizos. Por lo que tampoco puede ser removido.");
            }
        }
    }
}
