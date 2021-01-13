using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dino_v_Robot_2
{
    class Robot
    {
        //variables HAS
        public string name;
        public int health;
        public int powerLevel;
       


        //constructor SPAWN > used to make my Robot
        public Robot (string name, int health, int powerLevel)
           
        {
            this.name = name;
            this.health = health;
            this.powerLevel = powerLevel;
        }

        

    }
}
