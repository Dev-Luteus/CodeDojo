namespace ExamKata
{
    public class TurnManager
    {
        private readonly ILogger _logger;
        private List<Character> _teamAlpha;
        private List<Character> _teamBeta;
        
        private int TurnCount { get; set; }
        private int RoundCount { get; set; }

        public TurnManager(ILogger logger)
        {
            _teamAlpha = [];
            _teamBeta = [];
            TurnCount = 0;
            RoundCount = 1;
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
            _logger.Log("\nStarting the battle...");
        }

        public bool NextTurn()
        {
            var currentTeam = TurnCount % 2 == 0 ? _teamAlpha : _teamBeta;
            var currentCharacter = currentTeam[TurnCount / 2 % currentTeam.Count];

            _logger.Log($"\nRound {RoundCount}, Turn {TurnCount + 1}: \n" +
                        $"{currentCharacter.Name} ({(currentTeam == _teamAlpha ? "Team Alpha" : "Team Beta")}) " +
                        $"| Health: {currentCharacter.Health}, Mana: {currentCharacter.Mana}");

            if (currentCharacter.IsDefeated || (currentCharacter.Mana == 0 && currentCharacter.ClassType != "Warrior"))
            {
                _logger.Log($"{currentCharacter.Name} cannot take a turn.");
                
                return AdvanceTurn();
            }

            int actionChoice = ChooseAction(currentCharacter);
            if (actionChoice == currentCharacter.Abilities.Count)
            {
                _logger.Log($"{currentCharacter.Name} passed their turn.");
                
                return AdvanceTurn();
            }

            Character target = GetTarget(currentCharacter, actionChoice, currentTeam);
            currentCharacter.UseAbility(actionChoice, target);

            return AdvanceTurn();
        }

        private bool AdvanceTurn()
        {
            TurnCount++;
            if (TurnCount % 4 == 0)
            {
                RoundCount++;
                
                DisplayTeamStatus();
                _logger.Log("\nPress anything to continue...");
                
                // I could have made a new logger here.. ^^
                Console.ReadLine();
                Console.Clear();
                
                _logger.Log($"--- Round {RoundCount} ---");
            }

            return CheckWinCondition();
        }
        
        private void DisplayTeamStatus() // This could maybe be centralised? 
        {
            DisplayTeamMembers("\nTeam Alpha", _teamAlpha);
            DisplayTeamMembers("\nTeam Beta", _teamBeta);
        }

        private void DisplayTeamMembers(string teamName, List<Character> team)
        {
            _logger.Log(teamName);
            foreach (var member in team)
            {
                _logger.Log($"{member.Name}: Health: {member.Health} | Mana: {member.Mana}");
            }
        }

        private bool CheckWinCondition()
        {
            if (_teamAlpha.All(c => c.IsDefeated))
            {
                _logger.Log("Team Beta wins!");
                
                return false;
            }
            if (_teamBeta.All(c => c.IsDefeated))
            {
                _logger.Log("Team Alpha wins!");
                
                return false;
            }
            return true;
        }

        private int ChooseAction(Character character)
        {
            while (true) // I try to avoid this usually but it works. Please don't give me an F
            {
                _logger.Log("Choose action:");
                
                for (int i = 0; i < character.Abilities.Count; i++)
                {
                    _logger.Log($"> {i + 1}: {character.Abilities[i].GetType().Name} (Mana cost: {character.Abilities[i].ManaCost})");
                }
                
                _logger.Log($"> {character.Abilities.Count + 1}: Pass");
                _logger.Log("");

                if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= character.Abilities.Count + 1)
                {
                    return choice - 1;
                }
                
                _logger.Log("Invalid input. Please try again.");
            }
        }

        private Character GetTarget(Character currentCharacter, int actionChoice, List<Character> currentTeam)
        {
            var ability = currentCharacter.Abilities[actionChoice];
            
            if (ability is HealSelf)
            {
                return currentCharacter;
            }
            
            if (ability is Defend)
            {
                return null;
            }

            var targetTeam = ability is HealAlly ? currentTeam : (currentTeam == _teamAlpha ? _teamBeta : _teamAlpha);
            
            return ChooseTarget(targetTeam);
        }

        private Character ChooseTarget(List<Character> targetTeam)
        {
            while (true)
            {
                _logger.Log("Choose target:");
                
                for (int i = 0; i < targetTeam.Count; i++)
                {
                    _logger.Log($"> {i + 1}: {targetTeam[i].Name} ({targetTeam[i].ClassType})");
                }
                
                _logger.Log("");

                if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= targetTeam.Count)
                {
                    Console.Clear(); // Also here, not using a new logger type,, 
                    return targetTeam[choice - 1];
                }
                _logger.Log("Invalid input. Please try again.");
            }
        }
    }
}
