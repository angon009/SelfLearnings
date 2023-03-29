using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern01
{
    public class SamsungFactory : MobileFactory
    //SamsungFactory is called as Concrete Creator Class
    {
        protected override Mobile MakeMobile()
        {
            Mobile mobile = new Samsung();
            return mobile;
        }
    }
}
