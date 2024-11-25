namespace ExamKata
{
    public class TurnManager
    {
        private List<Character> _teamAlpha;
        private List<Character> _teamBeta;
        public int TurnCount { get; private set; }
        private readonly ILogger _logger;

        public TurnManager(ILogger logger)
        {
            _teamAlpha = [];
            _teamBeta = [];
            TurnCount = 0;
            _logger = logger;
        }

        public void SetTeams(List<Character> teamAlpha, List<Character> teamBeta)
        {
            _teamAlpha = teamAlpha;
            _teamBeta = teamBeta;
            DisplayTeams();
        }

        private void DisplayTeams()
        {
            _logger.Log("--- Welcome to the Battle Arena! ---");
            _logger.Log($"Team Alpha: {string.Join(", ", _teamAlpha.Select(c => $"{c.ClassType} {c.Name}"))}");
            _logger.Log($"Team Beta: {string.Join(", ", _teamBeta.Select(c => $"{c.ClassType} {c.Name}"))}");
            _logger.Log("\nStarting the battle...\n");
        }

        public void NextTurn()
        {
            var currentTeam = TurnCount % 2 == 0 ? _teamAlpha : _teamBeta;
            var currentCharacter = currentTeam[TurnCount / 2 % currentTeam.Count];
            _logger.Log($"Turn {TurnCount + 1}: {currentCharacter.Name} ({(currentTeam == _teamAlpha ? "Team Alpha" : "Team Beta")})");

            ResetDefendingIfNeeded(currentCharacter);

            int actionChoice = ChooseAction(currentCharacter);
            if (actionChoice == currentCharacter.Abilities.Count)
            {
                _logger.Log($"{currentCharacter.Name} passed their turn.");
                TurnCount++;
                return;
            }

            Character target = null;
            if (currentCharacter.Abilities[actionChoice] is HealSelf)
            {
                target = currentCharacter;
            }
            else if (!(currentCharacter.Abilities[actionChoice] is Defend))
            {
                var targetTeam = currentCharacter.Abilities[actionChoice] is HealAlly ? currentTeam : (currentTeam == _teamAlpha ? _teamBeta : _teamAlpha);
                int targetChoice = ChooseTarget(targetTeam);
                target = targetTeam[targetChoice];
            }
            
            currentCharacter.UseAbility(actionChoice, target);

            TurnCount++;
        }

        private int ChooseAction(Character character)
        {
            _logger.Log("Choose action:");
            for (int i = 0; i < character.Abilities.Count; i++)
            {
                _logger.Log($"> {i + 1}: {character.Abilities[i].GetType().Name}");
            }
            _logger.Log($"> {character.Abilities.Count + 1}: Pass");
            _logger.Log("");
            
            return int.Parse(Console.ReadLine() ?? "0") - 1;
        }

        private int ChooseTarget(List<Character> opposingTeam)
        {
            _logger.Log("Choose target:");
            for (int i = 0; i < opposingTeam.Count; i++)
            {
                _logger.Log($"> {i + 1}: {opposingTeam[i].Name} ({opposingTeam[i].ClassType})");
            }
            _logger.Log("");
            
            return int.Parse(Console.ReadLine() ?? "0") - 1;
        }

        private void ResetDefendingIfNeeded(Character character)
        {
            if (character.IsDefending)
            {
                character.IsDefending = false;
                _logger.Log($"{character.Name} is no longer defending.");
            }
        }
    }
}
