namespace ExamKata;

public interface IAbility
{
    void Use(Character user, Character target, ILogger logger);
}