using System;

namespace _04.ComputerFirm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfComputers = int.Parse(Console.ReadLine());
                 
            int countOfSales = 0;
             int rating = 0;
            double realSales = 0;

            for (int i = 1; i <=countOfComputers; i++)
            {
               int number = int.Parse(Console.ReadLine());
                                
                int possibleSales = number / 10; 
                
                if (number % 10 == 2)                { rating += 2;  realSales += 0;                       }
                else if (number %10  == 3)           { rating += 3;  realSales += possibleSales * 0.5;     }
                else if (number %10  == 4)           { rating += 4;  realSales += possibleSales * 0.7;     }
                else if (number %10  == 5)           { rating += 5;  realSales += possibleSales * 0.85;    }
                else if (number %10  == 6)           { rating += 6;  realSales += possibleSales * 1.0;      }

               countOfSales++;
                              
            }

            double average = 1.0 * rating / countOfComputers;
            Console.WriteLine($"{realSales:f2}");
            Console.WriteLine(average);
        }
    }
}
