using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_11_23_C_Sharp_Repeated_Interfaces_Task
{
    public class Order
    {
        public List<FoodItem> Items;

        public delegate void OrderCompleteDelegate(decimal totalPrice);

        public event OrderCompleteDelegate OrderCompleteEvent;

        public Order() { Items = new List<FoodItem>(); }

        public void Additem(FoodItem item) { Items.Add(item); }

        public decimal GetTotalPrice()
        {
            decimal total = 0;
            foreach (var item in Items)
            {
                total += item.Price;
            }
            return total;
        }


        public void PlaceOrder()
        {
            if (Items.Count > 0)
            {
                decimal totalPrice = GetTotalPrice();
                OrderCompleteEvent?.Invoke(totalPrice);
            }
        }
    }
}
