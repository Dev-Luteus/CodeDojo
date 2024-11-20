namespace Kata2;

public static class EventSystem
{
    public static event Action<string, int>? HealthChanged;
    public static void OnHealthChanged(string characterName, int health)
    {
        HealthChanged?.Invoke(characterName, health);
    }
    
    public static void SubscribeToHealthChanged(Action<string, int> subscribeAction)
    {
        HealthChanged += subscribeAction;
    }
    
    public static void UnsubscribeFromHealthChanged(Action<string, int> unsubscribeAction)
    {
        HealthChanged -= unsubscribeAction;
    }
}
