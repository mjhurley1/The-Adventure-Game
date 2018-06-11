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
                Console.WriteLine("As you begin your journey, you come across a wizard. Do you [talk] to him or [walk] past him?");
                choice = Console.ReadLine();
                if (choice.Equals("talk"))
                {
                    Console.WriteLine("The wizard warns you of danger. Do you [inquire] about the danger or ignore him and [walk] past?");
                }
                else if (choice.Equals("walk"))
                {
                    Console.WriteLine("The wizard tells you to stop and says only death is up ahead! Do you [walk] past him or [ask] about the danger");
                }
                else
                {
                    Console.WriteLine("Invalid Choice.");
                }
            }
            else if (choice.Equals("right")) 
            {
                Console.WriteLine("right is not a good choice!");
            }
            else if (choice.Equals("straight"))
            {
                Console.WriteLine("Straight is great!");
            }
            else
            {
                Console.WriteLine("invalid choice.");
            }

            Console.ReadLine();

        }
    }
}
