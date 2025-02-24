using static AdoptAFish.Library;
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
            Console.WriteLine($"{player.Name}, Welcome to ¸.·´¯`·.´¯`·.¸¸.·´¯`·.¸><(((º>{Name}¸.·´¯`·.´¯`·.¸¸.·´¯`·.¸<°))))><!!!");

            SetPLayerName();
            SetFishProperties();
            Console.WriteLine(player.Information());
            Console.WriteLine(player.tank.Information());
          
            Console.ReadKey();

            Console.WriteLine("Type Menu To View Menu");
            Console.ReadKey();
            DisplayMenu();
            GameLoop();
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

        public string DisplayMenu()
        {
            var menuString = string.Empty;
            menuString = menuString + "Main Menu:\n";
            menuString = menuString + "Change Name\n";
            menuString = menuString + "View Fish\n";
            menuString = menuString + "Test Tank Temperature\n";
            menuString = menuString + "Raise Tank Temperature\n";
            menuString = menuString + "Lower Tank Temperature\n";
            menuString = menuString + "Visit The Store\n";
            menuString = menuString + "Exit\n";
            menuString = menuString + "Enter your choice:\n";

            return menuString;
        }

        private void GameLoop()
        {
            Console.Clear();

            Print(DisplayMenu());

            string choice = Console.ReadLine();

            GameLoop();
        }
    }

}
