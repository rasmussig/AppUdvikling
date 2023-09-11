using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Modul4
{
    internal class Opgave2
    {
        public void Run()
        {

            MafiaDice d = new MafiaDice();

            int[] frequencies = new int[d.Size];

            int numberOfRolls = 1000000;

            for (int i = 0; i < numberOfRolls; i++)
            {
                d.Roll();
                int result = d.Eyes - 1;
                frequencies[result]++;
            }

            for (int i = 0; i < d.Size; i++)
            {
                Console.WriteLine($"Tallet {1 + i} er blevet sleået: {frequencies[i]} gange");
            }

        }


    }
}
