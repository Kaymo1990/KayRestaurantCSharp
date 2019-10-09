using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Order
    {

        private IDictionary<string, int> currentOrder = new Dictionary<string, int>();
        Menu menu = new Menu();
        public IDictionary<string, int> CurrentOrder { get => currentOrder; set => currentOrder = value; }

        public void addOrder(string item, int quantity)
        {
            ItemNotFound(item);

            if (CurrentOrder.ContainsKey(item))
            {
                CurrentOrder[item] += quantity;
            }
            else
            {
                CurrentOrder.Add(item, quantity);
            }
            
        }

        public void ItemNotFound(string item)
        {
            if(!menu.menuPrices.ContainsKey(item))
            {
                throw new Exception("Item not found");
            }
        }

    }
}
