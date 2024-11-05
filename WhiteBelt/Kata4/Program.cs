namespace Kata4;
class Program {
    static void Main(string[] args) {
        for (int i = 0; i < 2; i++) {
            Console.WriteLine($"Wave [{i + 1}] is starting ...");
            for (int j = 0; j < 4; j++) {
                Console.WriteLine($"Enemy [{j + 1}] spawned!");
            }
            Console.WriteLine();
        }
        Console.WriteLine("All waves completed! Victory is yours!");
    }
}