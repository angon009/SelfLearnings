using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern01
{
    public class VehicleFactory
    {
        public static VehicleDetails GetVehicleDetails(VehicleType vehicleType)
        {
            VehicleDetails vehicleDetails = null;

            if (VehicleType.Bus == vehicleType)
            {
                vehicleDetails = new Bus();
            }
            else if (VehicleType.Truck == vehicleType)
            {
                vehicleDetails = new Truck();
            }
            else if (VehicleType.Car == vehicleType)
            {
                vehicleDetails = new Car();
            }
            else if (VehicleType.MotorBike == vehicleType)
            {
                vehicleDetails = null;
            }
            return vehicleDetails;
        }
    }
}
