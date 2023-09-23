using System;
using System.Collections.Generic;

namespace Library
{
    public interface IAttackItem
    {
        public string Name {get;}
        public double ItemAttackValue {get;}
        public double GetItemAttackValue();
    }
}