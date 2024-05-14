using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class CarLot
    {
        public List<Car> ParkingLot { get; set; } = new List<Car>();

        public void CheckCarLot()
        {
            foreach(var car in ParkingLot)
            {
                Console.WriteLine($"The {car.Year},{car.Make},{car.Model}");
                car.MakeEngineNoise(car.EngineNoise);
                car.MakeHonkNoise(car.HonkNoise);
                
            }
        }
    }
}
