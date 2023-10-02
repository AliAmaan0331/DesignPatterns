using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactoryMethod
{
    public class MACFactory : IComputerFactory
    {
        public IBrand Brand()
        {
            return new MAC();
        }

        public IProcessor Processor()
        {
            return new I7();
        }

        public virtual ISystemType Systemtype()
        {
            return new Desktop();
        }
    }

    public class MACLaptopFactory : MACFactory
    {
        public override ISystemType Systemtype()
        {
            return new Laptop();
        }
    }
}
