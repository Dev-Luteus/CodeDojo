namespace ExamKata;

internal class Player : Character, ICombatVariables, ICombatMethods
{
    public int MaxHealth { get; private set; }
    public int Health { get; private set; }
    public int Mana { get; private set; }
    public int Armor { get; private set; }
    
    private readonly int _baseDamage;
    private readonly string _class;
    
    public int BaseDamage => _baseDamage;
    public string Class => _class;

    internal Player(string name, int maxHealth, int mana, int baseDamage, 
        int armor, string playerClass) : base(name)
    {
        MaxHealth = maxHealth;
        Health = maxHealth;
        Mana = mana;
        Armor = armor;
        _baseDamage = baseDamage;
        _class = playerClass;
    }
    public void TakeDamage(int damageAmount)
    {
        Health = Math.Max(0, Health - damageAmount); 
    }
    public void Heal(int healingAmount)
    {
        Health = Math.Min(MaxHealth, Health + healingAmount);
    }
    public void Attack()
    {
        // Attack logic
    }
    public void Heal() 
    {
        // Heal logic
    }
}
