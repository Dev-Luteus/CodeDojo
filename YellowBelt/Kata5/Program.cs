namespace Kata5;

class Program
{
    static void Main(string[] args)
    {
        AttackEnemy("Goblin",20);
        HealPlayer("Arin", 15);
    }
    static void AttackEnemy(string enemyName, int damage)
    {
        Console.WriteLine($"You attack {enemyName} for {damage} damage!");
    }
    static void HealPlayer(string playerName, int healAmount)
    {
        Console.WriteLine($"Player {playerName} heals for {healAmount} points!");
    }
}