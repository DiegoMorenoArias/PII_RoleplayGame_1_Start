using Library;
using System;
namespace Library.Tests
{
    [TestFixture]
    public class RoleplayTests
    {
        [Test]
        public void TestInvalidNameForCharacter()
        {
            const string expected = null;
            Wizard testWizard = CharacterCreator.CreateWizard("", 1000);
            Assert.AreEqual(expected, testWizard);
        }
    }
}