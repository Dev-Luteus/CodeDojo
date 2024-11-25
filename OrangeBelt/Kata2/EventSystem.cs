namespace Kata2;

public static class EventSystem
{
    public static void RegisterHealth(Character character)
    {
        character.HealthChanged += (name, health) =>
            Console.WriteLine($"[Event] {name}'s health changed to {health}.");
    }
}
