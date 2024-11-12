namespace Kata9;

class Program
{
    static void Main(string[] args)
    {
        var userChar = new Player("Arin", 100, 1);
        var enemyGoblin = new Enemy("Goblin", 50, 20);
        var npcCarl = new NPC("Carl", "Welcome to our village!");
        
        /* This could be done so much better. But I am sticking to the theme of defining attributes -
         * - upon initialisation. */
        var merchantEva = new Merchant(
            "Eva", 
            new List<string>() {"Sword, Shield, Potion"});
        
        userChar.Attack(enemyGoblin, 20);
        npcCarl.Speak("Welcome to our village!");
        merchantEva.Trade();
    }
}
class Player
{
    private string Name { get; set; }
    private int Health { get; set; }
    private int Level { get; set; }
    public Player(string name, int health, int level)
    {
        Name = name;
        Health = health;
        Level = level;
    }
    public void Attack(Enemy enemyType, int damage)
    {
        Console.WriteLine($"{Name} attacks {enemyType.Type} for {damage} damage!");
        enemyType.TakeDamage(this, damage);
    }
}
class Enemy
{
    public string Type { get; set; }
    private int Health { get; set; }
    private int Damage { get; set; }
    public Enemy(string type, int health, int damage)
    {
        Type = type;
        Health = health;
        Damage = damage;
    }
    public void TakeDamage(Player playerName, int damage)
    {
        Console.WriteLine($"{Type} takes {damage} damage! Remaining health: {Health}");
        Health -= damage;
    }
}
class NPC
{
    private string Name { get; set; }
    private string Dialogue { get; set; }
    /* I'm not using Consistent naming schemes here across constructors, but for learning purposes -
     * It tends to Solidify an idea of how something works better - */
    public NPC(string npcName, string dialogueString)
    {
        Name = npcName;
        Dialogue = dialogueString;
    }
    public void Speak(string dialogueString)
    {
        Console.WriteLine($"{this.Name}: {dialogueString}.");
    }
}
class Merchant
{
    private string Name { get; set; }
    private List<string> Inventory { get; set; }
    public Merchant(string name, List<string> inventory)
    {
        Name = name;
        Inventory = inventory;
    }
    public void Trade()
    {
        Console.Write($"{Name}'s Inventory: ");
        foreach (var itemName in Inventory)
        {
            Console.Write(itemName + " ");
        }
    }
}