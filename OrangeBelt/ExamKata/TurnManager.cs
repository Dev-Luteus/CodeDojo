namespace ExamKata;

public class TurnManager
{
    private List<Character> _teamAlpha;
    private List<Character> _teamBeta;
    public int _turnCount;
    private readonly ILogger _logger;
    
    public TurnManager(ILogger logger)
    {
        _teamAlpha = [];
        _teamBeta = [];
        _turnCount = 0;
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
        _logger.Log("Starting the battle...");
    }
    
    public void NextTurn()
    {
        var currentTeam = _turnCount % 2 == 0 ? _teamAlpha : _teamBeta;
        var currentCharacter = currentTeam[_turnCount / 2 % currentTeam.Count];
        
        _logger.Log($"Turn {_turnCount + 1}: {currentCharacter.Name} ({(currentTeam == _teamAlpha ? "Team Alpha" : "Team Beta")})");
        
        ChooseAction(currentCharacter);
        
        _turnCount++;
    }
    
    private void ChooseAction(Character character)
    {
        _logger.Log("\nChoose action:");
    }
}