using System.Dynamic;

namespace Kata3;

public class AbilityContainer<T> where T : IAbility
{
    private List<T> Abilities { get; } = [];

    public void Add(T ability)
    {
        Console.WriteLine($"Added ability: {ability.Name}");
        Abilities.Add(ability);
    }
    
    public void Remove(T ability)
    {
        Console.WriteLine($"Removed ability: {ability.Name}");
        Abilities.Remove(ability);
    }
    private bool Retrieve(T ability)
    {
        return Abilities.Contains(ability);
    }
    
    public void ContainsAbility(T ability)
    {
        Console.WriteLine(Retrieve(ability));
    }
    
    public void Display()
    {
        foreach (var ability in Abilities)
        {
            Console.WriteLine(ability);
        }
    }
}