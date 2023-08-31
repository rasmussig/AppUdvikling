using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1
{
    internal class Opgave2
    {
        public void Run()
        {
            Console.Write("Skriv et tal, vi tjekker om det er lige eller ulige: ");
            string input1 = Console.ReadLine();
            int tal1 = int.Parse(input1);

            if (tal1 % 2 == 0)
            {
                Console.WriteLine($"Tallet {input1} er et lige tal");
            }
            else
            {
                Console.WriteLine($"Tallet {input1} er et ulige tal");
            }
        }
    }
}