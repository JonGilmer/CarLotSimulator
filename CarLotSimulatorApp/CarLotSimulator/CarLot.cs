using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    public class CarLot
    {
        //Create a CarLot class
        //It should have at least one property: a List of cars
        //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.


        // Default Constructor
        public CarLot()
        {

        }

        // static field
        public static int _numberOfCars;

        // Property
        public List<Car> CarLot_ListProperty { get; set; } = new List<Car>();
    }
}
