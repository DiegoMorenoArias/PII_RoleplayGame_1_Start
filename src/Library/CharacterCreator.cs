using System;
using System.IO;

namespace Library
{
    class CharacterCreator
    {
        public static Wizard CreateWizard(string name, double health)
        {
            if (!string.IsNullOrWhiteSpace(name) && !double.IsNaN(health) && health > 0)
            {
                return new Wizard(name, health);
            }
            else
            {
                Console.WriteLine("Error, uno de los campos está incorrecto.");
                return null;
            }
        }

        public static Dwarf CreateDwarf(string name, double health)
        {
            if (!string.IsNullOrWhiteSpace(name) && !double.IsNaN(health) && health > 0)
            {
                return new Dwarf(name, health);
            }
            else
            {
                Console.WriteLine("Error, uno de los campos está incorrecto.");
                return null;
            }
        }

        public static Elf CreateElf(string name, double health)
        {
            if (!string.IsNullOrWhiteSpace(name) && !double.IsNaN(health) && health > 0)
            {
                return new Elf(name, health);
            }
            else
            {
                Console.WriteLine("Error, uno de los campos está incorrecto.");
                return null;
            }
        }
    }
}
