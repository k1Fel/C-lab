using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Restaurant
{
    public class Drink : Menu
    {
        public int Litrs { get; set; }
        public Drink(string name, decimal price, int litrs) : base(name, price)
        {
            Litrs = litrs;
        }
        public override string GetInfo()
        {
            return $"Item: {Name}, {Litrs} ml, Price: {Price}₴";
        }
    }
}
