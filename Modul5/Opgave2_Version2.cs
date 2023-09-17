using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul5
{
    internal class Opgave2_Version2
    {
        public void Run()
        {
            Console.WriteLine("Indtast hvor mange terningerne vi skal have i bæret: ");
            int antalTerninger = Convert.ToInt32(Console.ReadLine());

            DiceCup2 diceCup2 = new DiceCup2(antalTerninger);

            // Rul terningerne
            diceCup2.Roll();

            // Få det samlede resultat af øjne
            int totalEyes = diceCup2.GetTotalEyes();
            Console.WriteLine($"Samlet resultat: {totalEyes}");

            // Få resultaterne for hver terning
            string diceResults = diceCup2.GetDiceResults();
            Console.WriteLine($"Resultater for terninger: \n{diceResults}");
        }
    }
        
}
