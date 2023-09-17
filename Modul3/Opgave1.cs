using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3
{
    internal class Opgave1
    { public void Run ()
        {
            Console.WriteLine("Indtast antal tal: ");
            int antalTal = Convert.ToInt32(Console.ReadLine()); // Her kan også bruges: Convert.ToInt32(Console.ReadLine());
            int[] talArray = new int[antalTal]; // Antallet af tal sættes til arr længde

            for (int i = 0; i < antalTal; i++) // Forløkke som gør hvert input af tal ryger ind i arr.
            {
                Console.Write($"Indtast nu tal nummer {i + 1}: ");
                talArray[i] = Convert.ToInt32(Console.ReadLine());    
            }

            double gennemsnit = average(talArray);
            double varians = variansFunktion(talArray);
            double standardAfvigelse = standardAfvigelseFunktion(talArray);

            Console.WriteLine(); // For at gøre det mere overskueligt for brugeren

            Console.Write("Tallene i arrayet er: "); // Bruger denne forløkke for at vise hvad arrayet indeholder.
            for (int i = 0; i < talArray.Length; i++)
            {
                Console.Write(talArray[i]);
                if (i < talArray.Length - 1)
                {
                    Console.Write(", ");
                }
            }
           
            Console.WriteLine(); // For at gøre det mere overskueligt for brugeren
            Console.WriteLine(); // For at gøre det mere overskueligt for brugeren

            Console.WriteLine($"Gennemsnittet af tallene er {gennemsnit}");
            Console.WriteLine($"Variansen af tallene er {varians}");
            Console.WriteLine($"Standardafvigelsen af tallene er {standardAfvigelse}");

            double average(int[] a)
            {
                if (a.Length == 0) // Hvis antallet af tal i arr er 0.
                    return 0;

                double sum = 0;
                
                foreach (int tal in a)  // Finder summen af alle tal i arr.
                {
                sum += tal;
                }
                return sum / a.Length; // Udregner gennemsnit
            }

            // Varians er hvor meget de indiduelle datapunkter afviger fra gennemsnittet.
            double variansFunktion(int[] a)
            {
                if (a.Length == 0)  // Hvis antallet af tal i arr er 0.
                    return 0;

                double variansSum = 0;

                foreach (int tal in a)
                {
                    variansSum += Math.Pow(tal - average(a), 2); // Her beregnes kvadratet af afstanden mellem hvert datapunkt og gennemsnittet og akkumulerer disse kvadrater i variabelen variansSum
                }

                return variansSum / a.Length; // For at finde variansen skal vi divideres antallet af tal med variansSum.
            }

            double standardAfvigelseFunktion(int[] a)
            {
                return Math.Sqrt(variansFunktion(a)); // For at beregne standardafvigelsen, skal vi blot tage kvardratroden af variansen.
            }
        }
    }
}
