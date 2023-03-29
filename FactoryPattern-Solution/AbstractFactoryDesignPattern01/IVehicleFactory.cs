using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern01
{
    public interface IVehicleFactory
        //Abstract Factory
    {
        public IBike CreateBike();
        public ICar CreateCar();
        public IBus CreateBus();
    }
}
