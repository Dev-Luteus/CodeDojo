using System.Threading;
namespace ExamKata;

public static class Story
{
    public static void FirstAct()
    {
        Thread.Sleep(500);
        Console.WriteLine("\n...\n");
        Thread.Sleep(500);
        
        var Edgard = new Villager("Edgard");
        
        // I could have made an NPC actions system, I know
        Edgard.Speak("Welcome to our village! " +
                     $"My name is \x1b[92m{Villager._name}\x1b[39m!");
    }
    public static void SecondAct()
    {
        Thread.Sleep(500);
        Console.WriteLine("\n...\n");
        Thread.Sleep(500);
        
        var Eva = new Merchant("Eva", ["Sword", "Shield", "Health Potion"]);
        
        Eva.Speak("You look like you need gear! Come, take a look at my wares." +
                  $"\n> My name is \x1b[92m{Merchant._name}\x1b[39m!");
        Thread.Sleep(500);
        
        Eva.Trade();
        Thread.Sleep(500);
        
        
        Console.WriteLine("\n...\n");
        Console.WriteLine("To be continued...");
    }
}