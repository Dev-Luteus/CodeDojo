namespace ExamKata
{
    public static class Game
    {
        public static void Start(ILogger logger, CharacterManager characterManager, TurnManager turnManager)
        {
            var teamAlpha = new List<Character>
            {
                characterManager.CreateWarrior("Arin", 100, 25),
                characterManager.CreateHealer("Dalia", 100, 45)
            };

            var teamBeta = new List<Character>
            {
                characterManager.CreateWarrior("Cara", 100, 25),
                characterManager.CreateMage("Bran", 60, 45)
            };

            turnManager.SetTeams(teamAlpha, teamBeta);

            while (turnManager.NextTurn()) { }
        }
    }
}
