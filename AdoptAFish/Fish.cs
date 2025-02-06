namespace AdoptAFish
{
    public class Fish
    {
        public string FishName;
        public string FishType;
        public string FishColor;
        public int FishAge;
        public int HungerLevel = 0;
        public int Fulllevel = 10;

        private int maxLevel = 10;
        private int minLevel = 0;
        private string description;
        private string fishFoodType;
        private int fishFoodAmount;
        private string fishPrimaryColor;
        private string fishTankSizeRequirement;
        private double fishLifespan;

        public Fish()
        {

        }

        public Fish(string name, string color, double lifespan, int age)
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
        public void SetFishProperties(string name, string color, int age)
        {
            //allow player to change the name and color
            FishName = name;
            FishColor = color;
            FishAge = age;
        }
    }

}