namespace ExamKata
{
    public class Character
    {
        public event Action<string, int, int> HealthChanged;
        public event Action<string, int, int> ManaChanged;

        public List<IAbility> Abilities { get; }
        private readonly ILogger _logger;
        private readonly EventSystem _eventSystem;

        public string Name { get; set; }
        public string ClassType { get; private set; }
        public int Health { get; private set; }
        public int Amount { get; set; }
        public int Mana { get; private set; }
        public bool IsDefending { get; set; }
        public bool IsDefeated => Health <= 0; // True if health <= 0!! Really cool!!

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

        public bool UseAbility(int abilityIndex, Character target)
        {
            if (abilityIndex < 0 || abilityIndex >= Abilities.Count)
            {
                _logger.Log("Invalid ability index.");
                return false;
            }

            var ability = Abilities[abilityIndex];
            if (Mana < ability.ManaCost)
            {
                _logger.Log($"{Name} doesn't have enough mana to use this ability.");
                return false;
            }

            ChangeMana(-ability.ManaCost);
            ability.Use(this, target, _logger);
            return true;
        }

        public void ChangeHealth(int amount)
        {
            int oldHealth = Health;
            if (IsDefending && amount < 0)
            {
                amount /= 2;
                IsDefending = false;
                _logger.Log($"\n{Name} defended against the attack, reducing damage by half!\n" +
                            $"{Name} took {amount} damage! {Name} is no longer defending.\n");
            }
            Health = Math.Max(0, Health + amount);
            HealthChanged?.Invoke(Name, oldHealth, Health);
            _eventSystem.OnHealthChanged(this, oldHealth, Health);
        }

        public void ChangeMana(int amount)
        {
            int oldMana = Mana;
            Mana = Math.Max(0, Mana + amount);
            ManaChanged?.Invoke(Name, oldMana, Mana);
            _eventSystem.OnManaChanged(this, oldMana, Mana);
        }
    }
}
