using System;

namespace TheAdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Adventure Game!");

            Console.WriteLine("Which way would you like to go? [left, right, or straight?]");

            var choice = Console.ReadLine();

            if (choice.Equals("left"))
            {
                Console.WriteLine("left is a good choice!");
            }
           else if (choice.Equals("right"))
            {
                Console.WriteLine("right is not a good choice!");
            }
            else if (choice.Equals("straight"))
            {
                Console.WriteLine("straight is great!");
            } 
            else
            {
                Console.WriteLine("invalid choice.");
            }

            Console.ReadLine();

        }
    }
}
