namespace ExamKata;

public class Character
{
    private readonly IAbility _ability;
    private readonly ILogger _logger;
    public event Action<string, int>? HealthChanged;
    
    public string Name { get; set; }
    public string ClassType { get; private set; }
    public int Health { get; private set; }
    public int Amount { get; set; }
    public int Mana { get; private set; }
    
    public Character(string name, string classType, int health, int amount, int mana, 
        IAbility ability, ILogger logger)
    {
        Name = name;
        ClassType = classType;
        Health = health;
        Amount = amount;
        Mana = mana;
        _ability = ability;
        _logger = logger;
    }
    
    public void UseAbility(Character target)
    {
        _ability.Use(this, target, _logger);
    }

    public void ChangeHealth(int amount)
    {
        Health += amount;
        HealthChanged?.Invoke(Name, Health);
    }
}