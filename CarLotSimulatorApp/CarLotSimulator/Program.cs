﻿using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
                 

           
            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property
                     

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //Dot Notation


            var ShirleyTilda = new Car();

            var carLotOne = new CarLot();


            {
                ShirleyTilda.Make = "Chevrolet";
                ShirleyTilda.Model = "Cobalt";
                ShirleyTilda.Year = (2009); 
                ShirleyTilda.EngineNoise = "dunk dunk dunk dunk pffffft";
                ShirleyTilda.HonkNoise = "heeeeehhhht";
                ShirleyTilda.IsDriveable = false;
            };
            carLotOne.ParkingLot.Add(ShirleyTilda);
            carLotOne.CheckCarLot();


            //Object initializer syntax

            var BubbaTruck = new Car();
         

            {
                
                BubbaTruck.Make = "Chevrolet";
                BubbaTruck.Model = "Silverado";
                BubbaTruck.Year = (1999);
                BubbaTruck.EngineNoise = "rewr rewr rewr rewr";
                BubbaTruck.HonkNoise = "BOOOONK";
                BubbaTruck.IsDriveable = true;
            };

            carLotOne.ParkingLot.Add(BubbaTruck);
            carLotOne.CheckCarLot();

            Console.WriteLine($"The number of cars in the car lot {CarLot._numberOfCars}");

            var DorothyChristophe = new Car();
            {

                DorothyChristophe.Make = "Toyota";
                DorothyChristophe.Model = "Camry";
                DorothyChristophe.Year = (2023);
                DorothyChristophe.EngineNoise = "tonk tonk tonk";
                DorothyChristophe.HonkNoise = "boop";
                DorothyChristophe.IsDriveable = true;
            };

            carLotOne.ParkingLot.Add(DorothyChristophe);         

            Console.WriteLine($"The number of cars in the car lot {CarLot._numberOfCars}");
            

            //custom constuctor
            var TaylorQuick = new Car(2024,"Toyota","Avalon", "pssssst", "beep", true );
                        
            carLotOne.ParkingLot.Add(TaylorQuick);

            Console.WriteLine($"The Number of cars in car lot {CarLot._numberOfCars}");

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
