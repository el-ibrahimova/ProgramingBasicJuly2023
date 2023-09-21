using System;

namespace PospalivataKotkaTom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int restDay = int.Parse(Console.ReadLine());

            int workDay = 365 - restDay;
            double playInWorkDay = workDay * 63;
            double playInRestDay = restDay * 127;
            double totalPlay = playInRestDay + playInWorkDay;


            if (totalPlay >= 30000)
            {
                double morePlay = totalPlay - 30000;
                double hours = morePlay / 60;
                double minutes = morePlay % 60;

                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{Math.Floor(hours)} hours and {Math.Floor(minutes)} minutes more for play");
            }

            else if (totalPlay < 30000)
            {
                double morePlay = 30000 - totalPlay;
                double hours = morePlay / 60;
                double minutes = morePlay % 60;

                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{Math.Floor(hours)} hours and {Math.Floor(minutes)} minutes less for play");
            }
            }
        }
    }

