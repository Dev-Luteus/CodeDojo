using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Threading.Channels;

namespace MiniKata7;

class Program
{
    static void Main(string[] args)
    {
        Player userChar = new("Arin", 100, 1);
        
        //I could just do "var enemy" but whatever
        var Goblin = new Enemy("Goblin", 50, 10);
        
        Console.WriteLine("Player Info: " +
                          $"\n{userChar.Name}" + $"\n{userChar.Health}" + $"\n{userChar.Level}");
        Console.WriteLine("\nEnemy Info: " +
                          $"\n{Goblin.Name}" + $"\n{Goblin.Health}" + $"\n{Goblin.Damage}");
    }
}

public class Player
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Level { get; set; }
    public Player(string name, int health, int level)
    {
        Name = name;
        Health = health;
        Level = level;
    }
}
class Enemy
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Damage { get; set; }
    public Enemy(string name, int health, int damage)
    {
        Name = name;
        Health = health;
        Damage = damage;
    }
}