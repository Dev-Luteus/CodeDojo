namespace Level_1;

public class WarriorRole
{
    public Action<Character, List<Character>> AttackAction { get; private set; }

    public WarriorRole()
    {
        AttackAction = (character, characters) =>
        {
            Console.WriteLine($"(Warrior) {character.Name} is standing by with health: {character.Health}");
            Console.WriteLine($"{character.Name} charges with a fierce attack!");
        };
    }
}

public class HealerRole
{
    public Action<Character, List<Character>> HealAction { get; private set; }

    public HealerRole()
    {
        HealAction = (character, characters) =>
        {
            var target = FindLowestHealthWarrior(characters);
            
            Console.WriteLine($"(Healer) {character.Name} is healing someone with low health!");
            Console.WriteLine($"{character.Name} performs a powerful healing spell on {target.Name}!");
            Console.WriteLine();
        };
    }

    private Character FindLowestHealthWarrior(List<Character> characters)
    {
        return characters
            .Where(c => c is Warrior)
            .OrderBy(c => c.Health)
            .First();
    }

    public void AnnouncePriority(Character character, List<Character> characters)
    {
        var target = FindLowestHealthWarrior(characters);
        
        Console.WriteLine($"(Healer) {character.Name} is prioritizing healing " +
                          $"for (Warrior) {target.Name}! They have the lowest health.");
    }
}
