namespace ExamKata;

public static class Game
{
    public static void Start(ILogger logger, CharacterManager characterManager, TurnManager turnManager)
    {
        var arin = characterManager.CreateWarrior("Arin", 100, 25);
        var dalia = characterManager.CreateHealer("Dalia", 100, 45);
        var cara = characterManager.CreateWarrior("Cara", 100, 25);
        var bran = characterManager.CreateMage("Bran", 60, 45);
        
        var teamAlpha = new List<Character> { arin, dalia };
        var teamBeta = new List<Character> { cara, bran };
        turnManager.SetTeams(teamAlpha, teamBeta);

        do
        {
            turnManager.NextTurn();
            
        } while (turnManager._turnCount < 5);
    }
}