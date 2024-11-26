namespace ExamKata
{
    public static class Game
    {
        public static void Start(ILogger logger, CharacterFactory characterFactory, TurnManager turnManager)
        {
            var teamAlpha = new List<Character>
            {
                characterFactory.CreateWarrior("Arin", 100, 25),
                characterFactory.CreateHealer("Dalia", 100, 45)
            };

            var teamBeta = new List<Character>
            {
                characterFactory.CreateWarrior("Cara", 100, 25),
                characterFactory.CreateMage("Bran", 60, 45)
            };

            turnManager.SetTeams(teamAlpha, teamBeta);

            while (turnManager.NextTurn()) { }
        }
    }
}
