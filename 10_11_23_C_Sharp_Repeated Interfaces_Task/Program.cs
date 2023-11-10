﻿/*
 Задание: Система по заказу еды

Необходимо разработать простую систему для заказа еды. Система должна предоставлять следующие функции:

Создание меню:

Создайте класс FoodItem с полями Name (название блюда) и Price (цена).

Создайте интерфейс IMenu с методами AddItem (добавить блюдо в меню) и GetMenuItems (получить список всех блюд).

Создайте класс Menu и реализуйте интерфейс IMenu. Используйте подходящую коллекцию для хранения блюд.

Заказ еды:

Создайте класс Order с полем Items (список выбранных блюд) и методами AddItem (добавить блюдо в заказ) и
GetTotalPrice (получить общую стоимость заказа).

Создайте делегат OrderCompleteDelegate и событие OrderCompleteEvent, которое будет вызываться при успешном оформлении заказа.
В классе Order создайте метод PlaceOrder, который будет проверять, что заказ содержит хотя бы одно блюдо.
Если условие выполняется,вызовите событие OrderCompleteEvent и передайте общую стоимость заказа.
Тестирование системы:

Создайте класс Program с методом Main, где будет происходить тестирование системы.
В методе Main создайте экземпляр класса Menu и добавьте в него несколько блюд.
Создайте экземпляр класса Order и добавьте в него несколько блюд.
Подпишитесь на событие OrderCompleteEvent и выведите сообщение о успешном оформлении заказа с указанием общей стоимости.
Подсказки:

Используйте лямбда-выражения для удобного добавления блюд в меню и заказ.
Убедитесь, что вы правильно применяете принципы ООП и интерфейсов при проектировании системы.
 */

namespace _10_11_23_C_Sharp_Repeated_Interfaces_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Menu menu = new Menu();
            menu.AddItem(new FoodItem { Name = "Рыба", Price = 10 });

            menu.AddItem(new FoodItem { Name = "Суп", Price=20 });

            menu.AddItem(new FoodItem { Name = "Второе", Price = 50 });

            menu.AddItem(new FoodItem { Name = "Первое", Price = 60 });

            Order order = new Order();
            order.Additem(new FoodItem { Name = "Рыба", Price = 10 });
            order.Additem(new FoodItem { Name = "Рыба", Price = 10 });
            order.Additem(new FoodItem { Name = "Рыба", Price = 10 });
            order.Additem(new FoodItem { Name = "Рыба", Price = 10 });


            order.OrderCompleteEvent += (totalPrice) =>
            {
                Console.WriteLine($"Заказ был успешно оформлен. Общая стоимость: {+totalPrice}" );
            };

            order.PlaceOrder();
        }
    }
}
/*
 Эта функция в C# используется для подписки на событие OrderCompleteEvent класса Order. 

В данном случае, мы создаем анонимный метод с параметром totalPrice, который будет выполнен при возникновении события OrderCompleteEvent. 

order.OrderCompleteEvent += (totalPrice) =>
{
    Console.WriteLine("Заказ был успешно оформлен. Общая стоимость: " + totalPrice);
};


Этот анонимный метод выполняет код внутри блока {}, в данном случае, выводит сообщение о успешном оформлении заказа с указанием общей стоимости. 

После подписки на событие OrderCompleteEvent, когда событие происходит, т.е. метод PlaceOrder класса Order вызывается, 
проверяется условие наличия минимум одного блюда в заказе - если условие выполняется,
то вызывается событие OrderCompleteEvent и передается общая стоимость заказа. 

Обратите внимание на использование оператора += для подписки на событие. Это позволяет добавить метод в список обработчиков события,
если уже есть другие обработчики. 


Таким образом, когда событие возникает, все подписанные методы будут вызваны и выполнят свой код. 
В данном случае, метод подписки выводит сообщение о успешном оформлении заказа с указанием общей стоимости.
 */