using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_11_23_C_Sharp_Repeated_Interfaces_Task
{
    public class Menu : IMenu
    {
        public List<FoodItem> foodItems;

        public Menu() { foodItems = new List<FoodItem>(); }

        public void AddItem(FoodItem foodItem)
        {
            foodItems.Add(foodItem);
        }

        public List<FoodItem> GetMenuItems()
        {
            return foodItems;
        }
    }
}
