class WhiteBelt {
    static void Main() {
        WhiteBelt program = new WhiteBelt();
        program.Run();
    }
    private void Run() {
        bool exitProgram = false;
        while (!exitProgram) {
            Console.WriteLine("Hello User! Choose program to run!\n" +
                          "\x1b[92m[1]\x1b[39m Kata1\n" +
                          "\x1b[92m[2]\x1b[39m Mini-Kata1\n" +
                          "\x1b[92m[3]\x1b[39m Mini-Kata2\n" +
                          "\x1b[92m[4]\x1b[39m Mini-Kata3\n" +
                          "\x1b[92m[5]\x1b[39m Kata2\n" +
                          "\x1b[91m[Q]\x1b[39m Exit Program");
            
            string userChoice = Console.ReadLine()!.ToUpper();
            switch (userChoice) {
                case "1": Kata1(); break;
                case "2": MiniKata1(); break;
                case "3": MiniKata2(); break;
                case "4": MiniKata3(); break;
                case "5": Kata2(); break;
                case "Q": exitProgram = true; break;
                default:
                    Console.Clear();
                    Console.WriteLine("\x1b[91mInvalid input!\x1b[39m\n");
                    break;
            }
        }
    }
    private void GoBack() {
        Console.Clear();
        Console.WriteLine("\x1b[92mPress anything to go back to Main Menu..\x1b[39m");
        Console.ReadLine();
    }
    private void Kata1() {
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
        Console.WriteLine("boop");
    }
    private void MiniKata2() {
        Console.WriteLine("baap");
    }
    private void MiniKata3() {
        Console.WriteLine("beep");
    }
    private void Kata2() {
        Console.WriteLine("Zoom");
    }
}