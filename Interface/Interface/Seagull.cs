using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Seagull : IFlyable, ISwimmable
    {
        public void Fly()
        {
            Console.WriteLine("The seagull is flying...");
        }

        public void Swim()
        {
            Console.WriteLine("The seagull is swimming...");
        }
    }

}
