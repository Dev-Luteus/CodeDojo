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
    
    private Character CreateCharacter<TAbility, TAbility2>
        (string name, string classType, int health, int baseDamage, int mana) where TAbility : IAbility, new()
    {
        var ability = new TAbility();
        var character = new Character(name, classType, health, baseDamage, mana, ability, _logger);
        
        _eventSystem.RegisterHealth(character);
        _characters.Add(character);
        return character;
    }
    
    public Character CreateWarrior(string name, int health, int baseDamage)
        => CreateCharacter<Sword, Pass>(name, "Warrior", health, baseDamage, 0);

    public Character CreateHealer(string name, int health, int baseHealing)
        => CreateCharacter<Heal, Pass>(name, "Healer", health, baseHealing, 100);

    public Character CreateMage(string name, int health, int baseDamage)
        => CreateCharacter<Fireball, IceBlast>(name, "Mage", health, baseDamage, 100);
}