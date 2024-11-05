namespace Kata3;
class Program {
    static void Main(string[] args) 
    {
        bool isValidInput = false;
        string userInput = "";
        while (!isValidInput)
        {
            // I decided to use @ this time. Usually I do + "\n" in order to Align the strings
            Console.WriteLine(@"You find a mysterious treasure chest! What will you do?
1. Open the chest 
2. Ignore the chest
3. Leave the area");

            userInput = Console.ReadLine()!;
            if (userInput == "1" || userInput == "2" || userInput == "3")
            {
                isValidInput = true;
            } else
            {
                Console.WriteLine("\nPlease enter a valid option!");
            }
        }
    }
}