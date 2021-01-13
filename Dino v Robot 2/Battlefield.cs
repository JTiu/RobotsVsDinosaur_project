using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dino_v_Robot_2
{
    public class Battlefield
    {
        public Fleet theFleet = new Fleet();

        public Battlefield()
        {
            Fleet fleet = new Fleet();
            theFleet = fleet;
        }

        public void RunGame()
        {
            //Console.WriteLine(theFleet.robot1.name);
           
        }
    }
}
