using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4
{
    public class MafiaDice
    {
        private int size;
        private int eyes;
        private Random random;
        public MafiaDice(int size = 6)
        {
            this.size = size;
            random = new Random();
            Roll();
        }

        public void Roll()
        {
            // Justerer tilfældigheden for at få en 6 højere end andre tal
            int randomNumber = random.Next(1, 11); // Generer et tilfældigt tal mellem 1 og 10

            if (randomNumber <= 2) // 2/10 chance for at få en 6 (20%)
            {
                eyes = 6;
            }
            else
            {
                eyes = random.Next(1, 6); // 4/10 chance for at få 1, 2, 3, 4 eller 5 (40%)
            }
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

