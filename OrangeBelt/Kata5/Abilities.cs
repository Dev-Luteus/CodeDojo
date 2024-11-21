namespace Kata5;

public class Fireball : IAbility
{
    public void Use(Character user, Character target)
    {
        int damage = 50;
        target.ChangeHealth(-damage);
    }
}

public class Heal : IAbility
{
    public void Use(Character user, Character target)
    {
        int healAmount = 40;
        target.ChangeHealth(healAmount);
    }
}

public class Sword : IAbility
{
    public void Use(Character user, Character target)
    {
        int damage = 30;
        target.ChangeHealth(-damage);
    }
}