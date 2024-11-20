namespace Kata3;

internal abstract class Program
{
    private static void Main(string[] args)
    {
        var fireBall = new AttackAbility("Fireball", "Aoe Damage");
        var cureWounds = new HealAbility("Cure Wounds", "Touch-based Heal");
        Console.WriteLine(fireBall);
    }
}