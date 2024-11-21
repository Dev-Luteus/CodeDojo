namespace Kata5;

public static class EventSystem
{
    public static event Action<string, int>? HealthChanged;
    public static event Action<string>? UsedAbility;

    public static void OnUsedAbility(string message)
    {
        UsedAbility?.Invoke(message);
    }
    public static void OnHealthChanged(string characterName, int health)
    {
        HealthChanged?.Invoke(characterName, health);
    }
    
    public static void SubscribeToHealthChanged(Action<string, int> handler)
    {
        HealthChanged += handler;
    }
    
    public static void UnsubscribeFromHealthChanged(Action<string, int> handler)
    {
        HealthChanged -= handler;
    }
}
