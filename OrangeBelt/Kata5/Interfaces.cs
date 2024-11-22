namespace Kata5;

public interface IAbility
{
    void Use(Character user, int amount, Character target, ILogger logger);
}

public interface ICombat
{
    int Health { get; }
    int Damage { get; }
}

public interface ICharacter
{
    string Name { get; }
}