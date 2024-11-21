namespace Kata5;

public interface IAbility
{
    void Use(Character user, Character target);
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