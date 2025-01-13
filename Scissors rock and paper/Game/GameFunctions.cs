using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Scissors_rock_and_paper.Game
{
    internal class GameFunctions
    {

        // 0 - Scissors
        // 1 - Rock
        // 2 - Paper
        public static int Play(int PlayerChoise)
        {
            int botChoise = Random.Shared.Next(0, 3);
            if(botChoise == PlayerChoise)
            {
                return 0;
            }
            else if (PlayerChoise == 1 && botChoise == 2 
                || PlayerChoise == 0 && botChoise == 2 
                || PlayerChoise == 2 && botChoise == 1)
            {
                return 1; // plyaer wins
            }
            else
            {
                return 2; // bot wins
            }
        }

        public static string GetIpAddress() // hmmm... it isn't place for this method but never mind
        {
            foreach(var i in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                if(i.AddressFamily == AddressFamily.InterNetwork)
                {
                    return i.ToString();
                }
            }
            return null;
        }
    }
}
