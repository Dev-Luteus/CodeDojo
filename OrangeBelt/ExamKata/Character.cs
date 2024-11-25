namespace ExamKata
{
    public class Character
    {
        public event Action<string, int, int> HealthChanged;

        public List<IAbility> Abilities { get; }
        private readonly ILogger _logger;
        private readonly EventSystem _eventSystem;

        public string Name { get; set; }
        public string ClassType { get; private set; }
        public int Health { get; private set; }
        public int Amount { get; set; }
        public int Mana { get; private set; }
        public bool IsDefending { get; set; }
        public bool WasAttackedWhileDefending { get; private set; }

        public Character(string name, string classType, int health, int amount, int mana, List<IAbility> abilities, ILogger logger, EventSystem eventSystem)
        {
            Name = name;
            ClassType = classType;
            Health = health;
            Amount = amount;
            Mana = mana;
            Abilities = abilities;
            _logger = logger;
            _eventSystem = eventSystem;
        }

        public void UseAbility(int abilityIndex, Character target)
        {
            if (abilityIndex >= 0 && abilityIndex < Abilities.Count)
            {
                Abilities[abilityIndex].Use(this, target, _logger);
            }
            else
            {
                _logger.Log("Invalid ability index.");
            }
        }

        public void ChangeHealth(int amount)
        {
            int oldHealth = Health;
            if (IsDefending && amount < 0)
            {
                amount /= 2;
                WasAttackedWhileDefending = true;
            }
            Health += amount;
            HealthChanged?.Invoke(Name, oldHealth, Health);
            _eventSystem.OnHealthChanged(this, oldHealth, Health);
        }

        public void ResetDefending()
        {
            if (IsDefending && WasAttackedWhileDefending)
            {
                IsDefending = false;
                WasAttackedWhileDefending = false;
                _logger.Log($"{Name} is no longer defending after being attacked.");
            }
        }
    }
}
