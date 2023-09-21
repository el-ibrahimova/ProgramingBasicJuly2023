using System;

namespace VelikdenskiObqd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read input
            int kozunaciBroi = int.Parse(Console.ReadLine());   
            int eggsPack = int.Parse(Console.ReadLine());
            int kurabiiKg = int.Parse(Console.ReadLine());

            // 2. Calculate
            double kozunaciPrice = kozunaciBroi * 3.2;
            double eggsPrice = eggsPack * 4.35;
            double kurabiiPrice = kurabiiKg * 5.4;
            double paint = eggsPack * 12 * 0.15;
            double total = kozunaciPrice + eggsPrice + kurabiiPrice + paint;
           
            // 3. Print output
            Console.WriteLine($"{total:F2}");
        }
    }
}
