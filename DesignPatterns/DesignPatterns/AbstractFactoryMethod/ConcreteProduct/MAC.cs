using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactoryMethod
{
    public class MAC:IBrand
    {
        public string GetBrand()
        {
            return Enumerations.Brands.APPLE.ToString();
        }
    }
}
