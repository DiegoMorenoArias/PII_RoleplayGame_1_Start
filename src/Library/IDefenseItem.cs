using System;
using System.Collections.Generic;

namespace Library
{
    public interface IDefenseItem
    {
        public string Name {get;}
        public double ItemDefenseValue {get;}
        public double GetItemDefenseValue();
    }
}