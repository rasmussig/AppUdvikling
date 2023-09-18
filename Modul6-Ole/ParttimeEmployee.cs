using System;
namespace Modul6_Ole
{
    public class ParttimeEmployee : Employee
    {
        public int HourlySalary { get; set; }
        public int Hours { get; set; }

        public override int Salary => HourlySalary * Hours;

        public override string NameOfType => "Deltidsansat";

        public override string SpecLine
        {
            get
            {
                string salaryTxt = String.Format("{0,8}", Salary);
                return $"{Hours} timer af {HourlySalary} kr\t\t{salaryTxt} kr";
            }
        }
    }
}