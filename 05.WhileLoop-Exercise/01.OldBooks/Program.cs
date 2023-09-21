using System;

namespace _01.OldBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read input
            string bookToLookFor = Console.ReadLine();

            // 2. while te book is not found and there are more books to check it
            int checkedBooksCount = 0;
            bool isFound = false;
            string bookInput = Console.ReadLine();

            while (bookInput != "No More Books")
            { 
                if (bookInput == bookToLookFor)
                {
                    isFound = true;
                    break; 
                }
                checkedBooksCount++;
              bookInput = Console.ReadLine();          
            }

            // 3. Print outpu
            if (isFound)
            {
                Console.WriteLine($"You checked {checkedBooksCount} books and found it.");
            }
            else 
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {checkedBooksCount} books.");
            }
        }
    }
}
