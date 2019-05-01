using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip_FinalProject
{
    //This is a parent class to the rest of the ships
    public class Ship
    {
        public string Name { get; set; }
        public int Width { get; set; }
        public int Hits { get; set; }
        public ShipType ShipType { get; set; }
        public bool IsSunk
        {
            get
            {
                return Hits >= Width;
            }
        }
    }

    public class Carrier : Ship
    {
        public Carrier()
        {
            Name = "Aircraft Carrier";
            Width = 5;
            ShipType = ShipType.Carrier;
        }
    }

    public class Battleship : Ship
    {
        public Battleship()
        {
            Name = "BattleShip";
            Width = 4;
            ShipType = ShipType.Battleship;
        }
    }

    public class Submarine : Ship
    {
        public Submarine()
        {
            Name = "Submarine";
            Width = 3;
            ShipType = ShipType.Submarine;
        }
    }

    public class Cruiser : Ship
    {
        public Cruiser()
        {
            Name = "Cruiser";
            Width = 3;
            ShipType = ShipType.Cruiser;
        }
    }

    public class Destroyer : Ship
    {
        public Destroyer()
        {
            Name = "Destroyer";
            Width = 2;
            ShipType = ShipType.Destoryer;
        }
    }

    public enum ShipType
    {
        Carrier = 50,
        Battleship = 40,
        Submarine = 31,
        Cruiser = 30,
        Destoryer = 20,
        Empty = 'E'
    }
}
