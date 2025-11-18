using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Restaurant
    {
        public List<Menu> Menu { get; set; }
        public List<Order> Orders { get; set; }

        public Restaurant()
        {
            Menu = new List<Menu>();
            Orders = new List<Order>();

            Menu.Add(new Dish("Борщ", 120, "Перше"));
            Menu.Add(new Dish("Стейк", 250, "Друге"));
            Menu.Add(new Drink("Кава", 60, 200));
            Menu.Add(new Drink("Сік", 70, 250));
        }

        public void ShowMenu()
        {
            Console.WriteLine("\n--- МЕНЮ ---");
            foreach (var item in Menu)
                Console.WriteLine(item.GetInfo());
            Console.WriteLine();
        }
        private int _nextOrderId = 1;
        public Order CreateOrder(int table)
        {
            var order = new Order(_nextOrderId++, table);
            Orders.Add(order);
            Console.WriteLine("Замовлення створено!");
            return order;
        }

        public void ShowOrders()
        {
            Console.WriteLine("\n--- УСІ ЗАМОВЛЕННЯ ---");
            foreach (var o in Orders)
                Console.WriteLine(o);
            Console.WriteLine();
        }
    }
}
