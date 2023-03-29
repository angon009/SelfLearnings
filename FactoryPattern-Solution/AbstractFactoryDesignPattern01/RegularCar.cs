using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern01
{
    public class RegularCar : ICar
        //Concrete Product Class
    {
        public void GetDetails()
        {
            Console.WriteLine("Regular Car Details");
        }
    }
}
