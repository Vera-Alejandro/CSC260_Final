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
    public class GameBoard
    {
        //create list of panels 
        public List<Panel> Panels { get; set; }

        //constructor
        public GameBoard()
        {
            //create a 2D list of panels
            Panels = new List<Panel>();

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Panels.Add(new Panel(i, j));
                }
            }
        }
    }

    ////greated but don't know if this will stay... needs modificaitons
    public class FiringBoard : GameBoard
    {
        //    //create Lists with cordinates and panels
        //    public List<Coordinates> GetOpenRandomPanels() { }
        //    public List<Coordinates> GetHitNeighbors() { }
        //    public List<Coordinates> GerNeighbors(Coordinates coordinates) { }
        //}


        //public Coordinates FireShot()
        //{

    }
}
