using System;
using static System.Console;

namespace AdoptAFish
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Adopt A Fish App";
            AdoptionApplication app = new AdoptionApplication();
            app.Start();

            // WriteLine("Hello, World!");
          
        }
    
    }
}
