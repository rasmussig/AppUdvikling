using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul7
{
    public class DiceCup
    {
        private List<Dice> mDices; // En liste til at opbevare terningerne i terningebægeret.

        // Konstruktør for DiceCup, der opretter en samling af terninger baseret på antallet af almindelige og Mafia-terninger.
        public DiceCup(int numberOfDice, int numberOfMafiaDice)
        {
            mDices = new List<Dice>();

            // Tilføj det ønskede antal almindelige terninger til samlingen.
            for (int i = 0; i < numberOfDice; i++)
            {
                mDices.Add(new Dice());
            }

            // Tilføj det ønskede antal Mafia-terninger til samlingen, hvis antallet er større end nul.
            for (int i = 0; i < numberOfMafiaDice; i++)
            {
                mDices.Add(new MafiaDice()); 
            }
        }

        // Her bruger vi polyformi, da Roll-Metoden vil opføre sig forskelligt om det er Dice eller MafiaDice.
        public void Roll()
        {
            foreach (Dice d in mDices)
            {
                d.Roll(); 
            }
        }

        // Metode til at beregne og returnere summen af øjnene på alle terningerne i terningebæret.
        public int GetTotalEyes()
        {
            int totalEyes = 0;
            foreach (var dice in mDices)
            {
                totalEyes += dice.Eyes; 
            }
            return totalEyes;
        }
        // Metode til at returnere en tekststreng, der viser resultaterne af rulningen for alle terningerne inklusive terningnummeret, terningtypen og antallet af øjne, de viser.
        public string GetDiceResults()
        {
            string results = "";
            int diceNumber = 1;
           
            // Bestem terningtypen (Almindelig Terning eller Mafia Terning).
            foreach (var dice in mDices)
            {
                string terningType;
                if (dice is MafiaDice)
                {
                    terningType = "Mafia Terning";
                }
                else
                {
                    terningType = "Almindelig Terning";
                }

                // Sammensæt resultatet for hver terning med terningnummer, terningtypen og antallet af øjne.
                results += $"Terning {diceNumber} ({terningType}): Øjne: {dice.Eyes}\n"; // Inkluder terningtypen i resultatet
                diceNumber++;
            }
            return results;
        }
    }
}
