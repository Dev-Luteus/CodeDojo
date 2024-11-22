namespace ExamKata;

public static class AbilityManager<T> where T : Character, IAbility 
{
    private static readonly List<T> Abilities = [];
    
    public static void AddAbility(T ability)
    {
        Abilities.Add(ability);
    }
    
    public static void RemoveAbility(T ability)
    {
        Abilities.Remove(ability);
    }
    
    public static void DisplayAbility(T ability)
    {
        foreach (var T in Abilities)
        {
            Console.WriteLine(Abilities);
        }
    }
}