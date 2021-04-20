using System;
using System.Collections.Generic;

namespace ClassExercisePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var myNewCar1 = new Car();

            myNewCar1.Make = "Honda";
            myNewCar1.Model = "Accord";
            myNewCar1.Year = 1994;


            var myNewCar2 = new Car();

            myNewCar2.Make = "Toyota";
            myNewCar2.Model = "Camry";
            myNewCar2.Year = 2012;

            var myCar = new Car();

            myCar.Make = "MG";
            myCar.Model = "Rover";
            myCar.Year = 2012;

            var carList = new List<Car>() { myNewCar1, myNewCar2, myCar };
            foreach (var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");
            }


        }
    }
}
