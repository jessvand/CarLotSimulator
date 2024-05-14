using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {//Create a seperate class file called Car
     //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
     //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
     //The methods should take one string parameter: the respective noise property

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise {  get; set; }
        public string HonkNoise {  get; set; }
        public bool IsDriveable { get; set; }

           
        
        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine( $"My Toyota Camry's {engineNoise} is concerning!" );
        }

        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine($"My Chevrolet Cobalt's {honkNoise} is audaciously obnoxious!");

        }

        public void ShirleyTilda(string Make)
        {
           Console.WriteLine($"ShirleyTilda is a {Make}");
        }
        public void BubbaTruck(string Model)
        {
            Console.WriteLine($"BubbaTruck is a Chevrolet {Model}");
        }

        public void DorothyChristophe(string isDriveable)
        {
            Console.WriteLine($"BubbaTruck is a Chevrolet {isDriveable}");
        }

        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;

        }

        public Car()
        {
        }
    }
}
