using System;

namespace ClassesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Hyundai";
            myCar.Model = "Sonata";
            myCar.Year = 2002;

            Console.WriteLine($"Make: {myCar.Make}");
            Console.WriteLine($"Model: {myCar.Model}");
            Console.WriteLine($"Year: {myCar.Year}");
        }
    }
}
