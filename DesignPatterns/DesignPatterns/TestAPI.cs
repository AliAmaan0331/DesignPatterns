using DesignPatterns.AbstractFactoryMethod;
using DesignPatterns.FactoryMethod;
using DesignPatterns.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    [ApiController]
    [Route("[controller]")]
    public class TestAPI:ControllerBase
    {
        public readonly Singleton _singletonclass;
        public TestAPI()
        {
            _singletonclass = Singleton.GetInstance;
        }

        [HttpGet]
        [Route("/print")]
        public void callPrint(string message)
        {
            _singletonclass.print(message);
        }

        [HttpGet]
        [Route("/salary")]
        public void callEmployee(int employeeId)
        {
            EmployeeManagerFactory empFactory = new EmployeeManagerFactory();
            IEmployee employee = empFactory.GetEmployee(employeeId);
            Console.WriteLine("Salary is: " + employee.Salary());
            Console.WriteLine("Bonus is: " + employee.Bonus());
        }

        [HttpGet]
        [Route("/salaryByFactoryDesign")]
        public Employee callEmployeeByFactoryDesign(int employeeId)
        {
            Employee employee = new Employee();
            employee.Id = employeeId;
            BaseEmployeeFactory empFactory = new DesignPatterns.FactoryMethod.EmployeeManagerFactory().CreateEmployeeFactory(employee);
            empFactory.ApplySalary();
            return employee;
        }

        [HttpGet]
        [Route("/salaryByAbstractFactory")]
        public Employee callEmployeeByAbstractFactory(int employeeId, string designation)
        {
            Employee employee = new Employee();
            employee.Id = employeeId;
            employee.Designation = designation;
            IComputerFactory factory = new EmployeeSystemFactory().Create(employee);
            EmployeeSystemManager manager = new EmployeeSystemManager(factory);
            employee.ComputerSystemDetails = manager.GetSystemDetails();
            BaseEmployeeFactory empFactory = new DesignPatterns.FactoryMethod.EmployeeManagerFactory().CreateEmployeeFactory(employee);
            empFactory.ApplySalary();
            return employee;
        }
    }
}
