using System;

namespace TheAdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to a Rediculously Lame Adventure!");

            Console.WriteLine("You're standing on a road with three different possible directions to walk. Which way would you like to go? [left, right, or straight?]");

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
                Console.WriteLine("invalid choice. You died.");
            }

            Console.ReadLine();
        }

        private static void GoRight()
        {
            Console.WriteLine("You chose to walk to the right.");
            Console.WriteLine("you find a ladder in the road next to a dark hole.  Do you stand the ladder up and go [up] or drop it [down] in the hole?");
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
                Console.WriteLine("invalid choice. You died.");
            }
        }

        private static void GoDownTheHole()
        {
            Console.WriteLine("you plummet down to the bottom of the hole. You come across a nest of snakes. do you [jump] over it or [light] the entire nest on fire?");
            var choice = Console.ReadLine();
            if (choice.Equals("jump"))
            {
                Console.WriteLine("you jump over the snakes nest.");

            }
            else if (choice.Equals("light"))
            {
                Console.WriteLine("you light the nest of snakes on fire and kill 'em all!");
            }
            else
            {
                Console.WriteLine("invalid choice. You died.");
            }
        }

        private static void GoUpTheLadder()
        {
            Console.WriteLine("You climb up the ladder to the top and find your self standing on top of an old castle. You come across a giant, hairy, black, angry spider. Do you [fight] it or [run] past it?");
            var choice = Console.ReadLine();
            if (choice.Equals("fight"))
            {
                FightTheSpider();
            }
            else if (choice.Equals("run"))
            {
                RunFromSpider();
            }
            else
            {
                Console.WriteLine("invalid choice. You died.");
            }
        }

        private static void FightTheSpider()
        {
            Console.WriteLine("you are now fighting the giant, stinky angry spider. After a lengthy battle, you finally slay the giant spider.Do you now [rest] for a while or keep [strolling] down the path?");
            var choice = Console.ReadLine();
            if (choice.Equals("rest"))
            {
                Console.WriteLine("Your resting.");
            }
            else if (choice.Equals("strolling"))
            {
                Console.WriteLine("You are now strolling.");
            }
            else
            {
                Console.WriteLine("invalid choice. You died.");
            }
        }

        private static void RunFromSpider()
        {
            Console.WriteLine("Holding your breath, you run past the giant, smelly, angry spider. You run until you're out of breath. You slow down to a walk and find a piece of folded up paper. Do you [pick] it up or keep [walking] down the path? ");
            var choice = Console.ReadLine();
            if (choice.Equals("pick"))
            {
                Console.WriteLine("You pick up the folded paper and unfold it");
            }
            else if (choice.Equals("walking"))
            {
                Console.WriteLine("You leave the paper there and keep walkin.");
            }
            else
            {
                Console.WriteLine("invalid choice. You died.");
            }
        }

        private static void GoStraight()
        {
            Console.WriteLine("Straight is great!");
            Console.WriteLine("You discover an antique looking compass that someone apparently lost. Behold! It seems to work! Being in the middle of the no where, we need to figure out if we want to travel [west] or [east]?");
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
            Console.WriteLine("ok, now you're headed East. You come across a rather large, fire breathing dragon. Do you want to [fight] it or [tame] it?");
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
                Console.WriteLine("invalid choice. You died.");
            }
        }

        private static void HeadWest()
        {
            Console.WriteLine("Good job! You're heading West. You come across a zombie. do you [fight] or [retreat]?");
            var choice = Console.ReadLine();
            if (choice.Equals("fight"))
            {
                FightZombie();
            }
            else if (choice.Equals("retreat"))
            {
                RetreatFromZombie();
            }
            else
            {
                Console.WriteLine("invalid choice. You died.");
            }
        }

        private static void RetreatFromZombie()
        {
            Console.WriteLine("you have retreated. You run back about 100 yards and come across a rusty sword stuck in the ground. Do you [take] the sword or [leave] it and continue west?");
            var choice = Console.ReadLine();
            if (choice.Equals("take"))
            {
                Console.WriteLine("You take the sword and continue walking.");
            }
            else if (choice.Equals("leave"))
            {
                Console.WriteLine("You've left the sword where it is nd continue on.");
            }
        }

        private static void FightZombie()
        {
            Console.WriteLine("you are fighting the zombie. You kill the zombie. Do you continue [forward] or stop and [rest] for a little while?");
            var choice = Console.ReadLine();
            if (choice.Equals("forward"))
            {
                Console.WriteLine("You move forward.");
            }
            else if (choice.Equals("rest"))
            {
                Console.WriteLine("You are resting.");
            }
            else
            {
                Console.WriteLine("invalid choice. You died.");
            }
        }

        private static void GoLeft()
        {
            Console.WriteLine("As you begin your journey, you come across a wizard. Do you [talk] to him or [walk] past him?");
            var choice = Console.ReadLine();
            if (choice.Equals("talk"))
            {
                TalkToWizard();
            }
            else if (choice.Equals("walk"))
            {
                WalkPastWizard();
            }
            else
            {
                Console.WriteLine("Invalid Choice. You died.");
            }
        }

        private static void WalkPastWizard()
        {
            Console.WriteLine("The wizard tells you to stop and says only danger is up ahead! Do you [walk] past him or [ask] about the danger");
            var choice = Console.ReadLine();
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
                Console.WriteLine("invalid choice. You died.");
            }
        }

        private static void TalkToWizard()
        {
            Console.WriteLine("The wizard warns you of danger. Do you [inquire] about the danger or ignore him and [run] past?");
            var choice = Console.ReadLine();
            if (choice.Equals("inquire"))
            {
                InquireAboutDanger();
            }
            else if (choice.Equals("run"))
            {
                RunPastWizard();
            }
            else
            {
                Console.WriteLine("invalid choice. You died.");
            }
        }

        private static void RunPastWizard()
        {
            Console.WriteLine("you run past. after a while you come to a fork in the road where you can only head North or South. Do you walk [north] or do you walk [south]");
            var choice = Console.ReadLine();
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
                Console.WriteLine("invalid choice. You died.");
            }
        }

        private static void InquireAboutDanger()
        {
            Console.WriteLine("you have inquired. He tells you again about the danger up ahead. Do you [heed] his warning or [ignore] and walk past?");
            var choice = Console.ReadLine();
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
                Console.WriteLine("invalid choice. You died.");
            }
        }
    }
}
