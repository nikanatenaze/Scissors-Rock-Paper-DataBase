using Scissors_rock_and_paper.Design;
using Scissors_rock_and_paper.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scissors_rock_and_paper.Menu
{
    internal class GameMenu {
        public static void Start()
        {
            int playerScore = 0;
            int botScore = 0;
            int roundsPlayed = 0;
            while (true)
            {
                try
                {
                    Custom.Line();
                    Console.WriteLine($" Player score: {playerScore} - Bot score: {botScore}");
                    Say.Green("1", "Scissors");
                    Say.Green("2", "Rock");
                    Say.Green("3", "Paper");
                    Say.Red("Any", "End Session");
                    Console.Write(" Option: ");
                    int option = int.Parse(Console.ReadLine());
                    if (option == 1 || option == 2 || option == 3)
                    {
                        roundsPlayed++;
                        int result = GameFunctions.Play(option - 1);
                        if (result == 0)
                        {
                            Say.Yellow("Game is:", "Tie", true);
                        }
                        if (result == 1)
                        {
                            Say.Green("Winner of round:", "Player", true);
                            playerScore++;
                        }
                        if (result == 2)
                        {
                            Say.Red("Winner of round:", "Bot", true);
                            botScore++;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Say.Red("Error", $"Message: {ex.Message}");
                }
            }
        }
    }
}
