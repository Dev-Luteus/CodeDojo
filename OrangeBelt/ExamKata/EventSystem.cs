namespace ExamKata
{
    public class EventSystem
    {
        private readonly ILogger _logger;

        public EventSystem(ILogger logger)
        {
            _logger = logger;
        }

        public void OnHealthChanged(Character character, int oldHealth, int newHealth)
        {
            _logger.Log($">> {character.Name}'s health changed from {oldHealth} to {newHealth}!");
            
            if (character.IsDefending && oldHealth > newHealth)
            {
                _logger.Log($">> {character.Name} defended and reduced the damage!");
            }
        }

        public void OnManaChanged(Character character, int oldMana, int newMana)
        {
            _logger.Log($">> {character.Name}'s mana changed from {oldMana} to {newMana}!");
        }
    }
}
