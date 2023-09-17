using System;
using System.Collections.Generic;

namespace Library
{
    public class ItemCreator
    {
        public Item CreateItem(string name, double attackValue, double defenseValue)
        {
            if (!string.IsNullOrWhiteSpace(name) && !double.IsNaN(attackValue) && !double.IsNaN(defenseValue) && attackValue >= 0 && defenseValue >= 0)
            {
                return new Item(name, attackValue, defenseValue);
            }
            else
            {
                Console.WriteLine("Al menos uno de los campos no es válido. No se pudo crear el objeto.");
                return null;
            }
        }
    }
}
