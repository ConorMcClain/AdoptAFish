using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AdoptAFish.Library;

namespace AdoptAFish
{
    internal class Menu
    {
        public void DisplayMenu()
        {

            //List<string> menu = new List<string>(){ "Main Menu", "Change Name", "View Fish", "Test Tank Temperature", "Raise Tank Temperature", "Lower Tank Temperature", "Visit Store", "Exit"};
            Console.WriteLine("Main Menu:");
            Console.WriteLine("Change Name");
            Console.WriteLine("View Fish");
            Console.WriteLine("Test Tank Temperature");
            Console.WriteLine("Raise Tank Temperature");
            Console.WriteLine("Lower Tank Temperature");
            Console.WriteLine("Visit The Store");
            Console.WriteLine("Exit");
            Console.WriteLine("Enter your choice:");
            //return menu;
        }
    }
}
