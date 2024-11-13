namespace ExamKata;

public enum PlayerClass
{
    Paladin,
    Sorcerer,
}
internal static class CharacterCreator
{
    public static Player Create(string name, PlayerClass playerClass)
    {
        return playerClass switch
        {
            PlayerClass.Paladin => new Player(name, 150, 20, 10, 20, "Knight"),
            PlayerClass.Sorcerer => new Player(name, 80, 100, 20, 10, "Mage"),
            _ => throw new ArgumentException("Invalid player class type.")
        };
    }
}
