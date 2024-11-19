using System.Threading.Channels;

namespace Kata2;

class Program
{
    static void Main(string[] args)
    {
        var wAbel = new Warrior("Abel", 100);
        var wBabel = new Warrior("Babel", 100);
        var hCeline = new Healer("Celine", 80);
        
        EventSystem.SubscribeToHealthChanged((name, health) =>
            Console.WriteLine($"[Event] {name}'s health changed to {health}."));

        wAbel.Attack(wBabel, 20);
        Console.WriteLine();
        hCeline.Heal(wBabel, 15);
    }
}
