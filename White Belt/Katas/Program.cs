using System.Diagnostics;
using System.Threading.Channels;

class WhiteBelt {
    static void Main() {
        WhiteBelt program = new WhiteBelt();
        program.Run();
    }
    private void Run() {
        bool exitProgram = false;
        while (!exitProgram) {
            Console.WriteLine("Hello User! This is the\x1b[94m WhiteBelt\x1b[39m\n" +
                              "Choose program to run!\n" +
                              "-----------------------\n" +
                              "\x1b[92m[1]\x1b[39m Kata1\n" +
                              "\x1b[92m[2]\x1b[39m Mini-Kata1\n" +
                              "\x1b[92m[3]\x1b[39m Mini-Kata2\n" +
                              "\x1b[92m[4]\x1b[39m Mini-Kata3\n" +
                              "\x1b[92m[5]\x1b[39m Kata2\n" +
                              "\x1b[92m[6]\x1b[39m Mini-Kata4\n" +
                              "\x1b[92m[7]\x1b[39m Kata3\n" +
                              "\x1b[92m[8]\x1b[39m Kata4\n" +
                              "\x1b[92m[9]\x1b[39m ExamKata\n" +
                              "\x1b[91m[Q]\x1b[39m Exit Program");
            
            string userChoice = Console.ReadLine()!.ToUpper();
            switch (userChoice) {
                case "1": Kata1(); break;
                case "2": MiniKata1(); break;
                case "3": MiniKata2(); break;
                case "4": MiniKata3(); break;
                case "5": Kata2(); break;
                case "6": MiniKata4(); break;
                case "7": Kata3(); break;
                case "8": Kata4(); break;
                case "9": ExamKata(); break;
                case "Q": exitProgram = true; break;
                default:
                    Console.Clear();
                    Console.WriteLine("\x1b[91mInvalid input!\x1b[39m\n");
                    break;
            }
        }
    }
    private void Start() { Console.Clear(); }
    private void GoBack() {
        Console.WriteLine("\n\x1b[92m> Completed! <\x1b[39m\n" +
                          "\x1b[92m> Press anything to go back to Main Menu.. <\x1b[39m");
        Console.ReadLine(); Console.Clear();
    }
    private void Kata1() {
        Start();
        Console.WriteLine("Welcome\x1b[92m user\x1b[39m, whats your name? ");
        string name = Console.ReadLine()!;
        
        Console.WriteLine($"Welcome\x1b[92m {name}\x1b[39m!\n" +
                          "Rate your overall user experience from 1-10\n");

        int satisfaction;
        while(!int.TryParse(Console.ReadLine(), out satisfaction)) {
            Console.Clear();
            Console.WriteLine("\x1b[91mPlease enter a valid integer!\x1b[39m\n" +
                              "Rate your overall experience from 1-10\n");
        } 
        Console.WriteLine(satisfaction >= 7 ? "Okay, not bad! Good luck!" : "Ouch! Good luck!");
        GoBack();
    }
    private void MiniKata1() {
        Start();
        string charName = "Arin";
        int charHealth = 100;
        float attackPower = 15.5f;
        bool isParalyzed = true;
        double goldCoins = 24.75;
        Console.WriteLine($"Character Name: {charName}\n" +
                          $"Health Points: {charHealth}\n" +
                          $"Attack Power: {attackPower}\n" +
                          $"Is Paralyzed: {isParalyzed}\n" +
                          $"Gold Coins: {goldCoins}");
        GoBack();
    }
    private void MiniKata2() {
        Start();
        string name = "Arin";
        string goldString = "150,333333";
        int healthPoints = 100;
        float attackPower = 30f;
        float experiencePoints = 250f;
        bool isParalyzed = false;
        double currencyAmount = 150;

        double charHealth = healthPoints;
        attackPower = (int)attackPower;
        Convert.ToInt32(experiencePoints);
        Double.Parse(goldString);
        
        bool isNameParsed = int.TryParse(name, out int result);
        if (isNameParsed == false) { name = "Parsing failed: name is not a number."; }
        
        Console.WriteLine($"Health: {charHealth}\n" +
                          $"Attack Power: {attackPower}\n" +
                          $"Experience Points: {experiencePoints}\n" +
                          $"Gold Coins: {goldString}\n" +
                          $"Name: {name}");
        GoBack();
    }
    private void MiniKata3() {
        Start();
        Random random = new Random();
        int playerLuck = random.Next(1, 11);
        bool isAcceptedInput = false;
        
        while (!isAcceptedInput) {
            Console.WriteLine("You encounter an enemy! Do you want to attempt an attack? (yes/no)");
            string userInput = Console.ReadLine()!.ToLower();
            
            if (userInput == "yes") {
                Console.WriteLine("Attempting to attack ...");
                
                // Attempting to not use if/else if/else statement
                string attackResult = playerLuck switch {
                    > 7 => "Success! You hit the enemy",
                    6 => "Success! You barely hit! You try to steel your focus",
                    _ => "Fail! You brace for impact"
                };
                Console.WriteLine(attackResult);
                isAcceptedInput = true;
            } else if (userInput == "no") {
                Console.WriteLine("You retreat! ...");
                isAcceptedInput = true;
            } else {
                Console.WriteLine("\nPlease enter a valid option!");
            }
        }
        GoBack();
    }
    private void Kata2() {
        Start();
        string name = "Lira";
        int level = 5;
        float health = 75.5f;
        double experience = 1025.75;
        bool hasMagicAbility = true;
        char rank = 'A';

        double nextLevelThreshHold = 1200;
        double pointsToNextLevel = nextLevelThreshHold - experience;
        Console.WriteLine($"Name: {name}\n" +
                          $"Level: {level}\n" +
                          $"Health: {health}\n" +
                          $"Experience Points: {health}\n" +
                          $"Has Magic Ability: {hasMagicAbility}\n" +
                          $"Rank: {rank}\n" +
                          $"Points needed for next level: {pointsToNextLevel}");
        GoBack();
    }
    private void MiniKata4() {
        Start();
        int maxEnemies = 3;
        int enemiesSpawned = 0;
        
        Console.WriteLine("For Loop: ");
        for (int i = 0; i < 5; i++) {
            Console.WriteLine($"Enemy [{i + 1}] spawned!");
        }
        Console.WriteLine("\nWhile Loop:");
        while (enemiesSpawned < maxEnemies) {
            Console.WriteLine($"Enemy [{enemiesSpawned + 1}] spawned!");
            enemiesSpawned++;
        }
        GoBack();
    }
    private void Kata3() {
        Start(); 
        bool isValidInput = false;
        string userInput = "";
        while (!isValidInput) {
            // I decided to use @ this time. Usually I do + "\n" in order to Align the strings
            Console.WriteLine(@"You find a mysterious treasure chest! What will you do?
1. Open the chest 
2. Ignore the chest
3. Leave the area");

            userInput = Console.ReadLine();
            if (userInput == "1" || userInput == "2" || userInput == "3") {
                isValidInput = true;
            } else {
                Console.WriteLine("\nPlease enter a valid option!");
            }
        }

        string userChoice = userInput switch {
            "1" => "Success! You're rich! Just kidding, it was a mimic. \x1b[91mYou died.\x1b[39m",
            "2" => "You ignore the chest.",
            "3" => "With suspicion, you leave the area..",
            _ => "Invalid choice!" // this won't trigger
        };
        Console.WriteLine(userChoice);
        GoBack();
    }
    private void Kata4() {
        Start();
        for (int i = 0; i < 2; i++) {
            Console.WriteLine($"Wave [{i + 1}] is starting ...");
            for (int j = 0; j < 4; j++) {
                Console.WriteLine($"Enemy [{j + 1}] spawned!");
            }
            Console.WriteLine();
        }
        Console.WriteLine("All waves completed! Victory is yours!");
        GoBack();
    }
    private void ExamKata() {
        Start();
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
            Start();
            isValidInput = false;
            while (!isValidInput) {
                Console.WriteLine($"Player Health: \x1b[92m{charHealth}\x1b[39m\n" +
                              $"Goblin Health: \x1b[91m{goblinHealth}\x1b[39m\n" +
                              $"\nChoose Action:\n" +
                              $"1. Attack\n" +
                              $"2. Heal\n" +
                              $"3. Pass turn\n");
                userInput = Console.ReadLine();
                
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
        GoBack();
    }
}