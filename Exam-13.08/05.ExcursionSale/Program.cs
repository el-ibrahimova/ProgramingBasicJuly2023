using System;
using System.Runtime.InteropServices;

namespace _05.ExcursionSale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int seaExcursion = int.Parse(Console.ReadLine());
            int mountainExcursion = int.Parse(Console.ReadLine());

            double priceSea = 0;
            double priceMountain = 0;

            double total = 0;

            string input = Console.ReadLine();

            while (input != "Stop")
            {
                if ((seaExcursion + mountainExcursion) < 0) { break; }

                if (input == "sea")
                {
                    seaExcursion--;
                    if (seaExcursion < 0) { priceSea += 0; }
                    else                {  priceSea += 680; }
                }

                else if (input == "mountain")
                {
                    mountainExcursion--;
                    if (mountainExcursion < 0) { priceMountain += 0; }
                    else                    {   priceMountain += 499; }
                }
                 total = priceSea + priceMountain;
                
                            

                input = Console.ReadLine();
            }

            if (seaExcursion == 0 || mountainExcursion == 0)
            {
                
                Console.WriteLine($"Profit: {total} leva.");
            }
            else
            {
                Console.WriteLine($"Good job! Everything is sold.");
                Console.WriteLine($"Profit: {total} leva.");
            }

        }
    }
}
