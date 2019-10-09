using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Menu
    {
        public IDictionary<string, double> menuPrices = new Dictionary<string, double>()
        {
            { "Burger", 2.00 },
            { "Hotdog", 1.50 },
            { "Banana", 1.11 },
            { "Chips", 0.99 }
        };

        public string ViewItemsAndPrices()
        {
            var fullMenu = "";
            foreach(var item in menuPrices)
            {
                fullMenu += $"{item.Key}: £{item.Value.ToString("F2")}" + Environment.NewLine;
            }

            return fullMenu;
        }
    }
}
