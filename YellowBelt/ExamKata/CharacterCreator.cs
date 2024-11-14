namespace ExamKata
{
    public enum PlayerClass
    {
        PALADIN,
        SORCERER,
    }

    internal static class CharacterCreator
    {
        public static Player ChooseClass(string name)
        {
            string? choice = null;
            bool validHeroClass = false;

            do
            {   // I'm aware this WriteLine should not be hardcoded here.
                Console.WriteLine("\x1b[92mChoose your class!\x1b[39m\n" +
                                  "------------------\n" +
                                  "\x1b[93m> [A] Paladin <\x1b[39m\n" +
                                  "\x1b[94m> [B] Sorcerer <\x1b[39m");
                choice = Console.ReadLine().ToUpper();

                if (choice == "A" || choice == "B")
                {
                    validHeroClass = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\x1b[91m>> Invalid Choice! Please enter 'A' or 'B' <<\x1b[39m\n");
                }
            } 
            while (!validHeroClass);
            
            PlayerClass playerClass = choice switch
            {
                "A" => PlayerClass.PALADIN,
                "B" => PlayerClass.SORCERER,
                _ => throw new ArgumentException("Invalid class choice. Please choose A or B.")
            };
            
            Console.Clear();
            Console.WriteLine(playerClass == PlayerClass.PALADIN
                ? "\x1b[93mYou have chosen the path of the Paladin!\x1b[39m"
                : "\x1b[94mYou have chosen the path of the Sorcerer!\x1b[39m");
            
            return Create(name, playerClass);
        }
        private static Player Create(string name, PlayerClass playerClass)
        {
            return playerClass switch
            {
                PlayerClass.PALADIN => new Player(name, 150, 0,
                    20, 20, 20, "Knight"),
                
                PlayerClass.SORCERER => new Player(name, 80, 0,
                    100, 40, 10, "Mage"),
                
                _ => throw new ArgumentException("Invalid player class type.")
            };
        }
    }
}
