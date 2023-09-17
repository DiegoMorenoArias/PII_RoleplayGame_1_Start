using System;
using System.Collections.Generic;

namespace Library
{
    class SpellBook
    {
        List<Spell> Spells;

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
    }
}
