namespace Kata2;

class Program
{
    static void Main(string[] args)
    {
        var charEdgard = new Character("Edgard", 100);
        var charYourEx = new Character("Your Ex", 100);

        Console.WriteLine($"{charEdgard.Name} is attacking {charYourEx.Name}!");
        Console.WriteLine($"{charYourEx.Name} Max Health: {charYourEx.Health}");
        
        charEdgard.Attack(charYourEx, 20);
        charYourEx.Health -= charYourEx.HealthChanged.Invoke();
    }
}