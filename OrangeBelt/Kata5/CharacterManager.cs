namespace Kata5;

public class CharacterManager
{
    private readonly ILogger _logger;
    private readonly List<Character> _characters = new();

    public CharacterManager(ILogger logger)
    {
        _logger = logger;
        _logger.Log("CharacterManager initialized.");
    }
    
    public Character CreateWarrior(string name)
    {
        return new Character(name, 100, 20, new Sword());
    }

    public Character CreateHealer(string name)
    {
        return new Character(name, 75, 10, new Heal());
    }

    public Character CreateMage(string name)
    {
        return new Character(name, 50, 15, new Fireball());
    }
    
    public void AddCharacter(string name, int health, int damage, IAbility ability, ICombat combat)
    {
        var character = new Character(name, health, damage, ability);
        _characters.Add(character);
        _logger.Log($"Added character: {character.Name}");
    }

    public void Remove(Character character)
    {
        if (_characters.Remove(character))
        {
            _logger.Log($"Removed character: {character.Name}");
        }
    }
}
