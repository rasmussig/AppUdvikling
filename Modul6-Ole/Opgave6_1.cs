using System;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Modul6_Ole
{
    public class Opgave6_1
    {
        public void Run()
        {
            PermanentEmployee anders = new PermanentEmployee
            {
                Name = "Ander And",
                Address = "byvej 12",
                Email = "peter@peter.com",
                TaxDeduction = 5000,
                TaxPrecentage = 32,
                MonthlySalary = 23000,
                IsMemberOfLunch = true,
                IsMemberGiftbox = false
            };
            ParttimeEmployee jens = new ParttimeEmployee
            {
                Name = "jens",
                Address = "byvej 14",
                Email = "jens@jens.com",
                TaxDeduction = 6700,
                TaxPrecentage = 54,
                HourlySalary = 123,
                Hours = 110
            };
            PermanentEmployee peter = new PermanentEmployee
            {
                Name = "peter",
                Address = "byvej 12",
                Email = "peter@peter.com",
                TaxDeduction = 5000,
                TaxPrecentage = 32,
                MonthlySalary = 23000,
                IsMemberOfLunch = false,
                IsMemberGiftbox = false
            };
            ParttimeEmployee gert = new ParttimeEmployee
            {
                Name = "Gert",
                Address = "byvej 14",
                Email = "jens@jens.com",
                TaxDeduction = 6700,
                TaxPrecentage = 54,
                HourlySalary = 100,
                Hours = 100,
                IsMemberOfLunch = true
            };

            List<Employee> mEmp = new List<Employee>
            {
                anders,
                jens,
                peter,
                gert
            };

            // Opgave 7.1a Sorter listen efter navne
            mEmp.Sort();


            // Opgave 7.1b Sorter listen efter bruttoløn

            /*foreach (Employee emp in mEmp)
            {
                Console.WriteLine($"{emp.Name}: brutto: {emp.Salary}");
                emp.PrintSalaryNote();
            }*/

            // b) Skriv en funktion som tager en liste af ansatte som input parameter, og som returnerer den samlede bruttoløn for alle ansatte i listen.

            static decimal CalculateAllSalary(List<Employee> ansatteList) {
                decimal total = 0;

                foreach (Employee emp in ansatteList) { total += emp.Salary; }

                return total;

            }

            decimal samletBruttolon = CalculateAllSalary(mEmp);

            Console.WriteLine($"Den samlede bruttoløn for alle ansatte er: {samletBruttolon}");

            // c) Skriv en funktion som tager en liste af ansatte som input parameter, og som returnerer hvor meget skat de tilsammen skal betale.

            static decimal CalculateTotalTax(List<Employee> ansatteList) {
                decimal total = 0;

                foreach (Employee emp in ansatteList) { total += emp.TaxToPay; }

                return total;

            }

            foreach (var enAnsat in mEmp)
            {
                Console.WriteLine($"{enAnsat.Name} skal betale {enAnsat.TaxToPay}");
            }


            decimal SamletSkat = CalculateTotalTax(mEmp);

            Console.WriteLine($"Den samlede skat for alle ansatte er: {SamletSkat}");
        }
    }
    }