using Library;
using System;
namespace Library.Tests
{
    [TestFixture]
    // Los 12 test son funcionales y superados.
    public class RoleplayTests
    {
        [Test]
        public void TestInvalidNameForWizard()
        {
            const Wizard expected = null;
            Wizard testWizard = CharacterCreator.CreateWizard("", 1000);
            Assert.That(testWizard, Is.EqualTo(expected));
        }
        [Test]
        public void TestInvalidNameForDwarf()
        {
            const Dwarf expected = null;
            Dwarf testDwarf = CharacterCreator.CreateDwarf("      ", 1000);
            Assert.That(testDwarf, Is.EqualTo(expected));
        }
        [Test]
        public void TestInvalidNameForElf()
        {
            const Elf expected = null;
            Elf testElf = CharacterCreator.CreateElf(null, 1000);
            Assert.That(testElf, Is.EqualTo(expected));
        }
        [Test]
        public void TestInvalidHealthForWizard()
        {
            const Wizard expected = null;
            Wizard testWizard = CharacterCreator.CreateWizard("Maguito", 0);
            Assert.That(testWizard, Is.EqualTo(expected));
        }
        [Test]
        public void TestInvalidHealthForDwarf()
        {
            const Dwarf expected = null;
            Dwarf testDwarf = CharacterCreator.CreateDwarf("Enanito", -500);
            Assert.That(testDwarf, Is.EqualTo(expected));
        }
        [Test]
        public void TestInvalidHealthForElf()
        {
            const Elf expected = null;
            Elf testElf = CharacterCreator.CreateElf("Elfito", -2);
            Assert.That(testElf, Is.EqualTo(expected));
        }
        [Test]
        public void TestInvalidNameForItem()
        {
            const Item expected = null;
            Item testItem = ItemCreator.CreateItem("     ", 400, 200);
            Assert.That(testItem, Is.EqualTo(expected));
        }
        [Test]
        public void TestInvalidAttackValueForItem()
        {
            const Item expected = null;
            Item testItem = ItemCreator.CreateItem("Bastoncito", -300, 250);
            Assert.That(testItem, Is.EqualTo(expected));
        }
        [Test]
        public void TestInvalidDefenseValueForItem()
        {
            const Item expected = null;
            Item testItem = ItemCreator.CreateItem("Espadita", 600, -50);
            Assert.That(testItem, Is.EqualTo(expected));
        }
                [Test]
        public void TestInvalidNameForSpell()
        {
            const Spell expected = null;
            Spell testSpell = Spell.CreateSpell(null , 400, 200);
            Assert.That(testSpell, Is.EqualTo(expected));
        }
        [Test]
        public void TestInvalidAttackValueForSpell()
        {
            const Spell expected = null;
            Spell testSpell = Spell.CreateSpell("Agüita", -300, 250);
            Assert.That(testSpell, Is.EqualTo(expected));
        }
        [Test]
        public void TestInvalidDefenseValueForSpell()
        {
            const Spell expected = null;
            Spell testSpell = Spell.CreateSpell("Aurora Boreal", 600, -50);
            Assert.That(testSpell, Is.EqualTo(expected));
        }
    }
}