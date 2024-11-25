namespace ExamKata;

public abstract class Luck
{
    protected readonly Random luck = new Random();
}

public class Pass : IAbility
{
    public void Use(Character user, Character target, ILogger logger)
    {
        logger.Log($"{user.Name} passed their turn!");
    }
}

public class Fireball : Luck, IAbility
{
    public void Use(Character user, Character target, ILogger logger)
    {
        int luckDamage = luck.Next(5, 15);
        
        logger.Log($"{user.Name} hurls a fireball at {target.Name} " +
                    $"dealing {user.Amount}+{luckDamage} damage!");
        
        target.ChangeHealth(-(user.Amount + luckDamage));
    }
}

public class IceBlast : Luck, IAbility
{
    public void Use(Character user, Character target, ILogger logger)
    {
        int luckDamage = luck.Next(10, 25);
        
        logger.Log($"{user.Name} shoots an ice blast at {target.Name} " +
                    $"dealing {user.Amount}+{luckDamage} damage!");
        
        target.ChangeHealth(-(user.Amount + luckDamage));
    }
}

public class Heal : IAbility
{
    public void Use(Character user, Character target, ILogger logger)
    {
        logger.Log($"{user.Name} heals {target.Name} " +
                    $"for {user.Amount} points!");
        
        target.ChangeHealth(user.Amount);
    }
}

public class Sword : IAbility
{
    public void Use(Character user, Character target, ILogger logger)
    {
        logger.Log($"{user.Name} slashes with their sword towards {target.Name} " +
                    $"dealing {user.Amount} damage!");
        
        target.ChangeHealth(-user.Amount);
    }
}

