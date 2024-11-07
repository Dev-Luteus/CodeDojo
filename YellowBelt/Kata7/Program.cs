namespace Kata7;

class Program
{
    static void Main(string[] args)
    {
        var hero = new Player("Arin", 100, 1, 0);
        var enemy = new Enemy("Orc", 110, 15);
        
        hero.Attack(enemy, 25);
        Console.WriteLine();
        hero.Attack(enemy, 100);
    }
}

class Player
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Level { get; set; }
    public int Experience { get; set; }

    public void Attack(Enemy enemyType, int damage)
    {
        Console.WriteLine($"\x1b[92m{Name}\x1b[39m attacks \x1b[91m{enemyType.Type}\x1b[39m for {damage} damage!");
        enemyType.TakeDamage(damage, this);
    }
    public void GainExperience(int exp)
    {
        Console.WriteLine($"\x1b[92m{Name}\x1b[39m gains \x1b[92m{exp}\x1b[39m experience!");
        this.Experience += exp;
    }
    public Player(string name, int health, int level, int experience)
    {
        Name = name;
        Health = health;
        Level = level;
        Experience = experience;
    }
}
class Enemy
{
    public string Type { get; set; }
    public int Health { get; set; }
    public int Damage { get; set; }

    public void TakeDamage(int damage, Player hero)
    {
        Health -= damage;
        Console.WriteLine($"\x1b[91m{Type}\x1b[39m takes {damage} damage!\n" +
                          $"\x1b[91m{Type}\x1b[39m remaining health: \x1b[91m{Health}\x1b[39m");
        if (Health <= 0)
        {
            Console.WriteLine($"\n\x1b[91m{Type}\x1b[39m defeated!");
            hero.GainExperience(20);
        }
    }
    public Enemy(string type, int health, int damage)
    {
        Type = type;
        Health = health;
        Damage = damage;
    }
}