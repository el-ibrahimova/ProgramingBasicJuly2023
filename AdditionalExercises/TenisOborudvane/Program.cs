using System;

namespace TenisOborudvane
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            double priceFor1TennisRacket = double.Parse(Console.ReadLine());
            int broiTennisRacket = int.Parse(Console.ReadLine());
            int broiPairsOfShoes = int.Parse(Console.ReadLine());

            // 2. Calculate
            double tennisRacketPrice = priceFor1TennisRacket * broiTennisRacket;
            double priceFor1Shoes = priceFor1TennisRacket * (1.0 / 6);
            double priceForShoesAndRackets = tennisRacketPrice + broiPairsOfShoes * priceFor1Shoes;
            double accessories = priceForShoesAndRackets * 0.2;
            double total = priceForShoesAndRackets + accessories;
            double priceDjokovic = total * (1 / 8.0);
            double sponsors = total * (7 / 8.0);


            // 3. Print output
            Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(priceDjokovic)}");
            Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(sponsors)}");
        }
    }
}
