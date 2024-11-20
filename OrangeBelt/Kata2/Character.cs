namespace Kata2;

public abstract class Character(string name, int health)
{
    public string Name { get; set; } = name;
    private int Health { get; set; } = health;
    
    public void ChangeHealth(int amount)
    {
        Health += amount;
        EventSystem.OnHealthChanged(Name, Health);
    }
}

internal class Warrior(string name, int health) : Character(name, health), IAttack
{
    public void Attack(Character target, int damage)
    {
        target.ChangeHealth(-damage);
        Console.WriteLine($"{Name} is attacking {target.Name} for {damage} damage");
    }
}

internal class Healer(string name, int health) : Character(name, health), IHeal
{
    public void Heal(Character target, int healthPoints)
    {
        target.ChangeHealth(healthPoints);
        Console.WriteLine($"{Name} healed {target.Name} for {healthPoints} points! ");
    }
}