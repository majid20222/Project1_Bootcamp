using System;

namespace SalarySlip
{
    class Program
    {
        static void Main(string[] args)
        {
            EngineerSalary Nadeem = new EngineerSalary();
            Console.WriteLine($"Nadeem salary is { Nadeem.grossSalary()}");

            ManagerSalary Adeel_Rafiq = new ManagerSalary();
            Console.WriteLine($"Adeel_Rafiq salary is { Adeel_Rafiq.grossSalary()}");

            AnalystSalary Majid = new AnalystSalary();
            Console.WriteLine($"Majid salary is { Majid.grossSalary()}");
        }
    }
}
