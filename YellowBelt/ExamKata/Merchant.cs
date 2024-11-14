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
        Console.Write($"\n{Name}'s Inventory: ");
        Thread.Sleep(500);
        foreach (var itemName in Inventory)
        {
            Console.Write(itemName + " | ");
        }
    }
}