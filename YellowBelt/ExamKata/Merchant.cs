namespace ExamKata;

public class Merchant : Character, INPC
{
    public static string _name;
    public string Type => "Merchant";
    public string Dialogue { get; set; }
    private List<string> Inventory { get; set; }
    
    internal Merchant(string name, List<string> inventory) : base(name)
    {
        _name = name;
        Inventory = inventory;
    }
    
    public void Speak(string dialogue)
    {
        Console.WriteLine($"({Type}): ");
        Console.WriteLine($"> {dialogue}");
    }
    
    public void Trade()
    {
        bool isTrading = true;

        do
        {
            DisplayInventory();
            int choice = GetValidChoice();

            if (choice == 0)
            {
                Thread.Sleep(500);
                Console.WriteLine("\nWithout interest in any option, you choose to go back.\n");
                Console.WriteLine("...");
                isTrading = false;
            }
            else
            {
                HandlePurchase(choice);
                Thread.Sleep(500);
                Console.WriteLine("\nYou can only afford one item! As such, your journey continues..");
                
                break;
            }
        } 
        while (isTrading);
    }

    private void DisplayInventory()
    {
        Console.WriteLine($"\n{Name}'s Inventory:");

        for (int i = 0; i < Inventory.Count; i++)
        {
            Console.Write($"[{i + 1}] {Inventory[i]} | ");
        }

        Console.WriteLine("\n[0] Back");
    }

    private int GetValidChoice()
    {
        int choice;
        bool isValid;

        do
        {
            Console.WriteLine("\nWhich item would you like to buy? (Enter the number):");
            string input = Console.ReadLine()!;

            isValid = int.TryParse(input, out choice) && choice >= 0 && choice <= Inventory.Count;

            if (!isValid)
            {
                Console.WriteLine("Invalid choice! Please try again.");
            }
        } 
        while (!isValid);

        return choice;
    }

    private void HandlePurchase(int choice)
    {
        Console.WriteLine($"\x1b[92m> You bought {Inventory[choice - 1]}! <\x1b[39m");
    }
}
