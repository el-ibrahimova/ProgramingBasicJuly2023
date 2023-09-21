using System;

namespace _04.TouristShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            string product = Console.ReadLine();

            while (product != "Stop")
            { 
                 double productPrice = double.Parse(Console.ReadLine());
                 budget  -= productPrice;   
          
                 if (productPrice > budget)   { break; }

                for (int i = 0; i < budget; i+3)
                {
                    productPrice = 
                }
            }
        }
    }
}
