using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract2
{
    public abstract class Vehicle
    {
        public abstract void Start();

        public void Stop()
        {
            Console.WriteLine("The vehicle has stopped.");
        }
    }

}
