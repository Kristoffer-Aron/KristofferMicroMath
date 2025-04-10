using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KristofferMicroMath
{
    public class Staff
    {
        private double salary = 0.0;
        private string name="";
        private int id=0;
        private string type = "";
        private bool admin=false;
        static int idSet=0;

        public double Salary { get => salary; set => salary=value; }
        public Staff() { }
        public Staff(double sa,string type, bool admin) 
        {
            idSet++;
            id = idSet;
            salary = sa;
            this.type = type;
        }


    }
}
