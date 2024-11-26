namespace ExamKata;

public class Villager : Character, INPC
{
    public static string _name;
    public string Type => "Villager";
    public string Dialogue { get; set; }
    
    internal Villager(string name) : base(name)
    {
        _name = name;
    }
    
    public void Speak(string dialogue)
    {
        Console.WriteLine($"({Type}): ");
        Console.WriteLine($"> {dialogue}");
    }
}