namespace Kata1;

public static class Game
{
    public static void Start(List<Character> characters)
    {
        // Definitely Violates SRP, OCP and DIP
        
        Console.WriteLine("\x1b[92mStarting actions based on character health...\x1b[39m");
        var lowHealthWarriors = characters.OfType<Warrior>().Where(w => w.Health < 50);

        Console.WriteLine();
        Console.WriteLine("Characters attacking first (health < 50):");
        foreach (var warrior in lowHealthWarriors)
        {
            Console.WriteLine($"(Warrior) {warrior.Name} is attacking first due to low health! Health: {warrior.Health}");
        }
        Console.WriteLine();
        
        var healers = characters.OfType<Healer>();
        foreach (var healer in healers)
        {
            healer.AnnouncePriority(characters);
        }
        
        Console.WriteLine();
        Console.WriteLine("Additional character actions based on role:");
        
        characters.OrderBy(c => c.Health)
                   .ToList()
                   .ForEach(c => c.ExecutePrimaryAction(characters));
    }
}
