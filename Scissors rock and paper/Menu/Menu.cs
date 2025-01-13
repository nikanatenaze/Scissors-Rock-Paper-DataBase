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
    internal class Menu
    {
        public static void Start()
        {
            Background.TurnOn();
            Custom.Natenadze();
            string Ip = GameFunctions.GetIpAddress();
            if(Ip.Any())
            {
                while (true)
                {
                    DataContext data = new DataContext();
                    try
                    {
                        Custom.Line();
                        Say.Green("1", "Play game");
                        Say.Green("2", "Statistics");
                        Say.Green("3", "Credits");
                        Say.Red("Any", "Exit");
                        Console.Write(" Option: ");
                        int option = int.Parse(Console.ReadLine());
                        if (option == 1)
                        {
                            GameMenu.StartGame(data, Ip);
                        }
                        else if (option == 2)
                        {
                            GameMenu.StatisticMenu(data, Ip);
                        }
                        else if (option == 3)
                        {
                            Custom.Line();
                            Say.Green("Creator:", "Nikoloz Natenadze", true);
                            Say.Yellow("Git hub:", "https://github.com/nikanatenaze/Scissors-Rock-Paper-DataBase", true);
                            Say.Blue("Discord:", "nikanatenaze", true);
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
            else
            {
                Say.Red("Error", "Something went wrong with geting your Ip address");
            }
        }
    }
}
