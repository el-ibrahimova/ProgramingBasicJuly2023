using System;

namespace _06.Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read input
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int diluent = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            // 2. Calculate material expenses
            double nylonPrice = (nylon + 2) * 1.5;
            double paintPrice = (paint + 0.1 * paint) * 14.5; // 1.1 * paint * 14.5;
            double diluentPrice = diluent * 5;
            double totalMaterialExpenses = nylonPrice + paintPrice + diluentPrice + 0.4;
            

            // 3. Calculate labor expenses
            double laborPricePerHour = totalMaterialExpenses * 0.3;
            double totalLaborPrice = laborPricePerHour * hours;

            // 4. Print output
            Console.WriteLine(totalMaterialExpenses + totalLaborPrice);
        }     
    }
}
