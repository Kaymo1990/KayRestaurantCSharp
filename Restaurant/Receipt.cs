using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Receipt
    {
        Menu menu = new Menu();
        public double receiptTotal = 0;

        public string FormatReceiptForPrinting(Order order)
        {
            string finalReceipt = "";
            double finalTotal = 0;

            foreach (var singleOrder in order.CurrentOrder)
            {
                var itemSubtotal = ItemSubtotalCalc(menu.menuPrices[singleOrder.Key], singleOrder.Value);
                finalReceipt += $"{ singleOrder.Key } x {singleOrder.Value} : £{ itemSubtotal.ToString("F2") }" + Environment.NewLine;
                finalTotal += itemSubtotal;
            }
            receiptTotal = finalTotal;
            finalReceipt += $"Your total is: £{finalTotal.ToString("F2")}";
            return finalReceipt;
        }

        public double ItemSubtotalCalc(double price, int quantity)
        {
            return (quantity * price);
        }

    }
}
