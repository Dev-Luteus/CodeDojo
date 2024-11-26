using System.ComponentModel;

namespace ExamKata
{
    public static class Game
    {
        private static Player userChar;
        
        public static void StartGame()
        {
            userChar = InitialiseCharacter();
            
            // I could improve this definitely, but I am running out of time teehee
            var goblin = new Enemy("Goblin", 50, 50, 0, 10, 0);
            
            CombatSystem.StartCombat(userChar, goblin);
            Story.FirstAct();
            Story.SecondAct();
        }
        private static Player InitialiseCharacter()
        {
            var validName = PlayerNameValidator.GetValidPlayerName();
            
            return CharacterCreator.ChooseClass(validName);
        }
    }
}