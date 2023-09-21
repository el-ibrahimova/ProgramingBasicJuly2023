using System;

namespace _01.Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int high = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int percentageNotColoring = int.Parse(Console.ReadLine());

            int area = 4 * high * length;
            double areaForPainting = Math.Ceiling(0.01 * (100 - percentageNotColoring) * area);

            string input = Console.ReadLine();

            while (input != "Tired!")
            {
                int paintInLitres = int.Parse(input);
                areaForPainting -= paintInLitres;
                
                if (areaForPainting <= 0) { break; }

                input = Console.ReadLine();

            }

            if (areaForPainting > 0)
            {
                Console.WriteLine($"{areaForPainting} quadratic m left.");
            }
            else if (areaForPainting < 0)
            {
                Console.WriteLine($"All walls are painted and you have {Math.Abs(areaForPainting)} l paint left!");
            }
            else
            {
                Console.WriteLine($"All walls are painted! Great job, Pesho!");
            }

            

        }
    }
}
