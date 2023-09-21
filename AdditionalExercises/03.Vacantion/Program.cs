using System;

namespace _03.Vacantion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string typeOfSet = "";
            double price = 0;
            string location = "";

            if (budget <= 1000) 
            { typeOfSet = "Camp";
                switch (season)
                {
                    case "Summer":  location = "Alaska"; price = 0.65 * budget; break;
                    case "Winter":  location = "Morocco"; price = 0.45 * budget; break;
                }
            }

            else if (budget > 1000 && budget <= 3000)
            {
                typeOfSet = "Hut";
                switch (season)
                {
                    case "Summer": location = "Alaska"; price = 0.8 * budget; break;
                    case "Winter": location = "Morocco";  price = 0.6 * budget; break;
                }
            }

           else  if (budget > 3000)
            {
                typeOfSet = "Hotel";
                switch (season)
                {
                    case "Summer": location = "Alaska"; price = 0.9 * budget; break;
                    case "Winter": location = "Morocco"; price = 0.9 * budget; break;
                }
            }

            Console.WriteLine($"{location} - {typeOfSet} - {price:f2}");
        }
    }
}
