using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactoryMethod
{
    public class Desktop : ISystemType
    {
        public string GetSystemType()
        {
            return Enumerations.ComputerTypes.Desktop.ToString();
        }
    }

    public class Laptop : ISystemType
    {
        public string GetSystemType()
        {
            return Enumerations.ComputerTypes.Laptop.ToString();
        }
    }
}
