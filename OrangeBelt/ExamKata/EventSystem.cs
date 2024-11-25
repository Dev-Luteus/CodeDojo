namespace ExamKata;

public class EventSystem
{
    public void RegisterHealth(Character character)
    {
        character.HealthChanged += (name, health) =>
            Console.WriteLine($"  >> {name}'s health: {health}");
    }
}
