namespace ExamKata;

public interface ICombatVariables
{
    int Health { get; }
    int Mana { get; }
    int BaseDamage { get; }
    int Armor { get; }
}
public interface ICombatMethods
{
    void Attack();
    void TakeDamage(int damageAmount);
}