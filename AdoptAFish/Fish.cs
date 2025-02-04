using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdoptAFish
{
    public class Fish
    {
        public string fishName;
        public string fishType;
        private string description;
        private string fishFoodType;
        private int fishFoodAmount;
        private string fishPrimaryColor;
        private string fishTankSizeRequirement;
        private double fishLifespan;
        public string fishColor;

        public int HungerLevel = 0;
        public int Fulllevel = 10;
        private int maxLevel = 10;
        private int minLevel = 0;

        public Fish(string name, string color, double lifespan)
        {

        }

        public Fish()
        {

        }

        public void Eat()
        {
            //HungerLevel = HungerLevel - 1;
            if (HungerLevel > minLevel + 1)
            {
                HungerLevel--;
            }

            // FullLevel = FullLevel + 1;
            // if (FullLevel < maxLevel - 1)
            // {
            //     FullLevel++;
        }
        public void SetFishProperties(string name, string color)
        {
            //allow player to change the name and color
            fishName = name;
            fishColor = color;

        }
    }

}