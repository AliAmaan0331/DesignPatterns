using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class ContractualEmployee:IEmployee
    {
        public int Salary()
        {
            return 2000;
        }

        public int Bonus()
        {
            return 4000;
        }

        public int GetMedicalAllowance()
        {
            return 500;
        }
    }
}
