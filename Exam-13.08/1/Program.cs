using System;

namespace _1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fats = int.Parse(Console.ReadLine());
            int proteins = int.Parse(Console.ReadLine());
            int vagl = int.Parse(Console.ReadLine());
            int totalCalories = int.Parse(Console.ReadLine());
            int percentageWater = int.Parse(Console.ReadLine());


            double fatsGr = 0.01 * fats * totalCalories / 9;
            double proteinsGr = 0.01*proteins * totalCalories / 4;
            double vaglGr = 0.01 * vagl * totalCalories / 4;
            double totalFootGr = fatsGr + proteinsGr + vaglGr;
            double caloriesPerGr = totalCalories / totalFootGr;


            double calories = 0.01 * (100 - percentageWater) *caloriesPerGr;
            Console.WriteLine($"{ calories:f4}");
        

        }

    }
}

