using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Modul2
{
    internal class Opgave4
    { public void Run()
        {
            Console.WriteLine("Skriv et ord, vi tjekker om det er et palindrom: ");
            string input = Console.ReadLine();
            string cleanedInput = input.ToLower(); // Dette gør vi for at sikre, at alt er lowercase

            bool IsPalindrom (string s)
            {
                string cleanedInput = s.ToLower(); 
                string reversedInput = "";

                for (int i = cleanedInput.Length - 1; i >=0; i--)
                {
                    reversedInput += cleanedInput[i];
                }
                return cleanedInput == reversedInput;
            }
            
            if (IsPalindrom(cleanedInput))
            {
                Console.WriteLine("Dette er et palindrom!");
            }
            else
            {
                Console.WriteLine("Dette er ikke et palindrom.");
            }
        }
    }
}
