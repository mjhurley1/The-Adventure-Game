using TheAdventureGame.Models;

namespace TheAdventureGame.Services
{
    public class BattleService
    {
        public BattleResult Fight(Player player, Enemy enemy)
        {
            return BattleResult.PlayerWon;
        }
    }

    public enum BattleResult
    {
        PlayerWon,
        PlayerDied
    }
}
