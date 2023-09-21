using System;

namespace _09.FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read input
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double usedPercentage = double.Parse(Console.ReadLine());
            
            // 2. Calculate
            int volume = width * length * height;
            double capacityInLiters = volume * 0.001;

            double freeCapacity = capacityInLiters - (0.01 * usedPercentage * capacityInLiters); 
            // capacityInLiters * (1 - 0.01 * usedPercentage)
           

            // 3. Print output
            Console.WriteLine(freeCapacity); 
        }
    }
}
