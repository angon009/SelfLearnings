using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern01
{
    public class Xiaomi : Mobile
        //This class is called 'Concrete Product'.
    {
        public string GetBrandName()
        {
            return "Xiaomi";
        }

        public string GetModelName()
        {
            return "N7-X3";
        }

        public string GetOSName()
        {
            return "Android 11";
        }

        public int GetPrice()
        {
            return 15000;
        }
    }
}
