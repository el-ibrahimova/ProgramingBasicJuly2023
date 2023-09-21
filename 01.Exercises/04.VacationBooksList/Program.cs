using System;

namespace _04.VacationBooksList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bookPages = int.Parse(Console.ReadLine());
            int pagesForHour = int.Parse(Console.ReadLine());
            int days  = int.Parse(Console.ReadLine());

            int totalHours = bookPages / pagesForHour;
           // int hoursForDay = totalHours / days;

            Console.WriteLine(totalHours/days);
        }
    }
}
