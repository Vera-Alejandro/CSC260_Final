using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip_FinalProject
{
    //This is a parent class to the rest of the ships
    public abstract class Ships
    {

        //Methods that are to be overridden
        //**will these functions stay at void??
        public abstract void CheckHit();
        public abstract void Place();

    }
}
