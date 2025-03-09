using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Emplooye
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }

        public Emplooye(int id,string name,double salary,string department){
            ID = id;
            Name = name;
            Salary = salary;
            Department = department;
        }

        public virtual double CalculateBonus()
        {
            return 0; // Varsayılan olarak prim yok
        }
    }
}


