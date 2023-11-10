﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Задание: "Управление виртуальным зоопарком"

Ваша задача состоит в создании программы для управления виртуальным зоопарком. Зоопарк содержит различные виды животных,
и у них есть определенные характеристики и возможности.

Основные классы:

Зоопарк - содержит лист животных наследуемых от класса Animal 
Animal (абстрактный класс) - представляет животное в зоопарке. Содержит свойства: Name (имя), Age (возраст) и методы:
Eat() (покормить), Sleep() (поспать).
Mammal (наследуется от Animal) - представляет млекопитающее. Дополнительно содержит свойство: FurColor (цвет шерсти).
Bird (наследуется от Animal) - представляет птицу. Дополнительно содержит методы: Fly() (лететь) и BuildNest() (строить гнездо).
Интерфейсы:

ISwim - содержит метод Swim() (плыть).
IWalk - содержит метод Walk() (ходить).
Делегаты и события:

Action<T> - делегат, используемый для определения методов без возвращаемого значения и с параметром (T).
EventHandler<T> - делегат, используемый для определения методов обработки событий.
AnimalAdded - событие, возникающее при добавлении нового животного в зоопарк.
Обработчик события должен выводить информацию о добавленном животном.
Основной функционал программы:

Создание объектов классов Mammal и Bird с различными характеристиками.
Реализация интерфейсов ISwim и IWalk в нужных классах.
Использование методов, свойств и событий для взаимодействия с животными.
Обработка события AnimalAdded для вывода информации о добавленных животных в зоопарк.
 */
namespace _10_11_23_C_Sharp_Repeated_Interfaces_Task
{
    public class Zoo
    {
    }
}
