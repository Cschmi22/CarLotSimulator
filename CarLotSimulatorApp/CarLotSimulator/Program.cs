using Microsoft.VisualBasic;
using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
           var lot = new CarLot();


            //DONECreate a seperate class file called Car
            //DONE Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //DONE Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //DONE The methods should take one string parameter: the respective noise property
            var myCar = new Car();
            myCar.Year = 2018;
            myCar.Make = "Toyota";
            myCar.Model = "Camry";
            myCar.IsDriveable = true;
            myCar.EngineNoise = "buhbuhbuhbuhbuh";
            myCar.HonkNoise = "mep";

            lot.Cars.Add(myCar);

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

            var anotherCar = new Car(2001, "Chevy", "Silverado", "bumbumbumbum", "EeH", false);
            

            lot.Cars.Add(anotherCar);

            //DONE Now that the Car class is created we can instanciate 3 new cars
            //DONE Set the properties for each of the cars
            //DONE Call each of the methods for each car
            myCar.MakeEngineNoise(myCar.EngineNoise);
            wifeCar.MakeEngineNoise(wifeCar.EngineNoise);
            anotherCar.MakeEngineNoise(anotherCar.EngineNoise);

            myCar.MakeHonkNoise(myCar.HonkNoise);
            wifeCar.MakeHonkNoise(wifeCar.HonkNoise);
            anotherCar.MakeHonkNoise(anotherCar.HonkNoise);
            
            foreach (var Car in lot.Cars)
            {
                Console.WriteLine($" Year: {Car.Year} Make: {Car.Make} Model: {Car.Model}");
            }
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //DONE Create a CarLot class
            //DONE It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
