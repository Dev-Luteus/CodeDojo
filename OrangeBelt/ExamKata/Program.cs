namespace ExamKata;

internal abstract class Program
{
    private static void Main()
    {
        ILogger logger = new Logger();
        EventSystem eventSystem = new EventSystem();
        CharacterManager characterManager = new CharacterManager(logger, eventSystem);
        
        Game.Start(logger, characterManager);
    }
}