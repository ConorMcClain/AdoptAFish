using AdoptAFish;

namespace AdoptAFish
{
    public class Player
    {
        //attributes - C# fields or properties
        public string Name = "Anonymous Player";
        public Tank tank = new Tank();
        public Tank[] tanks = new Tank[4];

        //operations - C# methods

        public Player(string name)
        {
            Name = name;
            SetUpTanks();

        }
        public Player()
        {
            SetUpTanks();
        }
        private void SetUpTanks()
        {
            tank = new Tank() { TankName = $"tank #1" };
            //for (int i = 0; i < tanks.Length; i++)
            //{
            //tanks[i] = new Tank() { tankName = $"tank #{i + 1}" };
            //}

            //tanks[tanks.Length - 1].Fishes.Remove(tanks[tanks.Length - 1].Fishes[tanks[tanks.Length - 1].Fishes.Count - 1]);
        }
        public string Information()
        {
            string output = $"{Name}, you have one tank.";
            ////output += $"{Name}, you have one tank. Inside the tank is a {tanks[0].Fishes[0].FishColor} colored fish named {tanks[0].Fishes[0].FishName}";
            //foreach (Tank tank in tanks)
            //{
            //    output += $"{tank.tankName}\n{tank.Information()}";
            //}

            //return $"{Name}, you have one tank. Inside the tank is a {tanks[0].Fishes[0].FishColor} colored fish named {tanks[0].Fishes[0].FishName}";
            return output;
        }
        public double playercurrency = 0.00;

        public string Currency()
        {
            string output = "";
            output += $"you have {Currency} dollars";

            return output;
        }


        public void Buy(StoreItem item)
        {
            if (playercurrency >= item.Price)
            {
                playercurrency -= item.Price;
                // Add item to player inventory logic here 
                Console.WriteLine($"You bought {item.Name} for {item.Price} which leaves {playercurrency} currency.");
            }
            else
            {
                Console.WriteLine("Not enough currency to buy this item.");
            }
        }

    }

}
