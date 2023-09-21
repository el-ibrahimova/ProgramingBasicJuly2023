using System;

namespace _03.Flowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countChrisantemas = int.Parse(Console.ReadLine());
            int countRoses = int.Parse(Console.ReadLine()); 
            int countTulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holiday = Console.ReadLine();

            double priceChrisantemas = 0;
            double priceRoses = 0;
            double priceTulips = 0;

            if (season == "Spring" || season == "Summer")
            {
                priceChrisantemas = 2;
                priceRoses = 4.1;
                priceTulips = 2.5;
            }
            else if (season == "Autumn" || season == "Winter")
            {
                priceChrisantemas = 3.75;
                priceRoses = 4.5;
                priceTulips = 4.15;
            }

            if (holiday == "Y")
            {
                priceChrisantemas = priceChrisantemas + 0.15 * priceChrisantemas;
                priceRoses = priceRoses + 0.15 * priceRoses;
                priceTulips = priceTulips + 0.15 * priceTulips;
            }

            double priceBouquet = countChrisantemas * priceChrisantemas + countRoses * priceRoses 
                + countTulips * priceTulips;
            if (countTulips > 7 && season == "Spring")
            {
                priceBouquet = priceBouquet - 0.05 * priceBouquet;
            }
            
            if (countRoses >= 10 && season == "Winter")
            {
                priceBouquet = priceBouquet - 0.1 * priceBouquet;
            }
           
            if ((countChrisantemas + countRoses + countTulips) > 20 && (season == "Spring" || season == "Summer"
                || season == "Autumn" || season == "Winter"))
            {
                priceBouquet = priceBouquet - 0.2 * priceBouquet;
            }

            Console.WriteLine($"{priceBouquet+2:f2}");



        }
    }
}
