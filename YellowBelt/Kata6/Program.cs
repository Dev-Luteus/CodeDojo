namespace Kata6;

class Program
{
    static void Main(string[] args)
    {
        string[] enemies = {"Goblin","Orc","Troll","Skeleton","Dragon"};
        List<string> playerInventory = new List<string>(){"Sword", "Shield", "Potion"};
        
        Console.WriteLine("Enemies:");
        foreach (var enemyName in enemies)
        {
            Console.WriteLine(enemyName);
        }
        
        Console.WriteLine("\nPlayer inventory:");
        PrintList(playerInventory);
        
        playerInventory.Add("Armor");
        playerInventory.Add("Helmet");
        playerInventory.Remove("Potion");
        
        Console.WriteLine("\nUpdated Player Inventory");
        PrintList(playerInventory);
        Console.WriteLine($"\nTotal items in Player Inventory: {playerInventory.Count}");
    }
    static void PrintList(List<string> list)
    {
        foreach (var itemName in list)
        {
            Console.WriteLine(itemName);
        }
    }
}