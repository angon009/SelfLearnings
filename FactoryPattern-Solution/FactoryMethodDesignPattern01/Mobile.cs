using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern01
{
    public interface Mobile 
        // This class is called 'Product Interface'. We need to define the operations a product should have here. 
    {
        public string GetBrandName();
        public string GetModelName();
        public string GetOSName();
        public int GetPrice();
    }
}
