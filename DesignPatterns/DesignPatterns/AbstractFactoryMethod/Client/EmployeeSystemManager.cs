using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactoryMethod
{
    public class EmployeeSystemManager
    {
        private readonly IComputerFactory _computerFactory;
        public EmployeeSystemManager(IComputerFactory computerFactory)
        {
            _computerFactory = computerFactory;
        }

        public string GetSystemDetails()
        {
            IBrand brand = _computerFactory.Brand();
            ISystemType system = _computerFactory.Systemtype();
            IProcessor processor = _computerFactory.Processor();
            return string.Format("{0}, {1}, {2}", brand.GetBrand(), system.GetSystemType(), processor.GetProcessor());
        }
    }
}
