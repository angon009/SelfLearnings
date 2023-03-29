using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern02
{
    public class Walk : IShareRide
    {
        public void ShareVehicle(string vehicleType, int distance)
        {
            Console.WriteLine("Vehicle Type : Legs");
            Console.WriteLine("Fare : 0 Taka");
            Console.WriteLine($"Total Distance {distance} KM");
            Console.WriteLine($"You can reduce {distance/2}% of Fat from your body");
            Console.WriteLine("Happy Walking!!!");
        }
    }
}
