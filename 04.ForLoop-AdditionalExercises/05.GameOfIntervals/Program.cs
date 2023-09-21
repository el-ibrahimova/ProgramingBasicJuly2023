using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace _05.GameOfIntervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int steps = int.Parse(Console.ReadLine());
            int number;
            double points = 0;
            double p0 = 0, p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0;

            for (int i = 1; i <= steps; i++)
            {
                number = int.Parse(Console.ReadLine());
                
                if (number >= 0 && number <= 9) { points = points +0.2 * number; p0++; }
                else if (number >= 10 && number <= 19) { points = points + 0.3 * number; p1++; }
                else if (number >= 20 && number <= 29) { points = points + 0.4 * number; p2++; }
                else if (number >= 30 && number <= 39) { points = points + 50; p3++; }
                else if (number >= 40 && number <= 50) { points = points + 100; p4++; }
                else if (number < 0 || number > 50) { points = points / 2; p5++; }
                
            }

            Console.WriteLine($"{points:f2}");
            Console.WriteLine($"From 0 to 9: {100.0 * p0 / steps:f2}%");
            Console.WriteLine($"From 10 to 19: {100.0 * p1 / steps:f2}%");
            Console.WriteLine($"From 20 to 29: {100.0 * p2 / steps:f2}%");
            Console.WriteLine($"From 30 to 39: {100.0 * p3 / steps:f2}%");
            Console.WriteLine($"From 40 to 50: {100.0 * p4 / steps:f2}%");
            Console.WriteLine($"Invalid numbers: {100.0 * p5 / steps:f2}%");
        }
    }
}
