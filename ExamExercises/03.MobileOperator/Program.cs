using System;

namespace _03.MobileOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string termOfContract = Console.ReadLine();
            string tipeOfContract = Console.ReadLine();
            string mobileInternet = Console.ReadLine();
            int countOfMounth = int.Parse(Console.ReadLine());

            double price = 0;

            if (termOfContract == "one")
            {
                switch (tipeOfContract)
                {
                    case "Small": price = 9.98; break;
                    case "Middle": price = 18.99; break;
                    case "Large": price = 25.98; break;
                    case "ExtraLarge": price = 35.99; break;
                }
            }
            else if (termOfContract == "two")
            {
                switch (tipeOfContract)
                {
                    case "Small": price = 8.58; break;
                    case "Middle": price = 17.09; break;
                    case "Large": price = 23.59; break;
                    case "ExtraLarge": price = 31.79; break;
                }
            }

            switch (mobileInternet)
            {
                case "yes":
                    if (price <= 10) { price += 5.50; }
                    else if (price <= 30) { price += 4.35; }
                    else if (price > 30) { price += 3.85; }
                    break;
            }


            double totalPrice = price * countOfMounth;
            if (termOfContract == "two")
            { totalPrice -= 0.01*3.75 * totalPrice; }

            
            Console.WriteLine($"{totalPrice:f2} lv.");
        }
    }
}
