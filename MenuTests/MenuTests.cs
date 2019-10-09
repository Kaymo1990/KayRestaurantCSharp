using NUnit.Framework;
using Restaurant;
using System;

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

        [Test]
        public void ViewItemAndPrices_ReturnsFormattedItemsAndPrices_WhenCalled()
        {
            var expectedOutput = "Burger: £2.00\r\nHotdog: £1.50\r\nBanana: £1.11\r\nChips: £0.99\r\n";
            Assert.AreEqual(expectedOutput, menu.ViewItemsAndPrices());
        }
    }
}