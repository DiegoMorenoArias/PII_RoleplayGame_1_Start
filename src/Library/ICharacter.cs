using System;
using System.Collections.Generic;

namespace Library
{
    public interface ICharacter
    {
        string Name {get;}
        double Health {get;}
        double InitialHealth {get;}
        List<IAttackItem> AttackItems {get;}
        List<IDefenseItem> DefenseItems {get;}
        
        public double GetTotalAttackValue();
        public double GetTotalDefenseValue();
        public void GetAttacked(double attackValue, string name);
        public void AttackCharacter(ICharacter character);
        public void GetHealed(string healerName);
        public void HealAlly(ICharacter character);
        public void AddItem(string name);
        public void RemoveItem(string name);


    }
}