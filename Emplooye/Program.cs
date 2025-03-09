using _3;
using System;

class Program
{
    static void Main()
    {
        Manager manager = new Manager(1, "Ahmet", 50000, "IT",5);
        Developer developer = new Developer(2, "Mustafa", 60000, "Software", "Full Stack Developer");

        Console.WriteLine($"Manager: {manager.Name},bonus: {manager.CalculateBonus()}");
        Console.WriteLine($"Developer: {developer.Name},bonus:{developer.CalculateBonus()}");


          }
}
