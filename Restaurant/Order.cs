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

        public IDictionary<string, int> CurrentOrder { get => currentOrder; set => currentOrder = value; }

        public void addOrder(string item, int quantity)
        {
            if (CurrentOrder.ContainsKey(item))
            {
                CurrentOrder[item] += quantity;
            }
            else
            {
                CurrentOrder.Add(item, quantity);
            }
            
        }

    }
}
