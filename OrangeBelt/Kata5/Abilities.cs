namespace Kata5;

public class Fireball : IAbility
{
    public void Use(Character user, int damage, Character target, ILogger _logger)
    {
        target.Health -= damage;
        _logger.Log($"{user.Name} hurls a fireball at {target.Name} " +
                    $"dealing {damage} damage!");
    }
}

public class Heal : IAbility
{
    private readonly Logger _logger;
    public void Use(Character user, int healthPoints, Character target, ILogger _logger)
    {
        target.Health += healthPoints;
        _logger.Log($"{user.Name} heals {target.Name} " +
                    $"for {healthPoints} points!");
    }
}

public class Sword : IAbility
{
    public void Use(Character user, int damage, Character target, ILogger _logger)
    {
        target.Health -= damage;
        _logger.Log($"{user.Name} slashes with their sword towards {target.Name} " +
                    $"dealing {damage} damage!");
    }
}

public class Mace : IAbility
{
    public void Use(Character user, int damage, Character target, ILogger _logger)
    {
        target.Health -= damage;
        _logger.Log($"{user.Name} swings their mace towards {target.Name} " +
                    $"dealing {damage} damage!");
    }
}