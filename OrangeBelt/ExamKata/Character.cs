namespace ExamKata;

public class Character
{
    private readonly IAbility _ability;
    private readonly ILogger _logger;
    public event Action<string, int>? HealthChanged;
    public string Name { get; set; }
    public int Health { get; private set; }
    public int Amount { get; set; }
    
    public Character(string name, int health, int amount, IAbility ability, ILogger logger)
    {
        Name = name;
        Health = health;
        Amount = amount;
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
