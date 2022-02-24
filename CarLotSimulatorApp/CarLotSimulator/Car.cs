using System;
namespace CarLotSimulator
{
    public class Car
    {
        // Default Constructor
        public Car()
        {
            CarLot._numberOfCars++;
        }

        // Perameterized Constructor
        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
            CarLot._numberOfCars++;
        }


        //Create a seperate class file called Car
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }


        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property
        public void PrintCarName(string carMake, string carModel)
        {
            Console.WriteLine($"{carMake} {carModel}: ");
        }


        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine(engineNoise);
        }


        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine(honkNoise);
            Console.WriteLine("");
        }
    }

}
