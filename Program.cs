using System;
using System.Collections.Generic;

namespace ClassExercisePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();
            {
                myCar.Make = "Honda";
                myCar.Model = "Prelude";
                myCar.Year = 1998;
            }

            var myCar2 = new Car();
            {
                myCar2.Make = "Toyota";
                myCar2.Model = "Camry";
                myCar2.Year = 2002;

            }
            var myCar3 = new Car();
            {
                myCar3.Make = "Audi";
                myCar3.Model = "5000";
                myCar3.Year = 1984;
            }

            var carList = new List<Car>() { myCar, myCar2, myCar3 };

            foreach (var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make}  {vehicle.Model}  {vehicle.Year}");
            }
            




        }
    }
}
