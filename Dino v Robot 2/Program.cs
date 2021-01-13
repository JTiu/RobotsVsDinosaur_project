using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dino_v_Robot_2
{
    class Program
    {//make classes for Robot, Dinosaur, Fleet, Herd, Weapon, Battlefield
        static void Main(string[] args)
        {
            Robot robot1/*bucket*/ = new Robot("robot1", 100, 55);//instantiantion in the program class, just to check my new robot
            Console.WriteLine(robot1.name + " name " + robot1.health + " health " + robot1.powerLevel + " P/L "); //Console writeline of my new robot1, with the variables I want to print
            Robot robot2/*bucket*/ = new Robot("robot2", 90, 50); //the code that will instantiate robot2
            Console.WriteLine(robot2.name + " name " + robot2.health + " health " + robot2.powerLevel + " P/L ");
            Robot robot3/*bucket*/ = new Robot("robot3", 80, 45); //gives me robot3
            Console.WriteLine(robot3.name + " name " + robot3.health + " health " + robot3.powerLevel + "P/L");
            Robot robot4/*bucket*/ = new Robot("robot4", 70, 40); //gives me robot3
            Console.WriteLine(robot4.name + " name " + robot4.health + " health " + robot4.powerLevel + "P/L");
            Dinosaur dinosaur1 /*bucket*/ = new Dinosaur("t-rex", 101, 90, 70);
            Console.WriteLine("  ");
            Console.WriteLine(dinosaur1.type + " dino1's type " + dinosaur1.health + " health " + dinosaur1.energy + " energy " + dinosaur1.attackPower + " attack power");
            Dinosaur dinosaur2 /*bucket*/ = new Dinosaur("brontosaur", 91, 80, 60);
            Console.WriteLine(dinosaur2.type + " dino2's type " + dinosaur2.health + " health " + dinosaur2.energy + " energy " + dinosaur2.attackPower + " attack power");
            Dinosaur dinosaur3 /*bucket*/ = new Dinosaur("stegosaur", 81, 70, 50);
            Console.WriteLine(dinosaur3.type + " dino3's type " + dinosaur3.health + " health " + dinosaur3.energy + " energy " + dinosaur3.attackPower + " attack power");
            Dinosaur dinosaur4 /*bucket*/ = new Dinosaur("velocoraptor", 111, 110, 90);
            Console.WriteLine(dinosaur4.type + " dino4's type " + dinosaur4.health + " health " + dinosaur4.energy + " energy " + dinosaur4.attackPower + " attack power");
            Console.ReadLine();

            Battlefield myBattle = new Battlefield();
            myBattle.RunGame();
          
        }
    }
}
