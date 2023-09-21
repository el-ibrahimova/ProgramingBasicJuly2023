using System;

namespace _03.VtoriNachinZaReshavaneNaZad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
       
                // 1.Read input
                string flowerType = Console.ReadLine();
                int flowersCount = int.Parse(Console.ReadLine());
                int budget = int.Parse(Console.ReadLine());

                // "Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"

                // 2. Find price for a single flower
                double price = 0;
                double discount = 1;

                if (flowerType == "Roses") 
                { price = 5;
                    if (flowersCount > 80) { discount = 0.9; }
                }
                else if (flowerType == "Dahlias") 
                { price = 3.80;
                    if (flowersCount > 90) { discount = 0.85; }
                }
                else if (flowerType == "Tulips") 
                { price = 2.80;
                    if (flowersCount > 80) { discount = 0.85; }
                     }
                else if (flowerType == "Narcissus") 
                {
                    price = 3;
                    if (flowersCount < 120) { discount = 1.15;  }
                }
                else if (flowerType == "Gladiolus") 
                { price = 2.50;
                    if (flowersCount < 80) { discount = 1.2; }
                }

                double totalCost = flowersCount * price * discount;

                // 4. Print output
                if (budget >= totalCost)
                {
                    Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowerType} " +
                    $"and {budget - totalCost:f2} leva left.");
                }

                else if (budget < totalCost)
                {
                    Console.WriteLine($"Not enough money, you need {totalCost - budget:f2} leva more.");
                }

            }
        }
    }


