using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdoptAFish;
using System.Security.Cryptography;

namespace AdoptAFish
{
    public class Fish
    {
        private string fishName;
        private string fishType;
        private string description;
        private string fishFoodType;
        private int fishFoodAmount;
        private string fishPrimaryColor;
        private string fishTankSizeRequirement;
        private double fishLifespan;
        private double fishPrice;
        private string fishColor;
        private int maxLevel = 10;
        private int minLevel = 0;

        public int HungerLevel = 0;
        public int FullLevel = 10;
        public string FishName
        {
            get => fishName;
            set => fishName = value;
        }
        public string FishColor { get => fishColor; set => fishColor = value; }
        public string Description { get => description; set => description = value; }
        public double Price { get => fishPrice; set => fishPrice = value; }


        public Fish(string name, string color, double lifespan)
        {
            FishName = name;
            FishColor = color;
            fishLifespan = lifespan;
        }
        public Fish()
        {
            //new instance of fish - random name, random color
            FishName = GetRandomName();
            FishColor = GetRandomColor();

        }
        private string GetRandomName()
        {
            string[] names = {
             "Ann",
             "Bob",
             "Carol",
             "Dustin",
             "Ella",
             "Frank",
             "Gary",
             "Heather"
         };

            int max = names.Length;
            int randomNumber = Library.GetRandomNumber(max);
            string name = names[randomNumber];
            return name;

            //return names[Library.GetRandomNumber(names.Length)];
        }
        private string GetRandomColor()
        {
            string[] colors = {
         "blue",
         "green",
         "purple"
         };

            return colors[Library.GetRandomNumber(colors.Length)];
            //return colors[Library.GetRandomNumber(colors.Length)];
        }
        public void Eat()
        {
            //HungerLevel = HungerLevel - 1;
            if (HungerLevel > minLevel + 1)
            {
                HungerLevel--;
            }

        }



        public void SetFishProperties(string name, string color)
        {
            //allow player to change the name and the color
            FishName = name;
            FishColor = color;
        }

    }
}
