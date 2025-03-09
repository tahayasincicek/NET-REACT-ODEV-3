using Abstract;
using System;

class Program
{
    static void Main()
    {
        Animal cat = new Cat();
        Animal dog = new Dog();

        cat.MakeSound();
        dog.MakeSound();
        cat.Eat();
    }
}
