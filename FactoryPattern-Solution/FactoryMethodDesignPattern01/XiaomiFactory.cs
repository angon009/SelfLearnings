using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern01
{
    public class XiaomiFactory : MobileFactory 
        /*
         XiaomiFactory is called as Concrete Creator Class. This class implements the Abstract Creator Class and override the factory
         method to return an instance of a Concrete Product class 
        */
    {
        protected override Mobile MakeMobile()
        {
            Mobile mobile = new Xiaomi();
            return mobile;
        }
    }
}
