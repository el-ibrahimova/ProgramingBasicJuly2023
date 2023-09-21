using System;

namespace SerialsCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read input
            string Name = Console.ReadLine();
            int broiSezoni = int.Parse(Console.ReadLine());
            int broiEpizodi = int.Parse(Console.ReadLine());
            double vremetraeneBezReklami = double.Parse(Console.ReadLine());

            // 2. Calculate
            double reklama = vremetraeneBezReklami * 0.2;
            double epizodSReklami = vremetraeneBezReklami + reklama;
            double specialniEpizodi = broiSezoni * 10;
            double total = broiEpizodi * broiSezoni * epizodSReklami + specialniEpizodi;

            // 3. Read output
            Console.WriteLine($"Total time needed to watch {Name} series is {total} minutes");



        }
    }
}
