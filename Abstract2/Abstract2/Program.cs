using Abstract2;
using System;

class Program
{
    static void Main()
    {
        Vehicle car = new Car();
        Vehicle motorcycle = new Motorcycle();

        car.Start();
        motorcycle.Start();
        car.Stop();
    }
}
