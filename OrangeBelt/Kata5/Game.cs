namespace Kata5;

public class Game
{
    private readonly ILogger _logger;
    private readonly CharacterManager _characterManager;
    
    public Game(ILogger logger, CharacterManager characterManager)
    {
        _logger = logger;
        _characterManager = characterManager;
    }

    public void Start()
    {
        _logger.Log("Game started!");
        // Create character here
    }
}
