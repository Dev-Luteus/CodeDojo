namespace ExamKata;

public class Player : Character, ICombatVariables
{
    public int MaxHealth { get; private set; }
    public int Health { get; set; }
    public int ExperiencePoints { get; set; }
    public int Mana { get; private set; }
    public int Armor { get; private set; }
    
    private readonly int _baseDamage;
    private readonly string _class;
    
    public int BaseDamage => _baseDamage;
    public string Class => _class;

    internal Player(string name, int maxHealth, int experiencePoints, int mana, int baseDamage, 
        int armor, string playerClass) : base(name)
    {
        MaxHealth = maxHealth;
        Health = maxHealth;
        ExperiencePoints = experiencePoints;
        Mana = mana;
        Armor = armor;
        _baseDamage = baseDamage;
        _class = playerClass;
    }
}