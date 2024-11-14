namespace ExamKata
{
    public static class CombatSystem
    {
        public static void StartCombat(Player player, Enemy enemy)
        {
            bool combatActive = true;
            int turnCounter = 0;
            Console.WriteLine("STORY:\n" +
                              "------");
            Console.WriteLine($"> You encounter a \x1b[91m{enemy.Name}\x1b[39m <\n");
            
            while (combatActive)
            {
                Console.WriteLine($"\x1b[93m{player.Name}\x1b[39m Health: \x1b[92m{player.Health}\x1b[39m\n" +
                                  $"\x1b[91m{enemy.Name}\x1b[39m Health: \x1b[91m{enemy.Health}\x1b[39m\n");
                
                Console.WriteLine($"> TURN: [{turnCounter}] <");
                Console.WriteLine("Choose an action:");
                Console.WriteLine("\x1b[93m[A] Attack\x1b[39m");
                Console.WriteLine("\x1b[92m[B] Heal\x1b[39m");

                string choice = Console.ReadLine().ToUpper();
                Console.Clear();
                
                switch (choice)
                {
                    case "A":
                        CombatActions.Attack(player, enemy);
                        if (enemy.Health <= 0)
                        {
                            Console.WriteLine($"{enemy.Name} has been defeated!");
                            combatActive = false;
                            break;
                        }
                        EnemyAttack(player, enemy);
                        break;
                    
                    case "B":
                        CombatActions.Heal(player);
                        EnemyAttack(player, enemy);
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("\x1b[91m>> Invalid choice! Please choose 'A' or 'B' <<\x1b[39m");
                        break;
                }
                if (player.Health <= 0)
                {
                    Console.WriteLine($"{player.Name} has been defeated!");
                    combatActive = false;
                }
                turnCounter++;
            }
        }
        private static void EnemyAttack(Player player, Enemy enemy)
        {
            Console.WriteLine("Enemy turn:\n" +
                              $"\x1b[91m{enemy.Name}\x1b[39m attacks \x1b[93m{player.Name}\x1b[39m " +
                              $"for \x1b[91m{enemy.BaseDamage}\x1b[39m damage!\n");
            player.Health = Math.Max(0, player.Health - enemy.BaseDamage);
        }
    }
}