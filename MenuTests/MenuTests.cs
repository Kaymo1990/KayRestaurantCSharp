using NUnit.Framework;
using Restaurant;
using System;
using System.Linq;

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

    public class OrderTests
    {
        Menu menu;
        Order order;

        [SetUp]
        public void InitRestaurant()
        {
            menu = new Menu();
            order = new Order();
        }

        [Test]
        public void OrderItem_ShouldAddItemAndQuantity_ToCurrentOrder()
        {
            order.addOrder("Burger", 1);
            var expectedOutput = "Burger";
            Assert.AreEqual(expectedOutput, order.CurrentOrder.ElementAt(order.CurrentOrder.Count - 1).Key);
        }

        [Test]
        public void OrderQuantity_ShouldAddItemAndQuantity_ToCurrentOrder()
        {
            order.addOrder("Burger", 1);
            var expectedOutput = 1;
            Assert.AreEqual(expectedOutput, order.CurrentOrder.ElementAt(order.CurrentOrder.Count - 1).Value);
        }

        [Test]
        public void ItemNotFound_ShouldThrowException_WhenPassedWrongItem()
        {
            Assert.Throws<Exception>(() => order.ItemNotFound("Missing"));
        }


    }
        public class ReceiptTests
        {
            Menu menu;
            Order order;
            Receipt receipt;

            [SetUp]
            public void InitReceipt()
            {
            menu = new Menu();
            order = new Order();
            receipt = new Receipt();
            }

            [Test]
            public void ItemSubtotal_Returns6_WhenPassed2And3()
            {
            var expectedOutput = 6;
            Assert.AreEqual(expectedOutput, receipt.ItemSubtotalCalc(2, 3));
            }
            
            [Test]
            public void PrintReceipt_ReturnsFormattedReceipt_WhenPassedOrder()
            {
            order.addOrder("Burger", 1);
            order.addOrder("Hotdog", 2);
            var expectedOutput = "Burger x 1 : £2.00\r\nHotdog x 2 : £3.00\r\nYour total is: £5.00";
            Assert.AreEqual(expectedOutput, receipt.FormatReceiptForPrinting(order));
                
            }

        [Test]
        public void ReceiptVerification_ReturnsTrue_WhenPassedReceipt()
        {
            order.addOrder("Burger", 1);
            order.addOrder("Hotdog", 2);
            receipt.FormatReceiptForPrinting(order);
            Assert.IsTrue(ReceiptVerification.CorrectValue(receipt, 5.00)); 

        } 




    }
}