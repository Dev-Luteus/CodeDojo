namespace Kata5;

class Program
{
    static void Main()
    {
        ILogger logger = new Logger();
        var game = new Game(logger); 
        game.Start();
    }
}
