using DesignPatterns.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    public class PermanentEmployeeFactory: BaseEmployeeFactory
    {
        public PermanentEmployeeFactory(Employee emp):base(emp)
        {
        }

        public override IEmployee Create()
        {
            PermanentEmployee permanentEmployee = new PermanentEmployee();
            _emp.HouseAllowance = permanentEmployee.GetHouseAllowance();
            return permanentEmployee;
        }
    }
}
