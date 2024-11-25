namespace ExamKata;

public static class Game
{
    public static void Start(ILogger logger, CharacterManager characterManager)
    {
        var arin = characterManager.CreateWarrior("Arin", 100, 25);
        var dalia = characterManager.CreateHealer("Dalia", 100, 45);
        var cara = characterManager.CreateWarrior("Cara", 100, 25);
        var bran = characterManager.CreateMage("Bran", 60, 45);
        
        arin.UseAbility(dalia);
    }
}