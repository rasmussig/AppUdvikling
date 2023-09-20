using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul7
{
    // MafiaDice-klassen er en arv fra klassen af Dice, der repræsenterer en Mafia-terning.
    public class MafiaDice : Dice
    {
        private Dice d;
            
        public MafiaDice()
        {
            d = new Dice();
        }

        // Roll() metoden med OVERRIDE! ændre rulningsadfærden for Mafia-terningen for at justere sandsynligheden for at få en 6.
        public override void Roll()
        {
            // Justerer tilfældigheden for at få en 6 højere end andre tal
            int randomNumber = random.Next(1, 11); // Generer et tilfældigt tal mellem 1 og 10

            if (randomNumber <= 4) // 4/10 chance for at få en 6 (40%)
            {
                eyes = 6;
            }
            else
            {
                eyes = random.Next(1, 6); // 6/10 chance for at få 1, 2, 3, 4 eller 5 (60%)
            }
        }

        public override int Eyes
        {
            get
            {
                return eyes;
            }
        }
        // public int Size { get { return size; } }
    }
}

