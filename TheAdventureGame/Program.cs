using System;
using TheAdventureGame.Models;
using TheAdventureGame.Services;

namespace TheAdventureGame
{
    class Program
    {
        private static BattleService _battleService = new BattleService();
        private static Player PlayerOne { get; set; }

        static void Main(string[] args)
        {
            CharcterCreation();

            Console.WriteLine("Welcome to a Rediculously Boring and Lame Adventure, " + PlayerOne.Name + "!");
            Console.WriteLine("You have chosen to be a " + PlayerOne.CharacterClass);

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

        private static void CharcterCreation()
        {
            PlayerOne = new Player();
            Console.WriteLine("What is your name?");
            PlayerOne.Name = Console.ReadLine();
            Console.WriteLine("What is your class? Are you a warrior, wizard, or elf?");
            PlayerOne.CharacterClass = Console.ReadLine();
            PlayerOne.Weapons.Add(new Weapon
            {
                Name = "Sword",
                Damage = 2
            });
            PlayerOne.Weapons.Add(new Weapon
            {
                Name = "Dagger",
                Damage = 2
            });
            PlayerOne.Weapons.Add(new Weapon
            {
                Name = "Warhammer",
                Damage = 4
            });
            PlayerOne.Weapons.Add(new Weapon
            {
                Name = "Crossbow",
                Damage = 3
            });

            PlayerOne.Health = 20;
        }

        private static void ListWeapons()
        {
            Console.WriteLine("Here is your current weapon inventory:");
            foreach(var weapon in PlayerOne.Weapons)
            {
                Console.WriteLine(weapon.Name);
            }
        }

        private static void GoRight()
        {
            Console.WriteLine("You chose to walk to the right and as you walk you come across a mace just laying there in the road. Do you want to [pick] it up or [leave] it?");
            var choice = Console.ReadLine();
            if (choice.Equals("pick"))
            {
                var mace = new Weapon
                {
                    Name = "mace",
                    Damage = 5
                };
                PlayerOne.Weapons.Add(mace);
                Console.WriteLine("You have picked up the mace and added it to your inventory");
                ListWeapons();
            }
            else
            {
                Console.WriteLine("Not sure why, but you left it there! Too much weapon for you?");
            }

            Console.WriteLine("you find a ladder in the road next to a dark hole.  Do you stand the ladder up and go [up] or drop it [down] in the hole?");
            choice = Console.ReadLine();
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
                Console.WriteLine("you jump over the snakes nest.You lans safely and continue walking until you come to an old wooden staircase. Do you [ascend] the stairs or [descend] the stairs?");
                choice = Console.ReadLine();
                if (choice.Equals("ascend"))
                {
                    AscendStairs();
                }
                else if (choice.Equals("descend"))
                {
                    Console.WriteLine("You choose to go down the staircase");
                }
                else
                {
                    Console.WriteLine("Invalid choice. You died.");
                }
                }
            else if (choice.Equals("light"))
            {
                Console.WriteLine("you light the nest of snakes on fire and kill 'em all! You continue walking and come across a dark cave opening. Do you [enter] or [tread] on down the path?");
                choice = Console.ReadLine();
                if (choice.Equals("enter"))
                {
                    Console.WriteLine("You have entered the dark cave.");
                }
                else if (choice.Equals("tread"))
                {
                    TreadDownPath();
                }
                else
                {
                    Console.WriteLine("Invalid choice. You died.");
                }
            }
            else
            {
                Console.WriteLine("invalid choice. You died.");
            }
        }

        private static void AscendStairs()
        {
            Console.WriteLine("You decide to go up the staircase. At the top you come to a locked door straight ahead and a hallway to the left and to the right? Do you [bust] open the door ahead or walk [leftmost] or go [rightmost]down another hallway?");
            var choice = Console.ReadLine();
            if (choice.Equals("bust"))
            {
                Console.WriteLine("You bust down the door.");
            }
            else if (choice.Equals("leftmost"))
            {
                Console.WriteLine("You decide to walk down the left hallway.");
            }
            else if (choice.Equals("rightmost"))
            {
                Console.WriteLine("You decide to walk down the right hallway");
            }
            else
            {
                Console.WriteLine("Invalid choice. You died.");
            }
        }

        private static void TreadDownPath()
        {
            Console.WriteLine("You decide to not enter the cave.Contining down the path you run into a giant scorpion. Do you [kill] it or [scamper] past it down the path?");
            var choice = Console.ReadLine();
            if (choice.Equals("kill"))
            {
                var scorpion = new Enemy
                {
                    Name = "The Giant Scorpion",
                    EnemyClass = "scorpion",
                    Health = 8,
                };
                scorpion.Weapons.Add(new Weapon {
                    Name = "barbed stinger",
                    Damage = 4
                });
                scorpion.Weapons.Add(new Weapon
                {
                    Name = "pincer claws",
                    Damage = 3
                });

                var result = _battleService.Fight(PlayerOne, scorpion);
                if (result.Equals(BattleResult.PlayerWon))
                {
                    Console.WriteLine("You slay the giant scorpion.");
                }
                else
                {
                    Console.WriteLine("The giant scorion cut you in half. You bled out and died. Game over!");
                }
                
            }
            else if (choice.Equals("scamper"))
            {
                Console.WriteLine("You scamper past the giant scorpion");
            }
            else
            {
                Console.WriteLine("Invalid choice. You died.");
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
            Console.WriteLine("you are now fighting the giant, stinky angry spider.");

            var spider = new Enemy
            {
                Name = "The Angry Spider",
                EnemyClass = "spider",
                Health = 7,
            };
            spider.Weapons.Add(new Weapon
            {
                Name = "fangs",
                Damage = 3
            });
            spider.Weapons.Add(new Weapon
            {
                Name = "web",
                Damage = 1
            });

            var result = _battleService.Fight(PlayerOne, spider);

            if (result.Equals(BattleResult.PlayerWon))
            {
                Console.WriteLine("You killed the spider.");
                Console.WriteLine("After a lengthy battle, you finally slay the giant spider.Do you now [rest] for a while or keep [strolling] down the path?");
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
            else
            {
                Console.WriteLine("You died. Game over.");
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
                FightTheDragon();
            }

            else if (choice.Equals("tame"))
            {
                Console.WriteLine("you are now trying to tame the dragon");
            }
            else
            {
                Console.WriteLine("Invalid choice. You died.");
            }
        }

        private static void FightTheDragon()
        {
            Console.WriteLine("you are now fighting the dragon. ");

            var dragon = new Enemy
            {
                Name = "Earth Dragon",
                EnemyClass = "dragon",
                Health = 14
            };
            dragon.Weapons.Add(new Weapon
            {
                Name = "Teeth",
                Damage = 5
            });
            dragon.Weapons.Add(new Weapon
            {
                Name = "Fire Breath",
                Damage = 7
            });

            var result = _battleService.Fight(PlayerOne, dragon);

            if (result.Equals(BattleResult.PlayerWon))
            {
                Console.WriteLine("You finally slay it but it took a lot out of you. Do you now [sleep] or keep [moving] down the path?");
                var choice = Console.ReadLine();
                if (choice.Equals("sleep"))
                {
                    Console.WriteLine("You are now sleeping.");
                }
                else if (choice.Equals("moving"))
                {
                    Console.WriteLine("You keep moving down the path.");
                }
                else
                {
                    Console.WriteLine("Invalid choice. You died.");
                }
            }
            else
            {
                Console.WriteLine("The " + dragon.EnemyClass + " named " + dragon.Name + "killed you. Game over!");
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
            var zombie = new Enemy
            {
                Name = "Herman",
                EnemyClass = "Zombie",
                Health = 10
            };
            zombie.Weapons.Add(new Weapon
            {
                Name = "Bite",
                Damage = 4
            });
            zombie.Weapons.Add(new Weapon
            {
                Name = "Fists",
                Damage = 1
            });

            Console.WriteLine("you are fighting the " + zombie.EnemyClass + " named " + zombie.Name + ".");
            var result = _battleService.Fight(PlayerOne, zombie);
            if (result.Equals(BattleResult.PlayerWon))
            {
                Console.WriteLine("You kill the zombie. Do you continue [forward] or stop and [rest] for a little while?");
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
            else
            {
                Console.WriteLine("The zombie killed you! Your game is now over.");
            }
        }

        private static void GoLeft()
        {
            Console.WriteLine("As we begin our journey, you see a battle axe stuck in the trunk of a tree.  Do you [pick] up the battle axe or [leave] it and continue on?");
            var choice = Console.ReadLine();
            if (choice.Equals("pick"))
            {
                var battleAxe = new Weapon
                {
                    Name = "battle axe",
                    Damage = 4
                };
                PlayerOne.Weapons.Add(battleAxe);
                Console.WriteLine("You have picked up the battle axe and added it to your inventory");
                ListWeapons();
            }
            else if (choice.Equals("leave"))
            {
                Console.WriteLine("For some reason you don't another weapon... OK, boss.");
            }
            else
            {
                Console.WriteLine("Invalid choice. You're not very good at this!");
            }

            ContinueAfterBattleAxe();

        }

        private static void ContinueAfterBattleAxe()
        {
            Console.WriteLine("As you continue your journey, you come across a wizard. Do you [talk] to him or [walk] past him?");
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
