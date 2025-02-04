using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdoptAFish
{
    public class pond
    {
    }

    public class tank
    {
        public string tankName = "First tank";
        public Fish fish = new Fish();    

        public string Information()
        {
            string output = "Tank information:\n";
            output += $"{tankName} has one fish named {fish.fishName} that is the color {fish.fishColor}. {Environment.NewLine}";
            
            return output;
        }
    }
}