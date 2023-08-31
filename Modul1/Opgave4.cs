using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1
{
    internal class Opgave4
    {
        public void Run()
        {
            Console.Write("Skriv dit første tal: ");
            int tal1 = int.Parse(s: Console.ReadLine());

            Console.Write("Skriv dit andet tal: ");
            int tal2 = int.Parse(s: Console.ReadLine());

            Console.Write("Indtast en regneoprator (+, -, , /): ");
            char regneOperator = char.Parse(s: Console.ReadLine());

            int resultat = 0;

            if (regneOperator == '+')
            {
                resultat = tal1 + tal2;
            }
            else if (regneOperator == '-')
            {
                resultat = tal1 - tal2;
            }
            else if (regneOperator == '*')
            {
                resultat = tal1 * tal2;
            }
            else if (regneOperator == '/')
            {
                if (tal1 != 0 && tal2 != 0)
                {
                    resultat = tal1 / tal2;
                }
                else
                {
                    Console.WriteLine("NEJ! din idiot du kan ikke dividere med 0");
                }

            }
            else
            {
                Console.Write("Ugyldig regneoprator");
            }
            Console.WriteLine($"Resutatet af {tal1} {regneOperator} {tal2} er {resultat}");
        }
    }
}