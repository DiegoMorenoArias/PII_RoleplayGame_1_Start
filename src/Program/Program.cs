using System;
using System.Security.Cryptography;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se creó algunos objetos para ver cómo funcionaban en consola.
            Wizard Vassallito = CharacterCreator.CreateWizard("El Mago Vassallito", 10);
            Spell Fueguito = Spell.CreateSpell("Fuego", 150, 0);
            Spell Aguita = Spell.CreateSpell ("Agua", 20, 50);
            Spell Tormentita = Spell.CreateSpell ("Tormenta", 75, 40);
            Vassallito.AddSpellBook();
            Vassallito.AddSpellToSpellBook(Fueguito);
            Vassallito.AddSpellToSpellBook(Aguita);
            Vassallito.AddSpellToSpellBook(Fueguito);
            Vassallito.AddSpellToSpellBook(Aguita);
            Vassallito.RemoveSpellFromSpellBook(Tormentita);
            Wizard PepeElMago = CharacterCreator.CreateWizard("Pepe", 500);
            PepeElMago.AddSpellBook();
            Wizard GonzaloElFlipanteHechizero = CharacterCreator.CreateWizard("Gonzalo", 500);
            GonzaloElFlipanteHechizero.AddSpellBook();
            Dwarf EnanoDeViral = CharacterCreator.CreateDwarf("Enanito", 300);
            Elf PapaPitufo = CharacterCreator.CreateElf("Papi", 1500);
            EnanoDeViral.AddItem("Shield");
            PapaPitufo.AddItem("Sword");
            PapaPitufo.AttackCharacter(EnanoDeViral);
            // Aclaración: Todas las clases, excepto Wizard que tiene sus cosas agregadas con respecto al libro de hechizos y están aclaradas
            // en su clase con comentarios respectivos, tienen los mismos métodos para atacar, curar, ser atacados y ser curados. Entonces
            // simplemente se aclaró cómo funcionan estos métodos en una sola clase la cual fue Dwarf. Véase Dwarf para más aclaración al
            // respecto 
        }
    }
}
