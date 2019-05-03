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
        public int ShipsPlaced { get; set; }
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





        #region Placing Ships Functions
        //this places the Carrier class
        public bool PlaceCarrier(int row, int column, Player player0)
        {
            int location = ((row - 1) * 10) + ((column % 10) -1);

            //check if the button press is a value placment option
            if (!(player0.GameBoard.Panels[location].IsOccupied))
            {
                
                //check if there is space on the board to fit the ship
                for (int panelcheck = 1; panelcheck < Carrier.Width; panelcheck++)
                {
                    //checks if panel is free or if location moved to a new row
                    if (player0.GameBoard.Panels[location + panelcheck].IsOccupied || (player0.GameBoard.Panels[location + panelcheck].Coordinates.Row != player0.GameBoard.Panels[location + panelcheck - 1].Coordinates.Row))
                    {
                        //there is not enough spaces to allow ship placement 
                        return false;
                    }
                }

                //place ship on empty panels
                for (int placing = 0; placing < Carrier.Width; placing++)
                {
                    player0.GameBoard.Panels[location + placing].ShipType = ShipType.Carrier;
                }


                //place code
                CarrierPlaced = true;
                ShipsPlaced++;
                CarrierActive = false;
                BattleshipActive = true;

                //fucntion carried out successfully
                return true;
            }

            //button is not a valid placment point
            return false;
        }

        //this places the Balleship class
        public int PlaceBattleShip(int row, int column )
        {
            if (1 != row /*button location*/)
            {
                //place code
                BattleshipPlaced = true;
                ShipsPlaced++;

                //fucntion carried out successfully
                return 1;
            }
            else
            {
                //button is not a valid placment poiunt
                return -1;
            }

            
        }

        //this places the Cruiser class
        public int PlaceCruiser(int row, int column )
        {
            if (1 != row /*button location*/)
            {
                //place code
                CruiserPlaced = true;
                ShipsPlaced++; ;

                //fucntion carried out successfully
                return 1;
            }
            else
            {
                //button is not a valid placment poiunt
                return -1;
            }

            
        }

        //this places the Submarine class
        public int PlaceSubmarine(int row, int column )
        {

            if (1 != row /*button location*/)
            {
                //place code
                SubmarinePlaced = true;
                ShipsPlaced++;

                //fucntion carried out successfully
                return 1;
            }
            else
            {
                //button is not a valid placment poiunt
                return -1;
            }
            
        }

        //this places the Destroyer class
        public int PlaceDestroyer(int row, int column )
        {

            if (1 != row /*button location*/)
            {
                //place code
                DestroyerPlaced = true;
                ShipsPlaced++;

                //fucntion carried out successfully
                return 1;
            }
            else
            {
                //button is not a valid placment poiunt
                return -1;
            }
            
        }
        #endregion
    }
}
