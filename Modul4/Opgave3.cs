using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4
{
    internal class Opgave3
    {
        public void Run()
        {
                LottoDice lottoTerning = new LottoDice(35); // Angiv det maksimale nummer, f.eks. 35

                // Træk lottonumre indtil der ikke er flere tilbage
                while (lottoTerning.MaksNummer > 0)
                {
                    int trukketNummer = lottoTerning.Nummer;
                    Console.WriteLine($"Lottonummer: {trukketNummer}");
                    lottoTerning.TrækNummer();
                }

                // Nulstil for at trække igen
                lottoTerning.Nulstil();
            }
        
    }
}
