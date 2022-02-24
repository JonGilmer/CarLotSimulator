using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            //Building on our car lot simulator project, create a CarLot class with a static field called numberOfCars.
            //Have this number only increment when in our program we create a new Car.
            //From there create 3 cars in the Main() and then each time you create a car,
            //do a Console.WriteLine() printing the current number of cars in the car lot. 

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            CarLot carLotList_Variable = new CarLot();


            // Dot Notation:
            Car car1 = new Car();
            car1.Year = 1994;
            car1.Make = "McLaren";
            car1.Model = "F1";
            car1.EngineNoise = "Vroom VROOM [low rumble]";
            car1.HonkNoise = "Honk";
            car1.IsDriveable = true;

            carLotList_Variable.CarLot_ListProperty.Add(car1);

            car1.PrintCarName(car1.Make, car1.Model);
            car1.MakeEngineNoise(car1.EngineNoise);
            car1.MakeHonkNoise(car1.HonkNoise);

            Console.WriteLine($"Number of cars in car lot: {CarLot._numberOfCars}");


            // Object Initializer Syntax:
            var car2 = new Car()
            {
                Year = 2020,
                Make = "Audi",
                Model = "R8",
                EngineNoise = "Vroooooom vrr vrr vrr vrr",
                HonkNoise = "High Beep",
                IsDriveable = true
            };

            carLotList_Variable.CarLot_ListProperty.Add(car2);

            car2.PrintCarName(car2.Make, car2.Model);
            car2.MakeEngineNoise(car2.EngineNoise);
            car2.MakeHonkNoise(car2.HonkNoise);

            Console.WriteLine($"Number of cars in car lot: {CarLot._numberOfCars}");


            // Parameterized Constructor:
            Car car3 = new Car(2022, "Ford", "GT", "GRRROOWWWWLLLLL", "Low Beep", true);

            carLotList_Variable.CarLot_ListProperty.Add(car3);

            car3.PrintCarName(car3.Make, car3.Model);
            car3.MakeEngineNoise(car3.EngineNoise);
            car3.MakeHonkNoise(car3.HonkNoise);

            Console.WriteLine($"Number of cars in car lot: {CarLot._numberOfCars}");


            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            Console.WriteLine("---------------------LOT INVENTORY-----------------------");

            foreach (var car in carLotList_Variable.CarLot_ListProperty)
            {
                Console.WriteLine($"Year: {car.Year} \n Make: {car.Make} \n Model: {car.Model}");
                Console.WriteLine("");
            }

        }
    }
}
