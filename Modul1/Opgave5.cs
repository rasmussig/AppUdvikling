﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1
{
    internal class Opgave5
    {
        public void Run()
        {
            Console.WriteLine("----------");
            Console.WriteLine("Opgave 5.1: \n");
            for (int i = 0; i < 10; i++)
            {
                string output = "";

                for (int j = 0; j < 10; j++)
                {
                    output = output + "*";
                }

                Console.WriteLine(output);
            }

            // 5.2)

            Console.WriteLine("\nOpgave 5.2: \n");
            for (int i = 0; i < 10; i++)
            {
                string output = "";
                for (int j = i; j < 10; j++)
                {
                    output = output + "*";
                }
                Console.WriteLine(output);
            }

            // 5.3)

            Console.WriteLine("\nOpgave 5.3: \n");
            for (int i = 0; i < 10; i++)
            {
                string output = "";
                for (int j = 0; j < i + 1; j++)
                {
                    output = output + "*";
                }
                Console.WriteLine(output);
            }

            // 5.4)

            Console.WriteLine("\nOpgave 5.4: \n");
            for (int i = 0; i < 10; i++)
            {
                string output = "";
                for (int j = 0; j < 10 - i; j++)
                {
                    output += " ";
                }
                for (int k = 0; k < i + 1; k++)
                {
                    output += "*";
                }
                Console.WriteLine(output);
            }

            // 5.5)
            Console.WriteLine("\nOpgave 5.5: \n");
            for (int i = 0; i < 10; i++)
            {
                string output = "";
                for (int j = 0; j < i; j++)
                {
                    output += " ";
                }
                for (int k = 0; k < 10 - i; k++)
                {
                    output += "*";
                }
                Console.WriteLine(output);
            }

            Console.WriteLine("\n ----------");
        }
    }
}

