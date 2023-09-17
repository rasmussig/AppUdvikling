using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul6
{
 public class ptEmployee : employee
    {
        public decimal hourlyWage { get; set; }
        public int hoursWorked { get; set; }

        public decimal calculateSalary()
        {
            decimal totalSalary = hourlyWage * hoursWorked;

            totalSalary -= deduction; // Fradrag trækker vi fra

            totalSalary -= (totalSalary * (decimal)drawPercentage) / 100; // Trækprocent

            if (hasLunch && !isFullTime)
            {
                totalSalary -= 0.7m * 350; // 30% rabat på frokostordning (0.7m repræsentere 70 %)
            }

            totalSalary -= hasGiftBox ? 30 : 0; // Gavekasse

            totalSalary += deduction; // Lægger fradrag til

            return totalSalary;
        }

        // Metode til udskrivning af lønseddel for deltidsansatte
        public override void PrintPaySlip()
        {
            base.PrintPaySlip();
            Console.WriteLine($"Timeløn: {hourlyWage}");
            Console.WriteLine($"Antal timer arbejdet: {hoursWorked}");
            Console.WriteLine($"Total løn: {calculateSalary()}");
        }
    }
}
