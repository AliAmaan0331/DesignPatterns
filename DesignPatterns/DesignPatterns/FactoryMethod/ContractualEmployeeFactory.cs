using DesignPatterns.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    public class ContractualEmployeeFactory : BaseEmployeeFactory
    {
        public ContractualEmployeeFactory(Employee emp):base(emp)
        {

        }
        public override IEmployee Create()
        {
            ContractualEmployee contractualEmployee = new ContractualEmployee();
            _emp.MedicalAllowance = contractualEmployee.GetMedicalAllowance();
            return contractualEmployee;
        }
    }
}
