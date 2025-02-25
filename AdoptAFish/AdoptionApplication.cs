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
        private Player player = new Player();
        private Tank tank = new Tank();
        private int numFish = 3;
        private string? menu;

        public string Name = " The Awesome Adoption Agency";

        //A plauer has a tank
        //A fish lives in a tank

        //start method needs to be public
        public void Start()
        {
            //interpolation
            Console.WriteLine($"{player.Name}, Welcome to ¸.·´¯`·.´¯`·.¸¸.·´¯`·.¸><(((º>{Name}¸.·´¯`·.´¯`·.¸¸.·´¯`·.¸<°))))><!!!");

            SetPlayerName();
            // this is freebie
            // add fish to tank - give the new fish object to Tank
            tank.Fishes.Add(SetFishProperties());

            // display the tank information
            Console.WriteLine(player.Information());
            Console.WriteLine(tank.Information());

            //
            DisplayMenu();
            //Console.ReadKey();

            //GameLoop();
        }

        private void SetPlayerName()
        {
            //print out a request for the player to enter a new name
            Console.WriteLine("Please enter name:");
            //get whatever the player typed in
            string input = Console.ReadLine();
            player.Name = input;
            Console.WriteLine($"Nice to meet you {player.Name}!");
        }


        private Fish SetFishProperties()
        {
            Console.WriteLine("Please enter a name for your fish.");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter a color for your fish.");
            string color = Console.ReadLine();
            Console.WriteLine("Please enter an age for your fish.");
            string fishAge = Console.ReadLine();
            int fAge = Convert.ToInt32(fishAge);
            // set the properties
            Fish firstFish = new Fish() { FishName = name, FishColor = color, FishAge = fAge };

            return firstFish;


        }

        public void DisplayMenu()
        {
            var menuString = string.Empty;
            menuString = menuString + "Main Menu\n";
            menuString = menuString + "1. Change Name\n";
            menuString = menuString + "2. View Fish\n";
            menuString = menuString + "3. Test Tank Temperature\n";
            menuString = menuString + "4. Visit The Store\n";
            menuString = menuString + "5. Exit\n";
            menuString = menuString + "Enter your choice:\n";

            //Console.Clear();
            Print(menuString);
            string menuChoice = Console.ReadLine();

            switch (menuChoice)
            {
                case "1":
                    // do something - Player name change
                    Console.WriteLine("You chose to change player name.");
                    break;
                case "2":
                    // do something - View fish
                    Console.WriteLine("You chose to view your fish.");
                    break;
                case "3":
                    //test tank temperature //add option to raise or lower in the same option 
                    Console.WriteLine("You test tank temperature");
                    break;
                case "4":
                    Console.WriteLine("You chose to visit the store");
                    break;
                case "5":
                    Console.WriteLine("You chose exit");
                    break;

            }
        }

        //private void GameLoop()
        //{
        //    Console.Clear();

        //    Print(DisplayMenu());

        //    string choice = Console.ReadLine();
        //}
    }

}
