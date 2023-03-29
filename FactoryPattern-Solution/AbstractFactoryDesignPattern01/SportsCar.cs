using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern01
{
    public class SportsCar : ICar
    //Concrete Product Class
    {
        public void GetDetails()
        {
            Console.WriteLine("Sports Car Details");
        }
    }
}
