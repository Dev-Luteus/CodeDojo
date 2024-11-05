namespace Kata2;
class Program {
    static void Main(string[] args) { // annoying to edit all of them, string args survives
        string name = "Lira";
        int level = 5;
        float health = 75.5f;
        double experience = 1025.75;
        bool hasMagicAbility = true;
        char rank = 'A';

        double nextLevelThreshHold = 1200;
        double pointsToNextLevel = nextLevelThreshHold - experience;
        Console.WriteLine($"Name: {name}\n" +
                          $"Level: {level}\n" +
                          $"Health: {health}\n" +
                          $"Experience Points: {health}\n" +
                          $"Has Magic Ability: {hasMagicAbility}\n" +
                          $"Rank: {rank}\n" +
                          $"Points needed for next level: {pointsToNextLevel}");
    }
}