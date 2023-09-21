using System;

namespace _01.PipesInPool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int obemV = int.Parse(Console.ReadLine());
            int trabaP1 = int.Parse(Console.ReadLine());
            int trabaP2 = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double P1Litri = trabaP1 * hours;
            double P2Litri = trabaP2 * hours;
            double total = P1Litri + P2Litri;

            if (total < obemV)
            { Console.WriteLine($"The pool is {(total/obemV)*100:f2}% full. Pipe 1: {(P1Litri / total)*100:f2}%. Pipe 2: {(P2Litri / total)*100:f2}%."); }

            else if (total >= obemV)
                    { Console.WriteLine($"For {hours} hours the pool overflows with {total - obemV:f2} liters."); }
                    

        }
    }
}
