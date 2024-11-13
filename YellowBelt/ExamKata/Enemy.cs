namespace ExamKata;

internal class Enemy : Character, ICombatVariables, ICombatMethods
{
    public int MaxHealth { get; private set; }
    public int Health { get; private set; }
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
    public void Attack()
    {
        
    }
    public void TakeDamage(int damageAmount)
    {
        Health = Math.Max(0, Health - damageAmount); 
    }
}