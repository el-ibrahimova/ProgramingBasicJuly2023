using System;
using System.ComponentModel.DataAnnotations;

namespace _05.Club
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double desiredProfit = double.Parse(Console.ReadLine());

           double  coctailPrice = 0;
            double sum = 0;

            string coctailName = Console.ReadLine();

            while (coctailName != "Party!")
            {
                int countOfCoctails = int.Parse(Console.ReadLine());

                coctailPrice = coctailName.Length * countOfCoctails;

                if (coctailPrice % 2 == 1)
                {
                    coctailPrice -= 0.25 * coctailPrice; 
                }

                sum += coctailPrice;

                if (sum >= desiredProfit)
                { break; }
               
                coctailName = Console.ReadLine();
            }

            if (desiredProfit > sum)
            {
                Console.WriteLine($"We need {desiredProfit - sum:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Target acquired.");
            }
            Console.WriteLine($"Club income - {sum:f2} leva.");





        }
    }
}
