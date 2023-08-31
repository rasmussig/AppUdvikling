using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Modul2
{
    internal class Algoritme
    {
        public void Run()
        {
            int FindMax(int[] a)
            {
                int max = a[0];
                int i = 1;
                while (i < a.Length)
                {
                    if (a[i] > max)
                    {
                        max = a[i];
                    }
                    i++;
                }
                return max;
            }

          

            int[] array2 = { 10, 20, 30, 40, 50 };
            int max2 = FindMax(array2);
            Console.WriteLine("Det største tal i array2 er: " + max2);

        }
    }
}
