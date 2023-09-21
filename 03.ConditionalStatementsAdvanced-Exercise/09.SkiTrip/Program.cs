using System;

namespace _09.SkiTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string rate = Console.ReadLine();

            int dayForPay = day - 1;
            double pricePerDay = 0;

            switch (typeOfRoom)
            {
                case "room for one person": pricePerDay = 18;     break;
                case "apartment": pricePerDay = 25; break;
                case "president apartment": pricePerDay = 35; break;
            }

            double total = dayForPay * pricePerDay;

            if (dayForPay < 10) 
                switch (typeOfRoom)
                {
                    case "room for one person": total = dayForPay * pricePerDay; break;
                    case "apartment": total = total - 0.3 * total; break;
                    case "president apartment": total = total - 0.1 * total; break;
                }
            else if (dayForPay >= 10 && dayForPay < 15)
                switch (typeOfRoom)
                {
                    case "room for one person": total = dayForPay * pricePerDay; break;
                    case "apartment": total = total - 0.35 * total; break;
                    case "president apartment": total = total - 0.15 * total; break;
                }
            else if (dayForPay >= 15)
                switch (typeOfRoom)
                {
                    case "room for one person": total = dayForPay * pricePerDay; break;
                    case "apartment": total = total - 0.5 * total; break;
                    case "president apartment": total = total - 0.2 * total; break;
                }

            if (rate == "positive") { total = total + 0.25 * total; }
            else if (rate == "negative") { total = total - 0.1 * total; }

            Console.WriteLine($"{total:f2}");

        }
    }
}
