using System;

namespace _03.SumPrimeNonPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1st part
            // 1. Read input
            // 2. Determine if number is prime
            // 3. Print output
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("Number is negative.");
            }
            else
            {
                bool isPrime = true;
                if (number < 2)
                {
                    isPrime = false;
                }
                else
                {
                    double sqrt = Math.Sqrt(number);
                    for (int i = 2; i <= sqrt; i++)
                    {
                        if (number % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }
              
                Console.WriteLine(isPrime);
            }


            // 2nd part
            // 1. For each number chesk if it is prime
            // - keep track of the sum
            // 2. print output
        }
    }
}
