namespace Level_1;

public abstract class Program 
{
    private static void Main(string[] args) 
    {
        var characters = new List<Character> 
        {
            new Warrior("Abel", 60, new WarriorRole()),
            new Healer("Mara", 30, new HealerRole()),
            new Warrior("Babel", 40, new WarriorRole()),
            new Warrior("Cara", 45, new WarriorRole())
        };
        
        Game.Start(characters);
    }
}
