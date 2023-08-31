using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1
{
    internal class Opgave3
    {
        public void Run()
        {
            Console.WriteLine("Input et tal, vi summere fra 1 og op til og med tallet");
            string input1 = Console.ReadLine();
            int tal1 = int.Parse(input1);

            int sum = 0;

            for (int idx = 1; idx <= tal1; idx++)
            {
                sum += idx;
            }
            Console.Write($"Summen af tallene fra 1 til {tal1} er: {sum}");
        }

    }
}