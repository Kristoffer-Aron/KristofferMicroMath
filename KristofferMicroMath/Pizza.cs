using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KristofferMicroMath
{
    public class Pizza
    {
        public int PizzaNr { get; set; }
        public String Name { get; set; }
        public String Size { get; set; }
        public List<string> Toppings { get; set; }


        public Pizza()
        {
        }

        public Pizza(int pizzaNr, string name, string size, List<string> toppings)
        {
            PizzaNr = pizzaNr;
            Name = name;
            Size = size;
            Toppings = toppings;
        }

        public override string ToString()
        {
            return $"{nameof(PizzaNr)}: {PizzaNr}, {nameof(Name)}: {Name}, {nameof(Size)}: {Size}, {nameof(Toppings)}: {Toppings}";
        }
    }
}


//dette er skrevet i pizza