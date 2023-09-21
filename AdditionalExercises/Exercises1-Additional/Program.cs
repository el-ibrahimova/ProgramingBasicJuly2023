using System;

namespace Exercises1_Additional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read input
            double flourPriceForKg = double.Parse(Console.ReadLine());
            double flourKg = double.Parse(Console.ReadLine());  
            double sugarKg = double.Parse(Console.ReadLine());  
            int eggsPack = int.Parse(Console.ReadLine());
            int yeastPack = int.Parse(Console.ReadLine());

            // 2. Calculate
            double sugarPrice = flourPriceForKg - flourPriceForKg * 0.25;
            double eggsPrice = flourPriceForKg + flourPriceForKg * 0.1;
            double yeastPrice = sugarPrice - sugarPrice * 0.8;
            double total = flourPriceForKg * flourKg + sugarPrice * sugarKg + eggsPrice * eggsPack + yeastPrice * yeastPack;

            // 3. Print output
            Console.WriteLine($"{total:F2}");
        }
    }
}
