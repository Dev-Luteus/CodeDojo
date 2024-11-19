namespace Level_1;

public abstract class Character
{
    public string Name { get; private set; }
    public int Health { get; protected set; }
    public Action<Character, List<Character>> PrimaryAction { get; protected set; }
    protected Character(string name, int health)
    {
        Name = name;
        Health = health;
    }
    public void ExecutePrimaryAction(List<Character> characters)
    {
        PrimaryAction?.Invoke(this, characters);
    }
}
public class Warrior : Character
{
    public Warrior(string name, int health, WarriorRole role) 
        : base(name, health)
    {
        PrimaryAction = role.AttackAction;
    }
}

public class Healer : Character
{
    private HealerRole _role;

    public Healer(string name, int health, HealerRole role) 
        : base(name, health)
    {
        _role = role;
        PrimaryAction = role.HealAction;
    }

    public void AnnouncePriority(List<Character> characters)
    {
        _role.AnnouncePriority(this, characters);
    }
}

