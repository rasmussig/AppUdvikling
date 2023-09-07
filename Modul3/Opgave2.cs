using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Modul3
{
    internal class Opgave2
    {
        public void Run()
        {
            Console.WriteLine("Indtast hvor mange karaktere du vil angive");
            int AntalKaraktere = Convert.ToInt32(Console.ReadLine());
            int[] KarakterArr = new int[AntalKaraktere]; //Her opretter vi et array med nøgleordet "new",
                                                         //Antallet af AntalKaraktere bliver længden på arrey-KarakterArr
            
            //Nederst i denne kode ligger et eksempel på hvordan gennemsnittet beregnes i en funktion.
            double sum = 0; // Skal være en double, da gennemsnittet ofte indeholder kommatal, ellers vil det være int-division.

            for (int i = 0; i < AntalKaraktere; i++) //En forløkke for indtastningen af hver karakter,
                                                     //hvor vi også ligger hver karakter til sum. 
            {
                Console.Write($"Indtast karakter nummer {1 + i}: ");
                KarakterArr[i] = Convert.ToInt32(Console.ReadLine());

                sum += KarakterArr[i];
              
            }

            double gennemsnit = sum / AntalKaraktere; // Udregner gennemsnit 


            Console.WriteLine(); // Mere overskueligt program.
            Console.WriteLine($"Gennemsnittet af dine karaktere er {gennemsnit}");

            Console.WriteLine(); // For at gøre programmet mere overskueligt

           

            Console.Write("Her er en liste over hvor mange gange hver karakter forekommer:");

            Console.WriteLine(); // For at gøre programmet mere overskueligt


            Dictionary<int, int> karakterTællere = TælKarakterer(KarakterArr); // Her bruges funktionen med vores KarakterArr som input.

            foreach (var par in karakterTællere) // Denne forløkke udskriver hvert par, altså nøgle og værdi,
                                                 // også kaldet karakter og antal forekomster.
            {
                Console.WriteLine($"Karakter: {par.Key}, Antal forekomster: {par.Value}");
            }
        }
        Dictionary<int, int> TælKarakterer(int[] array) // Her er en funktion, som bruger Dictionary, som er en C# datastruktur som gemmer et par af nøgler og værdier,
                                                        // her gemmer den det i variablen TælKaraktere, funktionen tager et array som input.
        {
            Dictionary<int, int> karakterTæller = new Dictionary<int, int>();  // Her oprettes en tom Dictionary, kaldet karakterTæller,
                                                                               // som skal bruges til at gemme karaktertællingen.

            foreach (int karakter in array) // En forløkke som går gennem hvert element (karakter) i input-arrayet.
            {
                if (karakterTæller.ContainsKey(karakter)) // Tjekker om karakterTæller allerede indeholder den nøgle.
                                                          // fx 4, hvis ja øg derefter værdien for den karakter.
                {
                    karakterTæller[karakter]++;
                }
                else
                {
                    karakterTæller[karakter] = 1; // Hvis karakterTæller ikke indeholder den nøgle fx. 4 vil koden her eksekveres,
                                                  // og en ny nøgle tilføjes fx 4, og bliver tildelt værdien 1.
                }
            }

            return karakterTæller; // Funktionen returnere nu alle nøglerne og værdierne til disse nøgler.
        }
    }

    /* Herunder ses hele logikken for at udskrive et gennemsnit af et array. I en funktion
    Double gennemsnit = gennemsnitsFunktion(KarakterArr);
    Console.Write($"Gennemsnittet af dine karaktere er {gennemsnit}");

    double gennemsnitsFunktion(int []a)
    {
        double sum = 0;

        foreach (int tal in a)
        {
            sum += tal;
        }
        return sum/a.Length;
    }
    Her slutter logikken for at udskrive et gennemsnit af et array. */

}


