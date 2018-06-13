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
            Console.WriteLine("[left or right]");
            var choice = Console.ReadLine();
            if (choice.Equals("left"))
            {

                Console.WriteLine("Your walkin left. You come across a giant spider. Do you [fight] it or [run] past it?");
                choice = Console.ReadLine();
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
            else if (choice.Equals("right"))
            {
                Console.WriteLine("your going right. you come across a nest of snakes. do you [jump] over it or [light] it on fire?");
                choice = Console.ReadLine();
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
        }

        private static void GoStraight()
        {
            Console.WriteLine("Straight is great!");
            Console.WriteLine("[forward, or right]");
            var choice = Console.ReadLine();
            if (choice.Equals("forward"))
            {
                Console.WriteLine("Good job! Youre moving forward.You come across a zombie. do you [fight] or [retreat]?");
                choice = Console.ReadLine();
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
            else if (choice.Equals("right"))
            {
                Console.WriteLine("ok, now you're going right. you come across a dragon. do you want to [fight] it or [tame] it?");
                choice = Console.ReadLine();
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
                    Console.WriteLine("you run past. after a while you come to a fork in the road. do you walk [left] or do you walk [right]");
                    choice = Console.ReadLine();
                    if (choice.Equals("left"))
                    {
                        Console.WriteLine("you walk to the left");
                    }
                    else if (choice.Equals("right"))
                    {
                        Console.WriteLine("you walk to the right");
                    }
                    else
                    {
                        Console.WriteLine("invalid choice");
                    }
                    
                     
                }
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
