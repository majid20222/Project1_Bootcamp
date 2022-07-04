using System;
using System.Collections.Generic;
using System.Text;

namespace SalarySlip
{
    class SalarySlip
    {
        private int baseSalary=1500;
        public int fuel=0;
        public int medical=0;

        public int grossSalary()
        {
            int anount=baseSalary+fuel+medical;
            return anount;
        }
    }

    class ManagerSalary : SalarySlip
    {
        public ManagerSalary()
        {
            fuel = 250;
            medical = 1000;

        }

    }
    class EngineerSalary : SalarySlip
    {
        public EngineerSalary()
        {
            fuel = 100;
            medical = 500;

        }

    }
    class AnalystSalary : SalarySlip
    {
        public AnalystSalary()
        {
            fuel = 150;
            medical = 800;

        }

    }
}
