namespace Kata2;

public class Character
{
    private Action Action { get; set; }
    public event Action<int> HealthChanged;
    public string Name { get; set; }
    public int Health { get; set; }

    public void Attack(Character target, int damage)
    {
        Action?.Invoke();
        target.Health -= damage;
        HealthChanged?.Invoke(target.Health);
    }
    public Character(string name, int health)
    {
        Name = name;
        Health = health;
    }
}