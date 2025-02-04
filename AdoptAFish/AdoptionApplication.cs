using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            player.tank.fish.SetFishProperties(name, color);



        }
    }

}
