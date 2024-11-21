namespace Kata5;

class Program
{
    static void Main()
    {
        ILogger logger = new Logger();
        var characterManager = new CharacterManager(logger);
        var game = new Game(logger, characterManager); 
        
        game.Start();
    }
}
