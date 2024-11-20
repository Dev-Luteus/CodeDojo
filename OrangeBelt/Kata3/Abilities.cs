namespace Kata3;

public class AttackAbility(string name, string effect) : IAbility
{
    public string Name { get; set; } = name;
    public string Effect { get; set; } = effect;
}
public class HealAbility(string name, string effect) : IAbility
{
    public string Name { get; set; } = name;
    public string Effect { get; set; } = effect;
}