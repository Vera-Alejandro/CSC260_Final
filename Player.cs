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
        public List<Ship> Ships { get; set; }

        //checks all the list to see if they are all sunk.
        //if all sunk then return true because the player has lost
        public bool Lost
        {
            get
            {
                return Ships.All(x => x.IsSunk);
            }
        }

        //constructor
        public Player(string name)
        {
            //import the Player Name
            Name = name;
            //create a collection of ships
            Ships = new List<Ship>()
            {
                new Carrier(),
                new Battleship(),
                new Cruiser(),
                new Submarine(),
                new Destroyer()
            };
            //Create Gameboard and FiringBoard for Player Use
            GameBoard = new GameBoard();
            FiringBoard = new FiringBoard();

           
        }
       
    }
}
