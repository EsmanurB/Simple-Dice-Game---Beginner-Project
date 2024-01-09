using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_Dice_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;

            int playerPoints =0;
            int enemyPoints =0;

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll the dice");
                Console.ReadKey();

                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("You  rolled a " + playerRandomNum);

                Console.WriteLine("");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("Enemy AI rolled a " + enemyRandomNum);

                if(playerRandomNum> enemyRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("player wins this round!");
                }
                else if (playerRandomNum< enemyRandomNum)
                {
                    enemyPoints++;
                    Console.WriteLine("enemy  wins this round!");
                }
                else {

                    Console.WriteLine("DRAW!");
                     
                        
                }
                Console.WriteLine("The score is now - player :" + playerPoints + ". Enemy :" + enemyPoints + ".");
                Console.WriteLine();


            }

            if (playerPoints > enemyPoints) 
            {
                Console.WriteLine("You win !");
                       
            }
            else if(enemyPoints > playerPoints)
            {
                Console.WriteLine("You lose !");

            }
            else
            {
                Console.WriteLine("it's a draw!");
            }


            Console.ReadKey();

        }
    }
}
