using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul6
{
    public class ftEmployee : employee
    {
        public decimal monthlySalary { get; set; }

        // Metode til udskrivning af lønseddel for fuldtidsansatte
        public override void PrintPaySlip()
        {
            base.PrintPaySlip();
            Console.WriteLine($"Månedsløn: {monthlySalary}");
        }

        public override decimal PrintTax()
        {
            decimal taxAbleIncome = (decimal)(monthlySalary - deduction);
            decimal tax = 0.32m * taxAbleIncome;
            return tax;
            
        }
    }
}
