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
                Console.WriteLine("as you begin your journey, you come across a wizard. do you [talk] to him or [walk] past him?");
                choice = Console.ReadLine();
                if (choice.Equals("talk"))
                {
                    Console.WriteLine("the wizard warns you of danger. do you [inquire] about the danger or ignore him and [walk] past?");
                }
                else if (choice.Equals("walk"))
                {
                    Console.WriteLine("the wizard tells you to stop and says only death is up ahead!do you [walk] past him or [ask] about the danger");
                }
                else
                {
                    Console.WriteLine("invalid choice.");
                }
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
