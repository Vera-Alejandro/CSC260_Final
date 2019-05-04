using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip_FinalProject
{
    public class Game
    {
        public Player User { get; set; }
        public Player Opponent { get; set; }

        public Game(Player player1, Player player2)
        {
            User = player1;
            Opponent = player2;
        }

    }
}
