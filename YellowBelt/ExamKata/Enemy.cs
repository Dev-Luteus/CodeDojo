namespace ExamKata;

public class Enemy : Character, ICombatVariables
{
    public int MaxHealth { get; private set; }
    public int Health { get; set; }
    public int Mana { get; }
    public int BaseDamage { get; }
    public int Armor { get; }
    
    public Enemy(string type, int health, int maxHealth, int mana, int baseDamage, int armor) : base(type)
    {
        MaxHealth = maxHealth;
        Health = maxHealth;
        Mana = mana;
        BaseDamage = baseDamage;
        Armor = armor;
    }
}