using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern02
{
    public class Car : IShareRide
    {
        public void ShareVehicle(string vehicleType, int distance)
        {
            Console.WriteLine("Vehicle Type : " + vehicleType);
            Console.WriteLine($"Total Distance {distance} KM");
            Console.WriteLine("Total Fare : " + distance * 8 + " Taka");
        }
    }
}
