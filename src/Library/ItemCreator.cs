using System;
using System.Collections.Generic;

namespace Library
{
    public class ItemCreator
    {
        static public Item CreateItem(string name, double attackValue, double defenseValue) // Método que crea el item en caso de ser
        // válido (que el nombre no sea nulo ni un espacio en blanco, y que el valor de ataque y el valor de defensa no sean menores a 0)
        {
            if (!string.IsNullOrWhiteSpace(name) && attackValue >= 0 && defenseValue >= 0)
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
