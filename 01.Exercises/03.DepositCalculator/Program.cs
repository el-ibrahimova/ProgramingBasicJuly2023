using System;

namespace _03.DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read input (deposit sum, deposit term, interest rate)
            double depositSum = double.Parse(Console.ReadLine());
            int depositTerm = int.Parse(Console.ReadLine());
            double interestRate = double.Parse(Console.ReadLine());

            // Calculate using the given formula
            //сума = депозирана сума  + срок на депозита * ((депозирана сума * годишен лихвен процент ) / 12)
            double result = depositSum + depositTerm * ((depositSum * interestRate * 0.01) / 12);

            // Print output
            Console.WriteLine(result);

        }
    }
}
