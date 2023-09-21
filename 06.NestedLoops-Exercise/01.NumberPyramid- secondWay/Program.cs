using System;

namespace _01.NumberPyramid__secondWay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool hasMoreRows = true;
            int currentNumber = 1;
            int row = 1;

            while (hasMoreRows)
            {
                for (int i = 0; i < row; i++)
                {
                    Console.Write($"{currentNumber} ");
                    if (currentNumber == n)
                    {
                        hasMoreRows = false;
                        break;
                    }
                    currentNumber++;
                }
                row++;
                Console.WriteLine();

            }
        }
    }
}
