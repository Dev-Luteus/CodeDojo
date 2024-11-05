namespace MiniKata2;

class Program
{
    static void Main(string[] args)
    {
        string name = "Arin";
        string goldString = "150,333333";
        int healthPoints = 100;
        float attackPower = 30f;
        float experiencePoints = 250f;
        //bool isParalyzed = false;
        //double currencyAmount = 150;

        double charHealth = healthPoints;
        attackPower = (int)attackPower;
        Convert.ToInt32(experiencePoints);
        Double.Parse(goldString);
        
        bool isNameParsed = int.TryParse(name, out int result);
        if (isNameParsed == false) {
            name = "Parsing failed: name is not a number.";
        }
        
        Console.WriteLine($"Health: {charHealth}\n" +
                          $"Attack Power: {attackPower}\n" +
                          $"Experience Points: {experiencePoints}\n" +
                          $"Gold Coins: {goldString}\n" +
                          $"Name: {name}");
    }
}