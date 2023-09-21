using System;

namespace _05.AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double bankAccount = 0;

            while (input != "NoMoreMoney") 
            {
                double amountOfMoney = double.Parse(input);

                if (amountOfMoney < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                Console.WriteLine($"Increase: {amountOfMoney:f2}");
                bankAccount += amountOfMoney;

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total: {bankAccount:f2}");
        }
    }
}
