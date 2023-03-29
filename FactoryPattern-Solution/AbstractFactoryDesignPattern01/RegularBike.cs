using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern01
{
    public class RegularBike : IBike
        //Concrete Product Class
    {
        public void GetDetails()
        {
            Console.WriteLine("Regular Bike Details");
        }
    }
}
