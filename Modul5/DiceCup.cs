using System;
using System.Collections.Generic;

namespace Modul5
{
    public class DiceCup
    {
        private List<Dice> mDices; // En liste til at opbevare de to terninger i terningebægeret.

        public DiceCup()
        {
            mDices = new List<Dice> // Konstruktøren opretter en instans af DiceCup og initialiserer listen med to terninger.
            {
                new Dice(),  // Opretter den første terning og tilføjer den til listen.
                new Dice()   // Opretter den anden terning og tilføjer den til listen.
            };
        }

        public void Roll()
        {
            foreach (Dice d in mDices)
            {
                d.Roll(); // Denne metode ruller begge terninger i terningebægeret ved at kalde Roll() metoden på hver terning.
            }
        }

        public int GetTotalEyes()
        {
            int totalEyes = 0;
            foreach (var dice in mDices)
            {
                totalEyes += dice.Eyes; // Denne metode beregner og returnerer summen af øjnene på begge terninger, hvilket repræsenterer det samlede resultat í terningebæret.
            }
            return totalEyes;
        }

        public string GetDiceResults()
        {
            string results = "";
            int diceNumber = 1;
            foreach (var dice in mDices)
            {
                results += $"Terning: {diceNumber}, Øjne: {dice.Eyes}\n"; // Denne metode returnerer en tekststreng, der viser resultaterne af rulningen for begge terninger, inklusive størrelsen på terningerne og det antal øjne, de viser.
                diceNumber++;            
            }
            return results;
        }
    }
}
