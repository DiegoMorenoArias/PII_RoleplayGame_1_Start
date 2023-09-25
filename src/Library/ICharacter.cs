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
        public void AddAttackItem(IAttackItem item);
        public void AddDefenseItem(IDefenseItem item);
        public void RemoveAttackItem(IAttackItem item);
        public void RemoveDefenseItem(IDefenseItem item);


    }
}