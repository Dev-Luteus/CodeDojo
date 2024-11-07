using System.ComponentModel.DataAnnotations;
using System.Threading.Channels;

namespace MiniKata7;

class Program
{
    static void Main(string[] args)
    {
        var User = new Player();
        
        User.name = "Arin";
        User.health = 100;
        User.level = 1;
        
        Console.WriteLine($"{User.name}" + $"\n{User.health}" + $"\n{User.level}");
        var Goblin = new Enemy("Goblin", 50, 10);
    }
}

class Player()
{
    public string name { get; set; }
    public int health { get; set; }
    public int level { get; set; }
}
class Enemy(string type, int health, int damage)
{
}