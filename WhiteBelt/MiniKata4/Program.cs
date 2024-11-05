namespace MiniKata4;

class Program
{
    static void Main(string[] args)
    {
        int maxEnemies = 3;
        int enemiesSpawned = 0;
        
        Console.WriteLine("For Loop: ");
        for (int i = 0; i < 5; i++) {
            Console.WriteLine($"Enemy [{i + 1}] spawned!");
        }
        Console.WriteLine("\nWhile Loop:");
        while (enemiesSpawned < maxEnemies) {
            Console.WriteLine($"Enemy [{enemiesSpawned + 1}] spawned!");
            enemiesSpawned++;
        }
    }
}