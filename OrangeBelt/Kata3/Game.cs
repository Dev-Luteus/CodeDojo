namespace Kata3;

public static class Game
{
    public static void Start()
    {
        var fireBall = new AttackAbility("Fireball", "Aoe Damage");
        var cureWounds = new HealAbility("Cure Wounds", "Touch-based Heal");
        var abilityContainer = new AbilityContainer<IAbility>();
        
        abilityContainer.Add(fireBall);
        abilityContainer.Add(cureWounds);
        abilityContainer.ContainsAbility(cureWounds);
    }
}