using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scissors_rock_and_paper.Game
{
    internal class GameModel
    {
        public int Id { get; set; }
        public int PlayerScore { get; set; }
        public int BotScore { get; set; }
        public int RoundsPlayed { get; set; }
        public string PlayerIpHashed { get; set; }

        public override string ToString()
        {
            return $" [Id]: {Id} - [Player score]: {PlayerScore} - [Bot score]: {BotScore} - [Rounds played]: {RoundsPlayed}";
        }
    }
}
