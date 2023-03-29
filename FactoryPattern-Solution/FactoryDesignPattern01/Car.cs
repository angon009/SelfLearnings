using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern01
{
    public class Car : VehicleDetails
    {
        public int GetVehiclePrice(int carPrice)
        {
            return carPrice;
        }

        public int GetVehicleCount(int carCount)
        {
            return carCount;
        }

        public string GetVehicleName(string carName)
        {
            return carName;
        }

        public VehicleType GetVehicleType()
        {
            return VehicleType.Car;
        }
    }
}
