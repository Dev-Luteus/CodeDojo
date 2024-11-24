namespace Kata2;

public static class Game
{
    public static void Start()
    {
        var abel = new Warrior("Abel", 100);
        var babel = new Warrior("Babel", 100);
        var celine = new Healer("Celine", 80);

        EventSystem.RegisterHealth(abel);
        EventSystem.RegisterHealth(babel);
        
        abel.Attack(babel, 20);
        Console.WriteLine();
        celine.Heal(babel, 15);
    }
}