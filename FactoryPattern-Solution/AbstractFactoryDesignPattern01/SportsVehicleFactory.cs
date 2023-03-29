using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern01
{
    public class SportsVehicleFactory : IVehicleFactory
        //Concrete Factory
    {
        public IBike CreateBike()
        {
            return new SportsBike();
        }

        public IBus CreateBus()
        {
            return new SportsBus();
        }

        public ICar CreateCar()
        {
            return new SportsCar();
        }
    }
}
