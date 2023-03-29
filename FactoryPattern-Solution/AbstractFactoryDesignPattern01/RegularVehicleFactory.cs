using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern01
{
    public class RegularVehicleFactory : IVehicleFactory
        //Concrete Factory
    {
        public IBike CreateBike()
        {
            return new RegularBike();
        }

        public IBus CreateBus()
        {
            return new RegularBus();
        }

        public ICar CreateCar()
        {
            return new RegularCar();
        }
    }
}
