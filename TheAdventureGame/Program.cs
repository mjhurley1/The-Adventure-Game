using System;

namespace TheAdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Adventure Game!");
            Console.WriteLine("Which way would you like to go? [Left, Right, or Straight Ahead?]");

            var choice = Console.ReadLine();

            Console.WriteLine("You chose " + choice + ".");
            Console.ReadLine();
        }
    }
}
