using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul5
{
    public class DiceCup
    {
        private List<Dice> mDices;
        public DiceCup()
        {
            mDices = new List<Dice>
            {
                new Dice();
                new Dice();
            }
        }
    }
}
