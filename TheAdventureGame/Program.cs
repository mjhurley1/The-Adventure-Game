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
                GoRight();
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

        private static void GoRight()
        {
            Console.WriteLine("right is not a good choice!");
            Console.WriteLine("you find a ladder in the raod next to a hole.  Do you stand up the ladder and go [up] or drop [down] in the hole?");
            var choice = Console.ReadLine();
            if (choice.Equals("up"))
            {
                GoUpTheLadder();
            }
            else if (choice.Equals("down"))
            {
                GoDownTheHole();
            }
            else
            {
                Console.WriteLine("invalid choice");
            }
        }

        private static void GoDownTheHole()
        {
            Console.WriteLine("you plummet down to the bottom of the hole. You come across a nest of snakes. do you [jump] over it or [light] it on fire?");
            var choice = Console.ReadLine();
            if (choice.Equals("jump"))
            {
                Console.WriteLine("you jump over the snakes nest.");

            }
            else if (choice.Equals("light"))
            {
                Console.WriteLine("you light the nest of snakes on fire");
            }
            else
            {
                Console.WriteLine("invalid choice");
            }
        }

        private static void GoUpTheLadder()
        {
            Console.WriteLine("You climb up the ladder to the top of an old castle. You come across a giant spider. Do you [fight] it or [run] past it?");
            var choice = Console.ReadLine();
            if (choice.Equals("fight"))
            {
                Console.WriteLine("you are now fighting the giant spider.");

            }
            else if (choice.Equals("run"))
            {
                Console.WriteLine("you run past the giant spider.");
            }
            else
            {
                Console.WriteLine("invalid choice");
            }
        }

        private static void GoStraight()
        {
            Console.WriteLine("Straight is great!");
            Console.WriteLine("You discover a compass that someone apparently lost. Behold! It works!  Being in the middle of the kingdom, we need to figure out if we want to travel [west] or [east]?");
            var choice = Console.ReadLine();
            if (choice.Equals("west"))
            {
                HeadWest();
            }
            else if (choice.Equals("east"))
            {
               HeadEast();
            }
        }

        private static void HeadEast()
        {
            Console.WriteLine("ok, now you're headed East. You come across a dragon. Do you want to [fight] it or [tame] it?");
           var choice = Console.ReadLine();
            if (choice.Equals("fight"))
            {
                Console.WriteLine("you are now fighting the dragon");
            }
            else if (choice.Equals("tame"))
            {
                Console.WriteLine("you are now trying to tame the dragon");
            }
            else
            {
                Console.WriteLine("invalid choice");
            }
        }

        private static void HeadWest()
        {
            Console.WriteLine("Good job! You're heading West. You come across a zombie. do you [fight] or [retreat]?");
            var choice = Console.ReadLine();
            if (choice.Equals("fight"))
            {
                Console.WriteLine("you are fighting the zombie");
            }
            else if (choice.Equals("retreat"))
            {
                Console.WriteLine("you have retreated");
            }
            else
            {
                Console.WriteLine("invalid choice");
            }
        }

        private static void GoLeft()
        {
            Console.WriteLine("As you begin your journey, you come across a wizard. Do you [talk] to him or [walk] past him?");
            var choice = Console.ReadLine();
            if (choice.Equals("talk"))
            {
                Console.WriteLine("The wizard warns you of danger. Do you [inquire] about the danger or ignore him and [run] past?");
                choice = Console.ReadLine();
                if (choice.Equals("inquire"))
                {
                    Console.WriteLine("you have inquired. Do you [heed] his warning or [ignore] and walk past?");
                    choice = Console.ReadLine();
                    if (choice.Equals("heed"))
                    {
                        Console.WriteLine("You heed his warning.");
                    }
                    else if (choice.Equals("ignore"))
                    {
                        Console.WriteLine("you ignore him and walk past.");
                    }
                    else
                    {
                        Console.WriteLine("invalid choice");
                    }
                } 
                else if (choice.Equals("run"))
                {
                    Console.WriteLine("you run past. after a while you come to a fork in the road where you can only head North or South. Do you walk [north] or do you walk [south]");
                    choice = Console.ReadLine();
                    if (choice.Equals("north"))
                    {
                        Console.WriteLine("you start walking to the North");
                    }
                    else if (choice.Equals("south"))
                    {
                        Console.WriteLine("you start walking to the Sorth");
                    }
                    else
                    {
                        Console.WriteLine("invalid choice");
                    }
                }
                else
                {
                    Console.WriteLine("invalid choice");
                }
            }
            else if (choice.Equals("walk"))
            {
                Console.WriteLine("The wizard tells you to stop and says only death is up ahead! Do you [walk] past him or [ask] about the danger");
                choice = Console.ReadLine();
                if (choice.Equals("walk"))
                {
                    Console.WriteLine("you walked past");
                }
                else if (choice.Equals("ask"))
                {
                    Console.WriteLine("you ask about the danger");
                }
                else
                {
                    Console.WriteLine("invalid choice");
                }
            }
            else
            {
                Console.WriteLine("Invalid Choice.");
            }
        }
    }
}
