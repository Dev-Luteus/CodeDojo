namespace Kata5;

public class Game
{
    private readonly ILogger _logger;
    public Game(ILogger logger) => _logger = logger;
    public void Start()
    {
        _logger.Log("Game started!");
    }
}
