using System;

namespace Classes.Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();
            myCar.Make = "Ford";
            myCar.Model = "Explorer";
            myCar.Year = 2022;
            Console.WriteLine($"my car is a {myCar.Make} {myCar.Model} , its a {myCar.Year}");
        }

        
    }
}
