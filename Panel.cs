using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip_FinalProject
{

    //this will take care of the Game 
    //this will be able to see what the ships and gameboard can do.
    public class Panel
    {

        public Coordinates Coordinates { get; set; }
        public ShipType ShipType { get; set; }

        public Panel (int row, int column)
        {
            Coordinates = new Coordinates(row, column);
            ShipType = ShipType.Empty;
        }

        public bool IsOccupied
        {
            get
            {
                return ShipType == ShipType.Carrier
                    || ShipType == ShipType.Battleship
                    || ShipType == ShipType.Cruiser
                    || ShipType == ShipType.Submarine
                    || ShipType == ShipType.Destoryer;
            }
        }

 

        //I don't know if I will use this but I'll code it up anyway
        /*
         public bool IsRandomAvaliable
        {
            get
            {
                return  (Coordinates.Row % 2 == 0 && Coordinates.Column % 2 == 0)
                        ||
                        (Coordinates.Row % 2 == 1 && Coordinates.Column % 2 == 1);
            }
        }
         */
    }
}
