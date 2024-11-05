namespace Kata1;
class Program {
    static void Main() { // string args is Unnecessary
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
    }
}