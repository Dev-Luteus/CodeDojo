namespace Kata5;

internal abstract class Program
{
    private static void Main()
    {
        ILogger logger = new Logger();
        var characterManager = new CharacterManager(logger);
        var game = new Game(logger, characterManager); 
        
        game.Start();
    }
}
