namespace ExamKata;

public abstract class Character
{
    private readonly string _name;
    public string Name => _name;
    
    protected Character(string name)
    {
        _name = name;
    }
}