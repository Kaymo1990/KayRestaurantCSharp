using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class ReceiptVerification
    {
        public static bool CorrectValue(Receipt receipt, double assumedAmount)
        {
            if(receipt.receiptTotal.ToString("F2") == assumedAmount.ToString("F2"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
