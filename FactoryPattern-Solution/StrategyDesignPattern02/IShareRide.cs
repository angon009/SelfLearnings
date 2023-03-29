using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern02
{
    public interface IShareRide
    {
        public void ShareVehicle(string vehicleType, int distance);
    }
}
