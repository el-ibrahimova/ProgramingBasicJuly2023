using System;

namespace _02.BikeRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countJuniors = int.Parse(Console.ReadLine());
            int countSeniors = int.Parse(Console.ReadLine());
            string typeTrace = Console.ReadLine();

            double taxJuniors = 0;
            double taxSeniors = 0;
            
            switch (typeTrace)
            {
                case "trail": taxJuniors = countJuniors * 5.5;
                    taxSeniors = countSeniors * 7;
                    break;
                case "cross-country": taxJuniors = countJuniors * 8;
                    taxSeniors = countSeniors * 9.5;
                    break;
                case "downhill":
                    taxJuniors = countJuniors * 12.25;
                    taxSeniors = countSeniors * 13.75;
                    break;
                case "road":
                    taxJuniors = countJuniors * 20;
                    taxSeniors = countSeniors * 21.50;
                    break;
            }

            double totalTax = taxJuniors + taxSeniors;
            if (typeTrace == "cross-country" && countJuniors + countSeniors >= 50)
            {
                totalTax = totalTax - 0.25 * totalTax;
            }

            double costs = 0.05 * totalTax;

            Console.WriteLine($"{totalTax - costs:f2}"); 
        }
    }
}
