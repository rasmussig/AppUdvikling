using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Modul6
{
    internal class Opgave6_1
    {
        public void Run()
        {
            List<employee> employees = new List<employee>
        {
            new ftEmployee{
                name = "Anders And",
                address = "Byvej 13\r\n4321 Andeby",
                email = "anders@and.com",
                deduction = 5000,
                drawPercentage = 32,
                monthlySalary = 23000,
                hasLunch = true,
                hasGiftBox = false,
                isFullTime = true
            },
             new ptEmployee{
                name = "Benny Bomstærk",
                address = "Lærkevej 13\r\n4321 Brabrand",
                email = "benny@bom.com",
                deduction = 6000,
                drawPercentage = 28,
                hourlyWage = 187,
                hoursWorked = 120,
                hasLunch = true,
                hasGiftBox = true,
                isFullTime = false
            },
  };
            // Opgave 7.1
            employees.Sort();

            Console.WriteLine("Vil du udskrive lønsedler for alle (alle), fuldtidsansatte (fuldtid), deltidsansatte (deltid), eller konsulenter (konsulent)?");
            string choice = Console.ReadLine();        
           
            decimal totalTax = 0;

            foreach (employee emp in employees)
            {
                if ((choice == "alle") ||
                    (choice == "fuldtid" && emp is ftEmployee) ||
                    (choice == "deltid" && emp is ptEmployee))
                {
                    emp.PrintPaySlip();
                    Console.WriteLine("\n---------------------------\n");

                    decimal tax = emp.PrintTax();
                    Console.WriteLine($"Skat: {tax} kr");
                    Console.WriteLine("\n---------------------------\n");

                    totalTax += emp.PrintTax();
                } 
            }

            Console.WriteLine($"Den samlede skat for alle ansatte er: {totalTax}");

            Console.ReadKey();
            Console.WriteLine("Enter a key to exit...");
        }
    }
}

