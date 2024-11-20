using System.Dynamic;

namespace Kata3;

public abstract class AbilityContainer<T>
{
    private List<T> Abilities { get; } = [];

    public void Add(T ability)
    {
        Console.WriteLine($"Added ability: {ability}");
        Abilities.Add(ability);
    }
    
    public void Remove(T ability)
    {
        Console.WriteLine($"Removed ability: {ability}");
        Abilities.Remove(ability);
    }
    
    public List<T> GetAbility(T ability)
    {
        return Abilities;
    }
    
    public void Display()
    {
        foreach (var ability in Abilities)
        {
            Console.WriteLine(ability);
        }
    }
}