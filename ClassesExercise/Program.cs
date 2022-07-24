using System;
using System.Collections.Generic;

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

            Car yourCar = new Car("Kia", "Forte", 2015);

            Car herCar = new Car()
            {
                Make = "Toyota",
                Model = "Camry",
                Year = 2020
            };

            var carList = new List<Car>();
            carList.Add(myCar);
            carList.Add(yourCar);
            carList.Add(herCar);
            
            foreach (var car in carList)
            {
                Console.WriteLine($"{car.Make} {car.Model} {car.Year}");
            }
        }
    }
}
