using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nexmo.Api;

namespace Restaurant
{
    class Program
    {

        static void Main(string[] args)
        {
            var menu = new Menu();
            var order = new Order();
            var receipt = new Receipt();
            var textOrder = new TextOrder();

            Console.WriteLine("Welcome to the GREATEST restaurant! \r\nThe KAY RESTAURANT!" +
                "\r\nHere are some of our options:\r\n" +
                $"{menu.ViewItemsAndPrices()}\r\n");

            var orderComplete = "N";
            while (orderComplete == "N")
            {
                Console.WriteLine("What will it be ?");
                var foodOption = Console.ReadLine().ToString();
                
                if (menu.menuPrices.Keys.Contains(foodOption))
                {
                    Console.WriteLine("Enter a quantity: ");
                    var quantity = Convert.ToInt32(Console.ReadLine());
                    order.addOrder(foodOption, quantity);
                }

                else
                {
                    Console.WriteLine("That order doesn't exist...Try again?");
                }

                Console.WriteLine("Is your order complete? (Y/N)");
                var anotherOrder = Console.ReadLine().ToString().ToUpper();
                orderComplete = anotherOrder;
            }

            Console.WriteLine("Enter your phone number for SMS receipt and estimated delivery time: ");
            var mobileNumber = Console.ReadLine().ToString();
            textOrder.MobNumber = mobileNumber;
            textOrder.SentTextOrder(receipt.StoredReceipt);
            Console.WriteLine($"Here is your order, which will also been texted to you:\r\n"
                + $"{receipt.FormatReceiptForPrinting(order)}" + "\r\nEnjoy the best food EVER!");

        }
    }
}
