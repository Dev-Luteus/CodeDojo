using System.ComponentModel;

namespace ExamKata
{
    public static class Game
    {
        private static Player userChar;
        public static void StartGame()
        {
            userChar = InitialiseCharacter();
            var goblin = new Enemy("Goblin", 50, 50, 0, 10, 0);
            CombatSystem.StartCombat(userChar, goblin);
        }
        private static Player InitialiseCharacter()
        {
            var validName = PlayerNameValidator.GetValidPlayerName();
            return CharacterCreator.ChooseClass(validName);
        }
    }
}
// Console.WriteLine(userChar.Name);
// Console.WriteLine(userChar.Health);
// Console.WriteLine(userChar.Mana);
// Console.WriteLine(userChar.BaseDamage);
// Console.WriteLine(userChar.Armor);