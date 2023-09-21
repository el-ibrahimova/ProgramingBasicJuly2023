using System;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int num = 0;
            int maxNum = int.MinValue;
            int sum = 0;

            for (int i = 0; i <=n; i++)
            {
                num = int.Parse(Console.ReadLine());
                if (num > maxNum)
                {
                    num = maxNum;
                }

                sum += num;
            }
            sum -= maxNum;
        }
    }
}
