using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Mammal (наследуется от Animal) - представляет млекопитающее. Дополнительно содержит свойство: FurColor (цвет шерсти).
 */
namespace _10_11_23_C_Sharp_Repeated_Interfaces_Task
{
    public class Mammal : Animal
    {
        public string FurColor { get; set; }
        public override void Eat() { }
        public override void Sleep() { }
    }
}
