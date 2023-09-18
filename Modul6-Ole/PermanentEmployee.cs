using System;
namespace Modul6_Ole
{
    public class PermanentEmployee : Employee
    {
        public int MonthlySalary { get; set; }

        public override int Salary => MonthlySalary;

        public override string NameOfType => "Fastansat";

        public override string SpecLine
        {
            get
            {
                string salaryTxt = String.Format("{0,8}", Salary);
                return $"Månedsløn\t\t\t{salaryTxt} kr";
            }
        }
    }
}