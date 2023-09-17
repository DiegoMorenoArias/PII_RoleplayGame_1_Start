using System;
using System.Collections.Generic;

namespace Library
{
    class SpellBook
    {
        public List<Spell> Spells;

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
            this.Spells.Add(spell);
        }

        public void RemoveSpell(Spell spell)
        {
            if(this.Spells.Contains(spell))
            {
                this.Spells.Remove(spell);
            }
            else
            {
                Console.WriteLine("No se encontró este hechizo en el libro.");
            }
        }
    }
}
