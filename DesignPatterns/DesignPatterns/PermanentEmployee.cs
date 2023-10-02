using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class PermanentEmployee:IEmployee
    {
        public int Salary()
        {
            return 2800;
        }

        public int Bonus()
        {
            return 5600;
        }

        public int GetHouseAllowance()
        {
            return 1000;
        }
    }
}
