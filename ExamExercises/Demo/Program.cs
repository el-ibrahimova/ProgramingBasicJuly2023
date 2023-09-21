using System;
using System.Numerics;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string firstPlayerName = Console.ReadLine();
            string secondPlayerName = Console.ReadLine();

            int firstPlayerPoint = 0;
            int secondPlayerPoint = 0;

            int totalFirst = 0, totalSecond = 0;
            int firstPlayerCard = 0;
            int secondPlayerCard = 0;


                while (firstPlayerName != "End of game" )
            {
                firstPlayerCard = int.Parse(firstPlayerName);
                secondPlayerCard = int.Parse(secondPlayerName);

                if (firstPlayerCard == secondPlayerCard)
                {
                    firstPlayerCard = int.Parse(firstPlayerName);
                    secondPlayerCard = int.Parse(secondPlayerName);
                    break;
                }

               if (firstPlayerCard > secondPlayerCard)
                {
                    firstPlayerPoint = firstPlayerCard - secondPlayerCard;
                    totalFirst += firstPlayerPoint;
                }
                else if (secondPlayerCard > firstPlayerCard)
                {
                    secondPlayerPoint = secondPlayerCard - firstPlayerCard;
                    totalSecond += secondPlayerPoint;
                }
              
                firstPlayerCard = int.Parse(firstPlayerName);
                secondPlayerCard = int.Parse(secondPlayerName);
            }

            if (firstPlayerCard == secondPlayerCard)
            {
                Console.WriteLine("Number wars");
                if (firstPlayerCard > secondPlayerCard)
                {
                    Console.WriteLine($"{firstPlayerName} is winner with {firstPlayerCard-secondPlayerCard} points");
                }
                else 
                {
                    Console.WriteLine($"{secondPlayerName} is winner with {secondPlayerCard-firstPlayerCard} points");
                }
            }
            if (firstPlayerName == "End of game")
            {
               Console.WriteLine($"{firstPlayerName} has {totalFirst} points");
                Console.WriteLine($"{secondPlayerName} has {totalSecond} points");
            }
                
             
        }
    }
}
