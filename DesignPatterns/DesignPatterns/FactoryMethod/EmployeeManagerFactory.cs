using DesignPatterns.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    public class EmployeeManagerFactory
    {
        public BaseEmployeeFactory CreateEmployeeFactory(Employee emp)
        {
            BaseEmployeeFactory returnValue = null;
            if(emp.Id == 1)
            {
                returnValue = new PermanentEmployeeFactory(emp);
            }
            else if (emp.Id == 2)
            {
                returnValue = new ContractualEmployeeFactory(emp);
            }
            return returnValue;
        }
    }
}
