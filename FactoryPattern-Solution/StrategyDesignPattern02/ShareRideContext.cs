using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern02
{
    public class ShareRideContext
    {
        private IShareRide _shareRide;

        public void SetRide(IShareRide shareRide)
        {
            _shareRide = shareRide;
        }
        public void CreateRide(string vehicleType, int distance)
        {
            _shareRide.ShareVehicle(vehicleType, distance);
        }
    }
}
