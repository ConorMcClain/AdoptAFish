using System;
using static System.Console;

namespace AdoptAFish
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Adopt A Fish App";
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();
            AdoptionApplication app = new AdoptionApplication();
            app.Start();

          
        }
    
    }
}
