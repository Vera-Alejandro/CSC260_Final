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
        public bool StartGame { get; set; }
        public Game(Player player, Player AI)
        {
            StartGame = true;
            User = player;
            Opponent = AI;
        }

        public void PlayTurn()
        {

        }
        
        public void PlayToEnd()
        {

        }
    }
}
