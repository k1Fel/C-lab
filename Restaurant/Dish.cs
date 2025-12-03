using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Dish : Menu
    {
        public string Category { get; set; }
        public Dish(string name, decimal price, string category) : base(name, price)
        {
            Category = category;
        }
        public override string GetInfo()
        {
            return $"Item: {Name}, Category: {Category}, Price: {Price}₴";
        }
    }
}
