namespace Kata9;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player();
        player.Name = "PlayerName";
        Console.WriteLine(player.Name);
    }
}

abstract class Character
{
    protected string Name { get; set; }
    protected int Level { get; set; }
    protected int Health { get; set; }
}
class Player : Character
{
    /* "new" : member hiding
     * public new string Name { get => base.Name; set => base.Name = value; } */
    
}

class Enemy : Character
{
    public new string Name { get => base.Name; set => base.Name = value; }
}