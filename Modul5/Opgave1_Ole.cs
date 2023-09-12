using System;
namespace Modul5
{
    public class Opgave1_Ole
    {
        public void Run()
        {
            Console.WriteLine("Indtast karaktere, for at afslutte tast (-1)");

            var karakterListe = new List<int>();
            int i = 1;

            while (true)
            {
                Console.Write($"Intast karakter nr {i}: ");
                int grades = Convert.ToInt32(Console.ReadLine());
                if (grades == -1)
                {
                    break;
                } else
                {
                    karakterListe.Add(grades);
                    i++;
                }
            }
            var avg = karakterListe.Average();
            Console.WriteLine($"Gennemsnit: {avg}");
            // udskriver fordeling
            int[] allGrades = { -3, 0, 2, 4, 7, 10, 12 };

            foreach (var k in allGrades)
            {
                int count = CountGrades(k, karakterListe);
                Console.WriteLine($"Antal {k}: {count}");
            }
        }

        private int CountGrades(int grades, List<int> karakterListe)
        {
            int count = 0;
            foreach (int g in karakterListe)
            {
                if (g == grades)
                    count++;
            }
            return count;
            //return grades.Count(g => g == aGrade);
        }

    }

}