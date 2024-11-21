namespace Kata5;

class Program
{
    static void Main()
    {
        ILogger logger = new Logger();
        
        /* INSTEAD of: Game rely on Logger, Inverse it > Make game rely on ILogger
         * 
         * If Game depends on ILogger: ( Less Tight Coupling ) 
         * Game ---> ILogger <--- Logger
         * 
         * If Game depends on Logger:  ( Higher Coupling ) 
         * Game ---> Logger ---> Console ---> ILogger */
        
        var game = new Game(logger); 
        game.Start();
    }
}
