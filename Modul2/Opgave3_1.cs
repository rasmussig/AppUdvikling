﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2
{
    internal class Opgave3_1
    {
        public void Run()
        {
            Console.WriteLine("Indtast mængde: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            if (amount >= 8)
            {
                int[] result = CalculateStamps(amount);

                Console.WriteLine($"Antal 5 cents frimærker: {result[0]}");
                Console.WriteLine($"Antal 3 cents frimærker: {result[1]}");
            }
            else
            {
                Console.WriteLine("Beløbet skal være mindst 8 cent for at beregne frimærker.");
            }
        }

        public int[] CalculateStamps(int amount)
        {
            int[] stamps = new int[2]; // Opretter et heltals array, med to elementer. Index 0: Antal 5 cents frimærker, Index 1: Antal 3 cents frimærker

            int maxStamps5 = amount / 5; // Maksimalt antal 5 cents frimærker uden rest 
                                         // (Integer divison også kaldet floor divison, runder altid ned.)
                                         // I dette eksempel vil 9/5 give 1.

            for (int s5 = maxStamps5; s5 >= 0; s5--) // Med eksemplet 9, ville den forløkke, først køre med s5 = 1, dog ville if sætningen ikke være opflydt, defor vil den herefter køre med s5= 0.
            {
                int remainingAmount = amount - (s5 * 5); 

                if (remainingAmount % 3 == 0)
                {
                    int stamps5 = s5;
                    int stamps3 = remainingAmount / 3;

                    stamps[0] = stamps5;
                    stamps[1] = stamps3;

                    return stamps;
                }
            }

            return stamps; // return [0, 0], hvis intet er fundet
        }
    }
}
