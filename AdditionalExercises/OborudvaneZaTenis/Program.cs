using System;

namespace OborudvaneZaTenis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;

namespace VelikdenskiObqd
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                // 1. Read input
                double priceFor1TennisRacket = double.Parse(Console.ReadLine());
                int broiTennisRacket = int.Parse(Console.ReadLine());
                int broiPairsOfShoes = int.Parse(Console.ReadLine());

                // 2. Calculate
                double tennisRacketPrice = priceFor1TennisRacket * broiTennisRacket;
                double priceFor1Shoes = tennisRacketPrice * (1.0 / 6);
                double priceForShoesAndRackets = tennisRacketPrice + broiPairsOfShoes * priceFor1Shoes;
                double accessories = priceForShoesAndRackets * 0.2;
                double total = priceForShoesAndRackets + accessories;
                double priceDjokovic = total * (1 / 8.0);
                double sponsors = total * (7 / 8.0);
                         

                // 3. Print output
                Console.WriteLine($"Price to be paid by Djokovic {priceDjokovic}");
                Console.WriteLine($"Price to be paid by sponsors {sponsors}");

            }
        }
    }

}
    

