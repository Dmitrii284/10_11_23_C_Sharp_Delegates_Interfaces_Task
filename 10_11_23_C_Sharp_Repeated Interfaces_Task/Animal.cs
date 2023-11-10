using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Animal (абстрактный класс) - представляет животное в зоопарке. Содержит свойства: Name (имя), Age (возраст) и методы:
Eat() (покормить), Sleep() (поспать).
 */
namespace _10_11_23_C_Sharp_Repeated_Interfaces_Task
{
    public abstract class Animal
    {
        public string Name { get; set; }    
        public int Age { get; set; }

        public abstract void Eat();
        public abstract void Sleep();


    }
}
