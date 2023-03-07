using Microsoft.VisualBasic;
using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
           var lot = new CarLot();

            var myCar = new Car();
            CarLot.numberOfCars++;
            myCar.Year = 2018;
            myCar.Make = "Toyota";
            myCar.Model = "Camry";
            myCar.IsDriveable = true;
            myCar.EngineNoise = "buhbuhbuhbuhbuh";
            myCar.HonkNoise = "mep";

            lot.Cars.Add(myCar);
            Console.WriteLine($"There is {CarLot.numberOfCars} car in the lot");


            var wifeCar = new Car()
            {
                Year = 2020,
                Make = "Toyota",
                Model = "Corolla",
                IsDriveable = true,
                EngineNoise = "fstfstfstfstfst",
                HonkNoise = "mEEp",

            };
            lot.Cars.Add(wifeCar);
            CarLot.numberOfCars++;
            Console.WriteLine($"There are {CarLot.numberOfCars} cars in the lot");


            var anotherCar = new Car(2001, "Chevy", "Silverado", "bumbumbumbum", "EeH", false);

            

            lot.Cars.Add(anotherCar);
            CarLot.numberOfCars++;
            Console.WriteLine($"There are {CarLot.numberOfCars} cars in the lot");


            //myCar.MakeEngineNoise(myCar.EngineNoise);
            //wifeCar.MakeEngineNoise(wifeCar.EngineNoise);
            //anotherCar.MakeEngineNoise(anotherCar.EngineNoise);

            //myCar.MakeHonkNoise(myCar.HonkNoise);
            //wifeCar.MakeHonkNoise(wifeCar.HonkNoise);
            //anotherCar.MakeHonkNoise(anotherCar.HonkNoise);
            
            //foreach (var Car in lot.Cars)
            //{
            //    Console.WriteLine($" Year: {Car.Year} Make: {Car.Make} Model: {Car.Model}");
            //}


        }
    }
}
