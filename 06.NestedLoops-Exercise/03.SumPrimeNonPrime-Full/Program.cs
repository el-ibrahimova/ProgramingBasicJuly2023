using System;

namespace _03.SumPrimeNonPrime_Full
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1st part
            // 1. Read input
            // 2. Determine if number is prime
            // 3. Print output

            // 2nd part
            // 1. For each number chesk if it is prime
            // - keep track of the sum
            // 2. print output

            int primeSum=0, nonPrimeSum = 0;

            string input = Console.ReadLine();

            while (input != "stop")
            {

                int number = int.Parse(input);
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

                    if (isPrime)
                    {
                        primeSum += number;
                    }
                    else
                    {
                        nonPrimeSum += number;
                    }

                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
