namespace Kata5;

public class CharacterManager
{
    private readonly ILogger _logger;
    private readonly List<Character> _characters = [];
    
    public CharacterManager(ILogger logger)
    {
        _logger = logger;
    }
    
    public Character CreateWarrior(string name, int health, int baseDamage)
    { 
        var warrior = new Character(name, health, baseDamage, new Sword(), _logger);
        _characters.Add(warrior);
        return warrior;
    }

    public Character CreateHealer(string name, int health, int baseDamage)
    {
        var healer = new Character(name, health, baseDamage, new Heal(), _logger);
        _characters.Add(healer);
        return healer;
    }

    public Character CreateMage(string name, int health, int baseDamage)
    {
        var mage = new Character(name, health, baseDamage, new Fireball(), _logger);
        _characters.Add(mage);
        return mage;
    }

    public Character CreateEnemy(string name, int health, int baseDamage)
    {
        var enemy = new Character(name, health, baseDamage, new Mace(), _logger);
        _characters.Add(enemy);
        return enemy;
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
}
