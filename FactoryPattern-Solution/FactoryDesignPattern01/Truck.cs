using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern01
{
    public class Truck : VehicleDetails
    {
        public int GetVehiclePrice(int truckPrice)
        {
            return truckPrice;
        }

        public int GetVehicleCount(int truckCount)
        {
            return truckCount;
        }

        public string GetVehicleName(string truckName)
        {
            return truckName;
        }

        public VehicleType GetVehicleType()
        {
            return VehicleType.Truck;
        }
    }
}
