using Scissors_rock_and_paper.Data;
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

        public static void StatisticMenu(DataContext data, string IpAddress)
        {
            var AllGames = new List<GameModel>();
            foreach (var i in data.Game)
            {
                if(BCrypt.Net.BCrypt.Verify(IpAddress, i.PlayerIpHashed))
                {
                    AllGames.Add(i);
                }
            }
            if(AllGames.Any()) {
                Console.WriteLine(" All games you have played: ");
                AllGames.LogAll();
            }
            else
            {
                Say.Red("Error", "You don't have statistics yet!");
            }
        }

        public static void StartGame(DataContext data, string IpAddress)
        {
            string IpAddressHashed = BCrypt.Net.BCrypt.HashString(IpAddress);
            GameModel game = new GameModel() { PlayerIpHashed = IpAddressHashed};
            while (true)
            {
                try
                {
                    Custom.Line();
                    Console.WriteLine($" Player score: {game.PlayerScore} - Bot score: {game.BotScore}");
                    Say.Green("1", "Scissors");
                    Say.Green("2", "Rock");
                    Say.Green("3", "Paper");
                    Say.Red("Any", "End Session");
                    Console.Write(" Option: ");
                    int option = int.Parse(Console.ReadLine());
                    if (option == 1 || option == 2 || option == 3)
                    {
                        game.RoundsPlayed++;
                        int result = GameFunctions.Play(option - 1);
                        if (result == 0)
                        {
                            Say.Yellow("Game is:", "Tie", true);
                        }
                        if (result == 1)
                        {
                            Say.Green("Winner of round:", "Player", true);
                            game.PlayerScore++;
                        }
                        if (result == 2)
                        {
                            Say.Red("Winner of round:", "Bot", true);
                            game.BotScore++;
                        }
                    }
                    else
                    {
                        data.Game.AddToBase(data, game);
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
