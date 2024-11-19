// namespace Level_1 
// {
//     public class AbstractProgram
//     {
//         static void Mains(string[] args) 
//         {
//             var characters = new List<Character> 
//             {
//                 new Warrior("Abel", 80),
//                 new Healer("Mara", 50),
//                 new Warrior("Babel", 60),
//                 new Warrior("Cara", 70)
//             };
//             
//             Console.WriteLine("\x1b[92mStarting actions based on character health...\x1b[39m\n");
//             var lowHealthCharacters = characters.Where(c => c.Health < 50);
//             
//             Console.WriteLine("Characters attacking first (health < 50):");
//             foreach (var character in lowHealthCharacters)
//             {
//                 Console.WriteLine($"{character.Name} is attacking first due to low health! Health: {character.Health}");
//             }
//             Console.WriteLine();
//             
//             var healers = characters.OfType<Healer>();
//             foreach (var healer in healers)
//             {
//                 healer.AnnouncePriority(characters);
//             }
//             Console.WriteLine();
//             
//             Console.WriteLine("Additional character actions based on role:");
//             characters.OrderBy(c => c.Health)
//                      .ToList()
//                      .ForEach(c => c.ExecutePrimaryAction(characters));
//         }
//     }
//
//     public abstract class Character
//     {
//         public string Name { get; private set; }
//         public int Health { get; protected set; }
//
//         protected Character(string name, int health)
//         {
//             Name = name;
//             Health = health;
//         }
//         public abstract void ExecutePrimaryAction(List<Character> characters);
//     }
//
//     public class Warrior : Character
//     {
//         private readonly WarriorRole _role;
//
//         public Warrior(string name, int health) 
//             : base(name, health)
//         {
//             _role = new WarriorRole();
//         }
//
//         public override void ExecutePrimaryAction(List<Character> characters)
//         {
//             _role.ExecuteAction(this, characters);
//         }
//     }
//
//     public class Healer : Character
//     {
//         private readonly HealerRole _role;
//
//         public Healer(string name, int health) 
//             : base(name, health)
//         {
//             _role = new HealerRole();
//         }
//
//         public override void ExecutePrimaryAction(List<Character> characters)
//         {
//             _role.ExecuteAction(this, characters);
//         }
//
//         public void AnnouncePriority(List<Character> characters)
//         {
//             _role.AnnouncePriority(this, characters);
//         }
//     }
//     
//     internal interface ICharacterRole
//     {
//         void ExecuteAction(Character character, List<Character> characters);
//     }
//     
//     internal class WarriorRole : ICharacterRole
//     {
//         public void ExecuteAction(Character character, List<Character> characters)
//         {
//             Console.WriteLine($"{character.Name} is standing by with health: {character.Health}");
//             Attack(character);
//         }
//
//         private void Attack(Character character)
//         {
//             Console.WriteLine($"{character.Name} charges with a fierce attack!");
//         }
//     }
//     
//     internal class HealerRole : ICharacterRole
//     {
//         public void ExecuteAction(Character character, List<Character> characters)
//         {
//             var targetToHeal = FindLowestHealthWarrior(characters);
//             Heal(character, targetToHeal);
//         }
//
//         public void AnnouncePriority(Character character, List<Character> characters)
//         {
//             var targetToHeal = FindLowestHealthWarrior(characters);
//             Console.WriteLine($"{character.Name} is prioritizing healing for {targetToHeal.Name} who has the lowest health.");
//         }
//
//         private void Heal(Character healer, Character target)
//         {
//             Console.WriteLine($"{healer.Name} is healing {target.Name} with a powerful healing spell!");
//         }
//
//         private Character FindLowestHealthWarrior(List<Character> characters)
//         {
//             return characters
//                 .OfType<Warrior>()
//                 .OrderBy(c => c.Health)
//                 .First();
//         }
//     }
// }