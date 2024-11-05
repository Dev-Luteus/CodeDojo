namespace MiniKata1;

class Program
{
    static void Main(string[] args)
    {
        string charName = "Arin";
        int charHealth = 100;
        float attackPower = 15.5f;
        bool isParalyzed = true;
        double goldCoins = 24.75;
        Console.WriteLine($"Character Name: {charName}\n" +
                          $"Health Points: {charHealth}\n" +
                          $"Attack Power: {attackPower}\n" +
                          $"Is Paralyzed: {isParalyzed}\n" +
                          $"Gold Coins: {goldCoins}");
    }
}