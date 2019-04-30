using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShip_FinalProject
{
    class GameBoard
    {
        //constructor
        public GameBoard()
        {
            //creats a new gameboard
            char[,] board = new char[10, 10];

            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    board[x, y] = 'E';
                }

            }

        }

       
        
        
        

    }
}
