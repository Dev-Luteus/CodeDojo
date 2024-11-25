namespace ExamKata;

public class CharacterManager
{
    private readonly ILogger _logger;
    private readonly EventSystem _eventSystem;
    private readonly List<Character> _characters = [];
    
    public CharacterManager(ILogger logger, EventSystem eventSystem)
    {
        _logger = logger;
        _eventSystem = eventSystem;
    }

    private Character CreateCharacter<TAbility>
        (string name, int health, int baseDamage) where TAbility : IAbility, new()
    {
        var ability = new TAbility();
        var character = new Character(name, health, baseDamage, ability, _logger);
        
        _eventSystem.RegisterHealth(character);
        _characters.Add(character);
        return character;
    }

    public Character CreateWarrior(string name, int health, int baseDamage)
        => CreateCharacter<Sword>(name, health, baseDamage);

    public Character CreateHealer(string name, int health, int baseHealing)
        => CreateCharacter<Heal>(name, health, baseHealing);

    public Character CreateMage(string name, int health, int baseDamage)
        => CreateCharacter<Fireball>(name, health, baseDamage);
    
    public void Remove(string name)
    {
        var character = _characters.FirstOrDefault(c => c.Name == name);

        if (character == null)
        {
            _logger.Log($"Character with name '{name}' not found.");
            return;
        }

        _characters.Remove(character);
        _logger.Log($"Removed character: {character.Name}");
    }

    public void DisplayAllCharacters()
    {
        foreach (var character in _characters)
        {
            _logger.Log($"Character: {character.Name}, Health: {character.Health}, Base Damage: {character.Amount}");
        }
    }
}
