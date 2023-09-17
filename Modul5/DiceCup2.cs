using System;
using System.Collections.Generic;

namespace Modul5
{
    public class DiceCup2
    {
        private List<Dice> mDices; // En liste til at opbevare terningerne i terningebægeret.

        public DiceCup2(int numberOfDice) // Konstruktør med en parameter for antallet af terninger.
        {
            mDices = new List<Dice>(); // Konstruktøren opretter en instans af DiceCup og initialiserer listen med det ønskede antal terninger.

            for (int i = 0; i < numberOfDice; i++)
            {
                mDices.Add(new Dice());
            }
        }

        public void Roll()
        {
            foreach (Dice d in mDices)
            {
                d.Roll(); // Denne metode ruller alle terninger i terningebægeret ved at kalde Roll() metoden på hver terning.
            }
        }

        public int GetTotalEyes()
        {
            int totalEyes = 0;
            foreach (var dice in mDices)
            {
                totalEyes += dice.Eyes; // Denne metode beregner og returnerer summen af øjnene på alle terningerne, hvilket repræsenterer det samlede resultat i terningebæret.
            }
            return totalEyes;
        }

        public string GetDiceResults()
        {
            string results = "";
            int diceNumber = 1;
            foreach (var dice in mDices)
            {
                results += $"Terning {diceNumber}: Øjne: {dice.Eyes}\n"; // Denne metode returnerer en tekststreng, der viser resultaterne af rulningen for alle terningerne, inklusive terningnummeret, størrelsen på terningerne og antallet af øjne, de viser.
                diceNumber++;
            }
            return results;
        }
    }
}
