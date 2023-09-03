using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Modul2
{
    internal class Opgave4
    {
        public void Run()
        {
             bool IsPalindrom(string input)
            {
                int start = 0;
                int end = input.Length - 1;

                while (start < end)
                {
                    if (input[start] != input[end])
                    {
                        return false;
                    }
                    start++;
                    end--;
                }
                return true;
            }

            Console.WriteLine("Skriv en text, vi tjekker om det er et palindrom: ");
            string input = Console.ReadLine().ToLower();

            
        }
    }
}
