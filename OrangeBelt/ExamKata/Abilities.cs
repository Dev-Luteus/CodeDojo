namespace ExamKata;

public class Fireball : IAbility
{
    private Random luck = new Random();
    public void Use(Character user, Character target, ILogger _logger)
    {
        int luckDamage = luck.Next(1, 10);
        
        _logger.Log($"{user.Name} hurls a fireball at {target.Name} " +
                    $"dealing {user.Amount}+{luckDamage} damage!");
        
        target.ChangeHealth(-(user.Amount + luckDamage));
    }
}

public class Heal : IAbility
{
    private readonly Logger _logger;
    public void Use(Character user, Character target, ILogger _logger)
    {
        _logger.Log($"{user.Name} heals {target.Name} " +
                    $"for {user.Amount} points!");
        
        target.ChangeHealth(user.Amount);
    }
}

public class Sword : IAbility
{
    public void Use(Character user, Character target, ILogger _logger)
    {
        _logger.Log($"{user.Name} slashes with their sword towards {target.Name} " +
                    $"dealing {user.Amount} damage!");
        
        target.ChangeHealth(-user.Amount);
    }
}