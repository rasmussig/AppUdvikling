using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace Modul5
{
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
