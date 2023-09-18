using System;
using System.IO;

namespace Library
{
    public class CharacterCreator // Esta clase se encarga de crear el objeto Wizard o el objeto Elf o el objeto Dwarf, con los
    // parámetros ingresados (nombre y cantidad de vida). En caso de que algunos de los parámetros ingresados no sean válidos (que el nombresea 
    // null o  espacios en blanco, o que la vida sea menor o igual a 0), no se crea el objeto y se imprime una indicación del error.)
    {
        public static Wizard CreateWizard(string name, double health)
        {
            if (!string.IsNullOrWhiteSpace(name) && health > 0) // Condición para validar la creación del objeto.
            {
                return new Wizard(name, health);
            }
            else
            {
                Console.WriteLine("Error, uno de los campos está incorrecto."); // Indicación del error.
                return null;
            }
        }

        public static Dwarf CreateDwarf(string name, double health)
        {
            if (!string.IsNullOrWhiteSpace(name) && health > 0)
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
            if (!string.IsNullOrWhiteSpace(name) && health > 0)
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
