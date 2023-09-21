using System;
using System.ComponentModel.Design;
using System.Threading.Channels;

namespace _06.OperationsBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string mathSimbol = Console.ReadLine();

            switch (mathSimbol)
            {
                case "+": 
                    int sum = n1 + n2;
                    if (sum % 2 == 0)
                    { Console.WriteLine($"{n1} + {n2} = {sum} - even"); }
                    else { Console.WriteLine($"{n1} + {n2} = {sum} - odd"); }
                    break;

                case "-":
                    int diff = n1 - n2;
                    if (diff % 2 == 0)
                    { Console.WriteLine($"{n1} - {n2} = {diff} - even"); }
                    else { Console.WriteLine($"{n1} - {n2} = {diff} - odd"); }
                    break;

                case "*":
                    int produkt = n1 * n2;
                    if (produkt % 2 == 0)
                    { Console.WriteLine($"{n1} * {n2} = {produkt} - even"); }
                    else { Console.WriteLine($"{n1} * {n2} = {produkt} - odd"); }
                    break;

                case "/":
                    double result = n1*1.0/ n2;
                    if (n2 == 0)
                    { Console.WriteLine($"Cannot divide {n1} by zero"); }
                    else { Console.WriteLine($"{n1} / {n2} = {result:f2}"); }
                    break;

                case "%":
                    double modul = n1*1.0 % n2;
                    if (n2 == 0)
                    { Console.WriteLine($"Cannot divide {n1} by zero"); }
                    else { Console.WriteLine($"{n1} % {n2} = {modul}"); }
                    break;
            }

        }
    }
}
