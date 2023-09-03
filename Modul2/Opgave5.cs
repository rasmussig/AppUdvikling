using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2
{
    internal class Opgave5
    {
        public void Run()
        {
            double sum = 0;
            double produkt = 1;
            int antalTal = 0;

            Console.WriteLine("Indtast et tal per linje (afslut med 0):");

            while (true)
            {
                string input = Console.ReadLine();

                if (double.TryParse(input, out double tal))
                {
                    if (tal == 0)
                        break;

                    sum += tal;
                    produkt *= tal;
                    antalTal++;
                }
                else
                {
                    Console.WriteLine("Ugyldig indtastning. Indtast et tal eller 0 for at afslutte.");
                }
            }

            if (antalTal > 0)
            {
                double gennemsnit = sum / antalTal;
                Console.WriteLine($"Summen af tallene er: {sum}");
                Console.WriteLine($"Produktet af tallene er: {produkt}");
                Console.WriteLine($"Gennemsnittet af tallene er: {gennemsnit}");
            }
            else
            {
                Console.WriteLine("Ingen gyldige tal blev indtastet.");
            }
        }
    }
}