namespace Examkata;

class Program
{
    static void Main(string[] args)
    {
        // Usually I'd make separate class files, constructors, etc
        int charHealth = 100;
        int charAttack = 15;
        int charHeal = 20;
        
        int goblinHealth = charHealth - 50;
        int goblinAttack = charAttack - 5;

        string userInput = "";
        bool isGameOver = false;
        bool isValidInput = false;
        
        void Attack() {
            Console.WriteLine("Hero attacks the Goblin!\n" + 
                              $"Goblin takes {charAttack} damage!\n\n" +
                              "Goblin attacks the Hero!\n" +
                              $"Hero takes {goblinAttack} damage!\n\n" +
                              "\x1b[92mPress to continue ...\x1b[39m");
            charHealth -= goblinAttack;
            goblinHealth -= charAttack;
            Console.ReadLine();
        }
        void Heal() {
            Console.WriteLine($"Hero heals for \x1b[92m{charHeal}\x1b[39m points!\n" +
                              "\x1b[92mPress to continue ...\x1b[39m");
            charHealth += charHeal;
            Console.ReadLine();
        }

        void Pass() {
            Console.WriteLine($"Hero passed!" +
                              "Goblin attacks the Hero!\n" +
                              $"Hero takes {goblinAttack} damage!\n\n" +
                              "\x1b[92mPress to continue ...\x1b[39m");
            charHealth -= goblinAttack;
            Console.ReadLine();
        }
        while (!isGameOver) {
            Console.Clear();
            isValidInput = false;
            while (!isValidInput) {
                Console.WriteLine($"Player Health: \x1b[92m{charHealth}\x1b[39m\n" +
                              $"Goblin Health: \x1b[91m{goblinHealth}\x1b[39m\n" +
                              $"\nChoose Action:\n" +
                              $"1. Attack\n" +
                              $"2. Heal\n" +
                              $"3. Pass turn\n");
                userInput = Console.ReadLine()!;
                
                if (userInput == "1" || userInput == "2" || userInput == "3") {
                    isValidInput = true;
                } else {
                    Console.Clear(); Console.WriteLine("\x1b[91mInvalid choice!\x1b[39m\n");
                }
            }
            switch (userInput) {
                case "1":
                    Attack();
                    break;
                case "2":
                    Heal();
                    break;
                case "3":
                    Pass();
                    break;
            }

            if (charHealth <= 0) {
                Console.WriteLine("You lost to a goblin? Damn..");
                isGameOver = true;
            } else if (goblinHealth <= 0) {
                Console.WriteLine("You win! Easy target...");
                isGameOver = true;
            }
        }
    }
}