using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public int Salary { get; set; }
        public int Bonus { get; set; }
        public int MedicalAllowance { get; set; }
        public int HouseAllowance { get; set; }
        public string Designation { get; set; }
        public string ComputerSystemDetails { get; set; }
    }
}
