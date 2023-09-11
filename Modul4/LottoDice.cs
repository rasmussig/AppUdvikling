using System;
using System.Collections.Generic;
using System.Linq;

namespace Modul4
{
    public class LottoDice
    {
        private List<int> availableNumbers; // Opretter en liste, med mulige numre
        private int selectedNumber; 
        private Random random;

        public LottoDice(int maxNumber)
        {
                 /* Her er en stump kode som, udskriver en fejl, hvis input er 0 eller mindre. 
                 if (maxNumber <= 0)
                 {
                    Console.WriteLine("Fejl: Maksimalt nummer skal være større end 0.");
                    availableNumbers = new List<int>();
                 } */

            //OLE, hvorfor skal dette både erklæres her og i tidligere???
            availableNumbers = new List<int>(); 

            // En forløkke som kører igennem alle tallene fra 1 - maxNumber = 35, og sætter dem ind i availableNumbers-listen.
            for (int i = 1; i <= maxNumber; i++)
            {
                availableNumbers.Add(i);
            }
            // En one-liner istedet forløkken: availableNumbers = Enumerable.Range(1, maxNumber).ToList(); 
            
            random = new Random();
            TrækNummer();
        }

        public void TrækNummer()
        {
            if (availableNumbers.Count == 0)
            {
                throw new InvalidOperationException("Ingen flere numre tilbage at trække.");
            }

            int index = random.Next(availableNumbers.Count);
            selectedNumber = availableNumbers[index];
            availableNumbers.RemoveAt(index);
        }

        public int Nummer
        {
            get
            {
                return selectedNumber;
            }
        }

        public int MaksNummer
        {
            get
            {
                return availableNumbers.Count > 0 ? availableNumbers.Max() : 0;
            }
        }

        public void Nulstil()
        {
            availableNumbers.Clear();
        }
    }
}
