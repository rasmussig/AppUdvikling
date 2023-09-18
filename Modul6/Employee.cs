
using System;
namespace Modul6
{
    public class employee: IComparable<employee>
    {
        public string name { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public decimal deduction { get; set; }
        public decimal drawPercentage { get; set; }
        public bool hasLunch { get; set; }
        public bool hasGiftBox { get; set; }
        public bool isFullTime { get; set; }

        // Opgave 7.1
        public int CompareTo(employee other)
        {
            if (other == null)
            {
                return 1; // Eller en anden passende værdi, hvis du vil håndtere null-tilfælde.
            }
            return string.Compare(this.name, other.name, StringComparison.OrdinalIgnoreCase);
        }

        // Opgave b) Metode til udskrivning af lønseddel
        public virtual void PrintPaySlip()
        {
            Console.WriteLine($"Navn: {name}");
            Console.WriteLine($"Adresse: {address}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Fradrag: {deduction}");
            Console.WriteLine($"Trækprocent: {drawPercentage}%");
            Console.WriteLine($"Frokostordning: {(hasLunch ? "Ja" : "Nej")}");
            Console.WriteLine($"Gavekasse: {(hasGiftBox ? "Ja" : "Nej")}");
        }

        // c) Skriv en funktion som tager en liste af ansatte som input parameter, og som returnerer hvor meget skat de tilsammen skal betale.
        public virtual decimal PrintTax ()
        {
            return 0;
        }
    }
}