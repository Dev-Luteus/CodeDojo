namespace Kata8;

class Program
{
    static void Main(string[] args)
    {
        Player player = new();
        player.GainExperience(-100);
        player.GainExperience(200);
    }
}

class Player
{
    private int _health;
    private int _level;
    private int _experience;
    
    // These public properties are Redundant atm, but, I will leave them here anyway for demonstration.
    public int Health {
        get => _health;
        private set => _health = value;
    }
    public int Level {
        get => _level;
        private set => _level = value;
    }
    public int Experience {
        get => _experience;
        private set => _experience = value;
    }
    /* Instead of setting experience to 0, I decided to do a while loop so that overflowed XP is stored,
     * and the player levels up after every 100 XP */
    public void GainExperience(int experience)
    {
        if (experience <= 0)
        {
            Console.WriteLine("Experience cannot be less or equal to zero!");
            return;
        }
        
        experience = Math.Clamp(experience, 0, int.MaxValue);
        
        _experience += experience;
        Console.WriteLine($"Player gains {experience} experience!");
        while (_experience >= 100)
        {
            LevelUp();
            Console.WriteLine($"\nCurrent experience: {_experience}");
        }
    }
    private void LevelUp()
    {
        Console.Write($"\nLevel Up! {_level} -> ");
        _level++;
        Console.Write($"{_level}");
        _experience -= 100;
    }
}