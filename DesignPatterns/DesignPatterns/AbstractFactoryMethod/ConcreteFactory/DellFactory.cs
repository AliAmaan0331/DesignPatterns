using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactoryMethod
{
    public class DellFactory : IComputerFactory
    {
        public IBrand Brand()
        {
            return new DELL();
        }

        public IProcessor Processor()
        {
            return new I5();
        }

        public virtual ISystemType Systemtype()
        {
            return new Desktop();
        }
    }

    public class DellLaptopFactory : DellFactory
    {
        public override ISystemType Systemtype()
        {
            return new Laptop();
        }
    }
}
