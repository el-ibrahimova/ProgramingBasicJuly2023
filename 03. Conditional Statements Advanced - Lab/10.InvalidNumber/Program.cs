﻿using System;

namespace _10.InvalidNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            bool isValid = (number >= 100 && number <= 200) || number ==0;

            if (!isValid)
            // if (!((number >= 100 && number <= 200) || number ==0)) - bez da se izpolzva buleva promenliva
            {
                Console.WriteLine("invalid");
            }

        }
    }
}
