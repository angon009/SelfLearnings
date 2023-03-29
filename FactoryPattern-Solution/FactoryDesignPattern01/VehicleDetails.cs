using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern01
{
    public interface VehicleDetails
    {
        public VehicleType GetVehicleType();
        public int GetVehiclePrice(int vehiclePrice);
        public int GetVehicleCount(int vehicleCount);
        public string GetVehicleName(string vehicleName);
    }
    public enum VehicleType
    {
        Bus = 1,
        Car = 2,
        MotorBike = 3,
        Truck = 4
    }
}
