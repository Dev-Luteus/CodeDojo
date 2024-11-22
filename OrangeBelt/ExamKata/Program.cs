namespace ExamKata;

internal abstract class Program
{
    private static void Main()
    {
        ILogger logger = new Logger();
        Game.Start(logger);
    }
}