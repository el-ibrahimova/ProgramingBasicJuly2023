using System;

namespace _04.RentCar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string classOfCar = "";
            string type = "";
            double price = 0;

            if (budget <= 100)
            {
                classOfCar = "Economy class";
                switch (season)
                {
                    case "Summer": type = "Cabrio"; price = 0.35 * budget; break;
                    case "Winter": type = "Jeep"; price = 0.65; break;
                }
            }

            else if (budget > 100 && budget <= 500)
            {
                classOfCar = "Compact class";
                switch (season)
                {
                    case "Summer": type = "Cabrio"; price = 0.45 * budget; break;
                    case "Winter": type = "Jeep"; price = 0.8; break;
                }
            }

            else if (budget > 500)
            {
                classOfCar = "Luxury class";
                if (season == "Summer" || season == "Winter") { type = "Jeep"; price = 0.9 * budget; }
            }

            Console.WriteLine($"{classOfCar}");
            Console.WriteLine($"{type} - {price:f2}");

        }
    }
}
