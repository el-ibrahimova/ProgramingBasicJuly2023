using System;

namespace _03.Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int countOfCombination =0;
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    for (int k = 0; k <= n; k++)
                    {
                        int sum = i + j + k;
                        if (sum == n)
                        {
                            countOfCombination++;
                        }
                    }
                }
            }
            Console.WriteLine(countOfCombination);
        }
    }
}
