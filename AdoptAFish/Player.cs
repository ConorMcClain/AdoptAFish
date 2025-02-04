using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace AdoptAFish
{
    public class Player
    {

        //attributes - C# fields or properties
        public string Name = "Anonymous PLayer";
        public tank tank = new tank();

        //operations - C# methods

        //Constructor (No return type) (Exact same name as the class)
        public Player(string name)
        {
            Name = name;
        }

        public Player()
        {

        }


        public string Information()
        {
            string output = "";
            output += $"{Name}, you have one tank. Inside the tank is a {tank.fish.fishColor} colored fish named {tank.fish.fishName}.";

            return output;
        }
    }
}