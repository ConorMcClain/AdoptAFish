namespace AdoptAFish
{
    public class Tank
    {
        const int IdealTankTemperature = 72;

        public string tankName = "First tank";
        public Fish fish = new Fish();
        public double CurrentTankTemperature = 73.5;


        public string Information()
        {
            string output = "Tank information:\n";
            output += $"{tankName} has one fish named {fish.FishName} that is the color {fish.FishColor} and is {fish.FishAge} years old. The current tank temperature is {CurrentTankTemperature} degrees, the ideal tank temperature is {IdealTankTemperature} degrees. {Environment.NewLine}";
            
            return output;
        }

    }
}