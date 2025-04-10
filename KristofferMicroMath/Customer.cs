using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KristofferMicroMath
{
    public class Customer
    {
        private static int count = 0;
       
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }

        public Customer(string name, string address, string phone, string mail)
        {
            Id = count++;
            Name = name;
            Address = address;
            Phone = phone;
            Mail = mail;
        }
    }
}
