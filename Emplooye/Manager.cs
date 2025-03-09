using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Manager:Emplooye
    {
        public int TeamSize;
        public Manager(int id, string name, double salary, string department, int teamSize)
        : base(id, name, salary, department) 
        {
            TeamSize = teamSize;
        }

        public override double CalculateBonus()
        {
            return Salary * 0.2;
        }
    }
}
