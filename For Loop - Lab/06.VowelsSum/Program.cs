using System;

namespace _06.VowelsSum
{
    internal class Program
    {
        static void Main(string[] args)
        {

          //  буква      a   e   i   o   u
          // стойност    1   2   3   4   5

            string text = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a') { sum += 1; }
                else if (text[i] == 'e') { sum += 2; }
                else if (text[i] == 'i') { sum += 3; }
                else if (text[i] == 'o') { sum += 4; }
                else if (text[i] == 'u') { sum += 5; }
            }
            Console.WriteLine(sum);
        }
    }
}
