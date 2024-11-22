namespace Kata2;

public static class Game
{
    public static void Start()
    {
        var abel = new Warrior("Abel", 100);
        var babel = new Warrior("Babel", 100);
        var celine = new Healer("Celine", 80);

        EventSystem.SubscribeToHealthChanged((name, health) =>
            Console.WriteLine($"[Event] {name}'s health changed to {health}."));

        abel.Attack(babel, 20);
        Console.WriteLine();
        celine.Heal(babel, 15);
    }
}