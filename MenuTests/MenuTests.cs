using NUnit.Framework;
using Restaurant;

namespace Tests
{
    public class MenuTests
    {
        Menu menu;
        
        [SetUp]
        public void Setup()
        {
            menu = new Menu();
        }

        [Test]
        public void Menu_HasBurger_ReturnsTrue()
        {
            var expectedOutput = "Burger";
            Assert.IsTrue(menu.menuPrices.ContainsKey(expectedOutput));
        }

        [Test]
        public void Menu_BurgerHasPrice_Returns2()
        {
            var expectedOutput = 2.00;
            Assert.AreEqual(expectedOutput, menu.menuPrices["Burger"]);
        }
    }
}