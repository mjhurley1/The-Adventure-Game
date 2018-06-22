using TheAdventureGame.Models;
using System.Linq;
using System;

namespace TheAdventureGame.Services
{
    public class BattleService
    {
        public BattleResult Fight(Player player, Enemy enemy)
        {
            var playerWeapon = player.Weapons.First();
            Console.WriteLine(player.Name + " has chosen to use his/her " + playerWeapon.Name + " with damage of " + playerWeapon.Damage);

            var ememyWeapon = enemy.Weapons.First();
            Console.WriteLine(enemy.Name + " has chosen to use its " + ememyWeapon.Name + " with damage of " + ememyWeapon.Damage);

            while (true)
            {
                enemy.Health = enemy.Health - playerWeapon.Damage;
                if (enemy.Health < 1)
                {
                    return BattleResult.PlayerWon;
                }

                player.Health = player.Health - ememyWeapon.Damage;
                if (player.Health < 1)
                {
                    return BattleResult.PlayerDied;
                }
            }
        }
    }

    public enum BattleResult
    {
        PlayerWon,
        PlayerDied
    }
}
