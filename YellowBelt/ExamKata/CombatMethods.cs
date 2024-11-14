namespace ExamKata;

public static class CombatMethods
{
    private static Random luck = new Random();
    private static int luckDamage;
    private static int damageDealt;
    public static void Attack(Player player, Enemy enemy)
    {
        luckDamage = luck.Next(5, player.BaseDamage);
        damageDealt = player.BaseDamage + luckDamage;
        
        Console.Write("Player turn:\n" +
                      $"\x1b[93m{player.Name}\x1b[39m attacks \x1b[91m{enemy.Name}\x1b[39m " +
                      $"for \x1b[93m{damageDealt}\x1b[39m damage!\n\n");
        enemy.Health = Math.Max(0, enemy.Health - damageDealt);
    }
    public static void Heal(Player player)
    {
        int healAmount = 10 + luck.Next(5, 20); // If I had more time, this would not be hard-coded
        player.Health = Math.Min(player.MaxHealth, player.Health + healAmount);
        Console.WriteLine($"\x1b[93m{player.Name}\x1b[39m heals by \x1b[92m{healAmount}\x1b[39m points\n" +
                          $"\x1b[93m{player.Name}\x1b[39m Health: \x1b[92m{player.Health}\x1b[39m\n");
    }
}