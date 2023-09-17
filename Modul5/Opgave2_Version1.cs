using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul5
{
    internal class Opgave2_Version1
    {
        public void Run()
        {
            // Opret en instans af DiceCup
            DiceCup diceCup = new DiceCup();

            // Rul terningerne
            diceCup.Roll();

            // Få det samlede resultat af øjne
            int totalEyes = diceCup.GetTotalEyes();
            Console.WriteLine($"Samlet resultat: {totalEyes}");

            // Få resultaterne for hver terning
            string diceResults = diceCup.GetDiceResults();
            Console.WriteLine($"Resultater for terninger: \n{diceResults}");
        }
    }
}
