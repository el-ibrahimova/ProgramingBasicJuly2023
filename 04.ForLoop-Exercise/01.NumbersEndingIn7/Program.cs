using System;

namespace _01.NumbersEndingIn7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // proverqvame napravo ot 7 (i do 997) za da spestim mqsto i vreme
            for (int i = 7; i <= 997; i++) 
            {
                if (i % 10 == 7) 
                { 
                    Console.WriteLine(i); 
                }
            }
        }
    }
}
