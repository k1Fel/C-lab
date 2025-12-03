using static Restaurant.Order;

namespace Restaurant
{
    internal class Program
    {
        public void Main()
        {
            Restaurant r = new Restaurant();
            r.ShowMenu();

            
            var order = r.CreateOrder(5);
            order.AddItem(r.Menu[0]); 
            order.AddItem(r.Menu[2]); 
            Console.WriteLine($"Сума: {order.GetTotalPrice()} грн");

            var order2 = r.CreateOrder(3);
            order2.AddItem(r.Menu[2]);
            order2.AddItem(r.Menu[1]);
            order2.AddItem(r.Menu[3]);
            Console.WriteLine($"Сума: {order2.GetTotalPrice()} грн");

            order.SetStatus(OrderStatus.Ready);
            order2.SetStatus(OrderStatus.Paid);

            r.ShowOrders();
            Console.WriteLine("Готово!");

        }
    }
}
