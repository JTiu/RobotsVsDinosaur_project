using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dino_v_Robot_2
{
    class Dinosaur

   
    {
        //variables of my dino
        public string type;
        public int health;
        public int energy;
        public int attackPower;

        //Constructor for my Dino
        public Dinosaur (string type, int health, int energy, int attackPower)

        {
            this.type = type;
            this.health = health;
            this.energy = energy;
            this.attackPower = attackPower;

        }
    }


}
