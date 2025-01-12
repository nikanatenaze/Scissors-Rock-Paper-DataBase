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
            while (true)
            {
                try
                {
                    Custom.Line();
                    Say.Green("1", "Start");
                    Say.Green("2", "Statistics");
                    Say.Red("Any", "Exit");
                    Console.Write(" Option: ");
                    int option = int.Parse(Console.ReadLine());
                    if(option == 1)
                    {
                        GameMenu.Start();
                    }
                    else if(option == 2) 
                    {

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
