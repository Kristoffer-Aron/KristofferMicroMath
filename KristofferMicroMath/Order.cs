using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KristofferMicroMath
{
    public class Order
    {
        public string Pizza { get; set; }
        public int Price { get; set; }
        public Order(string pizza, int price) 
        {
            Pizza = pizza;
            Price = price;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
