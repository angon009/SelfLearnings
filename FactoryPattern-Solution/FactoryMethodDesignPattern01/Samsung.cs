using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern01
{
    public class Samsung : Mobile
        //This class is called 'Concrete Product'.
    {
        public string GetBrandName()
        {
            return "Samsung";
        }

        public string GetModelName()
        {
            return "S7 Ultra";
        }

        public string GetOSName()
        {
            return "Android-12";
        }

        public int GetPrice()
        {
            return 150000;
        }
    }
}
