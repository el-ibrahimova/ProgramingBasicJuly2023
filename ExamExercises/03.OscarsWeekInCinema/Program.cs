using System;

namespace _03.OscarsWeekInCinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfMovie = Console.ReadLine();
            string typeOfHall = Console.ReadLine();
            int countOfTicket = int.Parse(Console.ReadLine());

            double ticketPrice = 0;

            if (typeOfHall == "normal")
            {
                switch (nameOfMovie)
                {
                    case "A Star Is Born":  ticketPrice = 7.50; break;
                    case "Bohemian Rhapsody": ticketPrice = 7.35; break;
                    case "Green Book": ticketPrice = 8.15; break;
                    case "The Favourite": ticketPrice = 8.75; break;
                }
            }
            else if (typeOfHall == "luxury")
            {
                switch (nameOfMovie)
                {
                    case "A Star Is Born": ticketPrice = 10.50; break;
                    case "Bohemian Rhapsody": ticketPrice = 9.45; break;
                    case "Green Book": ticketPrice = 10.25; break;
                    case "The Favourite": ticketPrice = 11.55; break;
                }
            }
            else if (typeOfHall == "ultra luxury")
            {
                switch (nameOfMovie)
                {
                    case "A Star Is Born": ticketPrice = 13.50; break;
                    case "Bohemian Rhapsody": ticketPrice = 12.75; break;
                    case "Green Book": ticketPrice = 13.25; break;
                    case "The Favourite": ticketPrice = 13.95; break;
                }
            }

            Console.WriteLine($"{nameOfMovie} -> {countOfTicket*ticketPrice:f2} lv.");
        }
    }
}
