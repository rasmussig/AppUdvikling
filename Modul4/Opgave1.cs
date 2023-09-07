using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Modul4
{
    internal class Opgave1
    {

        public void Run()
        {

            Dice d = new Dice();

            int[] frequencies = new int[d.Size];

            int numberOfRolls = 1000000;

            for(int i = 0; i < numberOfRolls; i++)
            {
               d.Roll();
                int result = d.Eyes - 1;
                frequencies[result]++;
            }

            for(int i = 0 ; i < d.Size ; i++)
            {
                Console.WriteLine($"Tallet {1+i} er blevet sleået: {frequencies[i]} gange");
            }

        }

        public class Dice
        {
            private int size;
            private int eyes;
            private Random random;
            public Dice(int size = 6)
            {
                this.size = size;
                random = new Random();
                Roll();
            }

            public void Roll()
            {
                eyes = random.Next(1, size + 1);
            }

            public int Eyes
            {
                get
                {
                    return eyes;
                }
            }
            public int Size { get { return size; } }
        }


    }
}
