using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip_FinalProject
{
    public class Player
    {
        public string Name { get; set; }
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
            Name = name;

            //create a collection of ships
            Carrier = new Carrier();
            CarrierPlaced = false;
            Battleship = new Battleship();
            BattleshipPlaced = false;
            Cruiser = new Cruiser();
            CruiserPlaced = false;
            Submarine = new Submarine();
            SubmarinePlaced = false;
            Destroyer = new Destroyer();
            DestroyerPlaced = false;

            //Create Gameboard and FiringBoard for Player Use
            GameBoard = new GameBoard();
            FiringBoard = new FiringBoard();
        }


        #region Placing Ships Functions
        //this places the Carrier class
        public void PlaceShips(Carrier carrier)
        {

            CarrierPlaced = true;
            ShipsPlaced++;
        }

        //this places the Balleship class
        public void PlaceShips(Battleship battleship)
        {

            BattleshipPlaced = true;
            ShipsPlaced++;
        }

        //this places the Cruiser class
        public void PlaceShips(Cruiser cruiser)
        {
            CruiserPlaced = true;
            ShipsPlaced++;
        }

        //this places the Submarine class
        public void PlaceShips(Submarine submarine)
        {
            SubmarinePlaced = true;
            ShipsPlaced++;
        }

        //this places the Destroyer class
        public void PlaceShips(Destroyer destroyer)
        {
            DestroyerPlaced = true;
            ShipsPlaced++;
        }
        #endregion
    }
}
