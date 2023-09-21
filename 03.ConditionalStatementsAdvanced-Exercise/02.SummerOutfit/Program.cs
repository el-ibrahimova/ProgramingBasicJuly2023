using System;

namespace _02.SummerOutfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read input
            int degrees = int.Parse(Console.ReadLine());
            string partOfDay = Console.ReadLine();

            // 2. Find appropriate outfit and

            string outfit = "";
            string shoes = "";

            if (degrees >= 10 && degrees <= 18)
            {
                // find all values in first row
                if (partOfDay == "Morning") { outfit = "Sweatshirt"; shoes = "Sneakers"; }
                else if (partOfDay == "Afternoon" || partOfDay == "Evening")
                { outfit = "Shirt"; shoes = "Moccasins"; }
            }  

            if (degrees > 18 && degrees <= 24)
            {
                // find all values in second row
                if (partOfDay == "Morning" || partOfDay == "Evening")   
                    { outfit = "Shirt";       shoes = "Moccasins"; }
                else if (partOfDay == "Afternoon")   { outfit = "T-Shirt";     shoes = "Sandals"; }
            }

            if (degrees >= 25)
            {
                // find all values in third row
                if (partOfDay == "Morning")          { outfit = "T-Shirt";     shoes = "Sandals"; }
                else if (partOfDay == "Afternoon")   { outfit = "Swim Suit";   shoes = "Barefoot"; }
                else if (partOfDay == "Evening")     { outfit = "Shirt";       shoes = "Moccasins"; }
            }

            // 3. Print output
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");


        }
    }
}
