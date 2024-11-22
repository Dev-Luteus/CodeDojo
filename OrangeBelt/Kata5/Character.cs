namespace Kata5;

public class Character
{
    private readonly IAbility _ability;
    private readonly ILogger _logger;
    public string Name { get; set; }
    public int Health { get; set; }
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
        _ability.Use(this, Amount, target, _logger);
        _logger.Log($"{target.Name} new health: {target.Health}");
    }
}
