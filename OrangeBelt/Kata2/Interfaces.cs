namespace Kata2;

public interface IAttack
{
    public void Attack(Character target, int damage);
}

public interface IHeal
{
    public void Heal(Character target, int healthPoints);
}