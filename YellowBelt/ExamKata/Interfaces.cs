namespace ExamKata;

public interface ICombatVariables
{
    int Health { get; }
    int Mana { get; }
    int BaseDamage { get; }
    int Armor { get; }
}
public interface INPC
{
    string Type { get; }
    
    void Speak(string text);
}