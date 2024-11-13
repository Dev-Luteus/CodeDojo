namespace ExamKata;

class Program
{
    static void Main(string[] args)
    {
        var userChar = CharacterCreator.Create("Name", PlayerClass.Paladin);
        Console.WriteLine(userChar.Name);
        Console.WriteLine(userChar.Health);
        Console.WriteLine(userChar.Mana);
        Console.WriteLine(userChar.BaseDamage);
        Console.WriteLine(userChar.Armor);
    }
}