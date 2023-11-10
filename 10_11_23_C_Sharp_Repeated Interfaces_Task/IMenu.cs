using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_11_23_C_Sharp_Repeated_Interfaces_Task
{
    public interface IMenu
    {
        public void AddItem(FoodItem foodItem);
        public List<FoodItem> GetMenuItems();
    }
}
