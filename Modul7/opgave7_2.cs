using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul7
{
    internal class opgave7_2
    {
        public void Run()
        {
            Console.WriteLine("Indtast hvor mange almindelige terningerne vi skal have i bæret: ");
            int antalTerninger = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("Indtast hvor mange mafia terningerne vi skal have i bæret: ");
            int antalMafiaTerninger = Convert.ToInt32(Console.ReadLine());

            // Opret en instans af DiceCup med det angivne antal almindelige og Mafia-terninger.
            DiceCup diceCup = new DiceCup(antalTerninger, antalMafiaTerninger); // Brug korrekt variabelnavn

            // Rul terningerne
            diceCup.Roll();

            // Få det samlede resultat af øjne fra terningebægeret.
            int totalEyes = diceCup.GetTotalEyes();
            Console.WriteLine($"Samlet resultat: {totalEyes}");

            // Få resultaterne for hver terning i terningebægeret.
            string diceResults = diceCup.GetDiceResults();
            Console.WriteLine($"Resultater for terninger: \n{diceResults}");

        }
    }
}
