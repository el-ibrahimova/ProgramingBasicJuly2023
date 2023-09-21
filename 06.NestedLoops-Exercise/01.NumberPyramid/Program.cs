using System;

namespace _01.NumberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.Read input
            int n = int.Parse(Console.ReadLine());

            // 2. Print pyramid
            // - we need a variable to know which line we are writing to
            // - we need a variable to know which position we are writing to

            int row = 1;
            int position = 1;

            for (int i = 1; i <= n; i++)
            {
                Console.Write(i);
                if (position == row)
                {
                    Console.WriteLine();
                    row++;
                    position = 1;
                }
                else
                {
                    Console.Write(' ');
                    position++;
                }


            }
        }
    }
}
