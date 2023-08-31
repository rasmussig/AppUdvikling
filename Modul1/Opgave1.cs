using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1
{
    internal class Opgave1
    {
        public void Run()
        {
            Console.Write("Indtast det første tal: ");
            string input1 = Console.ReadLine();
            int tal1 = int.Parse(input1);

            //Der kan også blot bruges double som er heltal med komma
            //double tal1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Indtast det andet tal: ");
            string input2 = Console.ReadLine();
            int tal2 = int.Parse(input2);

            int sum = tal1 + tal2;
            Console.WriteLine($"Summen af {tal1} og {tal2} er: " + sum);
        }
    }
}