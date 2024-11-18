namespace Level_1 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            var characters = new List<dynamic> 
            { 
                new Warrior("Abel", 80, () => Console.WriteLine($"Abel Attacks!")),
                new Warrior("Babel", 100, () => Console.WriteLine($"Babel Attacks!")),
                new Warrior("Zara", 40, () => Console.WriteLine($"Zara Attacks!")),
                new Healer("Eva", 50, chars => 
                {
                    var lowestWarrior = chars
                        .OrderBy(c => c.Health)
                        .First(c => c is Warrior);
                    Console.WriteLine($"Eva heals {lowestWarrior.Name}!");
                })
            };

            characters = characters.OrderBy(c => c.Health).ToList();

            characters.ForEach(character => 
            {
                Console.WriteLine($"{character.Name} | Health: {character.Health}");
                character.PrimaryAction(characters);
            });
        }

        class Warrior 
        {
            public string Name { get; set; }
            public int Health { get; set; }
            public Action<List<dynamic>> PrimaryAction { get; }

            public Warrior(string name, int health, Action primaryAction) 
            {
                Name = name;
                Health = health;
                PrimaryAction = _ => primaryAction();
            }
        }

        class Healer 
        {
            public string Name { get; set; }
            public int Health { get; set; }
            public Action<List<dynamic>> PrimaryAction { get; }

            public Healer(string name, int health, Action<List<dynamic>> primaryAction) 
            {
                Name = name;
                Health = health;
                PrimaryAction = primaryAction;
            }
        }
    }
}
