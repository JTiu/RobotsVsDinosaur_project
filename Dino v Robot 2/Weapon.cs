using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dino_v_Robot_2
{
    class Weapon
    {
        //variables HAS
        string weaponType;
        int attackPower;

        //constructor SPAWN
        public Weapon(string weaponType, int attackPower)
        {
            this.weaponType = weaponType;
            this.attackPower = attackPower;
        }

    }
}
