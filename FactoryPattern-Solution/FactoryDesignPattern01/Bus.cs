using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern01
{
    public class Bus : VehicleDetails
    {
        public int GetVehiclePrice(int busPrice)
        {
            return busPrice;
        }

        public int GetVehicleCount(int busCount)
        {
            return busCount;
        }

        public string GetVehicleName(string busName)
        {
            return busName;
        }

        public VehicleType GetVehicleType()
        {
            return VehicleType.Bus;
        }
    }
}
