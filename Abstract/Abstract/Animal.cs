using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{

    public abstract class Animal
    {
        public abstract void MakeSound(); // Abstract method (must be implemented in derived classes)

        public void Eat()
        {
            Console.WriteLine("The animal is eating...");
        }
    }

}
