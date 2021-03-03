using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            while (x == 0)
            {
                Console.Clear();
                Console.Write("Choose your move (Rock (r), Paper (p), Scissors (s): ");
                char choice = Convert.ToChar(Console.ReadLine());
                Console.Clear();

                Random rnd = new Random();
                int randNum = rnd.Next(1, 4);
                // 1 is rock
                // 2 is paper
                //3 is scissors

                if (choice == 'r')
                {
                    if (randNum == 1)
                        Console.Write("Tie! :|\nComputer chose rock");

                    else if (randNum == 2)
                        Console.Write("You win! :)\nComputer chose rock");

                    else if (randNum == 3)
                        Console.Write("You lose! :(\nComputer chose rock");
                }

                else if (choice == 'p')
                {
                    if (randNum == 1)
                        Console.Write("You lose! :(\nComputer chose paper");

                    else if (randNum == 2)
                        Console.Write("Tie! :|\nComputer chose paper");

                    else if (randNum == 3)
                        Console.Write("You win! :)\nComputer chose paper");
                }

                else if (choice == 's')
                {
                    if (randNum == 1)
                        Console.Write("You won! :)\nComputer chose scissors");

                    else if (randNum == 2)
                        Console.Write("You lose! :(\nComputer chose scissors");

                    else if (randNum == 3)
                        Console.Write("Tie! :|\nComputer chose scissors");
                }

                Console.Write("\n\nDo you want to play again? (y/n) ");
                char playAgain = Convert.ToChar(Console.ReadLine());

                if (playAgain == 'y')
                    x = 0;

                else
                    x = 1;
            }
        }
    }
}
