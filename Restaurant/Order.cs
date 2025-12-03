using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public enum OrderStatus
    {
        New,
        InProgress,
        Ready,
        Paid
    }
    public class Order
    {
       
        public int Id { get; }
        public int Table { get; set; }
        public List<Menu> Items { get; set; }
        public OrderStatus Status { get; private set; }

        public Order(int id, int table)
        {
            Id = id;
            Table = table;
            Items = new List<Menu>();
            Status = OrderStatus.New;

        }
        public void AddItem(Menu item)
        {
            Items.Add(item);
        }
        public void RemoveItem(Menu item)
        {
            Items.Remove(item);
        }
        public decimal GetTotalPrice()
        {
            return Items.Sum(item => item.Price);
        }
        public void SetStatus(OrderStatus newStatus)
        {
            Status = newStatus;
        }
        public string Output()
        {
            return $"ID: {Id} | Стіл: {Table} | Статус: {Status} | Сума: {GetTotalPrice()} грн";
        }

    }
}
