using System.Data.Common;

namespace Kata10
{
    class Program
    {
        static void Main(string[] args)
        {
            var validName = PlayerNameValidator.GetValidPlayerName();
            var userChar = new Player(validName, 100, 1);

            Console.WriteLine($"User Name: {userChar.Name}\n" +
                              $"User Health: {userChar.Health}\n" +
                              $"User Level: {userChar.Level}\n");

            var goblin = new Enemy("Goblin", 50, 10); // does not need damage
            Console.WriteLine($"Enemy Type: {goblin.Name}\n" +
                              $"Enemy Health: {goblin.Health}\n" +
                              $"Enemy Damage: {goblin.Damage}");

            var edgard = new NPC("Edgard");
            Console.WriteLine("\nNPC Name: " + edgard.Name);
            
            var merchantEve = new Merchant("Eve", new List<string>() {"Sword", "Shield", "Health Potion"});
            Console.WriteLine("\nMerchant Name: " + merchantEve.Name);
            Console.WriteLine("\nPress anything to continue...");
            Console.ReadLine();
            Console.Clear();
            
            // I am being very lazy now
            Console.WriteLine("Goblin Current Health: " + goblin.Health);
            userChar.Attack(goblin, 20);
            Console.WriteLine("Goblin Remaining Health: " + goblin.Health);
            userChar.Attack(goblin, 20);
            Console.WriteLine("Goblin Current Health: " + goblin.Health);

            edgard.Speak("Your code is bad!");
            merchantEve.Trade();
        }
    }
    public static class PlayerNameValidator
    {
        public static string GetValidPlayerName()
        {
            bool validHeroName = false;
            string? username = null;

            do
            {
                try
                {
                    Console.WriteLine("Hello Hero! Please enter your username: ");
                    username = Console.ReadLine();

                    NameValidator.ValidatePlayerName(username);

                    validHeroName = true;
                    return username!;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"\nError: {ex.Message}\n" +
                                      "\x1b[92mPress anything to continue..\x1b[39m");
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (!validHeroName);

            return string.Empty;
        }
    }
    public static class NameValidator
    {
        public static void ValidatePlayerName(string name)
        {
            if (string.IsNullOrWhiteSpace(name) || name.Length < 2)
            {
                throw new ArgumentException("Name must be: \n- At least 2 characters\n- Cannot be empty or have whitespace.", nameof(name));
            }
        }
    }
    public interface IName
    {
        string Name { get; }
    }
    public abstract class Character : IName
    {
        private string _name;
        public string Name
        {
            get => _name;
            protected set
            {
                NameValidator.ValidatePlayerName(value);
                _name = value;
            }
        }
        protected Character(string name)
        {
            Name = name;
        }
    }
    public interface IDoubleInt
    {
        int Health { get; }
        int Int2 { get; }
    }
    internal class Player : Character, IDoubleInt
    {
        public int Health { get; set; }
        public int Level { get; set; }
        
        int IDoubleInt.Int2 => Level;

        public Player(string name, int health, int level) : base(name)
        {
            Health = health;
            Level = level;
        }
        public void Attack(Enemy enemyTarget, int damage)
        {
            Console.WriteLine($"{this.Name} attacks {enemyTarget.Name} for {damage} damage!");
            enemyTarget.TakeDamage(damage);
        }
    }
    internal class Enemy : Character, IDoubleInt
    {
        public string Type => Name;
        public int Health { get; set; }
        public int Damage { get; set; }

        int IDoubleInt.Int2 => Damage;
        public Enemy(string type, int health, int damage) : base(type)
        {
            Health = health;
            Damage = damage;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }
    }
    internal class NPC : Character
    {   // Could have "dialogue" get set string, but not needed
        public NPC(string name) : base(name) { }
        public void Speak(string dialogueString)
        {
            Console.Write("\n" + Name + ": " + dialogueString);
        }
    }
    internal class Merchant : Character
    {
        private List<string> Inventory { get; set; }
        public Merchant(string name, List<string> inventory) : base(name)
        {
            Inventory = inventory;
        }
        public void Trade()
        {
            Console.Write($"\n{Name}'s Inventory: ");
            foreach (var itemName in Inventory)
            {
                Console.Write(itemName + " ");
            }
        }
    }
}
