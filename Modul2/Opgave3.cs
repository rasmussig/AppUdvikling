using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2
{
    internal class Opgave3
    { public void Run()
        {
            Console.WriteLine("Indtast porto beløb (mindst 8 cent)");
            int portoBeløb = Convert.ToInt32(Console.ReadLine());

            if(portoBeløb < 8 )
            {
                Console.WriteLine("Porto beløbet skal være mindt 8 cent");
            } else
            {
                int antalFemCent = 0;
                int antalTreCent = 0;

                while (portoBeløb >= 5) {
                    portoBeløb -= 5;
                    antalFemCent++;

                } if (portoBeløb == 1)
                {
                    portoBeløb += 5;
                    antalFemCent--;
                    antalTreCent +=2;

                } else if(portoBeløb == 2)
                {
                    portoBeløb += 5;
                    antalFemCent-=2;
                    antalTreCent+=4;

                } else if(portoBeløb == 3)
                {
                    antalTreCent++;

                } else if(portoBeløb == 4)
                {
                    portoBeløb += 5;
                    antalFemCent-= 1;
                    antalTreCent+= 3;

                } Console.WriteLine($"Antal 5 cent frimærker: {antalFemCent}");
                  Console.WriteLine($"Antal 3 cent frimærker: {antalTreCent}");
            }
        }
    }
}
