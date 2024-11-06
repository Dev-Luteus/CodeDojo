namespace MiniKata6;

class Program
{
    static void Main(string[] args)
    {
        string[] enemies = {"Goblin", "Orc", "Troll"};
        List<string> playerInventory = new List<string> {"Sword", "Shield", "Potion"};
        
        Console.WriteLine("Enemies: ");
        foreach (string EnemyName in enemies)
        {
            Console.WriteLine(EnemyName);
        }
        Console.WriteLine("\nPlayer Inventory Items: ");
        foreach (var ItemName in playerInventory)
        {
            Console.WriteLine(ItemName);
        }
        
        playerInventory.Add("Helmet");
        Console.WriteLine("\nUpdated Player Inventory Items: ");
        
        // Just to Demonstrate, I wanted to do this in Two ways. I can ofc make this code better!
        PrintList(playerInventory);
    }

    static void PrintList(List<string> list)
    {
        foreach (var itemName in list)
        {
            Console.WriteLine(itemName);
        }
    }
}