/*
*Adopt a Fish
*Conor McClain
*1/28/25
*/
namespace AdoptAFish
{
    public class AdoptionApplication
    {
        //attributes / properties /fields / variables
        public string Name = " The Awesome Adoption Agency";
        private int numFish = 3;
        public Player player = new Player();
        private string? menu;

        //A plauer has a tank
        //A fish lives in a tank

        //start method needs to be public
        public void Start()
        {
            //interpolation
            Console.WriteLine($"{player.Name}, Welcome to {Name}!!!");

            SetPLayerName();
            SetFishProperties();
            Console.WriteLine(player.Information());
            Console.WriteLine(player.tank.Information());
            DisplayMenu();

            //concatenation
            //Console.WriteLine("Welcome to" + Name);

            //Composite formatting
            //Console.WriteLine("Welcome to {0}, there are {1}", Name, numFish);

            Console.ReadKey();
        }

        private void SetPLayerName()
        {
            //print out a request for the player to enter a new name
            Console.WriteLine("Please enter name:");
            //get whatever the player typed in
            string input = Console.ReadLine();
            player.Name = input;
            Console.WriteLine($"Nice to meet you {player.Name}!");
        }


        private void SetFishProperties()
        {
            Console.WriteLine("Please enter a name for your fish.");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter a color for your fish.");
            string color = Console.ReadLine();
            Console.WriteLine("Please enter an age for your fish.");
            string fishAge = Console.ReadLine();
            int fAge = Convert.ToInt32(fishAge);
            // set the properties
            player.tank.fish.SetFishProperties(name, color);


        }

        public void DisplayMenu()
        {
            Console.WriteLine("Main Menu:");
            Console.WriteLine("Change Name");
            Console.WriteLine("View Fish");
            Console.WriteLine("Test Tank Temperature");
            Console.WriteLine("Raise Tank Temperature");
            Console.WriteLine("Lower Tank Temperature");
            Console.WriteLine("Visit The Store");
            Console.WriteLine("Exit");
            Console.WriteLine("Enter your choice:");
        }

    }

}
