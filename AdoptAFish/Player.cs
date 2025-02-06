namespace AdoptAFish
{
    public class Player
    {
        #region Properties
        //attributes - C# fields or properties
        public string Name = "Anonymous PLayer";
        public Tank tank = new Tank();
        #endregion

        //operations - C# methods

        //Constructor (No return type) (Exact same name as the class)
        public Player()
        {

        }
        // overloaded constructor
        public Player(string name)
        {
            Name = name;
        }

        #region Methods
        public string Information()
        {
            string output = "";
            output += $"{Name}, you have one tank. Inside the tank is a {tank.fish.FishColor} colored fish named {tank.fish.FishName}.";

            return output;
        }

        #endregion
    }
}