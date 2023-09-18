using System;
using System.Security.Cryptography;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard PepeElMago = CharacterCreator.CreateWizard("Pepe", 500);
            PepeElMago.AddSpellBook();
            Wizard GonzaloElFlipanteHechizeroSublimeDeLosCojones = CharacterCreator.CreateWizard("Gonzalo", 500);
            GonzaloElFlipanteHechizeroSublimeDeLosCojones.AddSpellBook();
            Dwarf EnanoDeViral = CharacterCreator.CreateDwarf("Enanito", 300);
            Elf PapaPitufo = CharacterCreator.CreateElf("Papi", 1500);
            Item Bastoncito = ItemCreator.CreateItem("Bastón", 50, 10);
            Item Espadita = ItemCreator.CreateItem("Espada", 100, 0);
            Item Escudito = ItemCreator.CreateItem ("Escudo", 5, 50);
            Spell Fueguito = Spell.CreateSpell("Fuego", 150, 0);
            Spell Aguita = Spell.CreateSpell ("Agua", 20, 50);
            Spell Tormentita = Spell.CreateSpell ("Tormenta", 75, 40);
            PepeElMago.AddItem(Bastoncito);
            GonzaloElFlipanteHechizeroSublimeDeLosCojones.AddItem(Espadita);
            PepeElMago.AddSpellToSpellBook(Fueguito);
            GonzaloElFlipanteHechizeroSublimeDeLosCojones.AddSpellToSpellBook(Aguita);
            PepeElMago.AttackWizard(GonzaloElFlipanteHechizeroSublimeDeLosCojones);
            GonzaloElFlipanteHechizeroSublimeDeLosCojones.AttackWizard(PepeElMago);
            GonzaloElFlipanteHechizeroSublimeDeLosCojones.HealWizardAlly(PepeElMago);
            PepeElMago.HealDwarfAlly(EnanoDeViral);
        }
    }
}
