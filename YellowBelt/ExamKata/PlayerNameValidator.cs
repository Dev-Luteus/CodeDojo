namespace ExamKata
{
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
                    
                    // Check if the player is satisfied with their chosen name
                    validHeroName = GoodNameValidator(username);
                    Console.Clear();

                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"\nError: {ex.Message}\n" +
                                      "\x1b[92mPress anything to continue..\x1b[39m");
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (!validHeroName);
            
            return username!;
        }
        
        // Moved the confirmation logic here
        private static bool GoodNameValidator(string username)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("You chose the name:\n" +
                                  $"\x1b[92m{username}\x1b[39m\n" +
                                  "\nAre you satisfied with this name? (Y/N)");
                string choice = Console.ReadLine()!.ToUpper();
                
                if (choice == "Y")
                {
                    return true;
                }
                else if (choice == "N")
                {
                    return false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\x1b[91m>> Invalid Choice! Please enter 'Y' or 'N' <<\x1b[39m\n");
                }
            }
        }
    }
    public static class NameValidator
    {
        public static void ValidatePlayerName(string? name)
        {
            if (string.IsNullOrWhiteSpace(name) || name.Length < 3)
            {
                throw new ArgumentException("Name must be: \n- At least 3 characters\n- Cannot be empty or have whitespace.", nameof(name));
            }
        }
    }
}
