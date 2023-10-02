using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class EmployeeManagerFactory
    {
        public IEmployee GetEmployee(int id)
        {
            IEmployee returnValue = null;
            if(id == 1)
            {
                returnValue = new PermanentEmployee();
            }
            else if(id == 2)
            {
                returnValue = new ContractualEmployee();
            }
            return returnValue;
        }
    }
}
