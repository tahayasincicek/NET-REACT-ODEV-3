using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract2
{
    public class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("The car has started.");
        }
    }

}
