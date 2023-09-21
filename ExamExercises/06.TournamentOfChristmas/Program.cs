using System;

namespace _06.TournamentOfChristmas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double allMoney = 0;
            int winDayCounter = 0;
            int loseDayCounter = 0;
            

            for (int i = 0; i < days; i++)
            {
                int winCounter = 0;
                int loseCounter = 0;
                double currentDayMoney = 0;

                string nameOfGame = Console.ReadLine();


                while (nameOfGame != "Finish")
                {
                   
                    string winOrLose = Console.ReadLine();
                    if (winOrLose == "win")
                    {
                        currentDayMoney += 20;
                        winCounter++;
                    }
                    else if (winOrLose == "lose")
                    {
                        loseCounter++;

                    }
                                        
                    nameOfGame = Console.ReadLine();
                }

                if (winCounter > loseCounter)
                {
                    currentDayMoney = 1.1 * currentDayMoney; // currentDayMoney *= 1.1;
                    winDayCounter++;
                }
                else { loseDayCounter++; }

                allMoney += currentDayMoney;
            }

            bool isWonTournment = false;

            if (winDayCounter > loseDayCounter)
            {
                allMoney += allMoney * 0.2;
                isWonTournment = true;
            }

            if (isWonTournment)
            {
                Console.WriteLine($"You won the tournment! Total raised money: {allMoney:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournment! Total raised money: {allMoney:f2}");
            }
        }
    }
}
