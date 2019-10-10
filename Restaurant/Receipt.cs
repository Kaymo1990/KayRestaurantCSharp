using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Receipt
    {
        private string storedReceipt = "";
        private Menu menu;
        public Receipt()
        {
            menu = new Menu();
        }
        
        public double receiptTotal = 0;

        public string StoredReceipt { get => storedReceipt; set => storedReceipt = value; }

        public string FormatReceiptForPrinting(Order order)
        {
            string finalReceipt = "*~Your Kay Restaurant Order~*\r\n";
            double finalTotal = 0;

            foreach (var singleOrder in order.CurrentOrder)
            {
                var itemSubtotal = ItemSubtotalCalc(menu.menuPrices[singleOrder.Key], singleOrder.Value);
                finalReceipt += $"{ singleOrder.Key } x {singleOrder.Value} : £{ itemSubtotal.ToString("F2") }" + Environment.NewLine;
                finalTotal += itemSubtotal;
            }
            receiptTotal = finalTotal;
            finalReceipt += $"Your total is: £{finalTotal.ToString("F2")}";
            StoredReceipt = finalReceipt;
            return finalReceipt;
        }

        public double ItemSubtotalCalc(double price, int quantity)
        {
            return (quantity * price);
        }

    }
}
