using DesignPatterns.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    public abstract class BaseEmployeeFactory
    {
        protected Employee _emp;
        public BaseEmployeeFactory(Employee emp)
        {
            _emp = emp;
        }

        public Employee ApplySalary()
        {
            IEmployee manager = this.Create();
            _emp.Salary = manager.Salary();
            _emp.Bonus = manager.Bonus();
            return _emp;
        }
        public abstract IEmployee Create();
    }
}
