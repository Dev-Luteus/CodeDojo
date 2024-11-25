namespace ExamKata
{
    internal class Program
    {
        private static void Main()
        {
            ILogger logger = new Logger();
            EventSystem eventSystem = new EventSystem(logger);
            CharacterManager characterManager = new CharacterManager(logger, eventSystem);
            TurnManager turnManager = new TurnManager(logger);
            Game.Start(logger, characterManager, turnManager);
        }
    }
}
