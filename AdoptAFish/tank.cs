namespace AdoptAFish
{
    public class Tank
    {
        const int IdealTankTemperature = 72;

        public string tankName = "First tank";
        public List<Fish> Fishes = new List<Fish>();
        public Fish fish = new Fish();
        public double CurrentTankTemperature = 73.5;

        public Tank()
        {
            SetUpFishes();
        }
        private void SetUpFishes()
        {
            Fishes.Add(new Fish());
        }

        public string Information()
        {
            string output = "Tank information:\n";
            foreach (Fish fish in Fishes)
            {
                output += $"* {fish.FishName} is {fish.FishColor}\n";
            }
            return output;
        }

    }
}