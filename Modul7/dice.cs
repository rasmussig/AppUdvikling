using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace Modul7
{

        public class Dice
        {
            public int size;
            public int eyes;
            public Random random;
            
        // Konstruktøren initialiserer en terning med en given størrelse (standardstørrelse er 6).
            public Dice(int size = 6)
            {
                this.size = size;
                random = new Random();               
            }

            public virtual void Roll()
            {
                eyes = random.Next(1, size + 1);
            }

            public virtual int Eyes
            {
                get
                {
                    return eyes;
                }
            }           
        }
   
}
