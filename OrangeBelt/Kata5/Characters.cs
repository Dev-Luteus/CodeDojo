namespace Kata5;

public class Character
{
    private readonly IAbility _ability;
    public string Name { get; set; }
    private int Health { get; set; }
    public int Damage { get; set; }
    
    public Character(string name, int health, int damage, IAbility ability)
    {
        Name = name;
        Health = health;
        Damage = damage;
        _ability = ability;
    }

    public void ChangeHealth(int amount)
    {
        Health += amount;
        EventSystem.OnHealthChanged(Name, Health);
    }

    public void UseAbility(Character target)
    {
        _ability.Use(this, target);
        EventSystem.OnUsedAbility($"{Name} used ability on {target.Name}");
    }
}
