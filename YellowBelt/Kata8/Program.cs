namespace Kata8;

class Program
{
    static void Main(string[] args)
    {
        Player player = new();
        player.GainExperience(200);
    }
}

class Player
{
    private int health;
    private int level;
    private int experience;

    public int Health {
        get => health;
        private set => health = value;
    }
    public int Level {
        get => level;
        private set => level = value;
    }
    public int Experience {
        get => experience;
        private set => experience = value;
    }
    /* Instead of setting experience to 0, I decided to do a while loop so that overflowed XP is stored,
     * and the player levels up after every 100 XP */
    public void GainExperience(int experience)
    {
        this.experience += experience;
        Console.WriteLine($"Player gains {experience} experience!");
        while (this.experience >= 100)
        {
            LevelUp();
            Console.WriteLine($"\nCurrent experience: {this.experience}");
        }
    }
    private void LevelUp()
    {
        Console.Write($"\nLevel Up! {level} -> ");
        level++;
        Console.Write($"{level}");
        experience -= 100;
    }
}