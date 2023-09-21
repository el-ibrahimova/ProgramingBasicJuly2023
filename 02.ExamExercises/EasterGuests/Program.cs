using System;

namespace EasterGuests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int guest = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double breadCount = Math.Ceiling(guest / 3.0);
            double breadCost = breadCount * 4;
            double eggCount = guest * 2;
            double eggCost = eggCount * 0.45;
            double totalCost = eggCost + breadCost;

            if (budget >= totalCost)
            {
                Console.WriteLine($"Lyubo bought { breadCount} Easter bread and { eggCount}eggs.");
                Console.WriteLine($"He has { budget-totalCost:f2} lv.left.");}
            
                else if (budget < totalCost)
                {
                    Console.WriteLine("Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {totalCost-budget:f2} lv.More.");
                }

            }
        }
}
