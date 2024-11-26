using System.Threading;
namespace ExamKata
{
    public static class CombatSystem
    {
        private static Random luck = new Random();
        private static int luckDamage;
        private static int damageDealt;
        
        public static void StartCombat(Player player, Enemy enemy)
        {
            bool combatActive = true;
            int turnCounter = 0;
            
            Thread.Sleep(500);
            Console.WriteLine("STORY:\n" +
                              "------");
            
            Thread.Sleep(500);
            Console.WriteLine($"> You encounter a \x1b[91m{enemy.Name}\x1b[39m <\n");
            
            while (combatActive)
            {
                Thread.Sleep(500);
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
                        Thread.Sleep(500);
                        CombatActions.Attack(player, enemy);
                        
                        if (enemy.Health <= 0)
                        {
                            // Here, I'd give the enemy an experienceAmount, which is rewarded to
                            // the player on death. Then experienceAmount could be given to the player.
                            // But I'm out of time.
                            
                            Console.WriteLine($"\x1b[91m{enemy.Name}\x1b[39m has been defeated!");
                            
                            Console.WriteLine($"\n\x1b[92m{player.Name}\x1b[39m" +
                                              $" gains\x1b[92m 30 \x1b[39m" +
                                              $"experience points!");
                            
                            player.ExperiencePoints += 30;
                            
                            combatActive = false;
                            break;
                        }
                        EnemyAttack(player, enemy);
                        
                        break;
                    
                    case "B":
                        Thread.Sleep(500);
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
            luckDamage = luck.Next(5, enemy.BaseDamage);
            damageDealt = enemy.BaseDamage + luckDamage;
            
            Thread.Sleep(500);
            Console.WriteLine("Enemy turn:\n" +
                              $"\x1b[91m{enemy.Name}\x1b[39m attacks \x1b[93m{player.Name}\x1b[39m " +
                              $"for \x1b[91m{damageDealt}\x1b[39m damage!\n");
            
            player.Health = Math.Max(0, player.Health - damageDealt);
        }
    }
}