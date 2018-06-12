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
                GoLeft();
            }
            else if (choice.Equals("right"))
            {
                Right();
            }
            else if (choice.Equals("straight"))
            {
                GoStraight();
            }
            else
            {
                Console.WriteLine("invalid choice.");
            }

            Console.ReadLine();

        }

        private static void Right()
        {
            Console.WriteLine("right is not a good choice!");
            Console.WriteLine("[left or right]");
            var choice = Console.ReadLine();
            if (choice.Equals("left"))
            {
                Console.WriteLine("Your walkin left");
            }
            else if (choice.Equals("right"))
            {
                Console.WriteLine("your going right");

            }
        }

        private static void GoStraight()
        {
            Console.WriteLine("Straight is great!");
            Console.WriteLine("[forward, or right]");
            var choice = Console.ReadLine();
            if (choice.Equals("forward"))
            {
                Console.WriteLine("Good job! Youre moving forward.");
            }
            else if (choice.Equals("right"))
            {
                Console.WriteLine("ok, now you're going right");
            }
        }

        private static void GoLeft()
        {
            Console.WriteLine("As you begin your journey, you come across a wizard. Do you [talk] to him or [walk] past him?");
            var choice = Console.ReadLine();
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
    }
}
