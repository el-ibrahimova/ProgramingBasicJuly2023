using System;

namespace _01.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read input
            string projectionType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());


            // 2. Calculate profit
            // - find ticket price
            // - calculate total profit (ticket price * all seats)

            double ticketPrice = 0;
            switch (projectionType)
            {
                case "Premiere": ticketPrice = 12; break;
                case "Normal": ticketPrice = 7.50; break;
                case "Discount": ticketPrice = 5; break;
            }

            // alternativno reshenie
           //  if (projectionType == "Premiere") { ticketPrice = 12; }
           //  else if (projectionType == "Normal") { ticketPrice = 7.50; }
           //  else if (projectionType == "Discount") { ticketPrice = 5; }

            double totalProfit = rows * cols * ticketPrice;

            // 3. Print output
            Console.WriteLine($"{totalProfit:f2} leva");

        }
    }
}
