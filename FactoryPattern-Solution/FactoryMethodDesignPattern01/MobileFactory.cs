using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern01
{
    public abstract class MobileFactory
        //This class is called 'Abstract Creator'. This class declares the factory method which returns an object of type Product.
    {
        protected abstract Mobile MakeMobile(); // Factory Method

        public Mobile CreateMobile() // Concrete Method
        {
            Mobile mobile = MakeMobile();

            return mobile;
        }
    }
}
