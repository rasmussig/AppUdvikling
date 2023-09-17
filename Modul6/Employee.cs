
using System;
namespace Modul6
{
    public class employee
    {
        public string name { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public decimal deduction { get; set; }
        public decimal drawPercentage { get; set; }
        public bool hasLunch { get; set; }
        public bool hasGiftBox { get; set; }
        public bool isFullTime { get; set; }

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
    }
}