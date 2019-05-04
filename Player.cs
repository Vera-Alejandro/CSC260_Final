using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip_FinalProject
{
    public class Player 
    {
        public string PName { get; set; }
        public GameBoard GameBoard { get; set; }
        public FiringBoard FiringBoard { get; set; }
        public Carrier Carrier { get; set; }
        public Battleship Battleship { get; set; }
        public Cruiser Cruiser { get; set; }
        public Submarine Submarine { get; set; }
        public Destroyer Destroyer { get; set; }
        public bool CarrierPlaced { get; set; }
        public bool BattleshipPlaced { get; set; }
        public bool CruiserPlaced { get; set; }
        public bool SubmarinePlaced { get; set; }
        public bool DestroyerPlaced { get; set; }
        public bool CarrierActive { get; set; }
        public bool BattleshipActive { get; set; }
        public bool CruiserActive { get; set; }
        public bool SubmarineActive { get; set; }
        public bool DestroyerActive { get; set; }
        public bool ShipsPlaced
        {
            get
            {
                return CarrierPlaced
                    && BattleshipPlaced
                    && CruiserPlaced
                    && SubmarinePlaced
                    && DestroyerPlaced;
            }
        }


        //checks all the list to see if they are all sunk.
        //if all sunk then return true because the player has lost
        public bool Lost
        {
            get
            {
                return Carrier.IsSunk
                    && Battleship.IsSunk
                    && Cruiser.IsSunk
                    && Submarine.IsSunk
                    && Destroyer.IsSunk;
            }
        }

        //constructor
        public Player(string name)
        {
            //import the Player Name
            PName = name;

            //create a collection of ships
            Carrier = new Carrier();
            CarrierPlaced = false;
            CarrierActive = true;

            Battleship = new Battleship();
            BattleshipPlaced = false;
            BattleshipActive = false;

            Cruiser = new Cruiser();
            CruiserPlaced = false;
            CruiserActive = false;

            Submarine = new Submarine();
            SubmarinePlaced = false;
            SubmarineActive = false;

            Destroyer = new Destroyer();
            DestroyerPlaced = false;
            DestroyerActive = false;

            //Create Gameboard and FiringBoard for Player Use
            GameBoard = new GameBoard();
            FiringBoard = new FiringBoard();
        }





        //placing ships
        public bool PlaceShip(int row, int column, Player player0, ShipType PlaceShip)
        {
            int location = ((row - 1) * 10) + ((column % 10) - 1);
            int shipWidth = 11;

            switch (PlaceShip)
            {
                case ShipType.Carrier:
                    shipWidth = Carrier.Width;
                    break;
                case ShipType.Battleship:
                    shipWidth = Battleship.Width;
                    break;
                case ShipType.Submarine:
                    shipWidth = Submarine.Width;
                    break;
                case ShipType.Cruiser:
                    shipWidth = Cruiser.Width;
                    break;
                case ShipType.Destoryer:
                    shipWidth = Destroyer.Width;
                    break;
            }

            //check if the button press is a value placment option
            if (!(player0.GameBoard.Panels[location].IsOccupied))
            {
                if(player0.GameBoard.Panels.Count < (location + shipWidth))
                {
                    return false;
                }

                //check if there is space on the board to fit the ship
                for (int panelcheck = 1; panelcheck < shipWidth; panelcheck++)
                {

                    //checks if panel is free or if location moved to a new row
                    if (player0.GameBoard.Panels[location + panelcheck].IsOccupied  )
                    {
                        //there is not enough spaces to allow ship placement 
                        return false;
                    }                   
                   
                    if (player0.GameBoard.Panels[location + panelcheck].Coordinates.Row != player0.GameBoard.Panels[location + panelcheck - 1].Coordinates.Row)
                    {
                        return false;
                    }
                }

                //place ship on empty panels
                for (int placing = 0; placing < shipWidth; placing++)
                {
                    player0.GameBoard.Panels[location + placing].ShipType = ShipType.Carrier;
                }

                switch (PlaceShip)
                {
                    case ShipType.Carrier:
                        CarrierPlaced = true;
                        CarrierActive = false;
                        BattleshipActive = true;
                        break;
                    case ShipType.Battleship:
                        BattleshipPlaced = true;
                        BattleshipActive = false;
                        SubmarineActive = true;
                        break;
                    case ShipType.Submarine:
                        SubmarinePlaced = true;
                        SubmarineActive = false;
                        CruiserActive = true;
                        break;
                    case ShipType.Cruiser:
                        CruiserPlaced = true;
                        CruiserActive = false;
                        DestroyerActive = true;
                        break;
                    case ShipType.Destoryer:
                        DestroyerPlaced = true;
                        DestroyerActive = false;
                        break;
                }

                //fucntion carried out successfully
                return true;
            }

            //button is not a valid placment point
            return false;
        }

       
    }
}



//{ int ret_value; ret_value = ButtonPressed(1, 1); switch (ret_value) {case 15: this.Size = new System.Drawing.Size(390, 60); this.Text = "Aircraft Carrier"; break; case 14: this.Size = new System.Drawing.Size(); this.Text = "Battleship"; break; case 131: this.Size = new System.Drawing.Size(); this.Text = "Submarine"; break; case 132: this.Size = new System.Drawing.Size(); this.Text = "Cruiser"; break; case 12: this.Size = new System.Drawing.Size(); this.Text = "Destroyer"; break; case 10: break; case -1: break; } }
