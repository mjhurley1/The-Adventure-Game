using TheAdventureGame.Models;

namespace TheAdventureGame.Services
{
    public class BattleService
    {
        public BattleResult Fight(Player player, Enemy enemy)
        {
            while (true)
            {
                enemy.Health = enemy.Health - player.Weapon.Damage;
                if (enemy.Health < 1)
                {
                    return BattleResult.PlayerWon;
                }

                player.Health = player.Health - enemy.Weapon.Damage;
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
