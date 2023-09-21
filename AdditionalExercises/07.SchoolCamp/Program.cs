using System;

namespace _07.SchoolCamp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string typeOfGroup = Console.ReadLine();
            int countOfPupils = int.Parse(Console.ReadLine());
            int countOfOvernight = int.Parse(Console.ReadLine());

            double pricePerOvernight = 0;

            switch (season)
            {
                case "Winter":
                    if (typeOfGroup == "girls" || typeOfGroup == "boys") { pricePerOvernight = 9.6; }
                    else if (typeOfGroup == "mixed") { pricePerOvernight = 10; }
                    break;
                case "Spring":
                    if (typeOfGroup == "girls" || typeOfGroup == "boys") { pricePerOvernight = 7.2; }
                    else if (typeOfGroup == "mixed") { pricePerOvernight = 9.5; }
                    break;
                case "Summer":
                    if (typeOfGroup == "girls" || typeOfGroup == "boys") { pricePerOvernight = 15; }
                    else if (typeOfGroup == "mixed") { pricePerOvernight = 20; }
                    break;
            }
            double totalPrice = countOfOvernight * pricePerOvernight* countOfPupils;

            if (countOfPupils >= 50)
            { totalPrice = totalPrice - 0.5 * totalPrice; }
            else if (countOfPupils >= 20 && countOfPupils < 50)
            { totalPrice = totalPrice - 0.15 * totalPrice; }
            else if (countOfPupils >= 10 && countOfPupils < 20)
            { totalPrice = totalPrice - 0.05 * totalPrice; }

            string sport = "";
            
            switch (season)
            {
                case "Winter": if (typeOfGroup == "girls") { sport = "Gymnastics"; }
                    else if (typeOfGroup == "boys") { sport = "Judo"; }
                else if (typeOfGroup == "mixed") { sport = "Ski"; }
                    break;
                case "Spring":
                    if (typeOfGroup == "girls") { sport = "Athletics"; }
                    else if (typeOfGroup == "boys") { sport = "Tennis"; }
                    else if (typeOfGroup == "mixed") { sport = "Cycling"; }
                    break;
                case "Summer":
                    if (typeOfGroup == "girls") { sport = "Volleyball"; }
                    else if (typeOfGroup == "boys") { sport = "Football"; }
                    else if (typeOfGroup == "mixed") { sport = "Swimming"; }
                    break;
            }
            Console.WriteLine($"{sport} {totalPrice:f2} lv.");

        }
    }
}
