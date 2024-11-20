namespace Kata3;

internal abstract class Program
{
    private static void Main(string[] args)
    {
        var fireBall = new AttackAbility("Fireball", "Aoe Damage");
        var cureWounds = new HealAbility("Cure Wounds", "Touch-based Heal");
        var abilityContainer = new AbilityContainer<IAbility>();
        
        abilityContainer.Add(fireBall);
        abilityContainer.Add(cureWounds);
        abilityContainer.ContainsAbility(cureWounds);
    }
}