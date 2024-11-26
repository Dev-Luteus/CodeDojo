namespace ExamKata
{
    internal class Program
    {
        private static void Main()
        {
            ILogger logger = new Logger();
            EventSystem eventSystem = new EventSystem(logger);
            CharacterFactory characterFactory = new CharacterFactory(logger, eventSystem);
            TurnManager turnManager = new TurnManager(logger);
            
            Game.Start(logger, characterFactory, turnManager);
        }
    }
}
