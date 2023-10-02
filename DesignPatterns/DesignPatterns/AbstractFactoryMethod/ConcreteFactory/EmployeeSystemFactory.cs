using DesignPatterns.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactoryMethod
{
    public class EmployeeSystemFactory
    {
        public IComputerFactory Create(Employee emp)
        {
            IComputerFactory returnValue = null;

            if(emp.Id == 1)
            {
                if(emp.Designation == "Manager")
                {
                    returnValue = new MACLaptopFactory();
                }
                else
                {
                    returnValue = new MACFactory();
                }
            }
            else if(emp.Id == 2)
            {
                if (emp.Designation == "Manager")
                {
                    returnValue = new DellLaptopFactory();
                }
                else
                {
                    returnValue = new DellFactory();
                }
            }

            return returnValue;
        }
    }
}
